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
    public partial class Profile : Form
    {
        private string userId;
        public Profile(string Id)
        {
            InitializeComponent();
            Submit_btn.Visible = false;
            FullName.ReadOnly = true;
            Email.ReadOnly = true;
            Phone_Number.ReadOnly = true;
            this.userId = Id;
            LoadUserData();
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            Submit_btn.Visible = true;
            FullName.ReadOnly = false;
            Email.ReadOnly = false;
            Phone_Number.ReadOnly = false;
            FullName.Enabled = true;
            Email.Enabled = true;
            Phone_Number.Enabled = true;

        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            Submit_btn.Visible = false;
            FullName.ReadOnly = true;
            Email.ReadOnly = true;
            Phone_Number.ReadOnly = true;
            FullName.Enabled = false;
            Email.Enabled = false;
            Phone_Number.Enabled = false;

            string connectionString = "Server=DESKTOP-HLH7URN;Database=transportation;Trusted_Connection=True;Encrypt=False;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "UPDATE users SET fname = @fname, email = @Email, phone = @phone WHERE id = @userId";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@fname", FullName.Text);
                    command.Parameters.AddWithValue("@Email", Email.Text);
                    command.Parameters.AddWithValue("@phone", Phone_Number.Text);
                    command.Parameters.AddWithValue("@userId", userId);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Profile updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No changes were made.");
                    }
                }
            }
        }


        private void LoadUserData()
        {
            string connectionString = "Server=DESKTOP-HLH7URN;Database=transportation;Trusted_Connection=True;Encrypt=False;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT fname, email, phone FROM users WHERE id = @userId";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            FullName.Text = reader["fname"].ToString();
                            Email.Text = reader["email"].ToString();
                            Phone_Number.Text = reader["phone"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("User not found.");
                        }
                    }
                }
            }
        }
    }
}
