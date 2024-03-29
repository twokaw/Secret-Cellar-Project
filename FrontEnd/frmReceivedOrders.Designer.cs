﻿
namespace SecretCellar
{
    partial class frmReceivedOrders
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceivedOrders));
			this.received_dataGrid = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.minqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maxqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lbl_supplier = new System.Windows.Forms.Label();
			this.cbx_supplier = new System.Windows.Forms.ComboBox();
			this.btn_update = new System.Windows.Forms.Button();
			this.txt_received_qty = new System.Windows.Forms.TextBox();
			this.lbl_qty = new System.Windows.Forms.Label();
			this.btn_all_received = new System.Windows.Forms.Button();
			this.btn_close = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.received_dataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// received_dataGrid
			// 
			this.received_dataGrid.AllowUserToAddRows = false;
			this.received_dataGrid.AllowUserToDeleteRows = false;
			this.received_dataGrid.AllowUserToResizeColumns = false;
			this.received_dataGrid.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Ivory;
			this.received_dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.received_dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.received_dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.received_dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.received_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.received_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.barcode,
            this.name,
            this.ItemType,
            this.qty,
            this.price,
            this.minqty,
            this.maxqty,
            this.orderqty});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.received_dataGrid.DefaultCellStyle = dataGridViewCellStyle3;
			this.received_dataGrid.Location = new System.Drawing.Point(9, 53);
			this.received_dataGrid.Name = "received_dataGrid";
			this.received_dataGrid.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Ivory;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.received_dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.received_dataGrid.RowHeadersVisible = false;
			this.received_dataGrid.RowHeadersWidth = 62;
			this.received_dataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.received_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.received_dataGrid.Size = new System.Drawing.Size(981, 386);
			this.received_dataGrid.TabIndex = 1;
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
			this.barcode.FillWeight = 60F;
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
			this.qty.FillWeight = 15F;
			this.qty.HeaderText = "Qty";
			this.qty.MinimumWidth = 8;
			this.qty.Name = "qty";
			this.qty.ReadOnly = true;
			// 
			// price
			// 
			this.price.DataPropertyName = "Price";
			this.price.FillWeight = 25F;
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
			this.minqty.Visible = false;
			// 
			// maxqty
			// 
			this.maxqty.DataPropertyName = "maxqty";
			this.maxqty.HeaderText = "Max Qty";
			this.maxqty.MinimumWidth = 8;
			this.maxqty.Name = "maxqty";
			this.maxqty.ReadOnly = true;
			this.maxqty.Visible = false;
			// 
			// orderqty
			// 
			this.orderqty.DataPropertyName = "orderqty";
			this.orderqty.FillWeight = 30F;
			this.orderqty.HeaderText = "Order Qty";
			this.orderqty.MinimumWidth = 8;
			this.orderqty.Name = "orderqty";
			this.orderqty.ReadOnly = true;
			// 
			// lbl_supplier
			// 
			this.lbl_supplier.AutoSize = true;
			this.lbl_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_supplier.Location = new System.Drawing.Point(9, 18);
			this.lbl_supplier.Name = "lbl_supplier";
			this.lbl_supplier.Size = new System.Drawing.Size(88, 24);
			this.lbl_supplier.TabIndex = 4;
			this.lbl_supplier.Text = "Supplier";
			// 
			// cbx_supplier
			// 
			this.cbx_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbx_supplier.FormattingEnabled = true;
			this.cbx_supplier.Location = new System.Drawing.Point(103, 15);
			this.cbx_supplier.Name = "cbx_supplier";
			this.cbx_supplier.Size = new System.Drawing.Size(260, 32);
			this.cbx_supplier.TabIndex = 3;
			this.cbx_supplier.SelectedIndexChanged += new System.EventHandler(this.cbx_supplier_SelectedIndexChanged);
			// 
			// btn_update
			// 
			this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_update.Location = new System.Drawing.Point(602, 459);
			this.btn_update.Name = "btn_update";
			this.btn_update.Size = new System.Drawing.Size(154, 45);
			this.btn_update.TabIndex = 16;
			this.btn_update.Text = "Receive";
			this.btn_update.UseVisualStyleBackColor = true;
			this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
			// 
			// txt_received_qty
			// 
			this.txt_received_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_received_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_received_qty.Location = new System.Drawing.Point(392, 473);
			this.txt_received_qty.Name = "txt_received_qty";
			this.txt_received_qty.Size = new System.Drawing.Size(195, 26);
			this.txt_received_qty.TabIndex = 15;
			// 
			// lbl_qty
			// 
			this.lbl_qty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_qty.AutoSize = true;
			this.lbl_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_qty.Location = new System.Drawing.Point(388, 446);
			this.lbl_qty.Name = "lbl_qty";
			this.lbl_qty.Size = new System.Drawing.Size(205, 24);
			this.lbl_qty.TabIndex = 14;
			this.lbl_qty.Text = "Quantity To Receive:";
			// 
			// btn_all_received
			// 
			this.btn_all_received.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_all_received.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_all_received.Location = new System.Drawing.Point(805, 459);
			this.btn_all_received.Name = "btn_all_received";
			this.btn_all_received.Size = new System.Drawing.Size(185, 45);
			this.btn_all_received.TabIndex = 17;
			this.btn_all_received.Text = "Receive All";
			this.btn_all_received.UseVisualStyleBackColor = true;
			this.btn_all_received.Click += new System.EventHandler(this.btn_all_received_Click);
			// 
			// btn_close
			// 
			this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_close.Location = new System.Drawing.Point(9, 459);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(147, 45);
			this.btn_close.TabIndex = 18;
			this.btn_close.Text = "Close";
			this.btn_close.UseVisualStyleBackColor = true;
			this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
			// 
			// frmReceivedOrders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(998, 513);
			this.Controls.Add(this.btn_close);
			this.Controls.Add(this.btn_all_received);
			this.Controls.Add(this.btn_update);
			this.Controls.Add(this.txt_received_qty);
			this.Controls.Add(this.lbl_qty);
			this.Controls.Add(this.lbl_supplier);
			this.Controls.Add(this.cbx_supplier);
			this.Controls.Add(this.received_dataGrid);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmReceivedOrders";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmReceivedOrders";
			this.Load += new System.EventHandler(this.frmReceivedOrders_Load);
			((System.ComponentModel.ISupportInitialize)(this.received_dataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView received_dataGrid;
        private System.Windows.Forms.Label lbl_supplier;
        private System.Windows.Forms.ComboBox cbx_supplier;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_received_qty;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.Button btn_all_received;
        private System.Windows.Forms.Button btn_close;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemType;
		private System.Windows.Forms.DataGridViewTextBoxColumn qty;
		private System.Windows.Forms.DataGridViewTextBoxColumn price;
		private System.Windows.Forms.DataGridViewTextBoxColumn minqty;
		private System.Windows.Forms.DataGridViewTextBoxColumn maxqty;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderqty;
	}
}