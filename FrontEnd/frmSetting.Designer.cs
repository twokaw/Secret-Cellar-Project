namespace SecretCellar
{
    partial class FrmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetting));
            this.TabSettings = new System.Windows.Forms.TabControl();
            this.tabHardware = new System.Windows.Forms.TabPage();
            this.TabTypes = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstTypes = new System.Windows.Forms.ListBox();
            this.caseDiscount = new System.Windows.Forms.CheckBox();
            this.TabSettings.SuspendLayout();
            this.TabTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabSettings
            // 
            this.TabSettings.Controls.Add(this.tabHardware);
            this.TabSettings.Controls.Add(this.TabTypes);
            this.TabSettings.Location = new System.Drawing.Point(32, 28);
            this.TabSettings.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TabSettings.Name = "TabSettings";
            this.TabSettings.SelectedIndex = 0;
            this.TabSettings.Size = new System.Drawing.Size(2069, 1006);
            this.TabSettings.TabIndex = 0;
            // 
            // tabHardware
            // 
            this.tabHardware.Location = new System.Drawing.Point(10, 48);
            this.tabHardware.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.tabHardware.Name = "tabHardware";
            this.tabHardware.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.tabHardware.Size = new System.Drawing.Size(2049, 948);
            this.tabHardware.TabIndex = 0;
            this.tabHardware.Text = "Hardware";
            this.tabHardware.UseVisualStyleBackColor = true;
            // 
            // TabTypes
            // 
            this.TabTypes.Controls.Add(this.caseDiscount);
            this.TabTypes.Controls.Add(this.label3);
            this.TabTypes.Controls.Add(this.comboBox1);
            this.TabTypes.Controls.Add(this.label2);
            this.TabTypes.Controls.Add(this.label1);
            this.TabTypes.Controls.Add(this.lstTypes);
            this.TabTypes.Location = new System.Drawing.Point(10, 48);
            this.TabTypes.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TabTypes.Name = "TabTypes";
            this.TabTypes.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TabTypes.Size = new System.Drawing.Size(2049, 948);
            this.TabTypes.TabIndex = 1;
            this.TabTypes.Text = "Types";
            this.TabTypes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(551, 541);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tax Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(544, 594);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(395, 39);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = " ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory Type";
            // 
            // lstTypes
            // 
            this.lstTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstTypes.FormattingEnabled = true;
            this.lstTypes.ItemHeight = 31;
            this.lstTypes.Location = new System.Drawing.Point(50, 79);
            this.lstTypes.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.lstTypes.Name = "lstTypes";
            this.lstTypes.Size = new System.Drawing.Size(267, 810);
            this.lstTypes.TabIndex = 0;
            // 
            // caseDiscount
            // 
            this.caseDiscount.AutoSize = true;
            this.caseDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caseDiscount.Location = new System.Drawing.Point(544, 452);
            this.caseDiscount.Name = "caseDiscount";
            this.caseDiscount.Size = new System.Drawing.Size(250, 36);
            this.caseDiscount.TabIndex = 5;
            this.caseDiscount.Text = "Case Discount";
            this.caseDiscount.UseVisualStyleBackColor = true;
            this.caseDiscount.CheckedChanged += new System.EventHandler(this.CaseDiscount_CheckedChanged);
            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2133, 1073);
            this.Controls.Add(this.TabSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "FrmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSetting";
            this.Load += new System.EventHandler(this.FrmSetting_Load);
            this.TabSettings.ResumeLayout(false);
            this.TabTypes.ResumeLayout(false);
            this.TabTypes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabSettings;
        private System.Windows.Forms.TabPage tabHardware;
        private System.Windows.Forms.TabPage TabTypes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstTypes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox caseDiscount;
    }
}