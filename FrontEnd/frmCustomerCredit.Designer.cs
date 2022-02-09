
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_AddCredit
            // 
            this.button_AddCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_AddCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddCredit.Location = new System.Drawing.Point(297, 19);
            this.button_AddCredit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_AddCredit.Name = "button_AddCredit";
            this.button_AddCredit.Size = new System.Drawing.Size(210, 60);
            this.button_AddCredit.TabIndex = 2;
            this.button_AddCredit.Text = "Add";
            this.button_AddCredit.UseVisualStyleBackColor = true;
            this.button_AddCredit.Click += new System.EventHandler(this.button_AddCredit_Click);
            // 
            // button_SubtractCredit
            // 
            this.button_SubtractCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_SubtractCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SubtractCredit.Location = new System.Drawing.Point(15, 19);
            this.button_SubtractCredit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_SubtractCredit.Name = "button_SubtractCredit";
            this.button_SubtractCredit.Size = new System.Drawing.Size(210, 60);
            this.button_SubtractCredit.TabIndex = 1;
            this.button_SubtractCredit.Text = "Subtract";
            this.button_SubtractCredit.UseVisualStyleBackColor = true;
            this.button_SubtractCredit.Click += new System.EventHandler(this.button_SubtractCredit_Click);
            // 
            // button_CloseWindow
            // 
            this.button_CloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_CloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CloseWindow.Location = new System.Drawing.Point(15, 184);
            this.button_CloseWindow.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_CloseWindow.Name = "button_CloseWindow";
            this.button_CloseWindow.Size = new System.Drawing.Size(210, 60);
            this.button_CloseWindow.TabIndex = 6;
            this.button_CloseWindow.Text = "Close";
            this.button_CloseWindow.UseVisualStyleBackColor = true;
            this.button_CloseWindow.Click += new System.EventHandler(this.button_CloseWindow_Click);
            // 
            // button_ResetCredit
            // 
            this.button_ResetCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ResetCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ResetCredit.Location = new System.Drawing.Point(15, 99);
            this.button_ResetCredit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_ResetCredit.Name = "button_ResetCredit";
            this.button_ResetCredit.Size = new System.Drawing.Size(210, 60);
            this.button_ResetCredit.TabIndex = 3;
            this.button_ResetCredit.Text = "Reset";
            this.button_ResetCredit.UseVisualStyleBackColor = true;
            this.button_ResetCredit.Click += new System.EventHandler(this.button_ResetCredit_Click);
            // 
            // label_NewCreditAmount
            // 
            this.label_NewCreditAmount.AutoSize = true;
            this.label_NewCreditAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NewCreditAmount.Location = new System.Drawing.Point(46, 63);
            this.label_NewCreditAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NewCreditAmount.Name = "label_NewCreditAmount";
            this.label_NewCreditAmount.Size = new System.Drawing.Size(215, 32);
            this.label_NewCreditAmount.TabIndex = 55;
            this.label_NewCreditAmount.Text = "Current Credit:";
            // 
            // button_ForceChange
            // 
            this.button_ForceChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ForceChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ForceChange.Location = new System.Drawing.Point(297, 99);
            this.button_ForceChange.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_ForceChange.Name = "button_ForceChange";
            this.button_ForceChange.Size = new System.Drawing.Size(210, 60);
            this.button_ForceChange.TabIndex = 4;
            this.button_ForceChange.Text = "Set";
            this.button_ForceChange.UseVisualStyleBackColor = true;
            this.button_ForceChange.Click += new System.EventHandler(this.button_ForceChange_Click);
            // 
            // button_Confirm
            // 
            this.button_Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Confirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Confirm.Location = new System.Drawing.Point(297, 184);
            this.button_Confirm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(210, 60);
            this.button_Confirm.TabIndex = 7;
            this.button_Confirm.Text = "Confirm";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // label_CustomersCredit
            // 
            this.label_CustomersCredit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_CustomersCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CustomersCredit.Location = new System.Drawing.Point(13, 9);
            this.label_CustomersCredit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CustomersCredit.Name = "label_CustomersCredit";
            this.label_CustomersCredit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_CustomersCredit.Size = new System.Drawing.Size(541, 34);
            this.label_CustomersCredit.TabIndex = 53;
            this.label_CustomersCredit.Text = "Customer Credit";
            this.label_CustomersCredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_CustomersCreditValue
            // 
            this.label_CustomersCreditValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_CustomersCreditValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CustomersCreditValue.Location = new System.Drawing.Point(280, 53);
            this.label_CustomersCreditValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CustomersCreditValue.Name = "label_CustomersCreditValue";
            this.label_CustomersCreditValue.Size = new System.Drawing.Size(234, 47);
            this.label_CustomersCreditValue.TabIndex = 57;
            this.label_CustomersCreditValue.Text = "Credit Value";
            this.label_CustomersCreditValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_enterAmt
            // 
            this.lbl_enterAmt.AutoSize = true;
            this.lbl_enterAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enterAmt.Location = new System.Drawing.Point(21, 117);
            this.lbl_enterAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_enterAmt.Name = "lbl_enterAmt";
            this.lbl_enterAmt.Size = new System.Drawing.Size(242, 32);
            this.lbl_enterAmt.TabIndex = 59;
            this.lbl_enterAmt.Text = "Change Amount:";
            // 
            // touchKeyPad1
            // 
            this.touchKeyPad1.Location = new System.Drawing.Point(18, 178);
            this.touchKeyPad1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.touchKeyPad1.Name = "touchKeyPad1";
            this.touchKeyPad1.Size = new System.Drawing.Size(536, 551);
            this.touchKeyPad1.TabIndex = 58;
            this.touchKeyPad1.Target = null;
            // 
            // textBox_NewCreditAmount
            // 
            this.textBox_NewCreditAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NewCreditAmount.Location = new System.Drawing.Point(280, 110);
            this.textBox_NewCreditAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_NewCreditAmount.Name = "textBox_NewCreditAmount";
            this.textBox_NewCreditAmount.Size = new System.Drawing.Size(234, 48);
            this.textBox_NewCreditAmount.TabIndex = 0;
            this.textBox_NewCreditAmount.Text = "0.00";
            this.textBox_NewCreditAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_NewCreditAmount.Enter += new System.EventHandler(this.txtCashAmt_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(201)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.button_Confirm);
            this.panel1.Controls.Add(this.button_ForceChange);
            this.panel1.Controls.Add(this.button_ResetCredit);
            this.panel1.Controls.Add(this.button_CloseWindow);
            this.panel1.Controls.Add(this.button_SubtractCredit);
            this.panel1.Controls.Add(this.button_AddCredit);
            this.panel1.Location = new System.Drawing.Point(25, 742);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 257);
            this.panel1.TabIndex = 60;
            // 
            // frmCustomerCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(567, 1011);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_enterAmt);
            this.Controls.Add(this.touchKeyPad1);
            this.Controls.Add(this.label_CustomersCreditValue);
            this.Controls.Add(this.label_NewCreditAmount);
            this.Controls.Add(this.textBox_NewCreditAmount);
            this.Controls.Add(this.label_CustomersCredit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomerCredit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Credit";
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
    }
}