using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFAproject
{
    public partial class UCCommandsManagment : UserControl
    {
        Connection con = new Connection();

        public UCCommandsManagment()
        {
            InitializeComponent();
        }

        private void commandList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UCCommandsManagment_Load(object sender, EventArgs e)
        {
            displayCommand();
        }
        public void displayCommand()
        {
            con.Open();
            string query = "select * from command";
            DataSet dataSet = con.ExecuteDataSet(query);
            DataTable dataTable = dataSet.Tables[0];
            commandList.DataSource = dataTable;
        }

        private void btnRefreshCommands_Click(object sender, EventArgs e)
        {
            displayCommand();
        }
    }
}
