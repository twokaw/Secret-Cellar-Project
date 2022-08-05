using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SecretCellar.Settings_Panels
{
    public partial class PanTypes : UserControl
    {
        private List<Discount> discounts = null;
        public Discount newDiscount = null;

        public PanTypes()
        {
            InitializeComponent();
        }

        private void PanTypes_Load(object sender, EventArgs e)
        {
            if(DataAccess.instance != null)
            {
                getDiscounts();
                lstTypes.DataSource = DataAccess.instance?.GetInventoryType();
                cbx_tax.DataSource = DataAccess.instance?.GetTax();
                lstTypes.DisplayMember = "TypeName";
                cbx_tax.DisplayMember = "TaxName";
            }
        }

        private void lstTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            InventoryType it = (InventoryType)lstTypes.SelectedItem;

            txt_bottleDep.Text = it.BottleDeposit.ToString();
            txt_salesTax.Text = it.SalesTax.ToString();
            txt_localTax.Text = it.LocalSalesTax.ToString();
            txt_typename.Text = it.TypeName.ToString();
            txt_MinQty.Text = it.Min_qty.ToString();
            txt_MaxQty.Text = it.Max_qty.ToString();
            txt_Bottles.Text = it.Bottles.ToString();
            txt_orderIncrement.Text = it.OrderIncrement.ToString();
            cbx_tax.Text = it.TaxName;
            for (int i = 0; i < chk_lst_discount.Items.Count; i++)
                chk_lst_discount.SetItemChecked(i, ((InventoryType)lstTypes.SelectedItem).Discount.FirstOrDefault(x => x.DiscountName == chk_lst_discount.Items[i].ToString()) != null);

            List<Inventory> inventoryList = DataAccess.instance.GetInventory();
            List<Inventory> filteredInventoryList = inventoryList.FindAll((inventory) => inventory.TypeID == ((InventoryType)lstTypes.SelectedItem).TypeId);

            textBox_itemsUsingInventory.Text = filteredInventoryList.Count + "";

            button_deleteInventory.Enabled = (filteredInventoryList.Count == 0);
        }

        private void btn_type_clear_Click(object sender, EventArgs e)
        {
            txt_typename.Text = "";
            cbx_tax.SelectedItem = 0;
            txt_Bottles.Text = "0";
            txt_MaxQty.Text = "0";
            txt_MinQty.Text = "0";
            txt_orderIncrement.Text = "0";
            txt_typename.Focus();
        }

        private void btn_new_type_Click(object sender, EventArgs e)
        {
            if (DataAccess.instance.GetInventoryType(txt_typename.Text) == null)
            {
                InventoryType i = new InventoryType
                {
                    TypeName = txt_typename.Text.Trim(),
                    Bottles = uint.Parse(txt_Bottles.Text.Trim()),
                    Max_qty = uint.Parse(txt_MaxQty.Text.Trim()),
                    Min_qty = uint.Parse(txt_MinQty.Text.Trim()),
                    OrderIncrement  = uint.Parse(txt_orderIncrement.Text.Trim()),
                    IdTax = ((Tax)cbx_tax.SelectedItem).IdTax
                };
                DataAccess.instance.UpdateInventoryType(i);
                
                //REFRESH LIST
                lstTypes.DataSource = DataAccess.instance?.GetInventoryType();
            }
        }


        private void btn_update_type_Click(object sender, EventArgs e)
        {
            InventoryType i = (InventoryType)lstTypes.SelectedItem;
            i.TypeName = txt_typename.Text.Trim();
            i.Bottles = uint.Parse(txt_Bottles.Text.Trim());
            i.Max_qty = uint.Parse(txt_MaxQty.Text.Trim());
            i.Min_qty = uint.Parse(txt_MinQty.Text.Trim());
            i.OrderIncrement = uint.Parse(txt_orderIncrement.Text.Trim());
            i.IdTax = ((Tax)cbx_tax.SelectedItem).IdTax;

            for (int j = 0; j < chk_lst_discount.Items.Count; j++)
            {
                Discount d = i.Discount.FirstOrDefault(x => x.DiscountName == (string)chk_lst_discount.Items[j]);

                if (chk_lst_discount.GetItemChecked(j) && d == null)
                    i.Discount.Add(discounts.First(x => x.DiscountName == (string)chk_lst_discount.Items[j]));
                else if (!chk_lst_discount.GetItemChecked(j) && d != null)
                    i.Discount.Remove(d);
            }

            DataAccess.instance.UpdateInventoryType(i);

            //REFRESH LIST
            lstTypes.DataSource = DataAccess.instance?.GetInventoryType();
        }

        private void chk_lst_discount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chk_lst_discount.SelectedItem != null)
            {
                Discount selected = discounts.FirstOrDefault(x => x.DiscountName == chk_lst_discount.SelectedItem.ToString());
            }
        }

		private void button_deleteInventory_Click(object sender, EventArgs e) {
            if (lstTypes.SelectedItem == null) return; 

            DataAccess.instance.DeleteInventoryType(((InventoryType)lstTypes.SelectedItem).TypeId);

            lstTypes.DataSource = DataAccess.instance?.GetInventoryType();
        }

        private void populate() {
            chk_lst_discount.Items.Clear();
            discounts = DataAccess.instance.GetDiscount();
            discounts?.ForEach(x => chk_lst_discount.Items.Add(x.DiscountName));
        }

        private void panel3_VisibleChanged(object sender, EventArgs e)
        {
            getDiscounts();
        }

        private void getDiscounts()
        {
            chk_lst_discount.Items.Clear();
            discounts = DataAccess.instance?.GetDiscount();
            discounts?.ForEach(x => chk_lst_discount.Items.Add(x.DiscountName));
        }

        //private void PanTypes_VisibleChanged(object sender, EventArgs e)
        //{
        //    panMain.Visible = this.Visible;
        //}
    }
}
