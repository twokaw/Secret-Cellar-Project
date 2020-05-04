using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using Shared;

namespace NCR_Printer
{
    public class Receipt : Transaction
    {
        Image logo = null;
        string header;
        string footer;
        PrintDocument rcpt = null;
        CashDrawer drawer = null;

        public Receipt(uint InvoiceID,
                           uint RegisterID,
                           DateTime TransactionDateTime,
                           string Location,
                           List<Item> Items,
                           decimal Discount,
                           decimal Subtotal,
                           decimal Tax,
                           decimal Total,
                           bool TaxExempt,
                           string PayMethod,
                           string PayNum,
                           string header,
                           string footer,
                           Image logo) 
            : base(InvoiceID, RegisterID, TransactionDateTime, Location, Items, Discount, Subtotal, Tax, Total, TaxExempt, PayMethod, PayNum)
        {
            this.header = header;
            this.footer = footer;
            this.logo = logo;
            drawer = new CashDrawer();
        }

        public Receipt(Transaction trans, string header, string footer, Image logo)
            : this(trans.InvoiceID,
                 trans.RegisterID,
                 trans.TransactionDateTime,
                 trans.Location,
                 trans.Items,
                 trans.Discount,
                 trans.Subtotal,
                 trans.Tax,
                 trans.Total,
                 trans.TaxExempt,
                 trans.PayMethod,
                 trans.PayNum,
                 header,
                 footer,
                 logo)
        {
        }

        public void print()
        {
            // Open Cash drawer
            drawer.openDrawer();

            // Print receipt
            rcpt = new PrintDocument();
            rcpt.DefaultPageSettings.PaperSize = new PaperSize("receipt", 280, 0);
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
            g.DrawString(header, font, brush, wrappedCursor, align);
            cursor.Y += wrappedSize.Height + lSpacing;
            return cursor;
        }

        // Event handler for printing receipt
        void rcpt_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Initialize printing stuff
            Graphics g = e.Graphics;

            Font font = new Font("Arial", 10);
            Font barcodeFont = new Font("Free 3 of 9", 36);

            float lSpacing = 5F;
            Brush brush = Brushes.Black;
            Pen pen = new Pen(brush);
            
            StringFormat leftAlign = new StringFormat() { Alignment = StringAlignment.Near };
            StringFormat centerAlign = new StringFormat() { Alignment = StringAlignment.Center };
            StringFormat rightAlign = new StringFormat() { Alignment = StringAlignment.Far };

            RectangleF cursor = new RectangleF(e.PageBounds.X, e.PageBounds.Y, e.PageBounds.Width, font.Height);

            // Print Logo
            g.DrawImage(logo, cursor.Width/2-logo.Width/2, cursor.Top);
            cursor.Y += logo.Height + lSpacing;

            // Print InvoiceID Barcode
            cursor = printText("*" + InvoiceID.ToString() + "*", true, g, barcodeFont, brush, cursor, centerAlign, lSpacing);

            // Print Header
            cursor = printHeaderFooter(header, g, font, brush, cursor, centerAlign, lSpacing);

            // Print InvoiceID
            cursor = printText("Invoice #: " + InvoiceID.ToString(), true, g, font, brush, cursor, leftAlign, lSpacing);

            // Print RegisterID
            cursor = printText("Register ID: " + RegisterID.ToString(), false, g, font, brush, cursor, leftAlign, lSpacing);

            // Print Location
            cursor = printText("Location: " + Location, true, g, font, brush, cursor, rightAlign, lSpacing);

            // Date and time
            cursor = printText("Date and time: " + TransactionDateTime.ToString(), true, g, font, brush, cursor, leftAlign, lSpacing);

            // Print Separator
            cursor = printHorizontalLine(g, font, pen, cursor, lSpacing);

            // Print Items
            foreach (Item item in Items)
            {
                cursor = printText(item.NumSold + " " + item.Name, false, g, font, brush, cursor, leftAlign, lSpacing);
                cursor = printText("$ " + item.Price.ToString(), true, g, font, brush, cursor, rightAlign, lSpacing);
            }

            // Print Separator
            cursor = printHorizontalLine(g, font, pen, cursor, lSpacing);

            // Print subtotal
            cursor = printText("SubTotal:", false, g, font, brush, cursor, leftAlign, lSpacing);
            cursor = printText("$ " + Subtotal.ToString(), true, g, font, brush, cursor, rightAlign, lSpacing);

            // Print tax
            cursor = printText("Tax:", false, g, font, brush, cursor, leftAlign, lSpacing);
            cursor = printText("$ " + Tax.ToString(), true, g, font, brush, cursor, rightAlign, lSpacing);

            // Print total
            cursor = printText("TOTAL:", false, g, font, brush, cursor, leftAlign, lSpacing);
            cursor = printText("$ " + Total.ToString(), true, g, font, brush, cursor, rightAlign, lSpacing);

            // Print Separator
            cursor = printHorizontalLine(g, font, pen, cursor, lSpacing);

            // Print # of items
            cursor = printText("# of Items: " + Items.Count.ToString(), true, g, font, brush, cursor, leftAlign, lSpacing);

            // Print Payment Method
            cursor = printText("Payment Method: " + PayMethod + ": " + PayNum, true, g, font, brush, cursor, leftAlign, lSpacing);

            //Print footer
            cursor = printHeaderFooter(footer, g, font, brush, cursor, centerAlign, lSpacing);

        }
    }
}
