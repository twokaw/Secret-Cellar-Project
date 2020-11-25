namespace SecretCellar
{
	partial class frmSuspendTransaction
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
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DISCOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BOTTLE_DEPOSIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AllowUserToResizeColumns = false;
			this.dataGridView.AllowUserToResizeRows = false;
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DESCRIPTION,
            this.QTY,
            this.PRICE,
            this.DISCOUNT,
            this.TAX,
            this.BOTTLE_DEPOSIT,
            this.TOTAL});
			this.dataGridView.Location = new System.Drawing.Point(10, 10);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(1);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.RowHeadersWidth = 102;
			this.dataGridView.RowTemplate.Height = 40;
			this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(780, 430);
			this.dataGridView.TabIndex = 3;
			this.dataGridView.TabStop = false;
			this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
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
			this.QTY.FillWeight = 154.4118F;
			this.QTY.HeaderText = "QTY";
			this.QTY.MinimumWidth = 12;
			this.QTY.Name = "QTY";
			this.QTY.Width = 57;
			// 
			// PRICE
			// 
			this.PRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.PRICE.FillWeight = 18.80306F;
			this.PRICE.HeaderText = "PRICE";
			this.PRICE.MinimumWidth = 12;
			this.PRICE.Name = "PRICE";
			// 
			// DISCOUNT
			// 
			this.DISCOUNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DISCOUNT.FillWeight = 37.25315F;
			this.DISCOUNT.HeaderText = "DISCOUNT";
			this.DISCOUNT.MinimumWidth = 25;
			this.DISCOUNT.Name = "DISCOUNT";
			// 
			// TAX
			// 
			this.TAX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TAX.FillWeight = 57.0944F;
			this.TAX.HeaderText = "TAX";
			this.TAX.MinimumWidth = 12;
			this.TAX.Name = "TAX";
			// 
			// BOTTLE_DEPOSIT
			// 
			this.BOTTLE_DEPOSIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.BOTTLE_DEPOSIT.FillWeight = 88.47124F;
			this.BOTTLE_DEPOSIT.HeaderText = "BOTTLE DEPOSIT";
			this.BOTTLE_DEPOSIT.MinimumWidth = 12;
			this.BOTTLE_DEPOSIT.Name = "BOTTLE_DEPOSIT";
			// 
			// TOTAL
			// 
			this.TOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TOTAL.FillWeight = 138.0905F;
			this.TOTAL.HeaderText = "TOTAL";
			this.TOTAL.MinimumWidth = 12;
			this.TOTAL.Name = "TOTAL";
			// 
			// mySqlCommand1
			// 
			this.mySqlCommand1.CacheAge = 0;
			this.mySqlCommand1.Connection = null;
			this.mySqlCommand1.EnableCaching = false;
			this.mySqlCommand1.Transaction = null;
			// 
			// frmSuspendTransaction
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView);
			this.Name = "frmSuspendTransaction";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
		private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
		private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
		private System.Windows.Forms.DataGridViewTextBoxColumn DISCOUNT;
		private System.Windows.Forms.DataGridViewTextBoxColumn TAX;
		private System.Windows.Forms.DataGridViewTextBoxColumn BOTTLE_DEPOSIT;
		private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
		private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
	}
}