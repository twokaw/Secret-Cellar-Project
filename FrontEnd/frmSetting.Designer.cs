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
            this.btn_font_settings = new System.Windows.Forms.Button();
            this.btn_panel_color = new System.Windows.Forms.Button();
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
            this.TabSettings.Location = new System.Drawing.Point(16, 16);
            this.TabSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabSettings.Name = "TabSettings";
            this.TabSettings.SelectedIndex = 0;
            this.TabSettings.Size = new System.Drawing.Size(1035, 551);
            this.TabSettings.TabIndex = 0;
            // 
            // tabHardware
            // 
            this.tabHardware.Location = new System.Drawing.Point(4, 23);
            this.tabHardware.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabHardware.Name = "tabHardware";
            this.tabHardware.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabHardware.Size = new System.Drawing.Size(1027, 524);
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
            this.TabTypes.Location = new System.Drawing.Point(4, 23);
            this.TabTypes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabTypes.Name = "TabTypes";
            this.TabTypes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabTypes.Size = new System.Drawing.Size(1027, 524);
            this.TabTypes.TabIndex = 1;
            this.TabTypes.Text = "Types";
            this.TabTypes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 296);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tax Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(272, 325);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 25);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = " ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory Type";
            // 
            // lstTypes
            // 
            this.lstTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstTypes.FormattingEnabled = true;
            this.lstTypes.ItemHeight = 17;
            this.lstTypes.Location = new System.Drawing.Point(25, 44);
            this.lstTypes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstTypes.Name = "lstTypes";
            this.lstTypes.Size = new System.Drawing.Size(136, 446);
            this.lstTypes.TabIndex = 0;
            // 
            // tab_General
            // 
            this.tab_General.Controls.Add(this.btn_font_settings);
            this.tab_General.Controls.Add(this.btn_panel_color);
            this.tab_General.Controls.Add(this.btn_color);
            this.tab_General.Location = new System.Drawing.Point(4, 26);
            this.tab_General.Margin = new System.Windows.Forms.Padding(1);
            this.tab_General.Name = "tab_General";
            this.tab_General.Size = new System.Drawing.Size(1027, 521);
            this.tab_General.TabIndex = 2;
            this.tab_General.Text = "General";
            this.tab_General.UseVisualStyleBackColor = true;
            this.tab_General.Click += new System.EventHandler(this.tab_General_Click);
            // 
            // btn_font_settings
            // 
            this.btn_font_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_font_settings.Location = new System.Drawing.Point(400, 285);
            this.btn_font_settings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_font_settings.Name = "btn_font_settings";
            this.btn_font_settings.Size = new System.Drawing.Size(232, 27);
            this.btn_font_settings.TabIndex = 2;
            this.btn_font_settings.Text = "Font Settings";
            this.btn_font_settings.UseVisualStyleBackColor = true;
            // btn_panel_color
            // 
            this.btn_panel_color.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_panel_color.Location = new System.Drawing.Point(400, 234);
            this.btn_panel_color.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_panel_color.Name = "btn_panel_color";
            this.btn_panel_color.Size = new System.Drawing.Size(232, 27);
            this.btn_panel_color.TabIndex = 1;
            this.btn_panel_color.Text = "Panel Color Settings";
            this.btn_panel_color.UseVisualStyleBackColor = true;
            // btn_color
            // 
            this.btn_color.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_color.Location = new System.Drawing.Point(400, 181);
            this.btn_color.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(232, 27);
            this.btn_color.TabIndex = 0;
            this.btn_color.Text = "Color Settings";
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1027, 524);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Reports";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 668);
            this.Controls.Add(this.TabSettings);
            this.Font = new System.Drawing.Font("Arial", 11F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btn_font_settings;
        private System.Windows.Forms.Button btn_panel_color;
    }
}