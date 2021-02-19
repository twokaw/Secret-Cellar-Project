
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
            this.cbx_com_port = new System.Windows.Forms.ComboBox();
            this.lbl_com_port = new System.Windows.Forms.Label();
            this.btn_set_comm = new System.Windows.Forms.Button();
            this.btn_comm_default = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_comm_default);
            this.panel1.Controls.Add(this.btn_set_comm);
            this.panel1.Controls.Add(this.lbl_com_port);
            this.panel1.Controls.Add(this.cbx_com_port);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 350);
            this.panel1.TabIndex = 0;
            // 
            // cbx_com_port
            // 
            this.cbx_com_port.FormattingEnabled = true;
            this.cbx_com_port.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.cbx_com_port.Location = new System.Drawing.Point(233, 124);
            this.cbx_com_port.Name = "cbx_com_port";
            this.cbx_com_port.Size = new System.Drawing.Size(121, 21);
            this.cbx_com_port.TabIndex = 1;
            // 
            // lbl_com_port
            // 
            this.lbl_com_port.AutoSize = true;
            this.lbl_com_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_com_port.Location = new System.Drawing.Point(39, 125);
            this.lbl_com_port.Name = "lbl_com_port";
            this.lbl_com_port.Size = new System.Drawing.Size(174, 17);
            this.lbl_com_port.TabIndex = 2;
            this.lbl_com_port.Text = "Cash Drawer COM Port";
            // 
            // btn_set_comm
            // 
            this.btn_set_comm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_set_comm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_set_comm.Location = new System.Drawing.Point(203, 205);
            this.btn_set_comm.Margin = new System.Windows.Forms.Padding(6);
            this.btn_set_comm.Name = "btn_set_comm";
            this.btn_set_comm.Size = new System.Drawing.Size(151, 25);
            this.btn_set_comm.TabIndex = 37;
            this.btn_set_comm.Text = "Set Comm Port";
            this.btn_set_comm.UseVisualStyleBackColor = true;
            this.btn_set_comm.Click += new System.EventHandler(this.btn_set_comm_Click);
            // 
            // btn_comm_default
            // 
            this.btn_comm_default.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_comm_default.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comm_default.Location = new System.Drawing.Point(203, 242);
            this.btn_comm_default.Margin = new System.Windows.Forms.Padding(6);
            this.btn_comm_default.Name = "btn_comm_default";
            this.btn_comm_default.Size = new System.Drawing.Size(151, 25);
            this.btn_comm_default.TabIndex = 38;
            this.btn_comm_default.Text = "Default Comm Port";
            this.btn_comm_default.UseVisualStyleBackColor = true;
            this.btn_comm_default.Click += new System.EventHandler(this.btn_comm_default_Click);
            // 
            // PanHardware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PanHardware";
            this.Size = new System.Drawing.Size(441, 350);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbx_com_port;
        private System.Windows.Forms.Label lbl_com_port;
        private System.Windows.Forms.Button btn_set_comm;
        private System.Windows.Forms.Button btn_comm_default;
    }
}
