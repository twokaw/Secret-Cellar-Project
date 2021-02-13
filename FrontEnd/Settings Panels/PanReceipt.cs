using System;
using System.Windows.Forms;

namespace SecretCellar.Settings_Panels
{
    public partial class PanReceipt : UserControl
    {
        public PanReceipt()
        {
            InitializeComponent();
        }

        private void lbl_receipt_footer_Click(object sender, EventArgs e)
        {

        }

        private void btn_rec_font_Click(object sender, EventArgs e)
        {

        }

        private void PanReceipt_Load(object sender, EventArgs e)
        {
            txt_receipt_header.Text = Properties.Settings.Default.Header;

        }
    }
}
