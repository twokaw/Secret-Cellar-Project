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
            items.Add(new Item("Wine", 911, "911", 3, 1, 99.99M, true, "WINE", 1, 0.0M, 0.0M));
            Transaction trans = new Transaction(2286, 1, DateTime.Now, "Shueyville, IA", items, 0.0M, 99.99M, 0.13M, 99.99M+0.13M, false, "Card", "1234");

            Image logo = Image.FromFile("Z:\\SecretCellar\\hardware\\SecretCellar.jpg");
            Receipt r = new Receipt(trans, "The Secret Cellar\n(319) 841-2172\n1205 Curtis Bridge Rd NE", "Thank you!\nCheck our website for events and classes\nwww.SecretCellarwines.com", logo);
            r.print();

            /*Image logo = Image.FromFile("Z:\\SecretCellar\\hardware\\SecretCellar.jpg");
            Receipt r = new Receipt(trans, "The Secret Cellar This is an arbitrary sized header line that is in fact very long, too long in fact, which is automatically wrapped.\n(319) 841-2172\n1205 Curtis Bridge Rd NE\n\n\n", "Thank you!\nCheck our website for events and classes\nwww.SecretCellarwines.com\n\nJoin us for our next Wine Party, on January 1st! Check out the whole 2020 schedule at https://www.secretcellarwines.com/2020_Wine_Party_Schedule.php\n\n This month, get a free corkscrew when you purchase $30 or more in delicious wine!", logo);
            r.print();*/

        }
    }
}
