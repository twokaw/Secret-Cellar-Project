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
    public partial class EditInventory : ManagedForm
    {
        public EditInventory()
        {
            InitializeComponent();
        }

        private void EditInventory_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtItemDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSupplyPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboProdClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAddToQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExistingQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLowStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSupplierPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMarkUp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalesPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBottleDeposite_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType().ToString() == "System.Windows.Forms.TextBox" || c.GetType().ToString() == "System.Windows.Forms.ComboBox")
                {
                    c.Text = "";
                }
            }
        }

        private void btnCalcMarkUp_Click(object sender, EventArgs e)
        {

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowseInv_Click(object sender, EventArgs e)
        {

        }
    }
}
