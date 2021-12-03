
namespace SecretCellar {
	partial class frmCustomerCredit {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerCredit));
            this.button_AddCredit = new System.Windows.Forms.Button();
            this.button_SubtractCredit = new System.Windows.Forms.Button();
            this.button_CloseWindow = new System.Windows.Forms.Button();
            this.button_ResetCredit = new System.Windows.Forms.Button();
            this.label_NewCreditAmount = new System.Windows.Forms.Label();
            this.button_ForceChange = new System.Windows.Forms.Button();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.label_CustomersCredit = new System.Windows.Forms.Label();
            this.label_CustomersCreditValue = new System.Windows.Forms.Label();
            this.lbl_enterAmt = new System.Windows.Forms.Label();
            this.touchKeyPad1 = new SecretCellar.TouchKeyPad();
            this.textBox_NewCreditAmount = new SecretCellar.CurrencyBox();
            this.SuspendLayout();
            // 
            // button_AddCredit
            // 
            this.button_AddCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_AddCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddCredit.Location = new System.Drawing.Point(188, 442);
            this.button_AddCredit.Margin = new System.Windows.Forms.Padding(4);
            this.button_AddCredit.Name = "button_AddCredit";
            this.button_AddCredit.Size = new System.Drawing.Size(134, 37);
            this.button_AddCredit.TabIndex = 2;
            this.button_AddCredit.Text = "Add Value";
            this.button_AddCredit.UseVisualStyleBackColor = true;
            this.button_AddCredit.Click += new System.EventHandler(this.button_AddCredit_Click);
            // 
            // button_SubtractCredit
            // 
            this.button_SubtractCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_SubtractCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SubtractCredit.Location = new System.Drawing.Point(39, 442);
            this.button_SubtractCredit.Margin = new System.Windows.Forms.Padding(4);
            this.button_SubtractCredit.Name = "button_SubtractCredit";
            this.button_SubtractCredit.Size = new System.Drawing.Size(134, 37);
            this.button_SubtractCredit.TabIndex = 1;
            this.button_SubtractCredit.Text = "Subtract Value";
            this.button_SubtractCredit.UseVisualStyleBackColor = true;
            this.button_SubtractCredit.Click += new System.EventHandler(this.button_SubtractCredit_Click);
            // 
            // button_CloseWindow
            // 
            this.button_CloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_CloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CloseWindow.Location = new System.Drawing.Point(39, 552);
            this.button_CloseWindow.Margin = new System.Windows.Forms.Padding(4);
            this.button_CloseWindow.Name = "button_CloseWindow";
            this.button_CloseWindow.Size = new System.Drawing.Size(134, 37);
            this.button_CloseWindow.TabIndex = 6;
            this.button_CloseWindow.Text = "Close Window";
            this.button_CloseWindow.UseVisualStyleBackColor = true;
            this.button_CloseWindow.Click += new System.EventHandler(this.button_CloseWindow_Click);
            // 
            // button_ResetCredit
            // 
            this.button_ResetCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ResetCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ResetCredit.Location = new System.Drawing.Point(39, 489);
            this.button_ResetCredit.Margin = new System.Windows.Forms.Padding(4);
            this.button_ResetCredit.Name = "button_ResetCredit";
            this.button_ResetCredit.Size = new System.Drawing.Size(134, 37);
            this.button_ResetCredit.TabIndex = 3;
            this.button_ResetCredit.Text = "Reset To 0";
            this.button_ResetCredit.UseVisualStyleBackColor = true;
            this.button_ResetCredit.Click += new System.EventHandler(this.button_ResetCredit_Click);
            // 
            // label_NewCreditAmount
            // 
            this.label_NewCreditAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_NewCreditAmount.AutoSize = true;
            this.label_NewCreditAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NewCreditAmount.Location = new System.Drawing.Point(35, 48);
            this.label_NewCreditAmount.Name = "label_NewCreditAmount";
            this.label_NewCreditAmount.Size = new System.Drawing.Size(146, 24);
            this.label_NewCreditAmount.TabIndex = 55;
            this.label_NewCreditAmount.Text = "Current Credit:";
            // 
            // button_ForceChange
            // 
            this.button_ForceChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ForceChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ForceChange.Location = new System.Drawing.Point(188, 489);
            this.button_ForceChange.Margin = new System.Windows.Forms.Padding(4);
            this.button_ForceChange.Name = "button_ForceChange";
            this.button_ForceChange.Size = new System.Drawing.Size(134, 37);
            this.button_ForceChange.TabIndex = 4;
            this.button_ForceChange.Text = "Force Value";
            this.button_ForceChange.UseVisualStyleBackColor = true;
            this.button_ForceChange.Click += new System.EventHandler(this.button_ForceChange_Click);
            // 
            // button_Confirm
            // 
            this.button_Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Confirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Confirm.Location = new System.Drawing.Point(188, 552);
            this.button_Confirm.Margin = new System.Windows.Forms.Padding(4);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(134, 37);
            this.button_Confirm.TabIndex = 7;
            this.button_Confirm.Text = "Confirm";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // label_CustomersCredit
            // 
            this.label_CustomersCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CustomersCredit.Location = new System.Drawing.Point(72, 12);
            this.label_CustomersCredit.Name = "label_CustomersCredit";
            this.label_CustomersCredit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_CustomersCredit.Size = new System.Drawing.Size(197, 23);
            this.label_CustomersCredit.TabIndex = 53;
            this.label_CustomersCredit.Text = "Customer Credit:";
            this.label_CustomersCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_CustomersCreditValue
            // 
            this.label_CustomersCreditValue.AutoSize = true;
            this.label_CustomersCreditValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CustomersCreditValue.Location = new System.Drawing.Point(200, 47);
            this.label_CustomersCreditValue.Name = "label_CustomersCreditValue";
            this.label_CustomersCreditValue.Size = new System.Drawing.Size(125, 24);
            this.label_CustomersCreditValue.TabIndex = 57;
            this.label_CustomersCreditValue.Text = "Credit Value";
            this.label_CustomersCreditValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_enterAmt
            // 
            this.lbl_enterAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_enterAmt.AutoSize = true;
            this.lbl_enterAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enterAmt.Location = new System.Drawing.Point(14, 83);
            this.lbl_enterAmt.Name = "lbl_enterAmt";
            this.lbl_enterAmt.Size = new System.Drawing.Size(167, 24);
            this.lbl_enterAmt.TabIndex = 59;
            this.lbl_enterAmt.Text = "Change Amount:";
            // 
            // touchKeyPad1
            // 
            this.touchKeyPad1.Location = new System.Drawing.Point(32, 120);
            this.touchKeyPad1.Name = "touchKeyPad1";
            this.touchKeyPad1.Size = new System.Drawing.Size(297, 299);
            this.touchKeyPad1.TabIndex = 58;
            this.touchKeyPad1.Target = null;
            // 
            // textBox_NewCreditAmount
            // 
            this.textBox_NewCreditAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_NewCreditAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NewCreditAmount.Location = new System.Drawing.Point(187, 76);
            this.textBox_NewCreditAmount.Name = "textBox_NewCreditAmount";
            this.textBox_NewCreditAmount.Size = new System.Drawing.Size(157, 35);
            this.textBox_NewCreditAmount.TabIndex = 0;
            this.textBox_NewCreditAmount.Text = "0.00";
            this.textBox_NewCreditAmount.Enter += new System.EventHandler(this.txtCashAmt_Enter);
            // 
            // frmCustomerCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(366, 602);
            this.Controls.Add(this.lbl_enterAmt);
            this.Controls.Add(this.touchKeyPad1);
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.label_CustomersCreditValue);
            this.Controls.Add(this.button_ForceChange);
            this.Controls.Add(this.label_NewCreditAmount);
            this.Controls.Add(this.textBox_NewCreditAmount);
            this.Controls.Add(this.label_CustomersCredit);
            this.Controls.Add(this.button_ResetCredit);
            this.Controls.Add(this.button_CloseWindow);
            this.Controls.Add(this.button_SubtractCredit);
            this.Controls.Add(this.button_AddCredit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomerCredit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Credit";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_AddCredit;
		private System.Windows.Forms.Button button_SubtractCredit;
		private System.Windows.Forms.Button button_CloseWindow;
		private System.Windows.Forms.Button button_ResetCredit;
		private SecretCellar.CurrencyBox textBox_NewCreditAmount;
		private System.Windows.Forms.Label label_NewCreditAmount;
		private System.Windows.Forms.Button button_ForceChange;
		private System.Windows.Forms.Button button_Confirm;
		private System.Windows.Forms.Label label_CustomersCredit;
		private System.Windows.Forms.Label label_CustomersCreditValue;
        private TouchKeyPad touchKeyPad1;
        private System.Windows.Forms.Label lbl_enterAmt;
    }
}