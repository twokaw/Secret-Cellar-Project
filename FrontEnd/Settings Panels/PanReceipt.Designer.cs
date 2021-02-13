
namespace SecretCellar.Settings_Panels
{
    partial class PanReceipt
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_receipt_footer = new System.Windows.Forms.Label();
            this.txt_receipt_footer = new System.Windows.Forms.TextBox();
            this.lbl_header = new System.Windows.Forms.Label();
            this.txt_receipt_header = new System.Windows.Forms.TextBox();
            this.btn_rec_font = new System.Windows.Forms.Button();
            this.btn_foot = new System.Windows.Forms.Button();
            this.btn_header = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_receipt_footer);
            this.panel1.Controls.Add(this.txt_receipt_footer);
            this.panel1.Controls.Add(this.lbl_header);
            this.panel1.Controls.Add(this.txt_receipt_header);
            this.panel1.Controls.Add(this.btn_rec_font);
            this.panel1.Controls.Add(this.btn_foot);
            this.panel1.Controls.Add(this.btn_header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 264);
            this.panel1.TabIndex = 0;
            // 
            // lbl_receipt_footer
            // 
            this.lbl_receipt_footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_receipt_footer.Location = new System.Drawing.Point(617, 107);
            this.lbl_receipt_footer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_receipt_footer.Name = "lbl_receipt_footer";
            this.lbl_receipt_footer.Size = new System.Drawing.Size(287, 28);
            this.lbl_receipt_footer.TabIndex = 19;
            this.lbl_receipt_footer.Text = "Receipt Footer";
            this.lbl_receipt_footer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_receipt_footer.Click += new System.EventHandler(this.lbl_receipt_footer_Click);
            // 
            // txt_receipt_footer
            // 
            this.txt_receipt_footer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_receipt_footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_receipt_footer.Location = new System.Drawing.Point(617, 140);
            this.txt_receipt_footer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_receipt_footer.Multiline = true;
            this.txt_receipt_footer.Name = "txt_receipt_footer";
            this.txt_receipt_footer.Size = new System.Drawing.Size(287, 98);
            this.txt_receipt_footer.TabIndex = 18;
            // 
            // lbl_header
            // 
            this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_header.Location = new System.Drawing.Point(23, 107);
            this.lbl_header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(287, 25);
            this.lbl_header.TabIndex = 17;
            this.lbl_header.Text = "Reciept Header";
            this.lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_receipt_header
            // 
            this.txt_receipt_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_receipt_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_receipt_header.Location = new System.Drawing.Point(23, 137);
            this.txt_receipt_header.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_receipt_header.Multiline = true;
            this.txt_receipt_header.Name = "txt_receipt_header";
            this.txt_receipt_header.Size = new System.Drawing.Size(287, 101);
            this.txt_receipt_header.TabIndex = 16;
            // 
            // btn_rec_font
            // 
            this.btn_rec_font.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rec_font.AutoSize = true;
            this.btn_rec_font.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_rec_font.Location = new System.Drawing.Point(336, 164);
            this.btn_rec_font.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_rec_font.Name = "btn_rec_font";
            this.btn_rec_font.Size = new System.Drawing.Size(231, 47);
            this.btn_rec_font.TabIndex = 15;
            this.btn_rec_font.Text = "Change Receipt Font";
            this.btn_rec_font.UseVisualStyleBackColor = true;
            this.btn_rec_font.Click += new System.EventHandler(this.btn_rec_font_Click);
            // 
            // btn_foot
            // 
            this.btn_foot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_foot.AutoSize = true;
            this.btn_foot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_foot.Location = new System.Drawing.Point(617, 25);
            this.btn_foot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_foot.Name = "btn_foot";
            this.btn_foot.Size = new System.Drawing.Size(267, 47);
            this.btn_foot.TabIndex = 14;
            this.btn_foot.Text = "Change Reciept Footer";
            this.btn_foot.UseVisualStyleBackColor = true;
            // 
            // btn_header
            // 
            this.btn_header.AutoSize = true;
            this.btn_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_header.Location = new System.Drawing.Point(23, 22);
            this.btn_header.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_header.Name = "btn_header";
            this.btn_header.Size = new System.Drawing.Size(276, 47);
            this.btn_header.TabIndex = 13;
            this.btn_header.Text = "Change Receipt Header";
            this.btn_header.UseVisualStyleBackColor = true;
            // 
            // PanReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "PanReceipt";
            this.Size = new System.Drawing.Size(928, 264);
            this.Load += new System.EventHandler(this.PanReceipt_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_receipt_footer;
        private System.Windows.Forms.TextBox txt_receipt_footer;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.TextBox txt_receipt_header;
        private System.Windows.Forms.Button btn_rec_font;
        private System.Windows.Forms.Button btn_foot;
        private System.Windows.Forms.Button btn_header;
    }
}
