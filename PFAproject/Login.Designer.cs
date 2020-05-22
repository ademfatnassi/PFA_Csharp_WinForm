namespace PFAproject
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginPagePanel = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.sideLogoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.Label();
            this.loginPagePanel.SuspendLayout();
            this.sideLogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPagePanel
            // 
            this.loginPagePanel.Controls.Add(this.minimize);
            this.loginPagePanel.Controls.Add(this.btnLogin);
            this.loginPagePanel.Controls.Add(this.label4);
            this.loginPagePanel.Controls.Add(this.txtPassword);
            this.loginPagePanel.Controls.Add(this.label3);
            this.loginPagePanel.Controls.Add(this.txtEmail);
            this.loginPagePanel.Controls.Add(this.label2);
            this.loginPagePanel.Controls.Add(this.label1);
            this.loginPagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPagePanel.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPagePanel.Location = new System.Drawing.Point(200, 0);
            this.loginPagePanel.Name = "loginPagePanel";
            this.loginPagePanel.Size = new System.Drawing.Size(600, 450);
            this.loginPagePanel.TabIndex = 1;
            this.loginPagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(144)))), ((int)(((byte)(132)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(241, 332);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(109, 40);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(144)))), ((int)(((byte)(132)))));
            this.label4.Location = new System.Drawing.Point(147, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(151, 279);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(308, 27);
            this.txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(144)))), ((int)(((byte)(132)))));
            this.label3.Location = new System.Drawing.Point(147, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(151, 201);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(308, 27);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "admin Space";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 31F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(197, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log In";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Montserrat Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(766, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(34, 37);
            this.close.TabIndex = 7;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // sideLogoPanel
            // 
            this.sideLogoPanel.BackgroundImage = global::PFAproject.Properties.Resources.sideBg;
            this.sideLogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sideLogoPanel.Controls.Add(this.pictureBox1);
            this.sideLogoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideLogoPanel.Location = new System.Drawing.Point(0, 0);
            this.sideLogoPanel.Name = "sideLogoPanel";
            this.sideLogoPanel.Size = new System.Drawing.Size(200, 450);
            this.sideLogoPanel.TabIndex = 0;
            this.sideLogoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PFAproject.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(23, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 173);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // minimize
            // 
            this.minimize.AutoSize = true;
            this.minimize.Font = new System.Drawing.Font("Montserrat Light", 20.25F);
            this.minimize.ForeColor = System.Drawing.Color.Black;
            this.minimize.Location = new System.Drawing.Point(529, 9);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(31, 37);
            this.minimize.TabIndex = 21;
            this.minimize.Text = "_";
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.close);
            this.Controls.Add(this.loginPagePanel);
            this.Controls.Add(this.sideLogoPanel);
            this.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.loginPagePanel.ResumeLayout(false);
            this.loginPagePanel.PerformLayout();
            this.sideLogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sideLogoPanel;
        private System.Windows.Forms.Panel loginPagePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label minimize;
    }
}

