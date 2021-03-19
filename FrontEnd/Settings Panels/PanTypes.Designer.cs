
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
            this.lbl_dis_max = new System.Windows.Forms.Label();
            this.txt_dis_max = new System.Windows.Forms.TextBox();
            this.lbl_dis_min = new System.Windows.Forms.Label();
            this.txt_dis_min = new System.Windows.Forms.TextBox();
            this.lbl_dis_name = new System.Windows.Forms.Label();
            this.txt_dis_name = new System.Windows.Forms.TextBox();
            this.lbl_disc = new System.Windows.Forms.Label();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.btn_new_discount = new System.Windows.Forms.Button();
            this.btn_update_discount = new System.Windows.Forms.Button();
            this.btn_delete_discount = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTypes
            // 
            this.lstTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstTypes.FormattingEnabled = true;
            this.lstTypes.ItemHeight = 16;
            this.lstTypes.Location = new System.Drawing.Point(22, 62);
            this.lstTypes.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.lstTypes.Name = "lstTypes";
            this.lstTypes.Size = new System.Drawing.Size(182, 276);
            this.lstTypes.TabIndex = 0;
            this.lstTypes.SelectedIndexChanged += new System.EventHandler(this.lstTypes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chk_lst_discount
            // 
            this.chk_lst_discount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_lst_discount.FormattingEnabled = true;
            this.chk_lst_discount.Location = new System.Drawing.Point(626, 50);
            this.chk_lst_discount.Margin = new System.Windows.Forms.Padding(6);
            this.chk_lst_discount.Name = "chk_lst_discount";
            this.chk_lst_discount.Size = new System.Drawing.Size(246, 123);
            this.chk_lst_discount.TabIndex = 38;
            this.chk_lst_discount.SelectedIndexChanged += new System.EventHandler(this.chk_lst_discount_SelectedIndexChanged);
            // 
            // lbl_discount
            // 
            this.lbl_discount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_discount.Location = new System.Drawing.Point(626, 11);
            this.lbl_discount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_discount.Name = "lbl_discount";
            this.lbl_discount.Size = new System.Drawing.Size(246, 32);
            this.lbl_discount.TabIndex = 37;
            this.lbl_discount.Text = "Discounts";
            this.lbl_discount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_type_clear
            // 
            this.btn_type_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_type_clear.Location = new System.Drawing.Point(421, 45);
            this.btn_type_clear.Margin = new System.Windows.Forms.Padding(6);
            this.btn_type_clear.Name = "btn_type_clear";
            this.btn_type_clear.Size = new System.Drawing.Size(146, 45);
            this.btn_type_clear.TabIndex = 36;
            this.btn_type_clear.Text = "Clear";
            this.btn_type_clear.UseVisualStyleBackColor = true;
            this.btn_type_clear.Click += new System.EventHandler(this.btn_type_clear_Click);
            // 
            // lbl_typename
            // 
            this.lbl_typename.AutoSize = true;
            this.lbl_typename.Location = new System.Drawing.Point(236, 18);
            this.lbl_typename.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_typename.Name = "lbl_typename";
            this.lbl_typename.Size = new System.Drawing.Size(89, 16);
            this.lbl_typename.TabIndex = 35;
            this.lbl_typename.Text = "Type Name";
            // 
            // txt_typename
            // 
            this.txt_typename.Location = new System.Drawing.Point(240, 45);
            this.txt_typename.Margin = new System.Windows.Forms.Padding(6);
            this.txt_typename.Name = "txt_typename";
            this.txt_typename.Size = new System.Drawing.Size(155, 22);
            this.txt_typename.TabIndex = 34;
            // 
            // btn_update_type
            // 
            this.btn_update_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_type.Location = new System.Drawing.Point(421, 159);
            this.btn_update_type.Margin = new System.Windows.Forms.Padding(6);
            this.btn_update_type.Name = "btn_update_type";
            this.btn_update_type.Size = new System.Drawing.Size(146, 45);
            this.btn_update_type.TabIndex = 32;
            this.btn_update_type.Text = "Update Type";
            this.btn_update_type.UseVisualStyleBackColor = true;
            this.btn_update_type.Click += new System.EventHandler(this.btn_update_type_Click);
            // 
            // btn_new_type
            // 
            this.btn_new_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_new_type.Location = new System.Drawing.Point(421, 102);
            this.btn_new_type.Margin = new System.Windows.Forms.Padding(6);
            this.btn_new_type.Name = "btn_new_type";
            this.btn_new_type.Size = new System.Drawing.Size(146, 45);
            this.btn_new_type.TabIndex = 31;
            this.btn_new_type.Text = "New Type";
            this.btn_new_type.UseVisualStyleBackColor = true;
            this.btn_new_type.Click += new System.EventHandler(this.btn_new_type_Click);
            // 
            // lbl_localTax
            // 
            this.lbl_localTax.AutoSize = true;
            this.lbl_localTax.Location = new System.Drawing.Point(235, 275);
            this.lbl_localTax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_localTax.Name = "lbl_localTax";
            this.lbl_localTax.Size = new System.Drawing.Size(76, 16);
            this.lbl_localTax.TabIndex = 30;
            this.lbl_localTax.Text = "Local Tax";
            // 
            // txt_localTax
            // 
            this.txt_localTax.Location = new System.Drawing.Point(241, 301);
            this.txt_localTax.Margin = new System.Windows.Forms.Padding(6);
            this.txt_localTax.Name = "txt_localTax";
            this.txt_localTax.ReadOnly = true;
            this.txt_localTax.Size = new System.Drawing.Size(155, 22);
            this.txt_localTax.TabIndex = 29;
            // 
            // lbl_salesTax
            // 
            this.lbl_salesTax.AutoSize = true;
            this.lbl_salesTax.Location = new System.Drawing.Point(236, 210);
            this.lbl_salesTax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_salesTax.Name = "lbl_salesTax";
            this.lbl_salesTax.Size = new System.Drawing.Size(78, 16);
            this.lbl_salesTax.TabIndex = 28;
            this.lbl_salesTax.Text = "Sales Tax";
            // 
            // txt_salesTax
            // 
            this.txt_salesTax.Location = new System.Drawing.Point(242, 236);
            this.txt_salesTax.Margin = new System.Windows.Forms.Padding(6);
            this.txt_salesTax.Name = "txt_salesTax";
            this.txt_salesTax.ReadOnly = true;
            this.txt_salesTax.Size = new System.Drawing.Size(155, 22);
            this.txt_salesTax.TabIndex = 27;
            // 
            // lbl_bottleDep
            // 
            this.lbl_bottleDep.AutoSize = true;
            this.lbl_bottleDep.Location = new System.Drawing.Point(235, 145);
            this.lbl_bottleDep.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_bottleDep.Name = "lbl_bottleDep";
            this.lbl_bottleDep.Size = new System.Drawing.Size(106, 16);
            this.lbl_bottleDep.TabIndex = 26;
            this.lbl_bottleDep.Text = "Bottle Deposit";
            // 
            // txt_bottleDep
            // 
            this.txt_bottleDep.Location = new System.Drawing.Point(239, 176);
            this.txt_bottleDep.Margin = new System.Windows.Forms.Padding(6);
            this.txt_bottleDep.Name = "txt_bottleDep";
            this.txt_bottleDep.ReadOnly = true;
            this.txt_bottleDep.Size = new System.Drawing.Size(155, 22);
            this.txt_bottleDep.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(236, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tax Type";
            // 
            // cbx_tax
            // 
            this.cbx_tax.FormattingEnabled = true;
            this.cbx_tax.Location = new System.Drawing.Point(240, 109);
            this.cbx_tax.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.cbx_tax.Name = "cbx_tax";
            this.cbx_tax.Size = new System.Drawing.Size(155, 24);
            this.cbx_tax.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_delete_discount);
            this.panel1.Controls.Add(this.btn_update_discount);
            this.panel1.Controls.Add(this.btn_new_discount);
            this.panel1.Controls.Add(this.lbl_disc);
            this.panel1.Controls.Add(this.txt_discount);
            this.panel1.Controls.Add(this.lbl_dis_max);
            this.panel1.Controls.Add(this.txt_dis_max);
            this.panel1.Controls.Add(this.lbl_dis_min);
            this.panel1.Controls.Add(this.txt_dis_min);
            this.panel1.Controls.Add(this.lbl_dis_name);
            this.panel1.Controls.Add(this.txt_dis_name);
            this.panel1.Controls.Add(this.lstTypes);
            this.panel1.Controls.Add(this.chk_lst_discount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_discount);
            this.panel1.Controls.Add(this.btn_type_clear);
            this.panel1.Controls.Add(this.cbx_tax);
            this.panel1.Controls.Add(this.lbl_typename);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_typename);
            this.panel1.Controls.Add(this.txt_bottleDep);
            this.panel1.Controls.Add(this.lbl_bottleDep);
            this.panel1.Controls.Add(this.btn_update_type);
            this.panel1.Controls.Add(this.txt_salesTax);
            this.panel1.Controls.Add(this.btn_new_type);
            this.panel1.Controls.Add(this.lbl_salesTax);
            this.panel1.Controls.Add(this.lbl_localTax);
            this.panel1.Controls.Add(this.txt_localTax);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 387);
            this.panel1.TabIndex = 39;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_dis_max
            // 
            this.lbl_dis_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dis_max.AutoSize = true;
            this.lbl_dis_max.Location = new System.Drawing.Point(752, 238);
            this.lbl_dis_max.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_dis_max.Name = "lbl_dis_max";
            this.lbl_dis_max.Size = new System.Drawing.Size(127, 16);
            this.lbl_dis_max.TabIndex = 44;
            this.lbl_dis_max.Text = "Discount Max Qty";
            // 
            // txt_dis_max
            // 
            this.txt_dis_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dis_max.Location = new System.Drawing.Point(755, 263);
            this.txt_dis_max.Margin = new System.Windows.Forms.Padding(6);
            this.txt_dis_max.Name = "txt_dis_max";
            this.txt_dis_max.Size = new System.Drawing.Size(120, 22);
            this.txt_dis_max.TabIndex = 43;
            // 
            // lbl_dis_min
            // 
            this.lbl_dis_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dis_min.AutoSize = true;
            this.lbl_dis_min.Location = new System.Drawing.Point(585, 238);
            this.lbl_dis_min.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_dis_min.Name = "lbl_dis_min";
            this.lbl_dis_min.Size = new System.Drawing.Size(123, 16);
            this.lbl_dis_min.TabIndex = 42;
            this.lbl_dis_min.Text = "Discount Min Qty";
            // 
            // txt_dis_min
            // 
            this.txt_dis_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dis_min.Location = new System.Drawing.Point(588, 263);
            this.txt_dis_min.Margin = new System.Windows.Forms.Padding(6);
            this.txt_dis_min.Name = "txt_dis_min";
            this.txt_dis_min.Size = new System.Drawing.Size(120, 22);
            this.txt_dis_min.TabIndex = 41;
            // 
            // lbl_dis_name
            // 
            this.lbl_dis_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dis_name.AutoSize = true;
            this.lbl_dis_name.Location = new System.Drawing.Point(585, 185);
            this.lbl_dis_name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_dis_name.Name = "lbl_dis_name";
            this.lbl_dis_name.Size = new System.Drawing.Size(113, 16);
            this.lbl_dis_name.TabIndex = 40;
            this.lbl_dis_name.Text = "Discount Name";
            // 
            // txt_dis_name
            // 
            this.txt_dis_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dis_name.Location = new System.Drawing.Point(588, 210);
            this.txt_dis_name.Margin = new System.Windows.Forms.Padding(6);
            this.txt_dis_name.Name = "txt_dis_name";
            this.txt_dis_name.Size = new System.Drawing.Size(155, 22);
            this.txt_dis_name.TabIndex = 39;
            // 
            // lbl_disc
            // 
            this.lbl_disc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_disc.AutoSize = true;
            this.lbl_disc.Location = new System.Drawing.Point(753, 184);
            this.lbl_disc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_disc.Name = "lbl_disc";
            this.lbl_disc.Size = new System.Drawing.Size(68, 16);
            this.lbl_disc.TabIndex = 46;
            this.lbl_disc.Text = "Discount";
            // 
            // txt_discount
            // 
            this.txt_discount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_discount.Location = new System.Drawing.Point(755, 210);
            this.txt_discount.Margin = new System.Windows.Forms.Padding(6);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(120, 22);
            this.txt_discount.TabIndex = 45;
            // 
            // btn_new_discount
            // 
            this.btn_new_discount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_new_discount.Location = new System.Drawing.Point(588, 299);
            this.btn_new_discount.Name = "btn_new_discount";
            this.btn_new_discount.Size = new System.Drawing.Size(133, 23);
            this.btn_new_discount.TabIndex = 47;
            this.btn_new_discount.Text = "New Discount";
            this.btn_new_discount.UseVisualStyleBackColor = true;
            this.btn_new_discount.Click += new System.EventHandler(this.btn_new_discount_Click);
            // 
            // btn_update_discount
            // 
            this.btn_update_discount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_discount.Location = new System.Drawing.Point(739, 300);
            this.btn_update_discount.Name = "btn_update_discount";
            this.btn_update_discount.Size = new System.Drawing.Size(133, 23);
            this.btn_update_discount.TabIndex = 48;
            this.btn_update_discount.Text = "Update Discount";
            this.btn_update_discount.UseVisualStyleBackColor = true;
            // 
            // btn_delete_discount
            // 
            this.btn_delete_discount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete_discount.ForeColor = System.Drawing.Color.Red;
            this.btn_delete_discount.Location = new System.Drawing.Point(665, 340);
            this.btn_delete_discount.Name = "btn_delete_discount";
            this.btn_delete_discount.Size = new System.Drawing.Size(133, 23);
            this.btn_delete_discount.TabIndex = 49;
            this.btn_delete_discount.Text = "Delete Discount";
            this.btn_delete_discount.UseVisualStyleBackColor = true;
            // 
            // PanTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PanTypes";
            this.Size = new System.Drawing.Size(890, 387);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}
