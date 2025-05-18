using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class UserWelcome : Form
    {
        public UserWelcome()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userLoginForm loginForm = new userLoginForm();
            loginForm.Show();
            this.Hide();

        }

        private void UserSignupBtn_Click(object sender, EventArgs e)
        {
            userSignupForm userSignupForm = new userSignupForm();
            userSignupForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
