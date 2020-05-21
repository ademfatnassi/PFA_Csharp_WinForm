namespace PFAproject
{
    partial class UCUsersManagment
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.userMangTitle = new System.Windows.Forms.Label();
            this.usersList = new System.Windows.Forms.DataGridView();
            this.btnRefreshUsers = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersList)).BeginInit();
            this.SuspendLayout();
            // 
            // userMangTitle
            // 
            this.userMangTitle.AutoSize = true;
            this.userMangTitle.Font = new System.Drawing.Font("Montserrat Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userMangTitle.ForeColor = System.Drawing.Color.Black;
            this.userMangTitle.Location = new System.Drawing.Point(80, 25);
            this.userMangTitle.Name = "userMangTitle";
            this.userMangTitle.Size = new System.Drawing.Size(271, 37);
            this.userMangTitle.TabIndex = 0;
            this.userMangTitle.Text = "User Managment";
            // 
            // usersList
            // 
            this.usersList.AllowUserToAddRows = false;
            this.usersList.AllowUserToDeleteRows = false;
            this.usersList.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.usersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersList.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.usersList.Location = new System.Drawing.Point(84, 193);
            this.usersList.Name = "usersList";
            this.usersList.ReadOnly = true;
            this.usersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersList.Size = new System.Drawing.Size(730, 300);
            this.usersList.TabIndex = 1;
            this.usersList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersList_CellContentClick);
            // 
            // btnRefreshUsers
            // 
            this.btnRefreshUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(128)))), ((int)(((byte)(126)))));
            this.btnRefreshUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(204)))), ((int)(((byte)(155)))));
            this.btnRefreshUsers.FlatAppearance.BorderSize = 0;
            this.btnRefreshUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshUsers.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefreshUsers.Image = global::PFAproject.Properties.Resources.refresh;
            this.btnRefreshUsers.Location = new System.Drawing.Point(553, 128);
            this.btnRefreshUsers.Name = "btnRefreshUsers";
            this.btnRefreshUsers.Size = new System.Drawing.Size(72, 44);
            this.btnRefreshUsers.TabIndex = 5;
            this.btnRefreshUsers.UseVisualStyleBackColor = false;
            this.btnRefreshUsers.Click += new System.EventHandler(this.BtnRefreshUsers_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(128)))), ((int)(((byte)(126)))));
            this.btnUpdateUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(204)))), ((int)(((byte)(155)))));
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdateUser.Image = global::PFAproject.Properties.Resources.update;
            this.btnUpdateUser.Location = new System.Drawing.Point(650, 128);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(72, 44);
            this.btnUpdateUser.TabIndex = 4;
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.BtnUpdateUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(128)))), ((int)(((byte)(126)))));
            this.btnDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(204)))), ((int)(((byte)(155)))));
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeleteUser.Image = global::PFAproject.Properties.Resources.delete;
            this.btnDeleteUser.Location = new System.Drawing.Point(743, 128);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(72, 44);
            this.btnDeleteUser.TabIndex = 3;
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(128)))), ((int)(((byte)(126)))));
            this.btnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(204)))), ((int)(((byte)(155)))));
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddUser.Image = global::PFAproject.Properties.Resources.add;
            this.btnAddUser.Location = new System.Drawing.Point(84, 128);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(72, 44);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // UCUsersManagment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRefreshUsers);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.usersList);
            this.Controls.Add(this.userMangTitle);
            this.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "UCUsersManagment";
            this.Size = new System.Drawing.Size(900, 550);
            this.Load += new System.EventHandler(this.UCUsersManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userMangTitle;
        private System.Windows.Forms.DataGridView usersList;
        public System.Windows.Forms.Button btnAddUser;
        public System.Windows.Forms.Button btnDeleteUser;
        public System.Windows.Forms.Button btnUpdateUser;
        public System.Windows.Forms.Button btnRefreshUsers;
    }
}
