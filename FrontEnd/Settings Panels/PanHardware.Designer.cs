
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(206)))));
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
            this.panel1.Size = new System.Drawing.Size(1010, 492);
            this.panel1.TabIndex = 0;
            // 
            // btn_add_code
            // 
            this.btn_add_code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_code.Location = new System.Drawing.Point(415, 445);
            this.btn_add_code.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btn_add_code.Name = "btn_add_code";
            this.btn_add_code.Size = new System.Drawing.Size(252, 38);
            this.btn_add_code.TabIndex = 7;
            this.btn_add_code.Text = "Add Print Code";
            this.btn_add_code.UseVisualStyleBackColor = true;
            this.btn_add_code.Click += new System.EventHandler(this.btn_add_code_Click);
            // 
            // lbl_print_model
            // 
            this.lbl_print_model.AutoSize = true;
            this.lbl_print_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_print_model.Location = new System.Drawing.Point(5, 158);
            this.lbl_print_model.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_print_model.Name = "lbl_print_model";
            this.lbl_print_model.Size = new System.Drawing.Size(105, 17);
            this.lbl_print_model.TabIndex = 56;
            this.lbl_print_model.Text = "Printer Model";
            // 
            // lst_print_model
            // 
            this.lst_print_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_print_model.FormattingEnabled = true;
            this.lst_print_model.ItemHeight = 16;
            this.lst_print_model.Location = new System.Drawing.Point(10, 189);
            this.lst_print_model.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lst_print_model.Name = "lst_print_model";
            this.lst_print_model.Size = new System.Drawing.Size(336, 164);
            this.lst_print_model.TabIndex = 4;
            this.lst_print_model.SelectedIndexChanged += new System.EventHandler(this.lst_print_model_SelectedIndexChanged);
            // 
            // lbl_print_codes
            // 
            this.lbl_print_codes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_print_codes.AutoSize = true;
            this.lbl_print_codes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_print_codes.Location = new System.Drawing.Point(407, 77);
            this.lbl_print_codes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_print_codes.Name = "lbl_print_codes";
            this.lbl_print_codes.Size = new System.Drawing.Size(107, 17);
            this.lbl_print_codes.TabIndex = 54;
            this.lbl_print_codes.Text = "Printer Codes";
            // 
            // grid_print_codes
            // 
            this.grid_print_codes.AllowUserToAddRows = false;
            this.grid_print_codes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Ivory;
            this.grid_print_codes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_print_codes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_print_codes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_print_codes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_print_codes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grid_print_codes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_print_codes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DrawerCode,
            this.CutCode,
            this.CodeId});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_print_codes.DefaultCellStyle = dataGridViewCellStyle8;
            this.grid_print_codes.Location = new System.Drawing.Point(412, 108);
            this.grid_print_codes.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grid_print_codes.Name = "grid_print_codes";
            this.grid_print_codes.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_print_codes.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grid_print_codes.RowHeadersVisible = false;
            this.grid_print_codes.RowHeadersWidth = 62;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_print_codes.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.grid_print_codes.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid_print_codes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_print_codes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_print_codes.Size = new System.Drawing.Size(582, 268);
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
            this.btn_new_print.Location = new System.Drawing.Point(15, 445);
            this.btn_new_print.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btn_new_print.Name = "btn_new_print";
            this.btn_new_print.Size = new System.Drawing.Size(252, 38);
            this.btn_new_print.TabIndex = 6;
            this.btn_new_print.Text = "Add New Printer";
            this.btn_new_print.UseVisualStyleBackColor = true;
            this.btn_new_print.Click += new System.EventHandler(this.btn_new_print_Click);
            // 
            // lbl_manufact
            // 
            this.lbl_manufact.AutoSize = true;
            this.lbl_manufact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_manufact.Location = new System.Drawing.Point(5, 77);
            this.lbl_manufact.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_manufact.Name = "lbl_manufact";
            this.lbl_manufact.Size = new System.Drawing.Size(100, 17);
            this.lbl_manufact.TabIndex = 43;
            this.lbl_manufact.Text = "Printer Make";
            // 
            // cbx_manufact
            // 
            this.cbx_manufact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_manufact.FormattingEnabled = true;
            this.cbx_manufact.Location = new System.Drawing.Point(10, 108);
            this.cbx_manufact.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbx_manufact.Name = "cbx_manufact";
            this.cbx_manufact.Size = new System.Drawing.Size(336, 24);
            this.cbx_manufact.TabIndex = 3;
            this.cbx_manufact.SelectedIndexChanged += new System.EventHandler(this.cbx_manufact_SelectedIndexChanged);
            // 
            // btn_set_printer
            // 
            this.btn_set_printer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_set_printer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_set_printer.Location = new System.Drawing.Point(742, 445);
            this.btn_set_printer.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btn_set_printer.Name = "btn_set_printer";
            this.btn_set_printer.Size = new System.Drawing.Size(252, 38);
            this.btn_set_printer.TabIndex = 8;
            this.btn_set_printer.Text = "Set Printer";
            this.btn_set_printer.UseVisualStyleBackColor = true;
            this.btn_set_printer.Click += new System.EventHandler(this.btn_set_printer_Click);
            // 
            // btn_set_comm
            // 
            this.btn_set_comm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_set_comm.Location = new System.Drawing.Point(467, 9);
            this.btn_set_comm.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btn_set_comm.Name = "btn_set_comm";
            this.btn_set_comm.Size = new System.Drawing.Size(252, 38);
            this.btn_set_comm.TabIndex = 2;
            this.btn_set_comm.Text = "Set Comm Port";
            this.btn_set_comm.UseVisualStyleBackColor = true;
            this.btn_set_comm.Click += new System.EventHandler(this.btn_set_comm_Click);
            // 
            // lbl_com_port
            // 
            this.lbl_com_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_com_port.Location = new System.Drawing.Point(5, 18);
            this.lbl_com_port.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_com_port.Name = "lbl_com_port";
            this.lbl_com_port.Size = new System.Drawing.Size(235, 32);
            this.lbl_com_port.TabIndex = 2;
            this.lbl_com_port.Text = "Cash Drawer COM Port";
            // 
            // cbx_com_port
            // 
            this.cbx_com_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_com_port.FormattingEnabled = true;
            this.cbx_com_port.Location = new System.Drawing.Point(250, 14);
            this.cbx_com_port.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbx_com_port.Name = "cbx_com_port";
            this.cbx_com_port.Size = new System.Drawing.Size(199, 24);
            this.cbx_com_port.TabIndex = 1;
            // 
            // PanHardware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "PanHardware";
            this.Size = new System.Drawing.Size(1010, 492);
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
