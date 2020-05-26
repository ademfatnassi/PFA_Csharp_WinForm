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
    public partial class UCThemesManagmentInputs : UserControl
    {

        Connection con = new Connection();


        public UCThemesManagmentInputs()
        {
            InitializeComponent();
        }

        private void UCThemesManagmentInputs_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnSubmit.Text.Equals("Add"))
            {

                bool error = false;
                if (string.IsNullOrEmpty(txtThemeName.Text.Trim()))
                {
                    error = true;
                    MessageBox.Show("Verify theme name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtThemeName.Focus();
                }
                if (!error)
                {
                    MySqlDataReader row;
                    String SQL = $"INSERT INTO `themes`VALUES (NULL,'{txtThemeName.Text}')";
                    con.Open();
                    row = con.ExecuteReader(SQL);
                    while (row.Read())
                    {
                    }
                    con.Close();
                }

                //MessageBox.Show(SQL, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //con.ExecuteNonQuery(SQL);
                restInputs();

            }
            else
            {

                bool error = false;
                if (string.IsNullOrEmpty(txtThemeName.Text.Trim()))
                {
                    error = true;
                    MessageBox.Show("Verify theme name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtThemeName.Focus();
                }
                if (!error)
                {
                    //MessageBox.Show("Edit");
                    MySqlDataReader row;
                    string SQL = $"UPDATE `themes` SET `tName`='{txtThemeName.Text.Trim()}' WHERE `idTheme`='{IdTheme.Text}';";
                    con.Open();
                    row = con.ExecuteReader(SQL);
                    while (row.Read())
                    {
                    }
                    con.Close();
                    restInputs();
                }

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
        void restInputs()
        {
            IdTheme.Text = "";
            txtThemeName.Text = "";
        }

    }
}
