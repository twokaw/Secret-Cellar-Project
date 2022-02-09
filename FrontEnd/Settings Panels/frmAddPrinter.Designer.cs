
namespace SecretCellar.Settings_Panels
{
    partial class frmAddPrinter
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
            this.txt_new_cut_code = new System.Windows.Forms.TextBox();
            this.lbl_new_cut_code = new System.Windows.Forms.Label();
            this.txt_drawer_code = new System.Windows.Forms.TextBox();
            this.lbl_new_drawer = new System.Windows.Forms.Label();
            this.txt_print_model = new System.Windows.Forms.TextBox();
            this.lbl_new_print_mdl = new System.Windows.Forms.Label();
            this.lbl_manufact = new System.Windows.Forms.Label();
            this.cbx_manufact = new System.Windows.Forms.ComboBox();
            this.btn_add_print = new System.Windows.Forms.Button();
            this.btn_add_codes = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_print_codes = new System.Windows.Forms.Label();
            this.grid_print_codes = new System.Windows.Forms.DataGridView();
            this.DrawerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CutCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_delete_codes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_print_codes)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_new_cut_code
            // 
            this.txt_new_cut_code.Location = new System.Drawing.Point(80, 354);
            this.txt_new_cut_code.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_new_cut_code.Name = "txt_new_cut_code";
            this.txt_new_cut_code.Size = new System.Drawing.Size(224, 26);
            this.txt_new_cut_code.TabIndex = 58;
            // 
            // lbl_new_cut_code
            // 
            this.lbl_new_cut_code.AutoSize = true;
            this.lbl_new_cut_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_new_cut_code.Location = new System.Drawing.Point(75, 323);
            this.lbl_new_cut_code.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_new_cut_code.Name = "lbl_new_cut_code";
            this.lbl_new_cut_code.Size = new System.Drawing.Size(173, 25);
            this.lbl_new_cut_code.TabIndex = 57;
            this.lbl_new_cut_code.Text = "Printer Cut Code";
            // 
            // txt_drawer_code
            // 
            this.txt_drawer_code.Location = new System.Drawing.Point(82, 288);
            this.txt_drawer_code.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_drawer_code.Name = "txt_drawer_code";
            this.txt_drawer_code.Size = new System.Drawing.Size(224, 26);
            this.txt_drawer_code.TabIndex = 56;
            // 
            // lbl_new_drawer
            // 
            this.lbl_new_drawer.AutoSize = true;
            this.lbl_new_drawer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_new_drawer.Location = new System.Drawing.Point(78, 257);
            this.lbl_new_drawer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_new_drawer.Name = "lbl_new_drawer";
            this.lbl_new_drawer.Size = new System.Drawing.Size(207, 25);
            this.lbl_new_drawer.TabIndex = 55;
            this.lbl_new_drawer.Text = "Printer Drawer Code";
            // 
            // txt_print_model
            // 
            this.txt_print_model.Location = new System.Drawing.Point(82, 209);
            this.txt_print_model.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_print_model.Name = "txt_print_model";
            this.txt_print_model.Size = new System.Drawing.Size(224, 26);
            this.txt_print_model.TabIndex = 54;
            // 
            // lbl_new_print_mdl
            // 
            this.lbl_new_print_mdl.AutoSize = true;
            this.lbl_new_print_mdl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_new_print_mdl.Location = new System.Drawing.Point(81, 178);
            this.lbl_new_print_mdl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_new_print_mdl.Name = "lbl_new_print_mdl";
            this.lbl_new_print_mdl.Size = new System.Drawing.Size(202, 25);
            this.lbl_new_print_mdl.TabIndex = 53;
            this.lbl_new_print_mdl.Text = "Printer Model Name";
            // 
            // lbl_manufact
            // 
            this.lbl_manufact.AutoSize = true;
            this.lbl_manufact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_manufact.Location = new System.Drawing.Point(78, 88);
            this.lbl_manufact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_manufact.Name = "lbl_manufact";
            this.lbl_manufact.Size = new System.Drawing.Size(134, 25);
            this.lbl_manufact.TabIndex = 60;
            this.lbl_manufact.Text = "Printer Make";
            // 
            // cbx_manufact
            // 
            this.cbx_manufact.FormattingEnabled = true;
            this.cbx_manufact.Location = new System.Drawing.Point(82, 118);
            this.cbx_manufact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_manufact.Name = "cbx_manufact";
            this.cbx_manufact.Size = new System.Drawing.Size(180, 28);
            this.cbx_manufact.TabIndex = 59;
            // 
            // btn_add_print
            // 
            this.btn_add_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_print.Location = new System.Drawing.Point(872, 257);
            this.btn_add_print.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.btn_add_print.Name = "btn_add_print";
            this.btn_add_print.Size = new System.Drawing.Size(226, 38);
            this.btn_add_print.TabIndex = 61;
            this.btn_add_print.Text = "Add Printer";
            this.btn_add_print.UseVisualStyleBackColor = true;
            this.btn_add_print.Click += new System.EventHandler(this.btn_add_print_Click);
            // 
            // btn_add_codes
            // 
            this.btn_add_codes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_codes.Location = new System.Drawing.Point(872, 178);
            this.btn_add_codes.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.btn_add_codes.Name = "btn_add_codes";
            this.btn_add_codes.Size = new System.Drawing.Size(226, 38);
            this.btn_add_codes.TabIndex = 62;
            this.btn_add_codes.Text = "Add Print Codes";
            this.btn_add_codes.UseVisualStyleBackColor = true;
            this.btn_add_codes.Click += new System.EventHandler(this.btn_add_codes_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(471, 494);
            this.btn_close.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(226, 38);
            this.btn_close.TabIndex = 63;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_print_codes
            // 
            this.lbl_print_codes.AutoSize = true;
            this.lbl_print_codes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_print_codes.Location = new System.Drawing.Point(404, 132);
            this.lbl_print_codes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_print_codes.Name = "lbl_print_codes";
            this.lbl_print_codes.Size = new System.Drawing.Size(144, 25);
            this.lbl_print_codes.TabIndex = 65;
            this.lbl_print_codes.Text = "Printer Codes";
            // 
            // grid_print_codes
            // 
            this.grid_print_codes.AllowUserToAddRows = false;
            this.grid_print_codes.AllowUserToDeleteRows = false;
            this.grid_print_codes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_print_codes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DrawerCode,
            this.CutCode,
            this.CodeId});
            this.grid_print_codes.Location = new System.Drawing.Point(408, 178);
            this.grid_print_codes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grid_print_codes.Name = "grid_print_codes";
            this.grid_print_codes.ReadOnly = true;
            this.grid_print_codes.RowHeadersVisible = false;
            this.grid_print_codes.RowHeadersWidth = 62;
            this.grid_print_codes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_print_codes.Size = new System.Drawing.Size(405, 231);
            this.grid_print_codes.TabIndex = 64;
            // 
            // DrawerCode
            // 
            this.DrawerCode.DataPropertyName = "Drawer";
            this.DrawerCode.HeaderText = "Drawer Code";
            this.DrawerCode.MinimumWidth = 8;
            this.DrawerCode.Name = "DrawerCode";
            this.DrawerCode.ReadOnly = true;
            this.DrawerCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DrawerCode.Width = 150;
            // 
            // CutCode
            // 
            this.CutCode.DataPropertyName = "Cutter";
            this.CutCode.HeaderText = "Cut Code";
            this.CutCode.MinimumWidth = 8;
            this.CutCode.Name = "CutCode";
            this.CutCode.ReadOnly = true;
            this.CutCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CutCode.Width = 120;
            // 
            // CodeId
            // 
            this.CodeId.DataPropertyName = "CodeId";
            this.CodeId.HeaderText = "CodeId";
            this.CodeId.MinimumWidth = 8;
            this.CodeId.Name = "CodeId";
            this.CodeId.ReadOnly = true;
            this.CodeId.Visible = false;
            this.CodeId.Width = 150;
            // 
            // btn_delete_codes
            // 
            this.btn_delete_codes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_codes.ForeColor = System.Drawing.Color.Red;
            this.btn_delete_codes.Location = new System.Drawing.Point(872, 371);
            this.btn_delete_codes.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.btn_delete_codes.Name = "btn_delete_codes";
            this.btn_delete_codes.Size = new System.Drawing.Size(238, 38);
            this.btn_delete_codes.TabIndex = 66;
            this.btn_delete_codes.Text = "Delete Print Codes";
            this.btn_delete_codes.UseVisualStyleBackColor = true;
            this.btn_delete_codes.Click += new System.EventHandler(this.btn_delete_codes_Click);
            // 
            // frmAddPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1244, 555);
            this.Controls.Add(this.btn_delete_codes);
            this.Controls.Add(this.lbl_print_codes);
            this.Controls.Add(this.grid_print_codes);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_add_codes);
            this.Controls.Add(this.btn_add_print);
            this.Controls.Add(this.lbl_manufact);
            this.Controls.Add(this.cbx_manufact);
            this.Controls.Add(this.txt_new_cut_code);
            this.Controls.Add(this.lbl_new_cut_code);
            this.Controls.Add(this.txt_drawer_code);
            this.Controls.Add(this.lbl_new_drawer);
            this.Controls.Add(this.txt_print_model);
            this.Controls.Add(this.lbl_new_print_mdl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddPrinter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Printer";
            ((System.ComponentModel.ISupportInitialize)(this.grid_print_codes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_new_cut_code;
        private System.Windows.Forms.Label lbl_new_cut_code;
        private System.Windows.Forms.TextBox txt_drawer_code;
        private System.Windows.Forms.Label lbl_new_drawer;
        private System.Windows.Forms.TextBox txt_print_model;
        private System.Windows.Forms.Label lbl_new_print_mdl;
        private System.Windows.Forms.Label lbl_manufact;
        private System.Windows.Forms.ComboBox cbx_manufact;
        private System.Windows.Forms.Button btn_add_print;
        private System.Windows.Forms.Button btn_add_codes;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_print_codes;
        private System.Windows.Forms.DataGridView grid_print_codes;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrawerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CutCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeId;
        private System.Windows.Forms.Button btn_delete_codes;
    }
}