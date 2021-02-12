
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
            this.cbx_tax = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_bottleDep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_salesTax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_localTax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTypes
            // 
            this.lstTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstTypes.FormattingEnabled = true;
            this.lstTypes.ItemHeight = 20;
            this.lstTypes.Location = new System.Drawing.Point(15, 85);
            this.lstTypes.Margin = new System.Windows.Forms.Padding(6);
            this.lstTypes.Name = "lstTypes";
            this.lstTypes.Size = new System.Drawing.Size(218, 484);
            this.lstTypes.TabIndex = 0;
            this.lstTypes.SelectedIndexChanged += new System.EventHandler(this.lstTypes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory Type";
            // 
            // cbx_tax
            // 
            this.cbx_tax.FormattingEnabled = true;
            this.cbx_tax.Location = new System.Drawing.Point(288, 122);
            this.cbx_tax.Margin = new System.Windows.Forms.Padding(6);
            this.cbx_tax.Name = "cbx_tax";
            this.cbx_tax.Size = new System.Drawing.Size(322, 28);
            this.cbx_tax.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tax Type";
            // 
            // txt_bottleDep
            // 
            this.txt_bottleDep.Location = new System.Drawing.Point(288, 220);
            this.txt_bottleDep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_bottleDep.Name = "txt_bottleDep";
            this.txt_bottleDep.Size = new System.Drawing.Size(185, 26);
            this.txt_bottleDep.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bottle Deposit";
            // 
            // txt_salesTax
            // 
            this.txt_salesTax.Location = new System.Drawing.Point(283, 314);
            this.txt_salesTax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_salesTax.Name = "txt_salesTax";
            this.txt_salesTax.Size = new System.Drawing.Size(185, 26);
            this.txt_salesTax.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 277);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sales Tax";
            // 
            // txt_localTax
            // 
            this.txt_localTax.Location = new System.Drawing.Point(283, 403);
            this.txt_localTax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_localTax.Name = "txt_localTax";
            this.txt_localTax.Size = new System.Drawing.Size(185, 26);
            this.txt_localTax.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 374);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Local Tax";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(751, 120);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "New Type";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(751, 217);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 36);
            this.button2.TabIndex = 14;
            this.button2.Text = "Update Type";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PanTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lstTypes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_localTax);
            this.Controls.Add(this.cbx_tax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_bottleDep);
            this.Controls.Add(this.txt_salesTax);
            this.Controls.Add(this.label4);
            this.Name = "PanTypes";
            this.Size = new System.Drawing.Size(1004, 596);
            this.Load += new System.EventHandler(this.PanTypes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_tax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_bottleDep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_salesTax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_localTax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
