
namespace SecretCellar {
	partial class frmEventsWaitList {
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
			this.dataGridView_Customers = new System.Windows.Forms.DataGridView();
			this.button_Remove = new System.Windows.Forms.Button();
			this.button_Close = new System.Windows.Forms.Button();
			this.button_Add = new System.Windows.Forms.Button();
			this.button_CustomerList = new System.Windows.Forms.Button();
			this.textBox_Customer = new System.Windows.Forms.TextBox();
			this.label_Customer = new System.Windows.Forms.Label();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customers)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView_Customers
			// 
			this.dataGridView_Customers.AllowUserToAddRows = false;
			this.dataGridView_Customers.AllowUserToDeleteRows = false;
			this.dataGridView_Customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Customer,
            this.Date});
			this.dataGridView_Customers.Location = new System.Drawing.Point(12, 12);
			this.dataGridView_Customers.Name = "dataGridView_Customers";
			this.dataGridView_Customers.ReadOnly = true;
			this.dataGridView_Customers.RowHeadersVisible = false;
			this.dataGridView_Customers.RowHeadersWidth = 62;
			this.dataGridView_Customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_Customers.Size = new System.Drawing.Size(406, 200);
			this.dataGridView_Customers.TabIndex = 10;
			// 
			// button_Remove
			// 
			this.button_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Remove.Location = new System.Drawing.Point(12, 284);
			this.button_Remove.Name = "button_Remove";
			this.button_Remove.Size = new System.Drawing.Size(180, 55);
			this.button_Remove.TabIndex = 25;
			this.button_Remove.TabStop = false;
			this.button_Remove.Text = "REMOVE SELECTED FROM WAITLIST";
			this.button_Remove.UseVisualStyleBackColor = true;
			this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
			// 
			// button_Close
			// 
			this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Close.Location = new System.Drawing.Point(12, 345);
			this.button_Close.Name = "button_Close";
			this.button_Close.Size = new System.Drawing.Size(180, 55);
			this.button_Close.TabIndex = 26;
			this.button_Close.TabStop = false;
			this.button_Close.Text = "CLOSE WINDOW";
			this.button_Close.UseVisualStyleBackColor = true;
			this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
			// 
			// button_Add
			// 
			this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Add.Location = new System.Drawing.Point(238, 345);
			this.button_Add.Name = "button_Add";
			this.button_Add.Size = new System.Drawing.Size(180, 55);
			this.button_Add.TabIndex = 27;
			this.button_Add.TabStop = false;
			this.button_Add.Text = "ADD CURRENT CUSTOMER TO WAITLIST";
			this.button_Add.UseVisualStyleBackColor = true;
			this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
			// 
			// button_CustomerList
			// 
			this.button_CustomerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_CustomerList.Location = new System.Drawing.Point(238, 284);
			this.button_CustomerList.Name = "button_CustomerList";
			this.button_CustomerList.Size = new System.Drawing.Size(180, 55);
			this.button_CustomerList.TabIndex = 28;
			this.button_CustomerList.TabStop = false;
			this.button_CustomerList.Text = "SELECT CURRENT CUSTOMER";
			this.button_CustomerList.UseVisualStyleBackColor = true;
			this.button_CustomerList.Click += new System.EventHandler(this.button_CustomerList_Click);
			// 
			// textBox_Customer
			// 
			this.textBox_Customer.Enabled = false;
			this.textBox_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Customer.Location = new System.Drawing.Point(238, 224);
			this.textBox_Customer.Name = "textBox_Customer";
			this.textBox_Customer.Size = new System.Drawing.Size(180, 31);
			this.textBox_Customer.TabIndex = 30;
			// 
			// label_Customer
			// 
			this.label_Customer.AutoSize = true;
			this.label_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Customer.Location = new System.Drawing.Point(12, 227);
			this.label_Customer.Name = "label_Customer";
			this.label_Customer.Size = new System.Drawing.Size(187, 25);
			this.label_Customer.TabIndex = 29;
			this.label_Customer.Text = "Current Customer:";
			// 
			// Id
			// 
			this.Id.HeaderText = "Customer Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			// 
			// Customer
			// 
			this.Customer.HeaderText = "Customer Name";
			this.Customer.Name = "Customer";
			this.Customer.ReadOnly = true;
			// 
			// Date
			// 
			this.Date.HeaderText = "Date Put On Waitlist";
			this.Date.Name = "Date";
			this.Date.ReadOnly = true;
			// 
			// frmEventsWaitList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(430, 412);
			this.Controls.Add(this.textBox_Customer);
			this.Controls.Add(this.label_Customer);
			this.Controls.Add(this.button_CustomerList);
			this.Controls.Add(this.button_Add);
			this.Controls.Add(this.button_Close);
			this.Controls.Add(this.button_Remove);
			this.Controls.Add(this.dataGridView_Customers);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmEventsWaitList";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WaitList";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView_Customers;
		private System.Windows.Forms.Button button_Remove;
		private System.Windows.Forms.Button button_Close;
		private System.Windows.Forms.Button button_Add;
		private System.Windows.Forms.Button button_CustomerList;
		private System.Windows.Forms.TextBox textBox_Customer;
		private System.Windows.Forms.Label label_Customer;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
		private System.Windows.Forms.DataGridViewTextBoxColumn Date;
	}
}