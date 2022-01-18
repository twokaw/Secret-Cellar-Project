
namespace SecretCellar.Orders_Panels {
	partial class Panel_CustomerOrder {
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
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btn_update_custorder = new System.Windows.Forms.Button();
            this.txt_orderqty_custorder = new System.Windows.Forms.TextBox();
            this.lbl_qty_custorder = new System.Windows.Forms.Label();
            this.grpFavorites = new System.Windows.Forms.GroupBox();
            this.btnFavoritesRemove = new System.Windows.Forms.Button();
            this.btnFavoritesAdd = new System.Windows.Forms.Button();
            this.lbl_supp_custorder = new System.Windows.Forms.Label();
            this.cbx_supp_custorder = new System.Windows.Forms.ComboBox();
            this.custOrder_datagrid = new System.Windows.Forms.DataGridView();
            this.CustOrd_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustOrdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustOrdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustOrdOrderQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustOrdRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustOrdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustOrdLastUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_cust_custorder = new System.Windows.Forms.Label();
            this.cbx_cust_custorder = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpOrder.SuspendLayout();
            this.grpFavorites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custOrder_datagrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOrder
            // 
            this.grpOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOrder.Controls.Add(this.btnAddOrder);
            this.grpOrder.Controls.Add(this.btn_update_custorder);
            this.grpOrder.Controls.Add(this.txt_orderqty_custorder);
            this.grpOrder.Controls.Add(this.lbl_qty_custorder);
            this.grpOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrder.Location = new System.Drawing.Point(843, 249);
            this.grpOrder.Margin = new System.Windows.Forms.Padding(2);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Padding = new System.Windows.Forms.Padding(2);
            this.grpOrder.Size = new System.Drawing.Size(124, 177);
            this.grpOrder.TabIndex = 19;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Order";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.Location = new System.Drawing.Point(11, 23);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(100, 40);
            this.btnAddOrder.TabIndex = 10;
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btn_update_custorder
            // 
            this.btn_update_custorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_custorder.Location = new System.Drawing.Point(11, 131);
            this.btn_update_custorder.Name = "btn_update_custorder";
            this.btn_update_custorder.Size = new System.Drawing.Size(100, 40);
            this.btn_update_custorder.TabIndex = 7;
            this.btn_update_custorder.Text = "Update";
            this.btn_update_custorder.UseVisualStyleBackColor = true;
            this.btn_update_custorder.Click += new System.EventHandler(this.btn_update_custorder_Click);
            // 
            // txt_orderqty_custorder
            // 
            this.txt_orderqty_custorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_orderqty_custorder.Location = new System.Drawing.Point(11, 102);
            this.txt_orderqty_custorder.Name = "txt_orderqty_custorder";
            this.txt_orderqty_custorder.Size = new System.Drawing.Size(107, 26);
            this.txt_orderqty_custorder.TabIndex = 3;
            this.txt_orderqty_custorder.Text = "0";
            this.txt_orderqty_custorder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_orderqty_custorder_KeyPress);
            // 
            // lbl_qty_custorder
            // 
            this.lbl_qty_custorder.AutoSize = true;
            this.lbl_qty_custorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty_custorder.Location = new System.Drawing.Point(11, 76);
            this.lbl_qty_custorder.Name = "lbl_qty_custorder";
            this.lbl_qty_custorder.Size = new System.Drawing.Size(114, 20);
            this.lbl_qty_custorder.TabIndex = 4;
            this.lbl_qty_custorder.Text = "Request Qty:";
            // 
            // grpFavorites
            // 
            this.grpFavorites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFavorites.Controls.Add(this.btnFavoritesRemove);
            this.grpFavorites.Controls.Add(this.btnFavoritesAdd);
            this.grpFavorites.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFavorites.Location = new System.Drawing.Point(843, 75);
            this.grpFavorites.Margin = new System.Windows.Forms.Padding(2);
            this.grpFavorites.Name = "grpFavorites";
            this.grpFavorites.Padding = new System.Windows.Forms.Padding(2);
            this.grpFavorites.Size = new System.Drawing.Size(124, 137);
            this.grpFavorites.TabIndex = 18;
            this.grpFavorites.TabStop = false;
            this.grpFavorites.Text = "Favorites";
            // 
            // btnFavoritesRemove
            // 
            this.btnFavoritesRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavoritesRemove.Location = new System.Drawing.Point(11, 79);
            this.btnFavoritesRemove.Name = "btnFavoritesRemove";
            this.btnFavoritesRemove.Size = new System.Drawing.Size(100, 40);
            this.btnFavoritesRemove.TabIndex = 9;
            this.btnFavoritesRemove.Text = "Remove";
            this.btnFavoritesRemove.UseVisualStyleBackColor = true;
            this.btnFavoritesRemove.Click += new System.EventHandler(this.btnFavoritesRemove_Click);
            // 
            // btnFavoritesAdd
            // 
            this.btnFavoritesAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavoritesAdd.Location = new System.Drawing.Point(11, 26);
            this.btnFavoritesAdd.Name = "btnFavoritesAdd";
            this.btnFavoritesAdd.Size = new System.Drawing.Size(100, 40);
            this.btnFavoritesAdd.TabIndex = 8;
            this.btnFavoritesAdd.Text = "Add";
            this.btnFavoritesAdd.UseVisualStyleBackColor = true;
            this.btnFavoritesAdd.Click += new System.EventHandler(this.btnFavoritesAdd_Click);
            // 
            // lbl_supp_custorder
            // 
            this.lbl_supp_custorder.AutoSize = true;
            this.lbl_supp_custorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_supp_custorder.Location = new System.Drawing.Point(373, 8);
            this.lbl_supp_custorder.Name = "lbl_supp_custorder";
            this.lbl_supp_custorder.Size = new System.Drawing.Size(80, 20);
            this.lbl_supp_custorder.TabIndex = 17;
            this.lbl_supp_custorder.Text = "Supplier:";
            // 
            // cbx_supp_custorder
            // 
            this.cbx_supp_custorder.DisplayMember = "Name";
            this.cbx_supp_custorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_supp_custorder.FormattingEnabled = true;
            this.cbx_supp_custorder.Location = new System.Drawing.Point(461, 5);
            this.cbx_supp_custorder.Name = "cbx_supp_custorder";
            this.cbx_supp_custorder.Size = new System.Drawing.Size(243, 28);
            this.cbx_supp_custorder.TabIndex = 16;
            this.cbx_supp_custorder.SelectedIndexChanged += new System.EventHandler(this.cbx_supp_custorder_SelectedIndexChanged);
            // 
            // custOrder_datagrid
            // 
            this.custOrder_datagrid.AllowUserToAddRows = false;
            this.custOrder_datagrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Ivory;
            this.custOrder_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.custOrder_datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.custOrder_datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.custOrder_datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.custOrder_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.custOrder_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custOrder_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustOrd_id,
            this.CustOrdName,
            this.CustOrdQty,
            this.CustOrdOrderQty,
            this.CustOrdRequest,
            this.CustOrdPrice,
            this.CustOrdLastUsed});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.custOrder_datagrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.custOrder_datagrid.Location = new System.Drawing.Point(8, 38);
            this.custOrder_datagrid.MultiSelect = false;
            this.custOrder_datagrid.Name = "custOrder_datagrid";
            this.custOrder_datagrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.custOrder_datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.custOrder_datagrid.RowHeadersVisible = false;
            this.custOrder_datagrid.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Ivory;
            this.custOrder_datagrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.custOrder_datagrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.custOrder_datagrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custOrder_datagrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.custOrder_datagrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Ivory;
            this.custOrder_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.custOrder_datagrid.Size = new System.Drawing.Size(833, 509);
            this.custOrder_datagrid.TabIndex = 15;
            this.custOrder_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.custOrder_datagrid_CellContentClick);
            // 
            // CustOrd_id
            // 
            this.CustOrd_id.DataPropertyName = "id";
            this.CustOrd_id.HeaderText = "id";
            this.CustOrd_id.MinimumWidth = 8;
            this.CustOrd_id.Name = "CustOrd_id";
            this.CustOrd_id.ReadOnly = true;
            this.CustOrd_id.Visible = false;
            this.CustOrd_id.Width = 150;
            // 
            // CustOrdName
            // 
            this.CustOrdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustOrdName.DataPropertyName = "Name";
            this.CustOrdName.HeaderText = "Name";
            this.CustOrdName.MinimumWidth = 8;
            this.CustOrdName.Name = "CustOrdName";
            this.CustOrdName.ReadOnly = true;
            this.CustOrdName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CustOrdQty
            // 
            this.CustOrdQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustOrdQty.DataPropertyName = "Qty";
            this.CustOrdQty.HeaderText = "Qty";
            this.CustOrdQty.MinimumWidth = 8;
            this.CustOrdQty.Name = "CustOrdQty";
            this.CustOrdQty.ReadOnly = true;
            this.CustOrdQty.Width = 61;
            // 
            // CustOrdOrderQty
            // 
            this.CustOrdOrderQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustOrdOrderQty.DataPropertyName = "OrderQty";
            this.CustOrdOrderQty.HeaderText = "Order Qty";
            this.CustOrdOrderQty.MinimumWidth = 8;
            this.CustOrdOrderQty.Name = "CustOrdOrderQty";
            this.CustOrdOrderQty.ReadOnly = true;
            this.CustOrdOrderQty.Width = 102;
            // 
            // CustOrdRequest
            // 
            this.CustOrdRequest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustOrdRequest.DataPropertyName = "RequestQty";
            this.CustOrdRequest.HeaderText = "Request Qty";
            this.CustOrdRequest.MinimumWidth = 8;
            this.CustOrdRequest.Name = "CustOrdRequest";
            this.CustOrdRequest.ReadOnly = true;
            this.CustOrdRequest.Width = 123;
            // 
            // CustOrdPrice
            // 
            this.CustOrdPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustOrdPrice.DataPropertyName = "Price";
            this.CustOrdPrice.HeaderText = "Price";
            this.CustOrdPrice.MinimumWidth = 8;
            this.CustOrdPrice.Name = "CustOrdPrice";
            this.CustOrdPrice.ReadOnly = true;
            this.CustOrdPrice.Width = 74;
            // 
            // CustOrdLastUsed
            // 
            this.CustOrdLastUsed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustOrdLastUsed.DataPropertyName = "Lastused";
            this.CustOrdLastUsed.HeaderText = "Last Ordered";
            this.CustOrdLastUsed.MinimumWidth = 8;
            this.CustOrdLastUsed.Name = "CustOrdLastUsed";
            this.CustOrdLastUsed.ReadOnly = true;
            this.CustOrdLastUsed.Width = 127;
            // 
            // lbl_cust_custorder
            // 
            this.lbl_cust_custorder.AutoSize = true;
            this.lbl_cust_custorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cust_custorder.Location = new System.Drawing.Point(8, 7);
            this.lbl_cust_custorder.Name = "lbl_cust_custorder";
            this.lbl_cust_custorder.Size = new System.Drawing.Size(96, 20);
            this.lbl_cust_custorder.TabIndex = 14;
            this.lbl_cust_custorder.Text = "Customer: ";
            // 
            // cbx_cust_custorder
            // 
            this.cbx_cust_custorder.DisplayMember = "FullName";
            this.cbx_cust_custorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_cust_custorder.FormattingEnabled = true;
            this.cbx_cust_custorder.Location = new System.Drawing.Point(107, 5);
            this.cbx_cust_custorder.Name = "cbx_cust_custorder";
            this.cbx_cust_custorder.Size = new System.Drawing.Size(243, 28);
            this.cbx_cust_custorder.TabIndex = 13;
            this.cbx_cust_custorder.SelectedIndexChanged += new System.EventHandler(this.cbx_cust_custorder_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.grpOrder);
            this.panel1.Controls.Add(this.grpFavorites);
            this.panel1.Controls.Add(this.lbl_supp_custorder);
            this.panel1.Controls.Add(this.custOrder_datagrid);
            this.panel1.Controls.Add(this.cbx_supp_custorder);
            this.panel1.Controls.Add(this.lbl_cust_custorder);
            this.panel1.Controls.Add(this.cbx_cust_custorder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 554);
            this.panel1.TabIndex = 20;
            // 
            // Panel_CustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Name = "Panel_CustomerOrder";
            this.Size = new System.Drawing.Size(969, 554);
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.grpFavorites.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.custOrder_datagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpOrder;
		private System.Windows.Forms.Button btnAddOrder;
		private System.Windows.Forms.Button btn_update_custorder;
		private System.Windows.Forms.TextBox txt_orderqty_custorder;
		private System.Windows.Forms.Label lbl_qty_custorder;
		private System.Windows.Forms.GroupBox grpFavorites;
		private System.Windows.Forms.Button btnFavoritesRemove;
		private System.Windows.Forms.Button btnFavoritesAdd;
		private System.Windows.Forms.Label lbl_supp_custorder;
		private System.Windows.Forms.ComboBox cbx_supp_custorder;
		private System.Windows.Forms.DataGridView custOrder_datagrid;
		private System.Windows.Forms.Label lbl_cust_custorder;
		private System.Windows.Forms.ComboBox cbx_cust_custorder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustOrd_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustOrdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustOrdQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustOrdOrderQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustOrdRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustOrdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustOrdLastUsed;
    }
}
