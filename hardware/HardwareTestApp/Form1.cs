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
            items.Add(new Item("Wine", 911, 911, 3, 1, 99.99M, true, "WINE", 1));
            Transaction trans = new Transaction(2286, 1, DateTime.Now, "Shueyville, IA", items, 0.0M, 99.99M, 0.13M, 99.99M+0.13M, false, "Card", "1234");

            Image logo = Image.FromFile("Z:\\SecretCellar\\hardware\\SecretCellar.jpg");
            Receipt r = new Receipt(trans, "The Secret Cellar This is an arbitrary sized header line that is in fact very long, too long in fact.\n(319) 841-2172\n1205 Curtis Bridge Rd NE adomw oawmd oamwd aowd maowm doawmd oaimwdoam wdoawidmaoimd wao wdmaw domwodmao\n\n\n", "Thank youd awdokawpdo kapdka pkdpawkd pakdp kadpw kapd kapdk apkd apkfapfgkpakwfpawkpakdpakdwp akk apkdpakwdowapdap kpakd wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww!\nCheck our website for events and classes\n\n\nwww.SecretCellarwines.com", logo);
            r.print();

            /*List<Item> items2 = new List<Item>();
            items.Add(new Item("Wine", 911, 911, 3, 1, 9.99M, true, "WINE", 1));
            items.Add(new Item("Fancy Wine", 911, 911, 3, 1, 99.99M, true, "WINE", 1));
            items.Add(new Item("Fanciest Wine", 911, 911, 3, 1, 999.99M, true, "WINE", 1));
            Transaction trans2 = new Transaction(1234, 42, DateTime.Now, "The Moon", items2, 0.0M, 1109.97M, 20M, 1129.97M, false, "CHK", "1234");

            Image logo2 = Image.FromFile("Z:\\SecretCellar\\hardware\\logo.bmp");
            Receipt r2 = new Receipt(trans2, "The Secret Cellar\n(319) 841-2172\n1205 Curtis Bridge Rd NE", "Thank you!\nCheck our website for events and classes\nwww.SecretCellarwines.com", logo2);
            r2.print();*/

        }
    }
}
