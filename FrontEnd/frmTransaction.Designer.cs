﻿namespace SecretCellar
{
    partial class frmTransaction
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransaction));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LIST_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SALE_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DISCOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BOTTLE_DEPOSIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnCustom = new System.Windows.Forms.Button();
			this.btnShipping = new System.Windows.Forms.Button();
			this.btnEvents = new System.Windows.Forms.Button();
			this.btnDryClean = new System.Windows.Forms.Button();
			this.btnDiscount = new System.Windows.Forms.Button();
			this.btnVoidTrx = new System.Windows.Forms.Button();
			this.btnDeleteItem = new System.Windows.Forms.Button();
			this.panel_1 = new System.Windows.Forms.Panel();
			this.lbl_item_total = new System.Windows.Forms.Label();
			this.txt_itemTotal = new SecretCellar.CurrencyBox();
			this.txt_TransTotal = new SecretCellar.CurrencyBox();
			this.txt_transTax = new SecretCellar.CurrencyBox();
			this.txt_transDiscount = new SecretCellar.CurrencyBox();
			this.txt_transBTLDPT = new SecretCellar.CurrencyBox();
			this.txt_transSubTotal = new SecretCellar.CurrencyBox();
			this.LB_Discount = new System.Windows.Forms.Label();
			this.LB_TOTAL = new System.Windows.Forms.Label();
			this.LB_BTLDPT = new System.Windows.Forms.Label();
			this.LB_Tax = new System.Windows.Forms.Label();
			this.LB_SubTotal = new System.Windows.Forms.Label();
			this.txtBarcode = new System.Windows.Forms.TextBox();
			this.lbl_BARCODE = new System.Windows.Forms.Label();
			this.btnLookup = new System.Windows.Forms.Button();
			this.caseDiscount = new System.Windows.Forms.CheckBox();
			this.lbl_twentyone = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.btnSuspendedTransactions = new System.Windows.Forms.Button();
			this.lbl_current_cust = new System.Windows.Forms.Label();
			this.btn_order = new System.Windows.Forms.Button();
			this.ImgLstTenderButton = new System.Windows.Forms.ImageList(this.components);
			this.btn_signout = new System.Windows.Forms.Button();
			this.lbl_emp_logged_on = new System.Windows.Forms.Label();
			this.button_Invoices = new System.Windows.Forms.Button();
			this.btn_cashDrawer = new System.Windows.Forms.Button();
			this.label_currentCustomerValue = new System.Windows.Forms.Label();
			this.lbl_CreditValue = new System.Windows.Forms.Label();
			this.lbl_Credit = new System.Windows.Forms.Label();
			this.pic_transaction = new System.Windows.Forms.PictureBox();
			this.pic_susp = new System.Windows.Forms.PictureBox();
			this.pb_settings = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel_1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_transaction)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_susp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_settings)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Ivory;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(196)))));
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.ColumnHeadersHeight = 40;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DESCRIPTION,
            this.QTY,
            this.LIST_PRICE,
            this.SALE_PRICE,
            this.DISCOUNT,
            this.BOTTLE_DEPOSIT,
            this.TOTAL,
            this.ItemID});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Ivory;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.Location = new System.Drawing.Point(5, 174);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidth = 102;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.ShowEditingIcon = false;
			this.dataGridView1.Size = new System.Drawing.Size(996, 236);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
			this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
			this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
			// 
			// DESCRIPTION
			// 
			this.DESCRIPTION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DESCRIPTION.HeaderText = "Description";
			this.DESCRIPTION.MinimumWidth = 8;
			this.DESCRIPTION.Name = "DESCRIPTION";
			this.DESCRIPTION.ReadOnly = true;
			// 
			// QTY
			// 
			this.QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.QTY.HeaderText = "Qty";
			this.QTY.MinimumWidth = 8;
			this.QTY.Name = "QTY";
			this.QTY.ReadOnly = true;
			this.QTY.Width = 61;
			// 
			// LIST_PRICE
			// 
			this.LIST_PRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.LIST_PRICE.HeaderText = "List Price";
			this.LIST_PRICE.MinimumWidth = 8;
			this.LIST_PRICE.Name = "LIST_PRICE";
			this.LIST_PRICE.ReadOnly = true;
			this.LIST_PRICE.Width = 108;
			// 
			// SALE_PRICE
			// 
			this.SALE_PRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.SALE_PRICE.HeaderText = "Sale Price";
			this.SALE_PRICE.MinimumWidth = 8;
			this.SALE_PRICE.Name = "SALE_PRICE";
			this.SALE_PRICE.ReadOnly = true;
			this.SALE_PRICE.Width = 115;
			// 
			// DISCOUNT
			// 
			this.DISCOUNT.HeaderText = "Discount";
			this.DISCOUNT.MinimumWidth = 8;
			this.DISCOUNT.Name = "DISCOUNT";
			this.DISCOUNT.ReadOnly = true;
			this.DISCOUNT.Width = 150;
			// 
			// BOTTLE_DEPOSIT
			// 
			this.BOTTLE_DEPOSIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.BOTTLE_DEPOSIT.HeaderText = "Bottle Deposit";
			this.BOTTLE_DEPOSIT.MinimumWidth = 8;
			this.BOTTLE_DEPOSIT.Name = "BOTTLE_DEPOSIT";
			this.BOTTLE_DEPOSIT.ReadOnly = true;
			this.BOTTLE_DEPOSIT.Width = 149;
			// 
			// TOTAL
			// 
			this.TOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.TOTAL.HeaderText = "Total";
			this.TOTAL.MinimumWidth = 8;
			this.TOTAL.Name = "TOTAL";
			this.TOTAL.ReadOnly = true;
			this.TOTAL.Width = 74;
			// 
			// ItemID
			// 
			this.ItemID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ItemID.HeaderText = "ItemID";
			this.ItemID.MinimumWidth = 8;
			this.ItemID.Name = "ItemID";
			this.ItemID.ReadOnly = true;
			this.ItemID.Visible = false;
			this.ItemID.Width = 89;
			// 
			// btnCustom
			// 
			this.btnCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
			this.btnCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCustom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCustom.Location = new System.Drawing.Point(156, 116);
			this.btnCustom.Margin = new System.Windows.Forms.Padding(1);
			this.btnCustom.Name = "btnCustom";
			this.btnCustom.Size = new System.Drawing.Size(130, 48);
			this.btnCustom.TabIndex = 7;
			this.btnCustom.Text = "Custom";
			this.btnCustom.UseVisualStyleBackColor = false;
			this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
			// 
			// btnShipping
			// 
			this.btnShipping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnShipping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
			this.btnShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShipping.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnShipping.Location = new System.Drawing.Point(159, 603);
			this.btnShipping.Margin = new System.Windows.Forms.Padding(1);
			this.btnShipping.Name = "btnShipping";
			this.btnShipping.Size = new System.Drawing.Size(141, 68);
			this.btnShipping.TabIndex = 8;
			this.btnShipping.Text = "Shipping";
			this.btnShipping.UseVisualStyleBackColor = false;
			this.btnShipping.Click += new System.EventHandler(this.btnShipping_Click);
			// 
			// btnEvents
			// 
			this.btnEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
			this.btnEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEvents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnEvents.Location = new System.Drawing.Point(159, 511);
			this.btnEvents.Margin = new System.Windows.Forms.Padding(1);
			this.btnEvents.Name = "btnEvents";
			this.btnEvents.Size = new System.Drawing.Size(141, 68);
			this.btnEvents.TabIndex = 7;
			this.btnEvents.TabStop = false;
			this.btnEvents.Text = "Events";
			this.btnEvents.UseVisualStyleBackColor = false;
			this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
			// 
			// btnDryClean
			// 
			this.btnDryClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnDryClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
			this.btnDryClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDryClean.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDryClean.Location = new System.Drawing.Point(159, 419);
			this.btnDryClean.Margin = new System.Windows.Forms.Padding(1);
			this.btnDryClean.Name = "btnDryClean";
			this.btnDryClean.Size = new System.Drawing.Size(141, 68);
			this.btnDryClean.TabIndex = 4;
			this.btnDryClean.Text = "Dry Cleaning";
			this.btnDryClean.UseVisualStyleBackColor = false;
			this.btnDryClean.Click += new System.EventHandler(this.btnDryClean_Click);
			// 
			// btnDiscount
			// 
			this.btnDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
			this.btnDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDiscount.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnDiscount.Location = new System.Drawing.Point(307, 603);
			this.btnDiscount.Margin = new System.Windows.Forms.Padding(1);
			this.btnDiscount.Name = "btnDiscount";
			this.btnDiscount.Size = new System.Drawing.Size(141, 68);
			this.btnDiscount.TabIndex = 9;
			this.btnDiscount.Text = "Discount";
			this.btnDiscount.UseVisualStyleBackColor = false;
			this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
			// 
			// btnVoidTrx
			// 
			this.btnVoidTrx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnVoidTrx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
			this.btnVoidTrx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVoidTrx.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnVoidTrx.Location = new System.Drawing.Point(307, 511);
			this.btnVoidTrx.Margin = new System.Windows.Forms.Padding(1);
			this.btnVoidTrx.Name = "btnVoidTrx";
			this.btnVoidTrx.Size = new System.Drawing.Size(141, 68);
			this.btnVoidTrx.TabIndex = 10;
			this.btnVoidTrx.TabStop = false;
			this.btnVoidTrx.Text = "Void TRX";
			this.btnVoidTrx.UseVisualStyleBackColor = false;
			this.btnVoidTrx.Click += new System.EventHandler(this.btnVoidTrx_Click);
			// 
			// btnDeleteItem
			// 
			this.btnDeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnDeleteItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
			this.btnDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDeleteItem.Location = new System.Drawing.Point(307, 419);
			this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(1);
			this.btnDeleteItem.Name = "btnDeleteItem";
			this.btnDeleteItem.Size = new System.Drawing.Size(141, 68);
			this.btnDeleteItem.TabIndex = 5;
			this.btnDeleteItem.Text = "Delete Item";
			this.btnDeleteItem.UseVisualStyleBackColor = false;
			this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
			// 
			// panel_1
			// 
			this.panel_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.panel_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_1.Controls.Add(this.lbl_item_total);
			this.panel_1.Controls.Add(this.txt_itemTotal);
			this.panel_1.Controls.Add(this.txt_TransTotal);
			this.panel_1.Controls.Add(this.txt_transTax);
			this.panel_1.Controls.Add(this.txt_transDiscount);
			this.panel_1.Controls.Add(this.txt_transBTLDPT);
			this.panel_1.Controls.Add(this.txt_transSubTotal);
			this.panel_1.Controls.Add(this.LB_Discount);
			this.panel_1.Controls.Add(this.LB_TOTAL);
			this.panel_1.Controls.Add(this.LB_BTLDPT);
			this.panel_1.Controls.Add(this.LB_Tax);
			this.panel_1.Controls.Add(this.LB_SubTotal);
			this.panel_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel_1.Location = new System.Drawing.Point(775, 473);
			this.panel_1.Margin = new System.Windows.Forms.Padding(1);
			this.panel_1.Name = "panel_1";
			this.panel_1.Size = new System.Drawing.Size(226, 210);
			this.panel_1.TabIndex = 13;
			// 
			// lbl_item_total
			// 
			this.lbl_item_total.AutoSize = true;
			this.lbl_item_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_item_total.Location = new System.Drawing.Point(18, 17);
			this.lbl_item_total.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.lbl_item_total.Name = "lbl_item_total";
			this.lbl_item_total.Size = new System.Drawing.Size(76, 16);
			this.lbl_item_total.TabIndex = 13;
			this.lbl_item_total.Text = "Item Total";
			// 
			// txt_itemTotal
			// 
			this.txt_itemTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_itemTotal.ForeColor = System.Drawing.Color.Black;
			this.txt_itemTotal.Location = new System.Drawing.Point(114, 11);
			this.txt_itemTotal.Margin = new System.Windows.Forms.Padding(1);
			this.txt_itemTotal.Name = "txt_itemTotal";
			this.txt_itemTotal.ReadOnly = true;
			this.txt_itemTotal.Size = new System.Drawing.Size(108, 26);
			this.txt_itemTotal.TabIndex = 12;
			this.txt_itemTotal.TabStop = false;
			this.txt_itemTotal.Text = "$0.00";
			this.txt_itemTotal.Value = 0D;
			// 
			// txt_TransTotal
			// 
			this.txt_TransTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_TransTotal.ForeColor = System.Drawing.Color.Black;
			this.txt_TransTotal.Location = new System.Drawing.Point(114, 168);
			this.txt_TransTotal.Margin = new System.Windows.Forms.Padding(1);
			this.txt_TransTotal.Name = "txt_TransTotal";
			this.txt_TransTotal.ReadOnly = true;
			this.txt_TransTotal.Size = new System.Drawing.Size(108, 29);
			this.txt_TransTotal.TabIndex = 9;
			this.txt_TransTotal.TabStop = false;
			this.txt_TransTotal.Text = "$0.00";
			this.txt_TransTotal.Value = 0D;
			// 
			// txt_transTax
			// 
			this.txt_transTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_transTax.ForeColor = System.Drawing.Color.Black;
			this.txt_transTax.Location = new System.Drawing.Point(114, 105);
			this.txt_transTax.Margin = new System.Windows.Forms.Padding(1);
			this.txt_transTax.Name = "txt_transTax";
			this.txt_transTax.ReadOnly = true;
			this.txt_transTax.Size = new System.Drawing.Size(108, 26);
			this.txt_transTax.TabIndex = 8;
			this.txt_transTax.TabStop = false;
			this.txt_transTax.Text = "$0.00";
			this.txt_transTax.Value = 0D;
			// 
			// txt_transDiscount
			// 
			this.txt_transDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_transDiscount.ForeColor = System.Drawing.Color.Black;
			this.txt_transDiscount.Location = new System.Drawing.Point(114, 42);
			this.txt_transDiscount.Margin = new System.Windows.Forms.Padding(1);
			this.txt_transDiscount.Name = "txt_transDiscount";
			this.txt_transDiscount.ReadOnly = true;
			this.txt_transDiscount.Size = new System.Drawing.Size(108, 26);
			this.txt_transDiscount.TabIndex = 7;
			this.txt_transDiscount.TabStop = false;
			this.txt_transDiscount.Text = "$0.00";
			this.txt_transDiscount.Value = 0D;
			// 
			// txt_transBTLDPT
			// 
			this.txt_transBTLDPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_transBTLDPT.ForeColor = System.Drawing.Color.Black;
			this.txt_transBTLDPT.Location = new System.Drawing.Point(114, 136);
			this.txt_transBTLDPT.Margin = new System.Windows.Forms.Padding(1);
			this.txt_transBTLDPT.Name = "txt_transBTLDPT";
			this.txt_transBTLDPT.ReadOnly = true;
			this.txt_transBTLDPT.Size = new System.Drawing.Size(108, 26);
			this.txt_transBTLDPT.TabIndex = 6;
			this.txt_transBTLDPT.TabStop = false;
			this.txt_transBTLDPT.Text = "$0.00";
			this.txt_transBTLDPT.Value = 0D;
			// 
			// txt_transSubTotal
			// 
			this.txt_transSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_transSubTotal.ForeColor = System.Drawing.Color.Black;
			this.txt_transSubTotal.Location = new System.Drawing.Point(114, 73);
			this.txt_transSubTotal.Margin = new System.Windows.Forms.Padding(1);
			this.txt_transSubTotal.Name = "txt_transSubTotal";
			this.txt_transSubTotal.ReadOnly = true;
			this.txt_transSubTotal.Size = new System.Drawing.Size(108, 26);
			this.txt_transSubTotal.TabIndex = 5;
			this.txt_transSubTotal.TabStop = false;
			this.txt_transSubTotal.Text = "$0.00";
			this.txt_transSubTotal.Value = 0D;
			// 
			// LB_Discount
			// 
			this.LB_Discount.AutoSize = true;
			this.LB_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LB_Discount.Location = new System.Drawing.Point(12, 48);
			this.LB_Discount.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.LB_Discount.Name = "LB_Discount";
			this.LB_Discount.Size = new System.Drawing.Size(82, 16);
			this.LB_Discount.TabIndex = 4;
			this.LB_Discount.Text = "Disc. Total";
			// 
			// LB_TOTAL
			// 
			this.LB_TOTAL.AutoSize = true;
			this.LB_TOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LB_TOTAL.Location = new System.Drawing.Point(38, 171);
			this.LB_TOTAL.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.LB_TOTAL.Name = "LB_TOTAL";
			this.LB_TOTAL.Size = new System.Drawing.Size(56, 24);
			this.LB_TOTAL.TabIndex = 3;
			this.LB_TOTAL.Text = "Total";
			// 
			// LB_BTLDPT
			// 
			this.LB_BTLDPT.AutoSize = true;
			this.LB_BTLDPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LB_BTLDPT.Location = new System.Drawing.Point(41, 142);
			this.LB_BTLDPT.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.LB_BTLDPT.Name = "LB_BTLDPT";
			this.LB_BTLDPT.Size = new System.Drawing.Size(53, 16);
			this.LB_BTLDPT.TabIndex = 2;
			this.LB_BTLDPT.Text = "Btl Dpt";
			// 
			// LB_Tax
			// 
			this.LB_Tax.AutoSize = true;
			this.LB_Tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LB_Tax.Location = new System.Drawing.Point(61, 111);
			this.LB_Tax.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.LB_Tax.Name = "LB_Tax";
			this.LB_Tax.Size = new System.Drawing.Size(33, 16);
			this.LB_Tax.TabIndex = 1;
			this.LB_Tax.Text = "Tax";
			// 
			// LB_SubTotal
			// 
			this.LB_SubTotal.AutoSize = true;
			this.LB_SubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LB_SubTotal.Location = new System.Drawing.Point(20, 79);
			this.LB_SubTotal.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.LB_SubTotal.Name = "LB_SubTotal";
			this.LB_SubTotal.Size = new System.Drawing.Size(74, 16);
			this.LB_SubTotal.TabIndex = 0;
			this.LB_SubTotal.Text = "Sub Total";
			// 
			// txtBarcode
			// 
			this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBarcode.Location = new System.Drawing.Point(105, 84);
			this.txtBarcode.Margin = new System.Windows.Forms.Padding(1);
			this.txtBarcode.Name = "txtBarcode";
			this.txtBarcode.Size = new System.Drawing.Size(260, 26);
			this.txtBarcode.TabIndex = 0;
			this.txtBarcode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyUp);
			// 
			// lbl_BARCODE
			// 
			this.lbl_BARCODE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_BARCODE.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.lbl_BARCODE.Location = new System.Drawing.Point(6, 77);
			this.lbl_BARCODE.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.lbl_BARCODE.Name = "lbl_BARCODE";
			this.lbl_BARCODE.Size = new System.Drawing.Size(84, 40);
			this.lbl_BARCODE.TabIndex = 17;
			this.lbl_BARCODE.Text = "Barcode:";
			this.lbl_BARCODE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnLookup
			// 
			this.btnLookup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
			this.btnLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLookup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnLookup.Location = new System.Drawing.Point(8, 118);
			this.btnLookup.Margin = new System.Windows.Forms.Padding(1);
			this.btnLookup.MaximumSize = new System.Drawing.Size(173, 45);
			this.btnLookup.Name = "btnLookup";
			this.btnLookup.Size = new System.Drawing.Size(130, 45);
			this.btnLookup.TabIndex = 1;
			this.btnLookup.Text = "Lookup";
			this.btnLookup.UseVisualStyleBackColor = false;
			this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
			// 
			// caseDiscount
			// 
			this.caseDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.caseDiscount.AutoSize = true;
			this.caseDiscount.Checked = true;
			this.caseDiscount.CheckState = System.Windows.Forms.CheckState.Checked;
			this.caseDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.caseDiscount.Location = new System.Drawing.Point(801, 416);
			this.caseDiscount.Margin = new System.Windows.Forms.Padding(1);
			this.caseDiscount.Name = "caseDiscount";
			this.caseDiscount.Size = new System.Drawing.Size(194, 24);
			this.caseDiscount.TabIndex = 12;
			this.caseDiscount.Text = "Apply Case Discount";
			this.caseDiscount.UseVisualStyleBackColor = true;
			this.caseDiscount.CheckedChanged += new System.EventHandler(this.caseDiscount_CheckedChanged);
			// 
			// lbl_twentyone
			// 
			this.lbl_twentyone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_twentyone.BackColor = System.Drawing.Color.Transparent;
			this.lbl_twentyone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_twentyone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
			this.lbl_twentyone.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lbl_twentyone.Location = new System.Drawing.Point(483, 5);
			this.lbl_twentyone.MinimumSize = new System.Drawing.Size(333, 36);
			this.lbl_twentyone.Name = "lbl_twentyone";
			this.lbl_twentyone.Size = new System.Drawing.Size(333, 40);
			this.lbl_twentyone.TabIndex = 23;
			this.lbl_twentyone.Text = "21 Date";
			this.lbl_twentyone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(11, 419);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(141, 68);
			this.button1.TabIndex = 3;
			this.button1.Text = "Customers";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnSuspendedTransactions
			// 
			this.btnSuspendedTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSuspendedTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
			this.btnSuspendedTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSuspendedTransactions.ForeColor = System.Drawing.Color.White;
			this.btnSuspendedTransactions.Location = new System.Drawing.Point(860, 110);
			this.btnSuspendedTransactions.Margin = new System.Windows.Forms.Padding(1);
			this.btnSuspendedTransactions.Name = "btnSuspendedTransactions";
			this.btnSuspendedTransactions.Size = new System.Drawing.Size(141, 51);
			this.btnSuspendedTransactions.TabIndex = 10;
			this.btnSuspendedTransactions.Text = "Suspended Transactions";
			this.btnSuspendedTransactions.UseVisualStyleBackColor = false;
			this.btnSuspendedTransactions.Click += new System.EventHandler(this.btnSuspendedTransactions_Click);
			// 
			// lbl_current_cust
			// 
			this.lbl_current_cust.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_current_cust.AutoSize = true;
			this.lbl_current_cust.Location = new System.Drawing.Point(108, 22);
			this.lbl_current_cust.Name = "lbl_current_cust";
			this.lbl_current_cust.Size = new System.Drawing.Size(91, 20);
			this.lbl_current_cust.TabIndex = 26;
			this.lbl_current_cust.Text = "Customer:";
			// 
			// btn_order
			// 
			this.btn_order.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
			this.btn_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_order.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btn_order.Location = new System.Drawing.Point(11, 511);
			this.btn_order.Margin = new System.Windows.Forms.Padding(1);
			this.btn_order.Name = "btn_order";
			this.btn_order.Size = new System.Drawing.Size(141, 68);
			this.btn_order.TabIndex = 27;
			this.btn_order.Text = "Order";
			this.btn_order.UseVisualStyleBackColor = false;
			this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
			// 
			// ImgLstTenderButton
			// 
			this.ImgLstTenderButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgLstTenderButton.ImageStream")));
			this.ImgLstTenderButton.TransparentColor = System.Drawing.Color.Transparent;
			this.ImgLstTenderButton.Images.SetKeyName(0, "Tender Button.png");
			this.ImgLstTenderButton.Images.SetKeyName(1, "Tender Button hover.png");
			this.ImgLstTenderButton.Images.SetKeyName(2, "Suspend Button.png");
			this.ImgLstTenderButton.Images.SetKeyName(3, "Suspend Button Hover.png");
			// 
			// btn_signout
			// 
			this.btn_signout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_signout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_signout.Location = new System.Drawing.Point(880, 12);
			this.btn_signout.Margin = new System.Windows.Forms.Padding(1);
			this.btn_signout.Name = "btn_signout";
			this.btn_signout.Size = new System.Drawing.Size(114, 40);
			this.btn_signout.TabIndex = 31;
			this.btn_signout.Text = "Sign out";
			this.btn_signout.UseVisualStyleBackColor = true;
			this.btn_signout.Click += new System.EventHandler(this.btn_signout_Click);
			// 
			// lbl_emp_logged_on
			// 
			this.lbl_emp_logged_on.AutoSize = true;
			this.lbl_emp_logged_on.Location = new System.Drawing.Point(920, 61);
			this.lbl_emp_logged_on.Name = "lbl_emp_logged_on";
			this.lbl_emp_logged_on.Size = new System.Drawing.Size(71, 20);
			this.lbl_emp_logged_on.TabIndex = 32;
			this.lbl_emp_logged_on.Text = "lbl_emp";
			this.lbl_emp_logged_on.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// button_Invoices
			// 
			this.button_Invoices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button_Invoices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
			this.button_Invoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Invoices.ForeColor = System.Drawing.Color.White;
			this.button_Invoices.Location = new System.Drawing.Point(723, 110);
			this.button_Invoices.Margin = new System.Windows.Forms.Padding(1);
			this.button_Invoices.Name = "button_Invoices";
			this.button_Invoices.Size = new System.Drawing.Size(127, 51);
			this.button_Invoices.TabIndex = 33;
			this.button_Invoices.Text = "Invoices";
			this.button_Invoices.UseVisualStyleBackColor = false;
			this.button_Invoices.Click += new System.EventHandler(this.button_Invoices_Click);
			// 
			// btn_cashDrawer
			// 
			this.btn_cashDrawer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_cashDrawer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
			this.btn_cashDrawer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cashDrawer.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btn_cashDrawer.Location = new System.Drawing.Point(11, 603);
			this.btn_cashDrawer.Margin = new System.Windows.Forms.Padding(1);
			this.btn_cashDrawer.Name = "btn_cashDrawer";
			this.btn_cashDrawer.Size = new System.Drawing.Size(141, 68);
			this.btn_cashDrawer.TabIndex = 34;
			this.btn_cashDrawer.Text = "Cash Drawer";
			this.btn_cashDrawer.UseVisualStyleBackColor = false;
			this.btn_cashDrawer.Click += new System.EventHandler(this.btn_cashDrawer_Click);
			// 
			// label_currentCustomerValue
			// 
			this.label_currentCustomerValue.AutoSize = true;
			this.label_currentCustomerValue.Location = new System.Drawing.Point(201, 22);
			this.label_currentCustomerValue.Name = "label_currentCustomerValue";
			this.label_currentCustomerValue.Size = new System.Drawing.Size(0, 20);
			this.label_currentCustomerValue.TabIndex = 35;
			// 
			// lbl_CreditValue
			// 
			this.lbl_CreditValue.AutoSize = true;
			this.lbl_CreditValue.Location = new System.Drawing.Point(201, 51);
			this.lbl_CreditValue.Name = "lbl_CreditValue";
			this.lbl_CreditValue.Size = new System.Drawing.Size(54, 20);
			this.lbl_CreditValue.TabIndex = 37;
			this.lbl_CreditValue.Text = "$0.00";
			this.lbl_CreditValue.Visible = false;
			// 
			// lbl_Credit
			// 
			this.lbl_Credit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_Credit.AutoSize = true;
			this.lbl_Credit.Location = new System.Drawing.Point(135, 51);
			this.lbl_Credit.Name = "lbl_Credit";
			this.lbl_Credit.Size = new System.Drawing.Size(62, 20);
			this.lbl_Credit.TabIndex = 36;
			this.lbl_Credit.Text = "Credit:";
			this.lbl_Credit.Visible = false;
			// 
			// pic_transaction
			// 
			this.pic_transaction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_transaction.Image = global::SecretCellar.Properties.Resources.Tender_Button;
			this.pic_transaction.Location = new System.Drawing.Point(609, 589);
			this.pic_transaction.Margin = new System.Windows.Forms.Padding(2);
			this.pic_transaction.Name = "pic_transaction";
			this.pic_transaction.Size = new System.Drawing.Size(157, 110);
			this.pic_transaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_transaction.TabIndex = 40;
			this.pic_transaction.TabStop = false;
			this.pic_transaction.Click += new System.EventHandler(this.pic_transaction_Click);
			this.pic_transaction.MouseLeave += new System.EventHandler(this.pic_transaction_MouseLeave);
			this.pic_transaction.MouseHover += new System.EventHandler(this.pic_transaction_MouseHover);
			// 
			// pic_susp
			// 
			this.pic_susp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_susp.Image = global::SecretCellar.Properties.Resources.Suspend_Button;
			this.pic_susp.Location = new System.Drawing.Point(461, 606);
			this.pic_susp.Margin = new System.Windows.Forms.Padding(2);
			this.pic_susp.Name = "pic_susp";
			this.pic_susp.Size = new System.Drawing.Size(129, 75);
			this.pic_susp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_susp.TabIndex = 39;
			this.pic_susp.TabStop = false;
			this.pic_susp.Click += new System.EventHandler(this.pic_susp_Click);
			this.pic_susp.MouseLeave += new System.EventHandler(this.pic_susp_MouseLeave);
			this.pic_susp.MouseHover += new System.EventHandler(this.pic_susp_MouseHover);
			// 
			// pb_settings
			// 
			this.pb_settings.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pb_settings.Image = global::SecretCellar.Properties.Resources.Gears;
			this.pb_settings.Location = new System.Drawing.Point(20, 9);
			this.pb_settings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pb_settings.Name = "pb_settings";
			this.pb_settings.Size = new System.Drawing.Size(70, 51);
			this.pb_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb_settings.TabIndex = 20;
			this.pb_settings.TabStop = false;
			this.pb_settings.Click += new System.EventHandler(this.pb_settings_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(470, 416);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(274, 163);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 18;
			this.pictureBox1.TabStop = false;
			// 
			// frmTransaction
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(206)))));
			this.ClientSize = new System.Drawing.Size(1008, 707);
			this.Controls.Add(this.pic_transaction);
			this.Controls.Add(this.pic_susp);
			this.Controls.Add(this.lbl_CreditValue);
			this.Controls.Add(this.lbl_Credit);
			this.Controls.Add(this.label_currentCustomerValue);
			this.Controls.Add(this.btn_cashDrawer);
			this.Controls.Add(this.button_Invoices);
			this.Controls.Add(this.lbl_emp_logged_on);
			this.Controls.Add(this.btn_signout);
			this.Controls.Add(this.btn_order);
			this.Controls.Add(this.lbl_current_cust);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnSuspendedTransactions);
			this.Controls.Add(this.lbl_twentyone);
			this.Controls.Add(this.caseDiscount);
			this.Controls.Add(this.pb_settings);
			this.Controls.Add(this.btnLookup);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lbl_BARCODE);
			this.Controls.Add(this.txtBarcode);
			this.Controls.Add(this.panel_1);
			this.Controls.Add(this.btnDiscount);
			this.Controls.Add(this.btnVoidTrx);
			this.Controls.Add(this.btnDeleteItem);
			this.Controls.Add(this.btnShipping);
			this.Controls.Add(this.btnEvents);
			this.Controls.Add(this.btnDryClean);
			this.Controls.Add(this.btnCustom);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(1);
			this.Name = "frmTransaction";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Secret Cellar POS";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTransaction_FormClosed);
			this.Load += new System.EventHandler(this.frmTransaction_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel_1.ResumeLayout(false);
			this.panel_1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_transaction)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic_susp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_settings)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnShipping;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnDryClean;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnVoidTrx;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Panel panel_1;
        private System.Windows.Forms.Label LB_TOTAL;
        private System.Windows.Forms.Label LB_BTLDPT;
        private System.Windows.Forms.Label LB_Tax;
        private System.Windows.Forms.Label LB_SubTotal;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label LB_Discount;
        private SecretCellar.CurrencyBox txt_transSubTotal;
        private SecretCellar.CurrencyBox txt_transBTLDPT;
        private System.Windows.Forms.Label lbl_BARCODE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SecretCellar.CurrencyBox txt_transTax;
        private SecretCellar.CurrencyBox txt_transDiscount;
        private SecretCellar.CurrencyBox txt_TransTotal;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.Label lbl_item_total;
        private SecretCellar.CurrencyBox txt_itemTotal;
        private System.Windows.Forms.PictureBox pb_settings;
        private System.Windows.Forms.CheckBox caseDiscount;
		private System.Windows.Forms.Button btnSuspendedTransactions;
        private System.Windows.Forms.Label lbl_twentyone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_current_cust;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.ImageList ImgLstTenderButton;
        private System.Windows.Forms.Button btn_signout;
        private System.Windows.Forms.Label lbl_emp_logged_on;
        private System.Windows.Forms.Button button_Invoices;
        private System.Windows.Forms.Button btn_cashDrawer;
        private System.Windows.Forms.Label label_currentCustomerValue;
        private System.Windows.Forms.Label lbl_CreditValue;
        private System.Windows.Forms.Label lbl_Credit;
        private System.Windows.Forms.PictureBox pic_susp;
        private System.Windows.Forms.PictureBox pic_transaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIST_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALE_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISCOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOTTLE_DEPOSIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
    }
}