
namespace SecretCellar {
	partial class frmEventsWaitlist {
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
			this.EventId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button_Remove = new System.Windows.Forms.Button();
			this.button_Close = new System.Windows.Forms.Button();
			this.button_Add = new System.Windows.Forms.Button();
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
            this.EventId,
            this.CustomerId,
            this.CustomerName,
            this.Date});
			this.dataGridView_Customers.Location = new System.Drawing.Point(12, 12);
			this.dataGridView_Customers.Name = "dataGridView_Customers";
			this.dataGridView_Customers.ReadOnly = true;
			this.dataGridView_Customers.RowHeadersVisible = false;
			this.dataGridView_Customers.RowHeadersWidth = 62;
			this.dataGridView_Customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_Customers.Size = new System.Drawing.Size(406, 200);
			this.dataGridView_Customers.TabIndex = 0;
			this.dataGridView_Customers.TabStop = false;
			// 
			// EventId
			// 
			this.EventId.HeaderText = "Event Id";
			this.EventId.Name = "EventId";
			this.EventId.ReadOnly = true;
			// 
			// CustomerId
			// 
			this.CustomerId.HeaderText = "Customer Id";
			this.CustomerId.Name = "CustomerId";
			this.CustomerId.ReadOnly = true;
			// 
			// CustomerName
			// 
			this.CustomerName.HeaderText = "Customer Name";
			this.CustomerName.Name = "CustomerName";
			this.CustomerName.ReadOnly = true;
			// 
			// Date
			// 
			this.Date.HeaderText = "Date Put On Waitlist";
			this.Date.Name = "Date";
			this.Date.ReadOnly = true;
			// 
			// button_Remove
			// 
			this.button_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Remove.Location = new System.Drawing.Point(12, 223);
			this.button_Remove.Name = "button_Remove";
			this.button_Remove.Size = new System.Drawing.Size(180, 55);
			this.button_Remove.TabIndex = 1;
			this.button_Remove.Text = "REMOVE FROM WAITLIST";
			this.button_Remove.UseVisualStyleBackColor = true;
			this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
			// 
			// button_Close
			// 
			this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Close.Location = new System.Drawing.Point(12, 284);
			this.button_Close.Name = "button_Close";
			this.button_Close.Size = new System.Drawing.Size(180, 55);
			this.button_Close.TabIndex = 3;
			this.button_Close.Text = "CLOSE WINDOW";
			this.button_Close.UseVisualStyleBackColor = true;
			this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
			// 
			// button_Add
			// 
			this.button_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Add.Location = new System.Drawing.Point(238, 223);
			this.button_Add.Name = "button_Add";
			this.button_Add.Size = new System.Drawing.Size(180, 55);
			this.button_Add.TabIndex = 2;
			this.button_Add.Text = "ADD TO WAITLIST...";
			this.button_Add.UseVisualStyleBackColor = true;
			this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
			// 
			// frmEventsWaitlist
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(430, 348);
			this.Controls.Add(this.button_Add);
			this.Controls.Add(this.button_Close);
			this.Controls.Add(this.button_Remove);
			this.Controls.Add(this.dataGridView_Customers);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmEventsWaitlist";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WaitList";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Customers)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView_Customers;
		private System.Windows.Forms.Button button_Remove;
		private System.Windows.Forms.Button button_Close;
		private System.Windows.Forms.Button button_Add;
		private System.Windows.Forms.DataGridViewTextBoxColumn EventId;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Date;
	}
}