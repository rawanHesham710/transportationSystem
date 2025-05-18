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
    public partial class Vehicle_Types : Form
    {
        public Vehicle_Types()
        {
            InitializeComponent();
            string connectionString = "Server=DESKTOP-HLH7URN;Database=transportation;Trusted_Connection=True;Encrypt=False;";
            SqlConnection connection = new SqlConnection(connectionString);
            string sql = "SELECT driver.type, COUNT(*) as number FROM driver GROUP BY type ORDER BY number DESC";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataSet dataSet = new DataSet();
            connection.Open();
            adapter.Fill(dataSet);
            connection.Close();
            Vehicles.DataSource = dataSet.Tables[0];
        }
    }
}
