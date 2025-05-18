using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class FeedbackForm : Form
    {
        private int rideId;

        public FeedbackForm(int rideId)
        {
            InitializeComponent();
            this.rideId = rideId;
            if (txtCommentComboBox.Items.Count == 0)
            {
                txtCommentComboBox.Items.AddRange(new object[] { 1, 2, 3, 4, 5 });
            }
            MessageBox.Show($"FeedbackForm opened with Ride ID: {rideId}");
        }

        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //}

        private void FeedbackForm_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {

            try
            {
                string feedback = txtName.Text.Trim();
                if (string.IsNullOrEmpty(feedback))
                {
                    MessageBox.Show("Feedback is empty. Please enter feedback.");
                    return;
                }

                if (txtCommentComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a score.");
                    return;
                }
                int score;
                if (!int.TryParse(txtCommentComboBox.SelectedItem.ToString(), out score))
                {
                    MessageBox.Show("Invalid score value.");
                    return;
                }

                if (rideId <= 0)
                {
                    MessageBox.Show("Invalid ride ID.");
                    return;
                }

                MessageBox.Show($"About to update: Feedback = '{feedback}', Score = {score}, Ride ID = {rideId}");

                string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
                string sqlQuery = @"UPDATE ride SET feedback = @Feedback, score = @Score WHERE id = @RideId";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Feedback", feedback);
                        cmd.Parameters.AddWithValue("@Score", score);
                        cmd.Parameters.AddWithValue("@RideId", rideId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show($"Rows affected: {rowsAffected}");
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Feedback and score saved successfully!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No ride found with the given ID or update failed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in FeedbackForm: {ex.Message}\nStack Trace: {ex.StackTrace}");
            }

        }
    }
}