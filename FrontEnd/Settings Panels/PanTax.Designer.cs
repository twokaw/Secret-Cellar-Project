
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
			this.txt_tax_list = new System.Windows.Forms.Label();
			this.lst_tax_list = new System.Windows.Forms.ListBox();
			this.lbl_btl_deposit = new System.Windows.Forms.Label();
			this.lbl_local_tax = new System.Windows.Forms.Label();
			this.lbl_sales_tax = new System.Windows.Forms.Label();
			this.txt_bottle_dep = new System.Windows.Forms.TextBox();
			this.txt_local_tax = new System.Windows.Forms.TextBox();
			this.txt_sales_tax = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_new = new System.Windows.Forms.Button();
			this.btn_clear = new System.Windows.Forms.Button();
			this.txt_tax_type_name = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_update_tax
			// 
			this.btn_update_tax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_update_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.btn_update_tax.Location = new System.Drawing.Point(469, 282);
			this.btn_update_tax.Name = "btn_update_tax";
			this.btn_update_tax.Size = new System.Drawing.Size(133, 35);
			this.btn_update_tax.TabIndex = 8;
			this.btn_update_tax.Text = "Update";
			this.btn_update_tax.UseVisualStyleBackColor = true;
			this.btn_update_tax.Click += new System.EventHandler(this.btn_update_tax_Click);
			// 
			// txt_tax_list
			// 
			this.txt_tax_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.txt_tax_list.Location = new System.Drawing.Point(9, 10);
			this.txt_tax_list.Name = "txt_tax_list";
			this.txt_tax_list.Size = new System.Drawing.Size(115, 17);
			this.txt_tax_list.TabIndex = 16;
			this.txt_tax_list.Text = "Tax Types";
			this.txt_tax_list.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lst_tax_list
			// 
			this.lst_tax_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lst_tax_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.lst_tax_list.FormattingEnabled = true;
			this.lst_tax_list.ItemHeight = 16;
			this.lst_tax_list.Location = new System.Drawing.Point(9, 31);
			this.lst_tax_list.Name = "lst_tax_list";
			this.lst_tax_list.Size = new System.Drawing.Size(120, 260);
			this.lst_tax_list.TabIndex = 1;
			this.lst_tax_list.SelectedIndexChanged += new System.EventHandler(this.lst_tax_list_SelectedIndexChanged);
			// 
			// lbl_btl_deposit
			// 
			this.lbl_btl_deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.lbl_btl_deposit.Location = new System.Drawing.Point(135, 110);
			this.lbl_btl_deposit.Name = "lbl_btl_deposit";
			this.lbl_btl_deposit.Size = new System.Drawing.Size(102, 16);
			this.lbl_btl_deposit.TabIndex = 14;
			this.lbl_btl_deposit.Text = "Bottle Deposit:";
			this.lbl_btl_deposit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_local_tax
			// 
			this.lbl_local_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.lbl_local_tax.Location = new System.Drawing.Point(139, 84);
			this.lbl_local_tax.Name = "lbl_local_tax";
			this.lbl_local_tax.Size = new System.Drawing.Size(99, 18);
			this.lbl_local_tax.TabIndex = 13;
			this.lbl_local_tax.Text = "Local Tax:";
			this.lbl_local_tax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_sales_tax
			// 
			this.lbl_sales_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.lbl_sales_tax.Location = new System.Drawing.Point(142, 57);
			this.lbl_sales_tax.Name = "lbl_sales_tax";
			this.lbl_sales_tax.Size = new System.Drawing.Size(95, 16);
			this.lbl_sales_tax.TabIndex = 12;
			this.lbl_sales_tax.Text = "Sales Tax:";
			this.lbl_sales_tax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt_bottle_dep
			// 
			this.txt_bottle_dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.txt_bottle_dep.Location = new System.Drawing.Point(243, 110);
			this.txt_bottle_dep.Name = "txt_bottle_dep";
			this.txt_bottle_dep.Size = new System.Drawing.Size(97, 22);
			this.txt_bottle_dep.TabIndex = 5;
			// 
			// txt_local_tax
			// 
			this.txt_local_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.txt_local_tax.Location = new System.Drawing.Point(243, 82);
			this.txt_local_tax.Name = "txt_local_tax";
			this.txt_local_tax.Size = new System.Drawing.Size(97, 22);
			this.txt_local_tax.TabIndex = 4;
			// 
			// txt_sales_tax
			// 
			this.txt_sales_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.txt_sales_tax.Location = new System.Drawing.Point(243, 53);
			this.txt_sales_tax.Name = "txt_sales_tax";
			this.txt_sales_tax.Size = new System.Drawing.Size(97, 22);
			this.txt_sales_tax.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.Controls.Add(this.btn_new);
			this.panel1.Controls.Add(this.btn_clear);
			this.panel1.Controls.Add(this.txt_tax_type_name);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.lst_tax_list);
			this.panel1.Controls.Add(this.btn_update_tax);
			this.panel1.Controls.Add(this.txt_sales_tax);
			this.panel1.Controls.Add(this.txt_tax_list);
			this.panel1.Controls.Add(this.txt_local_tax);
			this.panel1.Controls.Add(this.txt_bottle_dep);
			this.panel1.Controls.Add(this.lbl_btl_deposit);
			this.panel1.Controls.Add(this.lbl_sales_tax);
			this.panel1.Controls.Add(this.lbl_local_tax);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(605, 320);
			this.panel1.TabIndex = 18;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// btn_new
			// 
			this.btn_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.btn_new.Location = new System.Drawing.Point(469, 241);
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
			this.btn_clear.Location = new System.Drawing.Point(469, 184);
			this.btn_clear.Name = "btn_clear";
			this.btn_clear.Size = new System.Drawing.Size(133, 35);
			this.btn_clear.TabIndex = 6;
			this.btn_clear.Text = "Clear";
			this.btn_clear.UseVisualStyleBackColor = true;
			this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
			// 
			// txt_tax_type_name
			// 
			this.txt_tax_type_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.txt_tax_type_name.Location = new System.Drawing.Point(243, 26);
			this.txt_tax_type_name.Name = "txt_tax_type_name";
			this.txt_tax_type_name.Size = new System.Drawing.Size(97, 22);
			this.txt_tax_type_name.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(142, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 16);
			this.label1.TabIndex = 19;
			this.label1.Text = "Tax Name:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_update_tax;
        private System.Windows.Forms.Label txt_tax_list;
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
    }
}
