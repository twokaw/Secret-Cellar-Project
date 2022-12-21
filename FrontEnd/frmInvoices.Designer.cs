
namespace SecretCellar {
	partial class frmInvoices {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoices));
            this.dataGridView_InvoiceData = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectionList_Invoices = new System.Windows.Forms.ListBox();
            this.button_CloseWindow = new System.Windows.Forms.Button();
            this.button_UpdatePayment = new System.Windows.Forms.Button();
            this.textBox_Filter = new System.Windows.Forms.TextBox();
            this.button_Print = new System.Windows.Forms.Button();
            this.label_Total = new System.Windows.Forms.Label();
            this.label_MoneyDown = new System.Windows.Forms.Label();
            this.checkBox_ClosedInvoices = new System.Windows.Forms.CheckBox();
            this.currencyBox_MoneyDown = new SecretCellar.CurrencyBox();
            this.currencyBox_Total = new SecretCellar.CurrencyBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_InvoiceData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_InvoiceData
            // 
            this.dataGridView_InvoiceData.AllowUserToAddRows = false;
            this.dataGridView_InvoiceData.AllowUserToDeleteRows = false;
            this.dataGridView_InvoiceData.AllowUserToResizeColumns = false;
            this.dataGridView_InvoiceData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Ivory;
            this.dataGridView_InvoiceData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_InvoiceData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_InvoiceData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_InvoiceData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_InvoiceData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_InvoiceData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_InvoiceData.ColumnHeadersHeight = 48;
            this.dataGridView_InvoiceData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.Price,
            this.Quantity});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_InvoiceData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_InvoiceData.Location = new System.Drawing.Point(286, 15);
            this.dataGridView_InvoiceData.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_InvoiceData.Name = "dataGridView_InvoiceData";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_InvoiceData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_InvoiceData.RowHeadersVisible = false;
            this.dataGridView_InvoiceData.RowHeadersWidth = 102;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Ivory;
            this.dataGridView_InvoiceData.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_InvoiceData.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_InvoiceData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_InvoiceData.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.dataGridView_InvoiceData.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Ivory;
            this.dataGridView_InvoiceData.RowTemplate.Height = 40;
            this.dataGridView_InvoiceData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView_InvoiceData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_InvoiceData.Size = new System.Drawing.Size(849, 317);
            this.dataGridView_InvoiceData.TabIndex = 4;
            this.dataGridView_InvoiceData.TabStop = false;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Name";
            this.ItemName.MinimumWidth = 8;
            this.ItemName.Name = "ItemName";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            // 
            // selectionList_Invoices
            // 
            this.selectionList_Invoices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.selectionList_Invoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionList_Invoices.FormattingEnabled = true;
            this.selectionList_Invoices.ItemHeight = 18;
            this.selectionList_Invoices.Location = new System.Drawing.Point(20, 110);
            this.selectionList_Invoices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectionList_Invoices.Name = "selectionList_Invoices";
            this.selectionList_Invoices.Size = new System.Drawing.Size(234, 220);
            this.selectionList_Invoices.TabIndex = 0;
            this.selectionList_Invoices.SelectedIndexChanged += new System.EventHandler(this.selectionList_Invoices_SelectedIndexChanged);
            // 
            // button_CloseWindow
            // 
            this.button_CloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_CloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CloseWindow.Location = new System.Drawing.Point(20, 396);
            this.button_CloseWindow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_CloseWindow.Name = "button_CloseWindow";
            this.button_CloseWindow.Size = new System.Drawing.Size(152, 49);
            this.button_CloseWindow.TabIndex = 3;
            this.button_CloseWindow.Text = "Close";
            this.button_CloseWindow.UseVisualStyleBackColor = true;
            this.button_CloseWindow.Click += new System.EventHandler(this.btn_CloseWindow_Click);
            // 
            // button_UpdatePayment
            // 
            this.button_UpdatePayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_UpdatePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_UpdatePayment.Location = new System.Drawing.Point(533, 396);
            this.button_UpdatePayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_UpdatePayment.Name = "button_UpdatePayment";
            this.button_UpdatePayment.Size = new System.Drawing.Size(272, 49);
            this.button_UpdatePayment.TabIndex = 1;
            this.button_UpdatePayment.Text = "Update Payment";
            this.button_UpdatePayment.UseVisualStyleBackColor = true;
            this.button_UpdatePayment.Click += new System.EventHandler(this.button_UpdatePayment_Click);
            // 
            // textBox_Filter
            // 
            this.textBox_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Filter.Location = new System.Drawing.Point(20, 68);
            this.textBox_Filter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Filter.Name = "textBox_Filter";
            this.textBox_Filter.Size = new System.Drawing.Size(234, 29);
            this.textBox_Filter.TabIndex = 5;
            this.textBox_Filter.Text = "Filter...";
            this.textBox_Filter.TextChanged += new System.EventHandler(this.textBox_Filter_TextChanged);
            this.textBox_Filter.Enter += new System.EventHandler(this.textBox_Filter_Enter);
            this.textBox_Filter.Leave += new System.EventHandler(this.textBox_Filter_Leave);
            // 
            // button_Print
            // 
            this.button_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Print.Location = new System.Drawing.Point(286, 396);
            this.button_Print.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(205, 49);
            this.button_Print.TabIndex = 2;
            this.button_Print.Text = "View/Print";
            this.button_Print.UseVisualStyleBackColor = true;
            this.button_Print.Click += new System.EventHandler(this.button_Print_Click);
            // 
            // label_Total
            // 
            this.label_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Total.AutoSize = true;
            this.label_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Total.Location = new System.Drawing.Point(1010, 365);
            this.label_Total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(64, 26);
            this.label_Total.TabIndex = 9;
            this.label_Total.Text = "Total";
            // 
            // label_MoneyDown
            // 
            this.label_MoneyDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_MoneyDown.AutoSize = true;
            this.label_MoneyDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MoneyDown.Location = new System.Drawing.Point(833, 365);
            this.label_MoneyDown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MoneyDown.Name = "label_MoneyDown";
            this.label_MoneyDown.Size = new System.Drawing.Size(149, 26);
            this.label_MoneyDown.TabIndex = 11;
            this.label_MoneyDown.Text = "Money Down";
            // 
            // checkBox_ClosedInvoices
            // 
            this.checkBox_ClosedInvoices.AutoSize = true;
            this.checkBox_ClosedInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_ClosedInvoices.Location = new System.Drawing.Point(20, 30);
            this.checkBox_ClosedInvoices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_ClosedInvoices.Name = "checkBox_ClosedInvoices";
            this.checkBox_ClosedInvoices.Size = new System.Drawing.Size(177, 28);
            this.checkBox_ClosedInvoices.TabIndex = 12;
            this.checkBox_ClosedInvoices.Text = "Closed Invoices";
            this.checkBox_ClosedInvoices.UseVisualStyleBackColor = true;
            this.checkBox_ClosedInvoices.CheckedChanged += new System.EventHandler(this.checkBox_ClosedInvoices_CheckedChanged);
            // 
            // currencyBox_MoneyDown
            // 
            this.currencyBox_MoneyDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.currencyBox_MoneyDown.Enabled = false;
            this.currencyBox_MoneyDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyBox_MoneyDown.ForeColor = System.Drawing.Color.Black;
            this.currencyBox_MoneyDown.Location = new System.Drawing.Point(838, 396);
            this.currencyBox_MoneyDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currencyBox_MoneyDown.Name = "currencyBox_MoneyDown";
            this.currencyBox_MoneyDown.Size = new System.Drawing.Size(120, 29);
            this.currencyBox_MoneyDown.TabIndex = 10;
            this.currencyBox_MoneyDown.Text = "$0.00";
            this.currencyBox_MoneyDown.Value = 0D;
            // 
            // currencyBox_Total
            // 
            this.currencyBox_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.currencyBox_Total.Enabled = false;
            this.currencyBox_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyBox_Total.ForeColor = System.Drawing.Color.Black;
            this.currencyBox_Total.Location = new System.Drawing.Point(1015, 396);
            this.currencyBox_Total.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currencyBox_Total.Name = "currencyBox_Total";
            this.currencyBox_Total.Size = new System.Drawing.Size(120, 29);
            this.currencyBox_Total.TabIndex = 8;
            this.currencyBox_Total.Text = "$0.00";
            this.currencyBox_Total.Value = 0D;
            // 
            // frmInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1150, 460);
            this.Controls.Add(this.checkBox_ClosedInvoices);
            this.Controls.Add(this.label_MoneyDown);
            this.Controls.Add(this.currencyBox_MoneyDown);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.currencyBox_Total);
            this.Controls.Add(this.button_Print);
            this.Controls.Add(this.textBox_Filter);
            this.Controls.Add(this.button_UpdatePayment);
            this.Controls.Add(this.button_CloseWindow);
            this.Controls.Add(this.selectionList_Invoices);
            this.Controls.Add(this.dataGridView_InvoiceData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInvoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoices";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_InvoiceData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView_InvoiceData;
		private System.Windows.Forms.ListBox selectionList_Invoices;
		private System.Windows.Forms.Button button_CloseWindow;
		private System.Windows.Forms.Button button_UpdatePayment;
		private System.Windows.Forms.TextBox textBox_Filter;
		private System.Windows.Forms.Button button_Print;
        private CurrencyBox currencyBox_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Label label_Total;
        private CurrencyBox currencyBox_MoneyDown;
        private System.Windows.Forms.Label label_MoneyDown;
        private System.Windows.Forms.CheckBox checkBox_ClosedInvoices;
    }
}