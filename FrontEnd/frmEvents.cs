using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretCellar
{
    public partial class frmEvents : Form
    {
        public frmEvents()
        {
            InitializeComponent();
        }

        private void btnAddCharge_Click(object sender, EventArgs e)
        {
            addCharge();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void addCharge()
        {
            if (double.TryParse(txtCharge.Text, out double d))
            {
                //events.Items.Add(new Item()
                //{
                //    Name = "Events",
                //    Id = xxxx,
                //    Barcode = "EVENTS",
                //    Price = d,
                //    NumSold = 1

                //});
                //  dryClean.Subtotal += d;
            }


        }
    }
}
