namespace PFAproject
{
    partial class UCThemesManagment
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
            this.themeMangTitle = new System.Windows.Forms.Label();
            this.themeList = new System.Windows.Forms.DataGridView();
            this.btnRefreshThemes = new System.Windows.Forms.Button();
            this.btnUpdateTheme = new System.Windows.Forms.Button();
            this.btnDeleteTheme = new System.Windows.Forms.Button();
            this.btnAddTheme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.themeList)).BeginInit();
            this.SuspendLayout();
            // 
            // themeMangTitle
            // 
            this.themeMangTitle.AutoSize = true;
            this.themeMangTitle.Font = new System.Drawing.Font("Montserrat Medium", 20F, System.Drawing.FontStyle.Bold);
            this.themeMangTitle.ForeColor = System.Drawing.Color.Black;
            this.themeMangTitle.Location = new System.Drawing.Point(80, 25);
            this.themeMangTitle.Name = "themeMangTitle";
            this.themeMangTitle.Size = new System.Drawing.Size(306, 37);
            this.themeMangTitle.TabIndex = 0;
            this.themeMangTitle.Text = "Theme Managment";
            // 
            // themeList
            // 
            this.themeList.AllowUserToAddRows = false;
            this.themeList.AllowUserToDeleteRows = false;
            this.themeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.themeList.Location = new System.Drawing.Point(87, 177);
            this.themeList.Name = "themeList";
            this.themeList.ReadOnly = true;
            this.themeList.Size = new System.Drawing.Size(730, 300);
            this.themeList.TabIndex = 1;
            // 
            // btnRefreshThemes
            // 
            this.btnRefreshThemes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(128)))), ((int)(((byte)(126)))));
            this.btnRefreshThemes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(204)))), ((int)(((byte)(155)))));
            this.btnRefreshThemes.FlatAppearance.BorderSize = 0;
            this.btnRefreshThemes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshThemes.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefreshThemes.Image = global::PFAproject.Properties.Resources.refresh;
            this.btnRefreshThemes.Location = new System.Drawing.Point(554, 127);
            this.btnRefreshThemes.Name = "btnRefreshThemes";
            this.btnRefreshThemes.Size = new System.Drawing.Size(72, 44);
            this.btnRefreshThemes.TabIndex = 13;
            this.btnRefreshThemes.UseVisualStyleBackColor = false;
            // 
            // btnUpdateTheme
            // 
            this.btnUpdateTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(128)))), ((int)(((byte)(126)))));
            this.btnUpdateTheme.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(204)))), ((int)(((byte)(155)))));
            this.btnUpdateTheme.FlatAppearance.BorderSize = 0;
            this.btnUpdateTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTheme.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdateTheme.Image = global::PFAproject.Properties.Resources.update;
            this.btnUpdateTheme.Location = new System.Drawing.Point(651, 127);
            this.btnUpdateTheme.Name = "btnUpdateTheme";
            this.btnUpdateTheme.Size = new System.Drawing.Size(72, 44);
            this.btnUpdateTheme.TabIndex = 12;
            this.btnUpdateTheme.UseVisualStyleBackColor = false;
            // 
            // btnDeleteTheme
            // 
            this.btnDeleteTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(128)))), ((int)(((byte)(126)))));
            this.btnDeleteTheme.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(204)))), ((int)(((byte)(155)))));
            this.btnDeleteTheme.FlatAppearance.BorderSize = 0;
            this.btnDeleteTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTheme.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeleteTheme.Image = global::PFAproject.Properties.Resources.delete;
            this.btnDeleteTheme.Location = new System.Drawing.Point(744, 127);
            this.btnDeleteTheme.Name = "btnDeleteTheme";
            this.btnDeleteTheme.Size = new System.Drawing.Size(72, 44);
            this.btnDeleteTheme.TabIndex = 11;
            this.btnDeleteTheme.UseVisualStyleBackColor = false;
            // 
            // btnAddTheme
            // 
            this.btnAddTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(128)))), ((int)(((byte)(126)))));
            this.btnAddTheme.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(204)))), ((int)(((byte)(155)))));
            this.btnAddTheme.FlatAppearance.BorderSize = 0;
            this.btnAddTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTheme.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddTheme.Image = global::PFAproject.Properties.Resources.add;
            this.btnAddTheme.Location = new System.Drawing.Point(86, 127);
            this.btnAddTheme.Name = "btnAddTheme";
            this.btnAddTheme.Size = new System.Drawing.Size(72, 44);
            this.btnAddTheme.TabIndex = 10;
            this.btnAddTheme.UseVisualStyleBackColor = false;
            // 
            // UCThemesManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnRefreshThemes);
            this.Controls.Add(this.btnUpdateTheme);
            this.Controls.Add(this.btnDeleteTheme);
            this.Controls.Add(this.btnAddTheme);
            this.Controls.Add(this.themeList);
            this.Controls.Add(this.themeMangTitle);
            this.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "UCThemesManagment";
            this.Size = new System.Drawing.Size(900, 550);
            ((System.ComponentModel.ISupportInitialize)(this.themeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label themeMangTitle;
        private System.Windows.Forms.DataGridView themeList;
        public System.Windows.Forms.Button btnRefreshThemes;
        public System.Windows.Forms.Button btnUpdateTheme;
        public System.Windows.Forms.Button btnDeleteTheme;
        public System.Windows.Forms.Button btnAddTheme;
    }
}
