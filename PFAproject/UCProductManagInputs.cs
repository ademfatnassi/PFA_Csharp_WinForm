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
    public partial class UCProductManagInputs : UserControl
    {
        Connection con = new Connection();

        public UCProductManagInputs()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            bool error = false;

            if (String.IsNullOrEmpty(txtImgSRC.Text) || txtImgSRC.Text.Length <= 25)
            {
                // assets\Images\product\ .text length 
                error = true;
                MessageBox.Show("Verify Product image source", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtImgSRC.Focus();

            }

            else if (String.IsNullOrEmpty(txtName.Text))
            {
                error = true;
                MessageBox.Show("Verify Product Title", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();

            }

            else if (String.IsNullOrEmpty(txtPrice.Text) || !Double.TryParse(txtPrice.Text, out double priceValue))
            {
                error = true;
                MessageBox.Show("Verify Product Price", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrice.Focus();

            }
            else if (cbxTheme.SelectedIndex == -1)
            {
                error = true;
                MessageBox.Show("Verify Product Theme", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxTheme.Focus();
            }

            else if (String.IsNullOrEmpty(txtStock.Text) || !int.TryParse(txtStock.Text, out int stockValue) || stockValue < 0)
            {
                error = true;
                MessageBox.Show("Verify Product Stock", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStock.Focus();

            }

            else if (String.IsNullOrEmpty(txtProvider.Text))
            {
                error = true;
                MessageBox.Show("Verify Product Provider", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProvider.Focus();

            }

            else if (String.IsNullOrEmpty(txtDescription.Text))
            {
                error = true;
                MessageBox.Show("Verify Product Description", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescription.Focus();

            }

            if (!error)
            {
                int themeSelectedIndex = cbxTheme.SelectedIndex + 1;//cbx start from 0

                if (btnSubmit.Text.Equals("Add"))
                {
                    MessageBox.Show("ADD", "¨product add", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtImgSRC.Text = txtImgSRC.Text.Replace("\\", "\\\\");

                    String SQL = $"INSERT INTO `product`(`idProduct`, `imgSRC`, `Title`, `Price`, `Description`, `Provider`, `ManufDate`, `ExpDate`, `Stock`, `idTheme`) VALUES (NULL,'{txtImgSRC.Text.Trim()}','{txtName.Text.Trim()}.','{txtPrice.Text.Trim()}.','{txtDescription.Text.Trim()}.','{txtProvider.Text.Trim()}','{ManuDatePicker.Text}','{ExepDatePicker.Text}','{txtStock.Text.Trim()}','{themeSelectedIndex}')";
                    con.ExecuteNonQuery(SQL);
                    MessageBox.Show(SQL);
                    restInputs();
                }
                else
                {
                    MessageBox.Show("EDIT", "¨product edit", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtImgSRC.Text = txtImgSRC.Text.Replace("\\", "\\\\");

                    String SQL = $"UPDATE `product` SET `imgSRC`='{txtImgSRC.Text}',`Title`='{txtName.Text.Trim()}',`Price`='{txtPrice.Text.Trim()}',`Description`='{txtDescription.Text.Trim()}',`Provider`='{txtProvider.Text.Trim()}',`ManufDate`='{ManuDatePicker.Text}',`ExpDate`='{ExepDatePicker.Text}',`Stock`='{txtStock.Text.Trim()}',`idTheme`='{themeSelectedIndex}' WHERE `idProduct`={idProduct.Text}";
                    con.ExecuteNonQuery(SQL);
                    MessageBox.Show(txtImgSRC.Text.Trim());
                    MessageBox.Show(SQL);
                    restInputs();
                }
            }


        }

        void fillComboboxTheme()
        {
            con.Open();
            string query = "select * from themes";
            DataSet dataSet = con.ExecuteDataSet(query);
            DataTable dataTable = dataSet.Tables[0];
            cbxTheme.DataSource = dataTable;
            cbxTheme.ValueMember = "idTheme";
            cbxTheme.DisplayMember = "tName";
        }

        void restInputs()
        {
            txtImgSRC.Text = @"assets\Images\product\";
            txtName.Text = "";
            txtPrice.Text = "";
            txtProvider.Text = "";
            txtStock.Text = "";
            txtDescription.Text = "";
            ManuDatePicker.Value = DateTime.Now;
            ExepDatePicker.Value = DateTime.Now;
            cbxTheme.SelectedIndex = -1;
            idProduct.Text = "";
        }

        private void UCProductManagInputs_Load(object sender, EventArgs e)
        {
            fillComboboxTheme();
            cbxTheme.SelectedIndex = -1;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            restInputs();
        }
    }
}
