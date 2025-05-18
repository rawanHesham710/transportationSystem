using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class Ride : Form
    {
        public Ride()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

                TimeSpan tripDuration = CalculateTripDuration(txtstartAddress.Text, txtdestination.Text);
                TimeSpan startTime = TimeSpan.Parse(txtstartTime.Text);
                TimeSpan endTime = startTime.Add(tripDuration);

                int randomDriverId = GetRandomDriverId(connectionString);

                string sqlQuery = @"INSERT INTO ride 
            (destination, startAddress, startTime, endTime, feedback, score, userId, driverId) 
            VALUES 
            (@Destination, @StartAddress, @StartTime, @EndTime,@Feedback,@Score, @UserId, @DriverId);
            SELECT SCOPE_IDENTITY();";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                    {
                        var destinationParameter = new SqlParameter("@Destination", System.Data.SqlDbType.VarChar);
                        destinationParameter.Value = txtdestination.Text;
                        cmd.Parameters.Add(destinationParameter);

                        var startAddressParameter = new SqlParameter("@StartAddress", System.Data.SqlDbType.VarChar);
                        startAddressParameter.Value = txtstartAddress.Text;
                        cmd.Parameters.Add(startAddressParameter);

                        var startTimeParameter = new SqlParameter("@StartTime", System.Data.SqlDbType.Time);
                        startTimeParameter.Value = startTime;
                        cmd.Parameters.Add(startTimeParameter);

                        var endTimeParameter = new SqlParameter("@EndTime", System.Data.SqlDbType.Time);
                        endTimeParameter.Value = endTime;
                        cmd.Parameters.Add(endTimeParameter);

                        var userIdParameter = new SqlParameter("@UserId", System.Data.SqlDbType.Int);
                        userIdParameter.Value = int.Parse(txtuserId.Text);
                        cmd.Parameters.Add(userIdParameter);

                        var feedbackParameter = new SqlParameter("@Feedback", System.Data.SqlDbType.VarChar);
                        feedbackParameter.Value = " ";
                        cmd.Parameters.Add(feedbackParameter);

                        var scoreParameter = new SqlParameter("@Score", System.Data.SqlDbType.VarChar);
                        scoreParameter.Value = " ";
                        cmd.Parameters.Add(scoreParameter);

                        var driverIdParameter = new SqlParameter("@DriverId", System.Data.SqlDbType.Int);
                        driverIdParameter.Value = randomDriverId;
                        cmd.Parameters.Add(driverIdParameter);

                        object result = cmd.ExecuteScalar();
                        if (result == null || result == DBNull.Value)
                        {
                            MessageBox.Show("Failed to get ride ID.");
                            return;
                        }
                        int rideId = Convert.ToInt32(result);
                        MessageBox.Show($"Ride created successfully! Estimated arrival: {endTime.ToString(@"hh\:mm")} Ride ID: {rideId}");

                        FeedbackForm feedbackForm = new FeedbackForm(rideId);
                        feedbackForm.ShowDialog();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter time in correct format (HH:mm)");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private int GetRandomDriverId(string connectionString)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT TOP 1 id FROM driver ORDER BY NEWID()";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Ignore database errors and fall through to random number generation
            }

            Random random = new Random();
            return random.Next(1, 1001);
        }

        private TimeSpan CalculateTripDuration(string startAddress, string destination)
        {
            double distanceKm = EstimateDistance(startAddress, destination);
            double durationHours = distanceKm / 40.0;
            return TimeSpan.FromMinutes(Math.Max(durationHours * 60, 15));
        }

        private double EstimateDistance(string start, string end)
        {
            if (start.Contains("downtown") && end.Contains("airport"))
                return 25.0;
            else if (start.Contains("main") && end.Contains("center"))
                return 8.0;
            else
                return 15.0;
        }
    }
}
