
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
            this.btn_defaultSettings = new System.Windows.Forms.Button();
            this.btn_row_color = new System.Windows.Forms.Button();
            this.btn_panel_color = new System.Windows.Forms.Button();
            this.listbox_logos = new System.Windows.Forms.ListBox();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.button_gridAlternateRowColor = new System.Windows.Forms.Button();
            this.button_gridBackColor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.button_gridBackColor);
            this.panel1.Controls.Add(this.button_gridAlternateRowColor);
            this.panel1.Controls.Add(this.btn_Font_Color);
            this.panel1.Controls.Add(this.btn_commit);
            this.panel1.Controls.Add(this.btn_change_logo);
            this.panel1.Controls.Add(this.btn_change_image);
            this.panel1.Controls.Add(this.btn_defaultSettings);
            this.panel1.Controls.Add(this.btn_row_color);
            this.panel1.Controls.Add(this.btn_panel_color);
            this.panel1.Controls.Add(this.listbox_logos);
            this.panel1.Controls.Add(this.pic_logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 280);
            this.panel1.TabIndex = 0;
            // 
            // btn_Font_Color
            // 
            this.btn_Font_Color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Font_Color.AutoSize = true;
            this.btn_Font_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Font_Color.Location = new System.Drawing.Point(560, 10);
            this.btn_Font_Color.Name = "btn_Font_Color";
            this.btn_Font_Color.Size = new System.Drawing.Size(125, 38);
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
            this.btn_commit.Location = new System.Drawing.Point(560, 224);
            this.btn_commit.Name = "btn_commit";
            this.btn_commit.Size = new System.Drawing.Size(125, 38);
            this.btn_commit.TabIndex = 9;
            this.btn_commit.Text = "Commit";
            this.btn_commit.UseVisualStyleBackColor = true;
            this.btn_commit.Click += new System.EventHandler(this.btn_commit_Click);
            // 
            // btn_change_logo
            // 
            this.btn_change_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_change_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change_logo.Location = new System.Drawing.Point(20, 54);
            this.btn_change_logo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_change_logo.Name = "btn_change_logo";
            this.btn_change_logo.Size = new System.Drawing.Size(174, 38);
            this.btn_change_logo.TabIndex = 3;
            this.btn_change_logo.Text = "Change Logo";
            this.btn_change_logo.UseVisualStyleBackColor = true;
            this.btn_change_logo.Click += new System.EventHandler(this.btn_change_logo_Click);
            // 
            // btn_change_image
            // 
            this.btn_change_image.AutoSize = true;
            this.btn_change_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change_image.Location = new System.Drawing.Point(20, 10);
            this.btn_change_image.Name = "btn_change_image";
            this.btn_change_image.Size = new System.Drawing.Size(147, 38);
            this.btn_change_image.TabIndex = 1;
            this.btn_change_image.Text = "Import Image";
            this.btn_change_image.UseVisualStyleBackColor = true;
            this.btn_change_image.Click += new System.EventHandler(this.btn_change_image_Click);
            // 
            // btn_defaultSettings
            // 
            this.btn_defaultSettings.AutoSize = true;
            this.btn_defaultSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_defaultSettings.Location = new System.Drawing.Point(231, 10);
            this.btn_defaultSettings.Name = "btn_defaultSettings";
            this.btn_defaultSettings.Size = new System.Drawing.Size(175, 38);
            this.btn_defaultSettings.TabIndex = 8;
            this.btn_defaultSettings.Text = "Default Settings";
            this.btn_defaultSettings.UseVisualStyleBackColor = true;
            this.btn_defaultSettings.Click += new System.EventHandler(this.btn_defaultSettings_Click);
            // 
            // btn_row_color
            // 
            this.btn_row_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_row_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_row_color.Location = new System.Drawing.Point(424, 54);
            this.btn_row_color.Name = "btn_row_color";
            this.btn_row_color.Size = new System.Drawing.Size(125, 38);
            this.btn_row_color.TabIndex = 7;
            this.btn_row_color.Text = "Grid Row Color";
            this.btn_row_color.UseVisualStyleBackColor = true;
            this.btn_row_color.Click += new System.EventHandler(this.btn_row_color_Click);
            // 
            // btn_panel_color
            // 
            this.btn_panel_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_panel_color.AutoSize = true;
            this.btn_panel_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_panel_color.Location = new System.Drawing.Point(424, 10);
            this.btn_panel_color.Name = "btn_panel_color";
            this.btn_panel_color.Size = new System.Drawing.Size(125, 38);
            this.btn_panel_color.TabIndex = 5;
            this.btn_panel_color.Text = "Panel Color";
            this.btn_panel_color.UseVisualStyleBackColor = true;
            this.btn_panel_color.Click += new System.EventHandler(this.btn_panel_color_Click);
            // 
            // listbox_logos
            // 
            this.listbox_logos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listbox_logos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.listbox_logos.FormattingEnabled = true;
            this.listbox_logos.ItemHeight = 16;
            this.listbox_logos.Location = new System.Drawing.Point(231, 98);
            this.listbox_logos.Margin = new System.Windows.Forms.Padding(2);
            this.listbox_logos.Name = "listbox_logos";
            this.listbox_logos.Size = new System.Drawing.Size(175, 164);
            this.listbox_logos.TabIndex = 2;
            this.listbox_logos.SelectedIndexChanged += new System.EventHandler(this.listbox_logos_SelectedIndexChanged);
            // 
            // pic_logo
            // 
            this.pic_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_logo.Location = new System.Drawing.Point(20, 98);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(198, 169);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 7;
            this.pic_logo.TabStop = false;
            // 
            // button_gridAlternateRowColor
            // 
            this.button_gridAlternateRowColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_gridAlternateRowColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_gridAlternateRowColor.Location = new System.Drawing.Point(560, 54);
            this.button_gridAlternateRowColor.Name = "button_gridAlternateRowColor";
            this.button_gridAlternateRowColor.Size = new System.Drawing.Size(125, 38);
            this.button_gridAlternateRowColor.TabIndex = 11;
            this.button_gridAlternateRowColor.Text = "Grid Alternate Row Color";
            this.button_gridAlternateRowColor.UseVisualStyleBackColor = true;
            this.button_gridAlternateRowColor.Click += new System.EventHandler(this.button_gridAlternateRowColor_Click);
            // 
            // button_gridBackColor
            // 
            this.button_gridBackColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_gridBackColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_gridBackColor.Location = new System.Drawing.Point(424, 98);
            this.button_gridBackColor.Name = "button_gridBackColor";
            this.button_gridBackColor.Size = new System.Drawing.Size(125, 38);
            this.button_gridBackColor.TabIndex = 12;
            this.button_gridBackColor.Text = "Grid Back Color";
            this.button_gridBackColor.UseVisualStyleBackColor = true;
            this.button_gridBackColor.Click += new System.EventHandler(this.button_gridBackColor_Click);
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
        private System.Windows.Forms.Button btn_defaultSettings;
        private System.Windows.Forms.Button btn_row_color;
        private System.Windows.Forms.Button btn_panel_color;
        private System.Windows.Forms.Button btn_change_logo;
        private System.Windows.Forms.Button btn_change_image;
        private System.Windows.Forms.Button btn_commit;
        private System.Windows.Forms.Button btn_Font_Color;
        private System.Windows.Forms.Button button_gridBackColor;
        private System.Windows.Forms.Button button_gridAlternateRowColor;
    }
}
