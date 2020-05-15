using SecretCellar;
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
    public partial class frmDryCleaning : Form
    {
        private Transaction dryClean = null;
        public frmDryCleaning()
        {
            InitializeComponent();
        }

        private void btnAddCharge_Click(object sender, EventArgs e)
        {
            addCharge();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private decimal addCharge()
        {
           // if (decimal.TryParse(txtPercentTotalSale.Text, out d))
                dryClean.Subtotal += decimal.Parse(txtCharge.Text);
            return dryClean.Subtotal;
        }

        private void txtCharge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
