using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Dynamic;
using Shared;

namespace NCR_Printer
{
    public abstract class PrintDoc
    {
        public PrintLayout Layout { get; set; }

        private PrintDocument rcpt = null;

        private static readonly StringFormat leftAlign = new StringFormat() { Alignment = StringAlignment.Near };
        private static readonly StringFormat centerAlign = new StringFormat() { Alignment = StringAlignment.Center };
        private static readonly StringFormat rightAlign = new StringFormat() { Alignment = StringAlignment.Far };
        private static readonly float lSpacing = 5F;

        private readonly Brush brush = Brushes.Black;
        private readonly Pen pen;

        public enum TextAlignment
        {
            Left,
            Center, 
            Right
        };

        public PrintDoc( PrintLayout layout)
        {
            Layout = layout;
            pen = new Pen(brush);
        }

        public Graphics g;
        public RectangleF cursor;

        public void Print()
        {
            // Print receipt
            rcpt = new PrintDocument();
            rcpt.DefaultPageSettings.PaperSize = new PaperSize(Layout.PageType, Layout.Width, 0);
            rcpt.PrintPage += new PrintPageEventHandler(PrintPage);
            rcpt.Print();
        }

        public void SetupPage(PrintPageEventArgs e)
        {
            g = e.Graphics;
            // Font font = Layout.TextFont;
            // Font barcodeFont = Layout.BarcodeFont; 

            cursor = new RectangleF(e.PageBounds.X, e.PageBounds.Y, e.PageBounds.Width, Layout.TextFont.Height);
        }

        // TODO : Scale image width to rectangle
        public void PrintImage(Image img)
        {
            RectangleF m = new RectangleF(0, cursor.Y, cursor.Width, (float)img.Height / (float)img.Width * cursor.Width);

            g.DrawImage(img, m); // .Width / 2 - img.Width / 2, m.Top);
            cursor.Y += m.Height + lSpacing;
        }

        // Print the text with the given alignment at the cursor and return an advanced cursor based on newLine
        public void PrintText(string text, bool newLine = true, TextAlignment align = TextAlignment.Left)
        {
            PrintText(text, Layout.TextFont, newLine, align);
        }

        // Print the text with the given alignment at the cursor and return an advanced cursor based on newLine
        public void PrintText(string text, Font font, bool newLine = true, TextAlignment align = TextAlignment.Left)
        {
            PrintText(text, newLine, g, font, brush, GetAlign(align), lSpacing);
        }

        // Print the text with the given alignment at the cursor and return an advanced cursor based on newLine
        public void PrintText(string text, bool newLine, Graphics g, Font font, Brush brush, StringFormat align, float lSpacing)
        {
            g.DrawString(text, font, brush, cursor, align);
            if (newLine) cursor.Y += font.Height + lSpacing;
        }

        // Print a horizontal line at the cursor and return an advanced cursor
        public void PrintHorizontalLine()
        {
            PrintHorizontalLine(g, Layout.TextFont, pen, lSpacing);
        }

        // Print a horizontal line at the cursor and return an advanced cursor
        public void PrintHorizontalLine(Graphics g, Font font, Pen pen, float lSpacing)
        {
            cursor.Y += (font.Height + lSpacing) / 2;
            g.DrawLine(pen, cursor.X, cursor.Y, cursor.X + cursor.Width, cursor.Y);
            cursor.Y += (font.Height + lSpacing) / 2;
        }

        // Print the header/footer text with the given alignment at the cursor and return an advanced cursor.
        // This handles newline characters and wrapping of arbitrary length lines.
        public void PrintHeaderFooter(string text, TextAlignment align = TextAlignment.Center )
        {
            PrintHeaderFooter(text, g, Layout.TextFont, brush, GetAlign(align), lSpacing);
        }

        // Print the header/footer text with the given alignment at the cursor and return an advanced cursor.
        // This handles newline characters and wrapping of arbitrary length lines.
        public void PrintHeaderFooter(string text, Graphics g, Font font, Brush brush, StringFormat align, float lSpacing)
        {
            // Figure out the box we want to draw in
            SizeF wrappedSize = g.MeasureString(text, font, (int)cursor.Width, align);
            wrappedSize.Width = cursor.Width; // We just wanted height from MeasureString
            RectangleF wrappedCursor = new RectangleF(cursor.Location, wrappedSize);
            // Print using box
            g.DrawString(text, font, brush, wrappedCursor, align);
            cursor.Y += wrappedSize.Height + lSpacing;
        }

        // Event handler for printing receipt
        public abstract void PrintPage(object sender, PrintPageEventArgs e);

        private StringFormat GetAlign(TextAlignment align)
        {
            StringFormat alignment;
            switch (align)
            {
                case TextAlignment.Left:
                    alignment = leftAlign;
                    break;
                case TextAlignment.Center:
                    alignment = centerAlign;
                    break;
                default:
                    alignment = rightAlign;
                    break;
            }

            return alignment;
        }
    }
}
