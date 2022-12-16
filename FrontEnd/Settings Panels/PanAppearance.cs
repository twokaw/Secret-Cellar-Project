﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretCellar.Settings_Panels
{
    public partial class PanAppearance : UserControl {
        private ToolTip _programTips = new ToolTip();


        public PanAppearance() {
            InitializeComponent();
            listbox_logos.DataSource = DataAccess.instance?.GetImageFiles();

            if (listbox_logos?.Items?.Count > 0)
                listbox_logos.SelectedItem = listbox_logos.Items.IndexOf(DataAccess.instance?.LogoName());

            // Set up the delays for the ToolTip.
            _programTips.AutoPopDelay = 10000;
            _programTips.InitialDelay = 1000;
            _programTips.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            _programTips.ShowAlways = true;
            // Set up the ToolTip text for the Button and Checkbox.
            _programTips.SetToolTip(this.btn_commit, "Click commit to save changes.");
            //ProgramTips.SetToolTip(this.checkBox1, "My checkBox1");
            //pic_logo.Image = DataAccess.instance.GetImage();
        }


        private void btn_change_logo_Click(object sender, EventArgs e) { DataAccess.instance.ChangeLogo(listbox_logos.Text); }
        private void listbox_logos_SelectedIndexChanged(object sender, EventArgs e) { pic_logo.Image = DataAccess.instance.GetImage(listbox_logos.Text); }


        /// <summary>
        /// Opens a file dialog to import the given image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_change_image_Click(object sender, EventArgs e) {
            OpenFileDialog image = new OpenFileDialog {
                Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp,;*.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png;",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (image.ShowDialog() == DialogResult.OK) pic_logo.Image = DataAccess.instance.ImportLogo(image.FileName);
        }


        /// <summary>
        /// Opens a color picker dialog to change the panel color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_panel_color_Click(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog { Color = ManagedForm.DataGridViewColor };

            if (colorPicker.ShowDialog() == DialogResult.OK)
                ManagedForm.PanelColor = colorPicker.Color;
        }


        /// <summary>
        /// Opens a color picker dialog to change the font color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Font_Color_Click(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog { Color = ManagedForm.DataGridViewColor };

            if (colorPicker.ShowDialog() == DialogResult.OK)
                ManagedForm.FontColor = colorPicker.Color;
        }


        /// <summary>
        /// Opens a color picker dialog to change the data grid row color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_row_color_Click(object sender, EventArgs e) {
            DataGridViewCellStyle cs = ManagedForm.CellStyle;
            ColorDialog gridcolor = new ColorDialog { Color = cs.BackColor };

            if (gridcolor.ShowDialog() == DialogResult.OK) {
                cs.BackColor = gridcolor.Color;
                cs.SelectionBackColor = Color.FromArgb(cs.BackColor.A, Math.Max(cs.BackColor.R - 25, 0), Math.Max(cs.BackColor.G - 25, 0), Math.Max(cs.BackColor.B - 25, 0));
                ManagedForm.DataGridViewRowColor = cs.BackColor;
            }
        }


        /// <summary>
        /// Opens a color picker dialog to change the data grid alternate row color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_gridAlternateRowColor_Click(object sender, EventArgs e) {
            DataGridViewCellStyle cs = ManagedForm.CellStyle;
            ColorDialog gridcolor = new ColorDialog { Color = cs.BackColor };

            if (gridcolor.ShowDialog() == DialogResult.OK) {
                cs.BackColor = gridcolor.Color;
                cs.SelectionBackColor = Color.FromArgb(cs.BackColor.A, Math.Max(cs.BackColor.R - 25, 0), Math.Max(cs.BackColor.G - 25, 0), Math.Max(cs.BackColor.B - 25, 0));
                ManagedForm.DataGridViewAlternateRowColor = cs.BackColor;
            }
        }


        /// <summary>
        /// Opens a color picker dialog to change the data grid background color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_gridBackColor_Click(object sender, EventArgs e) {
            DataGridViewCellStyle cs = ManagedForm.CellStyle;
            ColorDialog gridcolor = new ColorDialog { Color = cs.BackColor };

            if (gridcolor.ShowDialog() == DialogResult.OK) {
                cs.BackColor = gridcolor.Color;
                cs.SelectionBackColor = Color.FromArgb(cs.BackColor.A, Math.Max(cs.BackColor.R - 25, 0), Math.Max(cs.BackColor.G - 25, 0), Math.Max(cs.BackColor.B - 25, 0));
                ManagedForm.DataGridViewColor = cs.BackColor;
            }
        }


        /// <summary>
        /// Sets the settings back to default.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_defaultSettings_Click(object sender, EventArgs e) { ManagedForm.SetPropertiesToDefault(); }


        /// <summary>
        /// Saves the colors to the properties.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_commit_Click(object sender, EventArgs e) {
            ManagedForm._defaultPanelColor = ManagedForm.PanelColor;
            ManagedForm._defaultFontColor = ManagedForm.FontColor;
            ManagedForm._defaultButtonColor = ManagedForm.ButtonColor;
            ManagedForm._defaultButtonFontColor = ManagedForm.ButtonFontColor;
            ManagedForm._defaultDataGridViewColor = ManagedForm.DataGridViewColor;
            ManagedForm._defaultDataGridViewRowColor = ManagedForm.DataGridViewRowColor;
            ManagedForm._defaultDataGridViewAlternateRowColor = ManagedForm.DataGridViewAlternateRowColor;

            Properties.Settings.Default.Save();
        }
    }
}
