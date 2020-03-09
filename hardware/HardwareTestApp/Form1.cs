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

            CashDrawer drawer = new CashDrawer();
            drawer.open();

            Image logo = Image.FromFile("Z:\\SecretCellar\\hardware\\logo.bmp");
            Receipt r = new Receipt(logo, "Secret Cellar", new double[] { 0.99, 1.35, 4415.34 });
            r.print();

        }
    }
}
