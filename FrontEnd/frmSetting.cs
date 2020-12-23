using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretCellar
{
    public partial class FrmSetting : ManagedForm
    {
        private readonly DataAccess dataAccess = new DataAccess();
        private ToolTip ProgramTips = new ToolTip();

        public FrmSetting()
        {
            InitializeComponent();
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            lstTypes.DataSource = dataAccess.GetInventoryType();
            // Set up the delays for the ToolTip.
            ProgramTips.AutoPopDelay = 10000;
            ProgramTips.InitialDelay = 1000;
            ProgramTips.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            ProgramTips.ShowAlways = true;
            // Set up the ToolTip text for the Button and Checkbox.
            ProgramTips.SetToolTip(this.btn_commit, "Click commit to make changes permanent otherwise will reset on program close");
            //ProgramTips.SetToolTip(this.checkBox1, "My checkBox1");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog
            {
                Color = Color.Gray
            };

            if (colorPicker.ShowDialog() == DialogResult.OK)
                MainWindowColor = colorPicker.Color;
        }

        private void tab_General_Click(object sender, EventArgs e)
        {

        }

        private void btn_font_settings_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowDialog();
            CommonFontSetter = fontDlg.Font;
        }

        private void btn_panel_color_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog
            {
                Color = DataGridViewBackColor
            };

            if (colorPicker.ShowDialog() == DialogResult.OK)
                DataGridViewBackColor = colorPicker.Color;
        }

        private void btn_row_color_Click(object sender, EventArgs e)
        {
            DataGridViewCellStyle cs = DefaultCellStyle;

            ColorDialog gridcolor = new ColorDialog
            {
                Color = cs.BackColor
            };

            if (gridcolor.ShowDialog() == DialogResult.OK)

            {

                cs.BackColor = gridcolor.Color;
                cs.SelectionBackColor = Color.FromArgb(cs.BackColor.A, Math.Max(cs.BackColor.R - 25,0), Math.Max(cs.BackColor.G - 25,0), Math.Max(cs.BackColor.B - 25,0));
                SetDefaultCellStyle(cs);

            }
        }

        private void btn_commit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BackgroundColor = ManagedForm.MainWindowColor;
            Properties.Settings.Default.GridColor = ManagedForm.DataGridViewBackColor;
            Properties.Settings.Default.FontSet = ManagedForm.CommonFontSetter;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BackgroundColor = Properties.Settings.Default.DefaultBackgroundColor;
            Properties.Settings.Default.GridColor = Properties.Settings.Default.DefaultGridColor;
            Properties.Settings.Default.FontSet = Properties.Settings.Default.DefaultFont;
            reset_Default_Properties();
            Properties.Settings.Default.Save();
        }
    }
}
//testing