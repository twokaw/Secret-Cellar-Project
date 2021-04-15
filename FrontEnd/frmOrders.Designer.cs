
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cust_order = new System.Windows.Forms.TabPage();
            this.cust_order_dataGrid = new System.Windows.Forms.DataGridView();
            this.cust_request = new System.Windows.Forms.TabPage();
            this.request_dataGrid = new System.Windows.Forms.DataGridView();
            this.supp_order = new System.Windows.Forms.TabPage();
            this.supp_dataGrid = new System.Windows.Forms.DataGridView();
            this.cust_name = new System.Windows.Forms.TextBox();
            this.lbl_cust_name = new System.Windows.Forms.Label();
            this.lbl_product = new System.Windows.Forms.Label();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.cbx_supplier = new System.Windows.Forms.ComboBox();
            this.lbl_supplier = new System.Windows.Forms.Label();
            this.lbl_cust_subtotal = new System.Windows.Forms.Label();
            this.txt_cust_subtotal = new System.Windows.Forms.TextBox();
            this.lbl_cust_total = new System.Windows.Forms.Label();
            this.txt_cust_total = new System.Windows.Forms.TextBox();
            this.lbl_cust_tax = new System.Windows.Forms.Label();
            this.txt_cust_tax = new System.Windows.Forms.TextBox();
            this.pu_dateTime = new System.Windows.Forms.DateTimePicker();
            this.lbl_pu_date = new System.Windows.Forms.Label();
            this.lbl_supp_total = new System.Windows.Forms.Label();
            this.txt_supp_total = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.cust_order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cust_order_dataGrid)).BeginInit();
            this.cust_request.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.request_dataGrid)).BeginInit();
            this.supp_order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supp_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.cust_order);
            this.tabControl1.Controls.Add(this.cust_request);
            this.tabControl1.Controls.Add(this.supp_order);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1160, 528);
            this.tabControl1.TabIndex = 0;
            // 
            // cust_order
            // 
            this.cust_order.Controls.Add(this.lbl_pu_date);
            this.cust_order.Controls.Add(this.pu_dateTime);
            this.cust_order.Controls.Add(this.lbl_cust_tax);
            this.cust_order.Controls.Add(this.txt_cust_tax);
            this.cust_order.Controls.Add(this.lbl_cust_total);
            this.cust_order.Controls.Add(this.txt_cust_total);
            this.cust_order.Controls.Add(this.lbl_cust_subtotal);
            this.cust_order.Controls.Add(this.txt_cust_subtotal);
            this.cust_order.Controls.Add(this.lbl_product);
            this.cust_order.Controls.Add(this.txt_product);
            this.cust_order.Controls.Add(this.lbl_cust_name);
            this.cust_order.Controls.Add(this.cust_name);
            this.cust_order.Controls.Add(this.cust_order_dataGrid);
            this.cust_order.Location = new System.Drawing.Point(4, 29);
            this.cust_order.Name = "cust_order";
            this.cust_order.Padding = new System.Windows.Forms.Padding(3);
            this.cust_order.Size = new System.Drawing.Size(1152, 495);
            this.cust_order.TabIndex = 0;
            this.cust_order.Text = "Customer Order";
            this.cust_order.UseVisualStyleBackColor = true;
            // 
            // cust_order_dataGrid
            // 
            this.cust_order_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cust_order_dataGrid.Location = new System.Drawing.Point(21, 127);
            this.cust_order_dataGrid.Name = "cust_order_dataGrid";
            this.cust_order_dataGrid.Size = new System.Drawing.Size(800, 300);
            this.cust_order_dataGrid.TabIndex = 0;
            // 
            // cust_request
            // 
            this.cust_request.Controls.Add(this.request_dataGrid);
            this.cust_request.Location = new System.Drawing.Point(4, 29);
            this.cust_request.Name = "cust_request";
            this.cust_request.Padding = new System.Windows.Forms.Padding(3);
            this.cust_request.Size = new System.Drawing.Size(1152, 495);
            this.cust_request.TabIndex = 1;
            this.cust_request.Text = "Customer Request";
            this.cust_request.UseVisualStyleBackColor = true;
            // 
            // request_dataGrid
            // 
            this.request_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.request_dataGrid.Location = new System.Drawing.Point(18, 61);
            this.request_dataGrid.Name = "request_dataGrid";
            this.request_dataGrid.Size = new System.Drawing.Size(800, 300);
            this.request_dataGrid.TabIndex = 0;
            // 
            // supp_order
            // 
            this.supp_order.Controls.Add(this.txt_supp_total);
            this.supp_order.Controls.Add(this.lbl_supp_total);
            this.supp_order.Controls.Add(this.lbl_supplier);
            this.supp_order.Controls.Add(this.cbx_supplier);
            this.supp_order.Controls.Add(this.supp_dataGrid);
            this.supp_order.Location = new System.Drawing.Point(4, 29);
            this.supp_order.Name = "supp_order";
            this.supp_order.Padding = new System.Windows.Forms.Padding(3);
            this.supp_order.Size = new System.Drawing.Size(1152, 495);
            this.supp_order.TabIndex = 2;
            this.supp_order.Text = "Supplier Order";
            this.supp_order.UseVisualStyleBackColor = true;
            // 
            // supp_dataGrid
            // 
            this.supp_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supp_dataGrid.Location = new System.Drawing.Point(25, 107);
            this.supp_dataGrid.Name = "supp_dataGrid";
            this.supp_dataGrid.Size = new System.Drawing.Size(800, 300);
            this.supp_dataGrid.TabIndex = 0;
            // 
            // cust_name
            // 
            this.cust_name.Location = new System.Drawing.Point(193, 63);
            this.cust_name.Name = "cust_name";
            this.cust_name.Size = new System.Drawing.Size(183, 26);
            this.cust_name.TabIndex = 1;
            // 
            // lbl_cust_name
            // 
            this.lbl_cust_name.AutoSize = true;
            this.lbl_cust_name.Location = new System.Drawing.Point(30, 65);
            this.lbl_cust_name.Name = "lbl_cust_name";
            this.lbl_cust_name.Size = new System.Drawing.Size(137, 20);
            this.lbl_cust_name.TabIndex = 2;
            this.lbl_cust_name.Text = "Customer Name";
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.Location = new System.Drawing.Point(506, 66);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(76, 20);
            this.lbl_product.TabIndex = 4;
            this.lbl_product.Text = "Barcode";
            // 
            // txt_product
            // 
            this.txt_product.Location = new System.Drawing.Point(602, 64);
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(219, 26);
            this.txt_product.TabIndex = 3;
            // 
            // cbx_supplier
            // 
            this.cbx_supplier.FormattingEnabled = true;
            this.cbx_supplier.Location = new System.Drawing.Point(195, 55);
            this.cbx_supplier.Name = "cbx_supplier";
            this.cbx_supplier.Size = new System.Drawing.Size(260, 28);
            this.cbx_supplier.TabIndex = 1;
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
            // lbl_cust_subtotal
            // 
            this.lbl_cust_subtotal.AutoSize = true;
            this.lbl_cust_subtotal.Location = new System.Drawing.Point(903, 311);
            this.lbl_cust_subtotal.Name = "lbl_cust_subtotal";
            this.lbl_cust_subtotal.Size = new System.Drawing.Size(77, 20);
            this.lbl_cust_subtotal.TabIndex = 6;
            this.lbl_cust_subtotal.Text = "Subtotal";
            // 
            // txt_cust_subtotal
            // 
            this.txt_cust_subtotal.Location = new System.Drawing.Point(999, 309);
            this.txt_cust_subtotal.Name = "txt_cust_subtotal";
            this.txt_cust_subtotal.Size = new System.Drawing.Size(135, 26);
            this.txt_cust_subtotal.TabIndex = 5;
            // 
            // lbl_cust_total
            // 
            this.lbl_cust_total.AutoSize = true;
            this.lbl_cust_total.Location = new System.Drawing.Point(903, 403);
            this.lbl_cust_total.Name = "lbl_cust_total";
            this.lbl_cust_total.Size = new System.Drawing.Size(49, 20);
            this.lbl_cust_total.TabIndex = 8;
            this.lbl_cust_total.Text = "Total";
            // 
            // txt_cust_total
            // 
            this.txt_cust_total.Location = new System.Drawing.Point(999, 401);
            this.txt_cust_total.Name = "txt_cust_total";
            this.txt_cust_total.Size = new System.Drawing.Size(135, 26);
            this.txt_cust_total.TabIndex = 7;
            // 
            // lbl_cust_tax
            // 
            this.lbl_cust_tax.AutoSize = true;
            this.lbl_cust_tax.Location = new System.Drawing.Point(903, 359);
            this.lbl_cust_tax.Name = "lbl_cust_tax";
            this.lbl_cust_tax.Size = new System.Drawing.Size(37, 20);
            this.lbl_cust_tax.TabIndex = 10;
            this.lbl_cust_tax.Text = "Tax";
            // 
            // txt_cust_tax
            // 
            this.txt_cust_tax.Location = new System.Drawing.Point(999, 357);
            this.txt_cust_tax.Name = "txt_cust_tax";
            this.txt_cust_tax.Size = new System.Drawing.Size(135, 26);
            this.txt_cust_tax.TabIndex = 9;
            // 
            // pu_dateTime
            // 
            this.pu_dateTime.Location = new System.Drawing.Point(948, 87);
            this.pu_dateTime.Name = "pu_dateTime";
            this.pu_dateTime.Size = new System.Drawing.Size(191, 26);
            this.pu_dateTime.TabIndex = 11;
            // 
            // lbl_pu_date
            // 
            this.lbl_pu_date.AutoSize = true;
            this.lbl_pu_date.Location = new System.Drawing.Point(848, 89);
            this.lbl_pu_date.Name = "lbl_pu_date";
            this.lbl_pu_date.Size = new System.Drawing.Size(94, 20);
            this.lbl_pu_date.TabIndex = 12;
            this.lbl_pu_date.Text = "Est Pickup";
            // 
            // lbl_supp_total
            // 
            this.lbl_supp_total.AutoSize = true;
            this.lbl_supp_total.Location = new System.Drawing.Point(868, 373);
            this.lbl_supp_total.Name = "lbl_supp_total";
            this.lbl_supp_total.Size = new System.Drawing.Size(49, 20);
            this.lbl_supp_total.TabIndex = 3;
            this.lbl_supp_total.Text = "Total";
            // 
            // txt_supp_total
            // 
            this.txt_supp_total.Location = new System.Drawing.Point(943, 372);
            this.txt_supp_total.Name = "txt_supp_total";
            this.txt_supp_total.Size = new System.Drawing.Size(135, 26);
            this.txt_supp_total.TabIndex = 4;
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmOrders";
            this.Text = "frmOrders";
            this.tabControl1.ResumeLayout(false);
            this.cust_order.ResumeLayout(false);
            this.cust_order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cust_order_dataGrid)).EndInit();
            this.cust_request.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.request_dataGrid)).EndInit();
            this.supp_order.ResumeLayout(false);
            this.supp_order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supp_dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage cust_order;
        private System.Windows.Forms.TabPage cust_request;
        private System.Windows.Forms.TabPage supp_order;
        private System.Windows.Forms.DataGridView cust_order_dataGrid;
        private System.Windows.Forms.DataGridView request_dataGrid;
        private System.Windows.Forms.DataGridView supp_dataGrid;
        private System.Windows.Forms.TextBox cust_name;
        private System.Windows.Forms.Label lbl_pu_date;
        private System.Windows.Forms.DateTimePicker pu_dateTime;
        private System.Windows.Forms.Label lbl_cust_tax;
        private System.Windows.Forms.TextBox txt_cust_tax;
        private System.Windows.Forms.Label lbl_cust_total;
        private System.Windows.Forms.TextBox txt_cust_total;
        private System.Windows.Forms.Label lbl_cust_subtotal;
        private System.Windows.Forms.TextBox txt_cust_subtotal;
        private System.Windows.Forms.Label lbl_product;
        private System.Windows.Forms.TextBox txt_product;
        private System.Windows.Forms.Label lbl_cust_name;
        private System.Windows.Forms.TextBox txt_supp_total;
        private System.Windows.Forms.Label lbl_supp_total;
        private System.Windows.Forms.Label lbl_supplier;
        private System.Windows.Forms.ComboBox cbx_supplier;
    }
}