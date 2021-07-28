
namespace SecretCellar.Orders_Panels {
	partial class Panel_CustomerRequest {
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.textBox_CustomerName = new System.Windows.Forms.TextBox();
			this.lst_customer = new System.Windows.Forms.ListBox();
			this.btn_prod_delete = new System.Windows.Forms.Button();
			this.btn_prod_add = new System.Windows.Forms.Button();
			this.txt_prod_name = new System.Windows.Forms.TextBox();
			this.lbl_prod_name = new System.Windows.Forms.Label();
			this.request_dataGrid = new System.Windows.Forms.DataGridView();
			this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.note_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.note_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customer_names = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.prod_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.request_dataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox_CustomerName
			// 
			this.textBox_CustomerName.Location = new System.Drawing.Point(5, 4);
			this.textBox_CustomerName.Name = "textBox_CustomerName";
			this.textBox_CustomerName.Size = new System.Drawing.Size(339, 20);
			this.textBox_CustomerName.TabIndex = 22;
			this.textBox_CustomerName.Text = "Search for customer";
			// 
			// lst_customer
			// 
			this.lst_customer.FormattingEnabled = true;
			this.lst_customer.Location = new System.Drawing.Point(5, 45);
			this.lst_customer.Name = "lst_customer";
			this.lst_customer.Size = new System.Drawing.Size(339, 173);
			this.lst_customer.TabIndex = 21;
			// 
			// btn_prod_delete
			// 
			this.btn_prod_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_prod_delete.Location = new System.Drawing.Point(373, 288);
			this.btn_prod_delete.Name = "btn_prod_delete";
			this.btn_prod_delete.Size = new System.Drawing.Size(154, 36);
			this.btn_prod_delete.TabIndex = 20;
			this.btn_prod_delete.Text = "Remove";
			this.btn_prod_delete.UseVisualStyleBackColor = true;
			// 
			// btn_prod_add
			// 
			this.btn_prod_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_prod_add.Location = new System.Drawing.Point(678, 288);
			this.btn_prod_add.Name = "btn_prod_add";
			this.btn_prod_add.Size = new System.Drawing.Size(154, 36);
			this.btn_prod_add.TabIndex = 19;
			this.btn_prod_add.Text = "Add";
			this.btn_prod_add.UseVisualStyleBackColor = true;
			// 
			// txt_prod_name
			// 
			this.txt_prod_name.Location = new System.Drawing.Point(452, 4);
			this.txt_prod_name.Name = "txt_prod_name";
			this.txt_prod_name.Size = new System.Drawing.Size(380, 20);
			this.txt_prod_name.TabIndex = 18;
			// 
			// lbl_prod_name
			// 
			this.lbl_prod_name.AutoSize = true;
			this.lbl_prod_name.Location = new System.Drawing.Point(371, 7);
			this.lbl_prod_name.Name = "lbl_prod_name";
			this.lbl_prod_name.Size = new System.Drawing.Size(75, 13);
			this.lbl_prod_name.TabIndex = 17;
			this.lbl_prod_name.Text = "Product Name";
			// 
			// request_dataGrid
			// 
			this.request_dataGrid.AllowUserToAddRows = false;
			this.request_dataGrid.AllowUserToDeleteRows = false;
			this.request_dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.request_dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.request_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.request_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_id,
            this.note_id,
            this.note_date,
            this.customer_names,
            this.prod_name});
			this.request_dataGrid.Location = new System.Drawing.Point(374, 45);
			this.request_dataGrid.Name = "request_dataGrid";
			this.request_dataGrid.ReadOnly = true;
			this.request_dataGrid.RowHeadersVisible = false;
			this.request_dataGrid.RowHeadersWidth = 62;
			this.request_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.request_dataGrid.Size = new System.Drawing.Size(458, 234);
			this.request_dataGrid.TabIndex = 16;
			// 
			// customer_id
			// 
			this.customer_id.DataPropertyName = "customer_id";
			this.customer_id.HeaderText = "CustomerID";
			this.customer_id.MinimumWidth = 8;
			this.customer_id.Name = "customer_id";
			this.customer_id.ReadOnly = true;
			this.customer_id.Visible = false;
			// 
			// note_id
			// 
			this.note_id.DataPropertyName = "note_id";
			this.note_id.HeaderText = "NoteID";
			this.note_id.MinimumWidth = 8;
			this.note_id.Name = "note_id";
			this.note_id.ReadOnly = true;
			this.note_id.Visible = false;
			// 
			// note_date
			// 
			this.note_date.DataPropertyName = "note_date";
			this.note_date.HeaderText = "NoteDate";
			this.note_date.MinimumWidth = 8;
			this.note_date.Name = "note_date";
			this.note_date.ReadOnly = true;
			this.note_date.Visible = false;
			// 
			// customer_names
			// 
			this.customer_names.DataPropertyName = "customer_names";
			this.customer_names.HeaderText = "Customer Name";
			this.customer_names.MinimumWidth = 8;
			this.customer_names.Name = "customer_names";
			this.customer_names.ReadOnly = true;
			// 
			// prod_name
			// 
			this.prod_name.DataPropertyName = "prod_name";
			this.prod_name.HeaderText = "Product Name";
			this.prod_name.MinimumWidth = 8;
			this.prod_name.Name = "prod_name";
			this.prod_name.ReadOnly = true;
			// 
			// Panel_CustomerRequest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBox_CustomerName);
			this.Controls.Add(this.lst_customer);
			this.Controls.Add(this.btn_prod_delete);
			this.Controls.Add(this.btn_prod_add);
			this.Controls.Add(this.txt_prod_name);
			this.Controls.Add(this.lbl_prod_name);
			this.Controls.Add(this.request_dataGrid);
			this.Name = "Panel_CustomerRequest";
			this.Size = new System.Drawing.Size(836, 329);
			((System.ComponentModel.ISupportInitialize)(this.request_dataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox_CustomerName;
		private System.Windows.Forms.ListBox lst_customer;
		private System.Windows.Forms.Button btn_prod_delete;
		private System.Windows.Forms.Button btn_prod_add;
		private System.Windows.Forms.TextBox txt_prod_name;
		private System.Windows.Forms.Label lbl_prod_name;
		private System.Windows.Forms.DataGridView request_dataGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn note_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn note_date;
		private System.Windows.Forms.DataGridViewTextBoxColumn customer_names;
		private System.Windows.Forms.DataGridViewTextBoxColumn prod_name;
	}
}
