using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

namespace WinFormsApp1.Classes
{
    internal class Authentication
    {
        public void userSignUp(string userNameField, string lastNameField,string emailField, string phoneField, string passwordField)
        {
            if (string.IsNullOrWhiteSpace(userNameField))
            {
                MessageBox.Show("First name is required.", "Input Error");
                return;
            }
            if (string.IsNullOrWhiteSpace(emailField))
            {
                MessageBox.Show("email is required.", "Input Error");
                return;
            }
            if (!Regex.IsMatch(emailField, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.", "Input Error");
                return;
            }
            if (string.IsNullOrWhiteSpace(phoneField))
            {
                MessageBox.Show("phone number is required.", "Input Error");
                return;
            }
            if (string.IsNullOrWhiteSpace(passwordField))
            {
                MessageBox.Show("password is required.", "Input Error");
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            string query = "INSERT INTO users (fname, lname, email, phone, pass) VALUES (@fname, @lname, @email, @phone, @pass)";

            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);

                sqlCommand.Parameters.AddWithValue("@fname", userNameField);
                sqlCommand.Parameters.AddWithValue("@lname", lastNameField);
                sqlCommand.Parameters.AddWithValue("@email", emailField);
                sqlCommand.Parameters.AddWithValue("@phone", phoneField);
                sqlCommand.Parameters.AddWithValue("@pass", passwordField);

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("User added successfully!", "Success");
            }

            catch (SqlException ex)
            {
                if (ex.Number == 2627 && ex.Message.Contains("email"))
                {
                    MessageBox.Show("This email is already registered.", "Constraint Error");
                }
                else
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error");
                }
            }
        }

        public void Login(string loginEmailField, string loginPassField)
        {
            if (string.IsNullOrEmpty(loginEmailField))
            {
                MessageBox.Show("email is required.", "Input Error");
                return;
            }
            if (string.IsNullOrEmpty(loginPassField))
            {
                MessageBox.Show("password is required", "Input Error");
                return;
            }
            if (!Regex.IsMatch(loginEmailField, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.", "Input Error");
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            string userQuery = "SELECT COUNT(*) FROM users WHERE email = @email AND pass = @Pass";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand sqlCommand = new SqlCommand(userQuery, connection);
            sqlCommand.Parameters.AddWithValue("@email", loginEmailField);
            sqlCommand.Parameters.AddWithValue("@pass", loginPassField);

            int userCount = (int)sqlCommand.ExecuteScalar();
            if (userCount == 1)
            {
                MessageBox.Show("User login successful with id = " + getUserId(loginEmailField));
                return;
            }
            MessageBox.Show("Invalid email or password.");

        }

        private int getUserId(string emailField)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            string userQuery = "SELECT id FROM users WHERE email = @email";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(userQuery, connection);
            sqlCommand.Parameters.AddWithValue("@email", emailField);
            int userId = (int)sqlCommand.ExecuteScalar();
            return userId;
        }
    }
}
