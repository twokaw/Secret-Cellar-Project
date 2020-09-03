using System;
using System.Drawing.Printing;
using Shared;

namespace NCR_Printer
{
    public class Receipt: PrintDoc
    {
        public static PrintLayout DefaultLayout { get; set; }

        private readonly Transaction transaction;

        public Receipt(Transaction trans):this(trans, DefaultLayout) { }

        public Receipt(Transaction trans, PrintLayout layout): base(layout)
        {
            Layout = layout;
            transaction = trans;
            if (DefaultLayout == null)
                DefaultLayout = layout;
        }

        // Event handler for printing receipt
       public override void PrintPage(object sender, PrintPageEventArgs e)
        {
            // Initialize printing stuff
            SetupPage(e);

            PrintImage(Layout.Logo);

            // Print InvoiceID Barcode
            if (Layout.BarcodeFont != null)
                PrintText($"*{transaction.InvoiceID}*", Layout.BarcodeFont, true, TextAlignment.Center);

            // Print Header
            PrintHeaderFooter(Layout.Header);

            // Print InvoiceID
            PrintText($"Invoice #: {transaction.InvoiceID}");

            // Print RegisterID
            if(transaction.RegisterID > 0)
                PrintText($"Register ID: {transaction.RegisterID}");

            // Print Location
            if(!string.IsNullOrEmpty(transaction.Location))
                PrintText($"Location: {transaction.Location}", true, TextAlignment.Right);

            // Date and time
            PrintText("Date and Time:",false);
            PrintText($"{transaction.TransactionDateTime: M/dd/yy H:mm}", true,TextAlignment.Right);

            // Print Separator
            PrintHorizontalLine();

            // Print Items
            foreach (Item item in transaction.Items)
            {
                PrintText($"{item.Name.Substring(0, Math.Min(item.Name.Length, Layout.DesctiptionWidth - item.DiscountText.Length))}{item.DiscountText}", false);
                PrintText($"{item.Price:C}", true, TextAlignment.Right);
            }

            // Print Separator
            PrintHorizontalLine();

            // Print subtotal
            PrintText("SubTotal:", false);
            PrintText($"{transaction.Subtotal:C}", true, TextAlignment.Right);


            if (transaction.Bottle_deposit > 0)
            {
                // Print subtotal
                PrintText("Bottle Deposit:", false);
                PrintText($"{transaction.Bottle_deposit:C}", true, TextAlignment.Right);
            }

            if (transaction.DiscountTotal > 0)
            {
                // Print subtotal
                PrintText("Discount:", false);
                PrintText($"{transaction.DiscountTotal:C}", true, TextAlignment.Right);
            }

            // Print tax
            PrintText("Tax:", false);
            PrintText($"{transaction.Tax:C}", true, TextAlignment.Right);

            // Print total
            PrintText("Total:", false);
            PrintText($"{transaction.Total:C}", true, TextAlignment.Right);

            // Print Separator
            PrintHorizontalLine();

            // Print # of items
            PrintText($"# of Items: {transaction.Items.Count}");

            // Print Payment Method
            bool first = true;
            double payment = 0;
            foreach(Payment p in transaction.Payments)
            {
                if (first)
                    PrintText($"Payment: {p.Method}{(string.IsNullOrWhiteSpace(p.Number) ? "" : $"({p.Number})")}: {p.Amount:C}");
                else
                    PrintText($"         {p.Method}{(string.IsNullOrWhiteSpace(p.Number) ? "" : $"({p.Number})")}: {p.Amount:C}");
                
                first = false;
                payment += p.Amount;
            }

            if(payment > transaction.Total)
                PrintText($"         Change: {payment - transaction.Total:C}");

            //Print footer
           PrintHeaderFooter($"{Layout.Footer}\n\n ");
        }
    }
}
