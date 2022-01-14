
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.transaction_dataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_CustomerName
            // 
            this.textBox_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CustomerName.Location = new System.Drawing.Point(26, 20);
            this.textBox_CustomerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_CustomerName.Name = "textBox_CustomerName";
            this.textBox_CustomerName.Size = new System.Drawing.Size(364, 35);
            this.textBox_CustomerName.TabIndex = 25;
            this.textBox_CustomerName.Text = "Search for customer";
            this.textBox_CustomerName.TextChanged += new System.EventHandler(this.textBox_CustomerName_TextChanged);
            this.textBox_CustomerName.Enter += new System.EventHandler(this.textBox_CustomerName_Enter);
            this.textBox_CustomerName.Leave += new System.EventHandler(this.textBox_CustomerName_Leave);
            // 
            // btn_setDate
            // 
            this.btn_setDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_setDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setDate.Location = new System.Drawing.Point(1202, 24);
            this.btn_setDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_setDate.Name = "btn_setDate";
            this.btn_setDate.Size = new System.Drawing.Size(226, 42);
            this.btn_setDate.TabIndex = 24;
            this.btn_setDate.Text = "Set Date Range";
            this.btn_setDate.UseVisualStyleBackColor = true;
            this.btn_setDate.Click += new System.EventHandler(this.btn_setDate_Click);
            // 
            // btn_setCust
            // 
            this.btn_setCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setCust.Location = new System.Drawing.Point(84, 88);
            this.btn_setCust.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_setCust.Name = "btn_setCust";
            this.btn_setCust.Size = new System.Drawing.Size(252, 44);
            this.btn_setCust.TabIndex = 23;
            this.btn_setCust.Text = "Set Customer";
            this.btn_setCust.UseVisualStyleBackColor = true;
            this.btn_setCust.Click += new System.EventHandler(this.btn_setCust_Click);
            // 
            // lbl_orders
            // 
            this.lbl_orders.AutoSize = true;
            this.lbl_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orders.Location = new System.Drawing.Point(431, 108);
            this.lbl_orders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_orders.Name = "lbl_orders";
            this.lbl_orders.Size = new System.Drawing.Size(152, 29);
            this.lbl_orders.TabIndex = 22;
            this.lbl_orders.Text = "Past Orders";
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(1202, 429);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(226, 44);
            this.btn_reset.TabIndex = 21;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_print
            // 
            this.btn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(1202, 154);
            this.btn_print.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(226, 44);
            this.btn_print.TabIndex = 20;
            this.btn_print.Text = "View/Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // lstbox_customer
            // 
            this.lstbox_customer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstbox_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbox_customer.FormattingEnabled = true;
            this.lstbox_customer.ItemHeight = 29;
            this.lstbox_customer.Location = new System.Drawing.Point(26, 154);
            this.lstbox_customer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstbox_customer.Name = "lstbox_customer";
            this.lstbox_customer.Size = new System.Drawing.Size(364, 642);
            this.lstbox_customer.TabIndex = 19;
            this.lstbox_customer.SelectedIndexChanged += new System.EventHandler(this.lstbox_customer_SelectedIndexChanged);
            // 
            // transaction_dataGrid
            // 
            this.transaction_dataGrid.AllowUserToAddRows = false;
            this.transaction_dataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.transaction_dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.transaction_dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transaction_dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.transaction_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transaction_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trans_id,
            this.trans_date,
            this.trans_total});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transaction_dataGrid.DefaultCellStyle = dataGridViewCellStyle22;
            this.transaction_dataGrid.Location = new System.Drawing.Point(428, 154);
            this.transaction_dataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.transaction_dataGrid.Name = "transaction_dataGrid";
            this.transaction_dataGrid.ReadOnly = true;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transaction_dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.transaction_dataGrid.RowHeadersVisible = false;
            this.transaction_dataGrid.RowHeadersWidth = 62;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.transaction_dataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transaction_dataGrid.Size = new System.Drawing.Size(749, 638);
            this.transaction_dataGrid.TabIndex = 18;
            this.transaction_dataGrid.SelectionChanged += new System.EventHandler(this.transaction_dataGrid_SelectionChanged);
            // 
            // trans_id
            // 
            this.trans_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trans_id.DataPropertyName = "trans_id";
            this.trans_id.HeaderText = "Id";
            this.trans_id.MinimumWidth = 100;
            this.trans_id.Name = "trans_id";
            this.trans_id.ReadOnly = true;
            // 
            // trans_date
            // 
            this.trans_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trans_date.DataPropertyName = "trans_date";
            this.trans_date.HeaderText = "Date";
            this.trans_date.MinimumWidth = 100;
            this.trans_date.Name = "trans_date";
            this.trans_date.ReadOnly = true;
            // 
            // trans_total
            // 
            this.trans_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trans_total.DataPropertyName = "trans_total";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.trans_total.DefaultCellStyle = dataGridViewCellStyle21;
            this.trans_total.FillWeight = 81.47208F;
            this.trans_total.HeaderText = "Total";
            this.trans_total.MinimumWidth = 80;
            this.trans_total.Name = "trans_total";
            this.trans_total.ReadOnly = true;
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_end.Location = new System.Drawing.Point(776, 20);
            this.lbl_end.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(66, 29);
            this.lbl_end.TabIndex = 17;
            this.lbl_end.Text = "End:";
            // 
            // end_dateTime
            // 
            this.end_dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.end_dateTime.Location = new System.Drawing.Point(850, 16);
            this.end_dateTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.end_dateTime.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.end_dateTime.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.end_dateTime.Name = "end_dateTime";
            this.end_dateTime.Size = new System.Drawing.Size(242, 35);
            this.end_dateTime.TabIndex = 16;
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_start.Location = new System.Drawing.Point(417, 21);
            this.lbl_start.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(74, 29);
            this.lbl_start.TabIndex = 15;
            this.lbl_start.Text = "Start:";
            // 
            // start_dateTime
            // 
            this.start_dateTime.CustomFormat = "MM-dd-yy";
            this.start_dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.start_dateTime.Location = new System.Drawing.Point(501, 16);
            this.start_dateTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.start_dateTime.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.start_dateTime.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.start_dateTime.Name = "start_dateTime";
            this.start_dateTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.start_dateTime.Size = new System.Drawing.Size(241, 35);
            this.start_dateTime.TabIndex = 14;
            this.start_dateTime.Value = new System.DateTime(2021, 12, 29, 0, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstbox_customer);
            this.panel1.Controls.Add(this.textBox_CustomerName);
            this.panel1.Controls.Add(this.start_dateTime);
            this.panel1.Controls.Add(this.btn_setDate);
            this.panel1.Controls.Add(this.lbl_start);
            this.panel1.Controls.Add(this.btn_setCust);
            this.panel1.Controls.Add(this.end_dateTime);
            this.panel1.Controls.Add(this.lbl_orders);
            this.panel1.Controls.Add(this.lbl_end);
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.transaction_dataGrid);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1454, 831);
            this.panel1.TabIndex = 26;
            // 
            // Panel_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Panel_History";
            this.Size = new System.Drawing.Size(1454, 831);
            ((System.ComponentModel.ISupportInitialize)(this.transaction_dataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
		private System.Windows.Forms.Label lbl_end;
		private System.Windows.Forms.DateTimePicker end_dateTime;
		private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn trans_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn trans_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn trans_total;
        internal System.Windows.Forms.DateTimePicker start_dateTime;
    }
}
