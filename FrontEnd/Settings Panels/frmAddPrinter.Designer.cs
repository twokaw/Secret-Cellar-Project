
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
            this.SuspendLayout();
            // 
            // txt_new_cut_code
            // 
            this.txt_new_cut_code.Location = new System.Drawing.Point(53, 230);
            this.txt_new_cut_code.Name = "txt_new_cut_code";
            this.txt_new_cut_code.Size = new System.Drawing.Size(151, 20);
            this.txt_new_cut_code.TabIndex = 58;
            // 
            // lbl_new_cut_code
            // 
            this.lbl_new_cut_code.AutoSize = true;
            this.lbl_new_cut_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_new_cut_code.Location = new System.Drawing.Point(50, 210);
            this.lbl_new_cut_code.Name = "lbl_new_cut_code";
            this.lbl_new_cut_code.Size = new System.Drawing.Size(128, 17);
            this.lbl_new_cut_code.TabIndex = 57;
            this.lbl_new_cut_code.Text = "Printer Cut Code";
            // 
            // txt_drawer_code
            // 
            this.txt_drawer_code.Location = new System.Drawing.Point(55, 187);
            this.txt_drawer_code.Name = "txt_drawer_code";
            this.txt_drawer_code.Size = new System.Drawing.Size(151, 20);
            this.txt_drawer_code.TabIndex = 56;
            // 
            // lbl_new_drawer
            // 
            this.lbl_new_drawer.AutoSize = true;
            this.lbl_new_drawer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_new_drawer.Location = new System.Drawing.Point(52, 167);
            this.lbl_new_drawer.Name = "lbl_new_drawer";
            this.lbl_new_drawer.Size = new System.Drawing.Size(155, 17);
            this.lbl_new_drawer.TabIndex = 55;
            this.lbl_new_drawer.Text = "Printer Drawer Code";
            // 
            // txt_print_model
            // 
            this.txt_print_model.Location = new System.Drawing.Point(55, 136);
            this.txt_print_model.Name = "txt_print_model";
            this.txt_print_model.Size = new System.Drawing.Size(151, 20);
            this.txt_print_model.TabIndex = 54;
            // 
            // lbl_new_print_mdl
            // 
            this.lbl_new_print_mdl.AutoSize = true;
            this.lbl_new_print_mdl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_new_print_mdl.Location = new System.Drawing.Point(54, 116);
            this.lbl_new_print_mdl.Name = "lbl_new_print_mdl";
            this.lbl_new_print_mdl.Size = new System.Drawing.Size(151, 17);
            this.lbl_new_print_mdl.TabIndex = 53;
            this.lbl_new_print_mdl.Text = "Printer Model Name";
            // 
            // lbl_manufact
            // 
            this.lbl_manufact.AutoSize = true;
            this.lbl_manufact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_manufact.Location = new System.Drawing.Point(52, 57);
            this.lbl_manufact.Name = "lbl_manufact";
            this.lbl_manufact.Size = new System.Drawing.Size(100, 17);
            this.lbl_manufact.TabIndex = 60;
            this.lbl_manufact.Text = "Printer Make";
            // 
            // cbx_manufact
            // 
            this.cbx_manufact.FormattingEnabled = true;
            this.cbx_manufact.Location = new System.Drawing.Point(55, 77);
            this.cbx_manufact.Name = "cbx_manufact";
            this.cbx_manufact.Size = new System.Drawing.Size(121, 21);
            this.cbx_manufact.TabIndex = 59;
            // 
            // btn_add_print
            // 
            this.btn_add_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_print.Location = new System.Drawing.Point(301, 167);
            this.btn_add_print.Margin = new System.Windows.Forms.Padding(6);
            this.btn_add_print.Name = "btn_add_print";
            this.btn_add_print.Size = new System.Drawing.Size(151, 25);
            this.btn_add_print.TabIndex = 61;
            this.btn_add_print.Text = "Add Printer";
            this.btn_add_print.UseVisualStyleBackColor = true;
            this.btn_add_print.Click += new System.EventHandler(this.btn_add_print_Click);
            // 
            // btn_add_codes
            // 
            this.btn_add_codes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_codes.Location = new System.Drawing.Point(301, 116);
            this.btn_add_codes.Margin = new System.Windows.Forms.Padding(6);
            this.btn_add_codes.Name = "btn_add_codes";
            this.btn_add_codes.Size = new System.Drawing.Size(151, 25);
            this.btn_add_codes.TabIndex = 62;
            this.btn_add_codes.Text = "Add Print Codes";
            this.btn_add_codes.UseVisualStyleBackColor = true;
            this.btn_add_codes.Click += new System.EventHandler(this.btn_add_codes_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(180, 298);
            this.btn_close.Margin = new System.Windows.Forms.Padding(6);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(151, 25);
            this.btn_close.TabIndex = 63;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // frmAddPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
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
            this.Name = "frmAddPrinter";
            this.Text = "frmAddPrinter";
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
    }
}