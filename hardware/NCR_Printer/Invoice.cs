using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using Shared;


namespace NCR_Printer {
    public class Invoice : PrintDoc {
        private readonly Transaction _invoice;



        public Invoice(Transaction invoice, PrintLayout layout) : base(layout) {
            _invoice = invoice;
        }


        public override void PrintPage(object sender, PrintPageEventArgs e) {
            SetupPage(e);
            float y = cursor.Y;
            Font titleFont = new Font("Arial", 12, FontStyle.Bold);

            //HEADER
            PrintImage(Layout.Logo, (float)0.4, TextAlignment.Left);
            this.cursor.Y = (cursor.Y - y) / 2;
            PrintText($"Invoice #{_invoice.InvoiceID}", titleFont, true, TextAlignment.Center);
            PrintText("", true);
            PrintHeaderFooter(Layout.Header);

            PrintText("", true);
            PrintText("", true);

            //INVOICE ID AND CUSTOMER NAME
            PrintText($"{_invoice.CustomerName}", 5);

            //DATE AND TIME
            cursor.X = 0;
            PrintText($"{DateTime.Now:M/dd/yy}", -5, true, TextAlignment.Right);
            PrintHorizontalLine();

            //TABLE HEADERS
            PrintText("Barcode", titleFont, 5);
            PrintText("Item", titleFont, 200);
            PrintText("Price", titleFont, 550);
            PrintText("Number Sold", titleFont, 630);
            cursor.X = 0;
            PrintText("Total", titleFont, -5, true, TextAlignment.Right);

            double total = 0;
            cursor.X = 0;
            PrintHorizontalLine();

            //TABLE
            foreach (Item item in _invoice.Items) {
                PrintText(item.Barcode, 5);
                PrintText(item.Name, 200);
                PrintText(item.Price.ToString(), 550);
                PrintText(item.NumSold.ToString(), 630);
                cursor.X = 0;
                PrintText((item.Price * item.NumSold).ToString(), -5, true, TextAlignment.Right);
                total += item.Price * item.NumSold;
            }

            cursor.X = 0;
            PrintHorizontalLine();

            cursor.X = 0;
            PrintText($"Total: {total:C}", -5, true, TextAlignment.Right);

            double amountPaid = GetAmountPaid();
            cursor.X = 0;
            
            //PrintText($"Total Payment: ", titleFont, Layout.Width-MeasureString($"{amountPaid:C}", Layout.TextFont, StringFormat.GenericDefault).Width-50);
            PrintText($"{amountPaid:C}", -5, true, TextAlignment.Right);
            
            double remaining = total-amountPaid;

            if (remaining > 0) {
                cursor.X = 0;
                PrintText($"Remaining: {remaining:C}", -5, true, TextAlignment.Right);
            }
        }


        /// <summary>
        /// Gets the amount paid for the invoice.
        /// </summary>
        /// <returns></returns>
        private double GetAmountPaid() {
            double amountPaid = 0;

            foreach (Payment payment in _invoice.Payments) {
                amountPaid += payment.Amount;
            }

            return amountPaid;
        }
    }
}
