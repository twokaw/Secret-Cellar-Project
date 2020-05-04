using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
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
            g.DrawString("*" + InvoiceID.ToString() + "*", barcodeFont, brush, cursor, centerAlign);
            cursor.Y += barcodeFont.Height + lSpacing;

            // Print Header
            string[] headerLines = header.Split('\n');
            foreach (string line in headerLines) {
                g.DrawString(line, font, brush, cursor, centerAlign);
                cursor.Y += font.Height + lSpacing;
            }

            // Print InvoiceID
            g.DrawString("Invoice #: " + InvoiceID.ToString(), font, brush, cursor, leftAlign);
            cursor.Y += font.Height + lSpacing;

            // Print RegisterID
            g.DrawString("Register ID: " + RegisterID.ToString(), font, brush, cursor, leftAlign);

            // Print Location
            g.DrawString("Location: " + Location, font, brush, cursor, rightAlign);
            cursor.Y += font.Height + lSpacing;

            // Date and time
            g.DrawString("Date and time: " + TransactionDateTime.ToString(), font, brush, cursor, leftAlign);
            cursor.Y += font.Height + lSpacing;

            // Print Horizontal line
            cursor.Y += (font.Height + lSpacing) / 2;
            g.DrawLine(pen, cursor.X, cursor.Y, cursor.X + cursor.Width, cursor.Y);
            cursor.Y += (font.Height + lSpacing) / 2;

            // Print Items
            foreach (Item item in Items)
            {
                g.DrawString(item.NumSold + " " + item.Name, font, brush, cursor, leftAlign);
                g.DrawString("$ " + item.Price.ToString(), font, brush, cursor, rightAlign);
                cursor.Y += font.Height + lSpacing;
            }

            // Print Horizontal line
            cursor.Y += (font.Height + lSpacing) / 2;
            g.DrawLine(pen, cursor.X, cursor.Y, cursor.X + cursor.Width, cursor.Y);
            cursor.Y += (font.Height + lSpacing) / 2;

            // Print subtotal
            g.DrawString("SubTotal:", font, brush, cursor, leftAlign);
            g.DrawString("$ " + Subtotal.ToString(), font, brush, cursor, rightAlign);
            cursor.Y += font.Height + lSpacing;

            // Print tax
            g.DrawString("Tax:", font, brush, cursor, leftAlign);
            g.DrawString("$ " + Tax.ToString(), font, brush, cursor, rightAlign);
            cursor.Y += font.Height + lSpacing;

            // Print total
            g.DrawString("TOTAL:", font, brush, cursor, leftAlign);
            g.DrawString("$ " + Total.ToString(), font, brush, cursor, rightAlign);
            cursor.Y += font.Height + lSpacing;

            // Print Horizontal line
            cursor.Y += (font.Height + lSpacing) / 2;
            g.DrawLine(pen, cursor.X, cursor.Y, cursor.X + cursor.Width, cursor.Y);
            cursor.Y += (font.Height + lSpacing) / 2;

            // Print # of items
            g.DrawString("# of Items: " + Items.Count.ToString(), font, brush, cursor, leftAlign);
            cursor.Y += font.Height + lSpacing;

            // Print Payment Method
            g.DrawString("Payment Method: " + PayMethod + ": " + PayNum, font, brush, cursor, leftAlign);
            cursor.Y += font.Height + lSpacing;

            //Print footer
            string[] footerLines = footer.Split('\n');
            foreach (string line in footerLines)
            {
                g.DrawString(line, font, brush, cursor, centerAlign);
                cursor.Y += font.Height + lSpacing;
            }
        }
    }
}
