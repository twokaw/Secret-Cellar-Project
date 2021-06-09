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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiscount));
			this.btnExit = new System.Windows.Forms.Button();
			this.txtPercentLineItem = new System.Windows.Forms.TextBox();
			this.lblPercentLineItem = new System.Windows.Forms.Label();
			this.lblPercentTotalSale = new System.Windows.Forms.Label();
			this.txtPercentTotalSale = new System.Windows.Forms.TextBox();
			this.lblFixedDiscount = new System.Windows.Forms.Label();
			this.dataGridSelectItems = new System.Windows.Forms.DataGridView();
			this.ItemNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RegularPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button_Coupon = new System.Windows.Forms.Button();
			this.txtFixedDiscount = new SecretCellar.CurrencyBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btn_ApplyDiscount = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.button_ApplyToItem = new System.Windows.Forms.Button();
			this.txt_discountTotal = new System.Windows.Forms.TextBox();
			this.total_lbl = new System.Windows.Forms.Label();
			this.button_Clear = new System.Windows.Forms.Button();
			this.button_Close = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridSelectItems)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.ForeColor = System.Drawing.Color.Red;
			this.btnExit.Location = new System.Drawing.Point(1340, 434);
			this.btnExit.Margin = new System.Windows.Forms.Padding(4);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(179, 60);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "Close";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// txtPercentLineItem
			// 
			this.txtPercentLineItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPercentLineItem.Location = new System.Drawing.Point(362, 46);
			this.txtPercentLineItem.Margin = new System.Windows.Forms.Padding(4);
			this.txtPercentLineItem.Name = "txtPercentLineItem";
			this.txtPercentLineItem.Size = new System.Drawing.Size(138, 29);
			this.txtPercentLineItem.TabIndex = 5;
			this.txtPercentLineItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_only);
			// 
			// lblPercentLineItem
			// 
			this.lblPercentLineItem.AutoSize = true;
			this.lblPercentLineItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
			this.lblPercentLineItem.Location = new System.Drawing.Point(22, 42);
			this.lblPercentLineItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPercentLineItem.Name = "lblPercentLineItem";
			this.lblPercentLineItem.Size = new System.Drawing.Size(295, 31);
			this.lblPercentLineItem.TabIndex = 10;
			this.lblPercentLineItem.Text = "Enter Item Discount(%)";
			// 
			// lblPercentTotalSale
			// 
			this.lblPercentTotalSale.AutoSize = true;
			this.lblPercentTotalSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
			this.lblPercentTotalSale.Location = new System.Drawing.Point(25, 19);
			this.lblPercentTotalSale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPercentTotalSale.Name = "lblPercentTotalSale";
			this.lblPercentTotalSale.Size = new System.Drawing.Size(231, 31);
			this.lblPercentTotalSale.TabIndex = 12;
			this.lblPercentTotalSale.Text = "Total Discount(%)";
			// 
			// txtPercentTotalSale
			// 
			this.txtPercentTotalSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPercentTotalSale.Location = new System.Drawing.Point(30, 61);
			this.txtPercentTotalSale.Margin = new System.Windows.Forms.Padding(4);
			this.txtPercentTotalSale.Name = "txtPercentTotalSale";
			this.txtPercentTotalSale.Size = new System.Drawing.Size(218, 29);
			this.txtPercentTotalSale.TabIndex = 3;
			this.txtPercentTotalSale.Click += new System.EventHandler(this.txtPercentTotalSale_Click);
			this.txtPercentTotalSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_only);
			// 
			// lblFixedDiscount
			// 
			this.lblFixedDiscount.AutoSize = true;
			this.lblFixedDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
			this.lblFixedDiscount.Location = new System.Drawing.Point(25, 20);
			this.lblFixedDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFixedDiscount.Name = "lblFixedDiscount";
			this.lblFixedDiscount.Size = new System.Drawing.Size(222, 31);
			this.lblFixedDiscount.TabIndex = 14;
			this.lblFixedDiscount.Text = "Total Discount($)";
			// 
			// dataGridSelectItems
			// 
			this.dataGridSelectItems.AllowUserToAddRows = false;
			this.dataGridSelectItems.AllowUserToDeleteRows = false;
			this.dataGridSelectItems.AllowUserToResizeColumns = false;
			this.dataGridSelectItems.AllowUserToResizeRows = false;
			this.dataGridSelectItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridSelectItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridSelectItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNumber,
            this.ItemDescription,
            this.RegularPrice,
            this.Price,
            this.Discount});
			this.dataGridSelectItems.Location = new System.Drawing.Point(18, 103);
			this.dataGridSelectItems.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridSelectItems.Name = "dataGridSelectItems";
			this.dataGridSelectItems.RowHeadersVisible = false;
			this.dataGridSelectItems.RowHeadersWidth = 62;
			this.dataGridSelectItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridSelectItems.Size = new System.Drawing.Size(737, 349);
			this.dataGridSelectItems.TabIndex = 7;
			this.dataGridSelectItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSelectItems_CellContentClick);
			// 
			// ItemNumber
			// 
			this.ItemNumber.HeaderText = "Item Number";
			this.ItemNumber.MinimumWidth = 8;
			this.ItemNumber.Name = "ItemNumber";
			this.ItemNumber.ReadOnly = true;
			this.ItemNumber.Visible = false;
			this.ItemNumber.Width = 200;
			// 
			// ItemDescription
			// 
			this.ItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ItemDescription.HeaderText = "Item Desc.";
			this.ItemDescription.MinimumWidth = 8;
			this.ItemDescription.Name = "ItemDescription";
			this.ItemDescription.ReadOnly = true;
			// 
			// RegularPrice
			// 
			this.RegularPrice.HeaderText = "Regular Price";
			this.RegularPrice.MinimumWidth = 8;
			this.RegularPrice.Name = "RegularPrice";
			this.RegularPrice.Width = 150;
			// 
			// Price
			// 
			this.Price.HeaderText = "Discount Price";
			this.Price.MinimumWidth = 8;
			this.Price.Name = "Price";
			this.Price.ReadOnly = true;
			this.Price.Width = 150;
			// 
			// Discount
			// 
			this.Discount.HeaderText = "Discount";
			this.Discount.MinimumWidth = 8;
			this.Discount.Name = "Discount";
			this.Discount.ReadOnly = true;
			this.Discount.Width = 150;
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel1.Controls.Add(this.button_Coupon);
			this.panel1.Controls.Add(this.txtFixedDiscount);
			this.panel1.Controls.Add(this.lblFixedDiscount);
			this.panel1.Location = new System.Drawing.Point(17, 103);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(483, 106);
			this.panel1.TabIndex = 17;
			// 
			// button_Coupon
			// 
			this.button_Coupon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_Coupon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Coupon.Location = new System.Drawing.Point(289, 29);
			this.button_Coupon.Margin = new System.Windows.Forms.Padding(1);
			this.button_Coupon.Name = "button_Coupon";
			this.button_Coupon.Size = new System.Drawing.Size(180, 55);
			this.button_Coupon.TabIndex = 2;
			this.button_Coupon.Text = "APPLY";
			this.button_Coupon.UseVisualStyleBackColor = true;
			this.button_Coupon.Click += new System.EventHandler(this.button_Coupon_Click);
			// 
			// txtFixedDiscount
			// 
			this.txtFixedDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFixedDiscount.Location = new System.Drawing.Point(30, 62);
			this.txtFixedDiscount.Margin = new System.Windows.Forms.Padding(2);
			this.txtFixedDiscount.Name = "txtFixedDiscount";
			this.txtFixedDiscount.Size = new System.Drawing.Size(218, 29);
			this.txtFixedDiscount.TabIndex = 1;
			this.txtFixedDiscount.Text = "0.00";
			this.txtFixedDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// panel2
			// 
			this.panel2.AutoSize = true;
			this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel2.Controls.Add(this.btn_ApplyDiscount);
			this.panel2.Controls.Add(this.lblPercentTotalSale);
			this.panel2.Controls.Add(this.txtPercentTotalSale);
			this.panel2.Location = new System.Drawing.Point(17, 244);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(483, 106);
			this.panel2.TabIndex = 18;
			// 
			// btn_ApplyDiscount
			// 
			this.btn_ApplyDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_ApplyDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_ApplyDiscount.Location = new System.Drawing.Point(289, 28);
			this.btn_ApplyDiscount.Margin = new System.Windows.Forms.Padding(1);
			this.btn_ApplyDiscount.Name = "btn_ApplyDiscount";
			this.btn_ApplyDiscount.Size = new System.Drawing.Size(180, 55);
			this.btn_ApplyDiscount.TabIndex = 4;
			this.btn_ApplyDiscount.Text = "APPLY";
			this.btn_ApplyDiscount.UseVisualStyleBackColor = true;
			this.btn_ApplyDiscount.Click += new System.EventHandler(this.btn_ApplyDiscount_Click);
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.AutoSize = true;
			this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel3.Controls.Add(this.dataGridSelectItems);
			this.panel3.Controls.Add(this.button_ApplyToItem);
			this.panel3.Controls.Add(this.lblPercentLineItem);
			this.panel3.Controls.Add(this.txtPercentLineItem);
			this.panel3.Location = new System.Drawing.Point(517, 20);
			this.panel3.Margin = new System.Windows.Forms.Padding(4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(773, 471);
			this.panel3.TabIndex = 19;
			// 
			// button_ApplyToItem
			// 
			this.button_ApplyToItem.BackColor = System.Drawing.SystemColors.ControlDark;
			this.button_ApplyToItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_ApplyToItem.Location = new System.Drawing.Point(575, 35);
			this.button_ApplyToItem.Margin = new System.Windows.Forms.Padding(1);
			this.button_ApplyToItem.Name = "button_ApplyToItem";
			this.button_ApplyToItem.Size = new System.Drawing.Size(180, 55);
			this.button_ApplyToItem.TabIndex = 6;
			this.button_ApplyToItem.Text = "APPLY";
			this.button_ApplyToItem.UseVisualStyleBackColor = true;
			this.button_ApplyToItem.Click += new System.EventHandler(this.button_ApplyToItem_Click);
			// 
			// txt_discountTotal
			// 
			this.txt_discountTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_discountTotal.Location = new System.Drawing.Point(269, 380);
			this.txt_discountTotal.Margin = new System.Windows.Forms.Padding(4);
			this.txt_discountTotal.Name = "txt_discountTotal";
			this.txt_discountTotal.ReadOnly = true;
			this.txt_discountTotal.Size = new System.Drawing.Size(231, 38);
			this.txt_discountTotal.TabIndex = 20;
			this.txt_discountTotal.TabStop = false;
			// 
			// total_lbl
			// 
			this.total_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.total_lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.total_lbl.Location = new System.Drawing.Point(13, 380);
			this.total_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.total_lbl.Name = "total_lbl";
			this.total_lbl.Size = new System.Drawing.Size(233, 46);
			this.total_lbl.TabIndex = 21;
			this.total_lbl.Text = "Total Discount $";
			this.total_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// button_Clear
			// 
			this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Clear.Location = new System.Drawing.Point(19, 20);
			this.button_Clear.Margin = new System.Windows.Forms.Padding(1);
			this.button_Clear.Name = "button_Clear";
			this.button_Clear.Size = new System.Drawing.Size(180, 55);
			this.button_Clear.TabIndex = 0;
			this.button_Clear.Text = "RESET";
			this.button_Clear.UseVisualStyleBackColor = true;
			this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
			// 
			// button_Close
			// 
			this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_Close.BackColor = System.Drawing.SystemColors.ControlDark;
			this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Close.Location = new System.Drawing.Point(17, 436);
			this.button_Close.Margin = new System.Windows.Forms.Padding(1);
			this.button_Close.Name = "button_Close";
			this.button_Close.Size = new System.Drawing.Size(180, 55);
			this.button_Close.TabIndex = 8;
			this.button_Close.Text = "CLOSE WINDOW";
			this.button_Close.UseVisualStyleBackColor = true;
			this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
			// 
			// frmDiscount
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(1303, 514);
			this.Controls.Add(this.button_Close);
			this.Controls.Add(this.button_Clear);
			this.Controls.Add(this.total_lbl);
			this.Controls.Add(this.txt_discountTotal);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnExit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmDiscount";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Discount";
			((System.ComponentModel.ISupportInitialize)(this.dataGridSelectItems)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPercentLineItem;
        private System.Windows.Forms.Label lblPercentLineItem;
        private System.Windows.Forms.Label lblPercentTotalSale;
        private System.Windows.Forms.TextBox txtPercentTotalSale;
        private System.Windows.Forms.Label lblFixedDiscount;
        private System.Windows.Forms.DataGridView dataGridSelectItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_discountTotal;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegularPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private CurrencyBox txtFixedDiscount;
		private System.Windows.Forms.Button button_Coupon;
		private System.Windows.Forms.Button btn_ApplyDiscount;
		private System.Windows.Forms.Button button_Clear;
		private System.Windows.Forms.Button button_ApplyToItem;
		private System.Windows.Forms.Button button_Close;
	}
}