using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SecretCellar.Settings_Panels
{
    public partial class PanReports : ManagedPanel {
        private class Tuple
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        private string SalesTotal = "";
        private string SalesTypes = "";
        private string SalesItems = "";
        public PanReports()
        {
            InitializeComponent();
        }

        private class Sold {
            public static int maxlength { get; set; } = 0 ;
            public string Name { get; set; }
            public uint Qty { get; set; }
            public double Price { get; set; }
            public override string ToString() { return $"{Name.PadRight(maxlength)}\t{Qty}\t{Price:C}"; }
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            List<Transaction> transactions = DataAccess.instance.GetTransactions(dtp_start.Value.Date, dtp_end.Value.Date.AddDays(1));
            Dictionary<string, Sold> items = new Dictionary<string, Sold >();
            // Dictionary<string, double> vendorSales = new Dictionary<string, double>();
            Dictionary<string, double> typeSales = new Dictionary<string, double>();
            Dictionary<string, double> paymentTypes = new Dictionary<string, double>();
            double totalSales = 0.0;
            double costSales = 0.0;
            double bottleDeposit = 0.0;
            double netSales = 0.0;
            double tax = 0.0;
            double localtax = 0.0;
            string Itemtype;
            Sold.maxlength = 0;

            foreach (Transaction t in transactions)
            {
                totalSales += t.Total;

                foreach (Payment p in t.Payments)
                {
                    if (paymentTypes.ContainsKey(p.Method))
                        paymentTypes[p.Method] += p.Amount;
                    else
                        paymentTypes.Add(p.Method, p.Amount);
                }

                foreach (Item i in t.Items)
                {

                    totalSales += t.ItemPriceTotal(i);
                    bottleDeposit += t.Bottle_deposit;
                    netSales += t.ItemPrice(i) - i.SupplierPrice;
                    tax += t.ItemTax(i);
                    localtax += t.ItemLocalTax(i);
                    costSales += i.SupplierPrice;

                    Itemtype = i.ItemType;
                    if (t.TaxExempt)
                        Itemtype += " Wholesale";


                    if (!typeSales.ContainsKey(Itemtype))
                        typeSales.Add(Itemtype, t.ItemPriceTotal(i));
                    else
                        typeSales[Itemtype] += t.ItemPriceTotal(i);

                    if (items.Keys.Contains(i.Barcode))
                    {
                        items[i.Barcode].Price += i.AdjustedTotal;
                        items[i.Barcode].Qty += i.NumSold;
                    }
                    else
                    {
                        Sold.maxlength = Math.Max(Sold.maxlength, i.Name.Length);
                        items.Add(i.Barcode, new Sold
                        {
                            Name = i.Name,
                            Price = i.AdjustedTotal,
                            Qty = i.NumSold
                        });
                    }
                }
            }

            SalesTotal = $@"Total Sales:   {totalSales:C}
Net Sales:     {netSales:C}
Sales Tax:     {tax:C}
Local Tax:     {localtax:C}
Gross Cost:    {costSales:C}
Bottle Deposit:{bottleDeposit:C}{"\r\n\r\n"}";

            List<Tuple> row = new List<Tuple>();
            row.Add(new Tuple { Name = "Total Sales", Value = $"{totalSales:C}" });
            row.Add(new Tuple { Name = "Net Sales", Value = $"{netSales:C}" });
            row.Add(new Tuple { Name = "Sales Tax", Value = $"{tax:C}" });
            row.Add(new Tuple { Name = "Local Tax", Value = $"{localtax:C}" });
            row.Add(new Tuple { Name = "Gross Cost", Value = $"{costSales:C}" });
            row.Add(new Tuple { Name = "Bottle Deposit", Value = $"{bottleDeposit:C}" });

            SalesTotal = "";
            foreach (KeyValuePair<string, double> kv in typeSales)
            {
                SalesTotal += $"{$"{kv.Key}:",-7}\t{kv.Value:C}\r\n";
                row.Add(new Tuple { Name = Char.ToUpper(kv.Key[0]) + kv.Key.Substring(1).ToLower(), Value = $"{kv.Value:C}" });
            }
            DgvTotal.DataSource = row;

            SalesTypes = "";
            List <Tuple> sales = new List<Tuple>();
            foreach (KeyValuePair<string, double> kv in paymentTypes)
            {
                SalesTypes += $"{$"{kv.Key}:",-7}\t{kv.Value:C}\r\n";
                sales.Add(new Tuple { Name = Char.ToUpper(kv.Key[0]) + kv.Key.Substring(1).ToLower(), Value = kv.Value.ToString("C") });
            }

            SalesItems = string.Join("\r\n", items.Values);

            dgvTypes.DataSource = sales;
            DgvItems.DataSource = items.Values.ToList();
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

        private void BtnInventoryCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SalesItems);
        }

        private void BtnTotalCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SalesTotal);
        }

        private void BtnInvTypeCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SalesTypes); 
        }
    }
}
