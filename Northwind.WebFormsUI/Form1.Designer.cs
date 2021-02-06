
namespace Northwind.WebFormsUI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.lblProductName2 = new System.Windows.Forms.Label();
            this.tbxProductNameAdd = new System.Windows.Forms.TextBox();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.cbxCategoryId = new System.Windows.Forms.ComboBox();
            this.lblQuantityPerUnitAdd = new System.Windows.Forms.Label();
            this.tbxQuantityPerUnitAdd = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceAdd = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.tbxUnitsInStockAdd = new System.Windows.Forms.TextBox();
            this.lblUnitsInStockAdd = new System.Windows.Forms.Label();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.gbxProductUpdate = new System.Windows.Forms.GroupBox();
            this.btnProductUpdated = new System.Windows.Forms.Button();
            this.tbxUnitsInStockUpdate = new System.Windows.Forms.TextBox();
            this.lblUnitsInStockUpdate = new System.Windows.Forms.Label();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.tbxQuantityPerUnitUpdate = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnitUpdate = new System.Windows.Forms.Label();
            this.cbxCategoryIdUpdate = new System.Windows.Forms.ComboBox();
            this.lblCategoryIdUpdate = new System.Windows.Forms.Label();
            this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
            this.lblProductNameUpdate = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.gbxProductUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(22, 107);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(660, 258);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(22, 25);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(327, 67);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye göre ara";
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.tbxProductName);
            this.gbxProductName.Controls.Add(this.lblProductName);
            this.gbxProductName.Location = new System.Drawing.Point(355, 25);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(327, 67);
            this.gbxProductName.TabIndex = 2;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Ürün adına göre ara";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(22, 30);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(46, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(23, 29);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(48, 13);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(85, 21);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(206, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(86, 22);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(206, 20);
            this.tbxProductName.TabIndex = 2;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.btnProductAdd);
            this.gbxProductAdd.Controls.Add(this.tbxUnitsInStockAdd);
            this.gbxProductAdd.Controls.Add(this.lblUnitsInStockAdd);
            this.gbxProductAdd.Controls.Add(this.tbxUnitPriceAdd);
            this.gbxProductAdd.Controls.Add(this.lblUnitPrice);
            this.gbxProductAdd.Controls.Add(this.tbxQuantityPerUnitAdd);
            this.gbxProductAdd.Controls.Add(this.lblQuantityPerUnitAdd);
            this.gbxProductAdd.Controls.Add(this.cbxCategoryId);
            this.gbxProductAdd.Controls.Add(this.lblCategoryId);
            this.gbxProductAdd.Controls.Add(this.tbxProductNameAdd);
            this.gbxProductAdd.Controls.Add(this.lblProductName2);
            this.gbxProductAdd.Location = new System.Drawing.Point(22, 385);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(327, 259);
            this.gbxProductAdd.TabIndex = 3;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Ürün Ekle";
            // 
            // lblProductName2
            // 
            this.lblProductName2.AutoSize = true;
            this.lblProductName2.Location = new System.Drawing.Point(7, 32);
            this.lblProductName2.Name = "lblProductName2";
            this.lblProductName2.Size = new System.Drawing.Size(48, 13);
            this.lblProductName2.TabIndex = 0;
            this.lblProductName2.Text = "Ürün Adı";
            // 
            // tbxProductNameAdd
            // 
            this.tbxProductNameAdd.Location = new System.Drawing.Point(85, 25);
            this.tbxProductNameAdd.Name = "tbxProductNameAdd";
            this.tbxProductNameAdd.Size = new System.Drawing.Size(168, 20);
            this.tbxProductNameAdd.TabIndex = 1;
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(7, 77);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(46, 13);
            this.lblCategoryId.TabIndex = 2;
            this.lblCategoryId.Text = "Kategori";
            // 
            // cbxCategoryId
            // 
            this.cbxCategoryId.FormattingEnabled = true;
            this.cbxCategoryId.Location = new System.Drawing.Point(85, 69);
            this.cbxCategoryId.Name = "cbxCategoryId";
            this.cbxCategoryId.Size = new System.Drawing.Size(168, 21);
            this.cbxCategoryId.TabIndex = 3;
            // 
            // lblQuantityPerUnitAdd
            // 
            this.lblQuantityPerUnitAdd.AutoSize = true;
            this.lblQuantityPerUnitAdd.Location = new System.Drawing.Point(7, 116);
            this.lblQuantityPerUnitAdd.Name = "lblQuantityPerUnitAdd";
            this.lblQuantityPerUnitAdd.Size = new System.Drawing.Size(32, 13);
            this.lblQuantityPerUnitAdd.TabIndex = 4;
            this.lblQuantityPerUnitAdd.Text = "Birim ";
            // 
            // tbxQuantityPerUnitAdd
            // 
            this.tbxQuantityPerUnitAdd.Location = new System.Drawing.Point(86, 109);
            this.tbxQuantityPerUnitAdd.Name = "tbxQuantityPerUnitAdd";
            this.tbxQuantityPerUnitAdd.Size = new System.Drawing.Size(168, 20);
            this.tbxQuantityPerUnitAdd.TabIndex = 5;
            // 
            // tbxUnitPriceAdd
            // 
            this.tbxUnitPriceAdd.Location = new System.Drawing.Point(86, 150);
            this.tbxUnitPriceAdd.Name = "tbxUnitPriceAdd";
            this.tbxUnitPriceAdd.Size = new System.Drawing.Size(168, 20);
            this.tbxUnitPriceAdd.TabIndex = 7;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(7, 157);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(29, 13);
            this.lblUnitPrice.TabIndex = 6;
            this.lblUnitPrice.Text = "Fiyat";
            // 
            // tbxUnitsInStockAdd
            // 
            this.tbxUnitsInStockAdd.Location = new System.Drawing.Point(85, 185);
            this.tbxUnitsInStockAdd.Name = "tbxUnitsInStockAdd";
            this.tbxUnitsInStockAdd.Size = new System.Drawing.Size(168, 20);
            this.tbxUnitsInStockAdd.TabIndex = 9;
            // 
            // lblUnitsInStockAdd
            // 
            this.lblUnitsInStockAdd.AutoSize = true;
            this.lblUnitsInStockAdd.Location = new System.Drawing.Point(6, 192);
            this.lblUnitsInStockAdd.Name = "lblUnitsInStockAdd";
            this.lblUnitsInStockAdd.Size = new System.Drawing.Size(29, 13);
            this.lblUnitsInStockAdd.TabIndex = 8;
            this.lblUnitsInStockAdd.Text = "Stok";
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(86, 221);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(167, 32);
            this.btnProductAdd.TabIndex = 10;
            this.btnProductAdd.Text = "Ekle";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // gbxProductUpdate
            // 
            this.gbxProductUpdate.Controls.Add(this.btnRemove);
            this.gbxProductUpdate.Controls.Add(this.btnProductUpdated);
            this.gbxProductUpdate.Controls.Add(this.tbxUnitsInStockUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblUnitsInStockUpdate);
            this.gbxProductUpdate.Controls.Add(this.tbxUnitPriceUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblUnitPriceUpdate);
            this.gbxProductUpdate.Controls.Add(this.tbxQuantityPerUnitUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblQuantityPerUnitUpdate);
            this.gbxProductUpdate.Controls.Add(this.cbxCategoryIdUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblCategoryIdUpdate);
            this.gbxProductUpdate.Controls.Add(this.tbxProductNameUpdate);
            this.gbxProductUpdate.Controls.Add(this.lblProductNameUpdate);
            this.gbxProductUpdate.Location = new System.Drawing.Point(355, 385);
            this.gbxProductUpdate.Name = "gbxProductUpdate";
            this.gbxProductUpdate.Size = new System.Drawing.Size(327, 259);
            this.gbxProductUpdate.TabIndex = 4;
            this.gbxProductUpdate.TabStop = false;
            this.gbxProductUpdate.Text = "Ürün Güncelle";
            // 
            // btnProductUpdated
            // 
            this.btnProductUpdated.Location = new System.Drawing.Point(85, 221);
            this.btnProductUpdated.Name = "btnProductUpdated";
            this.btnProductUpdated.Size = new System.Drawing.Size(109, 32);
            this.btnProductUpdated.TabIndex = 10;
            this.btnProductUpdated.Text = "Güncelle";
            this.btnProductUpdated.UseVisualStyleBackColor = true;
            this.btnProductUpdated.Click += new System.EventHandler(this.btnProductUpdated_Click);
            // 
            // tbxUnitsInStockUpdate
            // 
            this.tbxUnitsInStockUpdate.Location = new System.Drawing.Point(85, 185);
            this.tbxUnitsInStockUpdate.Name = "tbxUnitsInStockUpdate";
            this.tbxUnitsInStockUpdate.Size = new System.Drawing.Size(168, 20);
            this.tbxUnitsInStockUpdate.TabIndex = 9;
            // 
            // lblUnitsInStockUpdate
            // 
            this.lblUnitsInStockUpdate.AutoSize = true;
            this.lblUnitsInStockUpdate.Location = new System.Drawing.Point(6, 192);
            this.lblUnitsInStockUpdate.Name = "lblUnitsInStockUpdate";
            this.lblUnitsInStockUpdate.Size = new System.Drawing.Size(29, 13);
            this.lblUnitsInStockUpdate.TabIndex = 8;
            this.lblUnitsInStockUpdate.Text = "Stok";
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(86, 150);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(168, 20);
            this.tbxUnitPriceUpdate.TabIndex = 7;
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(7, 157);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(29, 13);
            this.lblUnitPriceUpdate.TabIndex = 6;
            this.lblUnitPriceUpdate.Text = "Fiyat";
            // 
            // tbxQuantityPerUnitUpdate
            // 
            this.tbxQuantityPerUnitUpdate.Location = new System.Drawing.Point(86, 109);
            this.tbxQuantityPerUnitUpdate.Name = "tbxQuantityPerUnitUpdate";
            this.tbxQuantityPerUnitUpdate.Size = new System.Drawing.Size(168, 20);
            this.tbxQuantityPerUnitUpdate.TabIndex = 5;
            // 
            // lblQuantityPerUnitUpdate
            // 
            this.lblQuantityPerUnitUpdate.AutoSize = true;
            this.lblQuantityPerUnitUpdate.Location = new System.Drawing.Point(7, 116);
            this.lblQuantityPerUnitUpdate.Name = "lblQuantityPerUnitUpdate";
            this.lblQuantityPerUnitUpdate.Size = new System.Drawing.Size(32, 13);
            this.lblQuantityPerUnitUpdate.TabIndex = 4;
            this.lblQuantityPerUnitUpdate.Text = "Birim ";
            // 
            // cbxCategoryIdUpdate
            // 
            this.cbxCategoryIdUpdate.FormattingEnabled = true;
            this.cbxCategoryIdUpdate.Location = new System.Drawing.Point(85, 69);
            this.cbxCategoryIdUpdate.Name = "cbxCategoryIdUpdate";
            this.cbxCategoryIdUpdate.Size = new System.Drawing.Size(168, 21);
            this.cbxCategoryIdUpdate.TabIndex = 3;
            // 
            // lblCategoryIdUpdate
            // 
            this.lblCategoryIdUpdate.AutoSize = true;
            this.lblCategoryIdUpdate.Location = new System.Drawing.Point(7, 77);
            this.lblCategoryIdUpdate.Name = "lblCategoryIdUpdate";
            this.lblCategoryIdUpdate.Size = new System.Drawing.Size(46, 13);
            this.lblCategoryIdUpdate.TabIndex = 2;
            this.lblCategoryIdUpdate.Text = "Kategori";
            // 
            // tbxProductNameUpdate
            // 
            this.tbxProductNameUpdate.Location = new System.Drawing.Point(85, 25);
            this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            this.tbxProductNameUpdate.Size = new System.Drawing.Size(168, 20);
            this.tbxProductNameUpdate.TabIndex = 1;
            // 
            // lblProductNameUpdate
            // 
            this.lblProductNameUpdate.AutoSize = true;
            this.lblProductNameUpdate.Location = new System.Drawing.Point(7, 32);
            this.lblProductNameUpdate.Name = "lblProductNameUpdate";
            this.lblProductNameUpdate.Size = new System.Drawing.Size(48, 13);
            this.lblProductNameUpdate.TabIndex = 0;
            this.lblProductNameUpdate.Text = "Ürün Adı";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(212, 221);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(109, 32);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 643);
            this.Controls.Add(this.gbxProductUpdate);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Ürün";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.gbxProductUpdate.ResumeLayout(false);
            this.gbxProductUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.TextBox tbxUnitsInStockAdd;
        private System.Windows.Forms.Label lblUnitsInStockAdd;
        private System.Windows.Forms.TextBox tbxUnitPriceAdd;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitAdd;
        private System.Windows.Forms.Label lblQuantityPerUnitAdd;
        private System.Windows.Forms.ComboBox cbxCategoryId;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.TextBox tbxProductNameAdd;
        private System.Windows.Forms.Label lblProductName2;
        private System.Windows.Forms.GroupBox gbxProductUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnProductUpdated;
        private System.Windows.Forms.TextBox tbxUnitsInStockUpdate;
        private System.Windows.Forms.Label lblUnitsInStockUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitUpdate;
        private System.Windows.Forms.Label lblQuantityPerUnitUpdate;
        private System.Windows.Forms.ComboBox cbxCategoryIdUpdate;
        private System.Windows.Forms.Label lblCategoryIdUpdate;
        private System.Windows.Forms.TextBox tbxProductNameUpdate;
        private System.Windows.Forms.Label lblProductNameUpdate;
    }
}

