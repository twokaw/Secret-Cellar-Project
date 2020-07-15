using SecretCellar;
using Shared;
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
        public frmDryCleaning(Transaction transaction)
        {
            InitializeComponent();
            dryClean = transaction;
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
            {
                Item i = DataAccess.ConvertInvtoItem(DataAccess.instance.GetItem("DRY CLEANING"));
                i.Price = d;
                dryClean.Items.Add(i);
            }


        }

        private void txtCharge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
