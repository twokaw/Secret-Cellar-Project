﻿
namespace SecretCellar {
	partial class frmSuspendedTransactionsSelectReturnPaymentMethod {
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
			this.label_Result = new System.Windows.Forms.Label();
			this.button_Credit = new System.Windows.Forms.Button();
			this.button_CloseWindow = new System.Windows.Forms.Button();
			this.button_Cash = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label_Result
			// 
			this.label_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label_Result.AutoSize = true;
			this.label_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Result.Location = new System.Drawing.Point(12, 22);
			this.label_Result.Name = "label_Result";
			this.label_Result.Size = new System.Drawing.Size(59, 20);
			this.label_Result.TabIndex = 0;
			this.label_Result.Text = " Result";
			// 
			// button_Credit
			// 
			this.button_Credit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_Credit.DialogResult = System.Windows.Forms.DialogResult.Yes;
			this.button_Credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Credit.Location = new System.Drawing.Point(12, 60);
			this.button_Credit.Name = "button_Credit";
			this.button_Credit.Size = new System.Drawing.Size(180, 55);
			this.button_Credit.TabIndex = 0;
			this.button_Credit.Text = "CREDIT";
			this.button_Credit.UseVisualStyleBackColor = true;
			this.button_Credit.Click += new System.EventHandler(this.button_Credit_Click);
			// 
			// button_CloseWindow
			// 
			this.button_CloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_CloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_CloseWindow.Location = new System.Drawing.Point(12, 144);
			this.button_CloseWindow.Name = "button_CloseWindow";
			this.button_CloseWindow.Size = new System.Drawing.Size(180, 55);
			this.button_CloseWindow.TabIndex = 2;
			this.button_CloseWindow.Text = "CLOSE WINDOW";
			this.button_CloseWindow.UseVisualStyleBackColor = true;
			this.button_CloseWindow.Click += new System.EventHandler(this.button_CloseWindow_Click);
			// 
			// button_Cash
			// 
			this.button_Cash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_Cash.DialogResult = System.Windows.Forms.DialogResult.No;
			this.button_Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Cash.Location = new System.Drawing.Point(214, 60);
			this.button_Cash.Name = "button_Cash";
			this.button_Cash.Size = new System.Drawing.Size(180, 55);
			this.button_Cash.TabIndex = 1;
			this.button_Cash.Text = "CASH";
			this.button_Cash.UseVisualStyleBackColor = true;
			this.button_Cash.Click += new System.EventHandler(this.button_Cash_Click);
			// 
			// frmSuspendedTransactionsSelectReturnPaymentMethod
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(406, 211);
			this.Controls.Add(this.button_Cash);
			this.Controls.Add(this.button_CloseWindow);
			this.Controls.Add(this.button_Credit);
			this.Controls.Add(this.label_Result);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSuspendedTransactionsSelectReturnPaymentMethod";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Return Method";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_Result;
		private System.Windows.Forms.Button button_Credit;
		private System.Windows.Forms.Button button_CloseWindow;
		private System.Windows.Forms.Button button_Cash;
	}
}