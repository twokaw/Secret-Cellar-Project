
namespace SecretCellar.Settings_Panels
{
    partial class PanTax
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
			this.btn_update_tax = new System.Windows.Forms.Button();
			this.lst_tax_list = new System.Windows.Forms.ListBox();
			this.lbl_btl_deposit = new System.Windows.Forms.Label();
			this.lbl_local_tax = new System.Windows.Forms.Label();
			this.lbl_sales_tax = new System.Windows.Forms.Label();
			this.txt_bottle_dep = new System.Windows.Forms.TextBox();
			this.txt_local_tax = new System.Windows.Forms.TextBox();
			this.txt_sales_tax = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox_deleteTax = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button_deleteTax = new System.Windows.Forms.Button();
			this.textBox_itemsUsingTax = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnSetDiscount = new System.Windows.Forms.Button();
			this.txt_CashDiscount = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txt_tax_type_name = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_new = new System.Windows.Forms.Button();
			this.btn_clear = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.groupBox_deleteTax.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_update_tax
			// 
			this.btn_update_tax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_update_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.btn_update_tax.Location = new System.Drawing.Point(221, 249);
			this.btn_update_tax.Name = "btn_update_tax";
			this.btn_update_tax.Size = new System.Drawing.Size(133, 35);
			this.btn_update_tax.TabIndex = 8;
			this.btn_update_tax.Text = "Update";
			this.btn_update_tax.UseVisualStyleBackColor = true;
			this.btn_update_tax.Click += new System.EventHandler(this.btn_update_tax_Click);
			// 
			// lst_tax_list
			// 
			this.lst_tax_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lst_tax_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.lst_tax_list.FormattingEnabled = true;
			this.lst_tax_list.ItemHeight = 16;
			this.lst_tax_list.Location = new System.Drawing.Point(15, 42);
			this.lst_tax_list.Name = "lst_tax_list";
			this.lst_tax_list.Size = new System.Drawing.Size(120, 212);
			this.lst_tax_list.TabIndex = 1;
			this.lst_tax_list.SelectedIndexChanged += new System.EventHandler(this.lst_tax_list_SelectedIndexChanged);
			// 
			// lbl_btl_deposit
			// 
			this.lbl_btl_deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.lbl_btl_deposit.Location = new System.Drawing.Point(141, 110);
			this.lbl_btl_deposit.Name = "lbl_btl_deposit";
			this.lbl_btl_deposit.Size = new System.Drawing.Size(111, 16);
			this.lbl_btl_deposit.TabIndex = 14;
			this.lbl_btl_deposit.Text = "Bottle Deposit:";
			this.lbl_btl_deposit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_local_tax
			// 
			this.lbl_local_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.lbl_local_tax.Location = new System.Drawing.Point(154, 84);
			this.lbl_local_tax.Name = "lbl_local_tax";
			this.lbl_local_tax.Size = new System.Drawing.Size(99, 18);
			this.lbl_local_tax.TabIndex = 13;
			this.lbl_local_tax.Text = "Local Tax:";
			this.lbl_local_tax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_sales_tax
			// 
			this.lbl_sales_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.lbl_sales_tax.Location = new System.Drawing.Point(157, 57);
			this.lbl_sales_tax.Name = "lbl_sales_tax";
			this.lbl_sales_tax.Size = new System.Drawing.Size(95, 16);
			this.lbl_sales_tax.TabIndex = 12;
			this.lbl_sales_tax.Text = "Sales Tax:";
			this.lbl_sales_tax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt_bottle_dep
			// 
			this.txt_bottle_dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.txt_bottle_dep.Location = new System.Drawing.Point(258, 110);
			this.txt_bottle_dep.Name = "txt_bottle_dep";
			this.txt_bottle_dep.Size = new System.Drawing.Size(97, 22);
			this.txt_bottle_dep.TabIndex = 5;
			// 
			// txt_local_tax
			// 
			this.txt_local_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.txt_local_tax.Location = new System.Drawing.Point(258, 82);
			this.txt_local_tax.Name = "txt_local_tax";
			this.txt_local_tax.Size = new System.Drawing.Size(97, 22);
			this.txt_local_tax.TabIndex = 4;
			// 
			// txt_sales_tax
			// 
			this.txt_sales_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.txt_sales_tax.Location = new System.Drawing.Point(258, 53);
			this.txt_sales_tax.Name = "txt_sales_tax";
			this.txt_sales_tax.Size = new System.Drawing.Size(97, 22);
			this.txt_sales_tax.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(206)))));
			this.panel1.Controls.Add(this.groupBox_deleteTax);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(605, 320);
			this.panel1.TabIndex = 18;
			// 
			// groupBox_deleteTax
			// 
			this.groupBox_deleteTax.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox_deleteTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(201)))), ((int)(((byte)(176)))));
			this.groupBox_deleteTax.Controls.Add(this.label2);
			this.groupBox_deleteTax.Controls.Add(this.button_deleteTax);
			this.groupBox_deleteTax.Controls.Add(this.textBox_itemsUsingTax);
			this.groupBox_deleteTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_deleteTax.Location = new System.Drawing.Point(388, 140);
			this.groupBox_deleteTax.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox_deleteTax.Name = "groupBox_deleteTax";
			this.groupBox_deleteTax.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox_deleteTax.Size = new System.Drawing.Size(206, 167);
			this.groupBox_deleteTax.TabIndex = 26;
			this.groupBox_deleteTax.TabStop = false;
			this.groupBox_deleteTax.Text = "Delete Tax";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(5, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 16);
			this.label2.TabIndex = 24;
			this.label2.Text = "Items Using Tax:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// button_deleteTax
			// 
			this.button_deleteTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_deleteTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.button_deleteTax.Location = new System.Drawing.Point(93, 127);
			this.button_deleteTax.Name = "button_deleteTax";
			this.button_deleteTax.Size = new System.Drawing.Size(108, 35);
			this.button_deleteTax.TabIndex = 23;
			this.button_deleteTax.Text = "Delete Tax";
			this.button_deleteTax.UseVisualStyleBackColor = true;
			this.button_deleteTax.Click += new System.EventHandler(this.button_deleteTax_Click);
			// 
			// textBox_itemsUsingTax
			// 
			this.textBox_itemsUsingTax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_itemsUsingTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.textBox_itemsUsingTax.Location = new System.Drawing.Point(92, 21);
			this.textBox_itemsUsingTax.Name = "textBox_itemsUsingTax";
			this.textBox_itemsUsingTax.ReadOnly = true;
			this.textBox_itemsUsingTax.Size = new System.Drawing.Size(109, 22);
			this.textBox_itemsUsingTax.TabIndex = 20;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(201)))), ((int)(((byte)(176)))));
			this.groupBox2.Controls.Add(this.btnSetDiscount);
			this.groupBox2.Controls.Add(this.txt_CashDiscount);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(388, 12);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox2.Size = new System.Drawing.Size(206, 104);
			this.groupBox2.TabIndex = 25;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Cash Discount";
			// 
			// btnSetDiscount
			// 
			this.btnSetDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSetDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnSetDiscount.Location = new System.Drawing.Point(93, 60);
			this.btnSetDiscount.Name = "btnSetDiscount";
			this.btnSetDiscount.Size = new System.Drawing.Size(108, 35);
			this.btnSetDiscount.TabIndex = 23;
			this.btnSetDiscount.Text = "Set Discount";
			this.btnSetDiscount.UseVisualStyleBackColor = true;
			this.btnSetDiscount.Click += new System.EventHandler(this.btnSetDiscount_Click);
			// 
			// txt_CashDiscount
			// 
			this.txt_CashDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_CashDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.txt_CashDiscount.Location = new System.Drawing.Point(5, 26);
			this.txt_CashDiscount.MaxLength = 2;
			this.txt_CashDiscount.Name = "txt_CashDiscount";
			this.txt_CashDiscount.Size = new System.Drawing.Size(150, 22);
			this.txt_CashDiscount.TabIndex = 20;
			this.txt_CashDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CashDiscount_KeyPress);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(161, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 18);
			this.label3.TabIndex = 22;
			this.label3.Text = "%";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(201)))), ((int)(((byte)(176)))));
			this.groupBox1.Controls.Add(this.txt_tax_type_name);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btn_new);
			this.groupBox1.Controls.Add(this.lst_tax_list);
			this.groupBox1.Controls.Add(this.btn_update_tax);
			this.groupBox1.Controls.Add(this.btn_clear);
			this.groupBox1.Controls.Add(this.txt_sales_tax);
			this.groupBox1.Controls.Add(this.txt_local_tax);
			this.groupBox1.Controls.Add(this.txt_bottle_dep);
			this.groupBox1.Controls.Add(this.lbl_btl_deposit);
			this.groupBox1.Controls.Add(this.lbl_sales_tax);
			this.groupBox1.Controls.Add(this.lbl_local_tax);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(15, 12);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(362, 295);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tax Types";
			// 
			// txt_tax_type_name
			// 
			this.txt_tax_type_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.txt_tax_type_name.Location = new System.Drawing.Point(258, 26);
			this.txt_tax_type_name.Name = "txt_tax_type_name";
			this.txt_tax_type_name.Size = new System.Drawing.Size(97, 22);
			this.txt_tax_type_name.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(157, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 16);
			this.label1.TabIndex = 19;
			this.label1.Text = "Tax Name:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btn_new
			// 
			this.btn_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.btn_new.Location = new System.Drawing.Point(221, 208);
			this.btn_new.Name = "btn_new";
			this.btn_new.Size = new System.Drawing.Size(133, 35);
			this.btn_new.TabIndex = 7;
			this.btn_new.Text = "New";
			this.btn_new.UseVisualStyleBackColor = true;
			this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
			// 
			// btn_clear
			// 
			this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.btn_clear.Location = new System.Drawing.Point(221, 166);
			this.btn_clear.Name = "btn_clear";
			this.btn_clear.Size = new System.Drawing.Size(133, 35);
			this.btn_clear.TabIndex = 6;
			this.btn_clear.Text = "Clear";
			this.btn_clear.UseVisualStyleBackColor = true;
			this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
			// 
			// PanTax
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "PanTax";
			this.Size = new System.Drawing.Size(605, 320);
			this.panel1.ResumeLayout(false);
			this.groupBox_deleteTax.ResumeLayout(false);
			this.groupBox_deleteTax.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_update_tax;
        private System.Windows.Forms.ListBox lst_tax_list;
        private System.Windows.Forms.Label lbl_btl_deposit;
        private System.Windows.Forms.Label lbl_local_tax;
        private System.Windows.Forms.Label lbl_sales_tax;
        private System.Windows.Forms.TextBox txt_bottle_dep;
        private System.Windows.Forms.TextBox txt_local_tax;
        private System.Windows.Forms.TextBox txt_sales_tax;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_tax_type_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CashDiscount;
        private System.Windows.Forms.Button btnSetDiscount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox_deleteTax;
		private System.Windows.Forms.Button button_deleteTax;
		private System.Windows.Forms.TextBox textBox_itemsUsingTax;
		private System.Windows.Forms.Label label2;
	}
}
