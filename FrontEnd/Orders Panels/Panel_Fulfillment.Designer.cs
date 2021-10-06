
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbl_whole_cust = new System.Windows.Forms.Label();
            this.cbx_fullfill_cust = new System.Windows.Forms.ComboBox();
            this.btn_deliver_selected = new System.Windows.Forms.Button();
            this.btn_deliver_all = new System.Windows.Forms.Button();
            this.btn_whole_assign_update = new System.Windows.Forms.Button();
            this.lbl_assignqty = new System.Windows.Forms.Label();
            this.txt_deliverqty = new System.Windows.Forms.TextBox();
            this.fullfill_datagrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.due = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fullfill_datagrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(871, 10);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(312, 26);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // lbl_whole_cust
            // 
            this.lbl_whole_cust.AutoSize = true;
            this.lbl_whole_cust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_whole_cust.Location = new System.Drawing.Point(11, 11);
            this.lbl_whole_cust.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_whole_cust.Name = "lbl_whole_cust";
            this.lbl_whole_cust.Size = new System.Drawing.Size(96, 20);
            this.lbl_whole_cust.TabIndex = 14;
            this.lbl_whole_cust.Text = "Customer:";
            // 
            // cbx_fullfill_cust
            // 
            this.cbx_fullfill_cust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_fullfill_cust.FormattingEnabled = true;
            this.cbx_fullfill_cust.Location = new System.Drawing.Point(114, 8);
            this.cbx_fullfill_cust.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_fullfill_cust.Name = "cbx_fullfill_cust";
            this.cbx_fullfill_cust.Size = new System.Drawing.Size(388, 28);
            this.cbx_fullfill_cust.TabIndex = 13;
            this.cbx_fullfill_cust.SelectedValueChanged += new System.EventHandler(this.frefresh);
            // 
            // btn_deliver_selected
            // 
            this.btn_deliver_selected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deliver_selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deliver_selected.Location = new System.Drawing.Point(737, 436);
            this.btn_deliver_selected.Name = "btn_deliver_selected";
            this.btn_deliver_selected.Size = new System.Drawing.Size(243, 55);
            this.btn_deliver_selected.TabIndex = 25;
            this.btn_deliver_selected.Text = "Deliver Selected";
            this.btn_deliver_selected.UseVisualStyleBackColor = true;
            this.btn_deliver_selected.Click += new System.EventHandler(this.btn_deliver_selected_Click);
            // 
            // btn_deliver_all
            // 
            this.btn_deliver_all.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deliver_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deliver_all.Location = new System.Drawing.Point(997, 436);
            this.btn_deliver_all.Name = "btn_deliver_all";
            this.btn_deliver_all.Size = new System.Drawing.Size(186, 55);
            this.btn_deliver_all.TabIndex = 24;
            this.btn_deliver_all.Text = "Deliver All";
            this.btn_deliver_all.UseVisualStyleBackColor = true;
            this.btn_deliver_all.Click += new System.EventHandler(this.btn_deliver_all_Click);
            // 
            // btn_whole_assign_update
            // 
            this.btn_whole_assign_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_whole_assign_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_whole_assign_update.Location = new System.Drawing.Point(238, 436);
            this.btn_whole_assign_update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_whole_assign_update.Name = "btn_whole_assign_update";
            this.btn_whole_assign_update.Size = new System.Drawing.Size(255, 55);
            this.btn_whole_assign_update.TabIndex = 23;
            this.btn_whole_assign_update.Text = "Delivered Update";
            this.btn_whole_assign_update.UseVisualStyleBackColor = true;
            this.btn_whole_assign_update.Click += new System.EventHandler(this.btn_delivered_update_Click);
            // 
            // lbl_assignqty
            // 
            this.lbl_assignqty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_assignqty.AutoSize = true;
            this.lbl_assignqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_assignqty.Location = new System.Drawing.Point(10, 441);
            this.lbl_assignqty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_assignqty.Name = "lbl_assignqty";
            this.lbl_assignqty.Size = new System.Drawing.Size(130, 20);
            this.lbl_assignqty.TabIndex = 22;
            this.lbl_assignqty.Text = "Qty Delivered:";
            // 
            // txt_deliverqty
            // 
            this.txt_deliverqty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_deliverqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_deliverqty.Location = new System.Drawing.Point(15, 465);
            this.txt_deliverqty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_deliverqty.Name = "txt_deliverqty";
            this.txt_deliverqty.Size = new System.Drawing.Size(200, 26);
            this.txt_deliverqty.TabIndex = 21;
            // 
            // fullfill_datagrid
            // 
            this.fullfill_datagrid.AllowUserToAddRows = false;
            this.fullfill_datagrid.AllowUserToDeleteRows = false;
            this.fullfill_datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fullfill_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.fullfill_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fullfill_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.barcode,
            this.name,
            this.type,
            this.qty,
            this.orderqty,
            this.price,
            this.requestqty,
            this.due});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.fullfill_datagrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.fullfill_datagrid.Location = new System.Drawing.Point(15, 46);
            this.fullfill_datagrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fullfill_datagrid.Name = "fullfill_datagrid";
            this.fullfill_datagrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fullfill_datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.fullfill_datagrid.RowHeadersVisible = false;
            this.fullfill_datagrid.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullfill_datagrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.fullfill_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fullfill_datagrid.Size = new System.Drawing.Size(1168, 380);
            this.fullfill_datagrid.TabIndex = 20;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 150;
            // 
            // barcode
            // 
            this.barcode.DataPropertyName = "barcode";
            this.barcode.HeaderText = "Barcode";
            this.barcode.MinimumWidth = 8;
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            this.barcode.Width = 130;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 240;
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 8;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Visible = false;
            this.type.Width = 150;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "qty";
            this.qty.HeaderText = "Qty";
            this.qty.MinimumWidth = 8;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 80;
            // 
            // orderqty
            // 
            this.orderqty.DataPropertyName = "orderqty";
            this.orderqty.HeaderText = "Order Qty";
            this.orderqty.MinimumWidth = 8;
            this.orderqty.Name = "orderqty";
            this.orderqty.ReadOnly = true;
            this.orderqty.Width = 150;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 90;
            // 
            // requestqty
            // 
            this.requestqty.DataPropertyName = "requestqty";
            this.requestqty.HeaderText = "Request Qty";
            this.requestqty.MinimumWidth = 8;
            this.requestqty.Name = "requestqty";
            this.requestqty.ReadOnly = true;
            this.requestqty.Width = 80;
            // 
            // due
            // 
            this.due.DataPropertyName = "due";
            this.due.HeaderText = "Balance Due";
            this.due.MinimumWidth = 8;
            this.due.Name = "due";
            this.due.ReadOnly = true;
            this.due.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_deliver_selected);
            this.panel1.Controls.Add(this.lbl_assignqty);
            this.panel1.Controls.Add(this.btn_deliver_all);
            this.panel1.Controls.Add(this.txt_deliverqty);
            this.panel1.Controls.Add(this.btn_whole_assign_update);
            this.panel1.Controls.Add(this.fullfill_datagrid);
            this.panel1.Controls.Add(this.lbl_whole_cust);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.cbx_fullfill_cust);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 506);
            this.panel1.TabIndex = 26;
            // 
            // Panel_Fulfillment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Panel_Fulfillment";
            this.Size = new System.Drawing.Size(1200, 506);
            ((System.ComponentModel.ISupportInitialize)(this.fullfill_datagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn due;
        private System.Windows.Forms.Panel panel1;
    }
}
