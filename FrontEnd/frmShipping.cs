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
using Shared;

namespace SecretCellar
{
    public partial class frmShipping : ManagedForm
    {
        private Transaction shipping = null;
        public frmShipping(Transaction transaction)
        {
            InitializeComponent();
            shipping = transaction; 
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
        private void addCharge()
        {
            if (double.TryParse(txtCharge.Text, out double d))
                shipping.Shipping = d;
        }

        private void frmShipping_Load(object sender, EventArgs e)
        {

        }
    }
}
