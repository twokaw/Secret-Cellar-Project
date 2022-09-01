﻿namespace SecretCellar
{
	partial class frmSuspendedTransactions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuspendedTransactions));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.selectionListSuspendedTransactions = new System.Windows.Forms.ListBox();
            this.dataGridViewSuspendedTransaction = new System.Windows.Forms.DataGridView();
            this.btn_CloseWindow = new System.Windows.Forms.Button();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISCOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOTTLE_DEPOSIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuspendedTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(630, 270);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 55);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Transaction";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(816, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 55);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Transaction";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // selectionListSuspendedTransactions
            // 
            this.selectionListSuspendedTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectionListSuspendedTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionListSuspendedTransactions.FormattingEnabled = true;
            this.selectionListSuspendedTransactions.ItemHeight = 18;
            this.selectionListSuspendedTransactions.Location = new System.Drawing.Point(12, 10);
            this.selectionListSuspendedTransactions.Name = "selectionListSuspendedTransactions";
            this.selectionListSuspendedTransactions.Size = new System.Drawing.Size(160, 238);
            this.selectionListSuspendedTransactions.TabIndex = 0;
            this.selectionListSuspendedTransactions.SelectedIndexChanged += new System.EventHandler(this.selectionListSuspendedTransactions_SelectedIndexChanged);
            // 
            // dataGridViewSuspendedTransaction
            // 
            this.dataGridViewSuspendedTransaction.AllowUserToAddRows = false;
            this.dataGridViewSuspendedTransaction.AllowUserToDeleteRows = false;
            this.dataGridViewSuspendedTransaction.AllowUserToResizeColumns = false;
            this.dataGridViewSuspendedTransaction.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Ivory;
            this.dataGridViewSuspendedTransaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSuspendedTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSuspendedTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSuspendedTransaction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSuspendedTransaction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSuspendedTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSuspendedTransaction.ColumnHeadersHeight = 48;
            this.dataGridViewSuspendedTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewSuspendedTransaction.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSuspendedTransaction.Location = new System.Drawing.Point(185, 10);
            this.dataGridViewSuspendedTransaction.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridViewSuspendedTransaction.Name = "dataGridViewSuspendedTransaction";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSuspendedTransaction.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSuspendedTransaction.RowHeadersVisible = false;
            this.dataGridViewSuspendedTransaction.RowHeadersWidth = 102;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Ivory;
            this.dataGridViewSuspendedTransaction.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSuspendedTransaction.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewSuspendedTransaction.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewSuspendedTransaction.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.dataGridViewSuspendedTransaction.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Ivory;
            this.dataGridViewSuspendedTransaction.RowTemplate.Height = 40;
            this.dataGridViewSuspendedTransaction.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewSuspendedTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSuspendedTransaction.Size = new System.Drawing.Size(811, 239);
            this.dataGridViewSuspendedTransaction.TabIndex = 13;
            this.dataGridViewSuspendedTransaction.TabStop = false;
            // 
            // btn_CloseWindow
            // 
            this.btn_CloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CloseWindow.Location = new System.Drawing.Point(18, 270);
            this.btn_CloseWindow.Name = "btn_CloseWindow";
            this.btn_CloseWindow.Size = new System.Drawing.Size(180, 55);
            this.btn_CloseWindow.TabIndex = 1;
            this.btn_CloseWindow.Text = "Close Window";
            this.btn_CloseWindow.UseVisualStyleBackColor = true;
            this.btn_CloseWindow.Click += new System.EventHandler(this.btn_CloseWindow_Click);
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESCRIPTION.DataPropertyName = "description";
            this.DESCRIPTION.FillWeight = 205.876F;
            this.DESCRIPTION.HeaderText = "Description";
            this.DESCRIPTION.MinimumWidth = 12;
            this.DESCRIPTION.Name = "DESCRIPTION";
            // 
            // QTY
            // 
            this.QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.QTY.DataPropertyName = "qty";
            this.QTY.FillWeight = 154.4118F;
            this.QTY.HeaderText = "Qty";
            this.QTY.MinimumWidth = 12;
            this.QTY.Name = "QTY";
            this.QTY.Width = 75;
            // 
            // PRICE
            // 
            this.PRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PRICE.DataPropertyName = "price";
            this.PRICE.FillWeight = 18.80306F;
            this.PRICE.HeaderText = "Price";
            this.PRICE.MinimumWidth = 12;
            this.PRICE.Name = "PRICE";
            // 
            // DISCOUNT
            // 
            this.DISCOUNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DISCOUNT.DataPropertyName = "discount";
            this.DISCOUNT.FillWeight = 37.25315F;
            this.DISCOUNT.HeaderText = "Discount";
            this.DISCOUNT.MinimumWidth = 25;
            this.DISCOUNT.Name = "DISCOUNT";
            // 
            // BOTTLE_DEPOSIT
            // 
            this.BOTTLE_DEPOSIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BOTTLE_DEPOSIT.DataPropertyName = "bottleDeposit";
            this.BOTTLE_DEPOSIT.FillWeight = 88.47124F;
            this.BOTTLE_DEPOSIT.HeaderText = "Bottle Deposit";
            this.BOTTLE_DEPOSIT.MinimumWidth = 12;
            this.BOTTLE_DEPOSIT.Name = "BOTTLE_DEPOSIT";
            this.BOTTLE_DEPOSIT.Width = 160;
            // 
            // TOTAL
            // 
            this.TOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TOTAL.DataPropertyName = "total";
            this.TOTAL.FillWeight = 138.0905F;
            this.TOTAL.HeaderText = "Total";
            this.TOTAL.MinimumWidth = 12;
            this.TOTAL.Name = "TOTAL";
            // 
            // frmSuspendedTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1008, 343);
            this.Controls.Add(this.btn_CloseWindow);
            this.Controls.Add(this.dataGridViewSuspendedTransaction);
            this.Controls.Add(this.selectionListSuspendedTransactions);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSuspendedTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suspended Transactions";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuspendedTransaction)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ListBox selectionListSuspendedTransactions;
		private System.Windows.Forms.DataGridView dataGridViewSuspendedTransaction;
		private System.Windows.Forms.Button btn_CloseWindow;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISCOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOTTLE_DEPOSIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
    }
}