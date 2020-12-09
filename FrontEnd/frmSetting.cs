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

        public FrmSetting()
        {
            InitializeComponent();
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            lstTypes.DataSource = dataAccess.GetInventoryType();
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
                SetBackColor(colorPicker.Color);
        }

        private void tab_General_Click(object sender, EventArgs e)
        {

        }

        private void btn_font_settings_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowDialog();
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
                cs.SelectionBackColor = Color.FromArgb(cs.BackColor.A, cs.BackColor.R - 15, cs.BackColor.G - 15, cs.BackColor.B - 15);
                SetDefaultCellStyle(cs);

            }
        }
    }
}
