
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
            this.btn_received = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_update_qty = new System.Windows.Forms.TextBox();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.lbl_order_date = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_print_supp = new System.Windows.Forms.Button();
            this.txt_supp_total = new System.Windows.Forms.TextBox();
            this.lbl_supp_total = new System.Windows.Forms.Label();
            this.lbl_supplier = new System.Windows.Forms.Label();
            this.cbx_supplier = new System.Windows.Forms.ComboBox();
            this.supp_dataGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.supp_dataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_received
            // 
            this.btn_received.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_received.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_received.Location = new System.Drawing.Point(916, 446);
            this.btn_received.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_received.Name = "btn_received";
            this.btn_received.Size = new System.Drawing.Size(231, 55);
            this.btn_received.TabIndex = 26;
            this.btn_received.Text = "Enter Received";
            this.btn_received.UseVisualStyleBackColor = true;
            this.btn_received.Click += new System.EventHandler(this.btn_received_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(916, 168);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(231, 55);
            this.btn_update.TabIndex = 25;
            this.btn_update.Text = "Update Qty";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_update_qty
            // 
            this.txt_update_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_update_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_update_qty.Location = new System.Drawing.Point(915, 119);
            this.txt_update_qty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_update_qty.Name = "txt_update_qty";
            this.txt_update_qty.Size = new System.Drawing.Size(230, 26);
            this.txt_update_qty.TabIndex = 24;
            // 
            // lbl_qty
            // 
            this.lbl_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.Location = new System.Drawing.Point(917, 94);
            this.lbl_qty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(133, 20);
            this.lbl_qty.TabIndex = 23;
            this.lbl_qty.Text = "Order Quantity";
            // 
            // lbl_order_date
            // 
            this.lbl_order_date.AutoSize = true;
            this.lbl_order_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_date.Location = new System.Drawing.Point(9, 11);
            this.lbl_order_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_order_date.Name = "lbl_order_date";
            this.lbl_order_date.Size = new System.Drawing.Size(103, 20);
            this.lbl_order_date.TabIndex = 22;
            this.lbl_order_date.Text = "Order Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 8);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 25);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // btn_print_supp
            // 
            this.btn_print_supp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print_supp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print_supp.Location = new System.Drawing.Point(914, 11);
            this.btn_print_supp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_print_supp.Name = "btn_print_supp";
            this.btn_print_supp.Size = new System.Drawing.Size(231, 55);
            this.btn_print_supp.TabIndex = 20;
            this.btn_print_supp.Text = "Print Form";
            this.btn_print_supp.UseVisualStyleBackColor = true;
            this.btn_print_supp.Click += new System.EventHandler(this.btn_print_supp_Click);
            // 
            // txt_supp_total
            // 
            this.txt_supp_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_supp_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_supp_total.Location = new System.Drawing.Point(919, 366);
            this.txt_supp_total.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_supp_total.Name = "txt_supp_total";
            this.txt_supp_total.Size = new System.Drawing.Size(228, 26);
            this.txt_supp_total.TabIndex = 19;
            // 
            // lbl_supp_total
            // 
            this.lbl_supp_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_supp_total.AutoSize = true;
            this.lbl_supp_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_supp_total.Location = new System.Drawing.Point(917, 341);
            this.lbl_supp_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_supp_total.Name = "lbl_supp_total";
            this.lbl_supp_total.Size = new System.Drawing.Size(51, 20);
            this.lbl_supp_total.TabIndex = 18;
            this.lbl_supp_total.Text = "Total";
            // 
            // lbl_supplier
            // 
            this.lbl_supplier.AutoSize = true;
            this.lbl_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_supplier.Location = new System.Drawing.Point(457, 11);
            this.lbl_supplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_supplier.Name = "lbl_supplier";
            this.lbl_supplier.Size = new System.Drawing.Size(78, 20);
            this.lbl_supplier.TabIndex = 17;
            this.lbl_supplier.Text = "Supplier";
            // 
            // cbx_supplier
            // 
            this.cbx_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_supplier.FormattingEnabled = true;
            this.cbx_supplier.Location = new System.Drawing.Point(539, 7);
            this.cbx_supplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_supplier.Name = "cbx_supplier";
            this.cbx_supplier.Size = new System.Drawing.Size(370, 28);
            this.cbx_supplier.TabIndex = 16;
            this.cbx_supplier.SelectedIndexChanged += new System.EventHandler(this.cbx_supplier_SelectedIndexChanged);
            // 
            // supp_dataGrid
            // 
            this.supp_dataGrid.AllowUserToAddRows = false;
            this.supp_dataGrid.AllowUserToDeleteRows = false;
            this.supp_dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.supp_dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supp_dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.RequestQty,
            this.orderqty});
            this.supp_dataGrid.Location = new System.Drawing.Point(14, 45);
            this.supp_dataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.supp_dataGrid.Name = "supp_dataGrid";
            this.supp_dataGrid.ReadOnly = true;
            this.supp_dataGrid.RowHeadersVisible = false;
            this.supp_dataGrid.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supp_dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.supp_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.supp_dataGrid.Size = new System.Drawing.Size(895, 456);
            this.supp_dataGrid.TabIndex = 15;
            this.supp_dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supp_dataGrid_CellContentClick);
            this.supp_dataGrid.SelectionChanged += new System.EventHandler(this.supp_dataGrid_SelectionChanged);
            // 
            // panel1
            // 
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 506);
            this.panel1.TabIndex = 27;
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
            // RequestQty
            // 
            this.RequestQty.DataPropertyName = "RequestQty";
            this.RequestQty.HeaderText = "Request Qty";
            this.RequestQty.MinimumWidth = 8;
            this.RequestQty.Name = "RequestQty";
            this.RequestQty.ReadOnly = true;
            // 
            // orderqty
            // 
            this.orderqty.DataPropertyName = "orderqty";
            this.orderqty.HeaderText = "Ordered Qty";
            this.orderqty.MinimumWidth = 8;
            this.orderqty.Name = "orderqty";
            this.orderqty.ReadOnly = true;
            // 
            // Panel_SupplierOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Panel_SupplierOrder";
            this.Size = new System.Drawing.Size(1152, 506);
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
		private System.Windows.Forms.TextBox txt_supp_total;
		private System.Windows.Forms.Label lbl_supp_total;
		private System.Windows.Forms.Label lbl_supplier;
		private System.Windows.Forms.ComboBox cbx_supplier;
		private System.Windows.Forms.DataGridView supp_dataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn minqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderqty;
    }
}
