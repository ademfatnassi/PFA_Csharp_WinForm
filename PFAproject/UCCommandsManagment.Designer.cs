namespace PFAproject
{
    partial class UCCommandsManagment
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
            this.commandMangTitle = new System.Windows.Forms.Label();
            this.commandList = new System.Windows.Forms.DataGridView();
            this.btnRefreshCommands = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.commandList)).BeginInit();
            this.SuspendLayout();
            // 
            // commandMangTitle
            // 
            this.commandMangTitle.AutoSize = true;
            this.commandMangTitle.Font = new System.Drawing.Font("Montserrat Medium", 20F, System.Drawing.FontStyle.Bold);
            this.commandMangTitle.ForeColor = System.Drawing.Color.Black;
            this.commandMangTitle.Location = new System.Drawing.Point(80, 25);
            this.commandMangTitle.Name = "commandMangTitle";
            this.commandMangTitle.Size = new System.Drawing.Size(357, 37);
            this.commandMangTitle.TabIndex = 0;
            this.commandMangTitle.Text = "Command Managment";
            // 
            // commandList
            // 
            this.commandList.AllowUserToAddRows = false;
            this.commandList.AllowUserToDeleteRows = false;
            this.commandList.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.commandList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commandList.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.commandList.Location = new System.Drawing.Point(48, 167);
            this.commandList.Name = "commandList";
            this.commandList.ReadOnly = true;
            this.commandList.Size = new System.Drawing.Size(805, 312);
            this.commandList.TabIndex = 1;
            this.commandList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.commandList_CellContentClick);
            // 
            // btnRefreshCommands
            // 
            this.btnRefreshCommands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(128)))), ((int)(((byte)(126)))));
            this.btnRefreshCommands.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(204)))), ((int)(((byte)(155)))));
            this.btnRefreshCommands.FlatAppearance.BorderSize = 0;
            this.btnRefreshCommands.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshCommands.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefreshCommands.Image = global::PFAproject.Properties.Resources.refresh;
            this.btnRefreshCommands.Location = new System.Drawing.Point(781, 117);
            this.btnRefreshCommands.Name = "btnRefreshCommands";
            this.btnRefreshCommands.Size = new System.Drawing.Size(72, 44);
            this.btnRefreshCommands.TabIndex = 6;
            this.btnRefreshCommands.UseVisualStyleBackColor = false;
            this.btnRefreshCommands.Click += new System.EventHandler(this.btnRefreshCommands_Click);
            // 
            // UCCommandsManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRefreshCommands);
            this.Controls.Add(this.commandList);
            this.Controls.Add(this.commandMangTitle);
            this.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximumSize = new System.Drawing.Size(900, 550);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "UCCommandsManagment";
            this.Size = new System.Drawing.Size(900, 550);
            this.Load += new System.EventHandler(this.UCCommandsManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.commandList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label commandMangTitle;
        private System.Windows.Forms.DataGridView commandList;
        public System.Windows.Forms.Button btnRefreshCommands;
    }
}
