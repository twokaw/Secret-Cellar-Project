
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
            this.txt_orderIncrement = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Bottles = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaxQty = new System.Windows.Forms.TextBox();
            this.textBox_itemsUsingInventory = new System.Windows.Forms.TextBox();
            this.button_deleteInventory = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MinQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTypes
            // 
            this.lstTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstTypes.FormattingEnabled = true;
            this.lstTypes.ItemHeight = 16;
            this.lstTypes.Location = new System.Drawing.Point(31, 66);
            this.lstTypes.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.lstTypes.Name = "lstTypes";
            this.lstTypes.Size = new System.Drawing.Size(182, 356);
            this.lstTypes.TabIndex = 0;
            this.lstTypes.SelectedIndexChanged += new System.EventHandler(this.lstTypes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(31, 34);
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
            this.chk_lst_discount.Location = new System.Drawing.Point(545, 118);
            this.chk_lst_discount.Margin = new System.Windows.Forms.Padding(6);
            this.chk_lst_discount.Name = "chk_lst_discount";
            this.chk_lst_discount.Size = new System.Drawing.Size(317, 140);
            this.chk_lst_discount.TabIndex = 9;
            this.chk_lst_discount.SelectedIndexChanged += new System.EventHandler(this.chk_lst_discount_SelectedIndexChanged);
            // 
            // lbl_discount
            // 
            this.lbl_discount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_discount.Location = new System.Drawing.Point(590, 76);
            this.lbl_discount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_discount.Name = "lbl_discount";
            this.lbl_discount.Size = new System.Drawing.Size(234, 31);
            this.lbl_discount.TabIndex = 37;
            this.lbl_discount.Text = "Discounts";
            this.lbl_discount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_type_clear
            // 
            this.btn_type_clear.Location = new System.Drawing.Point(689, 293);
            this.btn_type_clear.Margin = new System.Windows.Forms.Padding(6);
            this.btn_type_clear.Name = "btn_type_clear";
            this.btn_type_clear.Size = new System.Drawing.Size(122, 35);
            this.btn_type_clear.TabIndex = 6;
            this.btn_type_clear.Text = "Clear";
            this.btn_type_clear.UseVisualStyleBackColor = true;
            this.btn_type_clear.Click += new System.EventHandler(this.btn_type_clear_Click);
            // 
            // lbl_typename
            // 
            this.lbl_typename.Location = new System.Drawing.Point(222, 27);
            this.lbl_typename.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_typename.Name = "lbl_typename";
            this.lbl_typename.Size = new System.Drawing.Size(89, 30);
            this.lbl_typename.TabIndex = 35;
            this.lbl_typename.Text = "Name:";
            // 
            // txt_typename
            // 
            this.txt_typename.Location = new System.Drawing.Point(307, 27);
            this.txt_typename.Margin = new System.Windows.Forms.Padding(6);
            this.txt_typename.Name = "txt_typename";
            this.txt_typename.Size = new System.Drawing.Size(203, 22);
            this.txt_typename.TabIndex = 1;
            // 
            // btn_update_type
            // 
            this.btn_update_type.Location = new System.Drawing.Point(545, 340);
            this.btn_update_type.Margin = new System.Windows.Forms.Padding(6);
            this.btn_update_type.Name = "btn_update_type";
            this.btn_update_type.Size = new System.Drawing.Size(122, 35);
            this.btn_update_type.TabIndex = 8;
            this.btn_update_type.Text = "Update Type";
            this.btn_update_type.UseVisualStyleBackColor = true;
            this.btn_update_type.Click += new System.EventHandler(this.btn_update_type_Click);
            // 
            // btn_new_type
            // 
            this.btn_new_type.Location = new System.Drawing.Point(545, 293);
            this.btn_new_type.Margin = new System.Windows.Forms.Padding(6);
            this.btn_new_type.Name = "btn_new_type";
            this.btn_new_type.Size = new System.Drawing.Size(122, 35);
            this.btn_new_type.TabIndex = 7;
            this.btn_new_type.Text = "New Type";
            this.btn_new_type.UseVisualStyleBackColor = true;
            this.btn_new_type.Click += new System.EventHandler(this.btn_new_type_Click);
            // 
            // lbl_localTax
            // 
            this.lbl_localTax.Location = new System.Drawing.Point(224, 331);
            this.lbl_localTax.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_localTax.Name = "lbl_localTax";
            this.lbl_localTax.Size = new System.Drawing.Size(127, 30);
            this.lbl_localTax.TabIndex = 30;
            this.lbl_localTax.Text = "Local Tax:";
            // 
            // txt_localTax
            // 
            this.txt_localTax.Location = new System.Drawing.Point(398, 331);
            this.txt_localTax.Margin = new System.Windows.Forms.Padding(6);
            this.txt_localTax.Name = "txt_localTax";
            this.txt_localTax.ReadOnly = true;
            this.txt_localTax.Size = new System.Drawing.Size(113, 22);
            this.txt_localTax.TabIndex = 5;
            this.txt_localTax.TabStop = false;
            // 
            // lbl_salesTax
            // 
            this.lbl_salesTax.Location = new System.Drawing.Point(223, 292);
            this.lbl_salesTax.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_salesTax.Name = "lbl_salesTax";
            this.lbl_salesTax.Size = new System.Drawing.Size(127, 30);
            this.lbl_salesTax.TabIndex = 28;
            this.lbl_salesTax.Text = "Sales Tax:";
            // 
            // txt_salesTax
            // 
            this.txt_salesTax.Location = new System.Drawing.Point(398, 293);
            this.txt_salesTax.Margin = new System.Windows.Forms.Padding(6);
            this.txt_salesTax.Name = "txt_salesTax";
            this.txt_salesTax.ReadOnly = true;
            this.txt_salesTax.Size = new System.Drawing.Size(113, 22);
            this.txt_salesTax.TabIndex = 4;
            this.txt_salesTax.TabStop = false;
            // 
            // lbl_bottleDep
            // 
            this.lbl_bottleDep.Location = new System.Drawing.Point(224, 255);
            this.lbl_bottleDep.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_bottleDep.Name = "lbl_bottleDep";
            this.lbl_bottleDep.Size = new System.Drawing.Size(124, 30);
            this.lbl_bottleDep.TabIndex = 26;
            this.lbl_bottleDep.Text = "Btl Deposit:";
            // 
            // txt_bottleDep
            // 
            this.txt_bottleDep.Location = new System.Drawing.Point(398, 255);
            this.txt_bottleDep.Margin = new System.Windows.Forms.Padding(6);
            this.txt_bottleDep.Name = "txt_bottleDep";
            this.txt_bottleDep.ReadOnly = true;
            this.txt_bottleDep.Size = new System.Drawing.Size(113, 22);
            this.txt_bottleDep.TabIndex = 3;
            this.txt_bottleDep.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(223, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 33);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tax Type:";
            // 
            // cbx_tax
            // 
            this.cbx_tax.FormattingEnabled = true;
            this.cbx_tax.Location = new System.Drawing.Point(398, 217);
            this.cbx_tax.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.cbx_tax.Name = "cbx_tax";
            this.cbx_tax.Size = new System.Drawing.Size(112, 24);
            this.cbx_tax.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.panel3);
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
            this.panel3.Controls.Add(this.lbl_discount);
            this.panel3.Controls.Add(this.txt_orderIncrement);
            this.panel3.Controls.Add(this.chk_lst_discount);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txt_Bottles);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txt_MaxQty);
            this.panel3.Controls.Add(this.textBox_itemsUsingInventory);
            this.panel3.Controls.Add(this.button_deleteInventory);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_typename);
            this.panel3.Controls.Add(this.txt_localTax);
            this.panel3.Controls.Add(this.txt_MinQty);
            this.panel3.Controls.Add(this.btn_type_clear);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cbx_tax);
            this.panel3.Controls.Add(this.lstTypes);
            this.panel3.Controls.Add(this.label6);
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
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(903, 476);
            this.panel3.TabIndex = 48;
            this.panel3.VisibleChanged += new System.EventHandler(this.panel3_VisibleChanged);
            // 
            // txt_orderIncrement
            // 
            this.txt_orderIncrement.Location = new System.Drawing.Point(398, 141);
            this.txt_orderIncrement.Margin = new System.Windows.Forms.Padding(6);
            this.txt_orderIncrement.Name = "txt_orderIncrement";
            this.txt_orderIncrement.Size = new System.Drawing.Size(113, 22);
            this.txt_orderIncrement.TabIndex = 45;
            this.txt_orderIncrement.TabStop = false;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(222, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 30);
            this.label7.TabIndex = 46;
            this.label7.Text = "Order Increment:";
            // 
            // txt_Bottles
            // 
            this.txt_Bottles.Location = new System.Drawing.Point(398, 179);
            this.txt_Bottles.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Bottles.Name = "txt_Bottles";
            this.txt_Bottles.Size = new System.Drawing.Size(113, 22);
            this.txt_Bottles.TabIndex = 41;
            this.txt_Bottles.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(221, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 32);
            this.label2.TabIndex = 38;
            this.label2.Text = "Number of Items:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_MaxQty
            // 
            this.txt_MaxQty.Location = new System.Drawing.Point(398, 65);
            this.txt_MaxQty.Margin = new System.Windows.Forms.Padding(6);
            this.txt_MaxQty.Name = "txt_MaxQty";
            this.txt_MaxQty.Size = new System.Drawing.Size(113, 22);
            this.txt_MaxQty.TabIndex = 39;
            this.txt_MaxQty.TabStop = false;
            // 
            // textBox_itemsUsingInventory
            // 
            this.textBox_itemsUsingInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_itemsUsingInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBox_itemsUsingInventory.Location = new System.Drawing.Point(398, 412);
            this.textBox_itemsUsingInventory.Name = "textBox_itemsUsingInventory";
            this.textBox_itemsUsingInventory.ReadOnly = true;
            this.textBox_itemsUsingInventory.Size = new System.Drawing.Size(164, 22);
            this.textBox_itemsUsingInventory.TabIndex = 37;
            // 
            // button_deleteInventory
            // 
            this.button_deleteInventory.Location = new System.Drawing.Point(689, 340);
            this.button_deleteInventory.Margin = new System.Windows.Forms.Padding(6);
            this.button_deleteInventory.Name = "button_deleteInventory";
            this.button_deleteInventory.Size = new System.Drawing.Size(122, 35);
            this.button_deleteInventory.TabIndex = 36;
            this.button_deleteInventory.Text = "Delete";
            this.button_deleteInventory.UseVisualStyleBackColor = true;
            this.button_deleteInventory.Click += new System.EventHandler(this.button_deleteInventory_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(221, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 30);
            this.label4.TabIndex = 42;
            this.label4.Text = "Max Qty:";
            // 
            // txt_MinQty
            // 
            this.txt_MinQty.Location = new System.Drawing.Point(398, 103);
            this.txt_MinQty.Margin = new System.Windows.Forms.Padding(6);
            this.txt_MinQty.Name = "txt_MinQty";
            this.txt_MinQty.Size = new System.Drawing.Size(113, 22);
            this.txt_MinQty.TabIndex = 40;
            this.txt_MinQty.TabStop = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(224, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 30);
            this.label5.TabIndex = 43;
            this.label5.Text = "Min Qty:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(224, 179);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 30);
            this.label6.TabIndex = 44;
            this.label6.Text = "Bottles:";
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
        private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button button_deleteInventory;
		private System.Windows.Forms.TextBox textBox_itemsUsingInventory;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Bottles;
        private System.Windows.Forms.TextBox txt_MaxQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MinQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_orderIncrement;
        private System.Windows.Forms.Label label7;
    }
}
