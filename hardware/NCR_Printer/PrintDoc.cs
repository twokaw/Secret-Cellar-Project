﻿using System;
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
        private readonly Transaction transaction;

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
        public Rectangle margin;

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
            margin = e.MarginBounds;
        }

        // TODO : Scale image to rectangle
        public void PrintImage(Image img)
        {
            Rectangle m = margin;

            if ((double)img.Width / (double)img.Height > (double)m.Width / (double)m.Height) // image is wider
                m.Height = (int)((double)img.Height / (double)img.Width * (double)m.Width);
            else
                m.Width = (int)((double)img.Width / (double)img.Height * (double)m.Height);

            g.DrawImage(img, m.Width / 2 - img.Width / 2, m.Top);
            cursor.Y += img.Height + lSpacing;
        }

        // Print the text with the given alignment at the cursor and return an advanced cursor based on newLine
        public RectangleF PrintText(string text, bool newLine = true, TextAlignment align = TextAlignment.Left)
        {
            return PrintText(text, Layout.TextFont, newLine, align);
        }

        // Print the text with the given alignment at the cursor and return an advanced cursor based on newLine
        public RectangleF PrintText(string text, Font font, bool newLine = true, TextAlignment align = TextAlignment.Left)
        {
            return PrintText(text, newLine, g, font, brush, cursor, GetAlign(align), lSpacing);
        }

        // Print the text with the given alignment at the cursor and return an advanced cursor based on newLine
        public RectangleF PrintText(string text, bool newLine, Graphics g, Font font, Brush brush, RectangleF cursor, StringFormat align, float lSpacing)
        {
            g.DrawString(text, font, brush, cursor, align);
            if (newLine) cursor.Y += font.Height + lSpacing;
            this.cursor = cursor;
            return cursor;
        }

        // Print a horizontal line at the cursor and return an advanced cursor
        public RectangleF PrintHorizontalLine()
        {
            return PrintHorizontalLine(g, Layout.TextFont, pen, cursor, lSpacing);
        }
        // Print a horizontal line at the cursor and return an advanced cursor
        public RectangleF PrintHorizontalLine(Graphics g, Font font, Pen pen, RectangleF cursor, float lSpacing)
        {
            cursor.Y += (font.Height + lSpacing) / 2;
            g.DrawLine(pen, cursor.X, cursor.Y, cursor.X + cursor.Width, cursor.Y);
            cursor.Y += (font.Height + lSpacing) / 2;
            this.cursor = cursor;
            return cursor;
        }

        // Print the header/footer text with the given alignment at the cursor and return an advanced cursor.
        // This handles newline characters and wrapping of arbitrary length lines.
        public RectangleF PrintHeaderFooter(string text, TextAlignment align = TextAlignment.Center )
        {
            return PrintHeaderFooter(text, g, Layout.TextFont, brush, cursor, GetAlign(align), lSpacing);
        }

        // Print the header/footer text with the given alignment at the cursor and return an advanced cursor.
        // This handles newline characters and wrapping of arbitrary length lines.
        public RectangleF PrintHeaderFooter(string text, Graphics g, Font font, Brush brush, RectangleF cursor, StringFormat align, float lSpacing)
        {
            // Figure out the box we want to draw in
            SizeF wrappedSize = g.MeasureString(text, font, (int)cursor.Width, align);
            wrappedSize.Width = cursor.Width; // We just wanted height from MeasureString
            RectangleF wrappedCursor = new RectangleF(cursor.Location, wrappedSize);
            // Print using box
            g.DrawString(text, font, brush, wrappedCursor, align);
            cursor.Y += wrappedSize.Height + lSpacing;
            this.cursor = cursor;
            return cursor;
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
