
namespace SecretCellar.Settings_Panels
{
    partial class PanTypes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.lstTypes = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.chk_lst_discount = new System.Windows.Forms.CheckedListBox();
			this.lbl_discount = new System.Windows.Forms.Label();
			this.btn_type_clear = new System.Windows.Forms.Button();
			this.lbl_typename = new System.Windows.Forms.Label();
			this.txt_typename = new System.Windows.Forms.TextBox();
			this.btn_update_type = new System.Windows.Forms.Button();
			this.btn_new_type = new System.Windows.Forms.Button();
			this.lbl_localTax = new System.Windows.Forms.Label();
			this.txt_localTax = new System.Windows.Forms.TextBox();
			this.lbl_salesTax = new System.Windows.Forms.Label();
			this.txt_salesTax = new System.Windows.Forms.TextBox();
			this.lbl_bottleDep = new System.Windows.Forms.Label();
			this.txt_bottleDep = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbx_tax = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txt_discount = new System.Windows.Forms.TextBox();
			this.btn_clear_discount = new System.Windows.Forms.Button();
			this.btn_delete_discount = new System.Windows.Forms.Button();
			this.btn_update_discount = new System.Windows.Forms.Button();
			this.txt_dis_name = new System.Windows.Forms.TextBox();
			this.btn_new_discount = new System.Windows.Forms.Button();
			this.lbl_dis_name = new System.Windows.Forms.Label();
			this.lbl_disc = new System.Windows.Forms.Label();
			this.txt_dis_min = new System.Windows.Forms.TextBox();
			this.lbl_dis_min = new System.Windows.Forms.Label();
			this.lbl_dis_max = new System.Windows.Forms.Label();
			this.txt_dis_max = new System.Windows.Forms.TextBox();
			this.button_deleteInventory = new System.Windows.Forms.Button();
			this.textBox_itemsUsingInventory = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstTypes
			// 
			this.lstTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lstTypes.FormattingEnabled = true;
			this.lstTypes.ItemHeight = 16;
			this.lstTypes.Location = new System.Drawing.Point(9, 51);
			this.lstTypes.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
			this.lstTypes.Name = "lstTypes";
			this.lstTypes.Size = new System.Drawing.Size(182, 372);
			this.lstTypes.TabIndex = 0;
			this.lstTypes.SelectedIndexChanged += new System.EventHandler(this.lstTypes_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(9, 19);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(182, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Inventory Type";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// chk_lst_discount
			// 
			this.chk_lst_discount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.chk_lst_discount.FormattingEnabled = true;
			this.chk_lst_discount.Location = new System.Drawing.Point(21, 50);
			this.chk_lst_discount.Margin = new System.Windows.Forms.Padding(6);
			this.chk_lst_discount.Name = "chk_lst_discount";
			this.chk_lst_discount.Size = new System.Drawing.Size(383, 157);
			this.chk_lst_discount.TabIndex = 9;
			this.chk_lst_discount.SelectedIndexChanged += new System.EventHandler(this.chk_lst_discount_SelectedIndexChanged);
			// 
			// lbl_discount
			// 
			this.lbl_discount.Location = new System.Drawing.Point(21, 15);
			this.lbl_discount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lbl_discount.Name = "lbl_discount";
			this.lbl_discount.Size = new System.Drawing.Size(383, 31);
			this.lbl_discount.TabIndex = 37;
			this.lbl_discount.Text = "Discounts";
			this.lbl_discount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_type_clear
			// 
			this.btn_type_clear.Location = new System.Drawing.Point(203, 317);
			this.btn_type_clear.Margin = new System.Windows.Forms.Padding(6);
			this.btn_type_clear.Name = "btn_type_clear";
			this.btn_type_clear.Size = new System.Drawing.Size(108, 35);
			this.btn_type_clear.TabIndex = 6;
			this.btn_type_clear.Text = "Clear";
			this.btn_type_clear.UseVisualStyleBackColor = true;
			this.btn_type_clear.Click += new System.EventHandler(this.btn_type_clear_Click);
			// 
			// lbl_typename
			// 
			this.lbl_typename.Location = new System.Drawing.Point(200, 19);
			this.lbl_typename.Margin = new System.Windows.Forms.Padding(0);
			this.lbl_typename.Name = "lbl_typename";
			this.lbl_typename.Size = new System.Drawing.Size(89, 30);
			this.lbl_typename.TabIndex = 35;
			this.lbl_typename.Text = "Name:";
			// 
			// txt_typename
			// 
			this.txt_typename.Location = new System.Drawing.Point(285, 19);
			this.txt_typename.Margin = new System.Windows.Forms.Padding(6);
			this.txt_typename.Name = "txt_typename";
			this.txt_typename.Size = new System.Drawing.Size(146, 22);
			this.txt_typename.TabIndex = 1;
			// 
			// btn_update_type
			// 
			this.btn_update_type.Location = new System.Drawing.Point(203, 270);
			this.btn_update_type.Margin = new System.Windows.Forms.Padding(6);
			this.btn_update_type.Name = "btn_update_type";
			this.btn_update_type.Size = new System.Drawing.Size(108, 35);
			this.btn_update_type.TabIndex = 8;
			this.btn_update_type.Text = "Update Type";
			this.btn_update_type.UseVisualStyleBackColor = true;
			this.btn_update_type.Click += new System.EventHandler(this.btn_update_type_Click);
			// 
			// btn_new_type
			// 
			this.btn_new_type.Location = new System.Drawing.Point(323, 270);
			this.btn_new_type.Margin = new System.Windows.Forms.Padding(6);
			this.btn_new_type.Name = "btn_new_type";
			this.btn_new_type.Size = new System.Drawing.Size(108, 35);
			this.btn_new_type.TabIndex = 7;
			this.btn_new_type.Text = "New Type";
			this.btn_new_type.UseVisualStyleBackColor = true;
			this.btn_new_type.Click += new System.EventHandler(this.btn_new_type_Click);
			// 
			// lbl_localTax
			// 
			this.lbl_localTax.Location = new System.Drawing.Point(200, 234);
			this.lbl_localTax.Margin = new System.Windows.Forms.Padding(0);
			this.lbl_localTax.Name = "lbl_localTax";
			this.lbl_localTax.Size = new System.Drawing.Size(127, 30);
			this.lbl_localTax.TabIndex = 30;
			this.lbl_localTax.Text = "Local Tax:";
			// 
			// txt_localTax
			// 
			this.txt_localTax.Location = new System.Drawing.Point(318, 234);
			this.txt_localTax.Margin = new System.Windows.Forms.Padding(6);
			this.txt_localTax.Name = "txt_localTax";
			this.txt_localTax.ReadOnly = true;
			this.txt_localTax.Size = new System.Drawing.Size(112, 22);
			this.txt_localTax.TabIndex = 5;
			this.txt_localTax.TabStop = false;
			// 
			// lbl_salesTax
			// 
			this.lbl_salesTax.Location = new System.Drawing.Point(200, 186);
			this.lbl_salesTax.Margin = new System.Windows.Forms.Padding(0);
			this.lbl_salesTax.Name = "lbl_salesTax";
			this.lbl_salesTax.Size = new System.Drawing.Size(127, 30);
			this.lbl_salesTax.TabIndex = 28;
			this.lbl_salesTax.Text = "Sales Tax:";
			// 
			// txt_salesTax
			// 
			this.txt_salesTax.Location = new System.Drawing.Point(318, 186);
			this.txt_salesTax.Margin = new System.Windows.Forms.Padding(6);
			this.txt_salesTax.Name = "txt_salesTax";
			this.txt_salesTax.ReadOnly = true;
			this.txt_salesTax.Size = new System.Drawing.Size(112, 22);
			this.txt_salesTax.TabIndex = 4;
			this.txt_salesTax.TabStop = false;
			// 
			// lbl_bottleDep
			// 
			this.lbl_bottleDep.Location = new System.Drawing.Point(206, 120);
			this.lbl_bottleDep.Margin = new System.Windows.Forms.Padding(0);
			this.lbl_bottleDep.Name = "lbl_bottleDep";
			this.lbl_bottleDep.Size = new System.Drawing.Size(106, 54);
			this.lbl_bottleDep.TabIndex = 26;
			this.lbl_bottleDep.Text = "Bottle Deposit:";
			// 
			// txt_bottleDep
			// 
			this.txt_bottleDep.Location = new System.Drawing.Point(318, 144);
			this.txt_bottleDep.Margin = new System.Windows.Forms.Padding(6);
			this.txt_bottleDep.Name = "txt_bottleDep";
			this.txt_bottleDep.ReadOnly = true;
			this.txt_bottleDep.Size = new System.Drawing.Size(112, 22);
			this.txt_bottleDep.TabIndex = 3;
			this.txt_bottleDep.TabStop = false;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(200, 73);
			this.label3.Margin = new System.Windows.Forms.Padding(0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 33);
			this.label3.TabIndex = 24;
			this.label3.Text = "Tax Type:";
			// 
			// cbx_tax
			// 
			this.cbx_tax.FormattingEnabled = true;
			this.cbx_tax.Location = new System.Drawing.Point(318, 73);
			this.cbx_tax.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
			this.cbx_tax.Name = "cbx_tax";
			this.cbx_tax.Size = new System.Drawing.Size(112, 24);
			this.cbx_tax.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(206)))));
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(909, 482);
			this.panel1.TabIndex = 39;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(201)))), ((int)(((byte)(176)))));
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.textBox_itemsUsingInventory);
			this.panel3.Controls.Add(this.button_deleteInventory);
			this.panel3.Controls.Add(this.txt_typename);
			this.panel3.Controls.Add(this.txt_localTax);
			this.panel3.Controls.Add(this.btn_type_clear);
			this.panel3.Controls.Add(this.cbx_tax);
			this.panel3.Controls.Add(this.lstTypes);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.lbl_typename);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.txt_bottleDep);
			this.panel3.Controls.Add(this.lbl_bottleDep);
			this.panel3.Controls.Add(this.btn_update_type);
			this.panel3.Controls.Add(this.txt_salesTax);
			this.panel3.Controls.Add(this.btn_new_type);
			this.panel3.Controls.Add(this.lbl_salesTax);
			this.panel3.Controls.Add(this.lbl_localTax);
			this.panel3.Location = new System.Drawing.Point(14, 14);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(450, 445);
			this.panel3.TabIndex = 48;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(201)))), ((int)(((byte)(176)))));
			this.panel2.Controls.Add(this.txt_discount);
			this.panel2.Controls.Add(this.btn_clear_discount);
			this.panel2.Controls.Add(this.lbl_discount);
			this.panel2.Controls.Add(this.btn_delete_discount);
			this.panel2.Controls.Add(this.chk_lst_discount);
			this.panel2.Controls.Add(this.btn_update_discount);
			this.panel2.Controls.Add(this.txt_dis_name);
			this.panel2.Controls.Add(this.btn_new_discount);
			this.panel2.Controls.Add(this.lbl_dis_name);
			this.panel2.Controls.Add(this.lbl_disc);
			this.panel2.Controls.Add(this.txt_dis_min);
			this.panel2.Controls.Add(this.lbl_dis_min);
			this.panel2.Controls.Add(this.lbl_dis_max);
			this.panel2.Controls.Add(this.txt_dis_max);
			this.panel2.Location = new System.Drawing.Point(481, 14);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(414, 445);
			this.panel2.TabIndex = 47;
			// 
			// txt_discount
			// 
			this.txt_discount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txt_discount.Location = new System.Drawing.Point(115, 305);
			this.txt_discount.Margin = new System.Windows.Forms.Padding(6);
			this.txt_discount.Name = "txt_discount";
			this.txt_discount.Size = new System.Drawing.Size(150, 22);
			this.txt_discount.TabIndex = 11;
			// 
			// btn_clear_discount
			// 
			this.btn_clear_discount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_clear_discount.Location = new System.Drawing.Point(296, 255);
			this.btn_clear_discount.Margin = new System.Windows.Forms.Padding(0);
			this.btn_clear_discount.Name = "btn_clear_discount";
			this.btn_clear_discount.Size = new System.Drawing.Size(108, 35);
			this.btn_clear_discount.TabIndex = 14;
			this.btn_clear_discount.Text = "Clear Discount ";
			this.btn_clear_discount.UseVisualStyleBackColor = true;
			this.btn_clear_discount.Click += new System.EventHandler(this.btn_clear_discount_Click);
			// 
			// btn_delete_discount
			// 
			this.btn_delete_discount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_delete_discount.ForeColor = System.Drawing.Color.Red;
			this.btn_delete_discount.Location = new System.Drawing.Point(296, 397);
			this.btn_delete_discount.Margin = new System.Windows.Forms.Padding(0);
			this.btn_delete_discount.Name = "btn_delete_discount";
			this.btn_delete_discount.Size = new System.Drawing.Size(108, 35);
			this.btn_delete_discount.TabIndex = 17;
			this.btn_delete_discount.Text = "Delete Discount";
			this.btn_delete_discount.UseVisualStyleBackColor = true;
			this.btn_delete_discount.Click += new System.EventHandler(this.btn_delete_discount_Click);
			// 
			// btn_update_discount
			// 
			this.btn_update_discount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_update_discount.Location = new System.Drawing.Point(296, 354);
			this.btn_update_discount.Margin = new System.Windows.Forms.Padding(0);
			this.btn_update_discount.Name = "btn_update_discount";
			this.btn_update_discount.Size = new System.Drawing.Size(108, 35);
			this.btn_update_discount.TabIndex = 15;
			this.btn_update_discount.Text = "Update Discount";
			this.btn_update_discount.UseVisualStyleBackColor = true;
			this.btn_update_discount.Click += new System.EventHandler(this.btn_update_discount_Click);
			// 
			// txt_dis_name
			// 
			this.txt_dis_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txt_dis_name.Location = new System.Drawing.Point(115, 259);
			this.txt_dis_name.Margin = new System.Windows.Forms.Padding(6);
			this.txt_dis_name.Name = "txt_dis_name";
			this.txt_dis_name.Size = new System.Drawing.Size(150, 22);
			this.txt_dis_name.TabIndex = 10;
			// 
			// btn_new_discount
			// 
			this.btn_new_discount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_new_discount.Location = new System.Drawing.Point(296, 298);
			this.btn_new_discount.Margin = new System.Windows.Forms.Padding(0);
			this.btn_new_discount.Name = "btn_new_discount";
			this.btn_new_discount.Size = new System.Drawing.Size(108, 35);
			this.btn_new_discount.TabIndex = 16;
			this.btn_new_discount.Text = "New Discount";
			this.btn_new_discount.UseVisualStyleBackColor = true;
			this.btn_new_discount.Click += new System.EventHandler(this.btn_new_discount_Click);
			// 
			// lbl_dis_name
			// 
			this.lbl_dis_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_dis_name.Location = new System.Drawing.Point(11, 262);
			this.lbl_dis_name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lbl_dis_name.Name = "lbl_dis_name";
			this.lbl_dis_name.Size = new System.Drawing.Size(103, 32);
			this.lbl_dis_name.TabIndex = 40;
			this.lbl_dis_name.Text = "Name:";
			// 
			// lbl_disc
			// 
			this.lbl_disc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_disc.Location = new System.Drawing.Point(11, 303);
			this.lbl_disc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lbl_disc.Name = "lbl_disc";
			this.lbl_disc.Size = new System.Drawing.Size(108, 32);
			this.lbl_disc.TabIndex = 46;
			this.lbl_disc.Text = "Discount:";
			// 
			// txt_dis_min
			// 
			this.txt_dis_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txt_dis_min.Location = new System.Drawing.Point(115, 350);
			this.txt_dis_min.Margin = new System.Windows.Forms.Padding(6);
			this.txt_dis_min.Name = "txt_dis_min";
			this.txt_dis_min.Size = new System.Drawing.Size(150, 22);
			this.txt_dis_min.TabIndex = 12;
			// 
			// lbl_dis_min
			// 
			this.lbl_dis_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_dis_min.Location = new System.Drawing.Point(11, 345);
			this.lbl_dis_min.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lbl_dis_min.Name = "lbl_dis_min";
			this.lbl_dis_min.Size = new System.Drawing.Size(103, 35);
			this.lbl_dis_min.TabIndex = 42;
			this.lbl_dis_min.Text = "Min Qty:";
			// 
			// lbl_dis_max
			// 
			this.lbl_dis_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_dis_max.Location = new System.Drawing.Point(11, 394);
			this.lbl_dis_max.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lbl_dis_max.Name = "lbl_dis_max";
			this.lbl_dis_max.Size = new System.Drawing.Size(103, 35);
			this.lbl_dis_max.TabIndex = 44;
			this.lbl_dis_max.Text = "Max Qty:";
			// 
			// txt_dis_max
			// 
			this.txt_dis_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txt_dis_max.Location = new System.Drawing.Point(115, 399);
			this.txt_dis_max.Margin = new System.Windows.Forms.Padding(6);
			this.txt_dis_max.Name = "txt_dis_max";
			this.txt_dis_max.Size = new System.Drawing.Size(150, 22);
			this.txt_dis_max.TabIndex = 13;
			// 
			// button_deleteInventory
			// 
			this.button_deleteInventory.Location = new System.Drawing.Point(336, 404);
			this.button_deleteInventory.Margin = new System.Windows.Forms.Padding(6);
			this.button_deleteInventory.Name = "button_deleteInventory";
			this.button_deleteInventory.Size = new System.Drawing.Size(108, 35);
			this.button_deleteInventory.TabIndex = 36;
			this.button_deleteInventory.Text = "Delete";
			this.button_deleteInventory.UseVisualStyleBackColor = true;
			this.button_deleteInventory.Click += new System.EventHandler(this.button_deleteInventory_Click);
			// 
			// textBox_itemsUsingInventory
			// 
			this.textBox_itemsUsingInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_itemsUsingInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.textBox_itemsUsingInventory.Location = new System.Drawing.Point(209, 410);
			this.textBox_itemsUsingInventory.Name = "textBox_itemsUsingInventory";
			this.textBox_itemsUsingInventory.ReadOnly = true;
			this.textBox_itemsUsingInventory.Size = new System.Drawing.Size(108, 22);
			this.textBox_itemsUsingInventory.TabIndex = 37;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(208, 368);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 39);
			this.label2.TabIndex = 38;
			this.label2.Text = "Items Using Inventory Type:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PanTypes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "PanTypes";
			this.Size = new System.Drawing.Size(909, 482);
			this.Load += new System.EventHandler(this.PanTypes_Load);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chk_lst_discount;
        private System.Windows.Forms.Label lbl_discount;
        private System.Windows.Forms.Button btn_type_clear;
        private System.Windows.Forms.Label lbl_typename;
        private System.Windows.Forms.TextBox txt_typename;
        private System.Windows.Forms.Button btn_update_type;
        private System.Windows.Forms.Button btn_new_type;
        private System.Windows.Forms.Label lbl_localTax;
        private System.Windows.Forms.TextBox txt_localTax;
        private System.Windows.Forms.Label lbl_salesTax;
        private System.Windows.Forms.TextBox txt_salesTax;
        private System.Windows.Forms.Label lbl_bottleDep;
        private System.Windows.Forms.TextBox txt_bottleDep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_tax;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_dis_max;
        private System.Windows.Forms.TextBox txt_dis_max;
        private System.Windows.Forms.Label lbl_dis_min;
        private System.Windows.Forms.TextBox txt_dis_min;
        private System.Windows.Forms.Label lbl_dis_name;
        private System.Windows.Forms.TextBox txt_dis_name;
        private System.Windows.Forms.Button btn_delete_discount;
        private System.Windows.Forms.Button btn_update_discount;
        private System.Windows.Forms.Button btn_new_discount;
        private System.Windows.Forms.Label lbl_disc;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.Button btn_clear_discount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button_deleteInventory;
		private System.Windows.Forms.TextBox textBox_itemsUsingInventory;
		private System.Windows.Forms.Label label2;
	}
}
