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
                Color = Color.Green
            };

            if (colorPicker.ShowDialog() == DialogResult.OK)
                ManagedForm.SetBackColor (colorPicker.Color);
                //BackColor = colorPicker.Color;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {

        }

        private void tab_General_Click(object sender, EventArgs e)
        {

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

        private void btn_font_Click(object sender, EventArgs e)
        {

        }

        private void btn_font_Click_1(object sender, EventArgs e)
        {

            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowDialog();
        }
    }
}
