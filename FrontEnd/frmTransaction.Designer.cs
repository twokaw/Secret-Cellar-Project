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
            this.btnBeverages = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnShipping = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnDryClean = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnVoidTrx = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLookup = new System.Windows.Forms.Button();
            this.btnTender = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataGridView1.Location = new System.Drawing.Point(15, 51);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1157, 266);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.QTY.FillWeight = 154.4118F;
            this.QTY.HeaderText = "QTY";
            this.QTY.MinimumWidth = 12;
            this.QTY.Name = "QTY";
            this.QTY.Width = 57;
            // 
            // PRICE
            // 
            this.PRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRICE.FillWeight = 18.80306F;
            this.PRICE.HeaderText = "PRICE";
            this.PRICE.MinimumWidth = 12;
            this.PRICE.Name = "PRICE";
            // 
            // DISCOUNT
            // 
            this.DISCOUNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DISCOUNT.FillWeight = 37.25315F;
            this.DISCOUNT.HeaderText = "DISCOUNT";
            this.DISCOUNT.MinimumWidth = 25;
            this.DISCOUNT.Name = "DISCOUNT";
            // 
            // TAX
            // 
            this.TAX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TAX.FillWeight = 57.0944F;
            this.TAX.HeaderText = "TAX";
            this.TAX.MinimumWidth = 12;
            this.TAX.Name = "TAX";
            // 
            // BOTTLE_DEPOSIT
            // 
            this.BOTTLE_DEPOSIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BOTTLE_DEPOSIT.FillWeight = 88.47124F;
            this.BOTTLE_DEPOSIT.HeaderText = "BOTTLE DEPOSIT";
            this.BOTTLE_DEPOSIT.MinimumWidth = 12;
            this.BOTTLE_DEPOSIT.Name = "BOTTLE_DEPOSIT";
            // 
            // TOTAL
            // 
            this.TOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TOTAL.FillWeight = 138.0905F;
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.MinimumWidth = 12;
            this.TOTAL.Name = "TOTAL";
            // 
            // btnBeverages
            // 
            this.btnBeverages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBeverages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeverages.Location = new System.Drawing.Point(15, 332);
            this.btnBeverages.Margin = new System.Windows.Forms.Padding(1);
            this.btnBeverages.Name = "btnBeverages";
            this.btnBeverages.Size = new System.Drawing.Size(120, 44);
            this.btnBeverages.TabIndex = 3;
            this.btnBeverages.TabStop = false;
            this.btnBeverages.Text = "BEVERAGES";
            this.btnBeverages.UseVisualStyleBackColor = true;
            // 
            // btnFood
            // 
            this.btnFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.Location = new System.Drawing.Point(15, 407);
            this.btnFood.Margin = new System.Windows.Forms.Padding(1);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(120, 44);
            this.btnFood.TabIndex = 4;
            this.btnFood.TabStop = false;
            this.btnFood.Text = "FOOD";
            this.btnFood.UseVisualStyleBackColor = true;
            // 
            // btnCustom
            // 
            this.btnCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustom.Location = new System.Drawing.Point(15, 483);
            this.btnCustom.Margin = new System.Windows.Forms.Padding(1);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(120, 44);
            this.btnCustom.TabIndex = 5;
            this.btnCustom.TabStop = false;
            this.btnCustom.Text = "CUSTOM";
            this.btnCustom.UseVisualStyleBackColor = true;
            // 
            // btnShipping
            // 
            this.btnShipping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShipping.Location = new System.Drawing.Point(154, 483);
            this.btnShipping.Margin = new System.Windows.Forms.Padding(1);
            this.btnShipping.Name = "btnShipping";
            this.btnShipping.Size = new System.Drawing.Size(120, 44);
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
            this.btnEvents.Location = new System.Drawing.Point(154, 407);
            this.btnEvents.Margin = new System.Windows.Forms.Padding(1);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(120, 44);
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
            this.btnDryClean.Location = new System.Drawing.Point(154, 332);
            this.btnDryClean.Margin = new System.Windows.Forms.Padding(1);
            this.btnDryClean.Name = "btnDryClean";
            this.btnDryClean.Size = new System.Drawing.Size(120, 44);
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
            this.btnDiscount.Location = new System.Drawing.Point(292, 483);
            this.btnDiscount.Margin = new System.Windows.Forms.Padding(1);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(120, 44);
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
            this.btnVoidTrx.Location = new System.Drawing.Point(292, 407);
            this.btnVoidTrx.Margin = new System.Windows.Forms.Padding(1);
            this.btnVoidTrx.Name = "btnVoidTrx";
            this.btnVoidTrx.Size = new System.Drawing.Size(120, 44);
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
            this.btnDeleteItem.Location = new System.Drawing.Point(292, 332);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(1);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(120, 44);
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
            this.panel1.Location = new System.Drawing.Point(976, 348);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 173);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_TransTotal
            // 
            this.txt_TransTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TransTotal.Location = new System.Drawing.Point(96, 136);
            this.txt_TransTotal.Margin = new System.Windows.Forms.Padding(1);
            this.txt_TransTotal.Name = "txt_TransTotal";
            this.txt_TransTotal.ReadOnly = true;
            this.txt_TransTotal.Size = new System.Drawing.Size(89, 26);
            this.txt_TransTotal.TabIndex = 9;
            this.txt_TransTotal.TabStop = false;
            // 
            // txt_transTax
            // 
            this.txt_transTax.Location = new System.Drawing.Point(96, 58);
            this.txt_transTax.Margin = new System.Windows.Forms.Padding(1);
            this.txt_transTax.Name = "txt_transTax";
            this.txt_transTax.ReadOnly = true;
            this.txt_transTax.Size = new System.Drawing.Size(88, 23);
            this.txt_transTax.TabIndex = 8;
            this.txt_transTax.TabStop = false;
            // 
            // txt_transDiscount
            // 
            this.txt_transDiscount.Location = new System.Drawing.Point(96, 33);
            this.txt_transDiscount.Margin = new System.Windows.Forms.Padding(1);
            this.txt_transDiscount.Name = "txt_transDiscount";
            this.txt_transDiscount.ReadOnly = true;
            this.txt_transDiscount.Size = new System.Drawing.Size(88, 23);
            this.txt_transDiscount.TabIndex = 7;
            this.txt_transDiscount.TabStop = false;
            this.txt_transDiscount.TextChanged += new System.EventHandler(this.txt_transDiscount_TextChanged);
            // 
            // txt_transBTLDPT
            // 
            this.txt_transBTLDPT.Location = new System.Drawing.Point(96, 83);
            this.txt_transBTLDPT.Margin = new System.Windows.Forms.Padding(1);
            this.txt_transBTLDPT.Name = "txt_transBTLDPT";
            this.txt_transBTLDPT.ReadOnly = true;
            this.txt_transBTLDPT.Size = new System.Drawing.Size(88, 23);
            this.txt_transBTLDPT.TabIndex = 6;
            this.txt_transBTLDPT.TabStop = false;
            // 
            // txt_transSubTotal
            // 
            this.txt_transSubTotal.Location = new System.Drawing.Point(96, 9);
            this.txt_transSubTotal.Margin = new System.Windows.Forms.Padding(1);
            this.txt_transSubTotal.Name = "txt_transSubTotal";
            this.txt_transSubTotal.ReadOnly = true;
            this.txt_transSubTotal.Size = new System.Drawing.Size(88, 23);
            this.txt_transSubTotal.TabIndex = 5;
            this.txt_transSubTotal.TabStop = false;
            this.txt_transSubTotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LB_Discount
            // 
            this.LB_Discount.AutoSize = true;
            this.LB_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Discount.Location = new System.Drawing.Point(6, 36);
            this.LB_Discount.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LB_Discount.Name = "LB_Discount";
            this.LB_Discount.Size = new System.Drawing.Size(84, 13);
            this.LB_Discount.TabIndex = 4;
            this.LB_Discount.Text = "DISC. TOTAL";
            // 
            // LB_TOTAL
            // 
            this.LB_TOTAL.AutoSize = true;
            this.LB_TOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TOTAL.Location = new System.Drawing.Point(31, 138);
            this.LB_TOTAL.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LB_TOTAL.Name = "LB_TOTAL";
            this.LB_TOTAL.Size = new System.Drawing.Size(64, 20);
            this.LB_TOTAL.TabIndex = 3;
            this.LB_TOTAL.Text = "TOTAL";
            // 
            // LB_BTLDPT
            // 
            this.LB_BTLDPT.AutoSize = true;
            this.LB_BTLDPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_BTLDPT.Location = new System.Drawing.Point(31, 86);
            this.LB_BTLDPT.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LB_BTLDPT.Name = "LB_BTLDPT";
            this.LB_BTLDPT.Size = new System.Drawing.Size(59, 13);
            this.LB_BTLDPT.TabIndex = 2;
            this.LB_BTLDPT.Text = "BTL DPT";
            // 
            // LB_Tax
            // 
            this.LB_Tax.AutoSize = true;
            this.LB_Tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Tax.Location = new System.Drawing.Point(52, 61);
            this.LB_Tax.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LB_Tax.Name = "LB_Tax";
            this.LB_Tax.Size = new System.Drawing.Size(31, 13);
            this.LB_Tax.TabIndex = 1;
            this.LB_Tax.Text = "TAX";
            // 
            // LB_SubTotal
            // 
            this.LB_SubTotal.AutoSize = true;
            this.LB_SubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_SubTotal.Location = new System.Drawing.Point(12, 11);
            this.LB_SubTotal.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LB_SubTotal.Name = "LB_SubTotal";
            this.LB_SubTotal.Size = new System.Drawing.Size(76, 13);
            this.LB_SubTotal.TabIndex = 0;
            this.LB_SubTotal.Text = "SUB TOTAL";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(444, 12);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(1);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(166, 26);
            this.txtBarcode.TabIndex = 15;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            this.txtBarcode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyUp);
            // 
            // lbl_BARCODE
            // 
            this.lbl_BARCODE.AutoSize = true;
            this.lbl_BARCODE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BARCODE.Location = new System.Drawing.Point(357, 17);
            this.lbl_BARCODE.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_BARCODE.Name = "lbl_BARCODE";
            this.lbl_BARCODE.Size = new System.Drawing.Size(72, 15);
            this.lbl_BARCODE.TabIndex = 17;
            this.lbl_BARCODE.Text = "BARCODE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(435, 343);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnLookup
            // 
            this.btnLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookup.Location = new System.Drawing.Point(643, 10);
            this.btnLookup.Margin = new System.Windows.Forms.Padding(1);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(104, 29);
            this.btnLookup.TabIndex = 19;
            this.btnLookup.TabStop = false;
            this.btnLookup.Text = "LOOKUP";
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
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
            this.btnTender.Location = new System.Drawing.Point(782, 397);
            this.btnTender.Margin = new System.Windows.Forms.Padding(1);
            this.btnTender.Name = "btnTender";
            this.btnTender.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnTender.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnTender.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnTender.Size = new System.Drawing.Size(144, 80);
            this.btnTender.TabIndex = 14;
            this.btnTender.TabStop = false;
            this.btnTender.Text = "TENDER";
            this.btnTender.TextColor = System.Drawing.Color.Black;
            this.btnTender.UseVisualStyleBackColor = false;
            this.btnTender.Click += new System.EventHandler(this.btnTender_Click);
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(151)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(1188, 546);
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
            this.Controls.Add(this.btnFood);
            this.Controls.Add(this.btnBeverages);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTransaction";
            this.Load += new System.EventHandler(this.frmTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBeverages;
        private System.Windows.Forms.Button btnFood;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISCOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAX;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOTTLE_DEPOSIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
    }
}