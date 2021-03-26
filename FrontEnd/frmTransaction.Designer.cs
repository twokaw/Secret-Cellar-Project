namespace SecretCellar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransaction));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISCOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOTTLE_DEPOSIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPropane = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnShipping = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnDryClean = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnVoidTrx = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_item_total = new System.Windows.Forms.Label();
            this.txt_itemTotal = new System.Windows.Forms.TextBox();
            this.lblShip = new System.Windows.Forms.Label();
            this.txt_Ship = new System.Windows.Forms.TextBox();
            this.txt_TransTotal = new System.Windows.Forms.TextBox();
            this.txt_transTax = new System.Windows.Forms.TextBox();
            this.txt_transDiscount = new System.Windows.Forms.TextBox();
            this.txt_transBTLDPT = new System.Windows.Forms.TextBox();
            this.txt_transSubTotal = new System.Windows.Forms.TextBox();
            this.LB_Discount = new System.Windows.Forms.Label();
            this.LB_TOTAL = new System.Windows.Forms.Label();
            this.LB_BTLDPT = new System.Windows.Forms.Label();
            this.LB_Tax = new System.Windows.Forms.Label();
            this.LB_SubTotal = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lbl_BARCODE = new System.Windows.Forms.Label();
            this.btnLookup = new System.Windows.Forms.Button();
            this.caseDiscount = new System.Windows.Forms.CheckBox();
            this.pb_settings = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTender = new ePOSOne.btnProduct.Button_WOC();
            this.lbl_twentyone = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSuspendedTransactions = new System.Windows.Forms.Button();
            this.btnSuspendTransaction = new System.Windows.Forms.Button();
            this.txt_current_cust = new System.Windows.Forms.TextBox();
            this.lbl_current_cust = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DESCRIPTION,
            this.QTY,
            this.PRICE,
            this.DISCOUNT,
            this.TAX,
            this.BOTTLE_DEPOSIT,
            this.TOTAL});
            this.dataGridView1.Location = new System.Drawing.Point(22, 106);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(2513, 683);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESCRIPTION.FillWeight = 205.876F;
            this.DESCRIPTION.HeaderText = "DESCRIPTION";
            this.DESCRIPTION.MinimumWidth = 12;
            this.DESCRIPTION.Name = "DESCRIPTION";
            // 
            // QTY
            // 
            this.QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.QTY.FillWeight = 154.4118F;
            this.QTY.HeaderText = "QTY";
            this.QTY.MinimumWidth = 12;
            this.QTY.Name = "QTY";
            this.QTY.Width = 150;
            // 
            // PRICE
            // 
            this.PRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PRICE.FillWeight = 18.80306F;
            this.PRICE.HeaderText = "PRICE";
            this.PRICE.MinimumWidth = 12;
            this.PRICE.Name = "PRICE";
            this.PRICE.Width = 120;
            // 
            // DISCOUNT
            // 
            this.DISCOUNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DISCOUNT.FillWeight = 37.25315F;
            this.DISCOUNT.HeaderText = "DISCOUNT";
            this.DISCOUNT.MinimumWidth = 25;
            this.DISCOUNT.Name = "DISCOUNT";
            this.DISCOUNT.Width = 120;
            // 
            // TAX
            // 
            this.TAX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TAX.FillWeight = 57.0944F;
            this.TAX.HeaderText = "TAX";
            this.TAX.MinimumWidth = 12;
            this.TAX.Name = "TAX";
            this.TAX.Width = 150;
            // 
            // BOTTLE_DEPOSIT
            // 
            this.BOTTLE_DEPOSIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BOTTLE_DEPOSIT.FillWeight = 88.47124F;
            this.BOTTLE_DEPOSIT.HeaderText = "BOTTLE DEPOSIT";
            this.BOTTLE_DEPOSIT.MinimumWidth = 12;
            this.BOTTLE_DEPOSIT.Name = "BOTTLE_DEPOSIT";
            this.BOTTLE_DEPOSIT.Width = 180;
            // 
            // TOTAL
            // 
            this.TOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TOTAL.FillWeight = 138.0905F;
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.MinimumWidth = 12;
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Width = 180;
            // 
            // btnPropane
            // 
            this.btnPropane.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPropane.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPropane.Location = new System.Drawing.Point(26, 948);
            this.btnPropane.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnPropane.Name = "btnPropane";
            this.btnPropane.Size = new System.Drawing.Size(260, 86);
            this.btnPropane.TabIndex = 3;
            this.btnPropane.TabStop = false;
            this.btnPropane.Text = "PROPANE";
            this.btnPropane.UseVisualStyleBackColor = true;
            this.btnPropane.Click += new System.EventHandler(this.btnPropane_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustom.Location = new System.Drawing.Point(26, 1077);
            this.btnCustom.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(260, 86);
            this.btnCustom.TabIndex = 5;
            this.btnCustom.TabStop = false;
            this.btnCustom.Text = "CUSTOM";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btnShipping
            // 
            this.btnShipping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShipping.Location = new System.Drawing.Point(326, 1077);
            this.btnShipping.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnShipping.Name = "btnShipping";
            this.btnShipping.Size = new System.Drawing.Size(260, 86);
            this.btnShipping.TabIndex = 8;
            this.btnShipping.TabStop = false;
            this.btnShipping.Text = "SHIPPING";
            this.btnShipping.UseVisualStyleBackColor = true;
            this.btnShipping.Click += new System.EventHandler(this.btnShipping_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvents.Location = new System.Drawing.Point(326, 948);
            this.btnEvents.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(260, 86);
            this.btnEvents.TabIndex = 7;
            this.btnEvents.TabStop = false;
            this.btnEvents.Text = "EVENTS";
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnDryClean
            // 
            this.btnDryClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDryClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDryClean.Location = new System.Drawing.Point(326, 819);
            this.btnDryClean.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnDryClean.Name = "btnDryClean";
            this.btnDryClean.Size = new System.Drawing.Size(260, 86);
            this.btnDryClean.TabIndex = 6;
            this.btnDryClean.TabStop = false;
            this.btnDryClean.Text = "DRY CLEANING";
            this.btnDryClean.UseVisualStyleBackColor = true;
            this.btnDryClean.Click += new System.EventHandler(this.btnDryClean_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.Location = new System.Drawing.Point(625, 1077);
            this.btnDiscount.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(260, 86);
            this.btnDiscount.TabIndex = 11;
            this.btnDiscount.TabStop = false;
            this.btnDiscount.Text = "DISCOUNT";
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnVoidTrx
            // 
            this.btnVoidTrx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoidTrx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoidTrx.Location = new System.Drawing.Point(625, 948);
            this.btnVoidTrx.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnVoidTrx.Name = "btnVoidTrx";
            this.btnVoidTrx.Size = new System.Drawing.Size(260, 86);
            this.btnVoidTrx.TabIndex = 10;
            this.btnVoidTrx.TabStop = false;
            this.btnVoidTrx.Text = "VOID TRX";
            this.btnVoidTrx.UseVisualStyleBackColor = true;
            this.btnVoidTrx.Click += new System.EventHandler(this.btnVoidTrx_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.Location = new System.Drawing.Point(625, 819);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(260, 86);
            this.btnDeleteItem.TabIndex = 9;
            this.btnDeleteItem.TabStop = false;
            this.btnDeleteItem.Text = "DELETE ITEM";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_item_total);
            this.panel1.Controls.Add(this.txt_itemTotal);
            this.panel1.Controls.Add(this.lblShip);
            this.panel1.Controls.Add(this.txt_Ship);
            this.panel1.Controls.Add(this.txt_TransTotal);
            this.panel1.Controls.Add(this.txt_transTax);
            this.panel1.Controls.Add(this.txt_transDiscount);
            this.panel1.Controls.Add(this.txt_transBTLDPT);
            this.panel1.Controls.Add(this.txt_transSubTotal);
            this.panel1.Controls.Add(this.LB_Discount);
            this.panel1.Controls.Add(this.LB_TOTAL);
            this.panel1.Controls.Add(this.LB_BTLDPT);
            this.panel1.Controls.Add(this.LB_Tax);
            this.panel1.Controls.Add(this.LB_SubTotal);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(2107, 811);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 388);
            this.panel1.TabIndex = 13;
            // 
            // lbl_item_total
            // 
            this.lbl_item_total.AutoSize = true;
            this.lbl_item_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item_total.Location = new System.Drawing.Point(13, 25);
            this.lbl_item_total.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_item_total.Name = "lbl_item_total";
            this.lbl_item_total.Size = new System.Drawing.Size(117, 20);
            this.lbl_item_total.TabIndex = 13;
            this.lbl_item_total.Text = "ITEM TOTAL";
            // 
            // txt_itemTotal
            // 
            this.txt_itemTotal.Location = new System.Drawing.Point(208, 14);
            this.txt_itemTotal.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txt_itemTotal.Name = "txt_itemTotal";
            this.txt_itemTotal.ReadOnly = true;
            this.txt_itemTotal.Size = new System.Drawing.Size(186, 30);
            this.txt_itemTotal.TabIndex = 12;
            this.txt_itemTotal.TabStop = false;
            // 
            // lblShip
            // 
            this.lblShip.AutoSize = true;
            this.lblShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold);
            this.lblShip.Location = new System.Drawing.Point(52, 277);
            this.lblShip.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblShip.Name = "lblShip";
            this.lblShip.Size = new System.Drawing.Size(96, 20);
            this.lblShip.TabIndex = 11;
            this.lblShip.Text = "SHIPPING";
            // 
            // txt_Ship
            // 
            this.txt_Ship.Location = new System.Drawing.Point(208, 270);
            this.txt_Ship.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txt_Ship.Name = "txt_Ship";
            this.txt_Ship.Size = new System.Drawing.Size(187, 30);
            this.txt_Ship.TabIndex = 10;
            this.txt_Ship.TabStop = false;
            // 
            // txt_TransTotal
            // 
            this.txt_TransTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TransTotal.Location = new System.Drawing.Point(208, 320);
            this.txt_TransTotal.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txt_TransTotal.Name = "txt_TransTotal";
            this.txt_TransTotal.ReadOnly = true;
            this.txt_TransTotal.Size = new System.Drawing.Size(187, 35);
            this.txt_TransTotal.TabIndex = 9;
            this.txt_TransTotal.TabStop = false;
            this.txt_TransTotal.TextChanged += new System.EventHandler(this.txt_TransTotal_TextChanged);
            // 
            // txt_transTax
            // 
            this.txt_transTax.Location = new System.Drawing.Point(208, 170);
            this.txt_transTax.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txt_transTax.Name = "txt_transTax";
            this.txt_transTax.ReadOnly = true;
            this.txt_transTax.Size = new System.Drawing.Size(186, 30);
            this.txt_transTax.TabIndex = 8;
            this.txt_transTax.TabStop = false;
            // 
            // txt_transDiscount
            // 
            this.txt_transDiscount.Location = new System.Drawing.Point(208, 62);
            this.txt_transDiscount.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txt_transDiscount.Name = "txt_transDiscount";
            this.txt_transDiscount.ReadOnly = true;
            this.txt_transDiscount.Size = new System.Drawing.Size(186, 30);
            this.txt_transDiscount.TabIndex = 7;
            this.txt_transDiscount.TabStop = false;
            // 
            // txt_transBTLDPT
            // 
            this.txt_transBTLDPT.Location = new System.Drawing.Point(208, 219);
            this.txt_transBTLDPT.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txt_transBTLDPT.Name = "txt_transBTLDPT";
            this.txt_transBTLDPT.ReadOnly = true;
            this.txt_transBTLDPT.Size = new System.Drawing.Size(186, 30);
            this.txt_transBTLDPT.TabIndex = 6;
            this.txt_transBTLDPT.TabStop = false;
            // 
            // txt_transSubTotal
            // 
            this.txt_transSubTotal.Location = new System.Drawing.Point(208, 120);
            this.txt_transSubTotal.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txt_transSubTotal.Name = "txt_transSubTotal";
            this.txt_transSubTotal.ReadOnly = true;
            this.txt_transSubTotal.Size = new System.Drawing.Size(186, 30);
            this.txt_transSubTotal.TabIndex = 5;
            this.txt_transSubTotal.TabStop = false;
            // 
            // LB_Discount
            // 
            this.LB_Discount.AutoSize = true;
            this.LB_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Discount.Location = new System.Drawing.Point(13, 70);
            this.LB_Discount.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LB_Discount.Name = "LB_Discount";
            this.LB_Discount.Size = new System.Drawing.Size(123, 20);
            this.LB_Discount.TabIndex = 4;
            this.LB_Discount.Text = "DISC. TOTAL";
            // 
            // LB_TOTAL
            // 
            this.LB_TOTAL.AutoSize = true;
            this.LB_TOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TOTAL.Location = new System.Drawing.Point(66, 325);
            this.LB_TOTAL.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LB_TOTAL.Name = "LB_TOTAL";
            this.LB_TOTAL.Size = new System.Drawing.Size(97, 29);
            this.LB_TOTAL.TabIndex = 3;
            this.LB_TOTAL.Text = "TOTAL";
            // 
            // LB_BTLDPT
            // 
            this.LB_BTLDPT.AutoSize = true;
            this.LB_BTLDPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_BTLDPT.Location = new System.Drawing.Point(66, 225);
            this.LB_BTLDPT.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LB_BTLDPT.Name = "LB_BTLDPT";
            this.LB_BTLDPT.Size = new System.Drawing.Size(87, 20);
            this.LB_BTLDPT.TabIndex = 2;
            this.LB_BTLDPT.Text = "BTL DPT";
            // 
            // LB_Tax
            // 
            this.LB_Tax.AutoSize = true;
            this.LB_Tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Tax.Location = new System.Drawing.Point(113, 177);
            this.LB_Tax.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LB_Tax.Name = "LB_Tax";
            this.LB_Tax.Size = new System.Drawing.Size(44, 20);
            this.LB_Tax.TabIndex = 1;
            this.LB_Tax.Text = "TAX";
            // 
            // LB_SubTotal
            // 
            this.LB_SubTotal.AutoSize = true;
            this.LB_SubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_SubTotal.Location = new System.Drawing.Point(26, 131);
            this.LB_SubTotal.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LB_SubTotal.Name = "LB_SubTotal";
            this.LB_SubTotal.Size = new System.Drawing.Size(112, 20);
            this.LB_SubTotal.TabIndex = 0;
            this.LB_SubTotal.Text = "SUB TOTAL";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(1466, 23);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtBarcode.MinimumSize = new System.Drawing.Size(355, 26);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(355, 35);
            this.txtBarcode.TabIndex = 15;
            this.txtBarcode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyUp);
            // 
            // lbl_BARCODE
            // 
            this.lbl_BARCODE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_BARCODE.AutoSize = true;
            this.lbl_BARCODE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BARCODE.Location = new System.Drawing.Point(1327, 33);
            this.lbl_BARCODE.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_BARCODE.Name = "lbl_BARCODE";
            this.lbl_BARCODE.Size = new System.Drawing.Size(112, 22);
            this.lbl_BARCODE.TabIndex = 17;
            this.lbl_BARCODE.Text = "BARCODE:";
            this.lbl_BARCODE.Click += new System.EventHandler(this.lbl_BARCODE_Click);
            // 
            // btnLookup
            // 
            this.btnLookup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookup.Location = new System.Drawing.Point(1871, 17);
            this.btnLookup.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnLookup.MaximumSize = new System.Drawing.Size(225, 56);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(123, 56);
            this.btnLookup.TabIndex = 19;
            this.btnLookup.TabStop = false;
            this.btnLookup.Text = "LOOKUP";
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // caseDiscount
            // 
            this.caseDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.caseDiscount.AutoSize = true;
            this.caseDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caseDiscount.Location = new System.Drawing.Point(1817, 839);
            this.caseDiscount.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.caseDiscount.Name = "caseDiscount";
            this.caseDiscount.Size = new System.Drawing.Size(211, 24);
            this.caseDiscount.TabIndex = 21;
            this.caseDiscount.Text = "Apply Case Discount";
            this.caseDiscount.UseVisualStyleBackColor = true;
            this.caseDiscount.CheckedChanged += new System.EventHandler(this.caseDiscount_CheckedChanged);
            // 
            // pb_settings
            // 
            this.pb_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_settings.Image = global::SecretCellar.Properties.Resources.Gears;
            this.pb_settings.Location = new System.Drawing.Point(26, 11);
            this.pb_settings.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pb_settings.Name = "pb_settings";
            this.pb_settings.Size = new System.Drawing.Size(104, 77);
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
            this.pictureBox1.Location = new System.Drawing.Point(936, 792);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(740, 414);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnTender
            // 
            this.btnTender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTender.AutoSize = true;
            this.btnTender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(151)))), ((int)(((byte)(152)))));
            this.btnTender.BorderColor = System.Drawing.Color.Transparent;
            this.btnTender.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnTender.FlatAppearance.BorderSize = 0;
            this.btnTender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTender.Location = new System.Drawing.Point(1716, 927);
            this.btnTender.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnTender.Name = "btnTender";
            this.btnTender.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnTender.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnTender.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnTender.Size = new System.Drawing.Size(312, 155);
            this.btnTender.TabIndex = 14;
            this.btnTender.TabStop = false;
            this.btnTender.Text = "TENDER";
            this.btnTender.TextColor = System.Drawing.Color.Black;
            this.btnTender.UseVisualStyleBackColor = false;
            this.btnTender.Click += new System.EventHandler(this.btnTender_Click);
            // 
            // lbl_twentyone
            // 
            this.lbl_twentyone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_twentyone.AutoSize = true;
            this.lbl_twentyone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_twentyone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.lbl_twentyone.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_twentyone.Location = new System.Drawing.Point(2102, 19);
            this.lbl_twentyone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_twentyone.MinimumSize = new System.Drawing.Size(433, 45);
            this.lbl_twentyone.Name = "lbl_twentyone";
            this.lbl_twentyone.Size = new System.Drawing.Size(433, 45);
            this.lbl_twentyone.TabIndex = 23;
            this.lbl_twentyone.Text = "21 Date";
            this.lbl_twentyone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(26, 820);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 84);
            this.button1.TabIndex = 24;
            this.button1.Text = "CUSTOMERS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSuspendedTransactions
            // 
            this.btnSuspendedTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuspendedTransactions.Location = new System.Drawing.Point(740, 17);
            this.btnSuspendedTransactions.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnSuspendedTransactions.Name = "btnSuspendedTransactions";
            this.btnSuspendedTransactions.Size = new System.Drawing.Size(347, 56);
            this.btnSuspendedTransactions.TabIndex = 23;
            this.btnSuspendedTransactions.TabStop = false;
            this.btnSuspendedTransactions.Text = "SUSPENDED TRANSACTIONS";
            this.btnSuspendedTransactions.UseVisualStyleBackColor = true;
            this.btnSuspendedTransactions.Click += new System.EventHandler(this.btnSuspendedTransactions_Click);
            // 
            // btnSuspendTransaction
            // 
            this.btnSuspendTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuspendTransaction.Location = new System.Drawing.Point(1122, 17);
            this.btnSuspendTransaction.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnSuspendTransaction.Name = "btnSuspendTransaction";
            this.btnSuspendTransaction.Size = new System.Drawing.Size(175, 56);
            this.btnSuspendTransaction.TabIndex = 24;
            this.btnSuspendTransaction.TabStop = false;
            this.btnSuspendTransaction.Text = "SUSPEND";
            this.btnSuspendTransaction.UseVisualStyleBackColor = true;
            this.btnSuspendTransaction.Click += new System.EventHandler(this.btnSuspendTransaction_Click);
            // 
            // txt_current_cust
            // 
            this.txt_current_cust.Location = new System.Drawing.Point(389, 39);
            this.txt_current_cust.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_current_cust.Name = "txt_current_cust";
            this.txt_current_cust.Size = new System.Drawing.Size(254, 30);
            this.txt_current_cust.TabIndex = 25;
            // 
            // lbl_current_cust
            // 
            this.lbl_current_cust.AutoSize = true;
            this.lbl_current_cust.Location = new System.Drawing.Point(192, 44);
            this.lbl_current_cust.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_current_cust.Name = "lbl_current_cust";
            this.lbl_current_cust.Size = new System.Drawing.Size(183, 25);
            this.lbl_current_cust.TabIndex = 26;
            this.lbl_current_cust.Text = "Current Customer";
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(151)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(2565, 1223);
            this.Controls.Add(this.lbl_current_cust);
            this.Controls.Add(this.txt_current_cust);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSuspendTransaction);
            this.Controls.Add(this.btnSuspendedTransactions);
            this.Controls.Add(this.lbl_twentyone);
            this.Controls.Add(this.caseDiscount);
            this.Controls.Add(this.pb_settings);
            this.Controls.Add(this.btnLookup);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_BARCODE);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.btnTender);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.btnVoidTrx);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnShipping);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnDryClean);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.btnPropane);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "frmTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secret Cellar POS";
            this.Load += new System.EventHandler(this.frmTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPropane;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnShipping;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnDryClean;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnVoidTrx;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LB_TOTAL;
        private System.Windows.Forms.Label LB_BTLDPT;
        private System.Windows.Forms.Label LB_Tax;
        private System.Windows.Forms.Label LB_SubTotal;
        private ePOSOne.btnProduct.Button_WOC btnTender;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label LB_Discount;
        private System.Windows.Forms.TextBox txt_transSubTotal;
        private System.Windows.Forms.TextBox txt_transBTLDPT;
        private System.Windows.Forms.Label lbl_BARCODE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_transTax;
        private System.Windows.Forms.TextBox txt_transDiscount;
        private System.Windows.Forms.TextBox txt_TransTotal;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.Label lblShip;
        private System.Windows.Forms.TextBox txt_Ship;
        private System.Windows.Forms.Label lbl_item_total;
        private System.Windows.Forms.TextBox txt_itemTotal;
        private System.Windows.Forms.PictureBox pb_settings;
        private System.Windows.Forms.CheckBox caseDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISCOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAX;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOTTLE_DEPOSIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
		private System.Windows.Forms.Button btnSuspendedTransactions;
		private System.Windows.Forms.Button btnSuspendTransaction;
        private System.Windows.Forms.Label lbl_twentyone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_current_cust;
        private System.Windows.Forms.Label lbl_current_cust;
    }
}