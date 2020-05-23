using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PFAproject
{
    public partial class UCProductsManagment : UserControl
    {
        Connection con = new Connection();
        static readonly string rootFolder = @"C:\xampp\htdocs\PFA\";


        public UCProductManagInputs productAddInputs { get; set; } // product Inputs for "adding"
        public UCProductManagInputs productEditInputs { get; set; } // product Inputs for "editing"

        public UCProductsManagment()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            productAddInputs.btnSubmit.Text = "Add";
            productAddInputs?.BringToFront();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            productEditInputs.btnSubmit.Text = "Edit";

            productEditInputs.idLabel.Text = "ID: ";
            productEditInputs.idProduct.Text = productList.CurrentRow.Cells[0].Value.ToString();
            productEditInputs.txtImgSRC.Text = productList.CurrentRow.Cells[1].Value.ToString();
            productEditInputs.txtImgSRC.Text = productEditInputs.txtImgSRC.Text.Replace("\\", "\\\\");
            MessageBox.Show(productEditInputs.txtImgSRC.Text);
            productEditInputs.txtName.Text = productList.CurrentRow.Cells[2].Value.ToString();
            productEditInputs.txtPrice.Text = productList.CurrentRow.Cells[3].Value.ToString();
            productEditInputs.txtDescription.Text = productList.CurrentRow.Cells[4].Value.ToString();
            productEditInputs.txtProvider.Text = productList.CurrentRow.Cells[5].Value.ToString();
            productEditInputs.ManuDatePicker.Text = productList.CurrentRow.Cells[6].Value.ToString();
            productEditInputs.ExepDatePicker.Text = productList.CurrentRow.Cells[7].Value.ToString();
            productEditInputs.txtStock.Text = productList.CurrentRow.Cells[8].Value.ToString();
            if (Int32.TryParse(productList.CurrentRow.Cells[9].Value.ToString(), out int ThemeValue))
            {
                productEditInputs.cbxTheme.SelectedIndex = ThemeValue - 1;
            }



            productEditInputs?.BringToFront();
        }

        private void productList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdateProduct.Enabled = true;
            btnDeleteProduct.Enabled = true;
        }

        private void UCProductsManagment_Load(object sender, EventArgs e)
        {
            displayProduct();
            btnUpdateProduct.Enabled = false;
            btnDeleteProduct.Enabled = false;
        }
        public void displayProduct()
        {
            con.Open();
            string query = "select * from product";
            DataSet dataSet = con.ExecuteDataSet(query);
            DataTable dataTable = dataSet.Tables[0];
            productList.DataSource = dataTable;
        }

        private void btnRefreshProducts_Click(object sender, EventArgs e)
        {
            displayProduct();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            // Files to be deleted    
            

            //do you really want to delete this user
            if (MessageBox.Show($"Do you really want to delete {productList.CurrentRow.Cells[0].Value.ToString()}::{productList.CurrentRow.Cells[2].Value.ToString()} ",
                                "User Deletion",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                String SQL = $"DELETE FROM `product` WHERE `idProduct`={productList.CurrentRow.Cells[0].Value.ToString()}";
                string productImg = productList.CurrentRow.Cells[1].Value.ToString();
                try
                {
                    // Check if file exists with its full path    
                    if (File.Exists(Path.Combine(rootFolder, productImg)))
                    {
                        // If file found, delete it    
                        File.Delete(Path.Combine(rootFolder, productImg));
                        con.ExecuteNonQuery(SQL);
                        MessageBox.Show("File deleted.");
                        displayProduct();

                    }
                    else MessageBox.Show("File not found");
                }
                catch (IOException ioExp)
                {
                    MessageBox.Show(ioExp.Message);
                }
                //MessageBox.Show(SQL);
                
            }

        }
    }
}
