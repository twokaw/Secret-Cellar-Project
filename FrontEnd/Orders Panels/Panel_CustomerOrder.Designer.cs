
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
            this.grpOrder.SuspendLayout();
            this.grpFavorites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custOrder_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOrder
            // 
            this.grpOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOrder.Controls.Add(this.btnAddOrder);
            this.grpOrder.Controls.Add(this.btn_update_custorder);
            this.grpOrder.Controls.Add(this.txt_orderqty_custorder);
            this.grpOrder.Controls.Add(this.lbl_qty_custorder);
            this.grpOrder.Location = new System.Drawing.Point(992, 223);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(186, 272);
            this.grpOrder.TabIndex = 19;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Order";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.Location = new System.Drawing.Point(16, 35);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(150, 62);
            this.btnAddOrder.TabIndex = 10;
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btn_update_custorder
            // 
            this.btn_update_custorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_custorder.Location = new System.Drawing.Point(16, 202);
            this.btn_update_custorder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_update_custorder.Name = "btn_update_custorder";
            this.btn_update_custorder.Size = new System.Drawing.Size(150, 62);
            this.btn_update_custorder.TabIndex = 7;
            this.btn_update_custorder.Text = "Update";
            this.btn_update_custorder.UseVisualStyleBackColor = true;
            this.btn_update_custorder.Click += new System.EventHandler(this.btn_update_custorder_Click);
            // 
            // txt_orderqty_custorder
            // 
            this.txt_orderqty_custorder.Location = new System.Drawing.Point(16, 162);
            this.txt_orderqty_custorder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_orderqty_custorder.Name = "txt_orderqty_custorder";
            this.txt_orderqty_custorder.Size = new System.Drawing.Size(158, 26);
            this.txt_orderqty_custorder.TabIndex = 3;
            this.txt_orderqty_custorder.Text = "0";
            this.txt_orderqty_custorder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_orderqty_custorder_KeyPress);
            // 
            // lbl_qty_custorder
            // 
            this.lbl_qty_custorder.AutoSize = true;
            this.lbl_qty_custorder.Location = new System.Drawing.Point(12, 128);
            this.lbl_qty_custorder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_qty_custorder.Name = "lbl_qty_custorder";
            this.lbl_qty_custorder.Size = new System.Drawing.Size(102, 20);
            this.lbl_qty_custorder.TabIndex = 4;
            this.lbl_qty_custorder.Text = "Request Qty:";
            // 
            // grpFavorites
            // 
            this.grpFavorites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFavorites.Controls.Add(this.btnFavoritesRemove);
            this.grpFavorites.Controls.Add(this.btnFavoritesAdd);
            this.grpFavorites.Location = new System.Drawing.Point(992, 0);
            this.grpFavorites.Name = "grpFavorites";
            this.grpFavorites.Size = new System.Drawing.Size(186, 211);
            this.grpFavorites.TabIndex = 18;
            this.grpFavorites.TabStop = false;
            this.grpFavorites.Text = "Favorites";
            // 
            // btnFavoritesRemove
            // 
            this.btnFavoritesRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavoritesRemove.Location = new System.Drawing.Point(16, 122);
            this.btnFavoritesRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFavoritesRemove.Name = "btnFavoritesRemove";
            this.btnFavoritesRemove.Size = new System.Drawing.Size(150, 62);
            this.btnFavoritesRemove.TabIndex = 9;
            this.btnFavoritesRemove.Text = "Remove";
            this.btnFavoritesRemove.UseVisualStyleBackColor = true;
            this.btnFavoritesRemove.Click += new System.EventHandler(this.btnFavoritesRemove_Click);
            // 
            // btnFavoritesAdd
            // 
            this.btnFavoritesAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavoritesAdd.Location = new System.Drawing.Point(16, 40);
            this.btnFavoritesAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFavoritesAdd.Name = "btnFavoritesAdd";
            this.btnFavoritesAdd.Size = new System.Drawing.Size(150, 62);
            this.btnFavoritesAdd.TabIndex = 8;
            this.btnFavoritesAdd.Text = "Add";
            this.btnFavoritesAdd.UseVisualStyleBackColor = true;
            this.btnFavoritesAdd.Click += new System.EventHandler(this.btnFavoritesAdd_Click);
            // 
            // lbl_supp_custorder
            // 
            this.lbl_supp_custorder.AutoSize = true;
            this.lbl_supp_custorder.Location = new System.Drawing.Point(504, 14);
            this.lbl_supp_custorder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_supp_custorder.Name = "lbl_supp_custorder";
            this.lbl_supp_custorder.Size = new System.Drawing.Size(71, 20);
            this.lbl_supp_custorder.TabIndex = 17;
            this.lbl_supp_custorder.Text = "Supplier:";
            // 
            // cbx_supp_custorder
            // 
            this.cbx_supp_custorder.DisplayMember = "Name";
            this.cbx_supp_custorder.FormattingEnabled = true;
            this.cbx_supp_custorder.Location = new System.Drawing.Point(585, 9);
            this.cbx_supp_custorder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_supp_custorder.Name = "cbx_supp_custorder";
            this.cbx_supp_custorder.Size = new System.Drawing.Size(362, 28);
            this.cbx_supp_custorder.TabIndex = 16;
            this.cbx_supp_custorder.SelectedIndexChanged += new System.EventHandler(this.cbx_supp_custorder_SelectedIndexChanged);
            // 
            // custOrder_datagrid
            // 
            this.custOrder_datagrid.AllowUserToAddRows = false;
            this.custOrder_datagrid.AllowUserToDeleteRows = false;
            this.custOrder_datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.custOrder_datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.custOrder_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custOrder_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustOrd_id,
            this.CustOrdName,
            this.CustOrdQty,
            this.CustOrdOrderQty,
            this.CustOrdRequest,
            this.CustOrdPrice,
            this.CustOrdLastUsed});
            this.custOrder_datagrid.Location = new System.Drawing.Point(12, 80);
            this.custOrder_datagrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custOrder_datagrid.MultiSelect = false;
            this.custOrder_datagrid.Name = "custOrder_datagrid";
            this.custOrder_datagrid.ReadOnly = true;
            this.custOrder_datagrid.RowHeadersVisible = false;
            this.custOrder_datagrid.RowHeadersWidth = 62;
            this.custOrder_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.custOrder_datagrid.Size = new System.Drawing.Size(972, 415);
            this.custOrder_datagrid.TabIndex = 15;
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
            this.CustOrdQty.Width = 69;
            // 
            // CustOrdOrderQty
            // 
            this.CustOrdOrderQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustOrdOrderQty.DataPropertyName = "OrderQty";
            this.CustOrdOrderQty.HeaderText = "Order Qty";
            this.CustOrdOrderQty.MinimumWidth = 8;
            this.CustOrdOrderQty.Name = "CustOrdOrderQty";
            this.CustOrdOrderQty.ReadOnly = true;
            this.CustOrdOrderQty.Width = 113;
            // 
            // CustOrdRequest
            // 
            this.CustOrdRequest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustOrdRequest.DataPropertyName = "Requested";
            this.CustOrdRequest.HeaderText = "Request Qty";
            this.CustOrdRequest.MinimumWidth = 8;
            this.CustOrdRequest.Name = "CustOrdRequest";
            this.CustOrdRequest.ReadOnly = true;
            this.CustOrdRequest.Width = 134;
            // 
            // CustOrdPrice
            // 
            this.CustOrdPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustOrdPrice.DataPropertyName = "Price";
            this.CustOrdPrice.HeaderText = "Price";
            this.CustOrdPrice.MinimumWidth = 8;
            this.CustOrdPrice.Name = "CustOrdPrice";
            this.CustOrdPrice.ReadOnly = true;
            this.CustOrdPrice.Width = 80;
            // 
            // CustOrdLastUsed
            // 
            this.CustOrdLastUsed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustOrdLastUsed.DataPropertyName = "Lastused";
            this.CustOrdLastUsed.HeaderText = "Last Ordered";
            this.CustOrdLastUsed.MinimumWidth = 8;
            this.CustOrdLastUsed.Name = "CustOrdLastUsed";
            this.CustOrdLastUsed.ReadOnly = true;
            this.CustOrdLastUsed.Width = 138;
            // 
            // lbl_cust_custorder
            // 
            this.lbl_cust_custorder.AutoSize = true;
            this.lbl_cust_custorder.Location = new System.Drawing.Point(4, 14);
            this.lbl_cust_custorder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cust_custorder.Name = "lbl_cust_custorder";
            this.lbl_cust_custorder.Size = new System.Drawing.Size(86, 20);
            this.lbl_cust_custorder.TabIndex = 14;
            this.lbl_cust_custorder.Text = "Customer: ";
            // 
            // cbx_cust_custorder
            // 
            this.cbx_cust_custorder.DisplayMember = "FullName";
            this.cbx_cust_custorder.FormattingEnabled = true;
            this.cbx_cust_custorder.Location = new System.Drawing.Point(99, 9);
            this.cbx_cust_custorder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_cust_custorder.Name = "cbx_cust_custorder";
            this.cbx_cust_custorder.Size = new System.Drawing.Size(362, 28);
            this.cbx_cust_custorder.TabIndex = 13;
            this.cbx_cust_custorder.SelectedIndexChanged += new System.EventHandler(this.cbx_cust_custorder_SelectedIndexChanged);
            // 
            // Panel_CustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.grpFavorites);
            this.Controls.Add(this.lbl_supp_custorder);
            this.Controls.Add(this.cbx_supp_custorder);
            this.Controls.Add(this.custOrder_datagrid);
            this.Controls.Add(this.lbl_cust_custorder);
            this.Controls.Add(this.cbx_cust_custorder);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Panel_CustomerOrder";
            this.Size = new System.Drawing.Size(1194, 506);
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.grpFavorites.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.custOrder_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
		private System.Windows.Forms.DataGridViewTextBoxColumn CustOrd_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustOrdName;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustOrdQty;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustOrdOrderQty;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustOrdRequest;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustOrdPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustOrdLastUsed;
		private System.Windows.Forms.Label lbl_cust_custorder;
		private System.Windows.Forms.ComboBox cbx_cust_custorder;
	}
}
