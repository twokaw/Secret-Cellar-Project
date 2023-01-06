using System;
using System.Drawing;
using System.Windows.Forms;

namespace SecretCellar.Settings_Panels
{
    public partial class PanReceipt : ManagedPanel {
        public PanReceipt()
        {
            InitializeComponent();
            txt_receipt_header.Text = Properties.Settings.Default.Header;
            txt_receipt_footer.Text = Properties.Settings.Default.Footer;
        }

        private void lbl_receipt_footer_Click(object sender, EventArgs e)
        {

        }

        private void btn_rec_font_Click(object sender, EventArgs e)
        {
            Font currentFont = new Font(Properties.Settings.Default.ReceiptFont, Properties.Settings.Default.ReceiptFontSize);
            FontDialog fontDlg = new FontDialog();
            fontDlg.MaxSize = 14;
            fontDlg.MinSize = 8;
            fontDlg.Font = currentFont;

            fontDlg.ShowDialog();
            Properties.Settings.Default.ReceiptFont = fontDlg.Font.Name;
            Properties.Settings.Default.ReceiptFontSize = fontDlg.Font.Size;
            Properties.Settings.Default.Save();
        }

        private void PanReceipt_Load(object sender, EventArgs e)
        {
            txt_receipt_header.Text = Properties.Settings.Default.Header;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_header_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Header = txt_receipt_header.Text;
        }

        private void btn_foot_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Footer = txt_receipt_footer.Text;
        }

        private void btn_receipt_font_reset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ReceiptFont = "Arial";
            Properties.Settings.Default.ReceiptFontSize = 9;
            Properties.Settings.Default.Save();
        }
    }
}
