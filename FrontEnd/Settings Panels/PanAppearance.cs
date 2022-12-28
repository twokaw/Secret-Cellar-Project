using System;
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
        /// Opens a color picker dialog to change the background color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_backgroundColor_Click(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog { Color = ManagedForm.DataGridViewColor };

            if (colorPicker.ShowDialog() == DialogResult.OK)
                ManagedForm.BackgroundColor = colorPicker.Color;
        }


        /// <summary>
        /// Opens a color picker dialog to change the panel color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_panel_color_Click(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog { Color = ManagedForm.PanelColor };

            if (colorPicker.ShowDialog() == DialogResult.OK)
                ManagedForm.PanelColor = colorPicker.Color;
        }


        /// <summary>
        /// Opens a color picker dialog to change the font color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Font_Color_Click(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog { Color = ManagedForm.FontColor };

            if (colorPicker.ShowDialog() == DialogResult.OK)
                ManagedForm.FontColor = colorPicker.Color;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_buttonBackColor_Click(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog { Color = ManagedForm.ButtonColor };

            if (colorPicker.ShowDialog() == DialogResult.OK)
                ManagedForm.ButtonColor = colorPicker.Color;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_buttonFontColor_Click(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog { Color = ManagedForm.ButtonFontColor };

            if (colorPicker.ShowDialog() == DialogResult.OK)
                ManagedForm.ButtonFontColor = colorPicker.Color;
        }


        /// <summary>
        /// Opens a color picker dialog to change the data grid background color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_gridBackColor_Click(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog { Color = ManagedForm.DataGridViewColor };

            if (colorPicker.ShowDialog() == DialogResult.OK) {
                ManagedForm.DataGridViewColor = colorPicker.Color;
            }
        }


        /// <summary>
        /// Opens a color picker dialog to change the data grid row color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_row_color_Click(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog { Color = ManagedForm.DataGridViewRowColor };

            if (colorPicker.ShowDialog() == DialogResult.OK) {
                ManagedForm.DataGridViewRowColor = colorPicker.Color;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_gridRowFontColor_Click(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog { Color = ManagedForm.DataGridViewRowFontColor };

            if (colorPicker.ShowDialog() == DialogResult.OK)
                ManagedForm.DataGridViewRowFontColor = colorPicker.Color;
        }


        /// <summary>
        /// Opens a color picker dialog to change the data grid alternate row color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_gridAlternateRowColor_Click(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog { Color = ManagedForm.DataGridViewAlternateRowColor };

            if (colorPicker.ShowDialog() == DialogResult.OK) {
                ManagedForm.DataGridViewAlternateRowColor = colorPicker.Color;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_gridAlternateRowFontColor_Click(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog { Color = ManagedForm.DataGridViewAlternateRowFontColor };

            if (colorPicker.ShowDialog() == DialogResult.OK)
                ManagedForm.DataGridViewAlternateRowFontColor = colorPicker.Color;
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
        private void btn_commit_Click(object sender, EventArgs e) { Properties.Settings.Default.Save(); }
    }
}
