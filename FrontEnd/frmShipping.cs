﻿using SecretCellar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared;

namespace SecretCellar
{
    public partial class frmShipping : Form
    {
        private Transaction shipping = null;
        public frmShipping(Transaction transaction)
        {
            InitializeComponent();
            shipping = transaction; 

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCharge_Click(object sender, EventArgs e)
        {
            addCharge();
            this.Close();
        }

        private void txtCharge_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void addCharge()
        {
            if (double.TryParse(txtCharge.Text, out double d))
            {
                Item i = DataAccess.ConvertInvtoItem(DataAccess.instance.GetItem("SHIPPING"));
                i.Price = d;

                shipping.Items.Add(i);
            }


        }
    }
}
