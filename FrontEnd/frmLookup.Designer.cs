﻿namespace SecretCellar
{
    partial class frmLookup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLookup));
            this.txtlookup = new System.Windows.Forms.TextBox();
            this.LookupView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.cbxTypeFilter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxSupplyFilter = new System.Windows.Forms.ComboBox();
            this.lblSupplyFilter = new System.Windows.Forms.Label();
            this.cbxOnlyItemsWithInventory = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_Supplier = new System.Windows.Forms.ComboBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.barcode_label = new System.Windows.Forms.Label();
            this.txtPrice = new SecretCellar.CurrencyBox();
            this.Price_txt = new System.Windows.Forms.Label();
            this.txt_net_price = new SecretCellar.CurrencyBox();
            this.lbl_netPrice = new System.Windows.Forms.Label();
            this.txtProd_Qty = new System.Windows.Forms.TextBox();
            this.Btl_Dep_Lb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.txt_Vintage = new System.Windows.Forms.TextBox();
            this.lblVintage = new System.Windows.Forms.Label();
            this.currencyBox_discountPrice = new SecretCellar.CurrencyBox();
            this.label_discountPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_hide_item = new System.Windows.Forms.CheckBox();
            this.lbl_order_qty = new System.Windows.Forms.Label();
            this.txt_max_qty = new System.Windows.Forms.TextBox();
            this.txt_order_qty = new System.Windows.Forms.TextBox();
            this.lbl_min = new System.Windows.Forms.Label();
            this.txt_min_qty = new System.Windows.Forms.TextBox();
            this.txt_markup = new System.Windows.Forms.TextBox();
            this.checkListBox_Discounts = new System.Windows.Forms.CheckedListBox();
            this.lbl_CaseDiscount = new System.Windows.Forms.Label();
            this.lbl_markup = new System.Windows.Forms.Label();
            this.lbl_max_qty = new System.Windows.Forms.Label();
            this.btn_clear_info = new System.Windows.Forms.Button();
            this.chk_box_show_hidden = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_DeleteItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LookupView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtlookup
            // 
            this.txtlookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlookup.Location = new System.Drawing.Point(9, 36);
            this.txtlookup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtlookup.Name = "txtlookup";
            this.txtlookup.Size = new System.Drawing.Size(271, 29);
            this.txtlookup.TabIndex = 1;
            this.txtlookup.WordWrap = false;
            this.txtlookup.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtlookup.Enter += new System.EventHandler(this.txtlookup_Enter);
            this.txtlookup.Leave += new System.EventHandler(this.txtlookup_Leave);
            // 
            // LookupView
            // 
            this.LookupView.AllowUserToAddRows = false;
            this.LookupView.AllowUserToDeleteRows = false;
            this.LookupView.AllowUserToResizeColumns = false;
            this.LookupView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Ivory;
            this.LookupView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.LookupView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LookupView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LookupView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LookupView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.LookupView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LookupView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Description,
            this.Class,
            this.Barcode,
            this.Qty,
            this.Price,
            this.minqty,
            this.orderqty,
            this.maxqty});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LookupView.DefaultCellStyle = dataGridViewCellStyle4;
            this.LookupView.Location = new System.Drawing.Point(9, 69);
            this.LookupView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LookupView.MultiSelect = false;
            this.LookupView.Name = "LookupView";
            this.LookupView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LookupView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.LookupView.RowHeadersVisible = false;
            this.LookupView.RowHeadersWidth = 62;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookupView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.LookupView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LookupView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookupView.RowTemplate.Height = 24;
            this.LookupView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LookupView.Size = new System.Drawing.Size(604, 561);
            this.LookupView.TabIndex = 0;
            this.LookupView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LookupView_CellContentClick);
            this.LookupView.SelectionChanged += new System.EventHandler(this.LookupView_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 8F;
            this.Id.HeaderText = "ItemId";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Name";
            this.Description.FillWeight = 223F;
            this.Description.HeaderText = "Name";
            this.Description.MinimumWidth = 223;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Class
            // 
            this.Class.DataPropertyName = "ItemType";
            this.Class.FillWeight = 65F;
            this.Class.HeaderText = "Class";
            this.Class.MinimumWidth = 65;
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            this.Class.Visible = false;
            // 
            // Barcode
            // 
            this.Barcode.DataPropertyName = "Barcode";
            this.Barcode.FillWeight = 130F;
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.MinimumWidth = 130;
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "Qty";
            this.Qty.FillWeight = 50F;
            this.Qty.HeaderText = "Qty";
            this.Qty.MinimumWidth = 50;
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Price.DefaultCellStyle = dataGridViewCellStyle3;
            this.Price.FillWeight = 90F;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 90;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // minqty
            // 
            this.minqty.DataPropertyName = "minqty";
            this.minqty.FillWeight = 65F;
            this.minqty.HeaderText = "Min Qty";
            this.minqty.MinimumWidth = 65;
            this.minqty.Name = "minqty";
            this.minqty.ReadOnly = true;
            this.minqty.Visible = false;
            // 
            // orderqty
            // 
            this.orderqty.DataPropertyName = "orderqty";
            this.orderqty.FillWeight = 70F;
            this.orderqty.HeaderText = "Order Qty";
            this.orderqty.MinimumWidth = 70;
            this.orderqty.Name = "orderqty";
            this.orderqty.ReadOnly = true;
            this.orderqty.Visible = false;
            // 
            // maxqty
            // 
            this.maxqty.DataPropertyName = "maxqty";
            this.maxqty.FillWeight = 65F;
            this.maxqty.HeaderText = "Max Qty";
            this.maxqty.MinimumWidth = 65;
            this.maxqty.Name = "maxqty";
            this.maxqty.ReadOnly = true;
            this.maxqty.Visible = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(22, 706);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(157, 46);
            this.btn_cancel.TabIndex = 22;
            this.btn_cancel.Text = "CLOSE WINDOW";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(197, 570);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(172, 46);
            this.btn_add.TabIndex = 22;
            this.btn_add.Text = "Add to Cart";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cbxTypeFilter
            // 
            this.cbxTypeFilter.DisplayMember = "TypeName";
            this.cbxTypeFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTypeFilter.FormattingEnabled = true;
            this.cbxTypeFilter.Location = new System.Drawing.Point(314, 35);
            this.cbxTypeFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxTypeFilter.Name = "cbxTypeFilter";
            this.cbxTypeFilter.Size = new System.Drawing.Size(200, 32);
            this.cbxTypeFilter.TabIndex = 2;
            this.cbxTypeFilter.SelectedIndexChanged += new System.EventHandler(this.cbxTypeFilter_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "Type: ";
            // 
            // cbxSupplyFilter
            // 
            this.cbxSupplyFilter.DisplayMember = "Name";
            this.cbxSupplyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSupplyFilter.FormattingEnabled = true;
            this.cbxSupplyFilter.Location = new System.Drawing.Point(550, 35);
            this.cbxSupplyFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxSupplyFilter.Name = "cbxSupplyFilter";
            this.cbxSupplyFilter.Size = new System.Drawing.Size(200, 32);
            this.cbxSupplyFilter.TabIndex = 3;
            this.cbxSupplyFilter.SelectedIndexChanged += new System.EventHandler(this.cbxSupplyFilter_SelectedIndexChanged);
            // 
            // lblSupplyFilter
            // 
            this.lblSupplyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplyFilter.Location = new System.Drawing.Point(546, 5);
            this.lblSupplyFilter.Margin = new System.Windows.Forms.Padding(0);
            this.lblSupplyFilter.Name = "lblSupplyFilter";
            this.lblSupplyFilter.Size = new System.Drawing.Size(203, 27);
            this.lblSupplyFilter.TabIndex = 12;
            this.lblSupplyFilter.Text = "Supplier:";
            // 
            // cbxOnlyItemsWithInventory
            // 
            this.cbxOnlyItemsWithInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxOnlyItemsWithInventory.AutoSize = true;
            this.cbxOnlyItemsWithInventory.Location = new System.Drawing.Point(761, 8);
            this.cbxOnlyItemsWithInventory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxOnlyItemsWithInventory.Name = "cbxOnlyItemsWithInventory";
            this.cbxOnlyItemsWithInventory.Size = new System.Drawing.Size(233, 24);
            this.cbxOnlyItemsWithInventory.TabIndex = 4;
            this.cbxOnlyItemsWithInventory.Text = "Only Items With Inventory";
            this.cbxOnlyItemsWithInventory.UseVisualStyleBackColor = true;
            this.cbxOnlyItemsWithInventory.CheckedChanged += new System.EventHandler(this.cbxOnlyItemsWithInventory_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(9, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Type:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_qty
            // 
            this.txt_qty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_qty.Location = new System.Drawing.Point(162, 183);
            this.txt_qty.Margin = new System.Windows.Forms.Padding(0);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(81, 26);
            this.txt_qty.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(9, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Qty:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(9, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(162, 34);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(206, 26);
            this.txtName.TabIndex = 7;
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(9, 570);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(131, 46);
            this.btn_update.TabIndex = 21;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // cboType
            // 
            this.cboType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboType.DisplayMember = "TypeName";
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(162, 70);
            this.cboType.Margin = new System.Windows.Forms.Padding(0);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(206, 28);
            this.cboType.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(9, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Supplier:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbo_Supplier
            // 
            this.cbo_Supplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_Supplier.DisplayMember = "Name";
            this.cbo_Supplier.FormattingEnabled = true;
            this.cbo_Supplier.Location = new System.Drawing.Point(162, 145);
            this.cbo_Supplier.Margin = new System.Windows.Forms.Padding(0);
            this.cbo_Supplier.Name = "cbo_Supplier";
            this.cbo_Supplier.Size = new System.Drawing.Size(206, 28);
            this.cbo_Supplier.TabIndex = 10;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBarcode.Location = new System.Drawing.Point(162, 108);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(0);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(206, 26);
            this.txtBarcode.TabIndex = 9;
            // 
            // barcode_label
            // 
            this.barcode_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.barcode_label.Location = new System.Drawing.Point(9, 103);
            this.barcode_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.barcode_label.Name = "barcode_label";
            this.barcode_label.Size = new System.Drawing.Size(145, 31);
            this.barcode_label.TabIndex = 10;
            this.barcode_label.Text = "Barcode:";
            this.barcode_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.Location = new System.Drawing.Point(162, 217);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(0);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(81, 26);
            this.txtPrice.TabIndex = 12;
            this.txtPrice.Text = "$0.00";
            this.txtPrice.Value = 0D;
            // 
            // Price_txt
            // 
            this.Price_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Price_txt.Location = new System.Drawing.Point(9, 213);
            this.Price_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Price_txt.Name = "Price_txt";
            this.Price_txt.Size = new System.Drawing.Size(145, 31);
            this.Price_txt.TabIndex = 12;
            this.Price_txt.Text = "Price:";
            this.Price_txt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_net_price
            // 
            this.txt_net_price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_net_price.ForeColor = System.Drawing.Color.Black;
            this.txt_net_price.Location = new System.Drawing.Point(162, 290);
            this.txt_net_price.Margin = new System.Windows.Forms.Padding(0);
            this.txt_net_price.Name = "txt_net_price";
            this.txt_net_price.Size = new System.Drawing.Size(81, 26);
            this.txt_net_price.TabIndex = 15;
            this.txt_net_price.Text = "$0.00";
            this.txt_net_price.Value = 0D;
            // 
            // lbl_netPrice
            // 
            this.lbl_netPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_netPrice.Location = new System.Drawing.Point(9, 285);
            this.lbl_netPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_netPrice.Name = "lbl_netPrice";
            this.lbl_netPrice.Size = new System.Drawing.Size(145, 31);
            this.lbl_netPrice.TabIndex = 14;
            this.lbl_netPrice.Text = "Wholesale:";
            this.lbl_netPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProd_Qty
            // 
            this.txtProd_Qty.Location = new System.Drawing.Point(162, 325);
            this.txtProd_Qty.Margin = new System.Windows.Forms.Padding(0);
            this.txtProd_Qty.Name = "txtProd_Qty";
            this.txtProd_Qty.Size = new System.Drawing.Size(58, 26);
            this.txtProd_Qty.TabIndex = 16;
            // 
            // Btl_Dep_Lb
            // 
            this.Btl_Dep_Lb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btl_Dep_Lb.Location = new System.Drawing.Point(9, 320);
            this.Btl_Dep_Lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Btl_Dep_Lb.Name = "Btl_Dep_Lb";
            this.Btl_Dep_Lb.Size = new System.Drawing.Size(145, 31);
            this.Btl_Dep_Lb.TabIndex = 17;
            this.Btl_Dep_Lb.Text = "Bottle Qty:";
            this.Btl_Dep_Lb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_Description);
            this.panel2.Controls.Add(this.lbl_Description);
            this.panel2.Controls.Add(this.txt_Vintage);
            this.panel2.Controls.Add(this.lblVintage);
            this.panel2.Controls.Add(this.currencyBox_discountPrice);
            this.panel2.Controls.Add(this.label_discountPrice);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.chk_hide_item);
            this.panel2.Controls.Add(this.lbl_order_qty);
            this.panel2.Controls.Add(this.txt_max_qty);
            this.panel2.Controls.Add(this.txt_order_qty);
            this.panel2.Controls.Add(this.lbl_min);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.txt_min_qty);
            this.panel2.Controls.Add(this.txt_markup);
            this.panel2.Controls.Add(this.checkListBox_Discounts);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.lbl_CaseDiscount);
            this.panel2.Controls.Add(this.Btl_Dep_Lb);
            this.panel2.Controls.Add(this.txtProd_Qty);
            this.panel2.Controls.Add(this.lbl_netPrice);
            this.panel2.Controls.Add(this.txt_net_price);
            this.panel2.Controls.Add(this.Price_txt);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.barcode_label);
            this.panel2.Controls.Add(this.txtBarcode);
            this.panel2.Controls.Add(this.cbo_Supplier);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cboType);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_qty);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbl_markup);
            this.panel2.Controls.Add(this.lbl_max_qty);
            this.panel2.Location = new System.Drawing.Point(620, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(383, 626);
            this.panel2.TabIndex = 8;
            // 
            // txt_Description
            // 
            this.txt_Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Description.Location = new System.Drawing.Point(162, 433);
            this.txt_Description.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(206, 56);
            this.txt_Description.TabIndex = 34;
            // 
            // lbl_Description
            // 
            this.lbl_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Description.Location = new System.Drawing.Point(9, 429);
            this.lbl_Description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(145, 31);
            this.lbl_Description.TabIndex = 33;
            this.lbl_Description.Text = "Description:";
            this.lbl_Description.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Vintage
            // 
            this.txt_Vintage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Vintage.Location = new System.Drawing.Point(311, 4);
            this.txt_Vintage.Margin = new System.Windows.Forms.Padding(0);
            this.txt_Vintage.Name = "txt_Vintage";
            this.txt_Vintage.Size = new System.Drawing.Size(57, 26);
            this.txt_Vintage.TabIndex = 32;
            // 
            // lblVintage
            // 
            this.lblVintage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVintage.Location = new System.Drawing.Point(185, 4);
            this.lblVintage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVintage.Name = "lblVintage";
            this.lblVintage.Size = new System.Drawing.Size(123, 23);
            this.lblVintage.TabIndex = 31;
            this.lblVintage.Text = "Vintage:";
            this.lblVintage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // currencyBox_discountPrice
            // 
            this.currencyBox_discountPrice.ForeColor = System.Drawing.Color.Black;
            this.currencyBox_discountPrice.Location = new System.Drawing.Point(162, 253);
            this.currencyBox_discountPrice.Name = "currencyBox_discountPrice";
            this.currencyBox_discountPrice.Size = new System.Drawing.Size(81, 26);
            this.currencyBox_discountPrice.TabIndex = 30;
            this.currencyBox_discountPrice.Text = "$0.00";
            this.currencyBox_discountPrice.Value = 0D;
            // 
            // label_discountPrice
            // 
            this.label_discountPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_discountPrice.Location = new System.Drawing.Point(9, 249);
            this.label_discountPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_discountPrice.Name = "label_discountPrice";
            this.label_discountPrice.Size = new System.Drawing.Size(146, 31);
            this.label_discountPrice.TabIndex = 29;
            this.label_discountPrice.Text = "Discount Price:";
            this.label_discountPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "Hide:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chk_hide_item
            // 
            this.chk_hide_item.AutoSize = true;
            this.chk_hide_item.Location = new System.Drawing.Point(162, 8);
            this.chk_hide_item.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_hide_item.Name = "chk_hide_item";
            this.chk_hide_item.Size = new System.Drawing.Size(15, 14);
            this.chk_hide_item.TabIndex = 6;
            this.chk_hide_item.UseVisualStyleBackColor = true;
            // 
            // lbl_order_qty
            // 
            this.lbl_order_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_order_qty.Location = new System.Drawing.Point(9, 392);
            this.lbl_order_qty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_order_qty.Name = "lbl_order_qty";
            this.lbl_order_qty.Size = new System.Drawing.Size(145, 31);
            this.lbl_order_qty.TabIndex = 26;
            this.lbl_order_qty.Text = "Order Qty:";
            this.lbl_order_qty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_max_qty
            // 
            this.txt_max_qty.Location = new System.Drawing.Point(306, 360);
            this.txt_max_qty.Margin = new System.Windows.Forms.Padding(0);
            this.txt_max_qty.Name = "txt_max_qty";
            this.txt_max_qty.Size = new System.Drawing.Size(58, 26);
            this.txt_max_qty.TabIndex = 19;
            // 
            // txt_order_qty
            // 
            this.txt_order_qty.Location = new System.Drawing.Point(162, 396);
            this.txt_order_qty.Margin = new System.Windows.Forms.Padding(0);
            this.txt_order_qty.Name = "txt_order_qty";
            this.txt_order_qty.ReadOnly = true;
            this.txt_order_qty.Size = new System.Drawing.Size(58, 26);
            this.txt_order_qty.TabIndex = 18;
            this.txt_order_qty.TabStop = false;
            // 
            // lbl_min
            // 
            this.lbl_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_min.Location = new System.Drawing.Point(9, 355);
            this.lbl_min.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(145, 31);
            this.lbl_min.TabIndex = 24;
            this.lbl_min.Text = "Min Qty:";
            this.lbl_min.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_min_qty
            // 
            this.txt_min_qty.Location = new System.Drawing.Point(162, 360);
            this.txt_min_qty.Margin = new System.Windows.Forms.Padding(0);
            this.txt_min_qty.Name = "txt_min_qty";
            this.txt_min_qty.Size = new System.Drawing.Size(58, 26);
            this.txt_min_qty.TabIndex = 17;
            // 
            // txt_markup
            // 
            this.txt_markup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_markup.Location = new System.Drawing.Point(301, 290);
            this.txt_markup.Margin = new System.Windows.Forms.Padding(0);
            this.txt_markup.Name = "txt_markup";
            this.txt_markup.ReadOnly = true;
            this.txt_markup.Size = new System.Drawing.Size(67, 26);
            this.txt_markup.TabIndex = 14;
            this.txt_markup.TabStop = false;
            // 
            // checkListBox_Discounts
            // 
            this.checkListBox_Discounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkListBox_Discounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkListBox_Discounts.FormattingEnabled = true;
            this.checkListBox_Discounts.Location = new System.Drawing.Point(162, 497);
            this.checkListBox_Discounts.Margin = new System.Windows.Forms.Padding(0);
            this.checkListBox_Discounts.MaximumSize = new System.Drawing.Size(222, 500);
            this.checkListBox_Discounts.Name = "checkListBox_Discounts";
            this.checkListBox_Discounts.Size = new System.Drawing.Size(207, 63);
            this.checkListBox_Discounts.TabIndex = 20;
            // 
            // lbl_CaseDiscount
            // 
            this.lbl_CaseDiscount.Location = new System.Drawing.Point(9, 489);
            this.lbl_CaseDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CaseDiscount.Name = "lbl_CaseDiscount";
            this.lbl_CaseDiscount.Size = new System.Drawing.Size(145, 31);
            this.lbl_CaseDiscount.TabIndex = 18;
            this.lbl_CaseDiscount.Text = "Discounts:";
            this.lbl_CaseDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_markup
            // 
            this.lbl_markup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_markup.Location = new System.Drawing.Point(284, 253);
            this.lbl_markup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_markup.Name = "lbl_markup";
            this.lbl_markup.Size = new System.Drawing.Size(85, 31);
            this.lbl_markup.TabIndex = 22;
            this.lbl_markup.Text = "Markup:";
            this.lbl_markup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_max_qty
            // 
            this.lbl_max_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_max_qty.Location = new System.Drawing.Point(219, 355);
            this.lbl_max_qty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_max_qty.Name = "lbl_max_qty";
            this.lbl_max_qty.Size = new System.Drawing.Size(83, 31);
            this.lbl_max_qty.TabIndex = 26;
            this.lbl_max_qty.Text = "Max Qty:";
            this.lbl_max_qty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_clear_info
            // 
            this.btn_clear_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_clear_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_info.Location = new System.Drawing.Point(445, 639);
            this.btn_clear_info.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_clear_info.Name = "btn_clear_info";
            this.btn_clear_info.Size = new System.Drawing.Size(157, 46);
            this.btn_clear_info.TabIndex = 19;
            this.btn_clear_info.Text = "Clear";
            this.btn_clear_info.UseVisualStyleBackColor = true;
            this.btn_clear_info.Click += new System.EventHandler(this.btn_clear_info_Click);
            // 
            // chk_box_show_hidden
            // 
            this.chk_box_show_hidden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_box_show_hidden.AutoSize = true;
            this.chk_box_show_hidden.Location = new System.Drawing.Point(761, 35);
            this.chk_box_show_hidden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_box_show_hidden.Name = "chk_box_show_hidden";
            this.chk_box_show_hidden.Size = new System.Drawing.Size(135, 24);
            this.chk_box_show_hidden.TabIndex = 5;
            this.chk_box_show_hidden.Text = "Hidden Items";
            this.chk_box_show_hidden.UseVisualStyleBackColor = true;
            this.chk_box_show_hidden.CheckedChanged += new System.EventHandler(this.chk_box_show_hidden_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 26);
            this.label7.TabIndex = 25;
            this.label7.Text = "Search:";
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(17, 639);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(157, 46);
            this.btn_close.TabIndex = 26;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_DeleteItem
            // 
            this.btn_DeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteItem.Location = new System.Drawing.Point(229, 639);
            this.btn_DeleteItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_DeleteItem.Name = "btn_DeleteItem";
            this.btn_DeleteItem.Size = new System.Drawing.Size(157, 46);
            this.btn_DeleteItem.TabIndex = 27;
            this.btn_DeleteItem.Text = "Delete";
            this.btn_DeleteItem.UseVisualStyleBackColor = true;
            this.btn_DeleteItem.Click += new System.EventHandler(this.button_DeleteItem_Click);
            // 
            // frmLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1008, 702);
            this.Controls.Add(this.cbxSupplyFilter);
            this.Controls.Add(this.cbxTypeFilter);
            this.Controls.Add(this.txtlookup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSupplyFilter);
            this.Controls.Add(this.LookupView);
            this.Controls.Add(this.btn_DeleteItem);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_clear_info);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.chk_box_show_hidden);
            this.Controls.Add(this.cbxOnlyItemsWithInventory);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLookup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Item lookup";
            this.Load += new System.EventHandler(this.frmLookup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LookupView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtlookup;
        private System.Windows.Forms.DataGridView LookupView;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cbxTypeFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxSupplyFilter;
        private System.Windows.Forms.Label lblSupplyFilter;
		private System.Windows.Forms.CheckBox cbxOnlyItemsWithInventory;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_qty;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Button btn_update;
		private System.Windows.Forms.ComboBox cboType;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbo_Supplier;
		private System.Windows.Forms.TextBox txtBarcode;
		private System.Windows.Forms.Label barcode_label;
		private SecretCellar.CurrencyBox txtPrice;
		private System.Windows.Forms.Label Price_txt;
		private SecretCellar.CurrencyBox txt_net_price;
		private System.Windows.Forms.Label lbl_netPrice;
		private System.Windows.Forms.TextBox txtProd_Qty;
		private System.Windows.Forms.Label Btl_Dep_Lb;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lbl_CaseDiscount;
        private System.Windows.Forms.Label lbl_markup;
        private System.Windows.Forms.TextBox txt_markup;
        private System.Windows.Forms.Label lbl_max_qty;
        private System.Windows.Forms.Label lbl_order_qty;
        private System.Windows.Forms.TextBox txt_max_qty;
        private System.Windows.Forms.TextBox txt_order_qty;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.TextBox txt_min_qty;
        private System.Windows.Forms.CheckBox chk_box_show_hidden;
        private System.Windows.Forms.CheckBox chk_hide_item;
        private System.Windows.Forms.Button btn_clear_info;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckedListBox checkListBox_Discounts;
        private System.Windows.Forms.Button btn_close;
		private System.Windows.Forms.Button btn_DeleteItem;
        private System.Windows.Forms.Label label_discountPrice;
        private CurrencyBox currencyBox_discountPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn minqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxqty;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.TextBox txt_Vintage;
        private System.Windows.Forms.Label lblVintage;
    }
}