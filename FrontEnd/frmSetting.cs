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
    public partial class FrmSetting : Form
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

        private void CaseDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (caseDiscount.Checked)
            {
                // Do something when CheckBox is checked  
            }
            else
            {
                // Do something here when CheckBox is not checked  
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog
            {
                Color = Color.Green
            };



            if (colorPicker.ShowDialog() == DialogResult.OK)
                BackColor = colorPicker.Color;
        }

        private void btn_panel_color_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog
            {
                Color = Color.Green
            };



            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                Color color = colorPicker.Color;
                Color dataGridView = color;
            }
        }

        private void btn_font_settings_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowDialog();
        }
    }
}
