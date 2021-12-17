using System;
using System.Windows.Forms;
using Shared;



namespace SecretCellar
{
    public partial class frmShipping : ManagedForm
    {
        private Transaction transaction = null;
        public frmShipping(Transaction t)
        {
            InitializeComponent();
            this.transaction = t; 
        }



        /////////////////////////
        //ADD THE SHIPPING CHARGE
        /////////////////////////
        private void button_AddCharge_Click(object sender, EventArgs e) {
            if (double.TryParse(txtCharge.Text, out double d)) {
                transaction.Shipping = d;
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
