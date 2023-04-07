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
using System.Windows.Forms;

namespace SecretCellar
{
    public partial class frmReceivedOrders : ManagedForm

    {
        private List<Supplier> suppliers = null;
        public frmReceivedOrders()
        {
            InitializeComponent();
            suppliers = DataAccess.instance.GetSuppliers();
            suppliers.Insert(0, new Supplier()
            {
                Name = "All",
                SupplierID = 0

            });

            txt_received_qty.Focus();
            received_dataGrid.Columns[5].DefaultCellStyle.Format = "C";
            cbx_supplier.DataSource = suppliers;
            cbx_supplier.DisplayMember = "Name";

            received_dataGrid.DataSource = DataAccess.instance.GetInventory().Where(x => x.OrderQty > 0).
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

            if (received_dataGrid.SelectedRows.Count > 0)
            {
                
                Inventory i = DataAccess.instance.GetInventory().First(x => x.Id == uint.Parse(received_dataGrid.SelectedRows[0].Cells["id"].Value.ToString()));
                

                if (uint.TryParse(txt_received_qty.Text.Trim(), out uint order)) 
                {

                    if (i.OrderQty >= order)
                    {
                        i.OrderQty -= order;
                    }
                    else
                    {
                        i.OrderQty = 0;
                    }
                    
                   
                    if (i.AllQty.Count == 0)
                    {
                        i.AllQty.Add(new InventoryQty { Qty = order, PurchasedDate = DateTime.Now, SupplierPrice = 0 });
                    }
                    else
                    {
                        i.AllQty[0].Qty += order;
                        i.AllQty[0].PurchasedDate = DateTime.Now;
                    }
                }
                else
                {
                    txt_received_qty.Focus();
                    txt_received_qty.SelectAll();
                    MessageBox.Show("Invalid Quantity");

                    return;
                }

                DataAccess.instance.UpdateItem(i);
            }

            refresh();
            txt_received_qty.Text = "";
        }

        private void refresh()
        {
            uint id = ((Supplier)cbx_supplier.SelectedItem).SupplierID;
            received_dataGrid.DataSource = DataAccess.instance.GetInventory().Where(x => (id == x.SupplierID || id == 0) && x.OrderQty > 0).
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

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_all_received_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in received_dataGrid.Rows)
            {
                Inventory i = DataAccess.instance.GetInventory().First(x => x.Id == uint.Parse(row.Cells["id"].Value.ToString()));
                i.AllQty[0].Qty += uint.Parse(row.Cells["OrderQty"].Value.ToString());
                i.OrderQty = 0;
                i.AllQty[0].PurchasedDate = DateTime.Now;
                DataAccess.instance.UpdateItem(i);
            }

            refresh();
        }

        private void frmReceivedOrders_Load(object sender, EventArgs e)
        {

        }
    }
}
