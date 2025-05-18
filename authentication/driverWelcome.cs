using db_assign;
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
    public partial class driverWelcome : Form
    {
        public driverWelcome()
        {
            InitializeComponent();
        }

        private void DriverSignupBtn_Click(object sender, EventArgs e)
        {
            
            driverForm driverForm = new driverForm();
            driverForm.Show();
            this.Hide();
        }

        private void DriverloginBtn_Click(object sender, EventArgs e)
        {
            driverLogin driverLogin = new driverLogin();
            driverLogin.Show();
            this.Hide();
        }
    }
}
