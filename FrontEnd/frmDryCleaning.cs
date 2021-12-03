using Shared;
using System;
using System.Windows.Forms;

namespace SecretCellar
{
    public partial class frmDryCleaning : ManagedForm
    {
        private Transaction transaction = null;
        public frmDryCleaning(Transaction t)
        {
            InitializeComponent();
            this.transaction = t;
            txtCharge.Focus();
        }


        ////////////////////////////////
        //ADD THE WINDOW CLEANING CHARGE
        ////////////////////////////////
        private void button_AddCharge_Click(object sender, EventArgs e) {
            if (double.TryParse(txtCharge.Text, out double d)) {
                Item i = Transaction.ConvertInvtoItem(DataAccess.instance.GetItem("DRY CLEANING"));
                i.Price = d;
                transaction.Items.Add(i);
            }

            this.Close();
        }


        //////////////////
        //CLOSE THE WINDOW
        //////////////////
        private void button_Cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void txtCashAmt_Enter(object sender, EventArgs e)
        {
            touchKeyPad1.Target = (TextBox)sender;
        }
    }
}
