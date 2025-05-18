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
using Microsoft.VisualBasic.ApplicationServices;

namespace Transportation_App.Views
{
   
    public partial class Checkout : Form
    {
        private string rideId;
        private string userId;
        private int fees;
        public Checkout(string uid, string rid)
        {
            InitializeComponent();
            Random rand = new Random();
            fees = rand.Next(40, 400);
            Fees_Lable.Text = fees.ToString();
            this.userId = uid;
            this.rideId = rid;

        }

        private void Checkout_btn_Click(object sender, EventArgs e)
        {
            string method = Payment_Method.Text;

            if (string.IsNullOrWhiteSpace(method))
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            string connectionString = "Server=DESKTOP-HLH7URN;Database=transportation;Trusted_Connection=True;Encrypt=False;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO payment (rideId, userId, rideFees, paymentMethod)
                       VALUES (@rideId, @userId, @rideFees, @paymentMethod);";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@rideId", rideId);
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@rideFees", fees);
                    command.Parameters.AddWithValue("@paymentMethod", method);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Payment recorded successfully.");
                        this.Close(); // Optionally close the checkout form
                    }
                    else
                    {
                        MessageBox.Show("Failed to record payment.");
                    }
                }
            }
        }
    }
}
