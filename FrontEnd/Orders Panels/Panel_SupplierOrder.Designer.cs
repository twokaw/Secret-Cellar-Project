
namespace SecretCellar.Orders_Panels {
	partial class Panel_SupplierOrder {
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
            this.btn_received = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_update_qty = new System.Windows.Forms.TextBox();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.lbl_order_date = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_print_supp = new System.Windows.Forms.Button();
            this.lbl_supp_total = new System.Windows.Forms.Label();
            this.lbl_supplier = new System.Windows.Forms.Label();
            this.cbx_supplier = new System.Windows.Forms.ComboBox();
            this.supp_dataGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequiredQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_OnlyRequired = new System.Windows.Forms.CheckBox();
            this.chk_ShowHidden = new System.Windows.Forms.CheckBox();
            this.txt_supp_total = new SecretCellar.CurrencyBox();
            ((System.ComponentModel.ISupportInitialize)(this.supp_dataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_received
            // 
            this.btn_received.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_received.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_received.Location = new System.Drawing.Point(610, 290);
            this.btn_received.Name = "btn_received";
            this.btn_received.Size = new System.Drawing.Size(154, 36);
            this.btn_received.TabIndex = 26;
            this.btn_received.Text = "Enter Received";
            this.btn_received.UseVisualStyleBackColor = true;
            this.btn_received.Click += new System.EventHandler(this.btn_received_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(610, 192);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(154, 36);
            this.btn_update.TabIndex = 25;
            this.btn_update.Text = "Update Qty";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_update_qty
            // 
            this.txt_update_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_update_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_update_qty.Location = new System.Drawing.Point(610, 158);
            this.txt_update_qty.Name = "txt_update_qty";
            this.txt_update_qty.Size = new System.Drawing.Size(155, 26);
            this.txt_update_qty.TabIndex = 24;
            // 
            // lbl_qty
            // 
            this.lbl_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.Location = new System.Drawing.Point(610, 128);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(126, 20);
            this.lbl_qty.TabIndex = 23;
            this.lbl_qty.Text = "Order Quantity";
            // 
            // lbl_order_date
            // 
            this.lbl_order_date.AutoSize = true;
            this.lbl_order_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_date.Location = new System.Drawing.Point(4, 7);
            this.lbl_order_date.Name = "lbl_order_date";
            this.lbl_order_date.Size = new System.Drawing.Size(91, 18);
            this.lbl_order_date.TabIndex = 22;
            this.lbl_order_date.Text = "Order Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(275, 24);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // btn_print_supp
            // 
            this.btn_print_supp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print_supp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print_supp.Location = new System.Drawing.Point(614, 87);
            this.btn_print_supp.Name = "btn_print_supp";
            this.btn_print_supp.Size = new System.Drawing.Size(150, 36);
            this.btn_print_supp.TabIndex = 20;
            this.btn_print_supp.Text = "Print";
            this.btn_print_supp.UseVisualStyleBackColor = true;
            this.btn_print_supp.Click += new System.EventHandler(this.btn_print_supp_Click);
            // 
            // lbl_supp_total
            // 
            this.lbl_supp_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_supp_total.AutoSize = true;
            this.lbl_supp_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_supp_total.Location = new System.Drawing.Point(610, 232);
            this.lbl_supp_total.Name = "lbl_supp_total";
            this.lbl_supp_total.Size = new System.Drawing.Size(49, 20);
            this.lbl_supp_total.TabIndex = 18;
            this.lbl_supp_total.Text = "Total";
            // 
            // lbl_supplier
            // 
            this.lbl_supplier.AutoSize = true;
            this.lbl_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_supplier.Location = new System.Drawing.Point(356, 6);
            this.lbl_supplier.Name = "lbl_supplier";
            this.lbl_supplier.Size = new System.Drawing.Size(69, 18);
            this.lbl_supplier.TabIndex = 17;
            this.lbl_supplier.Text = "Supplier";
            // 
            // cbx_supplier
            // 
            this.cbx_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_supplier.FormattingEnabled = true;
            this.cbx_supplier.Location = new System.Drawing.Point(423, 3);
            this.cbx_supplier.Name = "cbx_supplier";
            this.cbx_supplier.Size = new System.Drawing.Size(214, 25);
            this.cbx_supplier.TabIndex = 16;
            this.cbx_supplier.SelectedIndexChanged += new System.EventHandler(this.cbx_supplier_SelectedIndexChanged);
            // 
            // supp_dataGrid
            // 
            this.supp_dataGrid.AllowUserToAddRows = false;
            this.supp_dataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.supp_dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.supp_dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.supp_dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supp_dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.supp_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supp_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.barcode,
            this.name,
            this.ItemType,
            this.qty,
            this.price,
            this.minqty,
            this.maxqty,
            this.RequiredQty,
            this.orderqty});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.supp_dataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.supp_dataGrid.Location = new System.Drawing.Point(9, 36);
            this.supp_dataGrid.Name = "supp_dataGrid";
            this.supp_dataGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supp_dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.supp_dataGrid.RowHeadersVisible = false;
            this.supp_dataGrid.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supp_dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.supp_dataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supp_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.supp_dataGrid.Size = new System.Drawing.Size(597, 289);
            this.supp_dataGrid.TabIndex = 15;
            this.supp_dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supp_dataGrid_CellContentClick);
            this.supp_dataGrid.SelectionChanged += new System.EventHandler(this.supp_dataGrid_SelectionChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // barcode
            // 
            this.barcode.DataPropertyName = "Barcode";
            this.barcode.HeaderText = "Barcode";
            this.barcode.MinimumWidth = 8;
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // ItemType
            // 
            this.ItemType.DataPropertyName = "ItemType";
            this.ItemType.HeaderText = "Type";
            this.ItemType.MinimumWidth = 8;
            this.ItemType.Name = "ItemType";
            this.ItemType.ReadOnly = true;
            this.ItemType.Visible = false;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "Qty";
            this.qty.HeaderText = "Qty";
            this.qty.MinimumWidth = 8;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "Price";
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // minqty
            // 
            this.minqty.DataPropertyName = "minqty";
            this.minqty.HeaderText = "Min Qty";
            this.minqty.MinimumWidth = 8;
            this.minqty.Name = "minqty";
            this.minqty.ReadOnly = true;
            // 
            // maxqty
            // 
            this.maxqty.DataPropertyName = "maxqty";
            this.maxqty.HeaderText = "Max Qty";
            this.maxqty.MinimumWidth = 8;
            this.maxqty.Name = "maxqty";
            this.maxqty.ReadOnly = true;
            // 
            // RequiredQty
            // 
            this.RequiredQty.DataPropertyName = "RequiredQty";
            this.RequiredQty.HeaderText = "Required Qty";
            this.RequiredQty.MinimumWidth = 8;
            this.RequiredQty.Name = "RequiredQty";
            this.RequiredQty.ReadOnly = true;
            // 
            // orderqty
            // 
            this.orderqty.DataPropertyName = "orderqty";
            this.orderqty.HeaderText = "Ordered Qty";
            this.orderqty.MinimumWidth = 8;
            this.orderqty.Name = "orderqty";
            this.orderqty.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chk_OnlyRequired);
            this.panel1.Controls.Add(this.chk_ShowHidden);
            this.panel1.Controls.Add(this.lbl_qty);
            this.panel1.Controls.Add(this.btn_received);
            this.panel1.Controls.Add(this.lbl_supp_total);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.supp_dataGrid);
            this.panel1.Controls.Add(this.txt_update_qty);
            this.panel1.Controls.Add(this.cbx_supplier);
            this.panel1.Controls.Add(this.lbl_order_date);
            this.panel1.Controls.Add(this.lbl_supplier);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.txt_supp_total);
            this.panel1.Controls.Add(this.btn_print_supp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 329);
            this.panel1.TabIndex = 27;
            // 
            // chk_OnlyRequired
            // 
            this.chk_OnlyRequired.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_OnlyRequired.AutoSize = true;
            this.chk_OnlyRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_OnlyRequired.Location = new System.Drawing.Point(631, 54);
            this.chk_OnlyRequired.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_OnlyRequired.Name = "chk_OnlyRequired";
            this.chk_OnlyRequired.Size = new System.Drawing.Size(133, 22);
            this.chk_OnlyRequired.TabIndex = 28;
            this.chk_OnlyRequired.Text = "Only Required";
            this.chk_OnlyRequired.UseVisualStyleBackColor = true;
            this.chk_OnlyRequired.CheckedChanged += new System.EventHandler(this.chk_OnlyRequired_CheckedChanged);
            // 
            // chk_ShowHidden
            // 
            this.chk_ShowHidden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_ShowHidden.AutoSize = true;
            this.chk_ShowHidden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_ShowHidden.Location = new System.Drawing.Point(631, 27);
            this.chk_ShowHidden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_ShowHidden.Name = "chk_ShowHidden";
            this.chk_ShowHidden.Size = new System.Drawing.Size(126, 22);
            this.chk_ShowHidden.TabIndex = 27;
            this.chk_ShowHidden.Text = "Show Hidden";
            this.chk_ShowHidden.UseVisualStyleBackColor = true;
            this.chk_ShowHidden.CheckedChanged += new System.EventHandler(this.chk_ShowHidden_CheckedChanged);
            // 
            // txt_supp_total
            // 
            this.txt_supp_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_supp_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_supp_total.Location = new System.Drawing.Point(614, 259);
            this.txt_supp_total.Name = "txt_supp_total";
            this.txt_supp_total.Size = new System.Drawing.Size(153, 26);
            this.txt_supp_total.TabIndex = 19;
            this.txt_supp_total.Text = "0.00";
            // 
            // Panel_SupplierOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Panel_SupplierOrder";
            this.Size = new System.Drawing.Size(768, 329);
            this.Load += new System.EventHandler(this.Panel_SupplierOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supp_dataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_received;
		private System.Windows.Forms.Button btn_update;
		private System.Windows.Forms.TextBox txt_update_qty;
		private System.Windows.Forms.Label lbl_qty;
		private System.Windows.Forms.Label lbl_order_date;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button btn_print_supp;
		private SecretCellar.CurrencyBox  txt_supp_total;
		private System.Windows.Forms.Label lbl_supp_total;
		private System.Windows.Forms.Label lbl_supplier;
		private System.Windows.Forms.ComboBox cbx_supplier;
		private System.Windows.Forms.DataGridView supp_dataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chk_OnlyRequired;
        private System.Windows.Forms.CheckBox chk_ShowHidden;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn minqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequiredQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderqty;
    }
}
