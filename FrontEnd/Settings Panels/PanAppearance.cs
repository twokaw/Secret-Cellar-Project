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
    public partial class PanAppearance : UserControl
    {
        private ToolTip ProgramTips = new ToolTip();
        public PanAppearance()
        {
            InitializeComponent();
            listbox_logos.DataSource = DataAccess.instance?.GetImageFiles();

            listbox_logos.SelectedItem = listbox_logos.Items.IndexOf(DataAccess.instance?.LogoName());

            // Set up the delays for the ToolTip.
            ProgramTips.AutoPopDelay = 10000;
            ProgramTips.InitialDelay = 1000;
            ProgramTips.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            ProgramTips.ShowAlways = true;
            // Set up the ToolTip text for the Button and Checkbox.
            ProgramTips.SetToolTip(this.btn_commit, "Click commit to make changes permanent otherwise will reset on program close");
            //ProgramTips.SetToolTip(this.checkBox1, "My checkBox1");
            //pic_logo.Image = DataAccess.instance.GetImage();

        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog
            {
                Color = Color.Gray
            };

            if (colorPicker.ShowDialog() == DialogResult.OK)
                ManagedForm.MainWindowColor = colorPicker.Color;
        }

        private void btn_panel_color_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog
            {
                Color = ManagedForm.DataGridViewBackColor
            };

            if (colorPicker.ShowDialog() == DialogResult.OK)
                ManagedForm.DataGridViewBackColor = colorPicker.Color;
        }

        private void btn_font_settings_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowDialog();
            ManagedForm.CommonFontSetter = fontDlg.Font;
        }

        private void btn_row_color_Click(object sender, EventArgs e)
        {
            DataGridViewCellStyle cs = ManagedForm.DefaultCellStyle;

            ColorDialog gridcolor = new ColorDialog
            {
                Color = cs.BackColor
            };

            if (gridcolor.ShowDialog() == DialogResult.OK)

            {

                cs.BackColor = gridcolor.Color;
                cs.SelectionBackColor = Color.FromArgb(cs.BackColor.A, Math.Max(cs.BackColor.R - 25, 0), Math.Max(cs.BackColor.G - 25, 0), Math.Max(cs.BackColor.B - 25, 0));
                ManagedForm.SetDefaultCellStyle(cs);

            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BackgroundColor = Properties.Settings.Default.DefaultBackgroundColor;
            Properties.Settings.Default.GridColor = Properties.Settings.Default.DefaultGridColor;
            Properties.Settings.Default.FontSet = Properties.Settings.Default.DefaultFont;
            ManagedForm.reset_Default_Properties();
            Properties.Settings.Default.Save();
        }

        private void btn_change_logo_Click(object sender, EventArgs e)
        {
            DataAccess.instance.ChangeLogo(listbox_logos.Text);
        }

        private void btn_change_image_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog image = new OpenFileDialog
            {
                // image filters  
                Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp,;*.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png;",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            //Open Image Dialog okay;
            if (image.ShowDialog() == DialogResult.OK)
                pic_logo.Image = DataAccess.instance.ImportLogo(image.FileName);
        }

        private void listbox_logos_SelectedIndexChanged(object sender, EventArgs e)
        {
            pic_logo.Image = DataAccess.instance.GetImage(listbox_logos.Text);
        }

        private void btn_commit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BackgroundColor = ManagedForm.MainWindowColor;
            Properties.Settings.Default.GridColor = ManagedForm.DataGridViewBackColor;
            Properties.Settings.Default.FontSet = ManagedForm.CommonFontSetter;
            Properties.Settings.Default.Save();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
