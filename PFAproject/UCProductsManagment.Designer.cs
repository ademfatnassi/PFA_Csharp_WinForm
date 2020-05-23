namespace PFAproject
{
    partial class UCProductsManagment
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
            this.productMangTitle = new System.Windows.Forms.Label();
            this.productList = new System.Windows.Forms.DataGridView();
            this.btnRefreshProducts = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productList)).BeginInit();
            this.SuspendLayout();
            // 
            // productMangTitle
            // 
            this.productMangTitle.AutoSize = true;
            this.productMangTitle.Font = new System.Drawing.Font("Montserrat Medium", 20F, System.Drawing.FontStyle.Bold);
            this.productMangTitle.ForeColor = System.Drawing.Color.Black;
            this.productMangTitle.Location = new System.Drawing.Point(80, 25);
            this.productMangTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.productMangTitle.Name = "productMangTitle";
            this.productMangTitle.Size = new System.Drawing.Size(320, 37);
            this.productMangTitle.TabIndex = 0;
            this.productMangTitle.Text = "Product Managment";
            // 
            // productList
            // 
            this.productList.AllowUserToAddRows = false;
            this.productList.AllowUserToDeleteRows = false;
            this.productList.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productList.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.productList.Location = new System.Drawing.Point(87, 175);
            this.productList.Margin = new System.Windows.Forms.Padding(1);
            this.productList.Name = "productList";
            this.productList.ReadOnly = true;
            this.productList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productList.Size = new System.Drawing.Size(730, 300);
            this.productList.TabIndex = 1;
            this.productList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productList_CellContentClick);
            // 
            // btnRefreshProducts
            // 
            this.btnRefreshProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(128)))), ((int)(((byte)(126)))));
            this.btnRefreshProducts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(204)))), ((int)(((byte)(155)))));
            this.btnRefreshProducts.FlatAppearance.BorderSize = 0;
            this.btnRefreshProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshProducts.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefreshProducts.Image = global::PFAproject.Properties.Resources.refresh;
            this.btnRefreshProducts.Location = new System.Drawing.Point(555, 116);
            this.btnRefreshProducts.Name = "btnRefreshProducts";
            this.btnRefreshProducts.Size = new System.Drawing.Size(72, 44);
            this.btnRefreshProducts.TabIndex = 9;
            this.btnRefreshProducts.UseVisualStyleBackColor = false;
            this.btnRefreshProducts.Click += new System.EventHandler(this.btnRefreshProducts_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(128)))), ((int)(((byte)(126)))));
            this.btnUpdateProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(204)))), ((int)(((byte)(155)))));
            this.btnUpdateProduct.FlatAppearance.BorderSize = 0;
            this.btnUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProduct.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdateProduct.Image = global::PFAproject.Properties.Resources.update;
            this.btnUpdateProduct.Location = new System.Drawing.Point(652, 116);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(72, 44);
            this.btnUpdateProduct.TabIndex = 8;
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(128)))), ((int)(((byte)(126)))));
            this.btnDeleteProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(204)))), ((int)(((byte)(155)))));
            this.btnDeleteProduct.FlatAppearance.BorderSize = 0;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeleteProduct.Image = global::PFAproject.Properties.Resources.delete;
            this.btnDeleteProduct.Location = new System.Drawing.Point(745, 116);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(72, 44);
            this.btnDeleteProduct.TabIndex = 7;
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(128)))), ((int)(((byte)(126)))));
            this.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(204)))), ((int)(((byte)(155)))));
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.Image = global::PFAproject.Properties.Resources.add;
            this.btnAddProduct.Location = new System.Drawing.Point(87, 116);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(72, 44);
            this.btnAddProduct.TabIndex = 6;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // UCProductsManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRefreshProducts);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.productMangTitle);
            this.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "UCProductsManagment";
            this.Size = new System.Drawing.Size(900, 550);
            this.Load += new System.EventHandler(this.UCProductsManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productMangTitle;
        private System.Windows.Forms.DataGridView productList;
        public System.Windows.Forms.Button btnRefreshProducts;
        public System.Windows.Forms.Button btnUpdateProduct;
        public System.Windows.Forms.Button btnDeleteProduct;
        public System.Windows.Forms.Button btnAddProduct;
    }
}
