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
            this.panHardware1 = new SecretCellar.Settings_Panels.PanHardware();
            this.tab_Types = new System.Windows.Forms.TabPage();
            this.panTypes1 = new SecretCellar.Settings_Panels.PanTypes();
            this.tab_Appearance = new System.Windows.Forms.TabPage();
            this.panAppearance1 = new SecretCellar.Settings_Panels.PanAppearance();
            this.tab_Reports = new System.Windows.Forms.TabPage();
            this.panReports1 = new SecretCellar.Settings_Panels.PanReports();
            this.tab_Reciept = new System.Windows.Forms.TabPage();
            this.tab_tax = new System.Windows.Forms.TabPage();
            this.btn_update_tax = new System.Windows.Forms.Button();
            this.txt_tax_list = new System.Windows.Forms.Label();
            this.lst_tax_list = new System.Windows.Forms.ListBox();
            this.lbl_btl_deposit = new System.Windows.Forms.Label();
            this.lbl_local_tax = new System.Windows.Forms.Label();
            this.lbl_sales_tax = new System.Windows.Forms.Label();
            this.txt_bottle_dep = new System.Windows.Forms.TextBox();
            this.txt_local_tax = new System.Windows.Forms.TextBox();
            this.txt_sales_tax = new System.Windows.Forms.TextBox();
            this.btn_commit = new System.Windows.Forms.Button();
            this.panReceipt1 = new SecretCellar.Settings_Panels.PanReceipt();
            this.tab_receipt.SuspendLayout();
            this.tab_Hardware.SuspendLayout();
            this.tab_Types.SuspendLayout();
            this.tab_Appearance.SuspendLayout();
            this.tab_Reports.SuspendLayout();
            this.tab_Reciept.SuspendLayout();
            this.tab_tax.SuspendLayout();
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
            this.tab_receipt.Location = new System.Drawing.Point(9, 23);
            this.tab_receipt.Margin = new System.Windows.Forms.Padding(6);
            this.tab_receipt.Name = "tab_receipt";
            this.tab_receipt.SelectedIndex = 0;
            this.tab_receipt.Size = new System.Drawing.Size(1319, 540);
            this.tab_receipt.TabIndex = 0;
            // 
            // tab_Hardware
            // 
            this.tab_Hardware.Controls.Add(this.panHardware1);
            this.tab_Hardware.Location = new System.Drawing.Point(4, 34);
            this.tab_Hardware.Margin = new System.Windows.Forms.Padding(6);
            this.tab_Hardware.Name = "tab_Hardware";
            this.tab_Hardware.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab_Hardware.Size = new System.Drawing.Size(1311, 502);
            this.tab_Hardware.TabIndex = 0;
            this.tab_Hardware.Text = "Hardware";
            this.tab_Hardware.UseVisualStyleBackColor = true;
            // 
            // panHardware1
            // 
            this.panHardware1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panHardware1.Location = new System.Drawing.Point(4, 5);
            this.panHardware1.Margin = new System.Windows.Forms.Padding(4);
            this.panHardware1.Name = "panHardware1";
            this.panHardware1.Size = new System.Drawing.Size(1303, 492);
            this.panHardware1.TabIndex = 0;
            // 
            // tab_Types
            // 
            this.tab_Types.Controls.Add(this.panTypes1);
            this.tab_Types.Location = new System.Drawing.Point(4, 34);
            this.tab_Types.Margin = new System.Windows.Forms.Padding(6);
            this.tab_Types.Name = "tab_Types";
            this.tab_Types.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab_Types.Size = new System.Drawing.Size(1311, 502);
            this.tab_Types.TabIndex = 1;
            this.tab_Types.Text = "Types";
            this.tab_Types.UseVisualStyleBackColor = true;
            // 
            // panTypes1
            // 
            this.panTypes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panTypes1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.panTypes1.Location = new System.Drawing.Point(4, 5);
            this.panTypes1.Margin = new System.Windows.Forms.Padding(4);
            this.panTypes1.Name = "panTypes1";
            this.panTypes1.Size = new System.Drawing.Size(1303, 492);
            this.panTypes1.TabIndex = 0;
            // 
            // tab_Appearance
            // 
            this.tab_Appearance.Controls.Add(this.panAppearance1);
            this.tab_Appearance.Location = new System.Drawing.Point(4, 34);
            this.tab_Appearance.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.tab_Appearance.Name = "tab_Appearance";
            this.tab_Appearance.Size = new System.Drawing.Size(1311, 502);
            this.tab_Appearance.TabIndex = 2;
            this.tab_Appearance.Text = "Appearance";
            this.tab_Appearance.UseVisualStyleBackColor = true;
            // 
            // panAppearance1
            // 
            this.panAppearance1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panAppearance1.Location = new System.Drawing.Point(0, 0);
            this.panAppearance1.Margin = new System.Windows.Forms.Padding(4);
            this.panAppearance1.Name = "panAppearance1";
            this.panAppearance1.Size = new System.Drawing.Size(1311, 502);
            this.panAppearance1.TabIndex = 0;
            // 
            // tab_Reports
            // 
            this.tab_Reports.Controls.Add(this.panReports1);
            this.tab_Reports.Location = new System.Drawing.Point(4, 34);
            this.tab_Reports.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.tab_Reports.Name = "tab_Reports";
            this.tab_Reports.Size = new System.Drawing.Size(1311, 502);
            this.tab_Reports.TabIndex = 3;
            this.tab_Reports.Text = "Reports";
            this.tab_Reports.UseVisualStyleBackColor = true;
            // 
            // panReports1
            // 
            this.panReports1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panReports1.Location = new System.Drawing.Point(0, 0);
            this.panReports1.Margin = new System.Windows.Forms.Padding(4);
            this.panReports1.Name = "panReports1";
            this.panReports1.Size = new System.Drawing.Size(1311, 502);
            this.panReports1.TabIndex = 0;
            // 
            // tab_Reciept
            // 
            this.tab_Reciept.Controls.Add(this.panReceipt1);
            this.tab_Reciept.Location = new System.Drawing.Point(4, 34);
            this.tab_Reciept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_Reciept.Name = "tab_Reciept";
            this.tab_Reciept.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_Reciept.Size = new System.Drawing.Size(1311, 502);
            this.tab_Reciept.TabIndex = 4;
            this.tab_Reciept.Text = "Receipt";
            this.tab_Reciept.UseVisualStyleBackColor = true;
            // 
            // tab_tax
            // 
            this.tab_tax.Controls.Add(this.btn_update_tax);
            this.tab_tax.Controls.Add(this.txt_tax_list);
            this.tab_tax.Controls.Add(this.lst_tax_list);
            this.tab_tax.Controls.Add(this.lbl_btl_deposit);
            this.tab_tax.Controls.Add(this.lbl_local_tax);
            this.tab_tax.Controls.Add(this.lbl_sales_tax);
            this.tab_tax.Controls.Add(this.txt_bottle_dep);
            this.tab_tax.Controls.Add(this.txt_local_tax);
            this.tab_tax.Controls.Add(this.txt_sales_tax);
            this.tab_tax.Location = new System.Drawing.Point(4, 34);
            this.tab_tax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab_tax.Name = "tab_tax";
            this.tab_tax.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab_tax.Size = new System.Drawing.Size(1311, 502);
            this.tab_tax.TabIndex = 5;
            this.tab_tax.Text = "Tax";
            this.tab_tax.UseVisualStyleBackColor = true;
            // 
            // btn_update_tax
            // 
            this.btn_update_tax.Location = new System.Drawing.Point(949, 216);
            this.btn_update_tax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_update_tax.Name = "btn_update_tax";
            this.btn_update_tax.Size = new System.Drawing.Size(188, 36);
            this.btn_update_tax.TabIndex = 8;
            this.btn_update_tax.Text = "Update";
            this.btn_update_tax.UseVisualStyleBackColor = true;
            this.btn_update_tax.Click += new System.EventHandler(this.btn_update_tax_Click);
            // 
            // txt_tax_list
            // 
            this.txt_tax_list.AutoSize = true;
            this.txt_tax_list.Location = new System.Drawing.Point(153, 97);
            this.txt_tax_list.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_tax_list.Name = "txt_tax_list";
            this.txt_tax_list.Size = new System.Drawing.Size(122, 25);
            this.txt_tax_list.TabIndex = 7;
            this.txt_tax_list.Text = "Tax Types:";
            // 
            // lst_tax_list
            // 
            this.lst_tax_list.FormattingEnabled = true;
            this.lst_tax_list.ItemHeight = 25;
            this.lst_tax_list.Location = new System.Drawing.Point(157, 145);
            this.lst_tax_list.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst_tax_list.Name = "lst_tax_list";
            this.lst_tax_list.Size = new System.Drawing.Size(229, 154);
            this.lst_tax_list.TabIndex = 6;
            // 
            // lbl_btl_deposit
            // 
            this.lbl_btl_deposit.AutoSize = true;
            this.lbl_btl_deposit.Location = new System.Drawing.Point(471, 264);
            this.lbl_btl_deposit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_btl_deposit.Name = "lbl_btl_deposit";
            this.lbl_btl_deposit.Size = new System.Drawing.Size(153, 25);
            this.lbl_btl_deposit.TabIndex = 5;
            this.lbl_btl_deposit.Text = "Bottle Deposit:";
            // 
            // lbl_local_tax
            // 
            this.lbl_local_tax.AutoSize = true;
            this.lbl_local_tax.Location = new System.Drawing.Point(514, 223);
            this.lbl_local_tax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_local_tax.Name = "lbl_local_tax";
            this.lbl_local_tax.Size = new System.Drawing.Size(114, 25);
            this.lbl_local_tax.TabIndex = 4;
            this.lbl_local_tax.Text = "Local Tax:";
            // 
            // lbl_sales_tax
            // 
            this.lbl_sales_tax.AutoSize = true;
            this.lbl_sales_tax.Location = new System.Drawing.Point(514, 178);
            this.lbl_sales_tax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sales_tax.Name = "lbl_sales_tax";
            this.lbl_sales_tax.Size = new System.Drawing.Size(117, 25);
            this.lbl_sales_tax.TabIndex = 3;
            this.lbl_sales_tax.Text = "Sales Tax:";
            // 
            // txt_bottle_dep
            // 
            this.txt_bottle_dep.Location = new System.Drawing.Point(657, 259);
            this.txt_bottle_dep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_bottle_dep.Name = "txt_bottle_dep";
            this.txt_bottle_dep.Size = new System.Drawing.Size(143, 30);
            this.txt_bottle_dep.TabIndex = 2;
            // 
            // txt_local_tax
            // 
            this.txt_local_tax.Location = new System.Drawing.Point(657, 216);
            this.txt_local_tax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_local_tax.Name = "txt_local_tax";
            this.txt_local_tax.Size = new System.Drawing.Size(143, 30);
            this.txt_local_tax.TabIndex = 1;
            // 
            // txt_sales_tax
            // 
            this.txt_sales_tax.Location = new System.Drawing.Point(657, 172);
            this.txt_sales_tax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_sales_tax.Name = "txt_sales_tax";
            this.txt_sales_tax.Size = new System.Drawing.Size(143, 30);
            this.txt_sales_tax.TabIndex = 0;
            // 
            // btn_commit
            // 
            this.btn_commit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_commit.AutoSize = true;
            this.btn_commit.Location = new System.Drawing.Point(1185, 574);
            this.btn_commit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_commit.Name = "btn_commit";
            this.btn_commit.Size = new System.Drawing.Size(143, 41);
            this.btn_commit.TabIndex = 4;
            this.btn_commit.Text = "Commit";
            this.btn_commit.UseVisualStyleBackColor = true;
            this.btn_commit.Click += new System.EventHandler(this.btn_commit_Click);
            // 
            // panReceipt1
            // 
            this.panReceipt1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panReceipt1.Location = new System.Drawing.Point(3, 2);
            this.panReceipt1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panReceipt1.Name = "panReceipt1";
            this.panReceipt1.Size = new System.Drawing.Size(1305, 498);
            this.panReceipt1.TabIndex = 0;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 628);
            this.Controls.Add(this.btn_commit);
            this.Controls.Add(this.tab_receipt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSetting";
            this.Load += new System.EventHandler(this.FrmSetting_Load);
            this.tab_receipt.ResumeLayout(false);
            this.tab_Hardware.ResumeLayout(false);
            this.tab_Types.ResumeLayout(false);
            this.tab_Appearance.ResumeLayout(false);
            this.tab_Reports.ResumeLayout(false);
            this.tab_Reciept.ResumeLayout(false);
            this.tab_tax.ResumeLayout(false);
            this.tab_tax.PerformLayout();
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
        private System.Windows.Forms.TextBox txt_sales_tax;
        private System.Windows.Forms.Button btn_update_tax;
        private System.Windows.Forms.Label txt_tax_list;
        private System.Windows.Forms.ListBox lst_tax_list;
        private System.Windows.Forms.Label lbl_btl_deposit;
        private System.Windows.Forms.Label lbl_local_tax;
        private System.Windows.Forms.Label lbl_sales_tax;
        private System.Windows.Forms.TextBox txt_bottle_dep;
        private System.Windows.Forms.TextBox txt_local_tax;
        private Settings_Panels.PanHardware panHardware1;
        private Settings_Panels.PanReports panReports1;
        private Settings_Panels.PanTypes panTypes1;
        private Settings_Panels.PanAppearance panAppearance1;
        private Settings_Panels.PanReceipt panReceipt1;
    }
}