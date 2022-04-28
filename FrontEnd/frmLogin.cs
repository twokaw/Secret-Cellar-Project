using System;
using System.Drawing;
using System.Windows.Forms;
using Shared;
using Image = System.Drawing.Image;

namespace SecretCellar
{
    public partial class frmLogin : Form
    {
        public frmLogin(Image logo = null)
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            DataAccess.instance.AddPictureBox(pictureBox1);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Validate_user(txtPin.Text);
        }

        private void txtPin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Return)
            {
                Validate_user(txtPin.Text);
            }
        }

        private void Validate_user(string text)
        {
            EmployeeModel user = null;
            text = text.Trim();

            if (!string.IsNullOrWhiteSpace (text))
                user = DataAccess.instance.GetEmployee(text);

            if (user == null)
                MessageBox.Show("Invalid user name");
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
        }
    }
}