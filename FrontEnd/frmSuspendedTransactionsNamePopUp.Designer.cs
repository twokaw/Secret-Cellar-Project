namespace SecretCellar
{
	partial class frmSuspendedTransactionsNamePopUp
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
			this.textBoxSuspendedTransactionName = new System.Windows.Forms.TextBox();
			this.btnOkay = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.listCustomers = new System.Windows.Forms.ListBox();
			this.btn_CloseWindow = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxSuspendedTransactionName
			// 
			this.textBoxSuspendedTransactionName.Location = new System.Drawing.Point(12, 43);
			this.textBoxSuspendedTransactionName.Name = "textBoxSuspendedTransactionName";
			this.textBoxSuspendedTransactionName.Size = new System.Drawing.Size(319, 20);
			this.textBoxSuspendedTransactionName.TabIndex = 0;
			this.textBoxSuspendedTransactionName.TextChanged += new System.EventHandler(this.textBoxSuspendedTransactionName_TextChanged);
			this.textBoxSuspendedTransactionName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSuspendedTransactionName_KeyDown);
			// 
			// btnOkay
			// 
			this.btnOkay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOkay.Location = new System.Drawing.Point(192, 322);
			this.btnOkay.Name = "btnOkay";
			this.btnOkay.Size = new System.Drawing.Size(139, 53);
			this.btnOkay.TabIndex = 1;
			this.btnOkay.Text = "SELECT CUSTOMER";
			this.btnOkay.UseVisualStyleBackColor = true;
			this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.label1.Location = new System.Drawing.Point(12, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Search users:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.label2.Location = new System.Drawing.Point(12, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Search Customers:";
			this.label2.Click += new System.EventHandler(this.label1_Click);
			// 
			// listCustomers
			// 
			this.listCustomers.FormattingEnabled = true;
			this.listCustomers.Location = new System.Drawing.Point(12, 78);
			this.listCustomers.Name = "listCustomers";
			this.listCustomers.Size = new System.Drawing.Size(319, 225);
			this.listCustomers.TabIndex = 4;
			this.listCustomers.SelectedIndexChanged += new System.EventHandler(this.listCustomers_SelectedIndexChanged);
			// 
			// btn_CloseWindow
			// 
			this.btn_CloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_CloseWindow.Location = new System.Drawing.Point(17, 322);
			this.btn_CloseWindow.Name = "btn_CloseWindow";
			this.btn_CloseWindow.Size = new System.Drawing.Size(123, 53);
			this.btn_CloseWindow.TabIndex = 5;
			this.btn_CloseWindow.Text = "CLOSE WINDOW";
			this.btn_CloseWindow.UseVisualStyleBackColor = true;
			this.btn_CloseWindow.Click += new System.EventHandler(this.btn_CloseWindow_Click);
			// 
			// frmSuspendedTransactionsNamePopUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(343, 387);
			this.Controls.Add(this.btn_CloseWindow);
			this.Controls.Add(this.listCustomers);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnOkay);
			this.Controls.Add(this.textBoxSuspendedTransactionName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSuspendedTransactionsNamePopUp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Name Suspended Transaction";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxSuspendedTransactionName;
		private System.Windows.Forms.Button btnOkay;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox listCustomers;
		private System.Windows.Forms.Button btn_CloseWindow;
	}
}