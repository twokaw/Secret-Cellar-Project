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
            this.tab_General = new System.Windows.Forms.TabPage();
            this.btn_color = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TabSettings.SuspendLayout();
            this.TabTypes.SuspendLayout();
            this.tab_General.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabSettings
            // 
            this.TabSettings.Controls.Add(this.tabHardware);
            this.TabSettings.Controls.Add(this.TabTypes);
            this.TabSettings.Controls.Add(this.tab_General);
            this.TabSettings.Controls.Add(this.tabPage2);
            this.TabSettings.Location = new System.Drawing.Point(32, 29);
            this.TabSettings.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TabSettings.Name = "TabSettings";
            this.TabSettings.SelectedIndex = 0;
            this.TabSettings.Size = new System.Drawing.Size(2069, 1006);
            this.TabSettings.TabIndex = 0;
            // 
            // tabHardware
            // 
            this.tabHardware.Location = new System.Drawing.Point(10, 48);
            this.tabHardware.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabHardware.Name = "tabHardware";
            this.tabHardware.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabHardware.Size = new System.Drawing.Size(2049, 948);
            this.tabHardware.TabIndex = 0;
            this.tabHardware.Text = "Hardware";
            this.tabHardware.UseVisualStyleBackColor = true;
            // 
            // TabTypes
            // 
            this.TabTypes.Controls.Add(this.label3);
            this.TabTypes.Controls.Add(this.comboBox1);
            this.TabTypes.Controls.Add(this.label2);
            this.TabTypes.Controls.Add(this.label1);
            this.TabTypes.Controls.Add(this.lstTypes);
            this.TabTypes.Location = new System.Drawing.Point(10, 48);
            this.TabTypes.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TabTypes.Name = "TabTypes";
            this.TabTypes.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TabTypes.Size = new System.Drawing.Size(2049, 948);
            this.TabTypes.TabIndex = 1;
            this.TabTypes.Text = "Types";
            this.TabTypes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(552, 541);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tax Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(544, 594);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(396, 39);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = " ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
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
            this.lstTypes.Location = new System.Drawing.Point(51, 79);
            this.lstTypes.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lstTypes.Name = "lstTypes";
            this.lstTypes.Size = new System.Drawing.Size(268, 810);
            this.lstTypes.TabIndex = 0;
            // 
            // tab_General
            // 
            this.tab_General.Controls.Add(this.btn_color);
            this.tab_General.Location = new System.Drawing.Point(10, 48);
            this.tab_General.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_General.Name = "tab_General";
            this.tab_General.Size = new System.Drawing.Size(2049, 948);
            this.tab_General.TabIndex = 2;
            this.tab_General.Text = "General";
            this.tab_General.UseVisualStyleBackColor = true;
            // 
            // btn_color
            // 
            this.btn_color.Location = new System.Drawing.Point(627, 222);
            this.btn_color.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(464, 55);
            this.btn_color.TabIndex = 0;
            this.btn_color.Text = "Color Settings";
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(2049, 948);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Reports";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1925, 1061);
            this.Controls.Add(this.TabSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FrmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSetting";
            this.Load += new System.EventHandler(this.FrmSetting_Load);
            this.TabSettings.ResumeLayout(false);
            this.TabTypes.ResumeLayout(false);
            this.TabTypes.PerformLayout();
            this.tab_General.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tab_General;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_color;
    }
}