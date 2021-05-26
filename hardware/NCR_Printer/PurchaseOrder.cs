using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace NCR_Printer
{
    public class PurchaseOrder : PrintDoc
    {
        public static PrintLayout LetterLayout {get; set;}
        private Supplier supplier;
        private List<Inventory> inventory;
        string total;
        Margins margins = new Margins(100, 100, 100, 100);
        public PurchaseOrder(Supplier supplier, List<Inventory> inventories , PrintLayout letter) : base(letter)
        {
            

            if (LetterLayout == null || letter != null)
                LetterLayout = letter;
            this.supplier = supplier;
            this.inventory = inventories;
        }

        public PurchaseOrder(Supplier supplier, List<Inventory> inventories) : this(supplier, inventories, LetterLayout)
        {


        }


        public override void PrintPage(object sender, PrintPageEventArgs e)
        {
            // Initialize printing stuff
            
            SetupPage(e);
            margins.Top = 100;
            margins.Left = 50;
            margins.Right = 50;
            margins.Bottom = 100;

            PrintImage(Layout.Logo);
            // Print Header
            PrintHeaderFooter(Layout.Header);

            PrintText($"{supplier.Name}", true,TextAlignment.Center);
            PrintText($"{supplier.Phone}", true, TextAlignment.Center);

            // Date and time

            PrintText($"Date: {DateTime.Now:M/dd/yy}", true, TextAlignment.Right);

            PrintText($"\t\t\t\t\t Barcode  \t\t\t\t\t Name  \t\t\t\t\t Price  \t\t\t\t\t Order Qty  \t\t\t\t\t Qty Received");
            double total = 0;

            foreach (Inventory item in inventory)
            {
                
                PrintText($"\t\t\t\t\t{item.Barcode}  \t\t\t\t\t{item.Name}  \t\t\t\t\t{item.Price}  \t\t\t\t\t{item.OrderQty}", false);
                total += item.OrderQty * item.Price;
                PrintText($"{item.Price:C}", true, TextAlignment.Right);
            }

            
            PrintText($"Total: {total:C}", true, TextAlignment.Right);
        }
    }
}
