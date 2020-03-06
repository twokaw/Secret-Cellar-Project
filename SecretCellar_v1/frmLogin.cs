using SecretCellar.models;
using System;
using System.Windows.Forms;

namespace SecretCellar
{
    public partial class frmLogin : Form
    {
        private IDataAccess _dataAccess;
        public frmLogin()
        {
            if (Properties.Settings.Default.Live)
                _dataAccess = new DataAccess();
            else
                _dataAccess = new DataAccessTest();

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

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = null;
            if (txtPin.Text == "")
            {
                user = _dataAccess.GetUser(0);
            }
            else if (int.TryParse(txtPin.Text, out int pin))
            {
                user = _dataAccess.GetUser(pin);
            }

            if (user == null)
                MessageBox.Show("Invalid Pin");
            else
                MessageBox.Show($"welcome {user.FirstName}");
        }
    }
}
