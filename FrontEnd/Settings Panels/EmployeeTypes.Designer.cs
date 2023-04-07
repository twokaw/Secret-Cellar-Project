namespace SecretCellar.Settings_Panels
{
    partial class PanEmployeeTypes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.PanempTypes = new System.Windows.Forms.Panel();
			this.dataGridView_employeeTypes = new System.Windows.Forms.DataGridView();
			this.button_delete = new System.Windows.Forms.Button();
			this.chk_lstbx_Roles = new System.Windows.Forms.CheckedListBox();
			this.lbl_emp_name = new System.Windows.Forms.Label();
			this.btn_clear = new System.Windows.Forms.Button();
			this.txt_typeName = new System.Windows.Forms.TextBox();
			this.btn_update = new System.Windows.Forms.Button();
			this.btn_new = new System.Windows.Forms.Button();
			this.txt_roleDescription = new System.Windows.Forms.TextBox();
			this.lbl_description = new System.Windows.Forms.Label();
			this.lbl_emp_roles = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbx_empTypes = new System.Windows.Forms.ComboBox();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PanempTypes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_employeeTypes)).BeginInit();
			this.SuspendLayout();
			// 
			// PanempTypes
			// 
			this.PanempTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(223)))), ((int)(((byte)(234)))));
			this.PanempTypes.Controls.Add(this.dataGridView_employeeTypes);
			this.PanempTypes.Controls.Add(this.button_delete);
			this.PanempTypes.Controls.Add(this.chk_lstbx_Roles);
			this.PanempTypes.Controls.Add(this.lbl_emp_name);
			this.PanempTypes.Controls.Add(this.btn_clear);
			this.PanempTypes.Controls.Add(this.txt_typeName);
			this.PanempTypes.Controls.Add(this.btn_update);
			this.PanempTypes.Controls.Add(this.btn_new);
			this.PanempTypes.Controls.Add(this.txt_roleDescription);
			this.PanempTypes.Controls.Add(this.lbl_description);
			this.PanempTypes.Controls.Add(this.lbl_emp_roles);
			this.PanempTypes.Controls.Add(this.label1);
			this.PanempTypes.Controls.Add(this.cbx_empTypes);
			this.PanempTypes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PanempTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PanempTypes.Location = new System.Drawing.Point(0, 0);
			this.PanempTypes.Margin = new System.Windows.Forms.Padding(5);
			this.PanempTypes.Name = "PanempTypes";
			this.PanempTypes.Size = new System.Drawing.Size(1060, 475);
			this.PanempTypes.TabIndex = 0;
			// 
			// dataGridView_employeeTypes
			// 
			this.dataGridView_employeeTypes.AllowUserToAddRows = false;
			this.dataGridView_employeeTypes.AllowUserToDeleteRows = false;
			this.dataGridView_employeeTypes.AllowUserToResizeColumns = false;
			this.dataGridView_employeeTypes.AllowUserToResizeRows = false;
			this.dataGridView_employeeTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView_employeeTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_employeeTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Type});
			this.dataGridView_employeeTypes.Location = new System.Drawing.Point(231, 59);
			this.dataGridView_employeeTypes.MultiSelect = false;
			this.dataGridView_employeeTypes.Name = "dataGridView_employeeTypes";
			this.dataGridView_employeeTypes.ReadOnly = true;
			this.dataGridView_employeeTypes.RowHeadersVisible = false;
			this.dataGridView_employeeTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_employeeTypes.Size = new System.Drawing.Size(240, 150);
			this.dataGridView_employeeTypes.TabIndex = 14;
			this.dataGridView_employeeTypes.SelectionChanged += new System.EventHandler(this.dataGridView_employeeTypes_SelectionChanged);
			// 
			// button_delete
			// 
			this.button_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
			this.button_delete.Location = new System.Drawing.Point(27, 417);
			this.button_delete.Margin = new System.Windows.Forms.Padding(5);
			this.button_delete.Name = "button_delete";
			this.button_delete.Size = new System.Drawing.Size(160, 46);
			this.button_delete.TabIndex = 12;
			this.button_delete.Text = "Delete";
			this.button_delete.UseVisualStyleBackColor = true;
			// 
			// chk_lstbx_Roles
			// 
			this.chk_lstbx_Roles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.chk_lstbx_Roles.FormattingEnabled = true;
			this.chk_lstbx_Roles.Location = new System.Drawing.Point(496, 59);
			this.chk_lstbx_Roles.Margin = new System.Windows.Forms.Padding(5);
			this.chk_lstbx_Roles.Name = "chk_lstbx_Roles";
			this.chk_lstbx_Roles.Size = new System.Drawing.Size(169, 319);
			this.chk_lstbx_Roles.TabIndex = 11;
			this.chk_lstbx_Roles.SelectedIndexChanged += new System.EventHandler(this.chk_lstbx_Roles_SelectedIndexChanged);
			// 
			// lbl_emp_name
			// 
			this.lbl_emp_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_emp_name.AutoSize = true;
			this.lbl_emp_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
			this.lbl_emp_name.Location = new System.Drawing.Point(22, 249);
			this.lbl_emp_name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lbl_emp_name.Name = "lbl_emp_name";
			this.lbl_emp_name.Size = new System.Drawing.Size(148, 29);
			this.lbl_emp_name.TabIndex = 10;
			this.lbl_emp_name.Text = "Type Name";
			// 
			// btn_clear
			// 
			this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
			this.btn_clear.Location = new System.Drawing.Point(27, 332);
			this.btn_clear.Margin = new System.Windows.Forms.Padding(5);
			this.btn_clear.Name = "btn_clear";
			this.btn_clear.Size = new System.Drawing.Size(124, 46);
			this.btn_clear.TabIndex = 9;
			this.btn_clear.Text = "Clear";
			this.btn_clear.UseVisualStyleBackColor = true;
			this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
			// 
			// txt_typeName
			// 
			this.txt_typeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txt_typeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
			this.txt_typeName.Location = new System.Drawing.Point(27, 282);
			this.txt_typeName.Margin = new System.Windows.Forms.Padding(5);
			this.txt_typeName.Name = "txt_typeName";
			this.txt_typeName.Size = new System.Drawing.Size(196, 32);
			this.txt_typeName.TabIndex = 8;
			// 
			// btn_update
			// 
			this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
			this.btn_update.Location = new System.Drawing.Point(194, 332);
			this.btn_update.Margin = new System.Windows.Forms.Padding(5);
			this.btn_update.Name = "btn_update";
			this.btn_update.Size = new System.Drawing.Size(160, 46);
			this.btn_update.TabIndex = 7;
			this.btn_update.Text = "Update";
			this.btn_update.UseVisualStyleBackColor = true;
			this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
			// 
			// btn_new
			// 
			this.btn_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
			this.btn_new.Location = new System.Drawing.Point(717, 417);
			this.btn_new.Margin = new System.Windows.Forms.Padding(5);
			this.btn_new.Name = "btn_new";
			this.btn_new.Size = new System.Drawing.Size(160, 46);
			this.btn_new.TabIndex = 6;
			this.btn_new.Text = "New";
			this.btn_new.UseVisualStyleBackColor = true;
			this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
			// 
			// txt_roleDescription
			// 
			this.txt_roleDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_roleDescription.Location = new System.Drawing.Point(731, 59);
			this.txt_roleDescription.Margin = new System.Windows.Forms.Padding(5);
			this.txt_roleDescription.Multiline = true;
			this.txt_roleDescription.Name = "txt_roleDescription";
			this.txt_roleDescription.Size = new System.Drawing.Size(315, 319);
			this.txt_roleDescription.TabIndex = 5;
			// 
			// lbl_description
			// 
			this.lbl_description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_description.AutoSize = true;
			this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_description.Location = new System.Drawing.Point(726, 16);
			this.lbl_description.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lbl_description.Name = "lbl_description";
			this.lbl_description.Size = new System.Drawing.Size(200, 26);
			this.lbl_description.TabIndex = 4;
			this.lbl_description.Text = "Roles Description";
			// 
			// lbl_emp_roles
			// 
			this.lbl_emp_roles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_emp_roles.AutoSize = true;
			this.lbl_emp_roles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_emp_roles.Location = new System.Drawing.Point(491, 16);
			this.lbl_emp_roles.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lbl_emp_roles.Name = "lbl_emp_roles";
			this.lbl_emp_roles.Size = new System.Drawing.Size(186, 26);
			this.lbl_emp_roles.TabIndex = 2;
			this.lbl_emp_roles.Text = "Employee Roles";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(22, 24);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(209, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "Employee Types";
			// 
			// cbx_empTypes
			// 
			this.cbx_empTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
			this.cbx_empTypes.FormattingEnabled = true;
			this.cbx_empTypes.Location = new System.Drawing.Point(27, 59);
			this.cbx_empTypes.Margin = new System.Windows.Forms.Padding(5);
			this.cbx_empTypes.Name = "cbx_empTypes";
			this.cbx_empTypes.Size = new System.Drawing.Size(196, 33);
			this.cbx_empTypes.TabIndex = 0;
			this.cbx_empTypes.SelectedIndexChanged += new System.EventHandler(this.cbx_empTypes_SelectedIndexChanged);
			// 
			// Id
			// 
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			// 
			// Type
			// 
			this.Type.DataPropertyName = "Type";
			this.Type.HeaderText = "Type";
			this.Type.Name = "Type";
			this.Type.ReadOnly = true;
			// 
			// PanEmployeeTypes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(201)))), ((int)(((byte)(176)))));
			this.Controls.Add(this.PanempTypes);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "PanEmployeeTypes";
			this.Size = new System.Drawing.Size(1060, 475);
			this.PanempTypes.ResumeLayout(false);
			this.PanempTypes.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_employeeTypes)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanempTypes;
        private System.Windows.Forms.ComboBox cbx_empTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_emp_roles;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.TextBox txt_roleDescription;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_typeName;
        private System.Windows.Forms.Label lbl_emp_name;
        private System.Windows.Forms.CheckedListBox chk_lstbx_Roles;
		private System.Windows.Forms.Button button_delete;
		private System.Windows.Forms.DataGridView dataGridView_employeeTypes;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Type;
	}
}
