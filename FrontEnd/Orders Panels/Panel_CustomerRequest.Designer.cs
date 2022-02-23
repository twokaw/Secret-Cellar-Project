
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.request_dataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_CustomerName
            // 
            this.textBox_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CustomerName.Location = new System.Drawing.Point(13, 10);
            this.textBox_CustomerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_CustomerName.Name = "textBox_CustomerName";
            this.textBox_CustomerName.Size = new System.Drawing.Size(496, 35);
            this.textBox_CustomerName.TabIndex = 22;
            this.textBox_CustomerName.Text = "Search for customer";
            this.textBox_CustomerName.TextChanged += new System.EventHandler(this.textBox_CustomerName_TextChanged);
            this.textBox_CustomerName.Enter += new System.EventHandler(this.textBox_CustomerName_Enter);
            this.textBox_CustomerName.Leave += new System.EventHandler(this.textBox_CustomerName_Leave);
            // 
            // lst_customer
            // 
            this.lst_customer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lst_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_customer.FormattingEnabled = true;
            this.lst_customer.ItemHeight = 29;
            this.lst_customer.Location = new System.Drawing.Point(13, 66);
            this.lst_customer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lst_customer.Name = "lst_customer";
            this.lst_customer.Size = new System.Drawing.Size(496, 352);
            this.lst_customer.TabIndex = 21;
            // 
            // btn_prod_delete
            // 
            this.btn_prod_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_prod_delete.AutoSize = true;
            this.btn_prod_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prod_delete.Location = new System.Drawing.Point(549, 420);
            this.btn_prod_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_prod_delete.Name = "btn_prod_delete";
            this.btn_prod_delete.Size = new System.Drawing.Size(178, 58);
            this.btn_prod_delete.TabIndex = 20;
            this.btn_prod_delete.Text = "Remove";
            this.btn_prod_delete.UseVisualStyleBackColor = true;
            this.btn_prod_delete.Click += new System.EventHandler(this.btn_prod_delete_Click);
            // 
            // btn_prod_add
            // 
            this.btn_prod_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_prod_add.AutoSize = true;
            this.btn_prod_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prod_add.Location = new System.Drawing.Point(1058, 420);
            this.btn_prod_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_prod_add.Name = "btn_prod_add";
            this.btn_prod_add.Size = new System.Drawing.Size(184, 58);
            this.btn_prod_add.TabIndex = 19;
            this.btn_prod_add.Text = "Add";
            this.btn_prod_add.UseVisualStyleBackColor = true;
            this.btn_prod_add.Click += new System.EventHandler(this.btn_prod_add_Click);
            // 
            // txt_prod_name
            // 
            this.txt_prod_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prod_name.Location = new System.Drawing.Point(742, 15);
            this.txt_prod_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_prod_name.Name = "txt_prod_name";
            this.txt_prod_name.Size = new System.Drawing.Size(498, 35);
            this.txt_prod_name.TabIndex = 18;
            // 
            // lbl_prod_name
            // 
            this.lbl_prod_name.AutoSize = true;
            this.lbl_prod_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prod_name.Location = new System.Drawing.Point(544, 15);
            this.lbl_prod_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_prod_name.Name = "lbl_prod_name";
            this.lbl_prod_name.Size = new System.Drawing.Size(179, 29);
            this.lbl_prod_name.TabIndex = 17;
            this.lbl_prod_name.Text = "Product Name";
            // 
            // request_dataGrid
            // 
            this.request_dataGrid.AllowUserToAddRows = false;
            this.request_dataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Ivory;
            this.request_dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.request_dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.request_dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.request_dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.request_dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.request_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.request_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_id,
            this.note_id,
            this.note_date,
            this.customer_names,
            this.prod_name});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.request_dataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.request_dataGrid.Location = new System.Drawing.Point(550, 66);
            this.request_dataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.request_dataGrid.Name = "request_dataGrid";
            this.request_dataGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.request_dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.request_dataGrid.RowHeadersVisible = false;
            this.request_dataGrid.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Ivory;
            this.request_dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.request_dataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.request_dataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.request_dataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            this.request_dataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Ivory;
            this.request_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.request_dataGrid.Size = new System.Drawing.Size(690, 334);
            this.request_dataGrid.TabIndex = 16;
            this.request_dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.request_dataGrid_CellContentClick);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.btn_prod_delete);
            this.panel1.Controls.Add(this.textBox_CustomerName);
            this.panel1.Controls.Add(this.btn_prod_add);
            this.panel1.Controls.Add(this.lst_customer);
            this.panel1.Controls.Add(this.txt_prod_name);
            this.panel1.Controls.Add(this.lbl_prod_name);
            this.panel1.Controls.Add(this.request_dataGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 494);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Panel_CustomerRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Panel_CustomerRequest";
            this.Size = new System.Drawing.Size(1254, 494);
            ((System.ComponentModel.ISupportInitialize)(this.request_dataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
    }
}
