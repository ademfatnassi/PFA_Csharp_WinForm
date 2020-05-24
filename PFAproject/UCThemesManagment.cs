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
    public partial class UCThemesManagment : UserControl
    {
        Connection con = new Connection();
        
        public UCThemesManagmentInputs themeAddInputs { get; set; } // theme Inputs for "adding"
        public UCThemesManagmentInputs themeEditInputs { get; set; } // theme Inputs for "editing"

        public UCThemesManagment()
        {
            InitializeComponent();
        }

        private void UCThemesManagment_Load(object sender, EventArgs e)
        {
            DisplayThemes();
            btnUpdateTheme.Enabled = false;
            btnDeleteTheme.Enabled = false;
        }

        public void DisplayThemes()
        {
            con.Open();
            string query = "select * from themes";
            DataSet dataSet = con.ExecuteDataSet(query);
            DataTable dataTable = dataSet.Tables[0];
            themeList.DataSource = dataTable;
        }

        private void btnRefreshThemes_Click(object sender, EventArgs e)
        {
            DisplayThemes();
        }

        private void btnAddTheme_Click(object sender, EventArgs e)
        {
            themeAddInputs.btnSubmit.Text = "Add";
            themeAddInputs?.BringToFront();
        }

        private void themeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdateTheme.Enabled = true;
            btnDeleteTheme.Enabled = true;
        }

        private void btnUpdateTheme_Click(object sender, EventArgs e)
        {
            themeEditInputs.btnSubmit.Text = "Edit";
            themeEditInputs?.BringToFront();

            themeEditInputs.IdLabel.Text = "ID: ";
            themeEditInputs.IdTheme.Text = themeList.CurrentRow.Cells[0].Value.ToString();
            themeEditInputs.txtThemeName.Text = themeList.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
