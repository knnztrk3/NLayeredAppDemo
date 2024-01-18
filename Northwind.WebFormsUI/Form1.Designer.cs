
namespace Northwind.WebFormsUI
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
			this.dgwProduct = new System.Windows.Forms.DataGridView();
			this.gbxCategory = new System.Windows.Forms.GroupBox();
			this.cbxCategory = new System.Windows.Forms.ComboBox();
			this.lblCategory = new System.Windows.Forms.Label();
			this.gbxProductName = new System.Windows.Forms.GroupBox();
			this.tbxProductName = new System.Windows.Forms.TextBox();
			this.lblProductName = new System.Windows.Forms.Label();
			this.gbxProductAdd = new System.Windows.Forms.GroupBox();
			this.lblProductName2 = new System.Windows.Forms.Label();
			this.lblCategoryID = new System.Windows.Forms.Label();
			this.lblUnitPrice = new System.Windows.Forms.Label();
			this.lblStock = new System.Windows.Forms.Label();
			this.lblQuantityPerUnit = new System.Windows.Forms.Label();
			this.tbxProductName2 = new System.Windows.Forms.TextBox();
			this.cbxCategory2 = new System.Windows.Forms.ComboBox();
			this.tbxPrice = new System.Windows.Forms.TextBox();
			this.tbxStock = new System.Windows.Forms.TextBox();
			this.tbxQuantityPerUnit = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.gbxUpdate = new System.Windows.Forms.GroupBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.tbxQuantityPerUnitUpdate = new System.Windows.Forms.TextBox();
			this.tbxUnitsInStockUpdate = new System.Windows.Forms.TextBox();
			this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
			this.cbxCategoryIdUpdate = new System.Windows.Forms.ComboBox();
			this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
			this.lblUnitsInStockUpdate = new System.Windows.Forms.Label();
			this.lblStockAmountUpdate = new System.Windows.Forms.Label();
			this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
			this.lblCategoryIdUpdate = new System.Windows.Forms.Label();
			this.lblProductNameUpdate = new System.Windows.Forms.Label();
			this.btnRemove = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
			this.gbxCategory.SuspendLayout();
			this.gbxProductName.SuspendLayout();
			this.gbxProductAdd.SuspendLayout();
			this.gbxUpdate.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgwProduct
			// 
			this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwProduct.Location = new System.Drawing.Point(12, 395);
			this.dgwProduct.Name = "dgwProduct";
			this.dgwProduct.Size = new System.Drawing.Size(776, 208);
			this.dgwProduct.TabIndex = 0;
			this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
			// 
			// gbxCategory
			// 
			this.gbxCategory.Controls.Add(this.cbxCategory);
			this.gbxCategory.Controls.Add(this.lblCategory);
			this.gbxCategory.Location = new System.Drawing.Point(12, 12);
			this.gbxCategory.Name = "gbxCategory";
			this.gbxCategory.Size = new System.Drawing.Size(764, 74);
			this.gbxCategory.TabIndex = 1;
			this.gbxCategory.TabStop = false;
			this.gbxCategory.Text = "Kategoriye Göre Ara";
			// 
			// cbxCategory
			// 
			this.cbxCategory.FormattingEnabled = true;
			this.cbxCategory.Location = new System.Drawing.Point(72, 27);
			this.cbxCategory.Name = "cbxCategory";
			this.cbxCategory.Size = new System.Drawing.Size(176, 21);
			this.cbxCategory.TabIndex = 1;
			this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
			// 
			// lblCategory
			// 
			this.lblCategory.AutoSize = true;
			this.lblCategory.Location = new System.Drawing.Point(6, 27);
			this.lblCategory.Name = "lblCategory";
			this.lblCategory.Size = new System.Drawing.Size(52, 13);
			this.lblCategory.TabIndex = 0;
			this.lblCategory.Text = "Kategori :";
			// 
			// gbxProductName
			// 
			this.gbxProductName.Controls.Add(this.tbxProductName);
			this.gbxProductName.Controls.Add(this.lblProductName);
			this.gbxProductName.Location = new System.Drawing.Point(12, 92);
			this.gbxProductName.Name = "gbxProductName";
			this.gbxProductName.Size = new System.Drawing.Size(764, 72);
			this.gbxProductName.TabIndex = 2;
			this.gbxProductName.TabStop = false;
			this.gbxProductName.Text = "Ürün Adına Göre Ara";
			// 
			// tbxProductName
			// 
			this.tbxProductName.Location = new System.Drawing.Point(72, 34);
			this.tbxProductName.Name = "tbxProductName";
			this.tbxProductName.Size = new System.Drawing.Size(176, 20);
			this.tbxProductName.TabIndex = 1;
			this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
			// 
			// lblProductName
			// 
			this.lblProductName.AutoSize = true;
			this.lblProductName.Location = new System.Drawing.Point(9, 37);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(54, 13);
			this.lblProductName.TabIndex = 0;
			this.lblProductName.Text = "Ürün Adı :";
			// 
			// gbxProductAdd
			// 
			this.gbxProductAdd.Controls.Add(this.btnAdd);
			this.gbxProductAdd.Controls.Add(this.tbxQuantityPerUnit);
			this.gbxProductAdd.Controls.Add(this.tbxStock);
			this.gbxProductAdd.Controls.Add(this.tbxPrice);
			this.gbxProductAdd.Controls.Add(this.cbxCategory2);
			this.gbxProductAdd.Controls.Add(this.tbxProductName2);
			this.gbxProductAdd.Controls.Add(this.lblQuantityPerUnit);
			this.gbxProductAdd.Controls.Add(this.lblStock);
			this.gbxProductAdd.Controls.Add(this.lblUnitPrice);
			this.gbxProductAdd.Controls.Add(this.lblCategoryID);
			this.gbxProductAdd.Controls.Add(this.lblProductName2);
			this.gbxProductAdd.Location = new System.Drawing.Point(12, 180);
			this.gbxProductAdd.Name = "gbxProductAdd";
			this.gbxProductAdd.Size = new System.Drawing.Size(233, 197);
			this.gbxProductAdd.TabIndex = 3;
			this.gbxProductAdd.TabStop = false;
			this.gbxProductAdd.Text = "Yeni Ürün Ekle";
			// 
			// lblProductName2
			// 
			this.lblProductName2.AutoSize = true;
			this.lblProductName2.Location = new System.Drawing.Point(17, 26);
			this.lblProductName2.Name = "lblProductName2";
			this.lblProductName2.Size = new System.Drawing.Size(54, 13);
			this.lblProductName2.TabIndex = 0;
			this.lblProductName2.Text = "Ürün Adı :";
			// 
			// lblCategoryID
			// 
			this.lblCategoryID.AutoSize = true;
			this.lblCategoryID.Location = new System.Drawing.Point(19, 54);
			this.lblCategoryID.Name = "lblCategoryID";
			this.lblCategoryID.Size = new System.Drawing.Size(52, 13);
			this.lblCategoryID.TabIndex = 1;
			this.lblCategoryID.Text = "Kategori :";
			// 
			// lblUnitPrice
			// 
			this.lblUnitPrice.AutoSize = true;
			this.lblUnitPrice.Location = new System.Drawing.Point(36, 81);
			this.lblUnitPrice.Name = "lblUnitPrice";
			this.lblUnitPrice.Size = new System.Drawing.Size(35, 13);
			this.lblUnitPrice.TabIndex = 2;
			this.lblUnitPrice.Text = "Fiyat :";
			// 
			// lblStock
			// 
			this.lblStock.AutoSize = true;
			this.lblStock.Location = new System.Drawing.Point(6, 108);
			this.lblStock.Name = "lblStock";
			this.lblStock.Size = new System.Drawing.Size(65, 13);
			this.lblStock.TabIndex = 3;
			this.lblStock.Text = "Stok Adedi :";
			// 
			// lblQuantityPerUnit
			// 
			this.lblQuantityPerUnit.AutoSize = true;
			this.lblQuantityPerUnit.Location = new System.Drawing.Point(6, 138);
			this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
			this.lblQuantityPerUnit.Size = new System.Drawing.Size(65, 13);
			this.lblQuantityPerUnit.TabIndex = 4;
			this.lblQuantityPerUnit.Text = "Birim Adedi :";
			// 
			// tbxProductName2
			// 
			this.tbxProductName2.Location = new System.Drawing.Point(77, 23);
			this.tbxProductName2.Name = "tbxProductName2";
			this.tbxProductName2.Size = new System.Drawing.Size(121, 20);
			this.tbxProductName2.TabIndex = 5;
			// 
			// cbxCategory2
			// 
			this.cbxCategory2.FormattingEnabled = true;
			this.cbxCategory2.Location = new System.Drawing.Point(77, 51);
			this.cbxCategory2.Name = "cbxCategory2";
			this.cbxCategory2.Size = new System.Drawing.Size(121, 21);
			this.cbxCategory2.TabIndex = 6;
			// 
			// tbxPrice
			// 
			this.tbxPrice.Location = new System.Drawing.Point(77, 78);
			this.tbxPrice.Name = "tbxPrice";
			this.tbxPrice.Size = new System.Drawing.Size(121, 20);
			this.tbxPrice.TabIndex = 7;
			// 
			// tbxStock
			// 
			this.tbxStock.Location = new System.Drawing.Point(77, 105);
			this.tbxStock.Name = "tbxStock";
			this.tbxStock.Size = new System.Drawing.Size(121, 20);
			this.tbxStock.TabIndex = 8;
			// 
			// tbxQuantityPerUnit
			// 
			this.tbxQuantityPerUnit.Location = new System.Drawing.Point(77, 135);
			this.tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
			this.tbxQuantityPerUnit.Size = new System.Drawing.Size(121, 20);
			this.tbxQuantityPerUnit.TabIndex = 4;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(100, 161);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 9;
			this.btnAdd.Text = "Ekle";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// gbxUpdate
			// 
			this.gbxUpdate.Controls.Add(this.btnUpdate);
			this.gbxUpdate.Controls.Add(this.tbxQuantityPerUnitUpdate);
			this.gbxUpdate.Controls.Add(this.tbxUnitsInStockUpdate);
			this.gbxUpdate.Controls.Add(this.tbxUnitPriceUpdate);
			this.gbxUpdate.Controls.Add(this.cbxCategoryIdUpdate);
			this.gbxUpdate.Controls.Add(this.tbxProductNameUpdate);
			this.gbxUpdate.Controls.Add(this.lblUnitsInStockUpdate);
			this.gbxUpdate.Controls.Add(this.lblStockAmountUpdate);
			this.gbxUpdate.Controls.Add(this.lblUnitPriceUpdate);
			this.gbxUpdate.Controls.Add(this.lblCategoryIdUpdate);
			this.gbxUpdate.Controls.Add(this.lblProductNameUpdate);
			this.gbxUpdate.Location = new System.Drawing.Point(355, 180);
			this.gbxUpdate.Name = "gbxUpdate";
			this.gbxUpdate.Size = new System.Drawing.Size(233, 197);
			this.gbxUpdate.TabIndex = 10;
			this.gbxUpdate.TabStop = false;
			this.gbxUpdate.Text = "Ürün Güncelle";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(100, 161);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 9;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// tbxQuantityPerUnitUpdate
			// 
			this.tbxQuantityPerUnitUpdate.Location = new System.Drawing.Point(77, 135);
			this.tbxQuantityPerUnitUpdate.Name = "tbxQuantityPerUnitUpdate";
			this.tbxQuantityPerUnitUpdate.Size = new System.Drawing.Size(121, 20);
			this.tbxQuantityPerUnitUpdate.TabIndex = 4;
			// 
			// tbxUnitsInStockUpdate
			// 
			this.tbxUnitsInStockUpdate.Location = new System.Drawing.Point(77, 105);
			this.tbxUnitsInStockUpdate.Name = "tbxUnitsInStockUpdate";
			this.tbxUnitsInStockUpdate.Size = new System.Drawing.Size(121, 20);
			this.tbxUnitsInStockUpdate.TabIndex = 8;
			// 
			// tbxUnitPriceUpdate
			// 
			this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(77, 78);
			this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
			this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(121, 20);
			this.tbxUnitPriceUpdate.TabIndex = 7;
			// 
			// cbxCategoryIdUpdate
			// 
			this.cbxCategoryIdUpdate.FormattingEnabled = true;
			this.cbxCategoryIdUpdate.Location = new System.Drawing.Point(77, 51);
			this.cbxCategoryIdUpdate.Name = "cbxCategoryIdUpdate";
			this.cbxCategoryIdUpdate.Size = new System.Drawing.Size(121, 21);
			this.cbxCategoryIdUpdate.TabIndex = 6;
			// 
			// tbxProductNameUpdate
			// 
			this.tbxProductNameUpdate.Location = new System.Drawing.Point(77, 23);
			this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
			this.tbxProductNameUpdate.Size = new System.Drawing.Size(121, 20);
			this.tbxProductNameUpdate.TabIndex = 5;
			// 
			// lblUnitsInStockUpdate
			// 
			this.lblUnitsInStockUpdate.AutoSize = true;
			this.lblUnitsInStockUpdate.Location = new System.Drawing.Point(6, 138);
			this.lblUnitsInStockUpdate.Name = "lblUnitsInStockUpdate";
			this.lblUnitsInStockUpdate.Size = new System.Drawing.Size(65, 13);
			this.lblUnitsInStockUpdate.TabIndex = 4;
			this.lblUnitsInStockUpdate.Text = "Birim Adedi :";
			// 
			// lblStockAmountUpdate
			// 
			this.lblStockAmountUpdate.AutoSize = true;
			this.lblStockAmountUpdate.Location = new System.Drawing.Point(6, 108);
			this.lblStockAmountUpdate.Name = "lblStockAmountUpdate";
			this.lblStockAmountUpdate.Size = new System.Drawing.Size(65, 13);
			this.lblStockAmountUpdate.TabIndex = 3;
			this.lblStockAmountUpdate.Text = "Stok Adedi :";
			// 
			// lblUnitPriceUpdate
			// 
			this.lblUnitPriceUpdate.AutoSize = true;
			this.lblUnitPriceUpdate.Location = new System.Drawing.Point(36, 81);
			this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
			this.lblUnitPriceUpdate.Size = new System.Drawing.Size(35, 13);
			this.lblUnitPriceUpdate.TabIndex = 2;
			this.lblUnitPriceUpdate.Text = "Fiyat :";
			// 
			// lblCategoryIdUpdate
			// 
			this.lblCategoryIdUpdate.AutoSize = true;
			this.lblCategoryIdUpdate.Location = new System.Drawing.Point(19, 54);
			this.lblCategoryIdUpdate.Name = "lblCategoryIdUpdate";
			this.lblCategoryIdUpdate.Size = new System.Drawing.Size(52, 13);
			this.lblCategoryIdUpdate.TabIndex = 1;
			this.lblCategoryIdUpdate.Text = "Kategori :";
			// 
			// lblProductNameUpdate
			// 
			this.lblProductNameUpdate.AutoSize = true;
			this.lblProductNameUpdate.Location = new System.Drawing.Point(17, 26);
			this.lblProductNameUpdate.Name = "lblProductNameUpdate";
			this.lblProductNameUpdate.Size = new System.Drawing.Size(54, 13);
			this.lblProductNameUpdate.TabIndex = 0;
			this.lblProductNameUpdate.Text = "Ürün Adı :";
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(263, 341);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(75, 23);
			this.btnRemove.TabIndex = 11;
			this.btnRemove.Text = "Sil";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 615);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.gbxUpdate);
			this.Controls.Add(this.gbxProductAdd);
			this.Controls.Add(this.gbxProductName);
			this.Controls.Add(this.gbxCategory);
			this.Controls.Add(this.dgwProduct);
			this.Name = "Form1";
			this.Text = "Ürünler - İşlem sayfam";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
			this.gbxCategory.ResumeLayout(false);
			this.gbxCategory.PerformLayout();
			this.gbxProductName.ResumeLayout(false);
			this.gbxProductName.PerformLayout();
			this.gbxProductAdd.ResumeLayout(false);
			this.gbxProductAdd.PerformLayout();
			this.gbxUpdate.ResumeLayout(false);
			this.gbxUpdate.PerformLayout();
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
		private System.Windows.Forms.Label lblUnitPrice;
		private System.Windows.Forms.Label lblCategoryID;
		private System.Windows.Forms.Label lblProductName2;
		private System.Windows.Forms.Label lblQuantityPerUnit;
		private System.Windows.Forms.Label lblStock;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox tbxQuantityPerUnit;
		private System.Windows.Forms.TextBox tbxStock;
		private System.Windows.Forms.TextBox tbxPrice;
		private System.Windows.Forms.ComboBox cbxCategory2;
		private System.Windows.Forms.TextBox tbxProductName2;
		private System.Windows.Forms.GroupBox gbxUpdate;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.TextBox tbxQuantityPerUnitUpdate;
		private System.Windows.Forms.TextBox tbxUnitsInStockUpdate;
		private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
		private System.Windows.Forms.ComboBox cbxCategoryIdUpdate;
		private System.Windows.Forms.TextBox tbxProductNameUpdate;
		private System.Windows.Forms.Label lblUnitsInStockUpdate;
		private System.Windows.Forms.Label lblStockAmountUpdate;
		private System.Windows.Forms.Label lblUnitPriceUpdate;
		private System.Windows.Forms.Label lblCategoryIdUpdate;
		private System.Windows.Forms.Label lblProductNameUpdate;
		private System.Windows.Forms.Button btnRemove;
	}
}

