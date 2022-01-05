
namespace SecretCellar.Settings_Panels
{
    partial class PanHardware
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add_code = new System.Windows.Forms.Button();
            this.lbl_print_model = new System.Windows.Forms.Label();
            this.lst_print_model = new System.Windows.Forms.ListBox();
            this.lbl_print_codes = new System.Windows.Forms.Label();
            this.grid_print_codes = new System.Windows.Forms.DataGridView();
            this.DrawerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CutCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_new_print = new System.Windows.Forms.Button();
            this.lbl_manufact = new System.Windows.Forms.Label();
            this.cbx_manufact = new System.Windows.Forms.ComboBox();
            this.btn_set_printer = new System.Windows.Forms.Button();
            this.btn_set_comm = new System.Windows.Forms.Button();
            this.lbl_com_port = new System.Windows.Forms.Label();
            this.cbx_com_port = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_print_codes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_add_code);
            this.panel1.Controls.Add(this.lbl_print_model);
            this.panel1.Controls.Add(this.lst_print_model);
            this.panel1.Controls.Add(this.lbl_print_codes);
            this.panel1.Controls.Add(this.grid_print_codes);
            this.panel1.Controls.Add(this.btn_new_print);
            this.panel1.Controls.Add(this.lbl_manufact);
            this.panel1.Controls.Add(this.cbx_manufact);
            this.panel1.Controls.Add(this.btn_set_printer);
            this.panel1.Controls.Add(this.btn_set_comm);
            this.panel1.Controls.Add(this.lbl_com_port);
            this.panel1.Controls.Add(this.cbx_com_port);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 492);
            this.panel1.TabIndex = 0;
            // 
            // btn_add_code
            // 
            this.btn_add_code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_code.Location = new System.Drawing.Point(374, 445);
            this.btn_add_code.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.btn_add_code.Name = "btn_add_code";
            this.btn_add_code.Size = new System.Drawing.Size(226, 38);
            this.btn_add_code.TabIndex = 7;
            this.btn_add_code.Text = "Add Print Code";
            this.btn_add_code.UseVisualStyleBackColor = true;
            this.btn_add_code.Click += new System.EventHandler(this.btn_add_code_Click);
            // 
            // lbl_print_model
            // 
            this.lbl_print_model.AutoSize = true;
            this.lbl_print_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_print_model.Location = new System.Drawing.Point(4, 158);
            this.lbl_print_model.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_print_model.Name = "lbl_print_model";
            this.lbl_print_model.Size = new System.Drawing.Size(140, 25);
            this.lbl_print_model.TabIndex = 56;
            this.lbl_print_model.Text = "Printer Model";
            // 
            // lst_print_model
            // 
            this.lst_print_model.FormattingEnabled = true;
            this.lst_print_model.ItemHeight = 20;
            this.lst_print_model.Location = new System.Drawing.Point(9, 189);
            this.lst_print_model.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst_print_model.Name = "lst_print_model";
            this.lst_print_model.Size = new System.Drawing.Size(302, 184);
            this.lst_print_model.TabIndex = 4;
            this.lst_print_model.SelectedIndexChanged += new System.EventHandler(this.lst_print_model_SelectedIndexChanged);
            // 
            // lbl_print_codes
            // 
            this.lbl_print_codes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_print_codes.AutoSize = true;
            this.lbl_print_codes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_print_codes.Location = new System.Drawing.Point(366, 77);
            this.lbl_print_codes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_print_codes.Name = "lbl_print_codes";
            this.lbl_print_codes.Size = new System.Drawing.Size(144, 25);
            this.lbl_print_codes.TabIndex = 54;
            this.lbl_print_codes.Text = "Printer Codes";
            // 
            // grid_print_codes
            // 
            this.grid_print_codes.AllowUserToAddRows = false;
            this.grid_print_codes.AllowUserToDeleteRows = false;
            this.grid_print_codes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_print_codes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_print_codes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_print_codes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DrawerCode,
            this.CutCode,
            this.CodeId});
            this.grid_print_codes.Location = new System.Drawing.Point(370, 108);
            this.grid_print_codes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grid_print_codes.Name = "grid_print_codes";
            this.grid_print_codes.ReadOnly = true;
            this.grid_print_codes.RowHeadersVisible = false;
            this.grid_print_codes.RowHeadersWidth = 62;
            this.grid_print_codes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_print_codes.Size = new System.Drawing.Size(524, 268);
            this.grid_print_codes.TabIndex = 5;
            // 
            // DrawerCode
            // 
            this.DrawerCode.DataPropertyName = "Drawer";
            this.DrawerCode.HeaderText = "Drawer Code";
            this.DrawerCode.MinimumWidth = 8;
            this.DrawerCode.Name = "DrawerCode";
            this.DrawerCode.ReadOnly = true;
            this.DrawerCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CutCode
            // 
            this.CutCode.DataPropertyName = "Cutter";
            this.CutCode.HeaderText = "Cut Code";
            this.CutCode.MinimumWidth = 8;
            this.CutCode.Name = "CutCode";
            this.CutCode.ReadOnly = true;
            this.CutCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CodeId
            // 
            this.CodeId.DataPropertyName = "CodeId";
            this.CodeId.HeaderText = "CodeId";
            this.CodeId.MinimumWidth = 8;
            this.CodeId.Name = "CodeId";
            this.CodeId.ReadOnly = true;
            this.CodeId.Visible = false;
            // 
            // btn_new_print
            // 
            this.btn_new_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_new_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new_print.Location = new System.Drawing.Point(14, 445);
            this.btn_new_print.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.btn_new_print.Name = "btn_new_print";
            this.btn_new_print.Size = new System.Drawing.Size(226, 38);
            this.btn_new_print.TabIndex = 6;
            this.btn_new_print.Text = "Add New Printer";
            this.btn_new_print.UseVisualStyleBackColor = true;
            this.btn_new_print.Click += new System.EventHandler(this.btn_new_print_Click);
            // 
            // lbl_manufact
            // 
            this.lbl_manufact.AutoSize = true;
            this.lbl_manufact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_manufact.Location = new System.Drawing.Point(4, 77);
            this.lbl_manufact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_manufact.Name = "lbl_manufact";
            this.lbl_manufact.Size = new System.Drawing.Size(134, 25);
            this.lbl_manufact.TabIndex = 43;
            this.lbl_manufact.Text = "Printer Make";
            // 
            // cbx_manufact
            // 
            this.cbx_manufact.FormattingEnabled = true;
            this.cbx_manufact.Location = new System.Drawing.Point(9, 108);
            this.cbx_manufact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_manufact.Name = "cbx_manufact";
            this.cbx_manufact.Size = new System.Drawing.Size(302, 28);
            this.cbx_manufact.TabIndex = 3;
            this.cbx_manufact.SelectedIndexChanged += new System.EventHandler(this.cbx_manufact_SelectedIndexChanged);
            // 
            // btn_set_printer
            // 
            this.btn_set_printer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_set_printer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_set_printer.Location = new System.Drawing.Point(668, 445);
            this.btn_set_printer.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.btn_set_printer.Name = "btn_set_printer";
            this.btn_set_printer.Size = new System.Drawing.Size(226, 38);
            this.btn_set_printer.TabIndex = 8;
            this.btn_set_printer.Text = "Set Printer";
            this.btn_set_printer.UseVisualStyleBackColor = true;
            this.btn_set_printer.Click += new System.EventHandler(this.btn_set_printer_Click);
            // 
            // btn_set_comm
            // 
            this.btn_set_comm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_set_comm.Location = new System.Drawing.Point(420, 9);
            this.btn_set_comm.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.btn_set_comm.Name = "btn_set_comm";
            this.btn_set_comm.Size = new System.Drawing.Size(226, 38);
            this.btn_set_comm.TabIndex = 2;
            this.btn_set_comm.Text = "Set Comm Port";
            this.btn_set_comm.UseVisualStyleBackColor = true;
            this.btn_set_comm.Click += new System.EventHandler(this.btn_set_comm_Click);
            // 
            // lbl_com_port
            // 
            this.lbl_com_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_com_port.Location = new System.Drawing.Point(4, 18);
            this.lbl_com_port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_com_port.Name = "lbl_com_port";
            this.lbl_com_port.Size = new System.Drawing.Size(212, 32);
            this.lbl_com_port.TabIndex = 2;
            this.lbl_com_port.Text = "Cash Drawer COM Port";
            // 
            // cbx_com_port
            // 
            this.cbx_com_port.FormattingEnabled = true;
            this.cbx_com_port.Location = new System.Drawing.Point(225, 14);
            this.cbx_com_port.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_com_port.Name = "cbx_com_port";
            this.cbx_com_port.Size = new System.Drawing.Size(180, 28);
            this.cbx_com_port.TabIndex = 1;
            // 
            // PanHardware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "PanHardware";
            this.Size = new System.Drawing.Size(909, 492);
            this.Load += new System.EventHandler(this.PanHardware_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_print_codes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbx_com_port;
        private System.Windows.Forms.Label lbl_com_port;
        private System.Windows.Forms.Button btn_set_comm;
        private System.Windows.Forms.Button btn_set_printer;
        private System.Windows.Forms.Label lbl_manufact;
        private System.Windows.Forms.ComboBox cbx_manufact;
        private System.Windows.Forms.Button btn_new_print;
        private System.Windows.Forms.Label lbl_print_model;
        private System.Windows.Forms.ListBox lst_print_model;
        private System.Windows.Forms.Label lbl_print_codes;
        private System.Windows.Forms.DataGridView grid_print_codes;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrawerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CutCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeId;
        private System.Windows.Forms.Button btn_add_code;
    }
}
