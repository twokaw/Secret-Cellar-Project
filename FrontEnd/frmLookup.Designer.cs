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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLookup));
            this.txtlookup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LookupView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btl_Dep_Lb = new System.Windows.Forms.Label();
            this.txtProd_Qty = new System.Windows.Forms.TextBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.lbl_netPrice = new System.Windows.Forms.Label();
            this.txtNetPrice = new System.Windows.Forms.TextBox();
            this.Price_txt = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.barcode_label = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.cbo_Supplier = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxTypeFilter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxSupplyFilter = new System.Windows.Forms.ComboBox();
            this.lblSupplyFilter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LookupView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtlookup
            // 
            this.txtlookup.Location = new System.Drawing.Point(192, 21);
            this.txtlookup.Margin = new System.Windows.Forms.Padding(2);
            this.txtlookup.Name = "txtlookup";
            this.txtlookup.Size = new System.Drawing.Size(181, 20);
            this.txtlookup.TabIndex = 0;
            this.txtlookup.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Description or Barcode";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LookupView
            // 
            this.LookupView.AllowUserToResizeColumns = false;
            this.LookupView.AllowUserToResizeRows = false;
            this.LookupView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LookupView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LookupView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Description,
            this.Class,
            this.Barcode,
            this.Qty,
            this.Price});
            this.LookupView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LookupView.Location = new System.Drawing.Point(0, 0);
            this.LookupView.Margin = new System.Windows.Forms.Padding(2);
            this.LookupView.MultiSelect = false;
            this.LookupView.Name = "LookupView";
            this.LookupView.RowHeadersVisible = false;
            this.LookupView.RowHeadersWidth = 62;
            this.LookupView.RowTemplate.Height = 24;
            this.LookupView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LookupView.Size = new System.Drawing.Size(759, 390);
            this.LookupView.TabIndex = 2;
            this.LookupView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LookupView_CellContentClick);
            this.LookupView.SelectionChanged += new System.EventHandler(this.LookupView_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ItemId";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Description.DataPropertyName = "Name";
            this.Description.HeaderText = "Name";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            this.Description.Width = 60;
            // 
            // Class
            // 
            this.Class.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Class.DataPropertyName = "ItemType";
            this.Class.HeaderText = "Class";
            this.Class.MinimumWidth = 8;
            this.Class.Name = "Class";
            this.Class.Width = 57;
            // 
            // Barcode
            // 
            this.Barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Barcode.DataPropertyName = "Barcode";
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.MinimumWidth = 8;
            this.Barcode.Name = "Barcode";
            this.Barcode.Width = 72;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Qty.DataPropertyName = "Qty";
            this.Qty.HeaderText = "Qty";
            this.Qty.MinimumWidth = 8;
            this.Qty.Name = "Qty";
            this.Qty.Width = 48;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Price.DataPropertyName = "Price";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Price.DefaultCellStyle = dataGridViewCellStyle1;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.Width = 56;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(938, 449);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(74, 30);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(857, 449);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(73, 30);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cboType
            // 
            this.cboType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboType.DisplayMember = "TypeName";
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(74, 40);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(163, 21);
            this.cboType.TabIndex = 5;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Type:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_qty
            // 
            this.txt_qty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_qty.Location = new System.Drawing.Point(74, 93);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(163, 20);
            this.txt_qty.TabIndex = 3;
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Qty:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(74, 14);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 20);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(160, 346);
            this.btn_update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(73, 30);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.LookupView);
            this.panel1.Location = new System.Drawing.Point(13, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 390);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.Btl_Dep_Lb);
            this.panel2.Controls.Add(this.txtProd_Qty);
            this.panel2.Controls.Add(this.btn_new);
            this.panel2.Controls.Add(this.lbl_netPrice);
            this.panel2.Controls.Add(this.txtNetPrice);
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
            this.panel2.Location = new System.Drawing.Point(777, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 390);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Btl_Dep_Lb
            // 
            this.Btl_Dep_Lb.AutoSize = true;
            this.Btl_Dep_Lb.Location = new System.Drawing.Point(12, 206);
            this.Btl_Dep_Lb.Name = "Btl_Dep_Lb";
            this.Btl_Dep_Lb.Size = new System.Drawing.Size(56, 13);
            this.Btl_Dep_Lb.TabIndex = 17;
            this.Btl_Dep_Lb.Text = "Bottle Oty:";
            this.Btl_Dep_Lb.Click += new System.EventHandler(this.Btl_Dep_Lb_Click);
            // 
            // txtProd_Qty
            // 
            this.txtProd_Qty.Location = new System.Drawing.Point(75, 202);
            this.txtProd_Qty.Name = "txtProd_Qty";
            this.txtProd_Qty.Size = new System.Drawing.Size(162, 20);
            this.txtProd_Qty.TabIndex = 16;
            this.txtProd_Qty.TextChanged += new System.EventHandler(this.txtBtl_Deposit_TextChanged);
            // 
            // btn_new
            // 
            this.btn_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(20, 346);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(86, 30);
            this.btn_new.TabIndex = 15;
            this.btn_new.Text = "New Item";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // lbl_netPrice
            // 
            this.lbl_netPrice.AutoSize = true;
            this.lbl_netPrice.Location = new System.Drawing.Point(17, 175);
            this.lbl_netPrice.Name = "lbl_netPrice";
            this.lbl_netPrice.Size = new System.Drawing.Size(54, 13);
            this.lbl_netPrice.TabIndex = 14;
            this.lbl_netPrice.Text = "Net Price:";
            // 
            // txtNetPrice
            // 
            this.txtNetPrice.Location = new System.Drawing.Point(74, 172);
            this.txtNetPrice.Name = "txtNetPrice";
            this.txtNetPrice.Size = new System.Drawing.Size(162, 20);
            this.txtNetPrice.TabIndex = 13;
            this.txtNetPrice.TextChanged += new System.EventHandler(this.txtNetPrice_TextChanged);
            // 
            // Price_txt
            // 
            this.Price_txt.AutoSize = true;
            this.Price_txt.Location = new System.Drawing.Point(30, 122);
            this.Price_txt.Name = "Price_txt";
            this.Price_txt.Size = new System.Drawing.Size(34, 13);
            this.Price_txt.TabIndex = 12;
            this.Price_txt.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(74, 119);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(162, 20);
            this.txtPrice.TabIndex = 11;
            // 
            // barcode_label
            // 
            this.barcode_label.AutoSize = true;
            this.barcode_label.Location = new System.Drawing.Point(21, 71);
            this.barcode_label.Name = "barcode_label";
            this.barcode_label.Size = new System.Drawing.Size(50, 13);
            this.barcode_label.TabIndex = 10;
            this.barcode_label.Text = "Barcode:";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBarcode.Location = new System.Drawing.Point(74, 67);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(163, 20);
            this.txtBarcode.TabIndex = 9;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            // 
            // cbo_Supplier
            // 
            this.cbo_Supplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_Supplier.DisplayMember = "Name";
            this.cbo_Supplier.FormattingEnabled = true;
            this.cbo_Supplier.Location = new System.Drawing.Point(74, 145);
            this.cbo_Supplier.Name = "cbo_Supplier";
            this.cbo_Supplier.Size = new System.Drawing.Size(163, 21);
            this.cbo_Supplier.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Supplier:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxTypeFilter
            // 
            this.cbxTypeFilter.DisplayMember = "TypeName";
            this.cbxTypeFilter.FormattingEnabled = true;
            this.cbxTypeFilter.Location = new System.Drawing.Point(448, 21);
            this.cbxTypeFilter.Name = "cbxTypeFilter";
            this.cbxTypeFilter.Size = new System.Drawing.Size(121, 21);
            this.cbxTypeFilter.TabIndex = 9;
            this.cbxTypeFilter.SelectedIndexChanged += new System.EventHandler(this.cbxTypeFilter_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(411, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Type";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbxSupplyFilter
            // 
            this.cbxSupplyFilter.DisplayMember = "Name";
            this.cbxSupplyFilter.FormattingEnabled = true;
            this.cbxSupplyFilter.Location = new System.Drawing.Point(717, 21);
            this.cbxSupplyFilter.Name = "cbxSupplyFilter";
            this.cbxSupplyFilter.Size = new System.Drawing.Size(121, 21);
            this.cbxSupplyFilter.TabIndex = 11;
            this.cbxSupplyFilter.SelectedIndexChanged += new System.EventHandler(this.cbxSupplyFilter_SelectedIndexChanged);
            // 
            // lblSupplyFilter
            // 
            this.lblSupplyFilter.AutoSize = true;
            this.lblSupplyFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplyFilter.Location = new System.Drawing.Point(659, 25);
            this.lblSupplyFilter.Name = "lblSupplyFilter";
            this.lblSupplyFilter.Size = new System.Drawing.Size(57, 13);
            this.lblSupplyFilter.TabIndex = 12;
            this.lblSupplyFilter.Text = "Supplier:";
            // 
            // frmLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1023, 489);
            this.Controls.Add(this.lblSupplyFilter);
            this.Controls.Add(this.cbxSupplyFilter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxTypeFilter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtlookup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLookup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Item lookup";
            ((System.ComponentModel.ISupportInitialize)(this.LookupView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtlookup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView LookupView;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbo_Supplier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Label lbl_netPrice;
        private System.Windows.Forms.TextBox txtNetPrice;
        private System.Windows.Forms.Label Price_txt;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label barcode_label;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label Btl_Dep_Lb;
        private System.Windows.Forms.TextBox txtProd_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.ComboBox cbxTypeFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxSupplyFilter;
        private System.Windows.Forms.Label lblSupplyFilter;
    }
}