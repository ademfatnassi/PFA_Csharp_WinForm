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
using MySql.Data.MySqlClient;


namespace PFAproject
{
    public partial class LoginForm : Form
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

        Connection con = new Connection();
        string idUser, email, password, firstname, lastname, address;

        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text != "" && txtPassword.Text != "")
                {

                    con.Open();
                    string query = "select * from user WHERE `Role`=1 and `uStatus`=1 and Email ='" + txtEmail.Text + "' AND Password =MD5('" + txtPassword.Text + "')";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            idUser = row["idUser"].ToString();
                            email = row["Email"].ToString();
                            password = row["Password"].ToString();
                            firstname = row["Prenom"].ToString();
                            lastname = row["Nom"].ToString();
                            address = row["Adresse"].ToString();
                        }
                        this.Hide();
                        AdminDashboard admin = new AdminDashboard();
                        admin.ShowDialog();

                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Data not found", "Information");
                    }
                }
                else
                {
                    MessageBox.Show("Email or Password is empty", "Information");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
            }
            //this.Hide();
            //AdminDashboard adminDashboard = new AdminDashboard();
            //adminDashboard.ShowDialog();
            //this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }


        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
         
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
