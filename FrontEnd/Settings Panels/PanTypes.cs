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

namespace SecretCellar.Settings_Panels
{
    public partial class PanTypes : UserControl
    {
        private List<Discount> discounts = DataAccess.instance.GetDiscount();
        public Discount newDiscount = null;
        public PanTypes()
        {
            InitializeComponent();
            lstTypes.DataSource = DataAccess.instance?.GetInventoryType();
            cbx_tax.DataSource = DataAccess.instance?.GetTax();
            lstTypes.DisplayMember = "TypeName";
            cbx_tax.DisplayMember = "TaxName";
            
            discounts?.ForEach(x => chk_lst_discount.Items.Add(x.DiscountName));
            
        }

        private void lstTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

            txt_bottleDep.Text = ((InventoryType)lstTypes.SelectedItem).BottleDeposit.ToString();
            txt_salesTax.Text = ((InventoryType)lstTypes.SelectedItem).SalesTax.ToString();
            txt_localTax.Text = ((InventoryType)lstTypes.SelectedItem).LocalSalesTax.ToString();
            txt_typename.Text = ((InventoryType)lstTypes.SelectedItem).TypeName;
            
            for (int i = 0; i < chk_lst_discount.Items.Count; i++)
                chk_lst_discount.SetItemChecked(i, ((InventoryType)lstTypes.SelectedItem).Discount.FirstOrDefault(x => x.DiscountName == chk_lst_discount.Items[i].ToString()) != null);
        }

        private void btn_type_clear_Click(object sender, EventArgs e)
        {
            txt_typename.Text = "";
            cbx_tax.SelectedItem = 0;
            txt_typename.Focus();
        }

        private void btn_new_type_Click(object sender, EventArgs e)
        {
            if (DataAccess.instance.GetInventoryType(lbl_typename.Text) == null)
            {
                InventoryType i = new InventoryType();
                i.TypeName = lbl_typename.Text.Trim();
                i.IdTax = ((Tax)cbx_tax.SelectedItem).IdTax;
                //i.BottleDeposit = Convert.ToDouble(txt_bottleDep.Text);
                //i.SalesTax = Convert.ToDouble(txt_salesTax.Text);
                //i.LocalSalesTax = Convert.ToDouble(txt_localTax.Text);
                DataAccess.instance.UpdateInventoryType(i);
            }
        }

        private void btn_update_type_Click(object sender, EventArgs e)
        {
            InventoryType i = (InventoryType)lstTypes.SelectedItem;
            i.TypeName = txt_typename.Text.Trim();
            i.IdTax = ((Tax)cbx_tax.SelectedItem).IdTax;
            

            // TODO: Update Discount
            DataAccess.instance.UpdateInventoryType(i);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chk_lst_discount_SelectedIndexChanged(object sender, EventArgs e)
        {
            Discount selected = discounts.FirstOrDefault(x => x.DiscountName == chk_lst_discount.SelectedItem.ToString());
            txt_dis_name.Text = selected.DiscountName;
            txt_dis_min.Text = selected.Min.ToString();
            txt_dis_max.Text = selected.Max.ToString();
            txt_discount.Text = selected.Amount.ToString();
        }

        private void btn_new_discount_Click(object sender, EventArgs e)
        {
            newDiscount = new Discount
            {
                DiscountName = txt_dis_name.Text.Trim(),
                Min = uint.Parse(txt_dis_min.Text),
                Max = uint.Parse(txt_dis_min.Text),
                Amount = Convert.ToDouble(txt_discount.Text)

            };
            //newDiscount.(new Discount { DiscountName = txt_dis_name.Text, Min = uint.Parse(txt_dis_min.Text), Max = uint.Parse(txt_dis_min.Text), Amount = Convert.ToDouble(txt_discount.Text)});
            newDiscount.DiscountID = DataAccess.instance.UpdateDiscount(newDiscount);
            populate();

           
        }

        private void btn_update_discount_Click(object sender, EventArgs e)
        {

            Discount d = discounts.First(x => x.DiscountName == chk_lst_discount.SelectedItem.ToString());
            d.DiscountName = txt_dis_name.Text.Trim();
            d.Min = uint.Parse(txt_dis_min.Text.Trim());
            d.Max = uint.Parse(txt_dis_max.Text.Trim());
            d.Amount = Convert.ToDouble(txt_discount.Text);

            /* if (newDiscount != null && newDiscount.DiscountID > 0)
             {
                 newDiscount.Min = uint.Parse(txt_dis_min.Text),
                 newDiscount.Max = uint.Parse(txt_dis_min.Text),
                 newDiscount.Amount = Convert.ToDouble(txt_discount.Text)
             };*/
            DataAccess.instance.UpdateDiscount(d);
            populate();
        }

        private void btn_delete_discount_Click(object sender, EventArgs e)
        {
            Discount dis = discounts.First(x => x.DiscountName == chk_lst_discount.SelectedItem.ToString());
            DataAccess.instance.DeleteDiscount(dis);
            txt_dis_name.Text = "";
            txt_dis_min.Text = "";
            txt_dis_max.Text = "";
            txt_discount.Text = "";
            txt_dis_name.Focus();
            populate();
        }

        private void populate()
        {
            chk_lst_discount.Items.Clear();
            discounts = DataAccess.instance.GetDiscount();
            discounts?.ForEach(x => chk_lst_discount.Items.Add(x.DiscountName));
        }

        private void btn_clear_discount_Click(object sender, EventArgs e)
        {
            txt_dis_name.Text = "";
            txt_dis_min.Text = "";
            txt_dis_max.Text = "";
            txt_discount.Text = "";
            txt_dis_name.Focus();
        }
    }
}
