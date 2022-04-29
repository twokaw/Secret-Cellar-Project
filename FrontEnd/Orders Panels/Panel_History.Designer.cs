
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox_CustomerName = new System.Windows.Forms.TextBox();
            this.lbl_orders = new System.Windows.Forms.Label();
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
            this.LblLastRefund = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Items = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxPartId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxPartQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Returns = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transaction_dataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Items)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_CustomerName
            // 
            this.textBox_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CustomerName.Location = new System.Drawing.Point(31, 105);
            this.textBox_CustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_CustomerName.Name = "textBox_CustomerName";
            this.textBox_CustomerName.Size = new System.Drawing.Size(301, 35);
            this.textBox_CustomerName.TabIndex = 25;
            this.textBox_CustomerName.Text = "Search for customer";
            this.textBox_CustomerName.TextChanged += new System.EventHandler(this.textBox_CustomerName_TextChanged);
            this.textBox_CustomerName.Enter += new System.EventHandler(this.textBox_CustomerName_Enter);
            this.textBox_CustomerName.Leave += new System.EventHandler(this.textBox_CustomerName_Leave);
            // 
            // lbl_orders
            // 
            this.lbl_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orders.Location = new System.Drawing.Point(347, 72);
            this.lbl_orders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_orders.Name = "lbl_orders";
            this.lbl_orders.Size = new System.Drawing.Size(495, 29);
            this.lbl_orders.TabIndex = 22;
            this.lbl_orders.Text = "Past Orders";
            this.lbl_orders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_print
            // 
            this.btn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(943, 761);
            this.btn_print.Margin = new System.Windows.Forms.Padding(4);
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
            this.lstbox_customer.Location = new System.Drawing.Point(26, 163);
            this.lstbox_customer.Margin = new System.Windows.Forms.Padding(4);
            this.lstbox_customer.Name = "lstbox_customer";
            this.lstbox_customer.Size = new System.Drawing.Size(306, 642);
            this.lstbox_customer.TabIndex = 19;
            this.lstbox_customer.SelectedIndexChanged += new System.EventHandler(this.lstbox_customer_SelectedIndexChanged);
            // 
            // transaction_dataGrid
            // 
            this.transaction_dataGrid.AllowUserToAddRows = false;
            this.transaction_dataGrid.AllowUserToDeleteRows = false;
            this.transaction_dataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Ivory;
            this.transaction_dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.transaction_dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.transaction_dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.transaction_dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transaction_dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.transaction_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transaction_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trans_id,
            this.trans_date,
            this.trans_total});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transaction_dataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.transaction_dataGrid.Location = new System.Drawing.Point(352, 105);
            this.transaction_dataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.transaction_dataGrid.MultiSelect = false;
            this.transaction_dataGrid.Name = "transaction_dataGrid";
            this.transaction_dataGrid.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transaction_dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.transaction_dataGrid.RowHeadersVisible = false;
            this.transaction_dataGrid.RowHeadersWidth = 62;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Ivory;
            this.transaction_dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.transaction_dataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.transaction_dataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_dataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.transaction_dataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Ivory;
            this.transaction_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transaction_dataGrid.Size = new System.Drawing.Size(490, 700);
            this.transaction_dataGrid.TabIndex = 18;
            this.transaction_dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.transaction_dataGrid_CellContentClick);
            this.transaction_dataGrid.SelectionChanged += new System.EventHandler(this.transaction_dataGrid_SelectionChanged);
            // 
            // trans_id
            // 
            this.trans_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.trans_id.DataPropertyName = "trans_id";
            this.trans_id.HeaderText = "Id";
            this.trans_id.MinimumWidth = 100;
            this.trans_id.Name = "trans_id";
            this.trans_id.ReadOnly = true;
            // 
            // trans_date
            // 
            this.trans_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.trans_date.DataPropertyName = "trans_date";
            this.trans_date.HeaderText = "Date";
            this.trans_date.MinimumWidth = 100;
            this.trans_date.Name = "trans_date";
            this.trans_date.ReadOnly = true;
            this.trans_date.Width = 103;
            // 
            // trans_total
            // 
            this.trans_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trans_total.DataPropertyName = "trans_total";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.trans_total.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.end_dateTime.Margin = new System.Windows.Forms.Padding(4);
            this.end_dateTime.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.end_dateTime.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.end_dateTime.Name = "end_dateTime";
            this.end_dateTime.Size = new System.Drawing.Size(242, 35);
            this.end_dateTime.TabIndex = 16;
            this.end_dateTime.ValueChanged += new System.EventHandler(this.end_dateTime_ValueChanged);
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
            this.start_dateTime.Margin = new System.Windows.Forms.Padding(4);
            this.start_dateTime.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.start_dateTime.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.start_dateTime.Name = "start_dateTime";
            this.start_dateTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.start_dateTime.Size = new System.Drawing.Size(241, 35);
            this.start_dateTime.TabIndex = 14;
            this.start_dateTime.Value = new System.DateTime(2021, 12, 29, 0, 0, 0, 0);
            this.start_dateTime.ValueChanged += new System.EventHandler(this.start_dateTime_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.LblLastRefund);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgv_Items);
            this.panel1.Controls.Add(this.btn_Returns);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lstbox_customer);
            this.panel1.Controls.Add(this.textBox_CustomerName);
            this.panel1.Controls.Add(this.start_dateTime);
            this.panel1.Controls.Add(this.lbl_start);
            this.panel1.Controls.Add(this.end_dateTime);
            this.panel1.Controls.Add(this.lbl_orders);
            this.panel1.Controls.Add(this.lbl_end);
            this.panel1.Controls.Add(this.transaction_dataGrid);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1454, 831);
            this.panel1.TabIndex = 26;
            // 
            // LblLastRefund
            // 
            this.LblLastRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastRefund.ForeColor = System.Drawing.Color.DarkRed;
            this.LblLastRefund.Location = new System.Drawing.Point(863, 714);
            this.LblLastRefund.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLastRefund.Name = "LblLastRefund";
            this.LblLastRefund.Size = new System.Drawing.Size(572, 36);
            this.LblLastRefund.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(855, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(580, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "Order Items";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_Items
            // 
            this.dgv_Items.AllowUserToAddRows = false;
            this.dgv_Items.AllowUserToDeleteRows = false;
            this.dgv_Items.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Ivory;
            this.dgv_Items.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Items.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_Items.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Items.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Items.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxPartId,
            this.dataGridViewTextBoxPartName,
            this.Price,
            this.dataGridViewTextBoxPartQty});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Items.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_Items.Location = new System.Drawing.Point(860, 105);
            this.dgv_Items.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Items.Name = "dgv_Items";
            this.dgv_Items.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Items.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_Items.RowHeadersVisible = false;
            this.dgv_Items.RowHeadersWidth = 62;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Ivory;
            this.dgv_Items.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_Items.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Items.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Items.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.dgv_Items.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Ivory;
            this.dgv_Items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Items.Size = new System.Drawing.Size(575, 596);
            this.dgv_Items.TabIndex = 28;
            // 
            // dataGridViewTextBoxPartId
            // 
            this.dataGridViewTextBoxPartId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxPartId.DataPropertyName = "part_Id";
            this.dataGridViewTextBoxPartId.HeaderText = "Id";
            this.dataGridViewTextBoxPartId.MinimumWidth = 100;
            this.dataGridViewTextBoxPartId.Name = "dataGridViewTextBoxPartId";
            this.dataGridViewTextBoxPartId.ReadOnly = true;
            this.dataGridViewTextBoxPartId.Visible = false;
            this.dataGridViewTextBoxPartId.Width = 150;
            // 
            // dataGridViewTextBoxPartName
            // 
            this.dataGridViewTextBoxPartName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxPartName.DataPropertyName = "part_Name";
            this.dataGridViewTextBoxPartName.HeaderText = "Name";
            this.dataGridViewTextBoxPartName.MinimumWidth = 100;
            this.dataGridViewTextBoxPartName.Name = "dataGridViewTextBoxPartName";
            this.dataGridViewTextBoxPartName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Price.DataPropertyName = "part_price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 110;
            // 
            // dataGridViewTextBoxPartQty
            // 
            this.dataGridViewTextBoxPartQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxPartQty.DataPropertyName = "part_Qty";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxPartQty.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxPartQty.FillWeight = 81.47208F;
            this.dataGridViewTextBoxPartQty.HeaderText = "Qty";
            this.dataGridViewTextBoxPartQty.MinimumWidth = 80;
            this.dataGridViewTextBoxPartQty.Name = "dataGridViewTextBoxPartQty";
            this.dataGridViewTextBoxPartQty.ReadOnly = true;
            this.dataGridViewTextBoxPartQty.Width = 88;
            // 
            // btn_Returns
            // 
            this.btn_Returns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Returns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Returns.Location = new System.Drawing.Point(1199, 761);
            this.btn_Returns.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Returns.Name = "btn_Returns";
            this.btn_Returns.Size = new System.Drawing.Size(226, 44);
            this.btn_Returns.TabIndex = 27;
            this.btn_Returns.Text = "Return";
            this.btn_Returns.UseVisualStyleBackColor = true;
            this.btn_Returns.Click += new System.EventHandler(this.btn_Returns_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 36);
            this.label1.TabIndex = 26;
            this.label1.Text = "Customer or Receipt Id";
            // 
            // Panel_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Panel_History";
            this.Size = new System.Drawing.Size(1454, 831);
            this.VisibleChanged += new System.EventHandler(this.Panel_History_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.transaction_dataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Items)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox textBox_CustomerName;
		private System.Windows.Forms.Label lbl_orders;
		private System.Windows.Forms.Button btn_print;
		private System.Windows.Forms.ListBox lstbox_customer;
		private System.Windows.Forms.DataGridView transaction_dataGrid;
		private System.Windows.Forms.Label lbl_end;
		private System.Windows.Forms.DateTimePicker end_dateTime;
		private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.DateTimePicker start_dateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Returns;
        private System.Windows.Forms.DataGridViewTextBoxColumn trans_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn trans_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn trans_total;
        private System.Windows.Forms.DataGridView dgv_Items;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxPartId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxPartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxPartQty;
        private System.Windows.Forms.Label LblLastRefund;
    }
}
