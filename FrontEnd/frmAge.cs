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
    public partial class frmAge : ManagedForm
    {
        public frmAge()
        {
            InitializeComponent();
        }

        private void frmAge_Load(object sender, EventArgs e)
        {

        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show(test(textBox1.Text).ToString ());
        }

        private bool test(string barcode)
        {
            return true;
        }

    }
}
