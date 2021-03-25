using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
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

            TxtSalesTotals.Text = $@"Total Sales:{"\t"}{totalSales:C}
Net Sales:   {"\t"}{netSales:C}
Sales Tax:   {"\t"}{tax:C}
Local Tax:   {"\t"}{localtax:C}
Gross Cost:  {"\t"}{costSales:C}
Bottle Deposit:{"\t"}{bottleDeposit:C}";

            TxtSalesInvType.Text = "";
            foreach (KeyValuePair<string, double> kv in typeSales)
                TxtSalesInvType.Text += $"{$"{kv.Key}:",-7}\t{kv.Value:C}\r\n";
            
            TxtSalesVendor.Text = GetInv();
        }

        public List<Inventory> Inv = null;

        private class TypeSummary
        {
            public string Name = "";
            public double Qty = 0.0;
            public double Cost = 0.0;
            public double Price = 0.0;
            public override string ToString()
            {
                return $"{Name,-13}\t{Qty}\t{Cost:C}\t{Price:C}";
            }
            public static string Header
            {
                get { return "Name        \tQty\tCost\tPrice"; }
            }
        }
        private string GetInv()
        {
            List<TypeSummary> typeSum = new List< TypeSummary> ();
            TypeSummary totalSum = new TypeSummary { Name = "TOTAL" }; 
            
            if (Inv == null)
            {
                Inv = DataAccess.instance.GetInventory();
            }
            TypeSummary v;
            foreach (Inventory i in Inv)
            {
                v = typeSum.FirstOrDefault(x => x.Name == i.ItemType);

                if (v == null) 
                    typeSum.Add(new TypeSummary
                    {
                        Name = i.ItemType,
                        Qty = i.Qty,
                        Cost = i.SupplierPrice * i.Qty,
                        Price = i.Price * i.Qty
                    });
                else
                {
                    v.Qty += i.Qty;
                    v.Cost = i.SupplierPrice * i.Qty;
                    v.Price = i.Price * i.Qty;
                }
                totalSum.Qty += i.Qty;
                totalSum.Cost += i.SupplierPrice * i.Qty;
                totalSum.Price = i.Price * i.Qty;
            }

            string result = TypeSummary.Header;
            typeSum.ForEach(x => result += $"\r\n{x}");
            result += $"\r\n{totalSum}";

            return result;
            
        }
    }
}
