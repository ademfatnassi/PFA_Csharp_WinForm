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
    public partial class UCUserManagInputs : UserControl
    {
        Connection con = new Connection();
        public String selectedUserID { get; set; }// selected id column from selected row in datagridview


        String genderValue = "";

        public UCUserManagInputs()
        {
            InitializeComponent();
        }

        private void UCUserManagInputs_Load(object sender, EventArgs e)
        {
            fillComboboxCity();
            cbxCity.SelectedIndex = -1;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int citySelectedIndex = cbxCity.SelectedIndex + 1;//starts from 0
            int roleSelectedIndex = cbxRole.SelectedIndex + 1;//starts from 0
            int statusSelectedIndex = cbxStatus.SelectedIndex + 1;//starts from 0

            bool error = false;


            if (string.IsNullOrEmpty(txtFirstName.Text.Trim()))
            {
                error = true;
                MessageBox.Show("Verify User first name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFirstName.Focus();
            }
            else if (string.IsNullOrEmpty(txtLastName.Text.Trim()))
            {
                error = true;
                MessageBox.Show("Verify User last name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLastName.Focus();
            }
            else if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                error = true;
                MessageBox.Show("Verify User Email", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
            }
            else if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                error = true;
                MessageBox.Show("Verify User Password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
            }
            else if (string.IsNullOrEmpty(txtPhone.Text.Trim()))
            {
                error = true;
                MessageBox.Show("Verify User Phone", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhone.Focus();
            }
            else if (string.IsNullOrEmpty(txtAddresse.Text.Trim()))
            {
                error = true;
                MessageBox.Show("Verify User Addresse", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAddresse.Focus();
            }
            else if (string.IsNullOrEmpty(txtZip.Text.Trim()) || !int.TryParse(txtZip.Text, out int zipValue) || zipValue < 0)
            {
                error = true;
                MessageBox.Show("Verify User zip code", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtZip.Focus();
            }
            else if (cbxCity.SelectedIndex == -1)
            {
                error = true;
                MessageBox.Show("Verify User IcCity", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxCity.Focus();
            }
            else if (cbxRole.SelectedIndex == -1)
            {
                error = true;
                MessageBox.Show("Verify User Role", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxRole.Focus();
            }
            else if (cbxStatus.SelectedIndex == -1)
            {
                error = true;
                MessageBox.Show("Verify User Role", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxStatus.Focus();
            } else if (String.IsNullOrEmpty(genderValue))
            {
                MessageBox.Show("Not selected", "Gender not Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            if (btnSubmit.Text.Equals("Add"))
            {
                
                    if (!error)
                    {
                        String SQL = $"INSERT INTO `user`(`idUser`, `Nom`, `Prenom`, `Phone`, `BirthDate`, `Adresse`, `ZIP`, `Email`, `Password`, `Gender`, `idCity`, `Role`, `uStatus`, `inscritDate`) VALUES (NULL,'{txtLastName.Text}','{txtFirstName.Text}','{txtPhone.Text}','{birthDatePicker.Text}','{txtAddresse.Text}','{txtZip.Text}','{txtEmail.Text}',MD5('{txtPassword.Text}'),'{genderValue}','{citySelectedIndex.ToString()}','{roleSelectedIndex.ToString()}','{statusSelectedIndex.ToString()}','{DateTime.Now.ToString("yyyy-MM-dd")}')";
                        MessageBox.Show(SQL, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        con.ExecuteNonQuery(SQL);
                        restInputs();
                    }
                    
            }
            else
            {
                //MessageBox.Show("Edit");
                String SQL = $"UPDATE `user` SET `Nom`='{txtLastName.Text}',`Prenom`='{txtFirstName.Text}',`Phone`='{txtPhone.Text}',`BirthDate`='{birthDatePicker.Text}',`Adresse`='{txtAddresse.Text}',`ZIP`='{txtZip.Text}',`Email`='{txtEmail.Text}',`Gender`='{genderValue}',`idCity`='{citySelectedIndex.ToString()}',`Role`='{roleSelectedIndex.ToString()}',`uStatus`='{statusSelectedIndex.ToString()}' ";
                if (string.IsNullOrEmpty(txtPassword.Text)) {
                    SQL += $"WHERE `idUser`= '{IdUser.Text}'";
                }
                else
                {
                    SQL += $",`Password`=MD5('{txtPassword.Text}')";
                    SQL += $"WHERE `idUser`= '{IdUser.Text}'";

                }
                MessageBox.Show(SQL);
                con.ExecuteNonQuery(SQL);
                restInputs();
            }


        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            genderValue = "M";
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            genderValue = "F";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            restInputs();
        }
        void restInputs()
        {
            IdUser.Text = "";
            txtAddresse.Text = "";
            txtEmail.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPassword.Text = "";
            txtPhone.Text = "";
            txtZip.Text = "";
            birthDatePicker.Value = DateTime.Now;
            cbxCity.SelectedIndex = -1;
            cbxRole.SelectedIndex = -1;
            cbxStatus.SelectedIndex = -1;
            if (genderValue.Equals("M"))
            { male.Checked = false; }
            else if (genderValue.Equals("F"))
            { female.Checked = false; }
        }
        void fillComboboxCity()
        {
            con.Open();
            string query = "select * from city";
            DataSet dataSet = con.ExecuteDataSet(query);
            DataTable dataTable = dataSet.Tables[0];
            cbxCity.DataSource = dataTable;
            cbxCity.ValueMember = "idCity";
            cbxCity.DisplayMember = "nameCity";
        }
    }
}
