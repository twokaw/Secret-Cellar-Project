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
            this.txt_zip = new System.Windows.Forms.TextBox();
            this.lbl_zip = new System.Windows.Forms.Label();
            this.txt_state = new System.Windows.Forms.TextBox();
            this.lbl_state = new System.Windows.Forms.Label();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.lbl_city = new System.Windows.Forms.Label();
            this.txt_addr2 = new System.Windows.Forms.TextBox();
            this.lbl_addr2 = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_addr1 = new System.Windows.Forms.TextBox();
            this.lbl_addr1 = new System.Windows.Forms.Label();
            this.txt_company = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.lbl_customerdiscount = new System.Windows.Forms.Label();
            this.txt_custDisc = new System.Windows.Forms.TextBox();
            this.lbl_company = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.cbo_wholesale = new System.Windows.Forms.ComboBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_wholesale = new System.Windows.Forms.Label();
            this.customer_data_grid = new System.Windows.Forms.DataGridView();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.business_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isWholesale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addr1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addr2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.txt_box_customer_name = new System.Windows.Forms.TextBox();
            this.chkbox_wholesale = new System.Windows.Forms.CheckBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.pnl_change_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_data_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_change_info
            // 
            this.pnl_change_info.Controls.Add(this.txt_zip);
            this.pnl_change_info.Controls.Add(this.lbl_zip);
            this.pnl_change_info.Controls.Add(this.txt_state);
            this.pnl_change_info.Controls.Add(this.lbl_state);
            this.pnl_change_info.Controls.Add(this.txt_city);
            this.pnl_change_info.Controls.Add(this.lbl_city);
            this.pnl_change_info.Controls.Add(this.txt_addr2);
            this.pnl_change_info.Controls.Add(this.lbl_addr2);
            this.pnl_change_info.Controls.Add(this.btn_new);
            this.pnl_change_info.Controls.Add(this.btn_update);
            this.pnl_change_info.Controls.Add(this.txt_addr1);
            this.pnl_change_info.Controls.Add(this.lbl_addr1);
            this.pnl_change_info.Controls.Add(this.txt_company);
            this.pnl_change_info.Controls.Add(this.txt_fname);
            this.pnl_change_info.Controls.Add(this.lbl_fname);
            this.pnl_change_info.Controls.Add(this.lbl_customerdiscount);
            this.pnl_change_info.Controls.Add(this.txt_custDisc);
            this.pnl_change_info.Controls.Add(this.lbl_company);
            this.pnl_change_info.Controls.Add(this.lbl_phone);
            this.pnl_change_info.Controls.Add(this.txt_phone);
            this.pnl_change_info.Controls.Add(this.cbo_wholesale);
            this.pnl_change_info.Controls.Add(this.txt_lname);
            this.pnl_change_info.Controls.Add(this.lbl_lname);
            this.pnl_change_info.Controls.Add(this.lbl_email);
            this.pnl_change_info.Controls.Add(this.txt_email);
            this.pnl_change_info.Controls.Add(this.lbl_wholesale);
            this.pnl_change_info.Location = new System.Drawing.Point(978, 76);
            this.pnl_change_info.Name = "pnl_change_info";
            this.pnl_change_info.Size = new System.Drawing.Size(376, 480);
            this.pnl_change_info.TabIndex = 0;
            this.pnl_change_info.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_change_info_Paint);
            // 
            // txt_zip
            // 
            this.txt_zip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_zip.Location = new System.Drawing.Point(137, 338);
            this.txt_zip.Margin = new System.Windows.Forms.Padding(4);
            this.txt_zip.Name = "txt_zip";
            this.txt_zip.Size = new System.Drawing.Size(229, 20);
            this.txt_zip.TabIndex = 48;
            // 
            // lbl_zip
            // 
            this.lbl_zip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_zip.Location = new System.Drawing.Point(-1, 335);
            this.lbl_zip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_zip.Name = "lbl_zip";
            this.lbl_zip.Size = new System.Drawing.Size(69, 25);
            this.lbl_zip.TabIndex = 47;
            this.lbl_zip.Text = "Zip Code:";
            this.lbl_zip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_state
            // 
            this.txt_state.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_state.Location = new System.Drawing.Point(137, 310);
            this.txt_state.Margin = new System.Windows.Forms.Padding(4);
            this.txt_state.Name = "txt_state";
            this.txt_state.Size = new System.Drawing.Size(229, 20);
            this.txt_state.TabIndex = 46;
            // 
            // lbl_state
            // 
            this.lbl_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_state.Location = new System.Drawing.Point(-1, 307);
            this.lbl_state.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(45, 25);
            this.lbl_state.TabIndex = 45;
            this.lbl_state.Text = "State:";
            this.lbl_state.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_city
            // 
            this.txt_city.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_city.Location = new System.Drawing.Point(137, 282);
            this.txt_city.Margin = new System.Windows.Forms.Padding(4);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(229, 20);
            this.txt_city.TabIndex = 44;
            // 
            // lbl_city
            // 
            this.lbl_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_city.Location = new System.Drawing.Point(-1, 279);
            this.lbl_city.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(37, 25);
            this.lbl_city.TabIndex = 43;
            this.lbl_city.Text = "City:";
            this.lbl_city.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_addr2
            // 
            this.txt_addr2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_addr2.Location = new System.Drawing.Point(137, 254);
            this.txt_addr2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_addr2.Name = "txt_addr2";
            this.txt_addr2.Size = new System.Drawing.Size(229, 20);
            this.txt_addr2.TabIndex = 42;
            // 
            // lbl_addr2
            // 
            this.lbl_addr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addr2.Location = new System.Drawing.Point(-1, 251);
            this.lbl_addr2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_addr2.Name = "lbl_addr2";
            this.lbl_addr2.Size = new System.Drawing.Size(78, 25);
            this.lbl_addr2.TabIndex = 41;
            this.lbl_addr2.Text = "Address 2:";
            this.lbl_addr2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_new
            // 
            this.btn_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(100, 422);
            this.btn_new.Margin = new System.Windows.Forms.Padding(4);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(129, 37);
            this.btn_new.TabIndex = 40;
            this.btn_new.Text = "New Customer";
            this.btn_new.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(242, 422);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(110, 37);
            this.btn_update.TabIndex = 39;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // txt_addr1
            // 
            this.txt_addr1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_addr1.Location = new System.Drawing.Point(137, 226);
            this.txt_addr1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_addr1.Name = "txt_addr1";
            this.txt_addr1.Size = new System.Drawing.Size(230, 20);
            this.txt_addr1.TabIndex = 38;
            // 
            // lbl_addr1
            // 
            this.lbl_addr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addr1.Location = new System.Drawing.Point(-1, 223);
            this.lbl_addr1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_addr1.Name = "lbl_addr1";
            this.lbl_addr1.Size = new System.Drawing.Size(79, 25);
            this.lbl_addr1.TabIndex = 37;
            this.lbl_addr1.Text = "Address 1:";
            this.lbl_addr1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_company
            // 
            this.txt_company.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_company.Location = new System.Drawing.Point(137, 140);
            this.txt_company.Margin = new System.Windows.Forms.Padding(4);
            this.txt_company.Name = "txt_company";
            this.txt_company.Size = new System.Drawing.Size(230, 20);
            this.txt_company.TabIndex = 36;
            // 
            // txt_fname
            // 
            this.txt_fname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_fname.Location = new System.Drawing.Point(137, 56);
            this.txt_fname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(231, 20);
            this.txt_fname.TabIndex = 35;
            // 
            // lbl_fname
            // 
            this.lbl_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fname.Location = new System.Drawing.Point(2, 53);
            this.lbl_fname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(82, 25);
            this.lbl_fname.TabIndex = 34;
            this.lbl_fname.Text = "First Name:";
            this.lbl_fname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_customerdiscount
            // 
            this.lbl_customerdiscount.AutoSize = true;
            this.lbl_customerdiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerdiscount.Location = new System.Drawing.Point(3, 199);
            this.lbl_customerdiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_customerdiscount.Name = "lbl_customerdiscount";
            this.lbl_customerdiscount.Size = new System.Drawing.Size(132, 15);
            this.lbl_customerdiscount.TabIndex = 31;
            this.lbl_customerdiscount.Text = "Customer Discount:";
            // 
            // txt_custDisc
            // 
            this.txt_custDisc.Location = new System.Drawing.Point(137, 197);
            this.txt_custDisc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_custDisc.Name = "txt_custDisc";
            this.txt_custDisc.Size = new System.Drawing.Size(231, 20);
            this.txt_custDisc.TabIndex = 30;
            // 
            // lbl_company
            // 
            this.lbl_company.AutoSize = true;
            this.lbl_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_company.Location = new System.Drawing.Point(3, 143);
            this.lbl_company.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_company.Name = "lbl_company";
            this.lbl_company.Size = new System.Drawing.Size(70, 15);
            this.lbl_company.TabIndex = 29;
            this.lbl_company.Text = "Company:";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.Location = new System.Drawing.Point(4, 87);
            this.lbl_phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(52, 15);
            this.lbl_phone.TabIndex = 27;
            this.lbl_phone.Text = "Phone:";
            // 
            // txt_phone
            // 
            this.txt_phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_phone.Location = new System.Drawing.Point(137, 84);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(231, 20);
            this.txt_phone.TabIndex = 26;
            // 
            // cbo_wholesale
            // 
            this.cbo_wholesale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_wholesale.DisplayMember = "TypeName";
            this.cbo_wholesale.FormattingEnabled = true;
            this.cbo_wholesale.Location = new System.Drawing.Point(137, 168);
            this.cbo_wholesale.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_wholesale.Name = "cbo_wholesale";
            this.cbo_wholesale.Size = new System.Drawing.Size(230, 21);
            this.cbo_wholesale.TabIndex = 23;
            this.cbo_wholesale.SelectedIndexChanged += new System.EventHandler(this.cbo_wholesale_SelectedIndexChanged);
            // 
            // txt_lname
            // 
            this.txt_lname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_lname.Location = new System.Drawing.Point(137, 28);
            this.txt_lname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(231, 20);
            this.txt_lname.TabIndex = 19;
            // 
            // lbl_lname
            // 
            this.lbl_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lname.Location = new System.Drawing.Point(2, 25);
            this.lbl_lname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(82, 25);
            this.lbl_lname.TabIndex = 18;
            this.lbl_lname.Text = "Last Name:";
            this.lbl_lname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_email
            // 
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(-4, 109);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(55, 25);
            this.lbl_email.TabIndex = 20;
            this.lbl_email.Text = "email:";
            this.lbl_email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_email
            // 
            this.txt_email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_email.Location = new System.Drawing.Point(137, 112);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(231, 20);
            this.txt_email.TabIndex = 21;
            // 
            // lbl_wholesale
            // 
            this.lbl_wholesale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wholesale.Location = new System.Drawing.Point(2, 164);
            this.lbl_wholesale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_wholesale.Name = "lbl_wholesale";
            this.lbl_wholesale.Size = new System.Drawing.Size(82, 25);
            this.lbl_wholesale.TabIndex = 22;
            this.lbl_wholesale.Text = "Wholesale:";
            this.lbl_wholesale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // customer_data_grid
            // 
            this.customer_data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_data_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerID,
            this.last_name,
            this.first_name,
            this.phone,
            this.email,
            this.business_name,
            this.isWholesale,
            this.customer_discount,
            this.addr1,
            this.addr2,
            this.city,
            this.state,
            this.zip});
            this.customer_data_grid.Location = new System.Drawing.Point(26, 76);
            this.customer_data_grid.Name = "customer_data_grid";
            this.customer_data_grid.RowHeadersVisible = false;
            this.customer_data_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customer_data_grid.Size = new System.Drawing.Size(903, 540);
            this.customer_data_grid.TabIndex = 1;
            this.customer_data_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customer_data_grid_CellContentClick);
            this.customer_data_grid.SelectionChanged += new System.EventHandler(this.customergrid_SelectionChanged);
            // 
            // customerID
            // 
            this.customerID.DataPropertyName = "customerID";
            this.customerID.HeaderText = "Customer ID";
            this.customerID.Name = "customerID";
            this.customerID.Visible = false;
            // 
            // last_name
            // 
            this.last_name.DataPropertyName = "last_name";
            this.last_name.HeaderText = "Last";
            this.last_name.Name = "last_name";
            // 
            // first_name
            // 
            this.first_name.DataPropertyName = "first_name";
            this.first_name.HeaderText = "First";
            this.first_name.Name = "first_name";
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Phone Number";
            this.phone.Name = "phone";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            // 
            // business_name
            // 
            this.business_name.DataPropertyName = "business_name";
            this.business_name.HeaderText = "Company";
            this.business_name.Name = "business_name";
            // 
            // isWholesale
            // 
            this.isWholesale.DataPropertyName = "isWholesale";
            this.isWholesale.HeaderText = "Wholesale";
            this.isWholesale.Name = "isWholesale";
            // 
            // customer_discount
            // 
            this.customer_discount.DataPropertyName = "customerDiscount";
            this.customer_discount.HeaderText = "Customer Discount";
            this.customer_discount.Name = "customer_discount";
            // 
            // addr1
            // 
            this.addr1.DataPropertyName = "addr1";
            this.addr1.HeaderText = "Address 1";
            this.addr1.Name = "addr1";
            // 
            // addr2
            // 
            this.addr2.DataPropertyName = "addr2";
            this.addr2.HeaderText = "Address 2";
            this.addr2.Name = "addr2";
            // 
            // city
            // 
            this.city.DataPropertyName = "city";
            this.city.HeaderText = "City";
            this.city.Name = "city";
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "State";
            this.state.Name = "state";
            // 
            // zip
            // 
            this.zip.DataPropertyName = "zip";
            this.zip.HeaderText = "Zip Code";
            this.zip.Name = "zip";
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
            this.txt_box_customer_name.TextChanged += new System.EventHandler(this.txt_box_customer_name_TextChanged);
            // 
            // chkbox_wholesale
            // 
            this.chkbox_wholesale.AutoSize = true;
            this.chkbox_wholesale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbox_wholesale.Location = new System.Drawing.Point(659, 36);
            this.chkbox_wholesale.Name = "chkbox_wholesale";
            this.chkbox_wholesale.Size = new System.Drawing.Size(213, 21);
            this.chkbox_wholesale.TabIndex = 4;
            this.chkbox_wholesale.Text = "Wholesale Customer Only";
            this.chkbox_wholesale.UseVisualStyleBackColor = true;
            this.chkbox_wholesale.CheckedChanged += new System.EventHandler(this.chkbox_wholesale_CheckedChanged);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(1078, 579);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(110, 37);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(1220, 579);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(111, 37);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1384, 661);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.chkbox_wholesale);
            this.Controls.Add(this.txt_box_customer_name);
            this.Controls.Add(this.lbl_customer);
            this.Controls.Add(this.customer_data_grid);
            this.Controls.Add(this.pnl_change_info);
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCustomer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.pnl_change_info.ResumeLayout(false);
            this.pnl_change_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_data_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_change_info;
        private System.Windows.Forms.DataGridView customer_data_grid;
        private System.Windows.Forms.Label lbl_customer;
        private System.Windows.Forms.TextBox txt_box_customer_name;
        private System.Windows.Forms.CheckBox chkbox_wholesale;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn business_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn isWholesale;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn addr1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addr2;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn zip;
        private System.Windows.Forms.TextBox txt_addr1;
        private System.Windows.Forms.Label lbl_addr1;
        private System.Windows.Forms.TextBox txt_company;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Label lbl_customerdiscount;
        private System.Windows.Forms.TextBox txt_custDisc;
        private System.Windows.Forms.Label lbl_company;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.ComboBox cbo_wholesale;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_wholesale;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_zip;
        private System.Windows.Forms.Label lbl_zip;
        private System.Windows.Forms.TextBox txt_state;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.TextBox txt_addr2;
        private System.Windows.Forms.Label lbl_addr2;
    }
}