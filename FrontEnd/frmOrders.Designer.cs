﻿
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
            this.btn_recived = new System.Windows.Forms.Button();
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
            this.textBox_CustomerName = new System.Windows.Forms.TextBox();
            this.lst_customer = new System.Windows.Forms.ListBox();
            this.btn_prod_delete = new System.Windows.Forms.Button();
            this.btn_prod_add = new System.Windows.Forms.Button();
            this.txt_prod_name = new System.Windows.Forms.TextBox();
            this.lbl_prod_name = new System.Windows.Forms.Label();
            this.request_dataGrid = new System.Windows.Forms.DataGridView();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cust_order = new System.Windows.Forms.TabPage();
            this.btn_update_custorder = new System.Windows.Forms.Button();
            this.lbl_supp_custorder = new System.Windows.Forms.Label();
            this.cbx_supp_custorder = new System.Windows.Forms.ComboBox();
            this.lbl_qty_custorder = new System.Windows.Forms.Label();
            this.txt_orderqty_custorder = new System.Windows.Forms.TextBox();
            this.custOrder_datagrid = new System.Windows.Forms.DataGridView();
            this.lbl_cust_custorder = new System.Windows.Forms.Label();
            this.cbx_cust_custorder = new System.Windows.Forms.ComboBox();
            this.Fullfillment = new System.Windows.Forms.TabPage();
            this.btn_whole_assign_update = new System.Windows.Forms.Button();
            this.btn_whole_order_update = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbl_assignqty = new System.Windows.Forms.Label();
            this.txt_receivqty = new System.Windows.Forms.TextBox();
            this.lbl_whole_orderqty = new System.Windows.Forms.Label();
            this.txt_whole_orderqty = new System.Windows.Forms.TextBox();
            this.lbl_whole_cust = new System.Windows.Forms.Label();
            this.cbx_fullfill_cust = new System.Windows.Forms.ComboBox();
            this.fullfill_datagrid = new System.Windows.Forms.DataGridView();
            this.fid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fbarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ftype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fmax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forderqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.History = new System.Windows.Forms.TabPage();
            this.textBox_CustomerName_History = new System.Windows.Forms.TextBox();
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
            this.btn_close = new System.Windows.Forms.Button();
            this.btnFavoritesAdd = new System.Windows.Forms.Button();
            this.btnFavoritesRemove = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.supp_order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supp_dataGrid)).BeginInit();
            this.cust_request.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.request_dataGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.cust_order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custOrder_datagrid)).BeginInit();
            this.Fullfillment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullfill_datagrid)).BeginInit();
            this.History.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transaction_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // supp_order
            // 
            this.supp_order.Controls.Add(this.btn_recived);
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
            this.supp_order.Location = new System.Drawing.Point(4, 38);
            this.supp_order.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.supp_order.Name = "supp_order";
            this.supp_order.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.supp_order.Size = new System.Drawing.Size(1484, 704);
            this.supp_order.TabIndex = 2;
            this.supp_order.Text = "Supplier Order";
            this.supp_order.UseVisualStyleBackColor = true;
            // 
            // btn_recived
            // 
            this.btn_recived.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_recived.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recived.Location = new System.Drawing.Point(1240, 631);
            this.btn_recived.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_recived.Name = "btn_recived";
            this.btn_recived.Size = new System.Drawing.Size(231, 55);
            this.btn_recived.TabIndex = 14;
            this.btn_recived.Text = "Enter Received";
            this.btn_recived.UseVisualStyleBackColor = true;
            this.btn_recived.Click += new System.EventHandler(this.btn_recived_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(1124, 186);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(231, 55);
            this.btn_update.TabIndex = 13;
            this.btn_update.Text = "Update Qty";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_update_qty
            // 
            this.txt_update_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_update_qty.Location = new System.Drawing.Point(1122, 137);
            this.txt_update_qty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_update_qty.Name = "txt_update_qty";
            this.txt_update_qty.Size = new System.Drawing.Size(200, 35);
            this.txt_update_qty.TabIndex = 12;
            // 
            // lbl_qty
            // 
            this.lbl_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Location = new System.Drawing.Point(1116, 102);
            this.lbl_qty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(183, 29);
            this.lbl_qty.TabIndex = 11;
            this.lbl_qty.Text = "Order Quantity";
            // 
            // lbl_order_date
            // 
            this.lbl_order_date.AutoSize = true;
            this.lbl_order_date.Location = new System.Drawing.Point(15, 22);
            this.lbl_order_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_order_date.Name = "lbl_order_date";
            this.lbl_order_date.Size = new System.Drawing.Size(142, 29);
            this.lbl_order_date.TabIndex = 10;
            this.lbl_order_date.Text = "Order Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 18);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 35);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // btn_print_supp
            // 
            this.btn_print_supp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print_supp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print_supp.Location = new System.Drawing.Point(1000, 631);
            this.btn_print_supp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_print_supp.Name = "btn_print_supp";
            this.btn_print_supp.Size = new System.Drawing.Size(231, 55);
            this.btn_print_supp.TabIndex = 8;
            this.btn_print_supp.Text = "Print Form";
            this.btn_print_supp.UseVisualStyleBackColor = true;
            this.btn_print_supp.Click += new System.EventHandler(this.btn_print_supp_Click);
            // 
            // txt_supp_total
            // 
            this.txt_supp_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_supp_total.Location = new System.Drawing.Point(1122, 525);
            this.txt_supp_total.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_supp_total.Name = "txt_supp_total";
            this.txt_supp_total.Size = new System.Drawing.Size(200, 35);
            this.txt_supp_total.TabIndex = 4;
            // 
            // lbl_supp_total
            // 
            this.lbl_supp_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_supp_total.AutoSize = true;
            this.lbl_supp_total.Location = new System.Drawing.Point(1116, 489);
            this.lbl_supp_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_supp_total.Name = "lbl_supp_total";
            this.lbl_supp_total.Size = new System.Drawing.Size(73, 29);
            this.lbl_supp_total.TabIndex = 3;
            this.lbl_supp_total.Text = "Total";
            // 
            // lbl_supplier
            // 
            this.lbl_supplier.AutoSize = true;
            this.lbl_supplier.Location = new System.Drawing.Point(520, 22);
            this.lbl_supplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_supplier.Name = "lbl_supplier";
            this.lbl_supplier.Size = new System.Drawing.Size(112, 29);
            this.lbl_supplier.TabIndex = 2;
            this.lbl_supplier.Text = "Supplier";
            // 
            // cbx_supplier
            // 
            this.cbx_supplier.FormattingEnabled = true;
            this.cbx_supplier.Location = new System.Drawing.Point(642, 17);
            this.cbx_supplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_supplier.Name = "cbx_supplier";
            this.cbx_supplier.Size = new System.Drawing.Size(388, 37);
            this.cbx_supplier.TabIndex = 1;
            this.cbx_supplier.SelectedIndexChanged += new System.EventHandler(this.cbx_supplier_SelectedIndexChanged);
            // 
            // supp_dataGrid
            // 
            this.supp_dataGrid.AllowUserToAddRows = false;
            this.supp_dataGrid.AllowUserToDeleteRows = false;
            this.supp_dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.supp_dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.supp_dataGrid.Location = new System.Drawing.Point(9, 102);
            this.supp_dataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.supp_dataGrid.Name = "supp_dataGrid";
            this.supp_dataGrid.ReadOnly = true;
            this.supp_dataGrid.RowHeadersVisible = false;
            this.supp_dataGrid.RowHeadersWidth = 62;
            this.supp_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.supp_dataGrid.Size = new System.Drawing.Size(1094, 462);
            this.supp_dataGrid.TabIndex = 0;
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
            // orderqty
            // 
            this.orderqty.DataPropertyName = "orderqty";
            this.orderqty.HeaderText = "Order Qty";
            this.orderqty.MinimumWidth = 8;
            this.orderqty.Name = "orderqty";
            this.orderqty.ReadOnly = true;
            // 
            // cust_request
            // 
            this.cust_request.Controls.Add(this.textBox_CustomerName);
            this.cust_request.Controls.Add(this.lst_customer);
            this.cust_request.Controls.Add(this.btn_prod_delete);
            this.cust_request.Controls.Add(this.btn_prod_add);
            this.cust_request.Controls.Add(this.txt_prod_name);
            this.cust_request.Controls.Add(this.lbl_prod_name);
            this.cust_request.Controls.Add(this.request_dataGrid);
            this.cust_request.Location = new System.Drawing.Point(4, 38);
            this.cust_request.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cust_request.Name = "cust_request";
            this.cust_request.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cust_request.Size = new System.Drawing.Size(1484, 704);
            this.cust_request.TabIndex = 1;
            this.cust_request.Text = "Customer Request";
            this.cust_request.UseVisualStyleBackColor = true;
            // 
            // textBox_CustomerName
            // 
            this.textBox_CustomerName.Location = new System.Drawing.Point(15, 17);
            this.textBox_CustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_CustomerName.Name = "textBox_CustomerName";
            this.textBox_CustomerName.Size = new System.Drawing.Size(506, 35);
            this.textBox_CustomerName.TabIndex = 8;
            this.textBox_CustomerName.Text = "Search for customer";
            this.textBox_CustomerName.TextChanged += new System.EventHandler(this.textBox_CustomerName_TextChanged);
            this.textBox_CustomerName.Enter += new System.EventHandler(this.textBox_CustomerName_Enter);
            this.textBox_CustomerName.Leave += new System.EventHandler(this.textBox_CustomerName_Leave);
            // 
            // lst_customer
            // 
            this.lst_customer.FormattingEnabled = true;
            this.lst_customer.ItemHeight = 29;
            this.lst_customer.Location = new System.Drawing.Point(15, 80);
            this.lst_customer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst_customer.Name = "lst_customer";
            this.lst_customer.Size = new System.Drawing.Size(506, 207);
            this.lst_customer.TabIndex = 7;
            // 
            // btn_prod_delete
            // 
            this.btn_prod_delete.Location = new System.Drawing.Point(568, 589);
            this.btn_prod_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_prod_delete.Name = "btn_prod_delete";
            this.btn_prod_delete.Size = new System.Drawing.Size(231, 55);
            this.btn_prod_delete.TabIndex = 6;
            this.btn_prod_delete.Text = "Remove";
            this.btn_prod_delete.UseVisualStyleBackColor = true;
            this.btn_prod_delete.Click += new System.EventHandler(this.btn_prod_delete_Click);
            // 
            // btn_prod_add
            // 
            this.btn_prod_add.Location = new System.Drawing.Point(1240, 589);
            this.btn_prod_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_prod_add.Name = "btn_prod_add";
            this.btn_prod_add.Size = new System.Drawing.Size(231, 55);
            this.btn_prod_add.TabIndex = 5;
            this.btn_prod_add.Text = "Add";
            this.btn_prod_add.UseVisualStyleBackColor = true;
            this.btn_prod_add.Click += new System.EventHandler(this.btn_prod_add_Click);
            // 
            // txt_prod_name
            // 
            this.txt_prod_name.Location = new System.Drawing.Point(777, 17);
            this.txt_prod_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_prod_name.Name = "txt_prod_name";
            this.txt_prod_name.Size = new System.Drawing.Size(448, 35);
            this.txt_prod_name.TabIndex = 4;
            // 
            // lbl_prod_name
            // 
            this.lbl_prod_name.AutoSize = true;
            this.lbl_prod_name.Location = new System.Drawing.Point(562, 22);
            this.lbl_prod_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_prod_name.Name = "lbl_prod_name";
            this.lbl_prod_name.Size = new System.Drawing.Size(179, 29);
            this.lbl_prod_name.TabIndex = 3;
            this.lbl_prod_name.Text = "Product Name";
            // 
            // request_dataGrid
            // 
            this.request_dataGrid.AllowUserToAddRows = false;
            this.request_dataGrid.AllowUserToDeleteRows = false;
            this.request_dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.request_dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.request_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.request_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_id,
            this.note_id,
            this.note_date,
            this.customer_names,
            this.prod_name});
            this.request_dataGrid.Location = new System.Drawing.Point(568, 80);
            this.request_dataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.request_dataGrid.Name = "request_dataGrid";
            this.request_dataGrid.ReadOnly = true;
            this.request_dataGrid.RowHeadersVisible = false;
            this.request_dataGrid.RowHeadersWidth = 62;
            this.request_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.request_dataGrid.Size = new System.Drawing.Size(903, 500);
            this.request_dataGrid.TabIndex = 0;
            // 
            // customer_id
            // 
            this.customer_id.DataPropertyName = "customer_id";
            this.customer_id.HeaderText = "CustomerID";
            this.customer_id.MinimumWidth = 8;
            this.customer_id.Name = "customer_id";
            this.customer_id.ReadOnly = true;
            this.customer_id.Visible = false;
            // 
            // note_id
            // 
            this.note_id.DataPropertyName = "note_id";
            this.note_id.HeaderText = "NoteID";
            this.note_id.MinimumWidth = 8;
            this.note_id.Name = "note_id";
            this.note_id.ReadOnly = true;
            this.note_id.Visible = false;
            // 
            // note_date
            // 
            this.note_date.DataPropertyName = "note_date";
            this.note_date.HeaderText = "NoteDate";
            this.note_date.MinimumWidth = 8;
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
            // 
            // prod_name
            // 
            this.prod_name.DataPropertyName = "prod_name";
            this.prod_name.HeaderText = "Product Name";
            this.prod_name.MinimumWidth = 8;
            this.prod_name.Name = "prod_name";
            this.prod_name.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.cust_request);
            this.tabControl1.Controls.Add(this.supp_order);
            this.tabControl1.Controls.Add(this.cust_order);
            this.tabControl1.Controls.Add(this.Fullfillment);
            this.tabControl1.Controls.Add(this.History);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(18, 18);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1492, 746);
            this.tabControl1.TabIndex = 0;
            // 
            // cust_order
            // 
            this.cust_order.Controls.Add(this.btnAddOrder);
            this.cust_order.Controls.Add(this.btnFavoritesRemove);
            this.cust_order.Controls.Add(this.btnFavoritesAdd);
            this.cust_order.Controls.Add(this.btn_update_custorder);
            this.cust_order.Controls.Add(this.lbl_supp_custorder);
            this.cust_order.Controls.Add(this.cbx_supp_custorder);
            this.cust_order.Controls.Add(this.lbl_qty_custorder);
            this.cust_order.Controls.Add(this.txt_orderqty_custorder);
            this.cust_order.Controls.Add(this.custOrder_datagrid);
            this.cust_order.Controls.Add(this.lbl_cust_custorder);
            this.cust_order.Controls.Add(this.cbx_cust_custorder);
            this.cust_order.Location = new System.Drawing.Point(4, 38);
            this.cust_order.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cust_order.Name = "cust_order";
            this.cust_order.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cust_order.Size = new System.Drawing.Size(1484, 704);
            this.cust_order.TabIndex = 5;
            this.cust_order.Text = "Customer Order";
            this.cust_order.UseVisualStyleBackColor = true;
            // 
            // btn_update_custorder
            // 
            this.btn_update_custorder.Location = new System.Drawing.Point(1113, 608);
            this.btn_update_custorder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_update_custorder.Name = "btn_update_custorder";
            this.btn_update_custorder.Size = new System.Drawing.Size(267, 62);
            this.btn_update_custorder.TabIndex = 7;
            this.btn_update_custorder.Text = "Update Qty";
            this.btn_update_custorder.UseVisualStyleBackColor = true;
            // 
            // lbl_supp_custorder
            // 
            this.lbl_supp_custorder.AutoSize = true;
            this.lbl_supp_custorder.Location = new System.Drawing.Point(562, 25);
            this.lbl_supp_custorder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_supp_custorder.Name = "lbl_supp_custorder";
            this.lbl_supp_custorder.Size = new System.Drawing.Size(119, 29);
            this.lbl_supp_custorder.TabIndex = 6;
            this.lbl_supp_custorder.Text = "Supplier:";
            // 
            // cbx_supp_custorder
            // 
            this.cbx_supp_custorder.DisplayMember = "Name";
            this.cbx_supp_custorder.FormattingEnabled = true;
            this.cbx_supp_custorder.Location = new System.Drawing.Point(692, 20);
            this.cbx_supp_custorder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_supp_custorder.Name = "cbx_supp_custorder";
            this.cbx_supp_custorder.Size = new System.Drawing.Size(370, 37);
            this.cbx_supp_custorder.TabIndex = 5;
            // 
            // lbl_qty_custorder
            // 
            this.lbl_qty_custorder.AutoSize = true;
            this.lbl_qty_custorder.Location = new System.Drawing.Point(1111, 513);
            this.lbl_qty_custorder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_qty_custorder.Name = "lbl_qty_custorder";
            this.lbl_qty_custorder.Size = new System.Drawing.Size(134, 29);
            this.lbl_qty_custorder.TabIndex = 4;
            this.lbl_qty_custorder.Text = "Order Qty:";
            // 
            // txt_orderqty_custorder
            // 
            this.txt_orderqty_custorder.Location = new System.Drawing.Point(1117, 548);
            this.txt_orderqty_custorder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_orderqty_custorder.Name = "txt_orderqty_custorder";
            this.txt_orderqty_custorder.Size = new System.Drawing.Size(265, 35);
            this.txt_orderqty_custorder.TabIndex = 3;
            // 
            // custOrder_datagrid
            // 
            this.custOrder_datagrid.AllowUserToAddRows = false;
            this.custOrder_datagrid.AllowUserToDeleteRows = false;
            this.custOrder_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custOrder_datagrid.Location = new System.Drawing.Point(15, 88);
            this.custOrder_datagrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custOrder_datagrid.Name = "custOrder_datagrid";
            this.custOrder_datagrid.ReadOnly = true;
            this.custOrder_datagrid.RowHeadersVisible = false;
            this.custOrder_datagrid.RowHeadersWidth = 62;
            this.custOrder_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.custOrder_datagrid.Size = new System.Drawing.Size(1083, 582);
            this.custOrder_datagrid.TabIndex = 2;
            // 
            // lbl_cust_custorder
            // 
            this.lbl_cust_custorder.AutoSize = true;
            this.lbl_cust_custorder.Location = new System.Drawing.Point(9, 25);
            this.lbl_cust_custorder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cust_custorder.Name = "lbl_cust_custorder";
            this.lbl_cust_custorder.Size = new System.Drawing.Size(139, 29);
            this.lbl_cust_custorder.TabIndex = 1;
            this.lbl_cust_custorder.Text = "Customer: ";
            // 
            // cbx_cust_custorder
            // 
            this.cbx_cust_custorder.DisplayMember = "FullName";
            this.cbx_cust_custorder.FormattingEnabled = true;
            this.cbx_cust_custorder.Location = new System.Drawing.Point(162, 20);
            this.cbx_cust_custorder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_cust_custorder.Name = "cbx_cust_custorder";
            this.cbx_cust_custorder.Size = new System.Drawing.Size(370, 37);
            this.cbx_cust_custorder.TabIndex = 0;
            this.cbx_cust_custorder.SelectedIndexChanged += new System.EventHandler(this.cbx_cust_custorder_SelectedIndexChanged);
            // 
            // Fullfillment
            // 
            this.Fullfillment.Controls.Add(this.btn_whole_assign_update);
            this.Fullfillment.Controls.Add(this.btn_whole_order_update);
            this.Fullfillment.Controls.Add(this.dateTimePicker2);
            this.Fullfillment.Controls.Add(this.lbl_assignqty);
            this.Fullfillment.Controls.Add(this.txt_receivqty);
            this.Fullfillment.Controls.Add(this.lbl_whole_orderqty);
            this.Fullfillment.Controls.Add(this.txt_whole_orderqty);
            this.Fullfillment.Controls.Add(this.lbl_whole_cust);
            this.Fullfillment.Controls.Add(this.cbx_fullfill_cust);
            this.Fullfillment.Controls.Add(this.fullfill_datagrid);
            this.Fullfillment.Location = new System.Drawing.Point(4, 38);
            this.Fullfillment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Fullfillment.Name = "Fullfillment";
            this.Fullfillment.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Fullfillment.Size = new System.Drawing.Size(1484, 704);
            this.Fullfillment.TabIndex = 4;
            this.Fullfillment.Text = "Fullfillment";
            this.Fullfillment.UseVisualStyleBackColor = true;
            // 
            // btn_whole_assign_update
            // 
            this.btn_whole_assign_update.Location = new System.Drawing.Point(1202, 414);
            this.btn_whole_assign_update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_whole_assign_update.Name = "btn_whole_assign_update";
            this.btn_whole_assign_update.Size = new System.Drawing.Size(255, 55);
            this.btn_whole_assign_update.TabIndex = 11;
            this.btn_whole_assign_update.Text = "Delivered Update";
            this.btn_whole_assign_update.UseVisualStyleBackColor = true;
            // 
            // btn_whole_order_update
            // 
            this.btn_whole_order_update.Location = new System.Drawing.Point(1202, 222);
            this.btn_whole_order_update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_whole_order_update.Name = "btn_whole_order_update";
            this.btn_whole_order_update.Size = new System.Drawing.Size(255, 55);
            this.btn_whole_order_update.TabIndex = 10;
            this.btn_whole_order_update.Text = "Order Update";
            this.btn_whole_order_update.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(615, 22);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(298, 35);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // lbl_assignqty
            // 
            this.lbl_assignqty.AutoSize = true;
            this.lbl_assignqty.Location = new System.Drawing.Point(1196, 329);
            this.lbl_assignqty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_assignqty.Name = "lbl_assignqty";
            this.lbl_assignqty.Size = new System.Drawing.Size(179, 29);
            this.lbl_assignqty.TabIndex = 8;
            this.lbl_assignqty.Text = "Qty Delivered:";
            // 
            // txt_receivqty
            // 
            this.txt_receivqty.Location = new System.Drawing.Point(1202, 365);
            this.txt_receivqty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_receivqty.Name = "txt_receivqty";
            this.txt_receivqty.Size = new System.Drawing.Size(200, 35);
            this.txt_receivqty.TabIndex = 7;
            // 
            // lbl_whole_orderqty
            // 
            this.lbl_whole_orderqty.AutoSize = true;
            this.lbl_whole_orderqty.Location = new System.Drawing.Point(1196, 137);
            this.lbl_whole_orderqty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_whole_orderqty.Name = "lbl_whole_orderqty";
            this.lbl_whole_orderqty.Size = new System.Drawing.Size(134, 29);
            this.lbl_whole_orderqty.TabIndex = 6;
            this.lbl_whole_orderqty.Text = "Order Qty:";
            // 
            // txt_whole_orderqty
            // 
            this.txt_whole_orderqty.Location = new System.Drawing.Point(1202, 172);
            this.txt_whole_orderqty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_whole_orderqty.Name = "txt_whole_orderqty";
            this.txt_whole_orderqty.Size = new System.Drawing.Size(200, 35);
            this.txt_whole_orderqty.TabIndex = 5;
            // 
            // lbl_whole_cust
            // 
            this.lbl_whole_cust.AutoSize = true;
            this.lbl_whole_cust.Location = new System.Drawing.Point(9, 26);
            this.lbl_whole_cust.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_whole_cust.Name = "lbl_whole_cust";
            this.lbl_whole_cust.Size = new System.Drawing.Size(132, 29);
            this.lbl_whole_cust.TabIndex = 3;
            this.lbl_whole_cust.Text = "Customer:";
            // 
            // cbx_fullfill_cust
            // 
            this.cbx_fullfill_cust.FormattingEnabled = true;
            this.cbx_fullfill_cust.Location = new System.Drawing.Point(154, 22);
            this.cbx_fullfill_cust.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_fullfill_cust.Name = "cbx_fullfill_cust";
            this.cbx_fullfill_cust.Size = new System.Drawing.Size(388, 37);
            this.cbx_fullfill_cust.TabIndex = 2;
            // 
            // fullfill_datagrid
            // 
            this.fullfill_datagrid.AllowUserToAddRows = false;
            this.fullfill_datagrid.AllowUserToDeleteRows = false;
            this.fullfill_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fullfill_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fid,
            this.fbarcode,
            this.fname,
            this.ftype,
            this.fqty,
            this.fprice,
            this.fmin,
            this.fmax,
            this.forderqty});
            this.fullfill_datagrid.Location = new System.Drawing.Point(15, 137);
            this.fullfill_datagrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fullfill_datagrid.Name = "fullfill_datagrid";
            this.fullfill_datagrid.ReadOnly = true;
            this.fullfill_datagrid.RowHeadersVisible = false;
            this.fullfill_datagrid.RowHeadersWidth = 62;
            this.fullfill_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fullfill_datagrid.Size = new System.Drawing.Size(1158, 462);
            this.fullfill_datagrid.TabIndex = 0;
            // 
            // fid
            // 
            this.fid.DataPropertyName = "fid";
            this.fid.HeaderText = "Id";
            this.fid.MinimumWidth = 8;
            this.fid.Name = "fid";
            this.fid.ReadOnly = true;
            this.fid.Visible = false;
            this.fid.Width = 150;
            // 
            // fbarcode
            // 
            this.fbarcode.DataPropertyName = "fbarcode";
            this.fbarcode.HeaderText = "Barcode";
            this.fbarcode.MinimumWidth = 8;
            this.fbarcode.Name = "fbarcode";
            this.fbarcode.ReadOnly = true;
            this.fbarcode.Width = 200;
            // 
            // fname
            // 
            this.fname.DataPropertyName = "fname";
            this.fname.HeaderText = "Name";
            this.fname.MinimumWidth = 8;
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            this.fname.Width = 400;
            // 
            // ftype
            // 
            this.ftype.DataPropertyName = "ftype";
            this.ftype.HeaderText = "Type";
            this.ftype.MinimumWidth = 8;
            this.ftype.Name = "ftype";
            this.ftype.ReadOnly = true;
            this.ftype.Visible = false;
            this.ftype.Width = 150;
            // 
            // fqty
            // 
            this.fqty.DataPropertyName = "fqty";
            this.fqty.HeaderText = "Qty";
            this.fqty.MinimumWidth = 8;
            this.fqty.Name = "fqty";
            this.fqty.ReadOnly = true;
            this.fqty.Width = 80;
            // 
            // fprice
            // 
            this.fprice.DataPropertyName = "fprice";
            this.fprice.HeaderText = "Price";
            this.fprice.MinimumWidth = 8;
            this.fprice.Name = "fprice";
            this.fprice.ReadOnly = true;
            this.fprice.Width = 90;
            // 
            // fmin
            // 
            this.fmin.DataPropertyName = "fmin";
            this.fmin.HeaderText = "Min";
            this.fmin.MinimumWidth = 8;
            this.fmin.Name = "fmin";
            this.fmin.ReadOnly = true;
            this.fmin.Visible = false;
            this.fmin.Width = 150;
            // 
            // fmax
            // 
            this.fmax.DataPropertyName = "fmax";
            this.fmax.HeaderText = "Max";
            this.fmax.MinimumWidth = 8;
            this.fmax.Name = "fmax";
            this.fmax.ReadOnly = true;
            this.fmax.Visible = false;
            this.fmax.Width = 150;
            // 
            // forderqty
            // 
            this.forderqty.DataPropertyName = "forderqty";
            this.forderqty.HeaderText = "Order Qty";
            this.forderqty.MinimumWidth = 8;
            this.forderqty.Name = "forderqty";
            this.forderqty.ReadOnly = true;
            this.forderqty.Visible = false;
            this.forderqty.Width = 80;
            // 
            // History
            // 
            this.History.Controls.Add(this.textBox_CustomerName_History);
            this.History.Controls.Add(this.btn_setDate);
            this.History.Controls.Add(this.btn_setCust);
            this.History.Controls.Add(this.lbl_orders);
            this.History.Controls.Add(this.btn_reset);
            this.History.Controls.Add(this.btn_print);
            this.History.Controls.Add(this.lstbox_customer);
            this.History.Controls.Add(this.transaction_dataGrid);
            this.History.Controls.Add(this.lbl_end);
            this.History.Controls.Add(this.end_dateTime);
            this.History.Controls.Add(this.lbl_start);
            this.History.Controls.Add(this.start_dateTime);
            this.History.Location = new System.Drawing.Point(4, 38);
            this.History.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.History.Name = "History";
            this.History.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.History.Size = new System.Drawing.Size(1484, 704);
            this.History.TabIndex = 3;
            this.History.Text = "History";
            this.History.UseVisualStyleBackColor = true;
            // 
            // textBox_CustomerName_History
            // 
            this.textBox_CustomerName_History.Location = new System.Drawing.Point(15, 28);
            this.textBox_CustomerName_History.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_CustomerName_History.Name = "textBox_CustomerName_History";
            this.textBox_CustomerName_History.Size = new System.Drawing.Size(512, 35);
            this.textBox_CustomerName_History.TabIndex = 13;
            this.textBox_CustomerName_History.Text = "Search for customer";
            this.textBox_CustomerName_History.TextChanged += new System.EventHandler(this.textBox_CustomerName_History_TextChanged);
            // 
            // btn_setDate
            // 
            this.btn_setDate.Location = new System.Drawing.Point(1080, 25);
            this.btn_setDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_setDate.Name = "btn_setDate";
            this.btn_setDate.Size = new System.Drawing.Size(268, 74);
            this.btn_setDate.TabIndex = 12;
            this.btn_setDate.Text = "Set Date Range";
            this.btn_setDate.UseVisualStyleBackColor = true;
            this.btn_setDate.Click += new System.EventHandler(this.btn_setDate_Click);
            // 
            // btn_setCust
            // 
            this.btn_setCust.Location = new System.Drawing.Point(15, 326);
            this.btn_setCust.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_setCust.Name = "btn_setCust";
            this.btn_setCust.Size = new System.Drawing.Size(268, 74);
            this.btn_setCust.TabIndex = 11;
            this.btn_setCust.Text = "Set Customer";
            this.btn_setCust.UseVisualStyleBackColor = true;
            this.btn_setCust.Click += new System.EventHandler(this.btn_setCust_Click);
            // 
            // lbl_orders
            // 
            this.lbl_orders.AutoSize = true;
            this.lbl_orders.Location = new System.Drawing.Point(562, 157);
            this.lbl_orders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_orders.Name = "lbl_orders";
            this.lbl_orders.Size = new System.Drawing.Size(152, 29);
            this.lbl_orders.TabIndex = 10;
            this.lbl_orders.Text = "Past Orders";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(568, 574);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(268, 74);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(1080, 574);
            this.btn_print.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(268, 74);
            this.btn_print.TabIndex = 6;
            this.btn_print.Text = "View/Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // lstbox_customer
            // 
            this.lstbox_customer.FormattingEnabled = true;
            this.lstbox_customer.ItemHeight = 29;
            this.lstbox_customer.Location = new System.Drawing.Point(15, 88);
            this.lstbox_customer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstbox_customer.Name = "lstbox_customer";
            this.lstbox_customer.Size = new System.Drawing.Size(512, 207);
            this.lstbox_customer.TabIndex = 5;
            // 
            // transaction_dataGrid
            // 
            this.transaction_dataGrid.AllowUserToAddRows = false;
            this.transaction_dataGrid.AllowUserToDeleteRows = false;
            this.transaction_dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transaction_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transaction_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trans_id,
            this.trans_date,
            this.trans_total});
            this.transaction_dataGrid.Location = new System.Drawing.Point(568, 192);
            this.transaction_dataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.transaction_dataGrid.Name = "transaction_dataGrid";
            this.transaction_dataGrid.ReadOnly = true;
            this.transaction_dataGrid.RowHeadersVisible = false;
            this.transaction_dataGrid.RowHeadersWidth = 62;
            this.transaction_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transaction_dataGrid.Size = new System.Drawing.Size(780, 372);
            this.transaction_dataGrid.TabIndex = 4;
            this.transaction_dataGrid.SelectionChanged += new System.EventHandler(this.tranaction_dataGrid_SelectionChanged);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.trans_total.DefaultCellStyle = dataGridViewCellStyle2;
            this.trans_total.HeaderText = "Total";
            this.trans_total.MinimumWidth = 8;
            this.trans_total.Name = "trans_total";
            this.trans_total.ReadOnly = true;
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Location = new System.Drawing.Point(574, 95);
            this.lbl_end.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(59, 29);
            this.lbl_end.TabIndex = 3;
            this.lbl_end.Text = "End";
            // 
            // end_dateTime
            // 
            this.end_dateTime.Location = new System.Drawing.Point(645, 88);
            this.end_dateTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.end_dateTime.Name = "end_dateTime";
            this.end_dateTime.Size = new System.Drawing.Size(424, 35);
            this.end_dateTime.TabIndex = 2;
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Location = new System.Drawing.Point(562, 32);
            this.lbl_start.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(67, 29);
            this.lbl_start.TabIndex = 1;
            this.lbl_start.Text = "Start";
            // 
            // start_dateTime
            // 
            this.start_dateTime.Location = new System.Drawing.Point(645, 25);
            this.start_dateTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.start_dateTime.Name = "start_dateTime";
            this.start_dateTime.Size = new System.Drawing.Size(424, 35);
            this.start_dateTime.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(477, 774);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(574, 55);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btnFavoritesAdd
            // 
            this.btnFavoritesAdd.Location = new System.Drawing.Point(1115, 88);
            this.btnFavoritesAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFavoritesAdd.Name = "btnFavoritesAdd";
            this.btnFavoritesAdd.Size = new System.Drawing.Size(267, 62);
            this.btnFavoritesAdd.TabIndex = 8;
            this.btnFavoritesAdd.Text = "Add Favorite";
            this.btnFavoritesAdd.UseVisualStyleBackColor = true;
            this.btnFavoritesAdd.Click += new System.EventHandler(this.btnFavoritesAdd_Click);
            // 
            // btnFavoritesRemove
            // 
            this.btnFavoritesRemove.Location = new System.Drawing.Point(1115, 160);
            this.btnFavoritesRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFavoritesRemove.Name = "btnFavoritesRemove";
            this.btnFavoritesRemove.Size = new System.Drawing.Size(267, 62);
            this.btnFavoritesRemove.TabIndex = 9;
            this.btnFavoritesRemove.Text = "Remove Favorite";
            this.btnFavoritesRemove.UseVisualStyleBackColor = true;
            this.btnFavoritesRemove.Click += new System.EventHandler(this.btnFavoritesRemove_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(1115, 232);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(267, 62);
            this.btnAddOrder.TabIndex = 10;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1528, 846);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrders";
            this.supp_order.ResumeLayout(false);
            this.supp_order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supp_dataGrid)).EndInit();
            this.cust_request.ResumeLayout(false);
            this.cust_request.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.request_dataGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.cust_order.ResumeLayout(false);
            this.cust_order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custOrder_datagrid)).EndInit();
            this.Fullfillment.ResumeLayout(false);
            this.Fullfillment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullfill_datagrid)).EndInit();
            this.History.ResumeLayout(false);
            this.History.PerformLayout();
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
        private System.Windows.Forms.TabPage History;
        private System.Windows.Forms.ListBox lstbox_customer;
        private System.Windows.Forms.DataGridView transaction_dataGrid;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.DateTimePicker end_dateTime;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.DateTimePicker start_dateTime;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_print;
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
        private System.Windows.Forms.Button btn_recived;
        private System.Windows.Forms.TabPage Fullfillment;
        private System.Windows.Forms.DataGridView fullfill_datagrid;
        private System.Windows.Forms.TextBox txt_whole_orderqty;
        private System.Windows.Forms.Label lbl_whole_cust;
        private System.Windows.Forms.ComboBox cbx_fullfill_cust;
        private System.Windows.Forms.Label lbl_whole_orderqty;
        private System.Windows.Forms.Label lbl_assignqty;
        private System.Windows.Forms.TextBox txt_receivqty;
        private System.Windows.Forms.Button btn_whole_assign_update;
        private System.Windows.Forms.Button btn_whole_order_update;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fbarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ftype;
        private System.Windows.Forms.DataGridViewTextBoxColumn fqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn fprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn fmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn fmax;
        private System.Windows.Forms.DataGridViewTextBoxColumn forderqty;
        private System.Windows.Forms.TabPage cust_order;
        private System.Windows.Forms.Button btn_update_custorder;
        private System.Windows.Forms.Label lbl_supp_custorder;
        private System.Windows.Forms.ComboBox cbx_supp_custorder;
        private System.Windows.Forms.Label lbl_qty_custorder;
        private System.Windows.Forms.TextBox txt_orderqty_custorder;
        private System.Windows.Forms.DataGridView custOrder_datagrid;
        private System.Windows.Forms.Label lbl_cust_custorder;
        private System.Windows.Forms.ComboBox cbx_cust_custorder;
		private System.Windows.Forms.TextBox textBox_CustomerName;
		private System.Windows.Forms.TextBox textBox_CustomerName_History;
        private System.Windows.Forms.Button btnFavoritesRemove;
        private System.Windows.Forms.Button btnFavoritesAdd;
        private System.Windows.Forms.Button btnAddOrder;
    }
}