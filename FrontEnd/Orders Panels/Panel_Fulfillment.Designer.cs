
namespace SecretCellar.Orders_Panels {
	partial class Panel_Fulfillment {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbl_whole_cust = new System.Windows.Forms.Label();
            this.cbx_fullfill_cust = new System.Windows.Forms.ComboBox();
            this.btn_deliver_selected = new System.Windows.Forms.Button();
            this.btn_deliver_all = new System.Windows.Forms.Button();
            this.btn_whole_assign_update = new System.Windows.Forms.Button();
            this.lbl_assignqty = new System.Windows.Forms.Label();
            this.txt_deliverqty = new System.Windows.Forms.TextBox();
            this.fullfill_datagrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.due = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fullfill_datagrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(632, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(309, 26);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // lbl_whole_cust
            // 
            this.lbl_whole_cust.AutoSize = true;
            this.lbl_whole_cust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_whole_cust.Location = new System.Drawing.Point(7, 7);
            this.lbl_whole_cust.Name = "lbl_whole_cust";
            this.lbl_whole_cust.Size = new System.Drawing.Size(91, 20);
            this.lbl_whole_cust.TabIndex = 14;
            this.lbl_whole_cust.Text = "Customer:";
            // 
            // cbx_fullfill_cust
            // 
            this.cbx_fullfill_cust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_fullfill_cust.FormattingEnabled = true;
            this.cbx_fullfill_cust.Location = new System.Drawing.Point(104, 4);
            this.cbx_fullfill_cust.Name = "cbx_fullfill_cust";
            this.cbx_fullfill_cust.Size = new System.Drawing.Size(260, 28);
            this.cbx_fullfill_cust.TabIndex = 13;
            this.cbx_fullfill_cust.SelectedValueChanged += new System.EventHandler(this.frefresh);
            // 
            // btn_deliver_selected
            // 
            this.btn_deliver_selected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deliver_selected.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_deliver_selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deliver_selected.Location = new System.Drawing.Point(577, 507);
            this.btn_deliver_selected.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deliver_selected.Name = "btn_deliver_selected";
            this.btn_deliver_selected.Size = new System.Drawing.Size(170, 36);
            this.btn_deliver_selected.TabIndex = 25;
            this.btn_deliver_selected.Text = "Deliver Selected";
            this.btn_deliver_selected.UseVisualStyleBackColor = true;
            this.btn_deliver_selected.Click += new System.EventHandler(this.btn_deliver_selected_Click);
            // 
            // btn_deliver_all
            // 
            this.btn_deliver_all.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deliver_all.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_deliver_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deliver_all.Location = new System.Drawing.Point(787, 507);
            this.btn_deliver_all.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deliver_all.Name = "btn_deliver_all";
            this.btn_deliver_all.Size = new System.Drawing.Size(170, 36);
            this.btn_deliver_all.TabIndex = 24;
            this.btn_deliver_all.Text = "Deliver All";
            this.btn_deliver_all.UseVisualStyleBackColor = true;
            this.btn_deliver_all.Click += new System.EventHandler(this.btn_deliver_all_Click);
            // 
            // btn_whole_assign_update
            // 
            this.btn_whole_assign_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_whole_assign_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_whole_assign_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_whole_assign_update.Location = new System.Drawing.Point(194, 508);
            this.btn_whole_assign_update.Name = "btn_whole_assign_update";
            this.btn_whole_assign_update.Size = new System.Drawing.Size(170, 36);
            this.btn_whole_assign_update.TabIndex = 23;
            this.btn_whole_assign_update.Text = "Delivered Update";
            this.btn_whole_assign_update.UseVisualStyleBackColor = true;
            this.btn_whole_assign_update.Click += new System.EventHandler(this.btn_delivered_update_Click);
            // 
            // lbl_assignqty
            // 
            this.lbl_assignqty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_assignqty.AutoSize = true;
            this.lbl_assignqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_assignqty.Location = new System.Drawing.Point(10, 496);
            this.lbl_assignqty.Name = "lbl_assignqty";
            this.lbl_assignqty.Size = new System.Drawing.Size(121, 20);
            this.lbl_assignqty.TabIndex = 22;
            this.lbl_assignqty.Text = "Qty Delivered:";
            // 
            // txt_deliverqty
            // 
            this.txt_deliverqty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_deliverqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_deliverqty.Location = new System.Drawing.Point(10, 517);
            this.txt_deliverqty.Name = "txt_deliverqty";
            this.txt_deliverqty.Size = new System.Drawing.Size(134, 26);
            this.txt_deliverqty.TabIndex = 21;
            // 
            // fullfill_datagrid
            // 
            this.fullfill_datagrid.AllowUserToAddRows = false;
            this.fullfill_datagrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Ivory;
            this.fullfill_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.fullfill_datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullfill_datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fullfill_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.fullfill_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fullfill_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.barcode,
            this.name,
            this.type,
            this.qty,
            this.orderqty,
            this.price,
            this.requestqty,
            this.due});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.fullfill_datagrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.fullfill_datagrid.Location = new System.Drawing.Point(10, 32);
            this.fullfill_datagrid.Name = "fullfill_datagrid";
            this.fullfill_datagrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fullfill_datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.fullfill_datagrid.RowHeadersVisible = false;
            this.fullfill_datagrid.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Ivory;
            this.fullfill_datagrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.fullfill_datagrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fullfill_datagrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullfill_datagrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.fullfill_datagrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Ivory;
            this.fullfill_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fullfill_datagrid.Size = new System.Drawing.Size(947, 457);
            this.fullfill_datagrid.TabIndex = 20;
            this.fullfill_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fullfill_datagrid_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 150;
            // 
            // barcode
            // 
            this.barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.barcode.DataPropertyName = "barcode";
            this.barcode.FillWeight = 150F;
            this.barcode.HeaderText = "Barcode";
            this.barcode.MinimumWidth = 150;
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.FillWeight = 250F;
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 250;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 8;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Visible = false;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qty.DataPropertyName = "qty";
            this.qty.FillWeight = 85F;
            this.qty.HeaderText = "Qty";
            this.qty.MinimumWidth = 85;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // orderqty
            // 
            this.orderqty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderqty.DataPropertyName = "orderqty";
            this.orderqty.FillWeight = 90F;
            this.orderqty.HeaderText = "Order Qty";
            this.orderqty.MinimumWidth = 90;
            this.orderqty.Name = "orderqty";
            this.orderqty.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.DataPropertyName = "price";
            this.price.FillWeight = 90F;
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 90;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // requestqty
            // 
            this.requestqty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.requestqty.DataPropertyName = "requestqty";
            this.requestqty.FillWeight = 90F;
            this.requestqty.HeaderText = "Request Qty";
            this.requestqty.MinimumWidth = 90;
            this.requestqty.Name = "requestqty";
            this.requestqty.ReadOnly = true;
            // 
            // due
            // 
            this.due.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.due.DataPropertyName = "due";
            this.due.FillWeight = 90F;
            this.due.HeaderText = "Balance Due";
            this.due.MinimumWidth = 90;
            this.due.Name = "due";
            this.due.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Controls.Add(this.btn_deliver_selected);
            this.panel1.Controls.Add(this.lbl_assignqty);
            this.panel1.Controls.Add(this.btn_deliver_all);
            this.panel1.Controls.Add(this.txt_deliverqty);
            this.panel1.Controls.Add(this.btn_whole_assign_update);
            this.panel1.Controls.Add(this.fullfill_datagrid);
            this.panel1.Controls.Add(this.lbl_whole_cust);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.cbx_fullfill_cust);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 554);
            this.panel1.TabIndex = 26;
            // 
            // lbl_date
            // 
            this.lbl_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(552, 9);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(53, 20);
            this.lbl_date.TabIndex = 26;
            this.lbl_date.Text = "Date:";
            // 
            // Panel_Fulfillment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Name = "Panel_Fulfillment";
            this.Size = new System.Drawing.Size(969, 554);
            ((System.ComponentModel.ISupportInitialize)(this.fullfill_datagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label lbl_whole_cust;
		private System.Windows.Forms.ComboBox cbx_fullfill_cust;
		private System.Windows.Forms.Button btn_deliver_selected;
		private System.Windows.Forms.Button btn_deliver_all;
		private System.Windows.Forms.Button btn_whole_assign_update;
		private System.Windows.Forms.Label lbl_assignqty;
		private System.Windows.Forms.TextBox txt_deliverqty;
		private System.Windows.Forms.DataGridView fullfill_datagrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn due;
        private System.Windows.Forms.Label lbl_date;
    }
}
