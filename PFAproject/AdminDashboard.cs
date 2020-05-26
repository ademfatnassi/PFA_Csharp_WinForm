using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PFAproject
{
    public partial class AdminDashboard : Form
    {
        /*These block of Code is responsable of border radius*/
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        /*END OF CODE BLOCK*/

        public AdminDashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            ucAdminDashboard1.BringToFront();
            //ucAdminDashboard1.adminLabel.Text = "1";
            indicator.Hide();

            ucUsersManagment1.userAddInputs = ucUserManagInputs1;
            ucUsersManagment1.userEditInputs = ucUserManagEdit;

            ucProductsManagment1.productAddInputs = ucProductManagInputs1;
            ucProductsManagment1.productEditInputs = ucProductManagInputs2;

            ucThemesManagment1.themeAddInputs = ucThemesManagmentInputs1;
            ucThemesManagment1.themeEditInputs = ucThemesManagmentInputs2;
        }

        private void adminDashboard_Load(object sender, EventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {

        }

        private void usersMangment_Click(object sender, EventArgs e)
        {
            indicator.Show();
            indicator.Height = usersBtnManagment.Height;
            indicator.Top = usersBtnManagment.Top;
            ucUsersManagment1.BringToFront();
        }

        private void themeBtnManagment_Click(object sender, EventArgs e)
        {
            indicator.Show();
            indicator.Height = themeBtnManagment.Height;
            indicator.Top = themeBtnManagment.Top;
            ucThemesManagment1.BringToFront();
        }

        private void productsBtnManagment_Click(object sender, EventArgs e)
        {
            indicator.Show();
            indicator.Height = productsBtnManagment.Height;
            indicator.Top = productsBtnManagment.Top;
            ucProductsManagment1.BringToFront();
        }

        

        private void ucAdminDashboard1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

       

        private void HomeBtn_Click_1(object sender, EventArgs e)
        {
            ucAdminDashboard1.BringToFront();
            indicator.Hide();
        }

        private void ucAdminDashboard1_Load_1(object sender, EventArgs e)
        {

        }

        private void commandBtnManagment_Click(object sender, EventArgs e)
        {
            indicator.Show();
            indicator.Height = commandBtnManagment.Height;
            indicator.Top = commandBtnManagment.Top;
            ucCommandsManagment1.BringToFront();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucProductsManagment1_Load(object sender, EventArgs e)
        {

        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
    }
}
