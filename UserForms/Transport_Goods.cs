using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Transportation_App.Views
{
    public partial class Transport_Goods : Form
    {
        private string userId;
        public Transport_Goods(string Id)
        {
            InitializeComponent();
            this.userId = Id;
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-HLH7URN;Database=transportation;Trusted_Connection=True;Encrypt=False;";
            int rideId = -1;

            TimeSpan startTime = DateTime.Now.TimeOfDay;
            TimeSpan endTime = startTime.Add(new TimeSpan(1, 0, 0));
            if (endTime.TotalHours >= 24)
            {
                endTime = endTime.Subtract(new TimeSpan(24, 0, 0));
            }
            // First insert into ride and get the new rideId
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO ride(destination, startAddress, startTime, endTime, userId, driverId) 
                       VALUES(@destination, @startAddress, @startTime, @endTime, @userId, 1);
                       SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@destination", DestinationBox.Text);
                    command.Parameters.AddWithValue("@startAddress", StartAdressBox.Text);
                    command.Parameters.AddWithValue("@startTime", startTime);
                    command.Parameters.AddWithValue("@endTime", endTime);
                    command.Parameters.AddWithValue("@userId", userId);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    connection.Close();

                    if (result != null && int.TryParse(result.ToString(), out rideId))
                    {
                        // Got ride ID
                    }
                    else
                    {
                        MessageBox.Show("Failed to get ride ID.");
                        return;
                    }
                }
            }

            // Now insert into goods using the rideId
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO goods(name, weight, size, userId, rideId) VALUES(@name, @weight, @size, @userId, @rideId)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@name", Name_TextBox.Text);
                    command.Parameters.AddWithValue("@weight", Weigh_Box.Text);
                    command.Parameters.AddWithValue("@size", Size_Box.Text);
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@rideId", rideId);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Transport request submitted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to submit goods.");
                    }
                }
            }
            Checkout PaymentForm = new Checkout("1","1");
            PaymentForm.Show();
            this.Close();
        }

    }
}
