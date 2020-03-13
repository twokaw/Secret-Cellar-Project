using System.Drawing;
using System.Drawing.Printing;

namespace NCR_Printer
{
    public class Receipt
    {
        Image logo = null;
        string storeName;
        double[] items;
        PrintDocument rcpt = null;

        public Receipt(Image logo, string storeName, double[] items)
        {
            this.logo = logo;
            this.storeName = storeName;
            this.items = items;
        }

        public void print()
        {
            rcpt = new PrintDocument();

            rcpt.PrintPage += new PrintPageEventHandler(rcpt_PrintPage);

            rcpt.Print();
        }

        void rcpt_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Initialize printing stuff
            Graphics g = e.Graphics;
            float leftMargin = e.MarginBounds.Left;
            float rightMargin = e.MarginBounds.Right;
            float xCenter = (leftMargin + rightMargin) / 2;
            float yPos = e.MarginBounds.Top;
            Font font = new Font("Arial", 10);
            Brush brush = Brushes.Black;
            float total = 0;

            // Print store name
            g.DrawString(storeName, font, brush, leftMargin, yPos);
            yPos += font.Height;

            //Print logo
            g.DrawImage(logo, leftMargin, yPos);
            yPos += logo.Height;

            // Print items
            foreach(float item in items)
            {
                total += item;
                g.DrawString(item.ToString(), font, brush, rightMargin, yPos);
                yPos += font.Height;
            }

            // Print total
            g.DrawString("Total: " + total.ToString(), font, brush, rightMargin, yPos);
        }
    }
}
