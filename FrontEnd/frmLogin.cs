using System;
using System.Windows.Forms;
using Shared;
using Image = System.Drawing.Image;

namespace SecretCellar
{
    public partial class frmLogin : ManagedForm
    {
        private int InvalidUserCount;
        public frmLogin(Image logo = null)
        {
            InvalidUserCount = 0;
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e) =>
            DataAccess.instance.AddPictureBox(pictureBox1);

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Validate_user(txtPin.Text);
        }

        private void txtPin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Return)
                Validate_user(txtPin.Text);
        }

        private void Validate_user(string text)
        {
            EmployeeModel user = null;
            text = text.Trim();

            if (!string.IsNullOrWhiteSpace (text))
                user = DataAccess.instance.LoginUser(text);

            if (user == null)
            { 
                if (++InvalidUserCount > 3)
                    Application.Exit();

               
                lblError.Text = $"Invalid user name. Remaining tries {4 - InvalidUserCount}";
                lblError.Visible = true;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
            txtPin.Text = "";
            txtPin.SelectAll();  
            txtPin.Focus();
        }
    }
}