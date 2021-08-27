
namespace SecretCellar.Orders_Panels {
	partial class Panel_History {
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.textBox_CustomerName = new System.Windows.Forms.TextBox();
			this.btn_setDate = new System.Windows.Forms.Button();
			this.btn_setCust = new System.Windows.Forms.Button();
			this.lbl_orders = new System.Windows.Forms.Label();
			this.btn_reset = new System.Windows.Forms.Button();
			this.btn_print = new System.Windows.Forms.Button();
			this.lstbox_customer = new System.Windows.Forms.ListBox();
			this.transaction_dataGrid = new System.Windows.Forms.DataGridView();
			this.trans_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.trans_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.trans_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lbl_end = new System.Windows.Forms.Label();
			this.end_dateTime = new System.Windows.Forms.DateTimePicker();
			this.lbl_start = new System.Windows.Forms.Label();
			this.start_dateTime = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.transaction_dataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox_CustomerName
			// 
			this.textBox_CustomerName.Location = new System.Drawing.Point(3, 3);
			this.textBox_CustomerName.Name = "textBox_CustomerName";
			this.textBox_CustomerName.Size = new System.Drawing.Size(268, 20);
			this.textBox_CustomerName.TabIndex = 25;
			this.textBox_CustomerName.Text = "Search for customer";
			this.textBox_CustomerName.TextChanged += new System.EventHandler(this.textBox_CustomerName_TextChanged);
			this.textBox_CustomerName.Enter += new System.EventHandler(this.textBox_CustomerName_Enter);
			this.textBox_CustomerName.Leave += new System.EventHandler(this.textBox_CustomerName_Leave);
			// 
			// btn_setDate
			// 
			this.btn_setDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_setDate.Location = new System.Drawing.Point(654, 3);
			this.btn_setDate.Name = "btn_setDate";
			this.btn_setDate.Size = new System.Drawing.Size(179, 48);
			this.btn_setDate.TabIndex = 24;
			this.btn_setDate.Text = "Set Date Range";
			this.btn_setDate.UseVisualStyleBackColor = true;
			this.btn_setDate.Click += new System.EventHandler(this.btn_setDate_Click);
			// 
			// btn_setCust
			// 
			this.btn_setCust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_setCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_setCust.Location = new System.Drawing.Point(3, 278);
			this.btn_setCust.Name = "btn_setCust";
			this.btn_setCust.Size = new System.Drawing.Size(179, 48);
			this.btn_setCust.TabIndex = 23;
			this.btn_setCust.Text = "Set Customer";
			this.btn_setCust.UseVisualStyleBackColor = true;
			this.btn_setCust.Click += new System.EventHandler(this.btn_setCust_Click);
			// 
			// lbl_orders
			// 
			this.lbl_orders.AutoSize = true;
			this.lbl_orders.Location = new System.Drawing.Point(278, 67);
			this.lbl_orders.Name = "lbl_orders";
			this.lbl_orders.Size = new System.Drawing.Size(62, 13);
			this.lbl_orders.TabIndex = 22;
			this.lbl_orders.Text = "Past Orders";
			// 
			// btn_reset
			// 
			this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_reset.Location = new System.Drawing.Point(281, 278);
			this.btn_reset.Name = "btn_reset";
			this.btn_reset.Size = new System.Drawing.Size(179, 48);
			this.btn_reset.TabIndex = 21;
			this.btn_reset.Text = "Reset";
			this.btn_reset.UseVisualStyleBackColor = true;
			this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
			// 
			// btn_print
			// 
			this.btn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_print.Location = new System.Drawing.Point(654, 278);
			this.btn_print.Name = "btn_print";
			this.btn_print.Size = new System.Drawing.Size(179, 48);
			this.btn_print.TabIndex = 20;
			this.btn_print.Text = "View/Print";
			this.btn_print.UseVisualStyleBackColor = true;
			this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
			// 
			// lstbox_customer
			// 
			this.lstbox_customer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lstbox_customer.FormattingEnabled = true;
			this.lstbox_customer.Location = new System.Drawing.Point(3, 33);
			this.lstbox_customer.Name = "lstbox_customer";
			this.lstbox_customer.Size = new System.Drawing.Size(268, 238);
			this.lstbox_customer.TabIndex = 19;
			// 
			// transaction_dataGrid
			// 
			this.transaction_dataGrid.AllowUserToAddRows = false;
			this.transaction_dataGrid.AllowUserToDeleteRows = false;
			this.transaction_dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.transaction_dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.transaction_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.transaction_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trans_id,
            this.trans_date,
            this.trans_total});
			this.transaction_dataGrid.Location = new System.Drawing.Point(281, 83);
			this.transaction_dataGrid.Name = "transaction_dataGrid";
			this.transaction_dataGrid.ReadOnly = true;
			this.transaction_dataGrid.RowHeadersVisible = false;
			this.transaction_dataGrid.RowHeadersWidth = 62;
			this.transaction_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.transaction_dataGrid.Size = new System.Drawing.Size(552, 189);
			this.transaction_dataGrid.TabIndex = 18;
			this.transaction_dataGrid.SelectionChanged += new System.EventHandler(this.transaction_dataGrid_SelectionChanged);
			// 
			// trans_id
			// 
			this.trans_id.DataPropertyName = "trans_id";
			this.trans_id.HeaderText = "Id";
			this.trans_id.MinimumWidth = 8;
			this.trans_id.Name = "trans_id";
			this.trans_id.ReadOnly = true;
			// 
			// trans_date
			// 
			this.trans_date.DataPropertyName = "trans_date";
			this.trans_date.HeaderText = "Date";
			this.trans_date.MinimumWidth = 8;
			this.trans_date.Name = "trans_date";
			this.trans_date.ReadOnly = true;
			// 
			// trans_total
			// 
			this.trans_total.DataPropertyName = "trans_total";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.trans_total.DefaultCellStyle = dataGridViewCellStyle6;
			this.trans_total.HeaderText = "Total";
			this.trans_total.MinimumWidth = 8;
			this.trans_total.Name = "trans_total";
			this.trans_total.ReadOnly = true;
			// 
			// lbl_end
			// 
			this.lbl_end.AutoSize = true;
			this.lbl_end.Location = new System.Drawing.Point(314, 33);
			this.lbl_end.Name = "lbl_end";
			this.lbl_end.Size = new System.Drawing.Size(26, 13);
			this.lbl_end.TabIndex = 17;
			this.lbl_end.Text = "End";
			// 
			// end_dateTime
			// 
			this.end_dateTime.Location = new System.Drawing.Point(346, 29);
			this.end_dateTime.Name = "end_dateTime";
			this.end_dateTime.Size = new System.Drawing.Size(284, 20);
			this.end_dateTime.TabIndex = 16;
			// 
			// lbl_start
			// 
			this.lbl_start.AutoSize = true;
			this.lbl_start.Location = new System.Drawing.Point(311, 6);
			this.lbl_start.Name = "lbl_start";
			this.lbl_start.Size = new System.Drawing.Size(29, 13);
			this.lbl_start.TabIndex = 15;
			this.lbl_start.Text = "Start";
			// 
			// start_dateTime
			// 
			this.start_dateTime.Location = new System.Drawing.Point(346, 3);
			this.start_dateTime.Name = "start_dateTime";
			this.start_dateTime.Size = new System.Drawing.Size(284, 20);
			this.start_dateTime.TabIndex = 14;
			// 
			// Panel_History
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBox_CustomerName);
			this.Controls.Add(this.btn_setDate);
			this.Controls.Add(this.btn_setCust);
			this.Controls.Add(this.lbl_orders);
			this.Controls.Add(this.btn_reset);
			this.Controls.Add(this.btn_print);
			this.Controls.Add(this.lstbox_customer);
			this.Controls.Add(this.transaction_dataGrid);
			this.Controls.Add(this.lbl_end);
			this.Controls.Add(this.end_dateTime);
			this.Controls.Add(this.lbl_start);
			this.Controls.Add(this.start_dateTime);
			this.Name = "Panel_History";
			this.Size = new System.Drawing.Size(836, 329);
			((System.ComponentModel.ISupportInitialize)(this.transaction_dataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox_CustomerName;
		private System.Windows.Forms.Button btn_setDate;
		private System.Windows.Forms.Button btn_setCust;
		private System.Windows.Forms.Label lbl_orders;
		private System.Windows.Forms.Button btn_reset;
		private System.Windows.Forms.Button btn_print;
		private System.Windows.Forms.ListBox lstbox_customer;
		private System.Windows.Forms.DataGridView transaction_dataGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn trans_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn trans_date;
		private System.Windows.Forms.DataGridViewTextBoxColumn trans_total;
		private System.Windows.Forms.Label lbl_end;
		private System.Windows.Forms.DateTimePicker end_dateTime;
		private System.Windows.Forms.Label lbl_start;
		private System.Windows.Forms.DateTimePicker start_dateTime;
	}
}
