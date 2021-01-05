﻿
namespace SecretCellar
{
    partial class frmCustomer
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
            this.pnl_change_info = new System.Windows.Forms.Panel();
            this.customer_data_grid = new System.Windows.Forms.DataGridView();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.txt_box_customer_name = new System.Windows.Forms.TextBox();
            this.chkbox_tab = new System.Windows.Forms.CheckBox();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.business_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isWholesale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addr1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addr2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customer_data_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_change_info
            // 
            this.pnl_change_info.Location = new System.Drawing.Point(952, 76);
            this.pnl_change_info.Name = "pnl_change_info";
            this.pnl_change_info.Size = new System.Drawing.Size(360, 480);
            this.pnl_change_info.TabIndex = 0;
            // 
            // customer_data_grid
            // 
            this.customer_data_grid.AllowUserToOrderColumns = true;
            this.customer_data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_data_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerID,
            this.customer_discount,
            this.first_name,
            this.last_name,
            this.business_name,
            this.email,
            this.isWholesale,
            this.addr1,
            this.addr2,
            this.city,
            this.state,
            this.zip,
            this.phone});
            this.customer_data_grid.Location = new System.Drawing.Point(29, 76);
            this.customer_data_grid.Name = "customer_data_grid";
            this.customer_data_grid.Size = new System.Drawing.Size(788, 540);
            this.customer_data_grid.TabIndex = 1;
            this.customer_data_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customer_data_grid_CellContentClick);
            // 
            // lbl_customer
            // 
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customer.Location = new System.Drawing.Point(98, 35);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(122, 17);
            this.lbl_customer.TabIndex = 2;
            this.lbl_customer.Text = "Customer Name";
            // 
            // txt_box_customer_name
            // 
            this.txt_box_customer_name.Location = new System.Drawing.Point(243, 35);
            this.txt_box_customer_name.Name = "txt_box_customer_name";
            this.txt_box_customer_name.Size = new System.Drawing.Size(248, 20);
            this.txt_box_customer_name.TabIndex = 3;
            // 
            // chkbox_tab
            // 
            this.chkbox_tab.AutoSize = true;
            this.chkbox_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbox_tab.Location = new System.Drawing.Point(659, 36);
            this.chkbox_tab.Name = "chkbox_tab";
            this.chkbox_tab.Size = new System.Drawing.Size(430, 21);
            this.chkbox_tab.TabIndex = 4;
            this.chkbox_tab.Text = "Customers with Suspended Transaction or Balance Due";
            this.chkbox_tab.UseVisualStyleBackColor = true;
            // 
            // customerID
            // 
            this.customerID.HeaderText = "Customer ID";
            this.customerID.Name = "customerID";
            this.customerID.Visible = false;
            // 
            // customer_discount
            // 
            this.customer_discount.HeaderText = "Customer Discount";
            this.customer_discount.Name = "customer_discount";
            // 
            // first_name
            // 
            this.first_name.HeaderText = "First";
            this.first_name.Name = "first_name";
            // 
            // last_name
            // 
            this.last_name.HeaderText = "Last";
            this.last_name.Name = "last_name";
            // 
            // business_name
            // 
            this.business_name.HeaderText = "Company";
            this.business_name.Name = "business_name";
            // 
            // email
            // 
            this.email.HeaderText = "email";
            this.email.Name = "email";
            // 
            // isWholesale
            // 
            this.isWholesale.HeaderText = "Wholesale";
            this.isWholesale.Name = "isWholesale";
            // 
            // addr1
            // 
            this.addr1.HeaderText = "Address 1";
            this.addr1.Name = "addr1";
            // 
            // addr2
            // 
            this.addr2.HeaderText = "Address 2";
            this.addr2.Name = "addr2";
            // 
            // city
            // 
            this.city.HeaderText = "City";
            this.city.Name = "city";
            // 
            // state
            // 
            this.state.HeaderText = "State";
            this.state.Name = "state";
            // 
            // zip
            // 
            this.zip.HeaderText = "Zip Code";
            this.zip.Name = "zip";
            // 
            // phone
            // 
            this.phone.HeaderText = "Phone Number";
            this.phone.Name = "phone";
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1384, 661);
            this.Controls.Add(this.chkbox_tab);
            this.Controls.Add(this.txt_box_customer_name);
            this.Controls.Add(this.lbl_customer);
            this.Controls.Add(this.customer_data_grid);
            this.Controls.Add(this.pnl_change_info);
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCustomer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customer_data_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_change_info;
        private System.Windows.Forms.DataGridView customer_data_grid;
        private System.Windows.Forms.Label lbl_customer;
        private System.Windows.Forms.TextBox txt_box_customer_name;
        private System.Windows.Forms.CheckBox chkbox_tab;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn business_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn isWholesale;
        private System.Windows.Forms.DataGridViewTextBoxColumn addr1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addr2;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn zip;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
    }
}