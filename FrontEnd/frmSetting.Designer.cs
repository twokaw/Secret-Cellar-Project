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
            this.tab_receipt = new System.Windows.Forms.TabControl();
            this.tabHardware = new System.Windows.Forms.TabPage();
            this.TabTypes = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstTypes = new System.Windows.Forms.ListBox();
            this.tab_General = new System.Windows.Forms.TabPage();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.btn_change_image = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_row_color = new System.Windows.Forms.Button();
            this.btn_font_settings = new System.Windows.Forms.Button();
            this.btn_panel_color = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_rec_font = new System.Windows.Forms.Button();
            this.btn_foot = new System.Windows.Forms.Button();
            this.btn_header = new System.Windows.Forms.Button();
            this.btn_commit = new System.Windows.Forms.Button();
            this.tab_receipt.SuspendLayout();
            this.TabTypes.SuspendLayout();
            this.tab_General.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_receipt
            // 
            this.tab_receipt.Controls.Add(this.tabHardware);
            this.tab_receipt.Controls.Add(this.TabTypes);
            this.tab_receipt.Controls.Add(this.tab_General);
            this.tab_receipt.Controls.Add(this.tabPage2);
            this.tab_receipt.Controls.Add(this.tabPage1);
            this.tab_receipt.Location = new System.Drawing.Point(12, 12);
            this.tab_receipt.Name = "tab_receipt";
            this.tab_receipt.SelectedIndex = 0;
            this.tab_receipt.Size = new System.Drawing.Size(777, 421);
            this.tab_receipt.TabIndex = 0;
            // 
            // tabHardware
            // 
            this.tabHardware.Location = new System.Drawing.Point(4, 22);
            this.tabHardware.Name = "tabHardware";
            this.tabHardware.Padding = new System.Windows.Forms.Padding(3);
            this.tabHardware.Size = new System.Drawing.Size(769, 395);
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
            this.TabTypes.Location = new System.Drawing.Point(4, 22);
            this.TabTypes.Name = "TabTypes";
            this.TabTypes.Padding = new System.Windows.Forms.Padding(3);
            this.TabTypes.Size = new System.Drawing.Size(769, 395);
            this.TabTypes.TabIndex = 1;
            this.TabTypes.Text = "Types";
            this.TabTypes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tax Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(204, 249);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = " ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory Type";
            // 
            // lstTypes
            // 
            this.lstTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstTypes.FormattingEnabled = true;
            this.lstTypes.Location = new System.Drawing.Point(19, 34);
            this.lstTypes.Name = "lstTypes";
            this.lstTypes.Size = new System.Drawing.Size(103, 342);
            this.lstTypes.TabIndex = 0;
            // 
            // tab_General
            // 
            this.tab_General.Controls.Add(this.pic_logo);
            this.tab_General.Controls.Add(this.btn_change_image);
            this.tab_General.Controls.Add(this.btn_reset);
            this.tab_General.Controls.Add(this.btn_row_color);
            this.tab_General.Controls.Add(this.btn_font_settings);
            this.tab_General.Controls.Add(this.btn_panel_color);
            this.tab_General.Controls.Add(this.btn_color);
            this.tab_General.Location = new System.Drawing.Point(4, 22);
            this.tab_General.Margin = new System.Windows.Forms.Padding(1);
            this.tab_General.Name = "tab_General";
            this.tab_General.Size = new System.Drawing.Size(769, 395);
            this.tab_General.TabIndex = 2;
            this.tab_General.Text = "General";
            this.tab_General.UseVisualStyleBackColor = true;
            this.tab_General.Click += new System.EventHandler(this.tab_General_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.Location = new System.Drawing.Point(2, 25);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(2);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(293, 150);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
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
            this.btn_change_image.Location = new System.Drawing.Point(70, 198);
            this.btn_change_image.Name = "btn_change_image";
            this.btn_change_image.Size = new System.Drawing.Size(174, 23);
            this.btn_change_image.TabIndex = 5;
            this.btn_change_image.Text = "Change Image";
            this.btn_change_image.UseVisualStyleBackColor = true;
            this.btn_change_image.Click += new System.EventHandler(this.btn_change_image_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reset.AutoSize = true;
            this.btn_reset.Location = new System.Drawing.Point(300, 332);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(174, 23);
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
            this.btn_row_color.Location = new System.Drawing.Point(300, 258);
            this.btn_row_color.Name = "btn_row_color";
            this.btn_row_color.Size = new System.Drawing.Size(174, 23);
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
            this.btn_font_settings.Location = new System.Drawing.Point(300, 218);
            this.btn_font_settings.Name = "btn_font_settings";
            this.btn_font_settings.Size = new System.Drawing.Size(174, 23);
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
            this.btn_panel_color.Location = new System.Drawing.Point(300, 179);
            this.btn_panel_color.Name = "btn_panel_color";
            this.btn_panel_color.Size = new System.Drawing.Size(174, 23);
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
            this.btn_color.Location = new System.Drawing.Point(300, 139);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(174, 23);
            this.btn_color.TabIndex = 0;
            this.btn_color.Text = "Color Settings";
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(769, 395);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Reports";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_rec_font);
            this.tabPage1.Controls.Add(this.btn_foot);
            this.tabPage1.Controls.Add(this.btn_header);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(769, 395);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Receipt";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_rec_font
            // 
            this.btn_rec_font.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rec_font.AutoSize = true;
            this.btn_rec_font.Location = new System.Drawing.Point(300, 205);
            this.btn_rec_font.Name = "btn_rec_font";
            this.btn_rec_font.Size = new System.Drawing.Size(174, 23);
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
            this.btn_foot.Location = new System.Drawing.Point(300, 162);
            this.btn_foot.Name = "btn_foot";
            this.btn_foot.Size = new System.Drawing.Size(174, 23);
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
            this.btn_header.Location = new System.Drawing.Point(300, 123);
            this.btn_header.Name = "btn_header";
            this.btn_header.Size = new System.Drawing.Size(174, 23);
            this.btn_header.TabIndex = 6;
            this.btn_header.Text = "Change Receipt Header";
            this.btn_header.UseVisualStyleBackColor = true;
            // 
            // btn_commit
            // 
            this.btn_commit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_commit.AutoSize = true;
            this.btn_commit.Location = new System.Drawing.Point(315, 451);
            this.btn_commit.Name = "btn_commit";
            this.btn_commit.Size = new System.Drawing.Size(174, 23);
            this.btn_commit.TabIndex = 4;
            this.btn_commit.Text = "Commit";
            this.btn_commit.UseVisualStyleBackColor = true;
            this.btn_commit.Click += new System.EventHandler(this.btn_commit_Click);
            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 510);
            this.Controls.Add(this.btn_commit);
            this.Controls.Add(this.tab_receipt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSetting";
            this.Load += new System.EventHandler(this.FrmSetting_Load);
            this.tab_receipt.ResumeLayout(false);
            this.TabTypes.ResumeLayout(false);
            this.TabTypes.PerformLayout();
            this.tab_General.ResumeLayout(false);
            this.tab_General.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_receipt;
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
        private System.Windows.Forms.Button btn_row_color;
        private System.Windows.Forms.Button btn_commit;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_change_image;
        private System.Windows.Forms.Button btn_rec_font;
        private System.Windows.Forms.Button btn_foot;
        private System.Windows.Forms.Button btn_header;
        private System.Windows.Forms.PictureBox pic_logo;
    }
}