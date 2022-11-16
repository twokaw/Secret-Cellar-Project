using System;
using System.Windows.Forms;
using Shared;
using System.Collections.Generic;
using System.Linq;

namespace SecretCellar
{
    public partial class frmCustom : ManagedForm
    {
        private readonly Transaction customItem = null;
        private readonly List<InventoryType> types = null;

        public frmCustom(Transaction transaction, string itemType = "", string description = "")
        {
            InitializeComponent();
            customItem = transaction;
            txt_descript.Focus();
            touchKeyPad1.Target = txt_charge_am;
            types = DataAccess.instance.GetInventoryType();
            cboType.DataSource = types;
            if (itemType != "")
                cboType.SelectedItem = types.First(x => x.TypeName == itemType);

            txt_descript.Text = description;
        }

        /// <summary>
        /// ADD THE CHARGE TO THE TRANSACTION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_AddCharge_Click(object sender, EventArgs e) {

            if (txt_charge_am.Value > 0) 
            {
                Item i = Transaction.ConvertInvtoItem(DataAccess.instance.GetItem("Custom"));
                i.Price = txt_charge_am.Value;
                i.Name = txt_descript.Text;
                i.ItemType = cboType.Text;
                i.TypeID = types.First(x => x.TypeName == cboType.Text).TypeId;
                i.QtySold = 1;

                customItem.Items.Add(i);

                this.Close();
            }
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
