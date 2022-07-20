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

        private static readonly StringFormat leftAlign = new StringFormat() { Alignment = StringAlignment.Near };
        private static readonly StringFormat centerAlign = new StringFormat() { Alignment = StringAlignment.Center };
        private static readonly StringFormat rightAlign = new StringFormat() { Alignment = StringAlignment.Far };
        public static float LineSpacing { get; set; } = 5F;

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
        public Margins margins = new Margins();

        public void Print()
        {
            // Print receipt
            GetPrintDocument().Print();
            
        }

        public PrintDocument GetPrintDocument()
        {
            // Preview receipt
            PrintDocument rcpt = new PrintDocument();
            rcpt.DefaultPageSettings.PaperSize = new PaperSize(Layout.PageType, Layout.Width, Layout.Height);
            rcpt.PrintPage += new PrintPageEventHandler(PrintPage);
            return rcpt;
        }
        public PrintDocument GetPrintPreviewDocument()
        {
            // Preview receipt
            PrintDocument rcpt = new PrintDocument();
            rcpt.DefaultPageSettings.PaperSize = new PaperSize(Layout.PageType, Layout.Width, (Layout.Height == 0)?(int) Math.Ceiling( cursor.Location.Y):Layout.Height );
            rcpt.PrintPage += new PrintPageEventHandler(PrintPage);
            rcpt.DefaultPageSettings.Margins = margins;
            return rcpt;
        }


        public void SetupPage(PrintPageEventArgs e)
        {
            g = e.Graphics;
            // Font font = Layout.TextFont;
            // Font barcodeFont = Layout.BarcodeFont; 
            if(e == null)
                cursor = new RectangleF(0, 0, Layout.Width, Layout.TextFont.Height);
            else
                cursor = new RectangleF(e.PageBounds.X, e.PageBounds.Y, e.PageBounds.Width, Layout.TextFont.Height);
        }

        public void PrintImage(Image img)
        {
            RectangleF m = new RectangleF(0, cursor.Y, cursor.Width, (float)img.Height / (float)img.Width * cursor.Width);

            if(g != null)
                g.DrawImage(img, m); // .Width / 2 - img.Width / 2, m.Top);
            cursor.Y += m.Height + LineSpacing;
        }

        public void PrintImage(Image img, float percent,TextAlignment align = TextAlignment.Center)
        {
            float x = 0;
            if (align == TextAlignment.Center)
                x = (cursor.Width - cursor.Width * percent) / 2;
            else if (align == TextAlignment.Right)
                x = (cursor.Width - cursor.Width * percent);
            RectangleF m = new RectangleF(x, cursor.Y, cursor.Width * percent, (float)img.Height / (float)img.Width * cursor.Width * percent);

            if (g != null)
                g.DrawImage(img, m); // .Width / 2 - img.Width / 2, m.Top);
            cursor.Y += m.Height + LineSpacing;
        }

        // Print the text with the given alignment at the cursor and return an advanced cursor based on newLine
        public void PrintText(string text, bool newLine = true, TextAlignment align = TextAlignment.Left)
        {
            PrintText(text, Layout.TextFont, newLine, align);
        }

        // Print the text with the given alignment at the cursor and return an advanced cursor based on newLine
        public void PrintText(string text, Font font, bool newLine = true, TextAlignment align = TextAlignment.Left)
        {
            PrintText(text, newLine, g, font, brush, GetAlign(align), LineSpacing);
        }

        public void PrintText(string text, float x, bool newLine = false, TextAlignment align = TextAlignment.Left)
        {
            cursor.X = x;
            PrintText(text, newLine, g, Layout.TextFont, brush, GetAlign(align), LineSpacing);
        }

        public void PrintText(string text, Font font, float x, bool newLine = false, TextAlignment align = TextAlignment.Left)
        {
            cursor.X = x;
            PrintText(text, newLine, g, font, brush, GetAlign(align), LineSpacing);
        }

        // Print the text with the given alignment at the cursor and return an advanced cursor based on newLine
        public void PrintText(string text, bool newLine, Graphics g, Font font, Brush brush, StringFormat align, float lSpacing)
        {
            if (g != null)
                g.DrawString(text, font, brush, cursor, align);
            if (newLine) cursor.Y += font.Height + lSpacing;
        }

        // Print a horizontal line at the cursor and return an advanced cursor
        public void PrintHorizontalLine()
        {
            PrintHorizontalLine(g, Layout.TextFont, pen, LineSpacing);
        }

        // Print a horizontal line at the cursor and return an advanced cursor
        public void PrintHorizontalLine(Graphics g, Font font, Pen pen, float lSpacing)
        {
            cursor.Y += (font.Height + lSpacing) / 2;
            if (g != null)
                g.DrawLine(pen, cursor.X, cursor.Y, cursor.X + cursor.Width, cursor.Y);
            cursor.Y += (font.Height + lSpacing) / 2;
        }

        // Print the header/footer text with the given alignment at the cursor and return an advanced cursor.
        // This handles newline characters and wrapping of arbitrary length lines.
        public void PrintHeaderFooter(string text, TextAlignment align = TextAlignment.Center )
        {
            PrintHeaderFooter(text, g, Layout.TextFont, brush, GetAlign(align), LineSpacing);
        }

        public SizeF MeasureString(string text)
        {
            return g.MeasureString(text, Layout.TextFont, (int)cursor.Width);
        }

        public SizeF MeasureString(string text, StringFormat stringFormat)
        {
            return g.MeasureString(text, Layout.TextFont, (int)cursor.Width, stringFormat);
        }
        public SizeF MeasureString(string text, Font font, StringFormat stringFormat)
        {
            return g.MeasureString(text, font, (int)cursor.Width, stringFormat);
        }

        // Print the header/footer text with the given alignment at the cursor and return an advanced cursor.
        // This handles newline characters and wrapping of arbitrary length lines.
        public void PrintHeaderFooter(string text, Graphics g, Font font, Brush brush, StringFormat align, float lSpacing)
        {
            // Figure out the box we want to draw in
            SizeF wrappedSize;
            if( g != null)
                wrappedSize = g.MeasureString(text, font, (int)cursor.Width, align);
            else
            {
                wrappedSize = new SizeF
                {
                    Height = (font.Height + lSpacing) * (text.Split('\n').Length + 2)
                };
            }

            wrappedSize.Width = cursor.Width; // We just wanted height from MeasureString
            RectangleF wrappedCursor = new RectangleF(cursor.Location, wrappedSize);
            // Print using box
            if(g != null)
                g.DrawString(text, font, brush, wrappedCursor, align);
            cursor.Y += wrappedSize.Height + lSpacing;
        }

        // Event handler for printing receipt
        public abstract void PrintPage(object sender, PrintPageEventArgs e);

        public static StringFormat GetAlign(TextAlignment align)
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
