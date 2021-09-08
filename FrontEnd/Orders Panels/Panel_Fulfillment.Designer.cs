
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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbl_whole_cust = new System.Windows.Forms.Label();
            this.cbx_fullfill_cust = new System.Windows.Forms.ComboBox();
            this.btn_deliver_selected = new System.Windows.Forms.Button();
            this.btn_deliver_all = new System.Windows.Forms.Button();
            this.btn_whole_assign_update = new System.Windows.Forms.Button();
            this.lbl_assignqty = new System.Windows.Forms.Label();
            this.txt_deliverqty = new System.Windows.Forms.TextBox();
            this.fullfill_datagrid = new System.Windows.Forms.DataGridView();
            this.fid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fbarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ftype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequestqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fullfill_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.Location = new System.Drawing.Point(597, 6);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 19;
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
            this.cbx_fullfill_cust.Location = new System.Drawing.Point(63, 5);
            this.cbx_fullfill_cust.Name = "cbx_fullfill_cust";
            this.cbx_fullfill_cust.Size = new System.Drawing.Size(260, 21);
            this.cbx_fullfill_cust.TabIndex = 13;
            this.cbx_fullfill_cust.SelectedValueChanged += new System.EventHandler(this.frefresh);
            // 
            // btn_deliver_selected
            // 
            this.btn_deliver_selected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deliver_selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deliver_selected.Location = new System.Drawing.Point(469, 285);
            this.btn_deliver_selected.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deliver_selected.Name = "btn_deliver_selected";
            this.btn_deliver_selected.Size = new System.Drawing.Size(162, 36);
            this.btn_deliver_selected.TabIndex = 25;
            this.btn_deliver_selected.Text = "Deliver Selected";
            this.btn_deliver_selected.UseVisualStyleBackColor = true;
            this.btn_deliver_selected.Click += new System.EventHandler(this.btn_deliver_selected_Click);
            // 
            // btn_deliver_all
            // 
            this.btn_deliver_all.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deliver_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deliver_all.Location = new System.Drawing.Point(673, 285);
            this.btn_deliver_all.Margin = new System.Windows.Forms.Padding(2);
            this.btn_deliver_all.Name = "btn_deliver_all";
            this.btn_deliver_all.Size = new System.Drawing.Size(124, 36);
            this.btn_deliver_all.TabIndex = 24;
            this.btn_deliver_all.Text = "Deliver All";
            this.btn_deliver_all.UseVisualStyleBackColor = true;
            this.btn_deliver_all.Click += new System.EventHandler(this.btn_deliver_all_Click);
            // 
            // btn_whole_assign_update
            // 
            this.btn_whole_assign_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_whole_assign_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_whole_assign_update.Location = new System.Drawing.Point(153, 285);
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
            this.lbl_assignqty.Location = new System.Drawing.Point(3, 278);
            this.lbl_assignqty.Name = "lbl_assignqty";
            this.lbl_assignqty.Size = new System.Drawing.Size(74, 13);
            this.lbl_assignqty.TabIndex = 22;
            this.lbl_assignqty.Text = "Qty Delivered:";
            // 
            // txt_deliverqty
            // 
            this.txt_deliverqty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_deliverqty.Location = new System.Drawing.Point(6, 294);
            this.txt_deliverqty.Name = "txt_deliverqty";
            this.txt_deliverqty.Size = new System.Drawing.Size(135, 20);
            this.txt_deliverqty.TabIndex = 21;
            // 
            // fullfill_datagrid
            // 
            this.fullfill_datagrid.AllowUserToAddRows = false;
            this.fullfill_datagrid.AllowUserToDeleteRows = false;
            this.fullfill_datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullfill_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fullfill_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fid,
            this.fbarcode,
            this.fname,
            this.ftype,
            this.fqty,
            this.fprice,
            this.frequestqty});
            this.fullfill_datagrid.Location = new System.Drawing.Point(6, 36);
            this.fullfill_datagrid.Name = "fullfill_datagrid";
            this.fullfill_datagrid.ReadOnly = true;
            this.fullfill_datagrid.RowHeadersVisible = false;
            this.fullfill_datagrid.RowHeadersWidth = 62;
            this.fullfill_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fullfill_datagrid.Size = new System.Drawing.Size(791, 224);
            this.fullfill_datagrid.TabIndex = 20;
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
            // frequestqty
            // 
            this.frequestqty.DataPropertyName = "frequestqty";
            this.frequestqty.HeaderText = "Request Qty";
            this.frequestqty.MinimumWidth = 8;
            this.frequestqty.Name = "frequestqty";
            this.frequestqty.ReadOnly = true;
            this.frequestqty.Width = 80;
            // 
            // Panel_Fulfillment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_deliver_selected);
            this.Controls.Add(this.btn_deliver_all);
            this.Controls.Add(this.btn_whole_assign_update);
            this.Controls.Add(this.lbl_assignqty);
            this.Controls.Add(this.txt_deliverqty);
            this.Controls.Add(this.fullfill_datagrid);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.lbl_whole_cust);
            this.Controls.Add(this.cbx_fullfill_cust);
            this.Name = "Panel_Fulfillment";
            this.Size = new System.Drawing.Size(800, 329);
            ((System.ComponentModel.ISupportInitialize)(this.fullfill_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
		private System.Windows.Forms.DataGridViewTextBoxColumn fid;
		private System.Windows.Forms.DataGridViewTextBoxColumn fbarcode;
		private System.Windows.Forms.DataGridViewTextBoxColumn fname;
		private System.Windows.Forms.DataGridViewTextBoxColumn ftype;
		private System.Windows.Forms.DataGridViewTextBoxColumn fqty;
		private System.Windows.Forms.DataGridViewTextBoxColumn fprice;
		private System.Windows.Forms.DataGridViewTextBoxColumn frequestqty;
	}
}
