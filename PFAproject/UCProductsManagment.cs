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
    public partial class UCProductsManagment : UserControl
    {
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
            productEditInputs?.BringToFront();
        }
    }
}
