﻿using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretCellar.Settings_Panels
{
    public partial class PanTax : UserControl
    {
        public PanTax()
        {
            InitializeComponent();
            lst_tax_list.DataSource = DataAccess.instance?.GetTax();
            lst_tax_list.DisplayMember = "TaxName";

        }

        private void btn_update_tax_Click(object sender, EventArgs e)
        {
            Tax i = new Tax();
            i.TaxName = txt_tax_type_name.Text.Trim();
            i.BottleDeposit = Convert.ToDouble(txt_bottle_dep.Text);
            i.SalesTax = Convert.ToDouble(txt_sales_tax.Text);
            i.IdTax = ((Tax)lst_tax_list.SelectedItem).IdTax;

            DataAccess.instance.UpdateTax(i);
        }

        private void lst_tax_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_tax_type_name.Text = ((Tax)lst_tax_list.SelectedItem).TaxName;
            txt_bottle_dep.Text = ((Tax)lst_tax_list.SelectedItem).BottleDeposit.ToString();
            txt_sales_tax.Text = ((Tax)lst_tax_list.SelectedItem).SalesTax.ToString();
            txt_local_tax.Text = ((Tax)lst_tax_list.SelectedItem).LocalSalesTax.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_tax_type_name.Text = "";
            txt_bottle_dep.Text = "";
            txt_sales_tax.Text = "";
            txt_local_tax.Text = "";
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            if (((List<Tax>)lst_tax_list.DataSource).FirstOrDefault(x => x.TaxName == lst_tax_list.Text) != null)
            {
                Tax i = new Tax
                {
                    TaxName = txt_tax_type_name.Text.Trim(),
                    BottleDeposit = Convert.ToDouble(txt_bottle_dep.Text),
                    SalesTax = Convert.ToDouble(txt_sales_tax.Text)
                };

                DataAccess.instance.UpdateTax(i);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
