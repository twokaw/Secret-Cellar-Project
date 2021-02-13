﻿namespace SecretCellar
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
            this.tabHardware = new System.Windows.Forms.TabPage();
            this.TabTypes = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstTypes = new System.Windows.Forms.ListBox();
            this.tab_General = new System.Windows.Forms.TabPage();
            this.btn_change_logo = new System.Windows.Forms.Button();
            this.listbox_logos = new System.Windows.Forms.ListBox();
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
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtSalesTotals = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSalesInvType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSalesVendor = new System.Windows.Forms.TextBox();
            this.btn_Run = new System.Windows.Forms.Button();
            this.tab_receipt.SuspendLayout();
            this.TabTypes.SuspendLayout();
            this.tab_General.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.tab_receipt.Location = new System.Drawing.Point(26, 23);
            this.tab_receipt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tab_receipt.Name = "tab_receipt";
            this.tab_receipt.SelectedIndex = 0;
            this.tab_receipt.Size = new System.Drawing.Size(1166, 518);
            this.tab_receipt.TabIndex = 0;
            // 
            // tabHardware
            // 
            this.tabHardware.Location = new System.Drawing.Point(4, 34);
            this.tabHardware.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabHardware.Name = "tabHardware";
            this.tabHardware.Padding = new System.Windows.Forms.Padding(4);
            this.tabHardware.Size = new System.Drawing.Size(1158, 489);
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
            this.TabTypes.Location = new System.Drawing.Point(4, 34);
            this.TabTypes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TabTypes.Name = "TabTypes";
            this.TabTypes.Padding = new System.Windows.Forms.Padding(4);
            this.TabTypes.Size = new System.Drawing.Size(1158, 489);
            this.TabTypes.TabIndex = 1;
            this.TabTypes.Text = "Types";
            this.TabTypes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 434);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tax Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(442, 478);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(322, 33);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.cbx_tax_type_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = " ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory Type";
            // 
            // lstTypes
            // 
            this.lstTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstTypes.FormattingEnabled = true;
            this.lstTypes.ItemHeight = 25;
            this.lstTypes.Location = new System.Drawing.Point(40, 66);
            this.lstTypes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstTypes.Name = "lstTypes";
            this.lstTypes.Size = new System.Drawing.Size(218, 654);
            this.lstTypes.TabIndex = 0;
            this.lstTypes.SelectedIndexChanged += new System.EventHandler(this.lstTypes_SelectedIndexChanged);
            // 
            // tab_General
            // 
            this.tab_General.Controls.Add(this.btn_change_logo);
            this.tab_General.Controls.Add(this.listbox_logos);
            this.tab_General.Controls.Add(this.pic_logo);
            this.tab_General.Controls.Add(this.btn_change_image);
            this.tab_General.Controls.Add(this.btn_reset);
            this.tab_General.Controls.Add(this.btn_row_color);
            this.tab_General.Controls.Add(this.btn_font_settings);
            this.tab_General.Controls.Add(this.btn_panel_color);
            this.tab_General.Controls.Add(this.btn_color);
            this.tab_General.Location = new System.Drawing.Point(4, 25);
            this.tab_General.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tab_General.Name = "tab_General";
            this.tab_General.Size = new System.Drawing.Size(1158, 489);
            this.tab_General.TabIndex = 2;
            this.tab_General.Text = "General";
            this.tab_General.UseVisualStyleBackColor = true;
            this.tab_General.Click += new System.EventHandler(this.tab_General_Click);
            // 
            // btn_change_logo
            // 
            this.btn_change_logo.Location = new System.Drawing.Point(483, 241);
            this.btn_change_logo.Name = "btn_change_logo";
            this.btn_change_logo.Size = new System.Drawing.Size(210, 29);
            this.btn_change_logo.TabIndex = 8;
            this.btn_change_logo.Text = "Change Logo";
            this.btn_change_logo.UseVisualStyleBackColor = true;
            this.btn_change_logo.Click += new System.EventHandler(this.btn_change_logo_Click);
            // 
            // listbox_logos
            // 
            this.listbox_logos.FormattingEnabled = true;
            this.listbox_logos.ItemHeight = 16;
            this.listbox_logos.Location = new System.Drawing.Point(459, 139);
            this.listbox_logos.Name = "listbox_logos";
            this.listbox_logos.Size = new System.Drawing.Size(261, 84);
            this.listbox_logos.TabIndex = 7;
            this.listbox_logos.SelectedIndexChanged += new System.EventHandler(this.listbox_logos_SelectedIndexChanged);
            // 
            // pic_logo
            // 
            this.pic_logo.Location = new System.Drawing.Point(12, 139);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(440, 185);
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
            this.btn_change_image.Margin = new System.Windows.Forms.Padding(4);
            this.btn_change_image.Name = "btn_change_image";
            this.btn_change_image.Size = new System.Drawing.Size(261, 28);
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
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(261, 28);
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
            this.btn_row_color.Location = new System.Drawing.Point(766, 265);
            this.btn_row_color.Margin = new System.Windows.Forms.Padding(4);
            this.btn_row_color.Name = "btn_row_color";
            this.btn_row_color.Size = new System.Drawing.Size(261, 28);
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
            this.btn_font_settings.Location = new System.Drawing.Point(766, 215);
            this.btn_font_settings.Margin = new System.Windows.Forms.Padding(4);
            this.btn_font_settings.Name = "btn_font_settings";
            this.btn_font_settings.Size = new System.Drawing.Size(261, 28);
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
            this.btn_panel_color.Margin = new System.Windows.Forms.Padding(4);
            this.btn_panel_color.Name = "btn_panel_color";
            this.btn_panel_color.Size = new System.Drawing.Size(261, 28);
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
            this.btn_color.Location = new System.Drawing.Point(766, 118);
            this.btn_color.Margin = new System.Windows.Forms.Padding(4);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(261, 28);
            this.btn_color.TabIndex = 0;
            this.btn_color.Text = "Color Settings";
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_Run);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.TxtSalesVendor);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.TxtSalesInvType);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.TxtSalesTotals);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dtp_end);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dtp_start);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1675, 771);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Reports";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_rec_font);
            this.tabPage1.Controls.Add(this.btn_foot);
            this.tabPage1.Controls.Add(this.btn_header);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1158, 489);
            this.tabPage1.Text = "Receipt";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_rec_font
            // 
            this.btn_rec_font.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rec_font.AutoSize = true;
            this.btn_rec_font.Location = new System.Drawing.Point(450, 252);
            this.btn_rec_font.Margin = new System.Windows.Forms.Padding(4);
            this.btn_rec_font.Name = "btn_rec_font";
            this.btn_rec_font.Size = new System.Drawing.Size(261, 28);
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
            this.btn_foot.Location = new System.Drawing.Point(450, 199);
            this.btn_foot.Margin = new System.Windows.Forms.Padding(4);
            this.btn_foot.Name = "btn_foot";
            this.btn_foot.Size = new System.Drawing.Size(261, 28);
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
            this.btn_header.Location = new System.Drawing.Point(450, 151);
            this.btn_header.Margin = new System.Windows.Forms.Padding(4);
            this.btn_header.Name = "btn_header";
            this.btn_header.Size = new System.Drawing.Size(261, 28);
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
            this.btn_commit.Location = new System.Drawing.Point(472, 555);
            this.btn_commit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_commit.Name = "btn_commit";
            this.btn_commit.Size = new System.Drawing.Size(261, 28);
            this.btn_commit.TabIndex = 4;
            this.btn_commit.Text = "Commit";
            this.btn_commit.UseVisualStyleBackColor = true;
            this.btn_commit.Click += new System.EventHandler(this.btn_commit_Click);
            // 
            // FrmSettings
            //
			
			//
            // dtp_start
            // 
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_start.Location = new System.Drawing.Point(108, 85);
            this.dtp_start.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(175, 30);
            this.dtp_start.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Start:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "End:";
            // 
            // dtp_end
            // 
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_end.Location = new System.Drawing.Point(391, 85);
            this.dtp_end.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(175, 30);
            this.dtp_end.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(589, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(276, 34);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtSalesTotals
            // 
            this.TxtSalesTotals.Location = new System.Drawing.Point(589, 253);
            this.TxtSalesTotals.Multiline = true;
            this.TxtSalesTotals.Name = "TxtSalesTotals";
            this.TxtSalesTotals.ReadOnly = true;
            this.TxtSalesTotals.Size = new System.Drawing.Size(276, 403);
            this.TxtSalesTotals.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(893, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 34);
            this.label6.TabIndex = 12;
            this.label6.Text = "Inventory Type";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtSalesInvType
            // 
            this.TxtSalesInvType.Location = new System.Drawing.Point(893, 253);
            this.TxtSalesInvType.Multiline = true;
            this.TxtSalesInvType.Name = "TxtSalesInvType";
            this.TxtSalesInvType.ReadOnly = true;
            this.TxtSalesInvType.Size = new System.Drawing.Size(276, 403);
            this.TxtSalesInvType.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(1196, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(276, 34);
            this.label7.TabIndex = 14;
            this.label7.Text = "Vendor";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtSalesVendor
            // 
            this.TxtSalesVendor.Location = new System.Drawing.Point(1196, 253);
            this.TxtSalesVendor.Multiline = true;
            this.TxtSalesVendor.Name = "TxtSalesVendor";
            this.TxtSalesVendor.ReadOnly = true;
            this.TxtSalesVendor.Size = new System.Drawing.Size(276, 403);
            this.TxtSalesVendor.TabIndex = 13;
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(24, 23);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(116, 35);
            this.btn_Run.TabIndex = 15;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(1292, 628);
            this.Controls.Add(this.btn_commit);
            this.Controls.Add(this.tab_receipt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSetting";
            this.Load += new System.EventHandler(this.FrmSetting_Load);
            this.tab_receipt.ResumeLayout(false);
            this.TabTypes.ResumeLayout(false);
            this.TabTypes.PerformLayout();
            this.tab_General.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSalesVendor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSalesInvType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtSalesTotals;
        private System.Windows.Forms.Button btn_change_image;
        private System.Windows.Forms.Button btn_rec_font;
        private System.Windows.Forms.Button btn_foot;
        private System.Windows.Forms.Button btn_header;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.ListBox listbox_logos;
        private System.Windows.Forms.Button btn_change_logo;
    }
}