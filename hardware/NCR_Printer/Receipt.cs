using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using Shared;

namespace NCR_Printer
{
    public class Receipt
    {
        public Image Logo { get; set; } = null;
        public string Header { get; set; } = null;
        public string Footer { get; set; } = null;

        private PrintDocument rcpt = null;
        private Transaction transaction;
        /*
        public Receipt(uint InvoiceID,
                           uint RegisterID,
                           DateTime TransactionDateTime,
                           string Location,
                           List<Item> Items,
                           double Discount,
                           double Subtotal,
                           double Tax,
                           double Total,
                           bool TaxExempt,
                           string PayMethod,
                           string PayNum,
                           double LocalTax,
                           uint EmployeeID,
                           uint CustomerID,
                           string header,
                           string footer,
                           Image logo) 
            : base(InvoiceID, RegisterID, TransactionDateTime, Location, Items, Discount, TaxExempt,
                   new List<Payment>(){ new Payment() { Method = PayMethod, Number = PayNum, Amount = 0.0 }}, EmployeeID, CustomerID)
        {
            this.Header = header;
            this.Footer = footer;
            this.Logo = logo;   
        }*/

        public Receipt(Transaction trans, string header, string footer, Image logo)
        //: this(trans.InvoiceID,
        //     trans.RegisterID,
        //     trans.TransactionDateTime,
        //     trans.Location,
        //     trans.Items,
        //     trans.Discount,
        //     trans.Subtotal,
        //     trans.Tax,
        //     trans.Total,
        //     trans.TaxExempt,
        //     trans.PayMethod,
        //     trans.PayNum,
        //     trans.LocalTax,
        //     trans.EmployeeID,
        //     trans.CustomerID,
        //     header,
        //     footer,
        //     logo)
        {
            this.transaction = trans;
            this.Header = header;
            this.Footer = footer;
            this.Logo = logo;
        }

        public string PageType { get; set; } = "receipt";
        public int Width { get; set; } = 280;
        public int DesctiptionWidth { get; set; } = 29;
        public string BarcodeFontName { get; set; } = ""; //"Free 3 of 9";
        public float BarcodeFontSize { get; set; } = 36;

        public string FontName { get; set; } = "Arial";
        public float  FontSize { get; set; } = 11;

        public void print()
        {
            // Open Cash drawer
          //  if(drawer != null) drawer.OpenDrawer();

            // Print receipt
            rcpt = new PrintDocument();
            rcpt.DefaultPageSettings.PaperSize = new PaperSize(PageType, Width, 0);
            rcpt.PrintPage += new PrintPageEventHandler(rcpt_PrintPage);
            rcpt.Print();
        }

        // Print the text with the given alignment at the cursor and return an advanced cursor based on newLine
        RectangleF printText(string text, bool newLine, Graphics g, Font font, Brush brush, RectangleF cursor, StringFormat align, float lSpacing)
        {
            g.DrawString(text, font, brush, cursor, align);
            if(newLine) cursor.Y += font.Height + lSpacing;
            return cursor;
        }

        // Print a horizontal line at the cursor and return an advanced cursor
        RectangleF printHorizontalLine(Graphics g, Font font, Pen pen, RectangleF cursor, float lSpacing)
        {
            cursor.Y += (font.Height + lSpacing) / 2;
            g.DrawLine(pen, cursor.X, cursor.Y, cursor.X + cursor.Width, cursor.Y);
            cursor.Y += (font.Height + lSpacing) / 2;
            return cursor;
        }

        // Print the header/footer text with the given alignment at the cursor and return an advanced cursor.
        // This handles newline characters and wrapping of arbitrary length lines.
        RectangleF printHeaderFooter(string text, Graphics g, Font font, Brush brush, RectangleF cursor, StringFormat align, float lSpacing)
        {
            // Figure out the box we want to draw in
            SizeF wrappedSize = g.MeasureString(text, font, (int)cursor.Width, align);
            wrappedSize.Width = cursor.Width; // We just wanted height from MeasureString
            RectangleF wrappedCursor = new RectangleF(cursor.Location, wrappedSize);
            // Print using box
            g.DrawString(text, font, brush, wrappedCursor, align);
            cursor.Y += wrappedSize.Height + lSpacing;
            return cursor;
        }

        // Event handler for printing receipt
        void rcpt_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Initialize printing stuff
            Graphics g = e.Graphics;

            Font font = new Font(FontName, FontSize);
            Font barcodeFont = new Font(BarcodeFontName, BarcodeFontSize); //Will default to Sans Serif if not installed

            float lSpacing = 5F;
            Brush brush = Brushes.Black;
            Pen pen = new Pen(brush);

