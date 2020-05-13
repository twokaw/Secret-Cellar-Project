using SecretCellar.models;
using System;
using System.Windows.Forms;
using WebApi.Models;

namespace SecretCellar
{
    public partial class frmLogin : Form
    {
        private DataAccess _dataAccess;
        public frmLogin()
        {
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

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EmployeeModel user = null;
            if (txtPin.Text == "")
            {
                user = _dataAccess.GetEmployee(0);
            }
            else if (int.TryParse(txtPin.Text, out int pin))
            {
                user = _dataAccess.GetEmployee(pin);
            }

            if (user == null)
                MessageBox.Show("Invalid Pin");
            else
            {
                MessageBox.Show($"welcome {user.FirstName}");
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }

        }
    }
}