using SecretCellar;
using Shared;
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
    public partial class frmLookup : Form
    {
        private Transaction lookUp = null;
        

        public frmLookup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addCharge();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double addCharge()
        {
            // if (double.TryParse(txtPercentTotalSale.Text, out d))
            lookUp.Subtotal += double.Parse(txtCharge.Text);
            return lookUp.Subtotal;
        }
        private void txtCharge_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
