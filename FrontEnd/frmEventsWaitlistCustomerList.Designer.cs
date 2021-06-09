
namespace SecretCellar {
	partial class frmEventsWaitlistCustomerList {
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
			this.dataGridView_CustomerList = new System.Windows.Forms.DataGridView();
			this.Customer_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Customer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBox_CustomerName = new System.Windows.Forms.TextBox();
			this.button_CloseWindow = new System.Windows.Forms.Button();
			this.button_SelectCustomer = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_CustomerList)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView_CustomerList
			// 
			this.dataGridView_CustomerList.AllowUserToAddRows = false;
			this.dataGridView_CustomerList.AllowUserToDeleteRows = false;
			this.dataGridView_CustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView_CustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_CustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer_Id,
            this.Customer_Name});
			this.dataGridView_CustomerList.Location = new System.Drawing.Point(12, 43);
			this.dataGridView_CustomerList.Name = "dataGridView_CustomerList";
			this.dataGridView_CustomerList.ReadOnly = true;
			this.dataGridView_CustomerList.RowHeadersVisible = false;
			this.dataGridView_CustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_CustomerList.Size = new System.Drawing.Size(373, 200);
			this.dataGridView_CustomerList.TabIndex = 2;
			this.dataGridView_CustomerList.TabStop = false;
			this.dataGridView_CustomerList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CustomerList_CellDoubleClick);
			// 
			// Customer_Id
			// 
			this.Customer_Id.HeaderText = "Customer Id";
			this.Customer_Id.Name = "Customer_Id";
			this.Customer_Id.ReadOnly = true;
			// 
			// Customer_Name
			// 
			this.Customer_Name.HeaderText = "Customer Name";
			this.Customer_Name.Name = "Customer_Name";
			this.Customer_Name.ReadOnly = true;
			// 
			// textBox_CustomerName
			// 
			this.textBox_CustomerName.Location = new System.Drawing.Point(12, 12);
			this.textBox_CustomerName.Name = "textBox_CustomerName";
			this.textBox_CustomerName.Size = new System.Drawing.Size(373, 20);
			this.textBox_CustomerName.TabIndex = 2;
			this.textBox_CustomerName.Text = "Search for customer";
			this.textBox_CustomerName.TextChanged += new System.EventHandler(this.textBox_CustomerName_TextChanged);
			this.textBox_CustomerName.Enter += new System.EventHandler(this.textBox_CustomerName_Enter);
			this.textBox_CustomerName.Leave += new System.EventHandler(this.textBox_CustomerName_Leave);
			// 
			// button_CloseWindow
			// 
			this.button_CloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_CloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_CloseWindow.Location = new System.Drawing.Point(10, 255);
			this.button_CloseWindow.Margin = new System.Windows.Forms.Padding(1);
			this.button_CloseWindow.Name = "button_CloseWindow";
			this.button_CloseWindow.Size = new System.Drawing.Size(180, 55);
			this.button_CloseWindow.TabIndex = 1;
			this.button_CloseWindow.Text = "CLOSE WINDOW";
			this.button_CloseWindow.UseVisualStyleBackColor = true;
			this.button_CloseWindow.Click += new System.EventHandler(this.button_CloseWindow_Click);
			// 
			// button_SelectCustomer
			// 
			this.button_SelectCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_SelectCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_SelectCustomer.Location = new System.Drawing.Point(207, 255);
			this.button_SelectCustomer.Margin = new System.Windows.Forms.Padding(1);
			this.button_SelectCustomer.Name = "button_SelectCustomer";
			this.button_SelectCustomer.Size = new System.Drawing.Size(180, 55);
			this.button_SelectCustomer.TabIndex = 3;
			this.button_SelectCustomer.Text = "SELECT CUSTOMER";
			this.button_SelectCustomer.UseVisualStyleBackColor = true;
			this.button_SelectCustomer.Click += new System.EventHandler(this.button_SelectCustomer_Click);
			// 
			// frmEventsWaitlistCustomerList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(397, 320);
			this.Controls.Add(this.button_CloseWindow);
			this.Controls.Add(this.button_SelectCustomer);
			this.Controls.Add(this.textBox_CustomerName);
			this.Controls.Add(this.dataGridView_CustomerList);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmEventsWaitlistCustomerList";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Customer List";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_CustomerList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView_CustomerList;
		private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Name;
		private System.Windows.Forms.TextBox textBox_CustomerName;
		private System.Windows.Forms.Button button_CloseWindow;
		private System.Windows.Forms.Button button_SelectCustomer;
	}
}