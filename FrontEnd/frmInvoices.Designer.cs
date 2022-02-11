
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
			this.dataGridView_Invoices = new System.Windows.Forms.DataGridView();
			this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DISCOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BOTTLE_DEPOSIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.selectionList_Invoices = new System.Windows.Forms.ListBox();
			this.button_CloseWindow = new System.Windows.Forms.Button();
			this.button_Finalize = new System.Windows.Forms.Button();
			this.textBox_Filter = new System.Windows.Forms.TextBox();
			this.button_ = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Invoices)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView_Invoices
			// 
			this.dataGridView_Invoices.AllowUserToAddRows = false;
			this.dataGridView_Invoices.AllowUserToDeleteRows = false;
			this.dataGridView_Invoices.AllowUserToResizeColumns = false;
			this.dataGridView_Invoices.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Ivory;
			this.dataGridView_Invoices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView_Invoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView_Invoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView_Invoices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView_Invoices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(196)))));
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView_Invoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_Invoices.ColumnHeadersHeight = 48;
			this.dataGridView_Invoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DESCRIPTION,
            this.QTY,
            this.PRICE,
            this.DISCOUNT,
            this.BOTTLE_DEPOSIT,
            this.TOTAL});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Ivory;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView_Invoices.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView_Invoices.Location = new System.Drawing.Point(225, 10);
			this.dataGridView_Invoices.Margin = new System.Windows.Forms.Padding(1);
			this.dataGridView_Invoices.Name = "dataGridView_Invoices";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Ivory;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView_Invoices.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView_Invoices.RowHeadersVisible = false;
			this.dataGridView_Invoices.RowHeadersWidth = 102;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Ivory;
			this.dataGridView_Invoices.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridView_Invoices.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridView_Invoices.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridView_Invoices.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
			this.dataGridView_Invoices.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Ivory;
			this.dataGridView_Invoices.RowTemplate.Height = 40;
			this.dataGridView_Invoices.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dataGridView_Invoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_Invoices.Size = new System.Drawing.Size(726, 441);
			this.dataGridView_Invoices.TabIndex = 6;
			this.dataGridView_Invoices.TabStop = false;
			// 
			// DESCRIPTION
			// 
			this.DESCRIPTION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DESCRIPTION.DataPropertyName = "description";
			this.DESCRIPTION.FillWeight = 205.876F;
			this.DESCRIPTION.HeaderText = "DESCRIPTION";
			this.DESCRIPTION.MinimumWidth = 12;
			this.DESCRIPTION.Name = "DESCRIPTION";
			// 
			// QTY
			// 
			this.QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.QTY.DataPropertyName = "qty";
			this.QTY.FillWeight = 154.4118F;
			this.QTY.HeaderText = "QTY";
			this.QTY.MinimumWidth = 12;
			this.QTY.Name = "QTY";
			this.QTY.Width = 75;
			// 
			// PRICE
			// 
			this.PRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.PRICE.DataPropertyName = "price";
			this.PRICE.FillWeight = 18.80306F;
			this.PRICE.HeaderText = "PRICE";
			this.PRICE.MinimumWidth = 12;
			this.PRICE.Name = "PRICE";
			// 
			// DISCOUNT
			// 
			this.DISCOUNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.DISCOUNT.DataPropertyName = "discount";
			this.DISCOUNT.FillWeight = 37.25315F;
			this.DISCOUNT.HeaderText = "DISCOUNT";
			this.DISCOUNT.MinimumWidth = 25;
			this.DISCOUNT.Name = "DISCOUNT";
			// 
			// BOTTLE_DEPOSIT
			// 
			this.BOTTLE_DEPOSIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.BOTTLE_DEPOSIT.DataPropertyName = "bottleDeposit";
			this.BOTTLE_DEPOSIT.FillWeight = 88.47124F;
			this.BOTTLE_DEPOSIT.HeaderText = "BOTTLE DEPOSIT";
			this.BOTTLE_DEPOSIT.MinimumWidth = 12;
			this.BOTTLE_DEPOSIT.Name = "BOTTLE_DEPOSIT";
			this.BOTTLE_DEPOSIT.Width = 160;
			// 
			// TOTAL
			// 
			this.TOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.TOTAL.DataPropertyName = "total";
			this.TOTAL.FillWeight = 138.0905F;
			this.TOTAL.HeaderText = "TOTAL";
			this.TOTAL.MinimumWidth = 12;
			this.TOTAL.Name = "TOTAL";
			// 
			// selectionList_Invoices
			// 
			this.selectionList_Invoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.selectionList_Invoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectionList_Invoices.FormattingEnabled = true;
			this.selectionList_Invoices.ItemHeight = 18;
			this.selectionList_Invoices.Location = new System.Drawing.Point(12, 47);
			this.selectionList_Invoices.Name = "selectionList_Invoices";
			this.selectionList_Invoices.Size = new System.Drawing.Size(198, 202);
			this.selectionList_Invoices.TabIndex = 2;
			// 
			// button_CloseWindow
			// 
			this.button_CloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_CloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_CloseWindow.Location = new System.Drawing.Point(12, 396);
			this.button_CloseWindow.Name = "button_CloseWindow";
			this.button_CloseWindow.Size = new System.Drawing.Size(198, 55);
			this.button_CloseWindow.TabIndex = 5;
			this.button_CloseWindow.Text = "Close";
			this.button_CloseWindow.UseVisualStyleBackColor = true;
			this.button_CloseWindow.Click += new System.EventHandler(this.btn_CloseWindow_Click);
			// 
			// button_Finalize
			// 
			this.button_Finalize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_Finalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Finalize.Location = new System.Drawing.Point(12, 268);
			this.button_Finalize.Name = "button_Finalize";
			this.button_Finalize.Size = new System.Drawing.Size(198, 55);
			this.button_Finalize.TabIndex = 3;
			this.button_Finalize.Text = "Finalize";
			this.button_Finalize.UseVisualStyleBackColor = true;
			// 
			// textBox_Filter
			// 
			this.textBox_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Filter.Location = new System.Drawing.Point(12, 12);
			this.textBox_Filter.Name = "textBox_Filter";
			this.textBox_Filter.Size = new System.Drawing.Size(198, 29);
			this.textBox_Filter.TabIndex = 1;
			this.textBox_Filter.Text = "Filter...";
			// 
			// button_
			// 
			this.button_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_.Location = new System.Drawing.Point(12, 329);
			this.button_.Name = "button_";
			this.button_.Size = new System.Drawing.Size(198, 55);
			this.button_.TabIndex = 4;
			this.button_.Text = "View/Print";
			this.button_.UseVisualStyleBackColor = true;
			// 
			// frmInvoices
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(206)))));
			this.ClientSize = new System.Drawing.Size(961, 461);
			this.Controls.Add(this.button_);
			this.Controls.Add(this.textBox_Filter);
			this.Controls.Add(this.button_Finalize);
			this.Controls.Add(this.button_CloseWindow);
			this.Controls.Add(this.selectionList_Invoices);
			this.Controls.Add(this.dataGridView_Invoices);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmInvoices";
			this.Text = "Invoices";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Invoices)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView_Invoices;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
		private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
		private System.Windows.Forms.DataGridViewTextBoxColumn DISCOUNT;
		private System.Windows.Forms.DataGridViewTextBoxColumn BOTTLE_DEPOSIT;
		private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
		private System.Windows.Forms.ListBox selectionList_Invoices;
		private System.Windows.Forms.Button button_CloseWindow;
		private System.Windows.Forms.Button button_Finalize;
		private System.Windows.Forms.TextBox textBox_Filter;
		private System.Windows.Forms.Button button_;
	}
}