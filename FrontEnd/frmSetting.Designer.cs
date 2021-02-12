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
            this.tab_Types = new System.Windows.Forms.TabPage();
            this.tab_Appearance = new System.Windows.Forms.TabPage();
            this.btn_change_logo = new System.Windows.Forms.Button();
            this.listbox_logos = new System.Windows.Forms.ListBox();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.btn_change_image = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_row_color = new System.Windows.Forms.Button();
            this.btn_font_settings = new System.Windows.Forms.Button();
            this.btn_panel_color = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.tab_Reports = new System.Windows.Forms.TabPage();
            this.panReports1 = new SecretCellar.Settings_Panels.PanReports();
            this.tab_Reciept = new System.Windows.Forms.TabPage();
            this.btn_rec_font = new System.Windows.Forms.Button();
            this.btn_foot = new System.Windows.Forms.Button();
            this.btn_header = new System.Windows.Forms.Button();
            this.btn_commit = new System.Windows.Forms.Button();
            this.panHardware1 = new SecretCellar.Settings_Panels.PanHardware();
            this.tab_receipt.SuspendLayout();
            this.tab_Hardware.SuspendLayout();
            this.tab_Appearance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.tab_Reports.SuspendLayout();
            this.tab_Reciept.SuspendLayout();
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
            this.tab_receipt.Location = new System.Drawing.Point(26, 23);
            this.tab_receipt.Margin = new System.Windows.Forms.Padding(6);
            this.tab_receipt.Name = "tab_receipt";
            this.tab_receipt.SelectedIndex = 0;
            this.tab_receipt.Size = new System.Drawing.Size(1215, 468);
            this.tab_receipt.TabIndex = 0;
            // 
            // tab_Hardware
            // 
            this.tab_Hardware.Controls.Add(this.panHardware1);
            this.tab_Hardware.Location = new System.Drawing.Point(4, 34);
            this.tab_Hardware.Margin = new System.Windows.Forms.Padding(6);
            this.tab_Hardware.Name = "tab_Hardware";
            this.tab_Hardware.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab_Hardware.Size = new System.Drawing.Size(1207, 430);
            this.tab_Hardware.TabIndex = 0;
            this.tab_Hardware.Text = "Hardware";
            this.tab_Hardware.UseVisualStyleBackColor = true;
            // 
            // tab_Types
            // 
            this.tab_Types.Location = new System.Drawing.Point(4, 34);
            this.tab_Types.Margin = new System.Windows.Forms.Padding(6);
            this.tab_Types.Name = "tab_Types";
            this.tab_Types.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab_Types.Size = new System.Drawing.Size(1207, 430);
            this.tab_Types.TabIndex = 1;
            this.tab_Types.Text = "Types";
            this.tab_Types.UseVisualStyleBackColor = true;
            this.tab_Types.Click += new System.EventHandler(this.TabTypes_Click);
            // 
            // tab_Appearance
            // 
            this.tab_Appearance.Controls.Add(this.btn_change_logo);
            this.tab_Appearance.Controls.Add(this.listbox_logos);
            this.tab_Appearance.Controls.Add(this.pic_logo);
            this.tab_Appearance.Controls.Add(this.btn_change_image);
            this.tab_Appearance.Controls.Add(this.btn_reset);
            this.tab_Appearance.Controls.Add(this.btn_row_color);
            this.tab_Appearance.Controls.Add(this.btn_font_settings);
            this.tab_Appearance.Controls.Add(this.btn_panel_color);
            this.tab_Appearance.Controls.Add(this.btn_color);
            this.tab_Appearance.Location = new System.Drawing.Point(4, 34);
            this.tab_Appearance.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.tab_Appearance.Name = "tab_Appearance";
            this.tab_Appearance.Size = new System.Drawing.Size(1207, 430);
            this.tab_Appearance.TabIndex = 2;
            this.tab_Appearance.Text = "Appearance";
            this.tab_Appearance.UseVisualStyleBackColor = true;
            this.tab_Appearance.Click += new System.EventHandler(this.tab_General_Click);
            // 
            // btn_change_logo
            // 
            this.btn_change_logo.Location = new System.Drawing.Point(482, 241);
            this.btn_change_logo.Name = "btn_change_logo";
            this.btn_change_logo.Size = new System.Drawing.Size(209, 38);
            this.btn_change_logo.TabIndex = 8;
            this.btn_change_logo.Text = "Change Logo";
            this.btn_change_logo.UseVisualStyleBackColor = true;
            this.btn_change_logo.Click += new System.EventHandler(this.btn_change_logo_Click);
            // 
            // listbox_logos
            // 
            this.listbox_logos.FormattingEnabled = true;
            this.listbox_logos.ItemHeight = 25;
            this.listbox_logos.Location = new System.Drawing.Point(459, 139);
            this.listbox_logos.Name = "listbox_logos";
            this.listbox_logos.Size = new System.Drawing.Size(261, 79);
            this.listbox_logos.TabIndex = 7;
            this.listbox_logos.SelectedIndexChanged += new System.EventHandler(this.listbox_logos_SelectedIndexChanged);
            // 
            // pic_logo
            // 
            this.pic_logo.Location = new System.Drawing.Point(12, 139);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(441, 184);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 6;
            this.pic_logo.TabStop = false;
            this.pic_logo.Click += new System.EventHandler(this.pic_logo_Click);
            // 
            // btn_change_image
            // 
            this.btn_change_image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_change_image.AutoSize = true;
            this.btn_change_image.Location = new System.Drawing.Point(114, 352);
            this.btn_change_image.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_change_image.Name = "btn_change_image";
            this.btn_change_image.Size = new System.Drawing.Size(261, 47);
            this.btn_change_image.TabIndex = 5;
            this.btn_change_image.Text = "Import Image";
            this.btn_change_image.UseVisualStyleBackColor = true;
            this.btn_change_image.Click += new System.EventHandler(this.btn_change_image_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reset.AutoSize = true;
            this.btn_reset.Location = new System.Drawing.Point(766, 356);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(261, 47);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "Default Settings";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_row_color
            // 
            this.btn_row_color.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_row_color.AutoSize = true;
            this.btn_row_color.Location = new System.Drawing.Point(766, 266);
            this.btn_row_color.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_row_color.Name = "btn_row_color";
            this.btn_row_color.Size = new System.Drawing.Size(261, 47);
            this.btn_row_color.TabIndex = 3;
            this.btn_row_color.Text = "Row Color Settings";
            this.btn_row_color.UseVisualStyleBackColor = true;
            this.btn_row_color.Click += new System.EventHandler(this.btn_row_color_Click);
            // 
            // btn_font_settings
            // 
            this.btn_font_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_font_settings.AutoSize = true;
            this.btn_font_settings.Location = new System.Drawing.Point(766, 216);
            this.btn_font_settings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_font_settings.Name = "btn_font_settings";
            this.btn_font_settings.Size = new System.Drawing.Size(261, 47);
            this.btn_font_settings.TabIndex = 2;
            this.btn_font_settings.Text = "Font Settings";
            this.btn_font_settings.UseVisualStyleBackColor = true;
            this.btn_font_settings.Click += new System.EventHandler(this.btn_font_settings_Click);
            // 
            // btn_panel_color
            // 
            this.btn_panel_color.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_panel_color.AutoSize = true;
            this.btn_panel_color.Location = new System.Drawing.Point(766, 167);
            this.btn_panel_color.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_panel_color.Name = "btn_panel_color";
            this.btn_panel_color.Size = new System.Drawing.Size(261, 47);
            this.btn_panel_color.TabIndex = 1;
            this.btn_panel_color.Text = "Panel Color Settings";
            this.btn_panel_color.UseVisualStyleBackColor = true;
            this.btn_panel_color.Click += new System.EventHandler(this.btn_panel_color_Click);
            // 
            // btn_color
            // 
            this.btn_color.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_color.AutoSize = true;
            this.btn_color.Location = new System.Drawing.Point(766, 119);
            this.btn_color.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(261, 47);
            this.btn_color.TabIndex = 0;
            this.btn_color.Text = "Color Settings";
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // tab_Reports
            // 
            this.tab_Reports.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tab_Reports.Controls.Add(this.panReports1);
            this.tab_Reports.Location = new System.Drawing.Point(4, 34);
            this.tab_Reports.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.tab_Reports.Name = "tab_Reports";
            this.tab_Reports.Size = new System.Drawing.Size(1207, 430);
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
            this.panReports1.Size = new System.Drawing.Size(1203, 426);
            this.panReports1.TabIndex = 0;
            // 
            // tab_Reciept
            // 
            this.tab_Reciept.Controls.Add(this.btn_rec_font);
            this.tab_Reciept.Controls.Add(this.btn_foot);
            this.tab_Reciept.Controls.Add(this.btn_header);
            this.tab_Reciept.Location = new System.Drawing.Point(4, 34);
            this.tab_Reciept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_Reciept.Name = "tab_Reciept";
            this.tab_Reciept.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_Reciept.Size = new System.Drawing.Size(1207, 430);
            this.tab_Reciept.TabIndex = 4;
            this.tab_Reciept.Text = "Receipt";
            this.tab_Reciept.UseVisualStyleBackColor = true;
            // 
            // btn_rec_font
            // 
            this.btn_rec_font.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rec_font.AutoSize = true;
            this.btn_rec_font.Location = new System.Drawing.Point(451, 252);
            this.btn_rec_font.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_rec_font.Name = "btn_rec_font";
            this.btn_rec_font.Size = new System.Drawing.Size(261, 47);
            this.btn_rec_font.TabIndex = 8;
            this.btn_rec_font.Text = "Change Receipt Font";
            this.btn_rec_font.UseVisualStyleBackColor = true;
            // 
            // btn_foot
            // 
            this.btn_foot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_foot.AutoSize = true;
            this.btn_foot.Location = new System.Drawing.Point(451, 198);
            this.btn_foot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_foot.Name = "btn_foot";
            this.btn_foot.Size = new System.Drawing.Size(267, 47);
            this.btn_foot.TabIndex = 7;
            this.btn_foot.Text = "Change Reciept Footer";
            this.btn_foot.UseVisualStyleBackColor = true;
            // 
            // btn_header
            // 
            this.btn_header.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_header.AutoSize = true;
            this.btn_header.Location = new System.Drawing.Point(451, 152);
            this.btn_header.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_header.Name = "btn_header";
            this.btn_header.Size = new System.Drawing.Size(276, 47);
            this.btn_header.TabIndex = 6;
            this.btn_header.Text = "Change Receipt Header";
            this.btn_header.UseVisualStyleBackColor = true;
            // 
            // btn_commit
            // 
            this.btn_commit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_commit.AutoSize = true;
            this.btn_commit.Location = new System.Drawing.Point(1064, 502);
            this.btn_commit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_commit.Name = "btn_commit";
            this.btn_commit.Size = new System.Drawing.Size(177, 50);
            this.btn_commit.TabIndex = 4;
            this.btn_commit.Text = "Commit";
            this.btn_commit.UseVisualStyleBackColor = true;
            this.btn_commit.Click += new System.EventHandler(this.btn_commit_Click);
            // 
            // panHardware1
            // 
            this.panHardware1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panHardware1.Location = new System.Drawing.Point(4, 5);
            this.panHardware1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panHardware1.Name = "panHardware1";
            this.panHardware1.Size = new System.Drawing.Size(1199, 420);
            this.panHardware1.TabIndex = 0;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 566);
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
            this.tab_Appearance.ResumeLayout(false);
            this.tab_Appearance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.tab_Reports.ResumeLayout(false);
            this.tab_Reciept.ResumeLayout(false);
            this.tab_Reciept.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_receipt;
        private System.Windows.Forms.TabPage tab_Hardware;
        private System.Windows.Forms.TabPage tab_Types;
        private System.Windows.Forms.TabPage tab_Appearance;
        private System.Windows.Forms.TabPage tab_Reports;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button btn_font_settings;
        private System.Windows.Forms.Button btn_panel_color;
        private System.Windows.Forms.Button btn_row_color;
        private System.Windows.Forms.Button btn_commit;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TabPage tab_Reciept;
        private System.Windows.Forms.Button btn_change_image;
        private System.Windows.Forms.Button btn_rec_font;
        private System.Windows.Forms.Button btn_foot;
        private System.Windows.Forms.Button btn_header;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.ListBox listbox_logos;
        private System.Windows.Forms.Button btn_change_logo;
        private Settings_Panels.PanReports panReports1;
        private Settings_Panels.PanHardware panHardware1;
    }
}