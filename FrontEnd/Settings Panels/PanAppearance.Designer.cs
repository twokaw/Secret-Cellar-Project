﻿
namespace SecretCellar.Settings_Panels
{
    partial class PanAppearance
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
            this.btn_Font_Color = new System.Windows.Forms.Button();
            this.btn_commit = new System.Windows.Forms.Button();
            this.btn_change_logo = new System.Windows.Forms.Button();
            this.btn_change_image = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_row_color = new System.Windows.Forms.Button();
            this.btn_font_settings = new System.Windows.Forms.Button();
            this.btn_panel_color = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.listbox_logos = new System.Windows.Forms.ListBox();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.btn_Font_Color);
            this.panel1.Controls.Add(this.btn_commit);
            this.panel1.Controls.Add(this.btn_change_logo);
            this.panel1.Controls.Add(this.btn_change_image);
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.btn_row_color);
            this.panel1.Controls.Add(this.btn_font_settings);
            this.panel1.Controls.Add(this.btn_panel_color);
            this.panel1.Controls.Add(this.btn_color);
            this.panel1.Controls.Add(this.listbox_logos);
            this.panel1.Controls.Add(this.pic_logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 431);
            this.panel1.TabIndex = 0;
            // 
            // btn_Font_Color
            // 
            this.btn_Font_Color.AutoSize = true;
            this.btn_Font_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Font_Color.Location = new System.Drawing.Point(840, 287);
            this.btn_Font_Color.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Font_Color.Name = "btn_Font_Color";
            this.btn_Font_Color.Size = new System.Drawing.Size(188, 58);
            this.btn_Font_Color.TabIndex = 10;
            this.btn_Font_Color.Text = "Font Color";
            this.btn_Font_Color.UseVisualStyleBackColor = true;
            this.btn_Font_Color.Click += new System.EventHandler(this.btn_Font_Color_Click);
            // 
            // btn_commit
            // 
            this.btn_commit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_commit.AutoSize = true;
            this.btn_commit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_commit.Location = new System.Drawing.Point(840, 355);
            this.btn_commit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_commit.Name = "btn_commit";
            this.btn_commit.Size = new System.Drawing.Size(188, 58);
            this.btn_commit.TabIndex = 9;
            this.btn_commit.Text = "Commit";
            this.btn_commit.UseVisualStyleBackColor = true;
            this.btn_commit.Click += new System.EventHandler(this.btn_commit_Click);
            // 
            // btn_change_logo
            // 
            this.btn_change_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_change_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change_logo.Location = new System.Drawing.Point(478, 257);
            this.btn_change_logo.Name = "btn_change_logo";
            this.btn_change_logo.Size = new System.Drawing.Size(261, 58);
            this.btn_change_logo.TabIndex = 3;
            this.btn_change_logo.Text = "Change Logo";
            this.btn_change_logo.UseVisualStyleBackColor = true;
            this.btn_change_logo.Click += new System.EventHandler(this.btn_change_logo_Click);
            // 
            // btn_change_image
            // 
            this.btn_change_image.AutoSize = true;
            this.btn_change_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change_image.Location = new System.Drawing.Point(30, 16);
            this.btn_change_image.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_change_image.Name = "btn_change_image";
            this.btn_change_image.Size = new System.Drawing.Size(220, 58);
            this.btn_change_image.TabIndex = 1;
            this.btn_change_image.Text = "Import Image";
            this.btn_change_image.UseVisualStyleBackColor = true;
            this.btn_change_image.Click += new System.EventHandler(this.btn_change_image_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reset.AutoSize = true;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(478, 355);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(261, 58);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "Default Settings";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_row_color
            // 
            this.btn_row_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_row_color.AutoSize = true;
            this.btn_row_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_row_color.Location = new System.Drawing.Point(840, 151);
            this.btn_row_color.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_row_color.Name = "btn_row_color";
            this.btn_row_color.Size = new System.Drawing.Size(188, 58);
            this.btn_row_color.TabIndex = 7;
            this.btn_row_color.Text = "Row Color";
            this.btn_row_color.UseVisualStyleBackColor = true;
            this.btn_row_color.Click += new System.EventHandler(this.btn_row_color_Click);
            // 
            // btn_font_settings
            // 
            this.btn_font_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_font_settings.AutoSize = true;
            this.btn_font_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_font_settings.Location = new System.Drawing.Point(840, 219);
            this.btn_font_settings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_font_settings.Name = "btn_font_settings";
            this.btn_font_settings.Size = new System.Drawing.Size(188, 58);
            this.btn_font_settings.TabIndex = 6;
            this.btn_font_settings.Text = "Font";
            this.btn_font_settings.UseVisualStyleBackColor = true;
            this.btn_font_settings.Click += new System.EventHandler(this.btn_font_settings_Click);
            // 
            // btn_panel_color
            // 
            this.btn_panel_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_panel_color.AutoSize = true;
            this.btn_panel_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_panel_color.Location = new System.Drawing.Point(840, 83);
            this.btn_panel_color.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_panel_color.Name = "btn_panel_color";
            this.btn_panel_color.Size = new System.Drawing.Size(188, 58);
            this.btn_panel_color.TabIndex = 5;
            this.btn_panel_color.Text = "Panel Color";
            this.btn_panel_color.UseVisualStyleBackColor = true;
            this.btn_panel_color.Click += new System.EventHandler(this.btn_panel_color_Click);
            // 
            // btn_color
            // 
            this.btn_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_color.AutoSize = true;
            this.btn_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_color.Location = new System.Drawing.Point(840, 15);
            this.btn_color.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(188, 58);
            this.btn_color.TabIndex = 4;
            this.btn_color.Text = "Default Color";
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // listbox_logos
            // 
            this.listbox_logos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listbox_logos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.listbox_logos.FormattingEnabled = true;
            this.listbox_logos.ItemHeight = 25;
            this.listbox_logos.Location = new System.Drawing.Point(478, 72);
            this.listbox_logos.Name = "listbox_logos";
            this.listbox_logos.Size = new System.Drawing.Size(260, 179);
            this.listbox_logos.TabIndex = 2;
            this.listbox_logos.SelectedIndexChanged += new System.EventHandler(this.listbox_logos_SelectedIndexChanged);
            // 
            // pic_logo
            // 
            this.pic_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_logo.Location = new System.Drawing.Point(30, 81);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(422, 330);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 7;
            this.pic_logo.TabStop = false;
            // 
            // PanAppearance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "PanAppearance";
            this.Size = new System.Drawing.Size(1050, 431);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.ListBox listbox_logos;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_row_color;
        private System.Windows.Forms.Button btn_font_settings;
        private System.Windows.Forms.Button btn_panel_color;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button btn_change_logo;
        private System.Windows.Forms.Button btn_change_image;
        private System.Windows.Forms.Button btn_commit;
        private System.Windows.Forms.Button btn_Font_Color;
    }
}
