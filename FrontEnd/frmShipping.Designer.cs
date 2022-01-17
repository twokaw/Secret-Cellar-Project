namespace SecretCellar
{
    partial class frmShipping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShipping));
            this.txtCharge = new SecretCellar.CurrencyBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.button_AddCharge = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.touchKeyPad1 = new SecretCellar.TouchKeyPad();
            this.lbl_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCharge
            // 
            this.txtCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.txtCharge.Location = new System.Drawing.Point(369, 132);
            this.txtCharge.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(382, 53);
            this.txtCharge.TabIndex = 0;
            this.txtCharge.Text = "0.00";
            this.txtCharge.Enter += new System.EventHandler(this.txtCashAmt_Enter);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(63, 128);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(212, 59);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Charge:";
            // 
            // button_AddCharge
            // 
            this.button_AddCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddCharge.Location = new System.Drawing.Point(453, 783);
            this.button_AddCharge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_AddCharge.Name = "button_AddCharge";
            this.button_AddCharge.Size = new System.Drawing.Size(300, 104);
            this.button_AddCharge.TabIndex = 2;
            this.button_AddCharge.Text = "ADD CHARGE";
            this.button_AddCharge.UseVisualStyleBackColor = true;
            this.button_AddCharge.Click += new System.EventHandler(this.button_AddCharge_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.Location = new System.Drawing.Point(52, 783);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(300, 104);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "CANCEL";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 40);
            this.label4.TabIndex = 60;
            this.label4.Text = "$";
            // 
            // touchKeyPad1
            // 
            this.touchKeyPad1.Location = new System.Drawing.Point(144, 226);
            this.touchKeyPad1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.touchKeyPad1.Name = "touchKeyPad1";
            this.touchKeyPad1.Size = new System.Drawing.Size(526, 518);
            this.touchKeyPad1.TabIndex = 61;
            this.touchKeyPad1.Target = null;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold);
            this.lbl_title.Location = new System.Drawing.Point(267, 16);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(229, 59);
            this.lbl_title.TabIndex = 62;
            this.lbl_title.Text = "Shipping";
            // 
            // frmShipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(842, 927);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.touchKeyPad1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_AddCharge);
            this.Controls.Add(this.txtCharge);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShipping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Shipping Charge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SecretCellar.CurrencyBox txtCharge;
        private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button button_AddCharge;
		private System.Windows.Forms.Button button_Cancel;
		private System.Windows.Forms.Label label4;
        private TouchKeyPad touchKeyPad1;
        private System.Windows.Forms.Label lbl_title;
    }
}