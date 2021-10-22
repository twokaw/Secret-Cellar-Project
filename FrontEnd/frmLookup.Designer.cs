namespace SecretCellar
{
    partial class frmLookup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLookup));
            this.txtlookup = new System.Windows.Forms.TextBox();
            this.LookupView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxTypeFilter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxSupplyFilter = new System.Windows.Forms.ComboBox();
            this.lblSupplyFilter = new System.Windows.Forms.Label();
            this.cbxOnlyItemsWithInventory = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_Supplier = new System.Windows.Forms.ComboBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.barcode_label = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.Price_txt = new System.Windows.Forms.Label();
            this.txt_net_price = new System.Windows.Forms.TextBox();
            this.lbl_netPrice = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.txtProd_Qty = new System.Windows.Forms.TextBox();
            this.Btl_Dep_Lb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clear_info = new System.Windows.Forms.Button();
            this.chk_hide_item = new System.Windows.Forms.CheckBox();
            this.lbl_max_qty = new System.Windows.Forms.Label();
            this.lbl_order_qty = new System.Windows.Forms.Label();
            this.txt_max_qty = new System.Windows.Forms.TextBox();
            this.txt_order_qty = new System.Windows.Forms.TextBox();
            this.lbl_min = new System.Windows.Forms.Label();
            this.txt_min_qty = new System.Windows.Forms.TextBox();
            this.lbl_markup = new System.Windows.Forms.Label();
            this.txt_markup = new System.Windows.Forms.TextBox();
            this.checkListBox_Discounts = new System.Windows.Forms.CheckedListBox();
            this.label_CaseDiscount = new System.Windows.Forms.Label();
            this.chk_box_show_hidden = new System.Windows.Forms.CheckBox();
            this.button_Broken = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LookupView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtlookup
            // 
            this.txtlookup.Location = new System.Drawing.Point(20, 23);
            this.txtlookup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtlookup.Name = "txtlookup";
            this.txtlookup.Size = new System.Drawing.Size(227, 22);
            this.txtlookup.TabIndex = 1;
            this.txtlookup.WordWrap = false;
            this.txtlookup.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtlookup.Enter += new System.EventHandler(this.txtlookup_Enter);
            this.txtlookup.Leave += new System.EventHandler(this.txtlookup_Leave);
            // 
            // LookupView
            // 
            this.LookupView.AllowUserToAddRows = false;
            this.LookupView.AllowUserToDeleteRows = false;
            this.LookupView.AllowUserToResizeColumns = false;
            this.LookupView.AllowUserToResizeRows = false;
            this.LookupView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LookupView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LookupView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.LookupView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LookupView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Description,
            this.Class,
            this.Barcode,
            this.Qty,
            this.Price,
            this.minqty,
            this.orderqty,
            this.maxqty});
            this.LookupView.Location = new System.Drawing.Point(0, 0);
            this.LookupView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LookupView.MultiSelect = false;
            this.LookupView.Name = "LookupView";
            this.LookupView.ReadOnly = true;
            this.LookupView.RowHeadersVisible = false;
            this.LookupView.RowHeadersWidth = 62;
            this.LookupView.RowTemplate.Height = 24;
            this.LookupView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LookupView.Size = new System.Drawing.Size(645, 583);
            this.LookupView.TabIndex = 0;
            this.LookupView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LookupView_CellContentClick);
            this.LookupView.SelectionChanged += new System.EventHandler(this.LookupView_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ItemId";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Name";
            this.Description.FillWeight = 200F;
            this.Description.HeaderText = "Name";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Class
            // 
            this.Class.DataPropertyName = "ItemType";
            this.Class.HeaderText = "Class";
            this.Class.MinimumWidth = 8;
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            // 
            // Barcode
            // 
            this.Barcode.DataPropertyName = "Barcode";
            this.Barcode.FillWeight = 150F;
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.MinimumWidth = 8;
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "Qty";
            this.Qty.HeaderText = "Qty";
            this.Qty.MinimumWidth = 8;
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Price.DefaultCellStyle = dataGridViewCellStyle2;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // minqty
            // 
            this.minqty.DataPropertyName = "minqty";
            this.minqty.FillWeight = 150F;
            this.minqty.HeaderText = "Min Qty";
            this.minqty.MinimumWidth = 8;
            this.minqty.Name = "minqty";
            this.minqty.ReadOnly = true;
            // 
            // orderqty
            // 
            this.orderqty.DataPropertyName = "orderqty";
            this.orderqty.FillWeight = 175F;
            this.orderqty.HeaderText = "Order Qty";
            this.orderqty.MinimumWidth = 8;
            this.orderqty.Name = "orderqty";
            this.orderqty.ReadOnly = true;
            // 
            // maxqty
            // 
            this.maxqty.DataPropertyName = "maxqty";
            this.maxqty.FillWeight = 155F;
            this.maxqty.HeaderText = "Max Qty";
            this.maxqty.MinimumWidth = 8;
            this.maxqty.Name = "maxqty";
            this.maxqty.ReadOnly = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(20, 664);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(141, 37);
            this.btn_cancel.TabIndex = 22;
            this.btn_cancel.Text = "CLOSE WINDOW";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(877, 664);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(142, 37);
            this.btn_add.TabIndex = 23;
            this.btn_add.Text = "ADD ITEM";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.LookupView);
            this.panel1.Location = new System.Drawing.Point(20, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 585);
            this.panel1.TabIndex = 7;
            // 
            // cbxTypeFilter
            // 
            this.cbxTypeFilter.DisplayMember = "TypeName";
            this.cbxTypeFilter.FormattingEnabled = true;
            this.cbxTypeFilter.Location = new System.Drawing.Point(282, 23);
            this.cbxTypeFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxTypeFilter.Name = "cbxTypeFilter";
            this.cbxTypeFilter.Size = new System.Drawing.Size(180, 24);
            this.cbxTypeFilter.TabIndex = 2;
            this.cbxTypeFilter.SelectedIndexChanged += new System.EventHandler(this.cbxTypeFilter_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(279, 2);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Type: ";
            // 
            // cbxSupplyFilter
            // 
            this.cbxSupplyFilter.DisplayMember = "Name";
            this.cbxSupplyFilter.FormattingEnabled = true;
            this.cbxSupplyFilter.Location = new System.Drawing.Point(494, 23);
            this.cbxSupplyFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxSupplyFilter.Name = "cbxSupplyFilter";
            this.cbxSupplyFilter.Size = new System.Drawing.Size(180, 24);
            this.cbxSupplyFilter.TabIndex = 3;
            this.cbxSupplyFilter.SelectedIndexChanged += new System.EventHandler(this.cbxSupplyFilter_SelectedIndexChanged);
            // 
            // lblSupplyFilter
            // 
            this.lblSupplyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplyFilter.Location = new System.Drawing.Point(491, 2);
            this.lblSupplyFilter.Margin = new System.Windows.Forms.Padding(0);
            this.lblSupplyFilter.Name = "lblSupplyFilter";
            this.lblSupplyFilter.Size = new System.Drawing.Size(183, 17);
            this.lblSupplyFilter.TabIndex = 12;
            this.lblSupplyFilter.Text = "Supplier:";
            // 
            // cbxOnlyItemsWithInventory
            // 
            this.cbxOnlyItemsWithInventory.AutoSize = true;
            this.cbxOnlyItemsWithInventory.Location = new System.Drawing.Point(691, 25);
            this.cbxOnlyItemsWithInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxOnlyItemsWithInventory.Name = "cbxOnlyItemsWithInventory";
            this.cbxOnlyItemsWithInventory.Size = new System.Drawing.Size(200, 20);
            this.cbxOnlyItemsWithInventory.TabIndex = 4;
            this.cbxOnlyItemsWithInventory.Text = "Only Items WIth Inventory";
            this.cbxOnlyItemsWithInventory.UseVisualStyleBackColor = true;
            this.cbxOnlyItemsWithInventory.CheckedChanged += new System.EventHandler(this.cbxOnlyItemsWithInventory_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(36, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Type:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_qty
            // 
            this.txt_qty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_qty.Location = new System.Drawing.Point(157, 152);
            this.txt_qty.Margin = new System.Windows.Forms.Padding(0);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(186, 22);
            this.txt_qty.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(36, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Qty:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(36, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(157, 28);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 22);
            this.txtName.TabIndex = 7;
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(-1, 548);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(142, 37);
            this.btn_update.TabIndex = 21;
            this.btn_update.Text = "UPDATE ITEM";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // cboType
            // 
            this.cboType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboType.DisplayMember = "TypeName";
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(157, 58);
            this.cboType.Margin = new System.Windows.Forms.Padding(0);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(186, 24);
            this.cboType.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(36, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Supplier:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbo_Supplier
            // 
            this.cbo_Supplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_Supplier.DisplayMember = "Name";
            this.cbo_Supplier.FormattingEnabled = true;
            this.cbo_Supplier.Location = new System.Drawing.Point(157, 120);
            this.cbo_Supplier.Margin = new System.Windows.Forms.Padding(0);
            this.cbo_Supplier.Name = "cbo_Supplier";
            this.cbo_Supplier.Size = new System.Drawing.Size(186, 24);
            this.cbo_Supplier.TabIndex = 10;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBarcode.Location = new System.Drawing.Point(157, 90);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(0);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(186, 22);
            this.txtBarcode.TabIndex = 9;
            // 
            // barcode_label
            // 
            this.barcode_label.Location = new System.Drawing.Point(36, 90);
            this.barcode_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.barcode_label.Name = "barcode_label";
            this.barcode_label.Size = new System.Drawing.Size(104, 25);
            this.barcode_label.TabIndex = 10;
            this.barcode_label.Text = "Barcode:";
            this.barcode_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.Location = new System.Drawing.Point(157, 182);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(0);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(186, 22);
            this.txtPrice.TabIndex = 12;
            // 
            // Price_txt
            // 
            this.Price_txt.Location = new System.Drawing.Point(36, 182);
            this.Price_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Price_txt.Name = "Price_txt";
            this.Price_txt.Size = new System.Drawing.Size(104, 25);
            this.Price_txt.TabIndex = 12;
            this.Price_txt.Text = "Price:";
            this.Price_txt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_net_price
            // 
            this.txt_net_price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_net_price.Location = new System.Drawing.Point(157, 242);
            this.txt_net_price.Margin = new System.Windows.Forms.Padding(0);
            this.txt_net_price.Name = "txt_net_price";
            this.txt_net_price.Size = new System.Drawing.Size(186, 22);
            this.txt_net_price.TabIndex = 14;
            // 
            // lbl_netPrice
            // 
            this.lbl_netPrice.Location = new System.Drawing.Point(36, 242);
            this.lbl_netPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_netPrice.Name = "lbl_netPrice";
            this.lbl_netPrice.Size = new System.Drawing.Size(104, 25);
            this.lbl_netPrice.TabIndex = 14;
            this.lbl_netPrice.Text = "My Price:";
            this.lbl_netPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_new
            // 
            this.btn_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(-1, 496);
            this.btn_new.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(141, 37);
            this.btn_new.TabIndex = 20;
            this.btn_new.Text = "NEW ITEM";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // txtProd_Qty
            // 
            this.txtProd_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProd_Qty.Location = new System.Drawing.Point(157, 272);
            this.txtProd_Qty.Margin = new System.Windows.Forms.Padding(0);
            this.txtProd_Qty.Name = "txtProd_Qty";
            this.txtProd_Qty.Size = new System.Drawing.Size(186, 22);
            this.txtProd_Qty.TabIndex = 15;
            // 
            // Btl_Dep_Lb
            // 
            this.Btl_Dep_Lb.Location = new System.Drawing.Point(36, 272);
            this.Btl_Dep_Lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Btl_Dep_Lb.Name = "Btl_Dep_Lb";
            this.Btl_Dep_Lb.Size = new System.Drawing.Size(104, 25);
            this.Btl_Dep_Lb.TabIndex = 17;
            this.Btl_Dep_Lb.Text = "Bottle Qty:";
            this.Btl_Dep_Lb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_clear_info);
            this.panel2.Controls.Add(this.chk_hide_item);
            this.panel2.Controls.Add(this.lbl_max_qty);
            this.panel2.Controls.Add(this.lbl_order_qty);
            this.panel2.Controls.Add(this.txt_max_qty);
            this.panel2.Controls.Add(this.txt_order_qty);
            this.panel2.Controls.Add(this.lbl_min);
            this.panel2.Controls.Add(this.txt_min_qty);
            this.panel2.Controls.Add(this.lbl_markup);
            this.panel2.Controls.Add(this.txt_markup);
            this.panel2.Controls.Add(this.checkListBox_Discounts);
            this.panel2.Controls.Add(this.label_CaseDiscount);
            this.panel2.Controls.Add(this.Btl_Dep_Lb);
            this.panel2.Controls.Add(this.txtProd_Qty);
            this.panel2.Controls.Add(this.btn_new);
            this.panel2.Controls.Add(this.lbl_netPrice);
            this.panel2.Controls.Add(this.txt_net_price);
            this.panel2.Controls.Add(this.Price_txt);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.barcode_label);
            this.panel2.Controls.Add(this.txtBarcode);
            this.panel2.Controls.Add(this.cbo_Supplier);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cboType);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_qty);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(673, 66);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 585);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(36, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Hidden:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_clear_info
            // 
            this.btn_clear_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_clear_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_info.Location = new System.Drawing.Point(-1, 444);
            this.btn_clear_info.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_clear_info.Name = "btn_clear_info";
            this.btn_clear_info.Size = new System.Drawing.Size(141, 37);
            this.btn_clear_info.TabIndex = 19;
            this.btn_clear_info.Text = "CLEAR";
            this.btn_clear_info.UseVisualStyleBackColor = true;
            this.btn_clear_info.Click += new System.EventHandler(this.btn_clear_info_Click);
            // 
            // chk_hide_item
            // 
            this.chk_hide_item.AutoSize = true;
            this.chk_hide_item.Location = new System.Drawing.Point(157, 6);
            this.chk_hide_item.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_hide_item.Name = "chk_hide_item";
            this.chk_hide_item.Size = new System.Drawing.Size(15, 14);
            this.chk_hide_item.TabIndex = 6;
            this.chk_hide_item.UseVisualStyleBackColor = true;
            // 
            // lbl_max_qty
            // 
            this.lbl_max_qty.Location = new System.Drawing.Point(36, 362);
            this.lbl_max_qty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_max_qty.Name = "lbl_max_qty";
            this.lbl_max_qty.Size = new System.Drawing.Size(104, 25);
            this.lbl_max_qty.TabIndex = 26;
            this.lbl_max_qty.Text = "Max Qty:";
            this.lbl_max_qty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_order_qty
            // 
            this.lbl_order_qty.Location = new System.Drawing.Point(36, 332);
            this.lbl_order_qty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_order_qty.Name = "lbl_order_qty";
            this.lbl_order_qty.Size = new System.Drawing.Size(104, 25);
            this.lbl_order_qty.TabIndex = 26;
            this.lbl_order_qty.Text = "Order Qty:";
            this.lbl_order_qty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_max_qty
            // 
            this.txt_max_qty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_max_qty.Location = new System.Drawing.Point(157, 362);
            this.txt_max_qty.Margin = new System.Windows.Forms.Padding(0);
            this.txt_max_qty.Name = "txt_max_qty";
            this.txt_max_qty.Size = new System.Drawing.Size(186, 22);
            this.txt_max_qty.TabIndex = 18;
            // 
            // txt_order_qty
            // 
            this.txt_order_qty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_order_qty.Location = new System.Drawing.Point(157, 332);
            this.txt_order_qty.Margin = new System.Windows.Forms.Padding(0);
            this.txt_order_qty.Name = "txt_order_qty";
            this.txt_order_qty.ReadOnly = true;
            this.txt_order_qty.Size = new System.Drawing.Size(186, 22);
            this.txt_order_qty.TabIndex = 17;
            this.txt_order_qty.TabStop = false;
            // 
            // lbl_min
            // 
            this.lbl_min.Location = new System.Drawing.Point(36, 302);
            this.lbl_min.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(104, 25);
            this.lbl_min.TabIndex = 24;
            this.lbl_min.Text = "Min Qty:";
            this.lbl_min.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_min_qty
            // 
            this.txt_min_qty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_min_qty.Location = new System.Drawing.Point(157, 302);
            this.txt_min_qty.Margin = new System.Windows.Forms.Padding(0);
            this.txt_min_qty.Name = "txt_min_qty";
            this.txt_min_qty.Size = new System.Drawing.Size(186, 22);
            this.txt_min_qty.TabIndex = 16;
            // 
            // lbl_markup
            // 
            this.lbl_markup.Location = new System.Drawing.Point(36, 211);
            this.lbl_markup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_markup.Name = "lbl_markup";
            this.lbl_markup.Size = new System.Drawing.Size(104, 25);
            this.lbl_markup.TabIndex = 22;
            this.lbl_markup.Text = "Markup %:";
            this.lbl_markup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_markup
            // 
            this.txt_markup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_markup.Location = new System.Drawing.Point(157, 212);
            this.txt_markup.Margin = new System.Windows.Forms.Padding(0);
            this.txt_markup.Name = "txt_markup";
            this.txt_markup.ReadOnly = true;
            this.txt_markup.Size = new System.Drawing.Size(186, 22);
            this.txt_markup.TabIndex = 13;
            this.txt_markup.TabStop = false;
            // 
            // checkListBox_Discounts
            // 
            this.checkListBox_Discounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkListBox_Discounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkListBox_Discounts.Enabled = false;
            this.checkListBox_Discounts.FormattingEnabled = true;
            this.checkListBox_Discounts.Location = new System.Drawing.Point(157, 398);
            this.checkListBox_Discounts.Margin = new System.Windows.Forms.Padding(0);
            this.checkListBox_Discounts.MaximumSize = new System.Drawing.Size(200, 400);
            this.checkListBox_Discounts.Name = "checkListBox_Discounts";
            this.checkListBox_Discounts.Size = new System.Drawing.Size(186, 170);
            this.checkListBox_Discounts.TabIndex = 20;
            // 
            // label_CaseDiscount
            // 
            this.label_CaseDiscount.Location = new System.Drawing.Point(33, 391);
            this.label_CaseDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CaseDiscount.Name = "label_CaseDiscount";
            this.label_CaseDiscount.Size = new System.Drawing.Size(107, 25);
            this.label_CaseDiscount.TabIndex = 18;
            this.label_CaseDiscount.Text = "Discounts:";
            this.label_CaseDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chk_box_show_hidden
            // 
            this.chk_box_show_hidden.AutoSize = true;
            this.chk_box_show_hidden.Location = new System.Drawing.Point(905, 25);
            this.chk_box_show_hidden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_box_show_hidden.Name = "chk_box_show_hidden";
            this.chk_box_show_hidden.Size = new System.Drawing.Size(118, 20);
            this.chk_box_show_hidden.TabIndex = 5;
            this.chk_box_show_hidden.Text = "Hidden Items";
            this.chk_box_show_hidden.UseVisualStyleBackColor = true;
            this.chk_box_show_hidden.CheckedChanged += new System.EventHandler(this.chk_box_show_hidden_CheckedChanged);
            // 
            // button_Broken
            // 
            this.button_Broken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Broken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Broken.Location = new System.Drawing.Point(673, 664);
            this.button_Broken.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Broken.Name = "button_Broken";
            this.button_Broken.Size = new System.Drawing.Size(142, 37);
            this.button_Broken.TabIndex = 24;
            this.button_Broken.Text = "ADD CONSUMED";
            this.button_Broken.UseVisualStyleBackColor = true;
            this.button_Broken.Click += new System.EventHandler(this.button_Broken_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 2);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Search:";
            // 
            // frmLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1028, 679);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_Broken);
            this.Controls.Add(this.chk_box_show_hidden);
            this.Controls.Add(this.cbxOnlyItemsWithInventory);
            this.Controls.Add(this.lblSupplyFilter);
            this.Controls.Add(this.cbxSupplyFilter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxTypeFilter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txtlookup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLookup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item lookup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.LookupView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtlookup;
        private System.Windows.Forms.DataGridView LookupView;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxTypeFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxSupplyFilter;
        private System.Windows.Forms.Label lblSupplyFilter;
		private System.Windows.Forms.CheckBox cbxOnlyItemsWithInventory;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_qty;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Button btn_update;
		private System.Windows.Forms.ComboBox cboType;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbo_Supplier;
		private System.Windows.Forms.TextBox txtBarcode;
		private System.Windows.Forms.Label barcode_label;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label Price_txt;
		private System.Windows.Forms.TextBox txt_net_price;
		private System.Windows.Forms.Label lbl_netPrice;
		private System.Windows.Forms.Button btn_new;
		private System.Windows.Forms.TextBox txtProd_Qty;
		private System.Windows.Forms.Label Btl_Dep_Lb;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label_CaseDiscount;
        private System.Windows.Forms.Label lbl_markup;
        private System.Windows.Forms.TextBox txt_markup;
        private System.Windows.Forms.Label lbl_max_qty;
        private System.Windows.Forms.Label lbl_order_qty;
        private System.Windows.Forms.TextBox txt_max_qty;
        private System.Windows.Forms.TextBox txt_order_qty;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.TextBox txt_min_qty;
        private System.Windows.Forms.CheckBox chk_box_show_hidden;
        private System.Windows.Forms.CheckBox chk_hide_item;
        private System.Windows.Forms.Button btn_clear_info;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
		private System.Windows.Forms.DataGridViewTextBoxColumn Class;
		private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
		private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn minqty;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderqty;
		private System.Windows.Forms.DataGridViewTextBoxColumn maxqty;
		private System.Windows.Forms.Button button_Broken;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckedListBox checkListBox_Discounts;
	}
}