            StringFormat leftAlign = new StringFormat() { Alignment = StringAlignment.Near };
            StringFormat centerAlign = new StringFormat() { Alignment = StringAlignment.Center };
            StringFormat rightAlign = new StringFormat() { Alignment = StringAlignment.Far };

            RectangleF cursor = new RectangleF(e.PageBounds.X, e.PageBounds.Y, e.PageBounds.Width, font.Height);

            // TODO : Scale image to rectangle
            // Print Logo
            g.DrawImage(Logo, cursor.Width / 2 - Logo.Width / 2, cursor.Top);
            cursor.Y += Logo.Height + lSpacing;

            // Print InvoiceID Barcode
            if(!string.IsNullOrWhiteSpace(BarcodeFontName) )
                cursor = printText($"*{transaction.InvoiceID}*", true, g, barcodeFont, brush, cursor, centerAlign, lSpacing);

            // Print Header
            cursor = printHeaderFooter(Header, g, font, brush, cursor, centerAlign, lSpacing);

            // Print InvoiceID
            cursor = printText($"Invoice #: {transaction.InvoiceID}", true, g, font, brush, cursor, leftAlign, lSpacing);

            // Print RegisterID
            cursor = printText($"Register ID: {transaction.RegisterID}", false, g, font, brush, cursor, leftAlign, lSpacing);

            // Print Location
            cursor = printText($"Location: {transaction.Location}", true, g, font, brush, cursor, rightAlign, lSpacing);

            // Date and time
            cursor = printText("Date and Time:", false, g, font, brush, cursor, leftAlign, lSpacing);
            cursor = printText($"{transaction.TransactionDateTime: M/dd/yy H:mm}", true, g, font, brush, cursor, rightAlign, lSpacing);

            // Print Separator
            cursor = printHorizontalLine(g, font, pen, cursor, lSpacing);

            // Print Items
            foreach (Item item in transaction.Items)
            {
                cursor = printText($"{item.Name.Substring(0, Math.Min(item.Name.Length, DesctiptionWidth - item.DiscountText.Length))}{item.DiscountText}", false, g, font, brush, cursor, leftAlign, lSpacing);
                cursor = printText($"{item.Price:C}", true, g, font, brush, cursor, rightAlign, lSpacing);
            }

            // Print Separator
            cursor = printHorizontalLine(g, font, pen, cursor, lSpacing);

            // Print subtotal
            cursor = printText("SubTotal:", false, g, font, brush, cursor, leftAlign, lSpacing);
            cursor = printText($"{transaction.Subtotal:C}", true, g, font, brush, cursor, rightAlign, lSpacing);


            if (transaction.Bottle_deposit > 0)
            {
                // Print subtotal
                cursor = printText("Bottle Deposit:", false, g, font, brush, cursor, leftAlign, lSpacing);
                cursor = printText($"{transaction.Bottle_deposit:C}", true, g, font, brush, cursor, rightAlign, lSpacing);
            }

            if (transaction.DiscountTotal > 0)
            {
                // Print subtotal
                cursor = printText("Discount:", false, g, font, brush, cursor, leftAlign, lSpacing);
                cursor = printText($"{transaction.DiscountTotal:C}", true, g, font, brush, cursor, rightAlign, lSpacing);
            }

            // Print tax
            cursor = printText("Tax:", false, g, font, brush, cursor, leftAlign, lSpacing);
            cursor = printText($"{transaction.Tax:C}", true, g, font, brush, cursor, rightAlign, lSpacing);

            // Print total
            cursor = printText("Total:", false, g, font, brush, cursor, leftAlign, lSpacing);
            cursor = printText($"{transaction.Total:C}", true, g, font, brush, cursor, rightAlign, lSpacing);

            // Print Separator
            cursor = printHorizontalLine(g, font, pen, cursor, lSpacing);

            // Print # of items
            cursor = printText($"# of Items: {transaction.Items.Count}", true, g, font, brush, cursor, leftAlign, lSpacing);

            bool first = true;
            foreach(Payment p in transaction.Payments)
            {
                if (first)
                {
                    cursor = printText($"Payment Method: {p.Method}{(!string.IsNullOrWhiteSpace(p.Number) ? "" : $": {p.Number}")}", true, g, font, brush, cursor, leftAlign, lSpacing);
                    first = false;
                }
                else
                    cursor = printText($"                {p.Method}{(string.IsNullOrWhiteSpace(p.Number) ? "" : $": {p.Number}")}", true, g, font, brush, cursor, leftAlign, lSpacing);
            }
            // Print Payment Method

            //Print footer
            cursor = printHeaderFooter("Footer\n", g, font, brush, cursor, centerAlign, lSpacing);
        }
    }
}
