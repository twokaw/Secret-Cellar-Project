namespace SecretCellarProject
{
    partial class frmDrinksFoodCustom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrinksFoodCustom));
            this.dataGridNonBarcodedInventory = new System.Windows.Forms.DataGridView();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridItemsToAdddToSale = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNonBarcodedInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItemsToAdddToSale)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridNonBarcodedInventory
            // 
            this.dataGridNonBarcodedInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNonBarcodedInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcode,
            this.ItemClass,
            this.ItemDesc,
            this.Price});
            this.dataGridNonBarcodedInventory.Location = new System.Drawing.Point(12, 169);
            this.dataGridNonBarcodedInventory.Name = "dataGridNonBarcodedInventory";
            this.dataGridNonBarcodedInventory.RowHeadersWidth = 62;
            this.dataGridNonBarcodedInventory.Size = new System.Drawing.Size(444, 240);
            this.dataGridNonBarcodedInventory.TabIndex = 0;
            this.dataGridNonBarcodedInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNonBarcodedInventory_CellContentClick);
            // 
            // Barcode
            // 
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.MinimumWidth = 8;
            this.Barcode.Name = "Barcode";
            this.Barcode.Width = 150;
            // 
            // ItemClass
            // 
            this.ItemClass.HeaderText = "Item Class";
            this.ItemClass.MinimumWidth = 8;
            this.ItemClass.Name = "ItemClass";
            this.ItemClass.Width = 150;
            // 
            // ItemDesc
            // 
            this.ItemDesc.HeaderText = "Item Desc.";
            this.ItemDesc.MinimumWidth = 8;
            this.ItemDesc.Name = "ItemDesc";
            this.ItemDesc.Width = 150;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.Width = 150;
            // 
            // dataGridItemsToAdddToSale
            // 
            this.dataGridItemsToAdddToSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItemsToAdddToSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridItemsToAdddToSale.Location = new System.Drawing.Point(554, 169);
            this.dataGridItemsToAdddToSale.Name = "dataGridItemsToAdddToSale";
            this.dataGridItemsToAdddToSale.RowHeadersWidth = 62;
            this.dataGridItemsToAdddToSale.Size = new System.Drawing.Size(444, 240);
            this.dataGridItemsToAdddToSale.TabIndex = 1;
            this.dataGridItemsToAdddToSale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridItemsToAdddToSale_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Barcode";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Item Class";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Item Desc.";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label1.Location = new System.Drawing.Point(72, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Non Barcode Inventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label2.Location = new System.Drawing.Point(621, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Items to Add to Sale";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnCancel.Location = new System.Drawing.Point(84, 433);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(161, 107);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnAddItem.Location = new System.Drawing.Point(765, 433);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(161, 107);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.Text = "Add Item(s)";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnRemoveItem.Location = new System.Drawing.Point(538, 433);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(161, 107);
            this.btnRemoveItem.TabIndex = 6;
            this.btnRemoveItem.Text = "Remove Item(s)";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnClearAll.Location = new System.Drawing.Point(311, 433);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(161, 107);
            this.btnClearAll.TabIndex = 7;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // frmDrinksFoodCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 578);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridItemsToAdddToSale);
            this.Controls.Add(this.dataGridNonBarcodedInventory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDrinksFoodCustom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Drinks/Food/Custom";
            this.Load += new System.EventHandler(this.frmDrinksFoodCustom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNonBarcodedInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItemsToAdddToSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridNonBarcodedInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridView dataGridItemsToAdddToSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnClearAll;
    }
}