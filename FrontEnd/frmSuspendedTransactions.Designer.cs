namespace SecretCellar
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.selectionListSuspendedTransactions = new System.Windows.Forms.ListBox();
			this.dataGridViewSuspendedTransaction = new System.Windows.Forms.DataGridView();
			this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DISCOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BOTTLE_DEPOSIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_CloseWindow = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuspendedTransaction)).BeginInit();
			this.SuspendLayout();
			// 
			// mySqlCommand1
			// 
			this.mySqlCommand1.CacheAge = 0;
			this.mySqlCommand1.Connection = null;
			this.mySqlCommand1.EnableCaching = false;
			this.mySqlCommand1.Transaction = null;
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(624, 270);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(180, 55);
			this.btnDelete.TabIndex = 8;
			this.btnDelete.Text = "DELETE TRANSACTION";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(810, 270);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(180, 55);
			this.btnAdd.TabIndex = 9;
			this.btnAdd.Text = "ADD TRANSACTION";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// selectionListSuspendedTransactions
			// 
			this.selectionListSuspendedTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.selectionListSuspendedTransactions.FormattingEnabled = true;
			this.selectionListSuspendedTransactions.Location = new System.Drawing.Point(12, 10);
			this.selectionListSuspendedTransactions.Name = "selectionListSuspendedTransactions";
			this.selectionListSuspendedTransactions.Size = new System.Drawing.Size(154, 238);
			this.selectionListSuspendedTransactions.TabIndex = 11;
			this.selectionListSuspendedTransactions.SelectedIndexChanged += new System.EventHandler(this.selectionListSuspendedTransactions_SelectedIndexChanged);
			// 
			// dataGridViewSuspendedTransaction
			// 
			this.dataGridViewSuspendedTransaction.AllowUserToAddRows = false;
			this.dataGridViewSuspendedTransaction.AllowUserToDeleteRows = false;
			this.dataGridViewSuspendedTransaction.AllowUserToResizeColumns = false;
			this.dataGridViewSuspendedTransaction.AllowUserToResizeRows = false;
			this.dataGridViewSuspendedTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewSuspendedTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridViewSuspendedTransaction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewSuspendedTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewSuspendedTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewSuspendedTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DESCRIPTION,
            this.QTY,
            this.PRICE,
            this.DISCOUNT,
            this.TAX,
            this.BOTTLE_DEPOSIT,
            this.TOTAL});
			this.dataGridViewSuspendedTransaction.Location = new System.Drawing.Point(185, 10);
			this.dataGridViewSuspendedTransaction.Margin = new System.Windows.Forms.Padding(1);
			this.dataGridViewSuspendedTransaction.Name = "dataGridViewSuspendedTransaction";
			this.dataGridViewSuspendedTransaction.RowHeadersVisible = false;
			this.dataGridViewSuspendedTransaction.RowHeadersWidth = 102;
			this.dataGridViewSuspendedTransaction.RowTemplate.Height = 40;
			this.dataGridViewSuspendedTransaction.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dataGridViewSuspendedTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewSuspendedTransaction.Size = new System.Drawing.Size(805, 239);
			this.dataGridViewSuspendedTransaction.TabIndex = 13;
			this.dataGridViewSuspendedTransaction.TabStop = false;
			this.dataGridViewSuspendedTransaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSuspendedTransaction_CellContentClick);
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
			this.QTY.Width = 75;
			// 
			// PRICE
			// 
			this.PRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.PRICE.FillWeight = 18.80306F;
			this.PRICE.HeaderText = "PRICE";
			this.PRICE.MinimumWidth = 12;
			this.PRICE.Name = "PRICE";
			// 
			// DISCOUNT
			// 
			this.DISCOUNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.DISCOUNT.FillWeight = 37.25315F;
			this.DISCOUNT.HeaderText = "DISCOUNT";
			this.DISCOUNT.MinimumWidth = 25;
			this.DISCOUNT.Name = "DISCOUNT";
			// 
			// TAX
			// 
			this.TAX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.TAX.FillWeight = 57.0944F;
			this.TAX.HeaderText = "TAX";
			this.TAX.MinimumWidth = 12;
			this.TAX.Name = "TAX";
			this.TAX.Width = 80;
			// 
			// BOTTLE_DEPOSIT
			// 
			this.BOTTLE_DEPOSIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.BOTTLE_DEPOSIT.FillWeight = 88.47124F;
			this.BOTTLE_DEPOSIT.HeaderText = "BOTTLE DEPOSIT";
			this.BOTTLE_DEPOSIT.MinimumWidth = 12;
			this.BOTTLE_DEPOSIT.Name = "BOTTLE_DEPOSIT";
			this.BOTTLE_DEPOSIT.Width = 160;
			// 
			// TOTAL
			// 
			this.TOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.TOTAL.FillWeight = 138.0905F;
			this.TOTAL.HeaderText = "TOTAL";
			this.TOTAL.MinimumWidth = 12;
			this.TOTAL.Name = "TOTAL";
			// 
			// btn_CloseWindow
			// 
			this.btn_CloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_CloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_CloseWindow.Location = new System.Drawing.Point(12, 270);
			this.btn_CloseWindow.Name = "btn_CloseWindow";
			this.btn_CloseWindow.Size = new System.Drawing.Size(180, 55);
			this.btn_CloseWindow.TabIndex = 14;
			this.btn_CloseWindow.Text = "CLOSE WINDOW";
			this.btn_CloseWindow.UseVisualStyleBackColor = true;
			this.btn_CloseWindow.Click += new System.EventHandler(this.btn_CloseWindow_Click);
			// 
			// frmSuspendedTransactions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1002, 343);
			this.Controls.Add(this.btn_CloseWindow);
			this.Controls.Add(this.dataGridViewSuspendedTransaction);
			this.Controls.Add(this.selectionListSuspendedTransactions);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnDelete);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSuspendedTransactions";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Suspended Transactions";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuspendedTransaction)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ListBox selectionListSuspendedTransactions;
		private System.Windows.Forms.DataGridView dataGridViewSuspendedTransaction;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
		private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
		private System.Windows.Forms.DataGridViewTextBoxColumn DISCOUNT;
		private System.Windows.Forms.DataGridViewTextBoxColumn TAX;
		private System.Windows.Forms.DataGridViewTextBoxColumn BOTTLE_DEPOSIT;
		private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
		private System.Windows.Forms.Button btn_CloseWindow;
	}
}