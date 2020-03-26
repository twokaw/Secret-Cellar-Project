using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCR_Printer;
using Shared;

namespace HardwareTestApp
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_OnClick(object sender, EventArgs e)
        {

            List<Item> items = new List<Item>();
            items.Add(new Item("Wine", 911, 911, 3, 1, 999999.99M, true, "WINE", 1));
            Transaction trans = new Transaction(1, 1, DateTime.Now, "Shueyville", items, 0.0M, 99.99M, 0.0M, 99.99M, false, "Card", "1234");

            Image logo = Image.FromFile("Z:\\SecretCellar\\hardware\\logo.bmp");
            Receipt r = new Receipt(trans, "HEADER", "FOOTER", logo);
            r.print();

        }
    }
}
