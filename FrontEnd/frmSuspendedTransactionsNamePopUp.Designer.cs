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
			this.listUsers = new System.Windows.Forms.ListBox();
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
			this.btnOkay.Location = new System.Drawing.Point(256, 333);
			this.btnOkay.Name = "btnOkay";
			this.btnOkay.Size = new System.Drawing.Size(75, 23);
			this.btnOkay.TabIndex = 1;
			this.btnOkay.Text = "Okay";
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
			this.label2.Size = new System.Drawing.Size(96, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Search users:";
			this.label2.Click += new System.EventHandler(this.label1_Click);
			// 
			// listUsers
			// 
			this.listUsers.FormattingEnabled = true;
			this.listUsers.Location = new System.Drawing.Point(12, 82);
			this.listUsers.Name = "listUsers";
			this.listUsers.Size = new System.Drawing.Size(319, 238);
			this.listUsers.TabIndex = 3;
			this.listUsers.SelectedIndexChanged += new System.EventHandler(this.listUsers_SelectedIndexChanged);
			// 
			// frmSuspendedTransactionsNamePopUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(343, 368);
			this.Controls.Add(this.listUsers);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnOkay);
			this.Controls.Add(this.textBoxSuspendedTransactionName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSuspendedTransactionsNamePopUp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Suspend";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxSuspendedTransactionName;
		private System.Windows.Forms.Button btnOkay;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox listUsers;
	}
}