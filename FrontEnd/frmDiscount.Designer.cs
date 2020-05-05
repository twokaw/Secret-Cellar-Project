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
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnApplyToItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSelectItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(462, 458);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(254, 123);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.btnClear.Location = new System.Drawing.Point(94, 458);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(254, 123);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnApplyDiscount
            // 
            this.btnApplyDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.btnApplyDiscount.Location = new System.Drawing.Point(830, 458);
            this.btnApplyDiscount.Name = "btnApplyDiscount";
            this.btnApplyDiscount.Size = new System.Drawing.Size(254, 123);
            this.btnApplyDiscount.TabIndex = 6;
            this.btnApplyDiscount.Text = "Apply Discount";
            this.btnApplyDiscount.UseVisualStyleBackColor = true;
            this.btnApplyDiscount.Click += new System.EventHandler(this.btnApplyDiscount_Click);
            // 
            // txtPercentLineItem
            // 
            this.txtPercentLineItem.Location = new System.Drawing.Point(45, 62);
            this.txtPercentLineItem.Name = "txtPercentLineItem";
            this.txtPercentLineItem.Size = new System.Drawing.Size(200, 20);
            this.txtPercentLineItem.TabIndex = 8;
            this.txtPercentLineItem.TextChanged += new System.EventHandler(this.txtPercentLineItem_TextChanged);
            // 
            // lblPercentLineItem
            // 
            this.lblPercentLineItem.AutoSize = true;
            this.lblPercentLineItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblPercentLineItem.Location = new System.Drawing.Point(39, 28);
            this.lblPercentLineItem.Name = "lblPercentLineItem";
            this.lblPercentLineItem.Size = new System.Drawing.Size(235, 31);
            this.lblPercentLineItem.TabIndex = 10;
            this.lblPercentLineItem.Text = "Enter Discount(%)";
            this.lblPercentLineItem.Click += new System.EventHandler(this.lblPercentLineItem_Click);
            // 
            // lblPercentTotalSale
            // 
            this.lblPercentTotalSale.AutoSize = true;
            this.lblPercentTotalSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblPercentTotalSale.Location = new System.Drawing.Point(112, 46);
            this.lblPercentTotalSale.Name = "lblPercentTotalSale";
            this.lblPercentTotalSale.Size = new System.Drawing.Size(231, 31);
            this.lblPercentTotalSale.TabIndex = 12;
            this.lblPercentTotalSale.Text = "Total Discount(%)";
            this.lblPercentTotalSale.Click += new System.EventHandler(this.lblPercentTotalSale_Click);
            // 
            // txtPercentTotalSale
            // 
            this.txtPercentTotalSale.Location = new System.Drawing.Point(118, 80);
            this.txtPercentTotalSale.Name = "txtPercentTotalSale";
            this.txtPercentTotalSale.Size = new System.Drawing.Size(200, 20);
            this.txtPercentTotalSale.TabIndex = 13;
            this.txtPercentTotalSale.TextChanged += new System.EventHandler(this.txtPercentTotalSale_TextChanged);
            // 
            // lblFixedDiscount
            // 
            this.lblFixedDiscount.AutoSize = true;
            this.lblFixedDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblFixedDiscount.Location = new System.Drawing.Point(116, 46);
            this.lblFixedDiscount.Name = "lblFixedDiscount";
            this.lblFixedDiscount.Size = new System.Drawing.Size(222, 31);
            this.lblFixedDiscount.TabIndex = 14;
            this.lblFixedDiscount.Text = "Total Discount($)";
            this.lblFixedDiscount.Click += new System.EventHandler(this.lblFixedDiscount_Click);
            // 
            // txtFixedDiscount
            // 
            this.txtFixedDiscount.Location = new System.Drawing.Point(122, 80);
            this.txtFixedDiscount.Name = "txtFixedDiscount";
            this.txtFixedDiscount.Size = new System.Drawing.Size(193, 20);
            this.txtFixedDiscount.TabIndex = 15;
            this.txtFixedDiscount.Text = "b";
            this.txtFixedDiscount.TextChanged += new System.EventHandler(this.txtFixedDiscount_TextChanged);
            // 
            // dataGridSelectItems
            // 
            this.dataGridSelectItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSelectItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNumber,
            this.ItemDescription,
            this.Price});
            this.dataGridSelectItems.Location = new System.Drawing.Point(19, 120);
            this.dataGridSelectItems.Name = "dataGridSelectItems";
            this.dataGridSelectItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSelectItems.Size = new System.Drawing.Size(624, 175);
            this.dataGridSelectItems.TabIndex = 16;
            this.dataGridSelectItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSelectItems_CellContentClick);
            // 
            // ItemNumber
            // 
            this.ItemNumber.HeaderText = "Item Number";
            this.ItemNumber.Name = "ItemNumber";
            this.ItemNumber.Width = 200;
            // 
            // ItemDescription
            // 
            this.ItemDescription.HeaderText = "Item Desc.";
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.Width = 300;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.lblFixedDiscount);
            this.panel1.Controls.Add(this.txtFixedDiscount);
            this.panel1.Location = new System.Drawing.Point(36, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 146);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.lblPercentTotalSale);
            this.panel2.Controls.Add(this.txtPercentTotalSale);
            this.panel2.Location = new System.Drawing.Point(36, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 146);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Controls.Add(this.btnApplyToItem);
            this.panel3.Controls.Add(this.dataGridSelectItems);
            this.panel3.Controls.Add(this.lblPercentLineItem);
            this.panel3.Controls.Add(this.txtPercentLineItem);
            this.panel3.Location = new System.Drawing.Point(512, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(655, 307);
            this.panel3.TabIndex = 19;
            // 
            // btnApplyToItem
            // 
            this.btnApplyToItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnApplyToItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnApplyToItem.Location = new System.Drawing.Point(402, 28);
            this.btnApplyToItem.Name = "btnApplyToItem";
            this.btnApplyToItem.Size = new System.Drawing.Size(214, 72);
            this.btnApplyToItem.TabIndex = 17;
            this.btnApplyToItem.Text = "Apply to Item(s)";
            this.btnApplyToItem.UseVisualStyleBackColor = false;
            this.btnApplyToItem.Click += new System.EventHandler(this.btnApplyToItem_Click);
            // 
            // frmDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 603);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnApplyDiscount);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Name = "frmDiscount";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnApplyToItem;
    }
}