
namespace SecretCellar
{
    partial class frmOrders
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
            this.supp_order = new System.Windows.Forms.TabPage();
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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cust_request = new System.Windows.Forms.TabPage();
            this.lst_customer = new System.Windows.Forms.ListBox();
            this.btn_prod_delete = new System.Windows.Forms.Button();
            this.btn_prod_add = new System.Windows.Forms.Button();
            this.txt_prod_name = new System.Windows.Forms.TextBox();
            this.lbl_prod_name = new System.Windows.Forms.Label();
            this.txt_cust_name = new System.Windows.Forms.TextBox();
            this.lbl_cust_name = new System.Windows.Forms.Label();
            this.request_dataGrid = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_setDate = new System.Windows.Forms.Button();
            this.btn_setCust = new System.Windows.Forms.Button();
            this.lbl_orders = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
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
            this.btn_close = new System.Windows.Forms.Button();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supp_order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supp_dataGrid)).BeginInit();
            this.cust_request.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.request_dataGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transaction_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // supp_order
            // 
            this.supp_order.Controls.Add(this.btn_update);
            this.supp_order.Controls.Add(this.txt_update_qty);
            this.supp_order.Controls.Add(this.lbl_qty);
            this.supp_order.Controls.Add(this.lbl_order_date);
            this.supp_order.Controls.Add(this.dateTimePicker1);
            this.supp_order.Controls.Add(this.btn_print_supp);
            this.supp_order.Controls.Add(this.txt_supp_total);
            this.supp_order.Controls.Add(this.lbl_supp_total);
            this.supp_order.Controls.Add(this.lbl_supplier);
            this.supp_order.Controls.Add(this.cbx_supplier);
            this.supp_order.Controls.Add(this.supp_dataGrid);
            this.supp_order.Location = new System.Drawing.Point(4, 29);
            this.supp_order.Name = "supp_order";
            this.supp_order.Padding = new System.Windows.Forms.Padding(3);
            this.supp_order.Size = new System.Drawing.Size(1540, 463);
            this.supp_order.TabIndex = 2;
            this.supp_order.Text = "Supplier Order";
            this.supp_order.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(1370, 228);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(154, 36);
            this.btn_update.TabIndex = 13;
            this.btn_update.Text = "Update Qty";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_update_qty
            // 
            this.txt_update_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_update_qty.Location = new System.Drawing.Point(1389, 183);
            this.txt_update_qty.Name = "txt_update_qty";
            this.txt_update_qty.Size = new System.Drawing.Size(135, 26);
            this.txt_update_qty.TabIndex = 12;
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Location = new System.Drawing.Point(1240, 186);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(126, 20);
            this.lbl_qty.TabIndex = 11;
            this.lbl_qty.Text = "Order Quantity";
            // 
            // lbl_order_date
            // 
            this.lbl_order_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_order_date.AutoSize = true;
            this.lbl_order_date.Location = new System.Drawing.Point(1233, 101);
            this.lbl_order_date.Name = "lbl_order_date";
            this.lbl_order_date.Size = new System.Drawing.Size(98, 20);
            this.lbl_order_date.TabIndex = 10;
            this.lbl_order_date.Text = "Order Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1337, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // btn_print_supp
            // 
            this.btn_print_supp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print_supp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print_supp.Location = new System.Drawing.Point(1370, 371);
            this.btn_print_supp.Name = "btn_print_supp";
            this.btn_print_supp.Size = new System.Drawing.Size(154, 36);
            this.btn_print_supp.TabIndex = 8;
            this.btn_print_supp.Text = "Print Form";
            this.btn_print_supp.UseVisualStyleBackColor = true;
            // 
            // txt_supp_total
            // 
            this.txt_supp_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_supp_total.Location = new System.Drawing.Point(1389, 297);
            this.txt_supp_total.Name = "txt_supp_total";
            this.txt_supp_total.Size = new System.Drawing.Size(135, 26);
            this.txt_supp_total.TabIndex = 4;
            // 
            // lbl_supp_total
            // 
            this.lbl_supp_total.AutoSize = true;
            this.lbl_supp_total.Location = new System.Drawing.Point(1317, 303);
            this.lbl_supp_total.Name = "lbl_supp_total";
            this.lbl_supp_total.Size = new System.Drawing.Size(49, 20);
            this.lbl_supp_total.TabIndex = 3;
            this.lbl_supp_total.Text = "Total";
            // 
            // lbl_supplier
            // 
            this.lbl_supplier.AutoSize = true;
            this.lbl_supplier.Location = new System.Drawing.Point(101, 58);
            this.lbl_supplier.Name = "lbl_supplier";
            this.lbl_supplier.Size = new System.Drawing.Size(75, 20);
            this.lbl_supplier.TabIndex = 2;
            this.lbl_supplier.Text = "Supplier";
            // 
            // cbx_supplier
            // 
            this.cbx_supplier.FormattingEnabled = true;
            this.cbx_supplier.Location = new System.Drawing.Point(195, 55);
            this.cbx_supplier.Name = "cbx_supplier";
            this.cbx_supplier.Size = new System.Drawing.Size(260, 28);
            this.cbx_supplier.TabIndex = 1;
            this.cbx_supplier.SelectedIndexChanged += new System.EventHandler(this.cbx_supplier_SelectedIndexChanged);
            // 
            // supp_dataGrid
            // 
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
            this.orderqty});
            this.supp_dataGrid.Location = new System.Drawing.Point(25, 107);
            this.supp_dataGrid.Name = "supp_dataGrid";
            this.supp_dataGrid.RowHeadersWidth = 62;
            this.supp_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.supp_dataGrid.Size = new System.Drawing.Size(1177, 300);
            this.supp_dataGrid.TabIndex = 0;
            this.supp_dataGrid.SelectionChanged += new System.EventHandler(this.supp_dataGrid_SelectionChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 150;
            // 
            // barcode
            // 
            this.barcode.DataPropertyName = "Barcode";
            this.barcode.HeaderText = "Barcode";
            this.barcode.MinimumWidth = 8;
            this.barcode.Name = "barcode";
            this.barcode.Width = 200;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.Width = 400;
            // 
            // ItemType
            // 
            this.ItemType.DataPropertyName = "ItemType";
            this.ItemType.HeaderText = "Type";
            this.ItemType.MinimumWidth = 8;
            this.ItemType.Name = "ItemType";
            this.ItemType.Visible = false;
            this.ItemType.Width = 150;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "Qty";
            this.qty.HeaderText = "Qty";
            this.qty.MinimumWidth = 8;
            this.qty.Name = "qty";
            this.qty.Width = 80;
            // 
            // price
            // 
            this.price.DataPropertyName = "Price";
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.Width = 90;
            // 
            // minqty
            // 
            this.minqty.DataPropertyName = "minqty";
            this.minqty.HeaderText = "Min Qty";
            this.minqty.MinimumWidth = 8;
            this.minqty.Name = "minqty";
            this.minqty.Width = 90;
            // 
            // maxqty
            // 
            this.maxqty.DataPropertyName = "maxqty";
            this.maxqty.HeaderText = "Max Qty";
            this.maxqty.MinimumWidth = 8;
            this.maxqty.Name = "maxqty";
            this.maxqty.Width = 90;
            // 
            // orderqty
            // 
            this.orderqty.DataPropertyName = "orderqty";
            this.orderqty.HeaderText = "Order Qty";
            this.orderqty.MinimumWidth = 8;
            this.orderqty.Name = "orderqty";
            this.orderqty.Width = 90;
            // 
            // cust_request
            // 
            this.cust_request.Controls.Add(this.lst_customer);
            this.cust_request.Controls.Add(this.btn_prod_delete);
            this.cust_request.Controls.Add(this.btn_prod_add);
            this.cust_request.Controls.Add(this.txt_prod_name);
            this.cust_request.Controls.Add(this.lbl_prod_name);
            this.cust_request.Controls.Add(this.txt_cust_name);
            this.cust_request.Controls.Add(this.lbl_cust_name);
            this.cust_request.Controls.Add(this.request_dataGrid);
            this.cust_request.Location = new System.Drawing.Point(4, 29);
            this.cust_request.Name = "cust_request";
            this.cust_request.Padding = new System.Windows.Forms.Padding(3);
            this.cust_request.Size = new System.Drawing.Size(1540, 463);
            this.cust_request.TabIndex = 1;
            this.cust_request.Text = "Customer Request";
            this.cust_request.UseVisualStyleBackColor = true;
            // 
            // lst_customer
            // 
            this.lst_customer.FormattingEnabled = true;
            this.lst_customer.ItemHeight = 20;
            this.lst_customer.Location = new System.Drawing.Point(41, 179);
            this.lst_customer.Name = "lst_customer";
            this.lst_customer.Size = new System.Drawing.Size(343, 144);
            this.lst_customer.TabIndex = 7;
            // 
            // btn_prod_delete
            // 
            this.btn_prod_delete.Location = new System.Drawing.Point(717, 301);
            this.btn_prod_delete.Name = "btn_prod_delete";
            this.btn_prod_delete.Size = new System.Drawing.Size(154, 36);
            this.btn_prod_delete.TabIndex = 6;
            this.btn_prod_delete.Text = "Remove";
            this.btn_prod_delete.UseVisualStyleBackColor = true;
            this.btn_prod_delete.Click += new System.EventHandler(this.btn_prod_delete_Click);
            // 
            // btn_prod_add
            // 
            this.btn_prod_add.Location = new System.Drawing.Point(717, 236);
            this.btn_prod_add.Name = "btn_prod_add";
            this.btn_prod_add.Size = new System.Drawing.Size(154, 36);
            this.btn_prod_add.TabIndex = 5;
            this.btn_prod_add.Text = "Add";
            this.btn_prod_add.UseVisualStyleBackColor = true;
            this.btn_prod_add.Click += new System.EventHandler(this.btn_prod_add_Click);
            // 
            // txt_prod_name
            // 
            this.txt_prod_name.Location = new System.Drawing.Point(571, 176);
            this.txt_prod_name.Name = "txt_prod_name";
            this.txt_prod_name.Size = new System.Drawing.Size(300, 26);
            this.txt_prod_name.TabIndex = 4;
            // 
            // lbl_prod_name
            // 
            this.lbl_prod_name.AutoSize = true;
            this.lbl_prod_name.Location = new System.Drawing.Point(428, 179);
            this.lbl_prod_name.Name = "lbl_prod_name";
            this.lbl_prod_name.Size = new System.Drawing.Size(122, 20);
            this.lbl_prod_name.TabIndex = 3;
            this.lbl_prod_name.Text = "Product Name";
            // 
            // txt_cust_name
            // 
            this.txt_cust_name.Location = new System.Drawing.Point(184, 114);
            this.txt_cust_name.Name = "txt_cust_name";
            this.txt_cust_name.Size = new System.Drawing.Size(200, 26);
            this.txt_cust_name.TabIndex = 2;
            this.txt_cust_name.TextChanged += new System.EventHandler(this.txt_cust_name_TextChanged);
            // 
            // lbl_cust_name
            // 
            this.lbl_cust_name.AutoSize = true;
            this.lbl_cust_name.Location = new System.Drawing.Point(41, 117);
            this.lbl_cust_name.Name = "lbl_cust_name";
            this.lbl_cust_name.Size = new System.Drawing.Size(137, 20);
            this.lbl_cust_name.TabIndex = 1;
            this.lbl_cust_name.Text = "Customer Name";
            // 
            // request_dataGrid
            // 
            this.request_dataGrid.AllowUserToAddRows = false;
            this.request_dataGrid.AllowUserToDeleteRows = false;
            this.request_dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.request_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.request_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_id,
            this.note_id,
            this.note_date,
            this.customer_names,
            this.prod_name});
            this.request_dataGrid.Location = new System.Drawing.Point(962, 117);
            this.request_dataGrid.Name = "request_dataGrid";
            this.request_dataGrid.ReadOnly = true;
            this.request_dataGrid.RowHeadersVisible = false;
            this.request_dataGrid.RowHeadersWidth = 62;
            this.request_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.request_dataGrid.Size = new System.Drawing.Size(542, 300);
            this.request_dataGrid.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.cust_request);
            this.tabControl1.Controls.Add(this.supp_order);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1548, 496);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_setDate);
            this.tabPage1.Controls.Add(this.btn_setCust);
            this.tabPage1.Controls.Add(this.lbl_orders);
            this.tabPage1.Controls.Add(this.lbl_name);
            this.tabPage1.Controls.Add(this.txt_name);
            this.tabPage1.Controls.Add(this.btn_reset);
            this.tabPage1.Controls.Add(this.btn_print);
            this.tabPage1.Controls.Add(this.lstbox_customer);
            this.tabPage1.Controls.Add(this.transaction_dataGrid);
            this.tabPage1.Controls.Add(this.lbl_end);
            this.tabPage1.Controls.Add(this.end_dateTime);
            this.tabPage1.Controls.Add(this.lbl_start);
            this.tabPage1.Controls.Add(this.start_dateTime);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1540, 463);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "History";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_setDate
            // 
            this.btn_setDate.Location = new System.Drawing.Point(642, 201);
            this.btn_setDate.Name = "btn_setDate";
            this.btn_setDate.Size = new System.Drawing.Size(179, 48);
            this.btn_setDate.TabIndex = 12;
            this.btn_setDate.Text = "Set Date Range";
            this.btn_setDate.UseVisualStyleBackColor = true;
            this.btn_setDate.Click += new System.EventHandler(this.btn_setDate_Click);
            // 
            // btn_setCust
            // 
            this.btn_setCust.Location = new System.Drawing.Point(135, 342);
            this.btn_setCust.Name = "btn_setCust";
            this.btn_setCust.Size = new System.Drawing.Size(179, 48);
            this.btn_setCust.TabIndex = 11;
            this.btn_setCust.Text = "Set Customer";
            this.btn_setCust.UseVisualStyleBackColor = true;
            this.btn_setCust.Click += new System.EventHandler(this.btn_setCust_Click);
            // 
            // lbl_orders
            // 
            this.lbl_orders.AutoSize = true;
            this.lbl_orders.Location = new System.Drawing.Point(955, 71);
            this.lbl_orders.Name = "lbl_orders";
            this.lbl_orders.Size = new System.Drawing.Size(104, 20);
            this.lbl_orders.TabIndex = 10;
            this.lbl_orders.Text = "Past Orders";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(66, 99);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(137, 20);
            this.lbl_name.TabIndex = 9;
            this.lbl_name.Text = "Customer Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(209, 96);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(204, 26);
            this.txt_name.TabIndex = 8;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(642, 381);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(179, 48);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(642, 315);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(179, 48);
            this.btn_print.TabIndex = 6;
            this.btn_print.Text = "View/Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // lstbox_customer
            // 
            this.lstbox_customer.FormattingEnabled = true;
            this.lstbox_customer.ItemHeight = 20;
            this.lstbox_customer.Location = new System.Drawing.Point(70, 150);
            this.lstbox_customer.Name = "lstbox_customer";
            this.lstbox_customer.Size = new System.Drawing.Size(343, 144);
            this.lstbox_customer.TabIndex = 5;
            // 
            // transaction_dataGrid
            // 
            this.transaction_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transaction_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trans_id,
            this.trans_date,
            this.trans_total});
            this.transaction_dataGrid.Location = new System.Drawing.Point(959, 107);
            this.transaction_dataGrid.Name = "transaction_dataGrid";
            this.transaction_dataGrid.RowHeadersVisible = false;
            this.transaction_dataGrid.RowHeadersWidth = 62;
            this.transaction_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transaction_dataGrid.Size = new System.Drawing.Size(533, 270);
            this.transaction_dataGrid.TabIndex = 4;
            this.transaction_dataGrid.SelectionChanged += new System.EventHandler(this.tranaction_dataGrid_SelectionChanged);
            // 
            // trans_id
            // 
            this.trans_id.DataPropertyName = "trans_id";
            this.trans_id.HeaderText = "Id";
            this.trans_id.MinimumWidth = 8;
            this.trans_id.Name = "trans_id";
            this.trans_id.Width = 150;
            // 
            // trans_date
            // 
            this.trans_date.DataPropertyName = "trans_date";
            this.trans_date.HeaderText = "Date";
            this.trans_date.MinimumWidth = 8;
            this.trans_date.Name = "trans_date";
            this.trans_date.Width = 150;
            // 
            // trans_total
            // 
            this.trans_total.DataPropertyName = "trans_total";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.trans_total.DefaultCellStyle = dataGridViewCellStyle2;
            this.trans_total.HeaderText = "Total";
            this.trans_total.MinimumWidth = 8;
            this.trans_total.Name = "trans_total";
            this.trans_total.Width = 150;
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Location = new System.Drawing.Point(546, 154);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(41, 20);
            this.lbl_end.TabIndex = 3;
            this.lbl_end.Text = "End";
            // 
            // end_dateTime
            // 
            this.end_dateTime.Location = new System.Drawing.Point(601, 150);
            this.end_dateTime.Name = "end_dateTime";
            this.end_dateTime.Size = new System.Drawing.Size(284, 26);
            this.end_dateTime.TabIndex = 2;
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Location = new System.Drawing.Point(546, 111);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(49, 20);
            this.lbl_start.TabIndex = 1;
            this.lbl_start.Text = "Start";
            // 
            // start_dateTime
            // 
            this.start_dateTime.Location = new System.Drawing.Point(601, 107);
            this.start_dateTime.Name = "start_dateTime";
            this.start_dateTime.Size = new System.Drawing.Size(284, 26);
            this.start_dateTime.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(543, 514);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(418, 36);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // customer_id
            // 
            this.customer_id.DataPropertyName = "customer_id";
            this.customer_id.HeaderText = "CustomerID";
            this.customer_id.MinimumWidth = 8;
            this.customer_id.Name = "customer_id";
            this.customer_id.ReadOnly = true;
            this.customer_id.Visible = false;
            this.customer_id.Width = 150;
            // 
            // note_id
            // 
            this.note_id.DataPropertyName = "note_id";
            this.note_id.HeaderText = "NoteID";
            this.note_id.Name = "note_id";
            this.note_id.ReadOnly = true;
            this.note_id.Visible = false;
            // 
            // note_date
            // 
            this.note_date.DataPropertyName = "note_date";
            this.note_date.HeaderText = "NoteDate";
            this.note_date.Name = "note_date";
            this.note_date.ReadOnly = true;
            this.note_date.Visible = false;
            // 
            // customer_names
            // 
            this.customer_names.DataPropertyName = "customer_names";
            this.customer_names.HeaderText = "Customer Name";
            this.customer_names.MinimumWidth = 8;
            this.customer_names.Name = "customer_names";
            this.customer_names.ReadOnly = true;
            this.customer_names.Width = 200;
            // 
            // prod_name
            // 
            this.prod_name.DataPropertyName = "prod_name";
            this.prod_name.HeaderText = "Product Name";
            this.prod_name.MinimumWidth = 8;
            this.prod_name.Name = "prod_name";
            this.prod_name.ReadOnly = true;
            this.prod_name.Width = 300;
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1684, 561);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmOrders";
            this.Text = "frmOrders";
            this.supp_order.ResumeLayout(false);
            this.supp_order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supp_dataGrid)).EndInit();
            this.cust_request.ResumeLayout(false);
            this.cust_request.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.request_dataGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transaction_dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage supp_order;
        private System.Windows.Forms.TextBox txt_supp_total;
        private System.Windows.Forms.Label lbl_supp_total;
        private System.Windows.Forms.Label lbl_supplier;
        private System.Windows.Forms.ComboBox cbx_supplier;
        private System.Windows.Forms.DataGridView supp_dataGrid;
        private System.Windows.Forms.TabPage cust_request;
        private System.Windows.Forms.DataGridView request_dataGrid;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn_prod_delete;
        private System.Windows.Forms.Button btn_prod_add;
        private System.Windows.Forms.TextBox txt_prod_name;
        private System.Windows.Forms.Label lbl_prod_name;
        private System.Windows.Forms.TextBox txt_cust_name;
        private System.Windows.Forms.Label lbl_cust_name;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_update_qty;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.Label lbl_order_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_print_supp;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn minqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderqty;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lstbox_customer;
        private System.Windows.Forms.DataGridView transaction_dataGrid;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.DateTimePicker end_dateTime;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.DateTimePicker start_dateTime;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_orders;
        private System.Windows.Forms.Button btn_setCust;
        private System.Windows.Forms.Button btn_setDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn trans_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn trans_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn trans_total;
        private System.Windows.Forms.ListBox lst_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn note_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn note_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_names;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_name;
    }
}