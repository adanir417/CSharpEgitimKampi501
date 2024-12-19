namespace CSharpEgitimKampi501
{
    partial class Form1
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
            this.lbl_ProductID = new System.Windows.Forms.Label();
            this.textBox_ProductID = new System.Windows.Forms.TextBox();
            this.btn_ListProduct = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.btn_DeleteProduct = new System.Windows.Forms.Button();
            this.btn_UpdateProduct = new System.Windows.Forms.Button();
            this.btn_GetProductByID = new System.Windows.Forms.Button();
            this.textBox_ProductName = new System.Windows.Forms.TextBox();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.textBox_ProductStock = new System.Windows.Forms.TextBox();
            this.lbl_ProductStock = new System.Windows.Forms.Label();
            this.textBox_ProductPrice = new System.Windows.Forms.TextBox();
            this.lbl_ProductPrice = new System.Windows.Forms.Label();
            this.textBox_ProductCategory = new System.Windows.Forms.TextBox();
            this.lbl_ProductCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ProductID
            // 
            this.lbl_ProductID.AutoSize = true;
            this.lbl_ProductID.Location = new System.Drawing.Point(50, 51);
            this.lbl_ProductID.Name = "lbl_ProductID";
            this.lbl_ProductID.Size = new System.Drawing.Size(47, 13);
            this.lbl_ProductID.TabIndex = 0;
            this.lbl_ProductID.Text = "Ürün ID:";
            // 
            // textBox_ProductID
            // 
            this.textBox_ProductID.Location = new System.Drawing.Point(125, 48);
            this.textBox_ProductID.Name = "textBox_ProductID";
            this.textBox_ProductID.Size = new System.Drawing.Size(183, 20);
            this.textBox_ProductID.TabIndex = 1;
            // 
            // btn_ListProduct
            // 
            this.btn_ListProduct.Location = new System.Drawing.Point(73, 239);
            this.btn_ListProduct.Name = "btn_ListProduct";
            this.btn_ListProduct.Size = new System.Drawing.Size(178, 29);
            this.btn_ListProduct.TabIndex = 2;
            this.btn_ListProduct.Text = "Listele";
            this.btn_ListProduct.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(356, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(903, 965);
            this.dataGridView1.TabIndex = 3;
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Location = new System.Drawing.Point(73, 274);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(178, 29);
            this.btn_AddProduct.TabIndex = 4;
            this.btn_AddProduct.Text = "Ekle";
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteProduct
            // 
            this.btn_DeleteProduct.Location = new System.Drawing.Point(73, 309);
            this.btn_DeleteProduct.Name = "btn_DeleteProduct";
            this.btn_DeleteProduct.Size = new System.Drawing.Size(178, 29);
            this.btn_DeleteProduct.TabIndex = 5;
            this.btn_DeleteProduct.Text = "Sil";
            this.btn_DeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btn_UpdateProduct
            // 
            this.btn_UpdateProduct.Location = new System.Drawing.Point(73, 344);
            this.btn_UpdateProduct.Name = "btn_UpdateProduct";
            this.btn_UpdateProduct.Size = new System.Drawing.Size(178, 29);
            this.btn_UpdateProduct.TabIndex = 6;
            this.btn_UpdateProduct.Text = "Güncelle";
            this.btn_UpdateProduct.UseVisualStyleBackColor = true;
            // 
            // btn_GetProductByID
            // 
            this.btn_GetProductByID.Location = new System.Drawing.Point(73, 379);
            this.btn_GetProductByID.Name = "btn_GetProductByID";
            this.btn_GetProductByID.Size = new System.Drawing.Size(178, 29);
            this.btn_GetProductByID.TabIndex = 7;
            this.btn_GetProductByID.Text = "ID\'e göre getir";
            this.btn_GetProductByID.UseVisualStyleBackColor = true;
            // 
            // textBox_ProductName
            // 
            this.textBox_ProductName.Location = new System.Drawing.Point(125, 81);
            this.textBox_ProductName.Name = "textBox_ProductName";
            this.textBox_ProductName.Size = new System.Drawing.Size(183, 20);
            this.textBox_ProductName.TabIndex = 9;
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Location = new System.Drawing.Point(50, 84);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(51, 13);
            this.lbl_ProductName.TabIndex = 8;
            this.lbl_ProductName.Text = "Ürün Adı:";
            // 
            // textBox_ProductStock
            // 
            this.textBox_ProductStock.Location = new System.Drawing.Point(125, 114);
            this.textBox_ProductStock.Name = "textBox_ProductStock";
            this.textBox_ProductStock.Size = new System.Drawing.Size(183, 20);
            this.textBox_ProductStock.TabIndex = 11;
            // 
            // lbl_ProductStock
            // 
            this.lbl_ProductStock.AutoSize = true;
            this.lbl_ProductStock.Location = new System.Drawing.Point(50, 117);
            this.lbl_ProductStock.Name = "lbl_ProductStock";
            this.lbl_ProductStock.Size = new System.Drawing.Size(61, 13);
            this.lbl_ProductStock.TabIndex = 10;
            this.lbl_ProductStock.Text = "Ürün Stok: ";
            // 
            // textBox_ProductPrice
            // 
            this.textBox_ProductPrice.Location = new System.Drawing.Point(125, 147);
            this.textBox_ProductPrice.Name = "textBox_ProductPrice";
            this.textBox_ProductPrice.Size = new System.Drawing.Size(183, 20);
            this.textBox_ProductPrice.TabIndex = 13;
            // 
            // lbl_ProductPrice
            // 
            this.lbl_ProductPrice.AutoSize = true;
            this.lbl_ProductPrice.Location = new System.Drawing.Point(50, 150);
            this.lbl_ProductPrice.Name = "lbl_ProductPrice";
            this.lbl_ProductPrice.Size = new System.Drawing.Size(32, 13);
            this.lbl_ProductPrice.TabIndex = 12;
            this.lbl_ProductPrice.Text = "Fiyat:";
            // 
            // textBox_ProductCategory
            // 
            this.textBox_ProductCategory.Location = new System.Drawing.Point(125, 180);
            this.textBox_ProductCategory.Name = "textBox_ProductCategory";
            this.textBox_ProductCategory.Size = new System.Drawing.Size(183, 20);
            this.textBox_ProductCategory.TabIndex = 15;
            // 
            // lbl_ProductCategory
            // 
            this.lbl_ProductCategory.AutoSize = true;
            this.lbl_ProductCategory.Location = new System.Drawing.Point(50, 183);
            this.lbl_ProductCategory.Name = "lbl_ProductCategory";
            this.lbl_ProductCategory.Size = new System.Drawing.Size(49, 13);
            this.lbl_ProductCategory.TabIndex = 14;
            this.lbl_ProductCategory.Text = "Kategori:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1284, 1031);
            this.Controls.Add(this.textBox_ProductCategory);
            this.Controls.Add(this.lbl_ProductCategory);
            this.Controls.Add(this.textBox_ProductPrice);
            this.Controls.Add(this.lbl_ProductPrice);
            this.Controls.Add(this.textBox_ProductStock);
            this.Controls.Add(this.lbl_ProductStock);
            this.Controls.Add(this.textBox_ProductName);
            this.Controls.Add(this.lbl_ProductName);
            this.Controls.Add(this.btn_GetProductByID);
            this.Controls.Add(this.btn_UpdateProduct);
            this.Controls.Add(this.btn_DeleteProduct);
            this.Controls.Add(this.btn_AddProduct);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_ListProduct);
            this.Controls.Add(this.textBox_ProductID);
            this.Controls.Add(this.lbl_ProductID);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ProductID;
        private System.Windows.Forms.TextBox textBox_ProductID;
        private System.Windows.Forms.Button btn_ListProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Button btn_DeleteProduct;
        private System.Windows.Forms.Button btn_UpdateProduct;
        private System.Windows.Forms.Button btn_GetProductByID;
        private System.Windows.Forms.TextBox textBox_ProductName;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.TextBox textBox_ProductStock;
        private System.Windows.Forms.Label lbl_ProductStock;
        private System.Windows.Forms.TextBox textBox_ProductPrice;
        private System.Windows.Forms.Label lbl_ProductPrice;
        private System.Windows.Forms.TextBox textBox_ProductCategory;
        private System.Windows.Forms.Label lbl_ProductCategory;
    }
}

