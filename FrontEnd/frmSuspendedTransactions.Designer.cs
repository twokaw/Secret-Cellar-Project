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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.dataGridViewSuspendedTransaction = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.selectionListSuspendedTransactions = new System.Windows.Forms.ListBox();
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
			this.btnDelete.Location = new System.Drawing.Point(816, 284);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 27);
			this.btnDelete.TabIndex = 8;
			this.btnDelete.Text = "DELETE";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.Location = new System.Drawing.Point(915, 284);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 27);
			this.btnAdd.TabIndex = 9;
			this.btnAdd.Text = "ADD";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewSuspendedTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewSuspendedTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewSuspendedTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
			this.dataGridViewSuspendedTransaction.Location = new System.Drawing.Point(185, 10);
			this.dataGridViewSuspendedTransaction.Margin = new System.Windows.Forms.Padding(1);
			this.dataGridViewSuspendedTransaction.Name = "dataGridViewSuspendedTransaction";
			this.dataGridViewSuspendedTransaction.RowHeadersVisible = false;
			this.dataGridViewSuspendedTransaction.RowHeadersWidth = 102;
			this.dataGridViewSuspendedTransaction.RowTemplate.Height = 40;
			this.dataGridViewSuspendedTransaction.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dataGridViewSuspendedTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewSuspendedTransaction.Size = new System.Drawing.Size(807, 239);
			this.dataGridViewSuspendedTransaction.TabIndex = 10;
			this.dataGridViewSuspendedTransaction.TabStop = false;
			this.dataGridViewSuspendedTransaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSuspendedTransaction_CellContentClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.FillWeight = 205.876F;
			this.dataGridViewTextBoxColumn1.HeaderText = "DESCRIPTION";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 12;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.dataGridViewTextBoxColumn2.FillWeight = 154.4118F;
			this.dataGridViewTextBoxColumn2.HeaderText = "QTY";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 12;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 57;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.dataGridViewTextBoxColumn3.FillWeight = 18.80306F;
			this.dataGridViewTextBoxColumn3.HeaderText = "PRICE";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 12;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Width = 69;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.dataGridViewTextBoxColumn4.FillWeight = 37.25315F;
			this.dataGridViewTextBoxColumn4.HeaderText = "DISCOUNT";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 25;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.Width = 96;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.dataGridViewTextBoxColumn5.FillWeight = 57.0944F;
			this.dataGridViewTextBoxColumn5.HeaderText = "TAX";
			this.dataGridViewTextBoxColumn5.MinimumWidth = 12;
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Width = 56;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.dataGridViewTextBoxColumn6.FillWeight = 88.47124F;
			this.dataGridViewTextBoxColumn6.HeaderText = "BOTTLE DEPOSIT";
			this.dataGridViewTextBoxColumn6.MinimumWidth = 12;
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.Width = 126;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn7.FillWeight = 138.0905F;
			this.dataGridViewTextBoxColumn7.HeaderText = "TOTAL";
			this.dataGridViewTextBoxColumn7.MinimumWidth = 12;
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
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
			// frmSuspendedTransactions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1002, 343);
			this.Controls.Add(this.selectionListSuspendedTransactions);
			this.Controls.Add(this.dataGridViewSuspendedTransaction);
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
		private System.Windows.Forms.DataGridView dataGridViewSuspendedTransaction;
		private System.Windows.Forms.ListBox selectionListSuspendedTransactions;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
	}
}