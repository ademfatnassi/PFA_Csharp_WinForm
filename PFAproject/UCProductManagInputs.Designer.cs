namespace PFAproject
{
    partial class UCProductManagInputs
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
            this.ImageSRCLabel = new System.Windows.Forms.Label();
            this.txtImgSRC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ImageSRCLabel
            // 
            this.ImageSRCLabel.AutoSize = true;
            this.ImageSRCLabel.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageSRCLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(144)))), ((int)(((byte)(132)))));
            this.ImageSRCLabel.Location = new System.Drawing.Point(50, 58);
            this.ImageSRCLabel.Name = "ImageSRCLabel";
            this.ImageSRCLabel.Size = new System.Drawing.Size(120, 22);
            this.ImageSRCLabel.TabIndex = 0;
            this.ImageSRCLabel.Text = "Image SRC: ";
            // 
            // txtImgSRC
            // 
            this.txtImgSRC.Location = new System.Drawing.Point(177, 59);
            this.txtImgSRC.Name = "txtImgSRC";
            this.txtImgSRC.Size = new System.Drawing.Size(200, 21);
            this.txtImgSRC.TabIndex = 1;
            // 
            // UCProductManagInputs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtImgSRC);
            this.Controls.Add(this.ImageSRCLabel);
            this.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(1200, 635);
            this.MinimumSize = new System.Drawing.Size(1200, 635);
            this.Name = "UCProductManagInputs";
            this.Size = new System.Drawing.Size(1200, 635);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ImageSRCLabel;
        private System.Windows.Forms.TextBox txtImgSRC;
    }
}
