using System.Windows.Forms;

namespace SecretCellar
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.tab_receipt = new System.Windows.Forms.TabControl();
            this.tab_Hardware = new System.Windows.Forms.TabPage();
            this.panHardware = new SecretCellar.Settings_Panels.PanHardware();
            this.tab_Types = new System.Windows.Forms.TabPage();
            this.panTypes = new SecretCellar.Settings_Panels.PanTypes();
            this.tab_Appearance = new System.Windows.Forms.TabPage();
            this.panAppearance1 = new SecretCellar.Settings_Panels.PanAppearance();
            this.tab_Reports = new System.Windows.Forms.TabPage();
            this.panReports1 = new SecretCellar.Settings_Panels.PanReports();
            this.tab_Reciept = new System.Windows.Forms.TabPage();
            this.panReceipt1 = new SecretCellar.Settings_Panels.PanReceipt();
            this.tab_tax = new System.Windows.Forms.TabPage();
            this.panTax1 = new SecretCellar.Settings_Panels.PanTax();
            this.tab_Defaults = new System.Windows.Forms.TabPage();
            this.panDefaults1 = new SecretCellar.Settings_Panels.PanDefaults();
            this.btn_commit = new System.Windows.Forms.Button();
            this.tab_receipt.SuspendLayout();
            this.tab_Hardware.SuspendLayout();
            this.tab_Types.SuspendLayout();
            this.tab_Appearance.SuspendLayout();
            this.tab_Reports.SuspendLayout();
            this.tab_Reciept.SuspendLayout();
            this.tab_tax.SuspendLayout();
            this.tab_Defaults.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_receipt
            // 
            this.tab_receipt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_receipt.Controls.Add(this.tab_Hardware);
            this.tab_receipt.Controls.Add(this.tab_Types);
            this.tab_receipt.Controls.Add(this.tab_Appearance);
            this.tab_receipt.Controls.Add(this.tab_Reports);
            this.tab_receipt.Controls.Add(this.tab_Reciept);
            this.tab_receipt.Controls.Add(this.tab_tax);
            this.tab_receipt.Controls.Add(this.tab_Defaults);
            this.tab_receipt.Location = new System.Drawing.Point(10, 27);
            this.tab_receipt.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tab_receipt.Name = "tab_receipt";
            this.tab_receipt.SelectedIndex = 0;
            this.tab_receipt.Size = new System.Drawing.Size(1430, 777);
            this.tab_receipt.TabIndex = 0;
            // 
            // tab_Hardware
            // 
            this.tab_Hardware.Controls.Add(this.panHardware);
            this.tab_Hardware.Location = new System.Drawing.Point(4, 38);
            this.tab_Hardware.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tab_Hardware.Name = "tab_Hardware";
            this.tab_Hardware.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tab_Hardware.Size = new System.Drawing.Size(1422, 735);
            this.tab_Hardware.TabIndex = 0;
            this.tab_Hardware.Text = "Hardware";
            this.tab_Hardware.UseVisualStyleBackColor = true;
            // 
            // panHardware
            // 
            this.panHardware.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panHardware.Location = new System.Drawing.Point(4, 6);
            this.panHardware.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panHardware.Name = "panHardware";
            this.panHardware.Size = new System.Drawing.Size(1414, 723);
            this.panHardware.TabIndex = 0;
            // 
            // tab_Types
            // 
            this.tab_Types.Controls.Add(this.panTypes);
            this.tab_Types.Location = new System.Drawing.Point(4, 38);
            this.tab_Types.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tab_Types.Name = "tab_Types";
            this.tab_Types.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tab_Types.Size = new System.Drawing.Size(1422, 735);
            this.tab_Types.TabIndex = 1;
            this.tab_Types.Text = "Types";
            this.tab_Types.UseVisualStyleBackColor = true;
            // 
            // panTypes
            // 
            this.panTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.panTypes.Location = new System.Drawing.Point(4, 6);
            this.panTypes.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panTypes.Name = "panTypes";
            this.panTypes.Size = new System.Drawing.Size(1414, 723);
            this.panTypes.TabIndex = 0;
            // 
            // tab_Appearance
            // 
            this.tab_Appearance.Controls.Add(this.panAppearance1);
            this.tab_Appearance.Location = new System.Drawing.Point(4, 38);
            this.tab_Appearance.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tab_Appearance.Name = "tab_Appearance";
            this.tab_Appearance.Size = new System.Drawing.Size(1422, 735);
            this.tab_Appearance.TabIndex = 2;
            this.tab_Appearance.Text = "Appearance";
            this.tab_Appearance.UseVisualStyleBackColor = true;
            // 
            // panAppearance1
            // 
            this.panAppearance1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panAppearance1.Location = new System.Drawing.Point(0, 0);
            this.panAppearance1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panAppearance1.Name = "panAppearance1";
            this.panAppearance1.Size = new System.Drawing.Size(1422, 735);
            this.panAppearance1.TabIndex = 0;
            // 
            // tab_Reports
            // 
            this.tab_Reports.Controls.Add(this.panReports1);
            this.tab_Reports.Location = new System.Drawing.Point(4, 38);
            this.tab_Reports.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tab_Reports.Name = "tab_Reports";
            this.tab_Reports.Size = new System.Drawing.Size(1422, 735);
            this.tab_Reports.TabIndex = 3;
            this.tab_Reports.Text = "Reports";
            this.tab_Reports.UseVisualStyleBackColor = true;
            // 
            // panReports1
            // 
            this.panReports1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panReports1.Location = new System.Drawing.Point(0, 0);
            this.panReports1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panReports1.Name = "panReports1";
            this.panReports1.Size = new System.Drawing.Size(1422, 735);
            this.panReports1.TabIndex = 0;
            this.panReports1.Load += new System.EventHandler(this.panReports1_Load);
            // 
            // tab_Reciept
            // 
            this.tab_Reciept.Controls.Add(this.panReceipt1);
            this.tab_Reciept.Location = new System.Drawing.Point(4, 38);
            this.tab_Reciept.Name = "tab_Reciept";
            this.tab_Reciept.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tab_Reciept.Size = new System.Drawing.Size(1422, 735);
            this.tab_Reciept.TabIndex = 4;
            this.tab_Reciept.Text = "Receipt";
            this.tab_Reciept.UseVisualStyleBackColor = true;
            // 
            // panReceipt1
            // 
            this.panReceipt1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panReceipt1.Location = new System.Drawing.Point(3, 3);
            this.panReceipt1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panReceipt1.Name = "panReceipt1";
            this.panReceipt1.Size = new System.Drawing.Size(1416, 729);
            this.panReceipt1.TabIndex = 0;
            // 
            // tab_tax
            // 
            this.tab_tax.Controls.Add(this.panTax1);
            this.tab_tax.Location = new System.Drawing.Point(4, 38);
            this.tab_tax.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tab_tax.Name = "tab_tax";
            this.tab_tax.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tab_tax.Size = new System.Drawing.Size(1422, 735);
            this.tab_tax.TabIndex = 5;
            this.tab_tax.Text = "Tax";
            this.tab_tax.UseVisualStyleBackColor = true;
            // 
            // panTax1
            // 
            this.panTax1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panTax1.Location = new System.Drawing.Point(4, 6);
            this.panTax1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panTax1.Name = "panTax1";
            this.panTax1.Size = new System.Drawing.Size(1414, 723);
            this.panTax1.TabIndex = 0;
            // 
            // tab_Defaults
            // 
            this.tab_Defaults.Controls.Add(this.panDefaults1);
            this.tab_Defaults.Location = new System.Drawing.Point(4, 38);
            this.tab_Defaults.Name = "tab_Defaults";
            this.tab_Defaults.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tab_Defaults.Size = new System.Drawing.Size(1422, 735);
            this.tab_Defaults.TabIndex = 6;
            this.tab_Defaults.Text = "Defaults";
            this.tab_Defaults.UseVisualStyleBackColor = true;
            this.tab_Defaults.Click += new System.EventHandler(this.tabDefaults_Click);
            // 
            // panDefaults1
            // 
            this.panDefaults1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panDefaults1.Location = new System.Drawing.Point(3, 3);
            this.panDefaults1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panDefaults1.Name = "panDefaults1";
            this.panDefaults1.Size = new System.Drawing.Size(1416, 729);
            this.panDefaults1.TabIndex = 0;
            // 
            // btn_commit
            // 
            this.btn_commit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_commit.AutoSize = true;
            this.btn_commit.Location = new System.Drawing.Point(1275, 818);
            this.btn_commit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_commit.Name = "btn_commit";
            this.btn_commit.Size = new System.Drawing.Size(165, 50);
            this.btn_commit.TabIndex = 4;
            this.btn_commit.Text = "Close";
            this.btn_commit.UseVisualStyleBackColor = true;
            this.btn_commit.Click += new System.EventHandler(this.btn_commit_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1460, 884);
            this.Controls.Add(this.btn_commit);
            this.Controls.Add(this.tab_receipt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.FrmSetting_Load);
            this.tab_receipt.ResumeLayout(false);
            this.tab_Hardware.ResumeLayout(false);
            this.tab_Types.ResumeLayout(false);
            this.tab_Appearance.ResumeLayout(false);
            this.tab_Reports.ResumeLayout(false);
            this.tab_Reciept.ResumeLayout(false);
            this.tab_tax.ResumeLayout(false);
            this.tab_Defaults.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_receipt;
        private System.Windows.Forms.TabPage tab_Hardware;
        private System.Windows.Forms.TabPage tab_Types;
        private System.Windows.Forms.TabPage tab_Appearance;
        private System.Windows.Forms.TabPage tab_Reports;
        private System.Windows.Forms.Button btn_commit;
        private System.Windows.Forms.TabPage tab_Reciept;
        private System.Windows.Forms.TabPage tab_tax;
        private Settings_Panels.PanHardware panHardware;
        private Settings_Panels.PanReports panReports1;
        private Settings_Panels.PanTypes panTypes;
        private Settings_Panels.PanAppearance panAppearance1;
        private Settings_Panels.PanReceipt panReceipt1;
        private Settings_Panels.PanTax panTax1;
        private TabPage tab_Defaults;
        private Settings_Panels.PanDefaults panDefaults1;
        //    private Control panTypes;
    }
}