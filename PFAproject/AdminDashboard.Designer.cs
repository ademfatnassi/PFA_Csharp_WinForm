namespace PFAproject
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.sideNavPanel = new System.Windows.Forms.Panel();
            this.indicator = new System.Windows.Forms.Panel();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.commandBtnManagment = new System.Windows.Forms.Button();
            this.productsBtnManagment = new System.Windows.Forms.Button();
            this.themeBtnManagment = new System.Windows.Forms.Button();
            this.usersBtnManagment = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.rightSidePanel = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Label();
            this.ucUserManagEdit = new PFAproject.UCUserManagInputs();
            this.ucAdminDashboard1 = new PFAproject.UCAdminDashboard();
            this.ucThemesManagment1 = new PFAproject.UCThemesManagment();
            this.ucProductsManagment1 = new PFAproject.UCProductsManagment();
            this.ucCommandsManagment1 = new PFAproject.UCCommandsManagment();
            this.ucUsersManagment1 = new PFAproject.UCUsersManagment();
            this.ucUserManagInputs1 = new PFAproject.UCUserManagInputs();
            this.sideNavPanel.SuspendLayout();
            this.rightSidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideNavPanel
            // 
            this.sideNavPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(208)))), ((int)(((byte)(155)))));
            this.sideNavPanel.Controls.Add(this.indicator);
            this.sideNavPanel.Controls.Add(this.logOutBtn);
            this.sideNavPanel.Controls.Add(this.commandBtnManagment);
            this.sideNavPanel.Controls.Add(this.productsBtnManagment);
            this.sideNavPanel.Controls.Add(this.themeBtnManagment);
            this.sideNavPanel.Controls.Add(this.usersBtnManagment);
            this.sideNavPanel.Controls.Add(this.homeBtn);
            this.sideNavPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideNavPanel.ForeColor = System.Drawing.Color.Transparent;
            this.sideNavPanel.Location = new System.Drawing.Point(0, 0);
            this.sideNavPanel.Name = "sideNavPanel";
            this.sideNavPanel.Size = new System.Drawing.Size(100, 600);
            this.sideNavPanel.TabIndex = 0;
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.Color.White;
            this.indicator.Location = new System.Drawing.Point(4, 207);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(14, 44);
            this.indicator.TabIndex = 6;
            // 
            // logOutBtn
            // 
            this.logOutBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(204)))), ((int)(((byte)(155)))));
            this.logOutBtn.FlatAppearance.BorderSize = 0;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.ForeColor = System.Drawing.Color.Transparent;
            this.logOutBtn.Image = global::PFAproject.Properties.Resources.logout;
            this.logOutBtn.Location = new System.Drawing.Point(12, 495);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(72, 44);
            this.logOutBtn.TabIndex = 5;
            this.logOutBtn.UseVisualStyleBackColor = true;
            // 
            // commandBtnManagment
            // 
            this.commandBtnManagment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(204)))), ((int)(((byte)(155)))));
            this.commandBtnManagment.FlatAppearance.BorderSize = 0;
            this.commandBtnManagment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commandBtnManagment.ForeColor = System.Drawing.Color.Transparent;
            this.commandBtnManagment.Image = global::PFAproject.Properties.Resources.commands;
            this.commandBtnManagment.Location = new System.Drawing.Point(12, 357);
            this.commandBtnManagment.Name = "commandBtnManagment";
            this.commandBtnManagment.Size = new System.Drawing.Size(72, 44);
            this.commandBtnManagment.TabIndex = 4;
            this.commandBtnManagment.UseVisualStyleBackColor = true;
            this.commandBtnManagment.Click += new System.EventHandler(this.commandBtnManagment_Click);
            // 
            // productsBtnManagment
            // 
            this.productsBtnManagment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(204)))), ((int)(((byte)(155)))));
            this.productsBtnManagment.FlatAppearance.BorderSize = 0;
            this.productsBtnManagment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsBtnManagment.ForeColor = System.Drawing.Color.Transparent;
            this.productsBtnManagment.Image = global::PFAproject.Properties.Resources.products;
            this.productsBtnManagment.Location = new System.Drawing.Point(12, 307);
            this.productsBtnManagment.Name = "productsBtnManagment";
            this.productsBtnManagment.Size = new System.Drawing.Size(72, 44);
            this.productsBtnManagment.TabIndex = 3;
            this.productsBtnManagment.UseVisualStyleBackColor = true;
            this.productsBtnManagment.Click += new System.EventHandler(this.productsBtnManagment_Click);
            // 
            // themeBtnManagment
            // 
            this.themeBtnManagment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(204)))), ((int)(((byte)(155)))));
            this.themeBtnManagment.FlatAppearance.BorderSize = 0;
            this.themeBtnManagment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themeBtnManagment.ForeColor = System.Drawing.Color.Transparent;
            this.themeBtnManagment.Image = global::PFAproject.Properties.Resources.themes;
            this.themeBtnManagment.Location = new System.Drawing.Point(12, 257);
            this.themeBtnManagment.Name = "themeBtnManagment";
            this.themeBtnManagment.Size = new System.Drawing.Size(72, 44);
            this.themeBtnManagment.TabIndex = 2;
            this.themeBtnManagment.UseVisualStyleBackColor = true;
            this.themeBtnManagment.Click += new System.EventHandler(this.themeBtnManagment_Click);
            // 
            // usersBtnManagment
            // 
            this.usersBtnManagment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(204)))), ((int)(((byte)(155)))));
            this.usersBtnManagment.FlatAppearance.BorderSize = 0;
            this.usersBtnManagment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersBtnManagment.ForeColor = System.Drawing.Color.Transparent;
            this.usersBtnManagment.Image = global::PFAproject.Properties.Resources.users1;
            this.usersBtnManagment.Location = new System.Drawing.Point(12, 207);
            this.usersBtnManagment.Name = "usersBtnManagment";
            this.usersBtnManagment.Size = new System.Drawing.Size(72, 44);
            this.usersBtnManagment.TabIndex = 1;
            this.usersBtnManagment.UseVisualStyleBackColor = true;
            this.usersBtnManagment.Click += new System.EventHandler(this.usersMangment_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(204)))), ((int)(((byte)(155)))));
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.ForeColor = System.Drawing.Color.Transparent;
            this.homeBtn.Image = global::PFAproject.Properties.Resources.whiteLogo0_5x;
            this.homeBtn.Location = new System.Drawing.Point(3, 12);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(94, 71);
            this.homeBtn.TabIndex = 0;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.HomeBtn_Click_1);
            // 
            // rightSidePanel
            // 
            this.rightSidePanel.BackColor = System.Drawing.Color.White;
            this.rightSidePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightSidePanel.Controls.Add(this.close);
            this.rightSidePanel.Controls.Add(this.ucAdminDashboard1);
            this.rightSidePanel.Controls.Add(this.ucThemesManagment1);
            this.rightSidePanel.Controls.Add(this.ucProductsManagment1);
            this.rightSidePanel.Controls.Add(this.ucCommandsManagment1);
            this.rightSidePanel.Controls.Add(this.ucUsersManagment1);
            this.rightSidePanel.Controls.Add(this.ucUserManagInputs1);
            this.rightSidePanel.Controls.Add(this.ucUserManagEdit);
            this.rightSidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightSidePanel.ForeColor = System.Drawing.Color.Transparent;
            this.rightSidePanel.Location = new System.Drawing.Point(100, 0);
            this.rightSidePanel.Name = "rightSidePanel";
            this.rightSidePanel.Size = new System.Drawing.Size(900, 600);
            this.rightSidePanel.TabIndex = 1;
            this.rightSidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Font = new System.Drawing.Font("Montserrat Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.Black;
            this.close.Location = new System.Drawing.Point(853, 8);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(34, 37);
            this.close.TabIndex = 10;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // ucUserManagEdit
            // 
            this.ucUserManagEdit.AutoSize = true;
            this.ucUserManagEdit.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucUserManagEdit.Location = new System.Drawing.Point(0, 49);
            this.ucUserManagEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ucUserManagEdit.MaximumSize = new System.Drawing.Size(900, 550);
            this.ucUserManagEdit.MinimumSize = new System.Drawing.Size(900, 550);
            this.ucUserManagEdit.Name = "ucUserManagEdit";
            this.ucUserManagEdit.selectedUserID = null;
            this.ucUserManagEdit.Size = new System.Drawing.Size(900, 550);
            this.ucUserManagEdit.TabIndex = 18;
            // 
            // ucAdminDashboard1
            // 
            this.ucAdminDashboard1.AutoSize = true;
            this.ucAdminDashboard1.Location = new System.Drawing.Point(0, 47);
            this.ucAdminDashboard1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ucAdminDashboard1.MaximumSize = new System.Drawing.Size(900, 550);
            this.ucAdminDashboard1.MinimumSize = new System.Drawing.Size(900, 550);
            this.ucAdminDashboard1.Name = "ucAdminDashboard1";
            this.ucAdminDashboard1.Size = new System.Drawing.Size(900, 550);
            this.ucAdminDashboard1.TabIndex = 11;
            this.ucAdminDashboard1.Load += new System.EventHandler(this.ucAdminDashboard1_Load_1);
            // 
            // ucThemesManagment1
            // 
            this.ucThemesManagment1.AutoSize = true;
            this.ucThemesManagment1.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucThemesManagment1.Location = new System.Drawing.Point(0, 48);
            this.ucThemesManagment1.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.ucThemesManagment1.Name = "ucThemesManagment1";
            this.ucThemesManagment1.Size = new System.Drawing.Size(900, 550);
            this.ucThemesManagment1.TabIndex = 13;
            // 
            // ucProductsManagment1
            // 
            this.ucProductsManagment1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucProductsManagment1.AutoSize = true;
            this.ucProductsManagment1.BackColor = System.Drawing.Color.White;
            this.ucProductsManagment1.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucProductsManagment1.ForeColor = System.Drawing.Color.Black;
            this.ucProductsManagment1.Location = new System.Drawing.Point(-1, 49);
            this.ucProductsManagment1.Margin = new System.Windows.Forms.Padding(2);
            this.ucProductsManagment1.Name = "ucProductsManagment1";
            this.ucProductsManagment1.Size = new System.Drawing.Size(900, 550);
            this.ucProductsManagment1.TabIndex = 16;
            // 
            // ucCommandsManagment1
            // 
            this.ucCommandsManagment1.AutoSize = true;
            this.ucCommandsManagment1.BackColor = System.Drawing.Color.White;
            this.ucCommandsManagment1.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold);
            this.ucCommandsManagment1.Location = new System.Drawing.Point(0, 50);
            this.ucCommandsManagment1.Margin = new System.Windows.Forms.Padding(2);
            this.ucCommandsManagment1.MaximumSize = new System.Drawing.Size(900, 550);
            this.ucCommandsManagment1.MinimumSize = new System.Drawing.Size(900, 550);
            this.ucCommandsManagment1.Name = "ucCommandsManagment1";
            this.ucCommandsManagment1.Size = new System.Drawing.Size(900, 550);
            this.ucCommandsManagment1.TabIndex = 15;
            // 
            // ucUsersManagment1
            // 
            this.ucUsersManagment1.AutoSize = true;
            this.ucUsersManagment1.BackColor = System.Drawing.Color.White;
            this.ucUsersManagment1.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucUsersManagment1.ForeColor = System.Drawing.Color.Black;
            this.ucUsersManagment1.Location = new System.Drawing.Point(0, 49);
            this.ucUsersManagment1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ucUsersManagment1.Name = "ucUsersManagment1";
            this.ucUsersManagment1.Size = new System.Drawing.Size(900, 550);
            this.ucUsersManagment1.TabIndex = 12;
            this.ucUsersManagment1.userAddInputs = null;
            this.ucUsersManagment1.userEditInputs = null;
            // 
            // ucUserManagInputs1
            // 
            this.ucUserManagInputs1.AutoSize = true;
            this.ucUserManagInputs1.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucUserManagInputs1.Location = new System.Drawing.Point(-1, 49);
            this.ucUserManagInputs1.Margin = new System.Windows.Forms.Padding(1);
            this.ucUserManagInputs1.MaximumSize = new System.Drawing.Size(900, 550);
            this.ucUserManagInputs1.MinimumSize = new System.Drawing.Size(900, 550);
            this.ucUserManagInputs1.Name = "ucUserManagInputs1";
            this.ucUserManagInputs1.selectedUserID = null;
            this.ucUserManagInputs1.Size = new System.Drawing.Size(900, 550);
            this.ucUserManagInputs1.TabIndex = 17;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.rightSidePanel);
            this.Controls.Add(this.sideNavPanel);
            this.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminDashboard";
            this.Load += new System.EventHandler(this.adminDashboard_Load);
            this.sideNavPanel.ResumeLayout(false);
            this.rightSidePanel.ResumeLayout(false);
            this.rightSidePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideNavPanel;
        private System.Windows.Forms.Panel rightSidePanel;
        private System.Windows.Forms.Button themeBtnManagment;
        private System.Windows.Forms.Button commandBtnManagment;
        private System.Windows.Forms.Button productsBtnManagment;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Panel indicator;
        private System.Windows.Forms.Label close;
        public System.Windows.Forms.Button homeBtn;
        public System.Windows.Forms.Button usersBtnManagment;
        private UCUsersManagment ucUsersManagment1;
        public UCAdminDashboard ucAdminDashboard1;
        private UCThemesManagment ucThemesManagment1;
        private UCCommandsManagment ucCommandsManagment1;
        private UCProductsManagment ucProductsManagment1;
        public UCUserManagInputs ucUserManagInputs1;
        private UCUserManagInputs ucUserManagEdit;
    }
}