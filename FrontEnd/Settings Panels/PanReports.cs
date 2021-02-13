using Shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SecretCellar.Settings_Panels
{
    public partial class PanReports : UserControl
    {
        public PanReports()
        {
            InitializeComponent();
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            List<Transaction> transactions = DataAccess.instance.GetTransactions(dtp_start.Value, dtp_end.Value);

            // Dictionary<string, double> vendorSales = new Dictionary<string, double>();
            Dictionary<string, double> typeSales = new Dictionary<string, double>();
            double totalSales = 0.0;
            double costSales = 0.0;
            double bottleDeposit = 0.0;
            double netSales = 0.0;
            double tax = 0.0;
            double localtax = 0.0;

            foreach (Transaction t in transactions)
            {
                totalSales += t.Total;
                foreach (Item i in t.Items)
                {
                    totalSales += t.ItemPriceTotal(i);
                    bottleDeposit += t.Bottle_deposit;
                    netSales += t.ItemPrice(i) - i.SupplierPrice;
                    tax += t.ItemTax(i);
                    localtax += t.ItemLocalTax(i);
                    costSales += i.SupplierPrice;

                    if (!typeSales.ContainsKey(i.ItemType))
                        typeSales.Add(i.ItemType, t.ItemPriceTotal(i));
                    else
                        typeSales[i.ItemType] += t.ItemPriceTotal(i);
                }
            }

            /*
            txt_SalesTotal.Text = totalSales.ToString("C");
            txt_SalesNet.Text =netSales.ToString("C");
            txt_SalesTax.Text = tax.ToString("C");
            txt_SalesLocalTax.Text = localtax .ToString("C");
            txt_SalesCost.Text = costSales.ToString("C");
            txt_SalesBottleDeposit.Text = bottleDeposit.ToString("C");
            txt_SalesTotal.Text = totalSales.ToString("C");
            */


            TxtSalesTotals.Text = $@"Total Sales: {totalSales:C}
            Net Sales: {netSales:C}
            Sales Tax: {tax:C}
            Local Sales Tax: {localtax:C}
            Cost: {costSales:C}
            Bottle Deposit: {bottleDeposit:C}";

            TxtSalesInvType.Text = "";
            foreach (KeyValuePair<string, double> kv in typeSales)
                TxtSalesInvType.Text += $"{kv.Key}: {kv.Value }\r\n";
            /*
             transaction.Subtotal.ToString("C");
            txt_transBTLDPT.Text = transactionBottleDeposit.ToString("C");
            txt_itemTotal.Text = transaction.Subtotal.ToString("C");
            txt_transTax.Text = (transaction.Tax + transaction.LocalTax).ToString("C");
            txt_transDiscount.Text = transaction.DiscountTotal.ToString("C");
            txt_TransTotal.Text = transaction.Total.ToString("C");
            txt_Ship.Text = transaction.Shipping.ToString("C");

            */
        }


    }
}
