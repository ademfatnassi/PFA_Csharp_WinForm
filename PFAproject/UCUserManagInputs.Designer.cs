namespace PFAproject
{
    partial class UCUserManagInputs
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.roleLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.addresseLabel = new System.Windows.Forms.Label();
            this.txtAddresse = new System.Windows.Forms.TextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.IdUser = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(128)))), ((int)(((byte)(126)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Montserrat Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(673, 463);
            this.btnReset.Margin = new System.Windows.Forms.Padding(1);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(133, 36);
            this.btnReset.TabIndex = 61;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(128)))), ((int)(((byte)(126)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Montserrat Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(529, 463);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(1);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(133, 36);
            this.btnSubmit.TabIndex = 60;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbxRole
            // 
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Items.AddRange(new object[] {
            "1: Admin",
            "2: Client"});
            this.cbxRole.Location = new System.Drawing.Point(606, 396);
            this.cbxRole.Margin = new System.Windows.Forms.Padding(1);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(200, 23);
            this.cbxRole.TabIndex = 59;
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "1: Active",
            "2: Desactive"});
            this.cbxStatus.Location = new System.Drawing.Point(207, 398);
            this.cbxStatus.Margin = new System.Windows.Forms.Padding(1);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(200, 23);
            this.cbxStatus.TabIndex = 58;
            // 
            // cbxCity
            // 
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Location = new System.Drawing.Point(606, 212);
            this.cbxCity.Margin = new System.Windows.Forms.Padding(1);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(200, 23);
            this.cbxCity.TabIndex = 57;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(128)))), ((int)(((byte)(126)))));
            this.female.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(128)))), ((int)(((byte)(126)))));
            this.female.Location = new System.Drawing.Point(540, 144);
            this.female.Margin = new System.Windows.Forms.Padding(1);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(95, 26);
            this.female.TabIndex = 56;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            this.female.CheckedChanged += new System.EventHandler(this.female_CheckedChanged);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(128)))), ((int)(((byte)(126)))));
            this.male.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(128)))), ((int)(((byte)(126)))));
            this.male.Location = new System.Drawing.Point(444, 144);
            this.male.Margin = new System.Windows.Forms.Padding(1);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(71, 26);
            this.male.TabIndex = 55;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.CalendarFont = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDatePicker.CustomFormat = "yyyy-MM-dd";
            this.birthDatePicker.Font = new System.Drawing.Font("Montserrat Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDatePicker.Location = new System.Drawing.Point(207, 154);
            this.birthDatePicker.Margin = new System.Windows.Forms.Padding(1);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(200, 21);
            this.birthDatePicker.TabIndex = 54;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(144)))), ((int)(((byte)(132)))));
            this.roleLabel.Location = new System.Drawing.Point(448, 396);
            this.roleLabel.Margin = new System.Windows.Forms.Padding(1);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(55, 22);
            this.roleLabel.TabIndex = 53;
            this.roleLabel.Text = "Role:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(144)))), ((int)(((byte)(132)))));
            this.statusLabel.Location = new System.Drawing.Point(43, 400);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(1);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(74, 22);
            this.statusLabel.TabIndex = 52;
            this.statusLabel.Text = "Status:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(144)))), ((int)(((byte)(132)))));
            this.passwordLabel.Location = new System.Drawing.Point(43, 273);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(1);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(103, 22);
            this.passwordLabel.TabIndex = 51;
            this.passwordLabel.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtPassword.Font = new System.Drawing.Font("Montserrat Medium", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(207, 278);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(1);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '⬤';
            this.txtPassword.Size = new System.Drawing.Size(200, 19);
            this.txtPassword.TabIndex = 50;
            // 
            // addresseLabel
            // 
            this.addresseLabel.AutoSize = true;
            this.addresseLabel.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(144)))), ((int)(((byte)(132)))));
            this.addresseLabel.Location = new System.Drawing.Point(43, 338);
            this.addresseLabel.Margin = new System.Windows.Forms.Padding(1);
            this.addresseLabel.Name = "addresseLabel";
            this.addresseLabel.Size = new System.Drawing.Size(100, 22);
            this.addresseLabel.TabIndex = 49;
            this.addresseLabel.Text = "Addresse:";
            // 
            // txtAddresse
            // 
            this.txtAddresse.BackColor = System.Drawing.Color.White;
            this.txtAddresse.Font = new System.Drawing.Font("Montserrat Medium", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddresse.Location = new System.Drawing.Point(207, 344);
            this.txtAddresse.Margin = new System.Windows.Forms.Padding(1);
            this.txtAddresse.Name = "txtAddresse";
            this.txtAddresse.Size = new System.Drawing.Size(200, 19);
            this.txtAddresse.TabIndex = 48;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(144)))), ((int)(((byte)(132)))));
            this.zipLabel.Location = new System.Drawing.Point(448, 334);
            this.zipLabel.Margin = new System.Windows.Forms.Padding(1);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(98, 22);
            this.zipLabel.TabIndex = 47;
            this.zipLabel.Text = "ZIP Code:";
            // 
            // txtZip
            // 
            this.txtZip.BackColor = System.Drawing.Color.White;
            this.txtZip.Font = new System.Drawing.Font("Montserrat Medium", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZip.Location = new System.Drawing.Point(606, 340);
            this.txtZip.Margin = new System.Windows.Forms.Padding(1);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(200, 19);
            this.txtZip.TabIndex = 46;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(144)))), ((int)(((byte)(132)))));
            this.phoneLabel.Location = new System.Drawing.Point(448, 269);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(1);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(74, 22);
            this.phoneLabel.TabIndex = 45;
            this.phoneLabel.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.Font = new System.Drawing.Font("Montserrat Medium", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(606, 274);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(1);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 19);
            this.txtPhone.TabIndex = 44;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(144)))), ((int)(((byte)(132)))));
            this.cityLabel.Location = new System.Drawing.Point(448, 211);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(1);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(51, 22);
            this.cityLabel.TabIndex = 43;
            this.cityLabel.Text = "City:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(144)))), ((int)(((byte)(132)))));
            this.emailLabel.Location = new System.Drawing.Point(43, 213);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(1);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(66, 22);
            this.emailLabel.TabIndex = 42;
            this.emailLabel.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Montserrat Medium", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(207, 218);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(1);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 19);
            this.txtEmail.TabIndex = 41;
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(144)))), ((int)(((byte)(132)))));
            this.birthDateLabel.Location = new System.Drawing.Point(43, 153);
            this.birthDateLabel.Margin = new System.Windows.Forms.Padding(1);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(110, 22);
            this.birthDateLabel.TabIndex = 40;
            this.birthDateLabel.Text = "Birth Date:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(144)))), ((int)(((byte)(132)))));
            this.lastNameLabel.Location = new System.Drawing.Point(448, 81);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(1);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(113, 22);
            this.lastNameLabel.TabIndex = 39;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.Font = new System.Drawing.Font("Montserrat Medium", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(606, 84);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(1);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 19);
            this.txtLastName.TabIndex = 38;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(144)))), ((int)(((byte)(132)))));
            this.firstNameLabel.Location = new System.Drawing.Point(43, 85);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(1);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(115, 22);
            this.firstNameLabel.TabIndex = 37;
            this.firstNameLabel.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.Font = new System.Drawing.Font("Montserrat Medium", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(207, 88);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(1);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 19);
            this.txtFirstName.TabIndex = 36;
            // 
            // IdUser
            // 
            this.IdUser.AutoSize = true;
            this.IdUser.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(144)))), ((int)(((byte)(132)))));
            this.IdUser.Location = new System.Drawing.Point(89, 47);
            this.IdUser.Name = "IdUser";
            this.IdUser.Size = new System.Drawing.Size(0, 22);
            this.IdUser.TabIndex = 62;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(144)))), ((int)(((byte)(132)))));
            this.IdLabel.Location = new System.Drawing.Point(43, 47);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(0, 22);
            this.IdLabel.TabIndex = 63;
            // 
            // UCUserManagInputs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.IdUser);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbxRole);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.cbxCity);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.birthDatePicker);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.addresseLabel);
            this.Controls.Add(this.txtAddresse);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.birthDateLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.txtFirstName);
            this.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(900, 550);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "UCUserManagInputs";
            this.Size = new System.Drawing.Size(900, 550);
            this.Load += new System.EventHandler(this.UCUserManagInputs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label addresseLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        public System.Windows.Forms.Button btnSubmit;
        public System.Windows.Forms.TextBox txtFirstName;
        public System.Windows.Forms.Label IdUser;
        public System.Windows.Forms.ComboBox cbxRole;
        public System.Windows.Forms.ComboBox cbxStatus;
        public System.Windows.Forms.ComboBox cbxCity;
        public System.Windows.Forms.DateTimePicker birthDatePicker;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtAddresse;
        public System.Windows.Forms.TextBox txtZip;
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtLastName;
        public System.Windows.Forms.RadioButton female;
        public System.Windows.Forms.RadioButton male;
        public System.Windows.Forms.Label IdLabel;
    }
}
