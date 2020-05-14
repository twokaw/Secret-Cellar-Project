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
            this.dataGridInventory = new System.Windows.Forms.DataGridView();
            this.rbtnRadioShowAll = new System.Windows.Forms.RadioButton();
            this.rbtnRadioShowInStock = new System.Windows.Forms.RadioButton();
            this.rbtnRadioShowOutOfStock = new System.Windows.Forms.RadioButton();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUPPLIER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridInventory
            // 
            this.dataGridInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemId,
            this.ItemDesc,
            this.CLASS,
            this.InvCount,
            this.SUPPLIER,
            this.SalesPrice});
            this.dataGridInventory.Location = new System.Drawing.Point(34, 12);
            this.dataGridInventory.Name = "dataGridInventory";
            this.dataGridInventory.RowHeadersVisible = false;
            this.dataGridInventory.Size = new System.Drawing.Size(732, 302);
            this.dataGridInventory.TabIndex = 0;
            this.dataGridInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridInventory_CellContentClick);
            // 
            // rbtnRadioShowAll
            // 
            this.rbtnRadioShowAll.AutoSize = true;
            this.rbtnRadioShowAll.Location = new System.Drawing.Point(36, 334);
            this.rbtnRadioShowAll.Name = "rbtnRadioShowAll";
            this.rbtnRadioShowAll.Size = new System.Drawing.Size(66, 17);
            this.rbtnRadioShowAll.TabIndex = 3;
            this.rbtnRadioShowAll.TabStop = true;
            this.rbtnRadioShowAll.Text = "Show All";
            this.rbtnRadioShowAll.UseVisualStyleBackColor = true;
            this.rbtnRadioShowAll.CheckedChanged += new System.EventHandler(this.rbtnRadioShowAll_CheckedChanged);
            // 
            // rbtnRadioShowInStock
            // 
            this.rbtnRadioShowInStock.AutoSize = true;
            this.rbtnRadioShowInStock.Location = new System.Drawing.Point(108, 334);
            this.rbtnRadioShowInStock.Name = "rbtnRadioShowInStock";
            this.rbtnRadioShowInStock.Size = new System.Drawing.Size(94, 17);
            this.rbtnRadioShowInStock.TabIndex = 4;
            this.rbtnRadioShowInStock.TabStop = true;
            this.rbtnRadioShowInStock.Text = "Show in Stock";
            this.rbtnRadioShowInStock.UseVisualStyleBackColor = true;
            this.rbtnRadioShowInStock.CheckedChanged += new System.EventHandler(this.rbtnRadioShowInStock_CheckedChanged);
            // 
            // rbtnRadioShowOutOfStock
            // 
            this.rbtnRadioShowOutOfStock.AutoSize = true;
            this.rbtnRadioShowOutOfStock.Location = new System.Drawing.Point(208, 334);
            this.rbtnRadioShowOutOfStock.Name = "rbtnRadioShowOutOfStock";
            this.rbtnRadioShowOutOfStock.Size = new System.Drawing.Size(115, 17);
            this.rbtnRadioShowOutOfStock.TabIndex = 5;
            this.rbtnRadioShowOutOfStock.TabStop = true;
            this.rbtnRadioShowOutOfStock.Text = "Show Out of Stock";
            this.rbtnRadioShowOutOfStock.UseVisualStyleBackColor = true;
            this.rbtnRadioShowOutOfStock.CheckedChanged += new System.EventHandler(this.rbtnRadioShowOutOfStock_CheckedChanged);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(34, 381);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(168, 20);
            this.txtBoxSearch.TabIndex = 6;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(208, 379);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(389, 334);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(107, 104);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(524, 334);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(107, 104);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(650, 334);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(107, 104);
            this.btnMainMenu.TabIndex = 10;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // ItemId
            // 
            this.ItemId.HeaderText = "ITEM ID";
            this.ItemId.Name = "ItemId";
            // 
            // ItemDesc
            // 
            this.ItemDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemDesc.HeaderText = "ITEM DESC";
            this.ItemDesc.Name = "ItemDesc";
            // 
            // CLASS
            // 
            this.CLASS.HeaderText = "CLASS";
            this.CLASS.Name = "CLASS";
            // 
            // InvCount
            // 
            this.InvCount.HeaderText = "INV COUNT";
            this.InvCount.Name = "InvCount";
            // 
            // SUPPLIER
            // 
            this.SUPPLIER.HeaderText = "SUPPLIER";
            this.SUPPLIER.Name = "SUPPLIER";
            // 
            // SalesPrice
            // 
            this.SalesPrice.HeaderText = "SALES PRICE";
            this.SalesPrice.Name = "SalesPrice";
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
            this.Controls.Add(this.rbtnRadioShowOutOfStock);
            this.Controls.Add(this.rbtnRadioShowInStock);
            this.Controls.Add(this.rbtnRadioShowAll);
            this.Controls.Add(this.dataGridInventory);
            this.Name = "frmBrowseInventory";
            this.Text = "Browse Inventory";
            this.Load += new System.EventHandler(this.frmBrowseInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.DataGridView dataGridInventory;
        private System.Windows.Forms.RadioButton rbtnRadioShowAll;
        private System.Windows.Forms.RadioButton rbtnRadioShowInStock;
        private System.Windows.Forms.RadioButton rbtnRadioShowOutOfStock;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnMainMenu;
        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLASS;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUPPLIER;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesPrice;
    }
}