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
    public partial class Ride_History : Form
    {
        public Ride_History(string userId)
        {
            InitializeComponent();
            string connectionString = "Server=DESKTOP-HLH7URN;Database=transportation;Trusted_Connection=True;Encrypt=False;";
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = "SELECT ride.destination, ride.startAddress, ride.startTime, ride.endTime, ride.feedback, ride.score, driver.name, driver.phone FROM ride INNER JOIN driver on ride.driverId = driver.id WHERE ride.userId = " + userId;
            SqlDataAdapter adapter = new SqlDataAdapter(sql,connection);
            DataSet dataSet = new DataSet();
            connection.Open();
            adapter.Fill(dataSet);
            connection.Close();
            Ride_Grid.DataSource = dataSet.Tables[0];
        }
    }
}
