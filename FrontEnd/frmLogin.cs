using System;
using System.Drawing;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Shared;
using Image = System.Drawing.Image;

namespace SecretCellar
{
    public partial class frmLogin : Form
    {
        private DataAccess _dataAccess;
        private Image logo = null;
        public frmLogin(Image logo = null)
        {
            if (logo == null)
                this.logo = Properties.Resources.Logo;

            _dataAccess = new DataAccess(Properties.Settings.Default.URL);

            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            if (text == "")
            {
                user = _dataAccess.GetEmployee(0);
            }
            else if (int.TryParse(text, out int pin))
            {
                user = _dataAccess.GetEmployee(pin);
            }

            if (user == null)
                MessageBox.Show("Invalid Pin");
            else
            {
              //  MessageBox.Show($"   Welcome {user.FirstName}");
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
        }
    }
}