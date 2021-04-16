using System;
using SecretCellar;
using Shared;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SecretCellar
{
    public partial class frmOrders : Form
    {
        private DataAccess dataAccess = new DataAccess(Properties.Settings.Default.URL);
        private List<Supplier> suppliers = null;
        private List<Inventory> inventory = null;

        public frmOrders(Transaction transaction)
        {
            InitializeComponent();
            inventory = dataAccess.GetInventory();
            suppliers = dataAccess.GetSuppliers();
            cbx_supplier.DataSource = suppliers;
            cbx_supplier.DisplayMember = "Name";


            supp_dataGrid.DataSource = inventory.
                Select(x => new {
                    Name = x.Name,
                    Id = x.Id,
                    ItemType = x.ItemType,
                    Qty = x.Qty,
                    Barcode = x.Barcode,
                    Price = x.SupplierPrice,
                    minqty = x.InvMin,
                    maxqty = x.InvMax,
                    orderqty = x.OrderQty
                }).
                OrderBy(x => x.Name).
                ToList();
        }

        private void cust_request_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_prod_add_Click(object sender, EventArgs e)
        {
            //request_dataGrid.Rows.Add(["Customer Name"] == txt_cust_name.Text, ["Product Name"] == txt_prod_name.Text);
        }

        private void refresh()
        {
            supp_dataGrid.DataSource = inventory.Where(x => ((Supplier)cbx_supplier.SelectedItem).SupplierID == x.SupplierID).
               Select(x => new {
                   Name = x.Name,
                   Id = x.Id,
                   ItemType = x.ItemType,
                   Qty = x.Qty,
                   Barcode = x.Barcode,
                   Price = x.SupplierPrice,
                   minqty = x.InvMin,
                   maxqty = x.InvMax,
                   orderqty = x.OrderQty
               }).
               OrderBy(x => x.Name).
               ToList();
        }

        private void cbx_supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (supp_dataGrid.SelectedRows.Count > 0)
            {
                Inventory i = inventory.First(x => x.Id == uint.Parse(supp_dataGrid.SelectedRows[0].Cells["id"].Value.ToString()));

               
                if (uint.TryParse(txt_update_qty.Text.Trim(), out uint order)) i.OrderQty = order;
                else
                {
                    txt_update_qty.Focus();
                    txt_update_qty.SelectAll();
                    MessageBox.Show("Invalid Order Quantity");
                    return;
                }

                dataAccess.UpdateItem(i);
            }
        }
    }
}
