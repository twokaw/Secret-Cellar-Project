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

namespace SecretCellar.Settings_Panels
{
    public partial class PanTypes : UserControl
    {
        public PanTypes()
        {
            InitializeComponent();
            lstTypes.DataSource = DataAccess.instance?.GetInventoryType();
            cbx_tax.DataSource = DataAccess.instance?.GetTax();
            lstTypes.DisplayMember = "TypeName";
            cbx_tax.DisplayMember = "TaxName";
            DataAccess.instance?.GetDiscount()?.ForEach(x => chk_lst_discount.Items.Add(x.DiscountName));
        }

        private void lstTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

            txt_bottleDep.Text = ((InventoryType)lstTypes.SelectedItem).BottleDeposit.ToString();
            txt_salesTax.Text = ((InventoryType)lstTypes.SelectedItem).SalesTax.ToString();
            txt_localTax.Text = ((InventoryType)lstTypes.SelectedItem).LocalSalesTax.ToString();
            txt_typename.Text = ((InventoryType)lstTypes.SelectedItem).TypeName;
            
            for (int i = 0; i < chk_lst_discount.Items.Count; i++)
                chk_lst_discount.SetItemChecked(i, ((InventoryType)lstTypes.SelectedItem).Discount.FirstOrDefault(x => x.DiscountName == chk_lst_discount.Items[i].ToString()) != null);
        }

        private void btn_type_clear_Click(object sender, EventArgs e)
        {
            txt_typename.Text = "";
            cbx_tax.SelectedItem = 0;
            txt_typename.Focus();
        }

        private void btn_new_type_Click(object sender, EventArgs e)
        {
            if (DataAccess.instance.GetInventoryType(lbl_typename.Text) == null)
            {
                InventoryType i = new InventoryType();
                i.TypeName = lbl_typename.Text.Trim();
                i.IdTax = ((Tax)cbx_tax.SelectedItem).IdTax;
                //i.BottleDeposit = Convert.ToDouble(txt_bottleDep.Text);
                //i.SalesTax = Convert.ToDouble(txt_salesTax.Text);
                //i.LocalSalesTax = Convert.ToDouble(txt_localTax.Text);
                DataAccess.instance.UpdateInventoryType(i);
            }
        }

        private void btn_update_type_Click(object sender, EventArgs e)
        {
            InventoryType i = (InventoryType)lstTypes.SelectedItem;
            i.TypeName = txt_typename.Text.Trim();
            i.IdTax = ((Tax)cbx_tax.SelectedItem).IdTax;
            

            // TODO: Update Discount
            DataAccess.instance.UpdateInventoryType(i);
        }
    }
}
