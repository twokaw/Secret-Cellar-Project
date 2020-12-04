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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
			this.listSuspendedTransactions = new System.Windows.Forms.ListBox();
			this.dataGridViewSuspendedTransactions = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuspendedTransactions)).BeginInit();
			this.SuspendLayout();
			// 
			// mySqlCommand1
			// 
			this.mySqlCommand1.CacheAge = 0;
			this.mySqlCommand1.Connection = null;
			this.mySqlCommand1.EnableCaching = false;
			this.mySqlCommand1.Transaction = null;
			// 
			// listSuspendedTransactions
			// 
			this.listSuspendedTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listSuspendedTransactions.FormattingEnabled = true;
			this.listSuspendedTransactions.Location = new System.Drawing.Point(12, 10);
			this.listSuspendedTransactions.Name = "listSuspendedTransactions";
			this.listSuspendedTransactions.Size = new System.Drawing.Size(154, 238);
			this.listSuspendedTransactions.TabIndex = 5;
			this.listSuspendedTransactions.SelectedIndexChanged += new System.EventHandler(this.listSuspendedTransactions_SelectedIndexChanged);
			// 
			// dataGridViewSuspendedTransactions
			// 
			this.dataGridViewSuspendedTransactions.AllowUserToAddRows = false;
			this.dataGridViewSuspendedTransactions.AllowUserToDeleteRows = false;
			this.dataGridViewSuspendedTransactions.AllowUserToResizeColumns = false;
			this.dataGridViewSuspendedTransactions.AllowUserToResizeRows = false;
			this.dataGridViewSuspendedTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewSuspendedTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridViewSuspendedTransactions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewSuspendedTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewSuspendedTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewSuspendedTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
			this.dataGridViewSuspendedTransactions.Location = new System.Drawing.Point(185, 10);
			this.dataGridViewSuspendedTransactions.Margin = new System.Windows.Forms.Padding(1);
			this.dataGridViewSuspendedTransactions.Name = "dataGridViewSuspendedTransactions";
			this.dataGridViewSuspendedTransactions.RowHeadersVisible = false;
			this.dataGridViewSuspendedTransactions.RowHeadersWidth = 102;
			this.dataGridViewSuspendedTransactions.RowTemplate.Height = 40;
			this.dataGridViewSuspendedTransactions.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dataGridViewSuspendedTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewSuspendedTransactions.Size = new System.Drawing.Size(807, 239);
			this.dataGridViewSuspendedTransactions.TabIndex = 7;
			this.dataGridViewSuspendedTransactions.TabStop = false;
			this.dataGridViewSuspendedTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSuspendedTransactions_CellContentClick);
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn8.FillWeight = 205.876F;
			this.dataGridViewTextBoxColumn8.HeaderText = "DESCRIPTION";
			this.dataGridViewTextBoxColumn8.MinimumWidth = 12;
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.FillWeight = 154.4118F;
			this.dataGridViewTextBoxColumn9.HeaderText = "QTY";
			this.dataGridViewTextBoxColumn9.MinimumWidth = 12;
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.Width = 57;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn10.FillWeight = 18.80306F;
			this.dataGridViewTextBoxColumn10.HeaderText = "PRICE";
			this.dataGridViewTextBoxColumn10.MinimumWidth = 12;
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn11.FillWeight = 37.25315F;
			this.dataGridViewTextBoxColumn11.HeaderText = "DISCOUNT";
			this.dataGridViewTextBoxColumn11.MinimumWidth = 25;
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			// 
			// dataGridViewTextBoxColumn12
			// 
			this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn12.FillWeight = 57.0944F;
			this.dataGridViewTextBoxColumn12.HeaderText = "TAX";
			this.dataGridViewTextBoxColumn12.MinimumWidth = 12;
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			// 
			// dataGridViewTextBoxColumn13
			// 
			this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn13.FillWeight = 88.47124F;
			this.dataGridViewTextBoxColumn13.HeaderText = "BOTTLE DEPOSIT";
			this.dataGridViewTextBoxColumn13.MinimumWidth = 12;
			this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
			// 
			// dataGridViewTextBoxColumn14
			// 
			this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn14.FillWeight = 138.0905F;
			this.dataGridViewTextBoxColumn14.HeaderText = "TOTAL";
			this.dataGridViewTextBoxColumn14.MinimumWidth = 12;
			this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.Location = new System.Drawing.Point(197, 284);
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
			this.btnAdd.Location = new System.Drawing.Point(60, 284);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 27);
			this.btnAdd.TabIndex = 9;
			this.btnAdd.Text = "ADD";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// frmSuspendedTransactions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1002, 343);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.dataGridViewSuspendedTransactions);
			this.Controls.Add(this.listSuspendedTransactions);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSuspendedTransactions";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Suspended Transactions";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuspendedTransactions)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
		private System.Windows.Forms.ListBox listSuspendedTransactions;
		private System.Windows.Forms.DataGridView dataGridViewSuspendedTransactions;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAdd;
	}
}