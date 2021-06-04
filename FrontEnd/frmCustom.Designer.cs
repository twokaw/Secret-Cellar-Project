namespace SecretCellar
{
    partial class frmCustom
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
			this.txt_charge_am = new System.Windows.Forms.TextBox();
			this.lbl_custom = new System.Windows.Forms.Label();
			this.txt_descript = new System.Windows.Forms.TextBox();
			this.lbl_Descript = new System.Windows.Forms.Label();
			this.button_AddCharge = new System.Windows.Forms.Button();
			this.button_Cancel = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txt_charge_am
			// 
			this.txt_charge_am.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.txt_charge_am.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
			this.txt_charge_am.Location = new System.Drawing.Point(244, 84);
			this.txt_charge_am.Margin = new System.Windows.Forms.Padding(4);
			this.txt_charge_am.Name = "txt_charge_am";
			this.txt_charge_am.Size = new System.Drawing.Size(115, 38);
			this.txt_charge_am.TabIndex = 1;
			// 
			// lbl_custom
			// 
			this.lbl_custom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_custom.AutoSize = true;
			this.lbl_custom.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.lbl_custom.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
			this.lbl_custom.Location = new System.Drawing.Point(64, 83);
			this.lbl_custom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_custom.Name = "lbl_custom";
			this.lbl_custom.Size = new System.Drawing.Size(138, 39);
			this.lbl_custom.TabIndex = 4;
			this.lbl_custom.Text = "Charge:";
			// 
			// txt_descript
			// 
			this.txt_descript.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.txt_descript.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
			this.txt_descript.Location = new System.Drawing.Point(244, 21);
			this.txt_descript.Margin = new System.Windows.Forms.Padding(4);
			this.txt_descript.Name = "txt_descript";
			this.txt_descript.Size = new System.Drawing.Size(315, 38);
			this.txt_descript.TabIndex = 0;
			// 
			// lbl_Descript
			// 
			this.lbl_Descript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_Descript.AutoSize = true;
			this.lbl_Descript.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.lbl_Descript.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
			this.lbl_Descript.Location = new System.Drawing.Point(5, 18);
			this.lbl_Descript.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbl_Descript.Name = "lbl_Descript";
			this.lbl_Descript.Size = new System.Drawing.Size(197, 39);
			this.lbl_Descript.TabIndex = 8;
			this.lbl_Descript.Text = "Description:";
			// 
			// button_AddCharge
			// 
			this.button_AddCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_AddCharge.Location = new System.Drawing.Point(380, 172);
			this.button_AddCharge.Name = "button_AddCharge";
			this.button_AddCharge.Size = new System.Drawing.Size(180, 55);
			this.button_AddCharge.TabIndex = 4;
			this.button_AddCharge.Text = "ADD CHARGE";
			this.button_AddCharge.UseVisualStyleBackColor = true;
			this.button_AddCharge.Click += new System.EventHandler(this.button_AddCharge_Click);
			// 
			// button_Cancel
			// 
			this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Cancel.Location = new System.Drawing.Point(12, 172);
			this.button_Cancel.Name = "button_Cancel";
			this.button_Cancel.Size = new System.Drawing.Size(180, 55);
			this.button_Cancel.TabIndex = 3;
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
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(215, 90);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 29);
			this.label4.TabIndex = 60;
			this.label4.Text = "$";
			// 
			// frmCustom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.DarkGray;
			this.ClientSize = new System.Drawing.Size(572, 239);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button_Cancel);
			this.Controls.Add(this.button_AddCharge);
			this.Controls.Add(this.txt_descript);
			this.Controls.Add(this.lbl_Descript);
			this.Controls.Add(this.txt_charge_am);
			this.Controls.Add(this.lbl_custom);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCustom";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Custom Item";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_charge_am;
        private System.Windows.Forms.Label lbl_custom;
        private System.Windows.Forms.TextBox txt_descript;
        private System.Windows.Forms.Label lbl_Descript;
		private System.Windows.Forms.Button button_AddCharge;
		private System.Windows.Forms.Button button_Cancel;
		private System.Windows.Forms.Label label4;
	}
}