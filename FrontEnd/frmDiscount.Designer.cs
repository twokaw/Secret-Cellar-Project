namespace SecretCellar
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnApplyDiscount = new System.Windows.Forms.Button();
            this.txtPercentLineItem = new System.Windows.Forms.TextBox();
            this.lblPercentLineItem = new System.Windows.Forms.Label();
            this.lblPercentTotalSale = new System.Windows.Forms.Label();
            this.txtPercentTotalSale = new System.Windows.Forms.TextBox();
            this.lblFixedDiscount = new System.Windows.Forms.Label();
            this.txtFixedDiscount = new System.Windows.Forms.TextBox();
            this.dataGridSelectItems = new System.Windows.Forms.DataGridView();
            this.ItemNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegularPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.coupon_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnApplyToItem = new System.Windows.Forms.Button();
            this.txt_discountTotal = new System.Windows.Forms.TextBox();
            this.total_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelectItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(688, 566);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(297, 101);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.btnClear.Location = new System.Drawing.Point(1356, 15);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(255, 101);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Reset";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnApplyDiscount
            // 
            this.btnApplyDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.btnApplyDiscount.Location = new System.Drawing.Point(450, 53);
            this.btnApplyDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.btnApplyDiscount.Name = "btnApplyDiscount";
            this.btnApplyDiscount.Size = new System.Drawing.Size(202, 101);
            this.btnApplyDiscount.TabIndex = 5;
            this.btnApplyDiscount.Text = "Apply ";
            this.btnApplyDiscount.UseVisualStyleBackColor = true;
            this.btnApplyDiscount.Click += new System.EventHandler(this.btnApplyDiscount_Click);
            // 
            // txtPercentLineItem
            // 
            this.txtPercentLineItem.Location = new System.Drawing.Point(68, 76);
            this.txtPercentLineItem.Margin = new System.Windows.Forms.Padding(4);
            this.txtPercentLineItem.Name = "txtPercentLineItem";
            this.txtPercentLineItem.Size = new System.Drawing.Size(298, 22);
            this.txtPercentLineItem.TabIndex = 0;
            this.txtPercentLineItem.TextChanged += new System.EventHandler(this.txtPercentLineItem_TextChanged);
            this.txtPercentLineItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_only);
            // 
            // lblPercentLineItem
            // 
            this.lblPercentLineItem.AutoSize = true;
            this.lblPercentLineItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblPercentLineItem.Location = new System.Drawing.Point(58, 34);
            this.lblPercentLineItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPercentLineItem.Name = "lblPercentLineItem";
            this.lblPercentLineItem.Size = new System.Drawing.Size(235, 31);
            this.lblPercentLineItem.TabIndex = 10;
            this.lblPercentLineItem.Text = "Enter Discount(%)";
            // 
            // lblPercentTotalSale
            // 
            this.lblPercentTotalSale.AutoSize = true;
            this.lblPercentTotalSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblPercentTotalSale.Location = new System.Drawing.Point(42, 53);
            this.lblPercentTotalSale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPercentTotalSale.Name = "lblPercentTotalSale";
            this.lblPercentTotalSale.Size = new System.Drawing.Size(231, 31);
            this.lblPercentTotalSale.TabIndex = 12;
            this.lblPercentTotalSale.Text = "Total Discount(%)";
            this.lblPercentTotalSale.Click += new System.EventHandler(this.lblPercentTotalSale_Click);
            // 
            // txtPercentTotalSale
            // 
            this.txtPercentTotalSale.Location = new System.Drawing.Point(51, 95);
            this.txtPercentTotalSale.Margin = new System.Windows.Forms.Padding(4);
            this.txtPercentTotalSale.Name = "txtPercentTotalSale";
            this.txtPercentTotalSale.Size = new System.Drawing.Size(298, 22);
            this.txtPercentTotalSale.TabIndex = 4;
            this.txtPercentTotalSale.Click += new System.EventHandler(this.txtPercentTotalSale_Click);
            this.txtPercentTotalSale.TextChanged += new System.EventHandler(this.txtPercentTotalSale_TextChanged);
            this.txtPercentTotalSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digit_only);
            // 
            // lblFixedDiscount
            // 
            this.lblFixedDiscount.AutoSize = true;
            this.lblFixedDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblFixedDiscount.Location = new System.Drawing.Point(69, 60);
            this.lblFixedDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFixedDiscount.Name = "lblFixedDiscount";
            this.lblFixedDiscount.Size = new System.Drawing.Size(222, 31);
            this.lblFixedDiscount.TabIndex = 14;
            this.lblFixedDiscount.Text = "Total Discount($)";
            this.lblFixedDiscount.Click += new System.EventHandler(this.lblFixedDiscount_Click);
            // 
            // txtFixedDiscount
            // 
            this.txtFixedDiscount.Location = new System.Drawing.Point(78, 102);
            this.txtFixedDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtFixedDiscount.Name = "txtFixedDiscount";
            this.txtFixedDiscount.Size = new System.Drawing.Size(288, 22);
            this.txtFixedDiscount.TabIndex = 2;
            this.txtFixedDiscount.TextChanged += new System.EventHandler(this.txtFixedDiscount_TextChanged);
            this.txtFixedDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFixedDiscount_KeyPress);
            // 
            // dataGridSelectItems
            // 
            this.dataGridSelectItems.AllowUserToAddRows = false;
            this.dataGridSelectItems.AllowUserToDeleteRows = false;
            this.dataGridSelectItems.AllowUserToResizeColumns = false;
            this.dataGridSelectItems.AllowUserToResizeRows = false;
            this.dataGridSelectItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSelectItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNumber,
            this.ItemDescription,
            this.RegularPrice,
            this.Price,
            this.Discount});
            this.dataGridSelectItems.Location = new System.Drawing.Point(28, 148);
            this.dataGridSelectItems.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridSelectItems.Name = "dataGridSelectItems";
            this.dataGridSelectItems.RowHeadersVisible = false;
            this.dataGridSelectItems.RowHeadersWidth = 62;
            this.dataGridSelectItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSelectItems.Size = new System.Drawing.Size(936, 215);
            this.dataGridSelectItems.TabIndex = 16;
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
            this.RegularPrice.Name = "RegularPrice";
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
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.coupon_btn);
            this.panel1.Controls.Add(this.lblFixedDiscount);
            this.panel1.Controls.Add(this.txtFixedDiscount);
            this.panel1.Location = new System.Drawing.Point(54, 154);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 157);
            this.panel1.TabIndex = 17;
            // 
            // coupon_btn
            // 
            this.coupon_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.coupon_btn.Location = new System.Drawing.Point(450, 52);
            this.coupon_btn.Margin = new System.Windows.Forms.Padding(4);
            this.coupon_btn.Name = "coupon_btn";
            this.coupon_btn.Size = new System.Drawing.Size(202, 101);
            this.coupon_btn.TabIndex = 3;
            this.coupon_btn.Text = "Apply Coupon ";
            this.coupon_btn.UseVisualStyleBackColor = true;
            this.coupon_btn.Click += new System.EventHandler(this.coupon_btn_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.lblPercentTotalSale);
            this.panel2.Controls.Add(this.txtPercentTotalSale);
            this.panel2.Controls.Add(this.btnApplyDiscount);
            this.panel2.Location = new System.Drawing.Point(54, 352);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(656, 158);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Controls.Add(this.btnApplyToItem);
            this.panel3.Controls.Add(this.dataGridSelectItems);
            this.panel3.Controls.Add(this.lblPercentLineItem);
            this.panel3.Controls.Add(this.txtPercentLineItem);
            this.panel3.Location = new System.Drawing.Point(768, 154);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(968, 367);
            this.panel3.TabIndex = 19;
            // 
            // btnApplyToItem
            // 
            this.btnApplyToItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnApplyToItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnApplyToItem.Location = new System.Drawing.Point(603, 34);
            this.btnApplyToItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnApplyToItem.Name = "btnApplyToItem";
            this.btnApplyToItem.Size = new System.Drawing.Size(321, 89);
            this.btnApplyToItem.TabIndex = 1;
            this.btnApplyToItem.Text = "Apply to Item(s)";
            this.btnApplyToItem.UseVisualStyleBackColor = false;
            this.btnApplyToItem.Click += new System.EventHandler(this.btnApplyToItem_Click);
            // 
            // txt_discountTotal
            // 
            this.txt_discountTotal.Location = new System.Drawing.Point(1452, 566);
            this.txt_discountTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txt_discountTotal.Name = "txt_discountTotal";
            this.txt_discountTotal.Size = new System.Drawing.Size(238, 22);
            this.txt_discountTotal.TabIndex = 20;
            this.txt_discountTotal.TabStop = false;
            this.txt_discountTotal.TextChanged += new System.EventHandler(this.txt_discountTotal_TextChanged);
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_lbl.Location = new System.Drawing.Point(1233, 566);
            this.total_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(140, 20);
            this.total_lbl.TabIndex = 21;
            this.total_lbl.Text = "Total Discount $";
            // 
            // frmDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1768, 742);
            this.Controls.Add(this.total_lbl);
            this.Controls.Add(this.txt_discountTotal);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Discount";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnApplyDiscount;
        private System.Windows.Forms.TextBox txtPercentLineItem;
        private System.Windows.Forms.Label lblPercentLineItem;
        private System.Windows.Forms.Label lblPercentTotalSale;
        private System.Windows.Forms.TextBox txtPercentTotalSale;
        private System.Windows.Forms.Label lblFixedDiscount;
        private System.Windows.Forms.TextBox txtFixedDiscount;
        private System.Windows.Forms.DataGridView dataGridSelectItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnApplyToItem;
        private System.Windows.Forms.TextBox txt_discountTotal;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.Button coupon_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegularPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
    }
}