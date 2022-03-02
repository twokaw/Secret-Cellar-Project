using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SecretCellar.Settings_Panels
{
    public partial class PanTax : UserControl
    {
        readonly List<PaymentMethod> PayMethods;
        public PanTax()
        {
            InitializeComponent();
            lst_tax_list.DataSource = DataAccess.instance?.GetTax();
            PayMethods = DataAccess.instance?.GetPaymentMethods();
            lst_tax_list.DisplayMember = "TaxName";
        }

        private void lst_tax_list_SelectedIndexChanged(object sender, EventArgs e) {
            txt_tax_type_name.Text = ((Tax)lst_tax_list.SelectedItem).TaxName;
            txt_bottle_dep.Text = ((Tax)lst_tax_list.SelectedItem).BottleDeposit.ToString();
            txt_sales_tax.Text = ((Tax)lst_tax_list.SelectedItem).SalesTax.ToString();
            txt_local_tax.Text = ((Tax)lst_tax_list.SelectedItem).LocalSalesTax.ToString();

            List<Tax> taxes = DataAccess.instance?.GetTax();
            Tax currentTax = taxes.Find((tax) => tax.IdTax == ((Tax)lst_tax_list.SelectedItem).IdTax);

            List<Inventory> inventoryList = DataAccess.instance.GetInventory();
            List<Inventory> filteredInventoryList = inventoryList.FindAll((inventory) => inventory.IdTax == ((Tax)lst_tax_list.SelectedItem).IdTax);

            textBox_itemsUsingTax.Text = filteredInventoryList.Count + "";

            if (filteredInventoryList.Count == 0) { button_deleteTax.Enabled = true; }
            else { button_deleteTax.Enabled = false; }
        }


        private void btn_update_tax_Click(object sender, EventArgs e)
        {
            Double.TryParse(txt_bottle_dep.Text, out double deposit);
            Double.TryParse(txt_sales_tax.Text, out double salesTax);

            Tax i = new Tax
            {
                TaxName = txt_tax_type_name.Text.Trim(),
                BottleDeposit = deposit,
                SalesTax = salesTax,
                IdTax = ((Tax)lst_tax_list.SelectedItem).IdTax
            };

            DataAccess.instance.UpdateTax(i);
            lst_tax_list.DataSource = DataAccess.instance?.GetTax();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_tax_type_name.Text = "";
            txt_bottle_dep.Text = "";
            txt_sales_tax.Text = "";
            txt_local_tax.Text = "";
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Double.TryParse(txt_bottle_dep.Text, out double deposit);
            Double.TryParse(txt_sales_tax.Text, out double salesTax);
            Double.TryParse(txt_local_tax.Text, out double localTax);

            if (((List<Tax>)lst_tax_list.DataSource).FirstOrDefault(x => x.TaxName ==txt_tax_type_name.Text.Trim()) == null)
            {
                Tax i = new Tax
                {
                    TaxName = txt_tax_type_name.Text.Trim(),
                    BottleDeposit = deposit,
                    SalesTax = salesTax,
                    LocalSalesTax = localTax
                };

                DataAccess.instance.UpdateTax(i);
                lst_tax_list.DataSource = DataAccess.instance?.GetTax();
            }
        }

        private void txt_CashDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar);
        }

        private void btnSetDiscount_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txt_CashDiscount.Text, out decimal discount))
            {
                PaymentMethod p = PayMethods.FirstOrDefault(x => x.PayMethod == "CASH");

                p.PercentOffset = discount;
                DataAccess.instance.SetPaymentMethods(p);

                p = PayMethods.FirstOrDefault(x => x.PayMethod == "CHECK");

                p.PercentOffset = discount;
                DataAccess.instance.SetPaymentMethods(p);
            }
        }

		private void button_deleteTax_Click(object sender, EventArgs e) {

		}
	}
}
