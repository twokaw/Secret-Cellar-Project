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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustom));
            this.txt_charge_am = new SecretCellar.CurrencyBox();
            this.lbl_custom = new System.Windows.Forms.Label();
            this.txt_descript = new System.Windows.Forms.TextBox();
            this.lbl_Descript = new System.Windows.Forms.Label();
            this.button_AddCharge = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.touchKeyPad1 = new SecretCellar.TouchKeyPad();
            this.label1 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_charge_am
            // 
            this.txt_charge_am.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_charge_am.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txt_charge_am.ForeColor = System.Drawing.Color.Black;
            this.txt_charge_am.Location = new System.Drawing.Point(320, 207);
            this.txt_charge_am.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_charge_am.Name = "txt_charge_am";
            this.txt_charge_am.Size = new System.Drawing.Size(188, 53);
            this.txt_charge_am.TabIndex = 1;
            this.txt_charge_am.Text = "$0.00";
            this.txt_charge_am.Value = 0D;
            // 
            // lbl_custom
            // 
            this.lbl_custom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_custom.AutoSize = true;
            this.lbl_custom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_custom.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.lbl_custom.Location = new System.Drawing.Point(99, 206);
            this.lbl_custom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_custom.Name = "lbl_custom";
            this.lbl_custom.Size = new System.Drawing.Size(205, 59);
            this.lbl_custom.TabIndex = 4;
            this.lbl_custom.Text = "Charge:";
            // 
            // txt_descript
            // 
            this.txt_descript.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_descript.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txt_descript.Location = new System.Drawing.Point(320, 39);
            this.txt_descript.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_descript.Name = "txt_descript";
            this.txt_descript.Size = new System.Drawing.Size(425, 53);
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
            this.lbl_Descript.Location = new System.Drawing.Point(10, 33);
            this.lbl_Descript.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Descript.Name = "lbl_Descript";
            this.lbl_Descript.Size = new System.Drawing.Size(293, 59);
            this.lbl_Descript.TabIndex = 8;
            this.lbl_Descript.Text = "Description:";
            // 
            // button_AddCharge
            // 
            this.button_AddCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddCharge.Location = new System.Drawing.Point(445, 846);
            this.button_AddCharge.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_AddCharge.Name = "button_AddCharge";
            this.button_AddCharge.Size = new System.Drawing.Size(300, 104);
            this.button_AddCharge.TabIndex = 4;
            this.button_AddCharge.Text = "Add Charge";
            this.button_AddCharge.UseVisualStyleBackColor = true;
            this.button_AddCharge.Click += new System.EventHandler(this.button_AddCharge_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.Location = new System.Drawing.Point(21, 846);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(300, 104);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // touchKeyPad1
            // 
            this.touchKeyPad1.Location = new System.Drawing.Point(109, 277);
            this.touchKeyPad1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.touchKeyPad1.Name = "touchKeyPad1";
            this.touchKeyPad1.Size = new System.Drawing.Size(550, 544);
            this.touchKeyPad1.TabIndex = 61;
            this.touchKeyPad1.Target = null;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label1.Location = new System.Drawing.Point(40, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 59);
            this.label1.TabIndex = 63;
            this.label1.Text = "Item Type:";
            // 
            // cboType
            // 
            this.cboType.DisplayMember = "TypeName";
            this.cboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(320, 135);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(425, 54);
            this.cboType.TabIndex = 64;
            // 
            // frmCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(764, 973);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.touchKeyPad1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_AddCharge);
            this.Controls.Add(this.txt_descript);
            this.Controls.Add(this.lbl_Descript);
            this.Controls.Add(this.txt_charge_am);
            this.Controls.Add(this.lbl_custom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SecretCellar.CurrencyBox txt_charge_am;
        private System.Windows.Forms.Label lbl_custom;
        private System.Windows.Forms.TextBox txt_descript;
        private System.Windows.Forms.Label lbl_Descript;
		private System.Windows.Forms.Button button_AddCharge;
		private System.Windows.Forms.Button button_Cancel;
        private TouchKeyPad touchKeyPad1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboType;
    }
}