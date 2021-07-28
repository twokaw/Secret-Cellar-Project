
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
			((System.ComponentModel.ISupportInitialize)(this.fullfill_datagrid)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_whole_assign_update
			// 
			this.btn_whole_assign_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_whole_assign_update.Location = new System.Drawing.Point(651, 272);
			this.btn_whole_assign_update.Name = "btn_whole_assign_update";
			this.btn_whole_assign_update.Size = new System.Drawing.Size(135, 36);
			this.btn_whole_assign_update.TabIndex = 21;
			this.btn_whole_assign_update.Text = "Delivered Update";
			this.btn_whole_assign_update.UseVisualStyleBackColor = true;
			// 
			// btn_whole_order_update
			// 
			this.btn_whole_order_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_whole_order_update.Location = new System.Drawing.Point(651, 111);
			this.btn_whole_order_update.Name = "btn_whole_order_update";
			this.btn_whole_order_update.Size = new System.Drawing.Size(135, 36);
			this.btn_whole_order_update.TabIndex = 20;
			this.btn_whole_order_update.Text = "Order Update";
			this.btn_whole_order_update.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(441, 6);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker2.TabIndex = 19;
			// 
			// lbl_assignqty
			// 
			this.lbl_assignqty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_assignqty.AutoSize = true;
			this.lbl_assignqty.Location = new System.Drawing.Point(647, 217);
			this.lbl_assignqty.Name = "lbl_assignqty";
			this.lbl_assignqty.Size = new System.Drawing.Size(74, 13);
			this.lbl_assignqty.TabIndex = 18;
			this.lbl_assignqty.Text = "Qty Delivered:";
			// 
			// txt_receivqty
			// 
			this.txt_receivqty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_receivqty.Location = new System.Drawing.Point(651, 240);
			this.txt_receivqty.Name = "txt_receivqty";
			this.txt_receivqty.Size = new System.Drawing.Size(135, 20);
			this.txt_receivqty.TabIndex = 17;
			// 
			// lbl_whole_orderqty
			// 
			this.lbl_whole_orderqty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_whole_orderqty.AutoSize = true;
			this.lbl_whole_orderqty.Location = new System.Drawing.Point(647, 56);
			this.lbl_whole_orderqty.Name = "lbl_whole_orderqty";
			this.lbl_whole_orderqty.Size = new System.Drawing.Size(55, 13);
			this.lbl_whole_orderqty.TabIndex = 16;
			this.lbl_whole_orderqty.Text = "Order Qty:";
			// 
			// txt_whole_orderqty
			// 
			this.txt_whole_orderqty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_whole_orderqty.Location = new System.Drawing.Point(651, 79);
			this.txt_whole_orderqty.Name = "txt_whole_orderqty";
			this.txt_whole_orderqty.Size = new System.Drawing.Size(135, 20);
			this.txt_whole_orderqty.TabIndex = 15;
			// 
			// lbl_whole_cust
			// 
			this.lbl_whole_cust.AutoSize = true;
			this.lbl_whole_cust.Location = new System.Drawing.Point(3, 9);
			this.lbl_whole_cust.Name = "lbl_whole_cust";
			this.lbl_whole_cust.Size = new System.Drawing.Size(54, 13);
			this.lbl_whole_cust.TabIndex = 14;
			this.lbl_whole_cust.Text = "Customer:";
			// 
			// cbx_fullfill_cust
			// 
			this.cbx_fullfill_cust.FormattingEnabled = true;
			this.cbx_fullfill_cust.Location = new System.Drawing.Point(63, 9);
			this.cbx_fullfill_cust.Name = "cbx_fullfill_cust";
			this.cbx_fullfill_cust.Size = new System.Drawing.Size(260, 21);
			this.cbx_fullfill_cust.TabIndex = 13;
			// 
			// fullfill_datagrid
			// 
			this.fullfill_datagrid.AllowUserToAddRows = false;
			this.fullfill_datagrid.AllowUserToDeleteRows = false;
			this.fullfill_datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
			this.fullfill_datagrid.Location = new System.Drawing.Point(6, 56);
			this.fullfill_datagrid.Name = "fullfill_datagrid";
			this.fullfill_datagrid.ReadOnly = true;
			this.fullfill_datagrid.RowHeadersVisible = false;
			this.fullfill_datagrid.RowHeadersWidth = 62;
			this.fullfill_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.fullfill_datagrid.Size = new System.Drawing.Size(635, 252);
			this.fullfill_datagrid.TabIndex = 12;
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
			// Panel_Fulfillment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btn_whole_assign_update);
			this.Controls.Add(this.btn_whole_order_update);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.lbl_assignqty);
			this.Controls.Add(this.txt_receivqty);
			this.Controls.Add(this.lbl_whole_orderqty);
			this.Controls.Add(this.txt_whole_orderqty);
			this.Controls.Add(this.lbl_whole_cust);
			this.Controls.Add(this.cbx_fullfill_cust);
			this.Controls.Add(this.fullfill_datagrid);
			this.Name = "Panel_Fulfillment";
			this.Size = new System.Drawing.Size(800, 329);
			((System.ComponentModel.ISupportInitialize)(this.fullfill_datagrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_whole_assign_update;
		private System.Windows.Forms.Button btn_whole_order_update;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label lbl_assignqty;
		private System.Windows.Forms.TextBox txt_receivqty;
		private System.Windows.Forms.Label lbl_whole_orderqty;
		private System.Windows.Forms.TextBox txt_whole_orderqty;
		private System.Windows.Forms.Label lbl_whole_cust;
		private System.Windows.Forms.ComboBox cbx_fullfill_cust;
		private System.Windows.Forms.DataGridView fullfill_datagrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn fid;
		private System.Windows.Forms.DataGridViewTextBoxColumn fbarcode;
		private System.Windows.Forms.DataGridViewTextBoxColumn fname;
		private System.Windows.Forms.DataGridViewTextBoxColumn ftype;
		private System.Windows.Forms.DataGridViewTextBoxColumn fqty;
		private System.Windows.Forms.DataGridViewTextBoxColumn fprice;
		private System.Windows.Forms.DataGridViewTextBoxColumn fmin;
		private System.Windows.Forms.DataGridViewTextBoxColumn fmax;
		private System.Windows.Forms.DataGridViewTextBoxColumn forderqty;
	}
}
