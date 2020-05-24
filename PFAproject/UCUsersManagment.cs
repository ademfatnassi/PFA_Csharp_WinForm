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
    public partial class UCUsersManagment : UserControl
    {
        Connection con = new Connection();

        public UCUserManagInputs userAddInputs { get; set; } // user Inputs for "adding"
        public UCUserManagInputs userEditInputs { get; set; } // user Inputs for "editing"

        public UCUsersManagment()
        {
            InitializeComponent();

        }

        private void UCUsersManagment_Load(object sender, EventArgs e)
        {
            displayUsers();
            btnUpdateUser.Enabled = false;
            btnDeleteUser.Enabled = false;
            //btnUpdateUser.BackColor = Color.FromArgb(211, 211, 211);

        }

        public void displayUsers() {
            con.Open();
            string query = "select * from user";
            DataSet dataSet = con.ExecuteDataSet(query);
            DataTable dataTable = dataSet.Tables[0];
            usersList.DataSource = dataTable;
        }

        private void BtnRefreshUsers_Click(object sender, EventArgs e)
        {
            displayUsers();
        }

        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            userEditInputs.btnSubmit.Text = "Edit";
            userEditInputs?.BringToFront();

            userEditInputs.IdLabel.Text = "ID: ";
            userEditInputs.IdUser.Text = usersList.CurrentRow.Cells[0].Value.ToString();
            userEditInputs.txtLastName.Text =  usersList.CurrentRow.Cells[1].Value.ToString();
            userEditInputs.txtFirstName.Text = usersList.CurrentRow.Cells[2].Value.ToString();
            userEditInputs.txtPhone.Text = usersList.CurrentRow.Cells[3].Value.ToString();
            userEditInputs.birthDatePicker.Text = usersList.CurrentRow.Cells[4].Value.ToString();//*
            userEditInputs.txtAddresse.Text = usersList.CurrentRow.Cells[5].Value.ToString();
            userEditInputs.txtZip.Text =  usersList.CurrentRow.Cells[6].Value.ToString();
            userEditInputs.txtEmail.Text = usersList.CurrentRow.Cells[7].Value.ToString();
            userEditInputs.txtPassword.Text = usersList.CurrentRow.Cells[8].Value.ToString();
            if (usersList.CurrentRow.Cells[9].Value.ToString().Equals("M"))
            { userEditInputs.male.Checked = true; }
            else if (usersList.CurrentRow.Cells[9].Value.ToString().Equals("F"))
            { userEditInputs.female.Checked = true; }
            // TryParse City combobox
            if (Int32.TryParse(usersList.CurrentRow.Cells[10].Value.ToString(), out int CityValue))
            {
                userEditInputs.cbxCity.SelectedIndex = CityValue-1;
            }
            else
            {
                userEditInputs.cbxCity.SelectedIndex = -1;
            }
            // TryParse Role combobox
            if (Int32.TryParse(usersList.CurrentRow.Cells[11].Value.ToString(), out int RoleValue))
            {
                userEditInputs.cbxRole.SelectedIndex = RoleValue - 1;
            }
            else
            {
                userEditInputs.cbxRole.SelectedIndex = -1;
            }

            // TryParse user Status combobox
            if (Int32.TryParse(usersList.CurrentRow.Cells[11].Value.ToString(), out int StatusValue))
            {
                userEditInputs.cbxStatus.SelectedIndex = StatusValue - 1;
            }
            else
            {
                userEditInputs.cbxStatus.SelectedIndex = -1;
            }

        }

        private void UsersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(usersList.CurrentRow.Cells[0].Value.ToString());
            //userEditInputs.selectedUserID = usersList.CurrentRow.Cells[0].Value.ToString();
            btnUpdateUser.Enabled = true;
            btnDeleteUser.Enabled = true;

        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            userAddInputs.btnSubmit.Text = "Add";
            userAddInputs?.BringToFront();

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            //do you really want to delete this user
            if (MessageBox.Show($"Do you really want to delete {usersList.CurrentRow.Cells[2].Value.ToString()}{usersList.CurrentRow.Cells[1].Value.ToString()} ",
                                "User Deletion", 
                                MessageBoxButtons.YesNo, 
                                MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                String SQL = $"DELETE FROM `user` WHERE `idUser`={usersList.CurrentRow.Cells[0].Value.ToString()}";
                MessageBox.Show(SQL);
                con.ExecuteNonQuery(SQL);
            }
        }
    }
}
