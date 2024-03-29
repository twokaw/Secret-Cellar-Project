﻿namespace SecretCellar
{
    partial class frmDiscount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiscount));
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPercentTotalSale = new System.Windows.Forms.Label();
            this.txtPercentTotalSale = new System.Windows.Forms.TextBox();
            this.lblFixedDiscount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Coupon = new System.Windows.Forms.Button();
            this.txtFixedDiscount = new SecretCellar.CurrencyBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ApplyDiscount = new System.Windows.Forms.Button();
            this.txt_discountTotal = new SecretCellar.CurrencyBox();
            this.total_lbl = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.touchKeyPad1 = new SecretCellar.TouchKeyPad();
            this.lblPercentLineItem = new System.Windows.Forms.Label();
            this.button_ApplyToItem = new System.Windows.Forms.Button();
            this.dataGridSelectItems = new System.Windows.Forms.DataGridView();
            this.ItemNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegularPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPercentLineItem = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelectItems)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(1875, 862);
            this.btnExit.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(298, 112);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPercentTotalSale
            // 
            this.lblPercentTotalSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentTotalSale.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPercentTotalSale.Location = new System.Drawing.Point(10, 42);
            this.lblPercentTotalSale.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblPercentTotalSale.Name = "lblPercentTotalSale";
            this.lblPercentTotalSale.Size = new System.Drawing.Size(394, 75);
            this.lblPercentTotalSale.TabIndex = 12;
            this.lblPercentTotalSale.Text = "Total Discount (%)";
            this.lblPercentTotalSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPercentTotalSale
            // 
            this.txtPercentTotalSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentTotalSale.Location = new System.Drawing.Point(434, 51);
            this.txtPercentTotalSale.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtPercentTotalSale.MaxLength = 2;
            this.txtPercentTotalSale.Name = "txtPercentTotalSale";
            this.txtPercentTotalSale.Size = new System.Drawing.Size(91, 53);
            this.txtPercentTotalSale.TabIndex = 0;
            this.txtPercentTotalSale.Click += new System.EventHandler(this.txtPercentTotalSale_Click);
            this.txtPercentTotalSale.Enter += new System.EventHandler(this.txtCashAmt_Enter);
            this.txtPercentTotalSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_only);
            // 
            // lblFixedDiscount
            // 
            this.lblFixedDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixedDiscount.Location = new System.Drawing.Point(10, 40);
            this.lblFixedDiscount.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblFixedDiscount.Name = "lblFixedDiscount";
            this.lblFixedDiscount.Size = new System.Drawing.Size(380, 76);
            this.lblFixedDiscount.TabIndex = 14;
            this.lblFixedDiscount.Text = "Total Discount ($)";
            this.lblFixedDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(201)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.button_Coupon);
            this.panel1.Controls.Add(this.txtFixedDiscount);
            this.panel1.Controls.Add(this.lblFixedDiscount);
            this.panel1.Location = new System.Drawing.Point(16, 816);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 156);
            this.panel1.TabIndex = 17;
            // 
            // button_Coupon
            // 
            this.button_Coupon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Coupon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Coupon.Location = new System.Drawing.Point(652, 28);
            this.button_Coupon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_Coupon.Name = "button_Coupon";
            this.button_Coupon.Size = new System.Drawing.Size(206, 104);
            this.button_Coupon.TabIndex = 5;
            this.button_Coupon.Text = "Apply";
            this.button_Coupon.UseVisualStyleBackColor = true;
            this.button_Coupon.Click += new System.EventHandler(this.button_Coupon_Click);
            // 
            // txtFixedDiscount
            // 
            this.txtFixedDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFixedDiscount.ForeColor = System.Drawing.Color.Black;
            this.txtFixedDiscount.Location = new System.Drawing.Point(401, 53);
            this.txtFixedDiscount.Name = "txtFixedDiscount";
            this.txtFixedDiscount.Size = new System.Drawing.Size(215, 53);
            this.txtFixedDiscount.TabIndex = 4;
            this.txtFixedDiscount.Text = "$0.00";
            this.txtFixedDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFixedDiscount.Value = 0D;
            this.txtFixedDiscount.Enter += new System.EventHandler(this.txtCashAmt_Enter);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(201)))), ((int)(((byte)(176)))));
            this.panel2.Controls.Add(this.txtPercentTotalSale);
            this.panel2.Controls.Add(this.btn_ApplyDiscount);
            this.panel2.Controls.Add(this.lblPercentTotalSale);
            this.panel2.Location = new System.Drawing.Point(16, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 160);
            this.panel2.TabIndex = 18;
            // 
            // btn_ApplyDiscount
            // 
            this.btn_ApplyDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ApplyDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ApplyDiscount.Location = new System.Drawing.Point(652, 28);
            this.btn_ApplyDiscount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_ApplyDiscount.Name = "btn_ApplyDiscount";
            this.btn_ApplyDiscount.Size = new System.Drawing.Size(206, 104);
            this.btn_ApplyDiscount.TabIndex = 1;
            this.btn_ApplyDiscount.Text = "Apply";
            this.btn_ApplyDiscount.UseVisualStyleBackColor = true;
            this.btn_ApplyDiscount.Click += new System.EventHandler(this.btn_ApplyDiscount_Click);
            // 
            // txt_discountTotal
            // 
            this.txt_discountTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discountTotal.ForeColor = System.Drawing.Color.Black;
            this.txt_discountTotal.Location = new System.Drawing.Point(1270, 777);
            this.txt_discountTotal.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txt_discountTotal.Name = "txt_discountTotal";
            this.txt_discountTotal.ReadOnly = true;
            this.txt_discountTotal.Size = new System.Drawing.Size(210, 53);
            this.txt_discountTotal.TabIndex = 20;
            this.txt_discountTotal.TabStop = false;
            this.txt_discountTotal.Text = "$0.00";
            this.txt_discountTotal.Value = 0D;
            // 
            // total_lbl
            // 
            this.total_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.total_lbl.Location = new System.Drawing.Point(908, 778);
            this.total_lbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(346, 63);
            this.total_lbl.TabIndex = 21;
            this.total_lbl.Text = "Total Discount :";
            this.total_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.Location = new System.Drawing.Point(933, 885);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(260, 104);
            this.button_Clear.TabIndex = 7;
            this.button_Clear.TabStop = false;
            this.button_Clear.Text = "Reset";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Close
            // 
            this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Close.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.Location = new System.Drawing.Point(1226, 885);
            this.button_Close.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(260, 104);
            this.button_Close.TabIndex = 8;
            this.button_Close.TabStop = false;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // touchKeyPad1
            // 
            this.touchKeyPad1.Location = new System.Drawing.Point(920, 82);
            this.touchKeyPad1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.touchKeyPad1.Name = "touchKeyPad1";
            this.touchKeyPad1.Size = new System.Drawing.Size(564, 554);
            this.touchKeyPad1.TabIndex = 6;
            this.touchKeyPad1.TabStop = false;
            this.touchKeyPad1.Target = null;
            // 
            // lblPercentLineItem
            // 
            this.lblPercentLineItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentLineItem.Location = new System.Drawing.Point(24, 48);
            this.lblPercentLineItem.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblPercentLineItem.Name = "lblPercentLineItem";
            this.lblPercentLineItem.Size = new System.Drawing.Size(380, 76);
            this.lblPercentLineItem.TabIndex = 10;
            this.lblPercentLineItem.Text = "Item Discount (%)";
            this.lblPercentLineItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_ApplyToItem
            // 
            this.button_ApplyToItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_ApplyToItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ApplyToItem.Location = new System.Drawing.Point(652, 36);
            this.button_ApplyToItem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_ApplyToItem.Name = "button_ApplyToItem";
            this.button_ApplyToItem.Size = new System.Drawing.Size(206, 104);
            this.button_ApplyToItem.TabIndex = 3;
            this.button_ApplyToItem.Text = "Apply";
            this.button_ApplyToItem.UseVisualStyleBackColor = true;
            this.button_ApplyToItem.Click += new System.EventHandler(this.button_ApplyToItem_Click);
            // 
            // dataGridSelectItems
            // 
            this.dataGridSelectItems.AllowUserToAddRows = false;
            this.dataGridSelectItems.AllowUserToDeleteRows = false;
            this.dataGridSelectItems.AllowUserToResizeColumns = false;
            this.dataGridSelectItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Ivory;
            this.dataGridSelectItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridSelectItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridSelectItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSelectItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(196)))));
            this.dataGridSelectItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSelectItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNumber,
            this.ItemDescription,
            this.RegularPrice,
            this.SalePrice,
            this.Price,
            this.Discount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSelectItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridSelectItems.Location = new System.Drawing.Point(18, 158);
            this.dataGridSelectItems.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.dataGridSelectItems.Name = "dataGridSelectItems";
            this.dataGridSelectItems.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSelectItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridSelectItems.RowHeadersVisible = false;
            this.dataGridSelectItems.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridSelectItems.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridSelectItems.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridSelectItems.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridSelectItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSelectItems.Size = new System.Drawing.Size(840, 374);
            this.dataGridSelectItems.TabIndex = 5;
            this.dataGridSelectItems.TabStop = false;
            this.dataGridSelectItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSelectItems_CellContentClick);
            // 
            // ItemNumber
            // 
            this.ItemNumber.HeaderText = "Item Number";
            this.ItemNumber.MinimumWidth = 8;
            this.ItemNumber.Name = "ItemNumber";
            this.ItemNumber.ReadOnly = true;
            this.ItemNumber.Visible = false;
            // 
            // ItemDescription
            // 
            this.ItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemDescription.FillWeight = 54.05275F;
            this.ItemDescription.HeaderText = "Item Desc.";
            this.ItemDescription.MinimumWidth = 8;
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.ReadOnly = true;
            // 
            // RegularPrice
            // 
            this.RegularPrice.FillWeight = 20.78952F;
            this.RegularPrice.HeaderText = "Regular Price";
            this.RegularPrice.MinimumWidth = 8;
            this.RegularPrice.Name = "RegularPrice";
            this.RegularPrice.ReadOnly = true;
            // 
            // SalePrice
            // 
            this.SalePrice.FillWeight = 20F;
            this.SalePrice.HeaderText = "Sale Price";
            this.SalePrice.MinimumWidth = 8;
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.FillWeight = 20.78952F;
            this.Price.HeaderText = "Discount Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.FillWeight = 20.78952F;
            this.Discount.HeaderText = "Discount";
            this.Discount.MinimumWidth = 8;
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // txtPercentLineItem
            // 
            this.txtPercentLineItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentLineItem.Location = new System.Drawing.Point(434, 60);
            this.txtPercentLineItem.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtPercentLineItem.MaxLength = 2;
            this.txtPercentLineItem.Name = "txtPercentLineItem";
            this.txtPercentLineItem.Size = new System.Drawing.Size(91, 53);
            this.txtPercentLineItem.TabIndex = 2;
            this.txtPercentLineItem.Enter += new System.EventHandler(this.txtCashAmt_Enter);
            this.txtPercentLineItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_only);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(201)))), ((int)(((byte)(176)))));
            this.panel3.Controls.Add(this.txtPercentLineItem);
            this.panel3.Controls.Add(this.dataGridSelectItems);
            this.panel3.Controls.Add(this.button_ApplyToItem);
            this.panel3.Controls.Add(this.lblPercentLineItem);
            this.panel3.Location = new System.Drawing.Point(16, 216);
            this.panel3.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(874, 556);
            this.panel3.TabIndex = 19;
            // 
            // frmDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1497, 1012);
            this.Controls.Add(this.touchKeyPad1);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.total_lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_discountTotal);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discount";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelectItems)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPercentTotalSale;
        private System.Windows.Forms.TextBox txtPercentTotalSale;
        private System.Windows.Forms.Label lblFixedDiscount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private SecretCellar.CurrencyBox txt_discountTotal;
        private System.Windows.Forms.Label total_lbl;
        private CurrencyBox txtFixedDiscount;
		private System.Windows.Forms.Button button_Coupon;
		private System.Windows.Forms.Button btn_ApplyDiscount;
		private System.Windows.Forms.Button button_Clear;
		private System.Windows.Forms.Button button_Close;
        private TouchKeyPad touchKeyPad1;
        private System.Windows.Forms.Label lblPercentLineItem;
        private System.Windows.Forms.Button button_ApplyToItem;
        private System.Windows.Forms.DataGridView dataGridSelectItems;
        private System.Windows.Forms.TextBox txtPercentLineItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegularPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
    }
}