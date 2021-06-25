
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
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(700, 280);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// btn_commit
			// 
			this.btn_commit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_commit.AutoSize = true;
			this.btn_commit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.btn_commit.Location = new System.Drawing.Point(512, 240);
			this.btn_commit.Name = "btn_commit";
			this.btn_commit.Size = new System.Drawing.Size(174, 27);
			this.btn_commit.TabIndex = 16;
			this.btn_commit.Text = "Commit";
			this.btn_commit.UseVisualStyleBackColor = true;
			this.btn_commit.Click += new System.EventHandler(this.btn_commit_Click);
			// 
			// btn_change_logo
			// 
			this.btn_change_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_change_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.btn_change_logo.Location = new System.Drawing.Point(319, 242);
			this.btn_change_logo.Margin = new System.Windows.Forms.Padding(2);
			this.btn_change_logo.Name = "btn_change_logo";
			this.btn_change_logo.Size = new System.Drawing.Size(174, 25);
			this.btn_change_logo.TabIndex = 15;
			this.btn_change_logo.Text = "Change Logo";
			this.btn_change_logo.UseVisualStyleBackColor = true;
			this.btn_change_logo.Click += new System.EventHandler(this.btn_change_logo_Click);
			// 
			// btn_change_image
			// 
			this.btn_change_image.AutoSize = true;
			this.btn_change_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.btn_change_image.Location = new System.Drawing.Point(20, 14);
			this.btn_change_image.Name = "btn_change_image";
			this.btn_change_image.Size = new System.Drawing.Size(135, 26);
			this.btn_change_image.TabIndex = 14;
			this.btn_change_image.Text = "Import Image";
			this.btn_change_image.UseVisualStyleBackColor = true;
			this.btn_change_image.Click += new System.EventHandler(this.btn_change_image_Click);
			// 
			// btn_reset
			// 
			this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_reset.AutoSize = true;
			this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.btn_reset.Location = new System.Drawing.Point(512, 196);
			this.btn_reset.Name = "btn_reset";
			this.btn_reset.Size = new System.Drawing.Size(174, 31);
			this.btn_reset.TabIndex = 13;
			this.btn_reset.Text = "Default Settings";
			this.btn_reset.UseVisualStyleBackColor = true;
			this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
			// 
			// btn_row_color
			// 
			this.btn_row_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_row_color.AutoSize = true;
			this.btn_row_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.btn_row_color.Location = new System.Drawing.Point(512, 125);
			this.btn_row_color.Name = "btn_row_color";
			this.btn_row_color.Size = new System.Drawing.Size(174, 31);
			this.btn_row_color.TabIndex = 12;
			this.btn_row_color.Text = "Row Color Settings";
			this.btn_row_color.UseVisualStyleBackColor = true;
			this.btn_row_color.Click += new System.EventHandler(this.btn_row_color_Click);
			// 
			// btn_font_settings
			// 
			this.btn_font_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_font_settings.AutoSize = true;
			this.btn_font_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.btn_font_settings.Location = new System.Drawing.Point(512, 88);
			this.btn_font_settings.Name = "btn_font_settings";
			this.btn_font_settings.Size = new System.Drawing.Size(174, 31);
			this.btn_font_settings.TabIndex = 11;
			this.btn_font_settings.Text = "Font Settings";
			this.btn_font_settings.UseVisualStyleBackColor = true;
			this.btn_font_settings.Click += new System.EventHandler(this.btn_font_settings_Click);
			// 
			// btn_panel_color
			// 
			this.btn_panel_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_panel_color.AutoSize = true;
			this.btn_panel_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.btn_panel_color.Location = new System.Drawing.Point(512, 51);
			this.btn_panel_color.Name = "btn_panel_color";
			this.btn_panel_color.Size = new System.Drawing.Size(174, 31);
			this.btn_panel_color.TabIndex = 10;
			this.btn_panel_color.Text = "Panel Color Settings";
			this.btn_panel_color.UseVisualStyleBackColor = true;
			this.btn_panel_color.Click += new System.EventHandler(this.btn_panel_color_Click);
			// 
			// btn_color
			// 
			this.btn_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_color.AutoSize = true;
			this.btn_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.btn_color.Location = new System.Drawing.Point(512, 14);
			this.btn_color.Name = "btn_color";
			this.btn_color.Size = new System.Drawing.Size(174, 31);
			this.btn_color.TabIndex = 9;
			this.btn_color.Text = "Color Settings";
			this.btn_color.UseVisualStyleBackColor = true;
			this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
			// 
			// listbox_logos
			// 
			this.listbox_logos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listbox_logos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.listbox_logos.FormattingEnabled = true;
			this.listbox_logos.ItemHeight = 16;
			this.listbox_logos.Location = new System.Drawing.Point(319, 47);
			this.listbox_logos.Margin = new System.Windows.Forms.Padding(2);
			this.listbox_logos.Name = "listbox_logos";
			this.listbox_logos.Size = new System.Drawing.Size(175, 180);
			this.listbox_logos.TabIndex = 8;
			this.listbox_logos.SelectedIndexChanged += new System.EventHandler(this.listbox_logos_SelectedIndexChanged);
			// 
			// pic_logo
			// 
			this.pic_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_logo.Location = new System.Drawing.Point(20, 50);
			this.pic_logo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
			this.pic_logo.Name = "pic_logo";
			this.pic_logo.Size = new System.Drawing.Size(281, 185);
			this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_logo.TabIndex = 7;
			this.pic_logo.TabStop = false;
			// 
			// PanAppearance
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "PanAppearance";
			this.Size = new System.Drawing.Size(700, 280);
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
    }
}
