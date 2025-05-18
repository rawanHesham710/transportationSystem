using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transportation_App.Views
{
    public partial class MainForm : Form
    {
        private string userId;
        public MainForm(string Username, string Id)
        {
            InitializeComponent();
            this.Hello_Massage.Text = "Hello" + Username;
            this.Hello_Massage.ReadOnly = true;
            this.userId = Id;
        }

        private void NewRide_Click(object sender, EventArgs e)
        {
            Form RideForm = new Form();
            RideForm.Show();
        }

        private void TransportGoods_Click(object sender, EventArgs e)
        {
            Form GoodsForm = new Transport_Goods(userId);
            GoodsForm.Show();
        }

        private void rideHistory_Click(object sender, EventArgs e)
        {
            Form RH = new Ride_History(userId);
            RH.Show();
        }

        private void vehicleTypes_Click(object sender, EventArgs e)
        {
            Form VehicleTypesForm = new Vehicle_Types();
            VehicleTypesForm.Show();
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            Form UserProfile = new Profile(userId);
            UserProfile.Show();
        }
    }
}
