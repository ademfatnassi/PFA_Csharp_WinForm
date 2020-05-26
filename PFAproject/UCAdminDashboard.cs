using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PFAproject
{
    public partial class UCAdminDashboard : UserControl
    {
        Connection con = new Connection();
    
        public UCAdminDashboard()
        {
            InitializeComponent();
        }

        private void UCAdminDashboard_Load(object sender, EventArgs e)
        {
            con.Open();
            string query1 = "SELECT COUNT(*) 'Total', COUNT(CASE WHEN `Gender`='M' THEN 1 END) 'male_tot', COUNT(CASE WHEN `Gender`='F' THEN 1 END) 'female_tot', COUNT(CASE WHEN `Role`='2' THEN 1 END) 'clients_tot' FROM `user`";
            MySqlDataReader row;
            row = con.ExecuteReader(query1);
            if (row.HasRows)
            {
                while (row.Read())
                {
                    totUsersNumber.Text = row["Total"].ToString();
                    totClient.Text = row["clients_tot"].ToString();
                    totMale.Text = row["male_tot"].ToString();
                    totFemale.Text = row["female_tot"].ToString();
                }
                TimeLabel.Text = DateTime.Now.ToString();
            }
            else
            {
                MessageBox.Show("Data not found", "Information");
            }
            con.Close();

            con.Open();
            string query2 = "SELECT COUNT(*) 'totproduct' FROM `product`";
            //MySqlDataReader row;
            row = con.ExecuteReader(query2);
            if (row.HasRows)
            {
                while (row.Read())
                {
                    totproducts.Text = row["totproduct"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Data not found", "Information");
            }
            con.Close();

            con.Open();
            string query3 = "SELECT COUNT(*)'totcommands' FROM `command`";
            //MySqlDataReader row;
            row = con.ExecuteReader(query3);
            if (row.HasRows)
            {
                while (row.Read())
                {
                    totcommands.Text = row["totcommands"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Data not found", "Information");
            }
            con.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
