using System;
using System.Collections.Generic;
using System.Drawing;
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
        private readonly Supplier supplier;
        private readonly List<Inventory> inventory;
        public PurchaseOrder(Supplier supplier, List<Inventory> inventories , PrintLayout letter, Margins margins) : base(letter)
        {
            

            if (LetterLayout == null || letter != null)
                LetterLayout = letter;
                this.supplier = supplier;
                this.inventory = inventories;
                this.margins = margins;
        }

        public PurchaseOrder(Supplier supplier, List<Inventory> inventories) : this(supplier, inventories, LetterLayout, new Margins (100,100,100,100)){}


        public override void PrintPage(object sender, PrintPageEventArgs e)
        {
            // Initialize printing stuff
            
            SetupPage(e);
            float y = cursor.Y;
            Font potitle = new Font("Arial", 12, FontStyle.Bold);
            PrintImage(Layout.Logo, (float)0.4,TextAlignment.Left);
            this.cursor.Y = (cursor.Y - y)/2;
            PrintText($"Purchase Order", potitle, true, TextAlignment.Center);
            PrintText("", true);
            // Print Header
            PrintHeaderFooter(Layout.Header);

            string bcode = "Barcode";
            string name = "Name";
            string price = "Price";
            string oqty = "Order Qty";
            string qtyrec = "Received Qty";

            PrintText("", true);
            PrintText("", true);

            PrintText($"{supplier.Name}", true,TextAlignment.Center);
            if(!string.IsNullOrWhiteSpace (supplier.Phone))
                PrintText($"{supplier.Phone}", true, TextAlignment.Center);


            
            // Date and time

            PrintText($"Date: {DateTime.Now:M/dd/yy}", true, TextAlignment.Right);
   
            PrintHorizontalLine();

            //PrintText($"{bcode,6} {name,35} {price,40}{oqty,25}{qtyrec,40}");
            
            PrintText(bcode,5);           
            PrintText(name,200);            
            PrintText(price,550);           
            PrintText(oqty,650);            
            PrintText(qtyrec,750,true);
            //PrintText($"\t\t\t\t\t Barcode  \t\t\t\t\t Name  \t\t\t\t\t Price  \t\t\t\t\t Order Qty  \t\t\t\t\t Qty Received",true);
            double total = 0;
            cursor.X = 0;
            PrintHorizontalLine();

            foreach (Inventory item in inventory)
            {
                PrintText(item.Barcode, 5);
                PrintText(item.Name, 200);
                PrintText(item.Price.ToString(), 550);
                PrintText(item.OrderQty.ToString(),680,true);
                PrintText($"*{item.Barcode}*", Layout.BarcodeFont, 5, true);
                total += item.OrderQty * item.Price;
                //PrintText($"{item.Price:C}", true, TextAlignment.Right);
            }

            cursor.X = 0;
            PrintHorizontalLine();
            cursor.X = 0;
            PrintText($"Total: {total:C}", true, TextAlignment.Right);
        }
    }
}
