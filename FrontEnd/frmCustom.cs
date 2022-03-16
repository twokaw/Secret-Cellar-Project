using System;
using System.Windows.Forms;
using Shared;

namespace SecretCellar
{
    public partial class frmCustom : ManagedForm
    {
        private readonly Transaction customItem = null;

        public frmCustom(Transaction transaction)
        {
            InitializeComponent();
            customItem = transaction;
            txt_descript.Focus();
            touchKeyPad1.Target = txt_charge_am;

        }

        /// <summary>
        /// ADD THE CHARGE TO THE TRANSACTION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_AddCharge_Click(object sender, EventArgs e) {
            if (double.TryParse(txt_charge_am.Text, out double d)) {
                Item i = Transaction.ConvertInvtoItem(DataAccess.instance.GetItem("Custom"));
                i.Price = d;
                i.Name = txt_descript.Text;
                i.QtySold = 1;

                customItem.Items.Add(i);
            }

            this.Close();
        }

        /// <summary>
        /// Close Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Cancel_Click(object sender, EventArgs e) {
            this.Close();
		}

        private void txtCashAmt_Enter(object sender, EventArgs e)
        {
            touchKeyPad1.Target = (TextBox)sender;
        }
    }
}
