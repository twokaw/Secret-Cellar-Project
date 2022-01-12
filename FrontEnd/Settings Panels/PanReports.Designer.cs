
namespace SecretCellar.Settings_Panels
{
    partial class PanReports
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
            this.btn_Run = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSalesVendor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSalesInvType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtSalesTotals = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Run
            // 
            this.btn_Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Run.Location = new System.Drawing.Point(12, 18);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(87, 38);
            this.btn_Run.TabIndex = 0;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(494, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(326, 34);
            this.label7.TabIndex = 25;
            this.label7.Text = "Inventory";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtSalesVendor
            // 
            this.TxtSalesVendor.AcceptsReturn = true;
            this.TxtSalesVendor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSalesVendor.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSalesVendor.Location = new System.Drawing.Point(494, 105);
            this.TxtSalesVendor.Multiline = true;
            this.TxtSalesVendor.Name = "TxtSalesVendor";
            this.TxtSalesVendor.ReadOnly = true;
            this.TxtSalesVendor.Size = new System.Drawing.Size(326, 229);
            this.TxtSalesVendor.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(294, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 34);
            this.label6.TabIndex = 23;
            this.label6.Text = "Inventory Type";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtSalesInvType
            // 
            this.TxtSalesInvType.AcceptsReturn = true;
            this.TxtSalesInvType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtSalesInvType.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSalesInvType.Location = new System.Drawing.Point(294, 105);
            this.TxtSalesInvType.Multiline = true;
            this.TxtSalesInvType.Name = "TxtSalesInvType";
            this.TxtSalesInvType.ReadOnly = true;
            this.TxtSalesInvType.Size = new System.Drawing.Size(186, 229);
            this.TxtSalesInvType.TabIndex = 4;
            this.TxtSalesInvType.TextChanged += new System.EventHandler(this.TxtSalesInvType_TextChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(12, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 34);
            this.label8.TabIndex = 21;
            this.label8.Text = "Total";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtSalesTotals
            // 
            this.TxtSalesTotals.AcceptsReturn = true;
            this.TxtSalesTotals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtSalesTotals.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSalesTotals.Location = new System.Drawing.Point(12, 105);
            this.TxtSalesTotals.Multiline = true;
            this.TxtSalesTotals.Name = "TxtSalesTotals";
            this.TxtSalesTotals.ReadOnly = true;
            this.TxtSalesTotals.Size = new System.Drawing.Size(267, 229);
            this.TxtSalesTotals.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(436, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "End:";
            // 
            // dtp_end
            // 
            this.dtp_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_end.Location = new System.Drawing.Point(499, 18);
            this.dtp_end.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(174, 30);
            this.dtp_end.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(143, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Start:";
            // 
            // dtp_start
            // 
            this.dtp_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_start.Location = new System.Drawing.Point(213, 18);
            this.dtp_start.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(174, 30);
            this.dtp_start.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Run);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TxtSalesVendor);
            this.panel1.Controls.Add(this.TxtSalesInvType);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TxtSalesTotals);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtp_end);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtp_start);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 345);
            this.panel1.TabIndex = 29;
            // 
            // PanReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "PanReports";
            this.Size = new System.Drawing.Size(832, 345);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSalesVendor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSalesInvType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtSalesTotals;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.Panel panel1;
    }
}
