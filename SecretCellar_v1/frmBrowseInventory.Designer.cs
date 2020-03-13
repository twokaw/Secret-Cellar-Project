namespace SecretCellar
{
    partial class frmBrowseInventory
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "frmBrowseInventory";
            this.dataGridinventory = new System.Windows.Forms.DataGridView();
            this.ITEM_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INV_COUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUPPLIER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALES_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRadioShowAll = new System.Windows.Forms.RadioButton();
            this.btnRadioShowInStock = new System.Windows.Forms.RadioButton();
            this.btnRadioShowOutOfStock = new System.Windows.Forms.RadioButton();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridinventory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridinventory
            // 
            this.dataGridinventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridinventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridinventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ITEM_ID,
            this.ITEM_DESC,
            this.CLASS,
            this.INV_COUNT,
            this.SUPPLIER,
            this.SALES_PRICE});
            this.dataGridinventory.Location = new System.Drawing.Point(34, 12);
            this.dataGridinventory.Name = "dataGridinventory";
            this.dataGridinventory.RowHeadersVisible = false;
            this.dataGridinventory.Size = new System.Drawing.Size(732, 302);
            this.dataGridinventory.TabIndex = 0;
            this.dataGridinventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ITEM_ID
            // 
            this.ITEM_ID.HeaderText = "ITEM ID";
            this.ITEM_ID.Name = "ITEM_ID";
            // 
            // ITEM_DESC
            // 
            this.ITEM_DESC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ITEM_DESC.HeaderText = "ITEM DESC";
            this.ITEM_DESC.Name = "ITEM_DESC";
            // 
            // CLASS
            // 
            this.CLASS.HeaderText = "CLASS";
            this.CLASS.Name = "CLASS";
            // 
            // INV_COUNT
            // 
            this.INV_COUNT.HeaderText = "INV COUNT";
            this.INV_COUNT.Name = "INV_COUNT";
            // 
            // SUPPLIER
            // 
            this.SUPPLIER.HeaderText = "SUPPLIER";
            this.SUPPLIER.Name = "SUPPLIER";
            // 
            // SALES_PRICE
            // 
            this.SALES_PRICE.HeaderText = "SALES PRICE";
            this.SALES_PRICE.Name = "SALES_PRICE";
            // 
            // btnRadioShowAll
            // 
            this.btnRadioShowAll.AutoSize = true;
            this.btnRadioShowAll.Location = new System.Drawing.Point(36, 334);
            this.btnRadioShowAll.Name = "btnRadioShowAll";
            this.btnRadioShowAll.Size = new System.Drawing.Size(66, 17);
            this.btnRadioShowAll.TabIndex = 3;
            this.btnRadioShowAll.TabStop = true;
            this.btnRadioShowAll.Text = "Show All";
            this.btnRadioShowAll.UseVisualStyleBackColor = true;
            this.btnRadioShowAll.CheckedChanged += new System.EventHandler(this.btnRadioShowAll_CheckedChanged);
            // 
            // btnRadioShowInStock
            // 
            this.btnRadioShowInStock.AutoSize = true;
            this.btnRadioShowInStock.Location = new System.Drawing.Point(108, 334);
            this.btnRadioShowInStock.Name = "btnRadioShowInStock";
            this.btnRadioShowInStock.Size = new System.Drawing.Size(94, 17);
            this.btnRadioShowInStock.TabIndex = 4;
            this.btnRadioShowInStock.TabStop = true;
            this.btnRadioShowInStock.Text = "Show in Stock";
            this.btnRadioShowInStock.UseVisualStyleBackColor = true;
            this.btnRadioShowInStock.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnRadioShowOutOfStock
            // 
            this.btnRadioShowOutOfStock.AutoSize = true;
            this.btnRadioShowOutOfStock.Location = new System.Drawing.Point(208, 334);
            this.btnRadioShowOutOfStock.Name = "btnRadioShowOutOfStock";
            this.btnRadioShowOutOfStock.Size = new System.Drawing.Size(115, 17);
            this.btnRadioShowOutOfStock.TabIndex = 5;
            this.btnRadioShowOutOfStock.TabStop = true;
            this.btnRadioShowOutOfStock.Text = "Show Out of Stock";
            this.btnRadioShowOutOfStock.UseVisualStyleBackColor = true;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(34, 381);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(168, 20);
            this.txtBoxSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(208, 379);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(389, 334);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(107, 104);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(524, 334);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(107, 104);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(650, 334);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(107, 104);
            this.btnMainMenu.TabIndex = 10;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            // 
            // frmBrowseInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.btnRadioShowOutOfStock);
            this.Controls.Add(this.btnRadioShowInStock);
            this.Controls.Add(this.btnRadioShowAll);
            this.Controls.Add(this.dataGridinventory);
            this.Name = "frmBrowseInventory";
            this.Text = "Browse Inventory";
            this.Load += new System.EventHandler(this.frmBrowseInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridinventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.DataGridView dataGridinventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLASS;
        private System.Windows.Forms.DataGridViewTextBoxColumn INV_COUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUPPLIER;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALES_PRICE;
        private System.Windows.Forms.RadioButton btnRadioShowAll;
        private System.Windows.Forms.RadioButton btnRadioShowInStock;
        private System.Windows.Forms.RadioButton btnRadioShowOutOfStock;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnMainMenu;
        #endregion
    }
}