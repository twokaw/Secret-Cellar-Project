using System;
using Shared;
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
    public partial class frmCustom : Form
    {
        private Transaction customItem = null;

        public frmCustom(Transaction transaction)
        {
            InitializeComponent();
            customItem = transaction;

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
            if (double.TryParse(txt_charge_am.Text, out double d))
            {
                Item i = DataAccess.ConvertInvtoItem(DataAccess.instance.GetItem("Custom"));
                i.Price = d;
                i.Price = d
				
				/*
                  <<<<<<< HEAD
                    //  i.Description = txt_descript.Text;
                  =======
                i.Name = txt_descript.Text;
                >>>>>>> master
                */
				i.Name = txt_descript.Text;

                i.NumSold = 1;
                customItem.Items.Add(i);
            }


        }

        private void txt_charge_am_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_descript_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
