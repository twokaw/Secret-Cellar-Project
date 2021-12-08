﻿namespace SecretCellar
{
    partial class frmDryCleaning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDryCleaning));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtCharge = new SecretCellar.CurrencyBox();
            this.button_AddCharge = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.touchKeyPad1 = new SecretCellar.TouchKeyPad();
            this.lbl_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(35, 68);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(145, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Charge:";
            // 
            // txtCharge
            // 
            this.txtCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.txtCharge.Location = new System.Drawing.Point(221, 70);
            this.txtCharge.Margin = new System.Windows.Forms.Padding(4);
            this.txtCharge.MaxLength = 6;
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(233, 38);
            this.txtCharge.TabIndex = 0;
            this.txtCharge.Text = "0.00";
            this.txtCharge.Enter += new System.EventHandler(this.txtCashAmt_Enter);
            // 
            // button_AddCharge
            // 
            this.button_AddCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddCharge.Location = new System.Drawing.Point(291, 521);
            this.button_AddCharge.Name = "button_AddCharge";
            this.button_AddCharge.Size = new System.Drawing.Size(180, 55);
            this.button_AddCharge.TabIndex = 2;
            this.button_AddCharge.Text = "ADD CHARGE";
            this.button_AddCharge.UseVisualStyleBackColor = true;
            this.button_AddCharge.Click += new System.EventHandler(this.button_AddCharge_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.Location = new System.Drawing.Point(20, 521);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(180, 55);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "CANCEL";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 29);
            this.label1.TabIndex = 57;
            this.label1.Text = "$";
            // 
            // touchKeyPad1
            // 
            this.touchKeyPad1.Location = new System.Drawing.Point(20, 116);
            this.touchKeyPad1.Margin = new System.Windows.Forms.Padding(4);
            this.touchKeyPad1.Name = "touchKeyPad1";
            this.touchKeyPad1.Size = new System.Drawing.Size(451, 370);
            this.touchKeyPad1.TabIndex = 58;
            this.touchKeyPad1.Target = null;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold);
            this.lbl_title.Location = new System.Drawing.Point(140, 9);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(227, 39);
            this.lbl_title.TabIndex = 59;
            this.lbl_title.Text = "Dry Cleaning";
            // 
            // frmDryCleaning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(505, 616);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.touchKeyPad1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_AddCharge);
            this.Controls.Add(this.txtCharge);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDryCleaning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Dry Cleaning Charge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private SecretCellar.CurrencyBox txtCharge;
		private System.Windows.Forms.Button button_AddCharge;
		private System.Windows.Forms.Button button_Cancel;
		private System.Windows.Forms.Label label1;
        private TouchKeyPad touchKeyPad1;
        private System.Windows.Forms.Label lbl_title;
    }
}