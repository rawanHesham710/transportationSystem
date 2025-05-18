using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace db_assign
{
    public partial class driverLogin : Form
    {
        public driverLogin()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(email.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Please enter both email and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int driverId = GetDriverId(email.Text, password.Text);
            if (driverId != 0)
            {
                MessageBox.Show($"Login successful! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private int GetDriverId(string email, string password)
        {
            string connectionString = "Data source = Roros-laptop;Initial catalog = transportation; Integrated security = True;TrustServerCertificate=True";
            string sql = "SELECT id FROM driver WHERE email = @Email AND pass = @Password";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int userId))
                        return userId;
                    else
                        return 0;
                }
                catch
                {
                    return 0;
                }
            }
        }

    }
}
