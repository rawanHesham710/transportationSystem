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
using System.Text.RegularExpressions;
using System.Configuration;

namespace db_assign
{
    public partial class driverForm : Form
    {
        public driverForm()
        {
            InitializeComponent();
        }

        private void sebmit_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(name.Text) ||
                string.IsNullOrWhiteSpace(email.Text) ||
                string.IsNullOrWhiteSpace(phone.Text) ||
                string.IsNullOrWhiteSpace(password.Text) ||
                string.IsNullOrWhiteSpace(license.Text) ||
                string.IsNullOrWhiteSpace(color.Text) ||
                string.IsNullOrWhiteSpace(model.Text) ||
                string.IsNullOrWhiteSpace(type.Text) ||
                string.IsNullOrWhiteSpace(capacity.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Email regex validation
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email.Text, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString; ;
            string sql = "INSERT INTO dbo.driver (name, email, phone, pass, licenseNo, carColor, model, type, capacity) VALUES (@name, @email, @phone, @password, @license, @color, @model, @type, @capacity)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@name", name.Text);
                command.Parameters.AddWithValue("@email", email.Text);
                command.Parameters.AddWithValue("@phone", phone.Text);
                command.Parameters.AddWithValue("@password", password.Text);
                command.Parameters.AddWithValue("@license", license.Text);
                command.Parameters.AddWithValue("@color", color.Text);
                command.Parameters.AddWithValue("@model", model.Text);
                command.Parameters.AddWithValue("@type", type.Text);
                command.Parameters.AddWithValue("@capacity", capacity.Text);
                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Signed up successfully!");
                    var driverLoginForm = new driverLogin();
                    driverLoginForm.Show();
                    this.Hide(); // Hide the current form
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
    }
}
