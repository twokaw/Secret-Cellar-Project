using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NCR_Printer;
using Shared;



namespace SecretCellar.Orders_Panels {
	public partial class Panel_SupplierOrder : UserControl {
        private List<Inventory> inventory = null;
        private List<Inventory> withQty = null;
        private List<Supplier> suppliers = null;

        public Panel_SupplierOrder() {
			InitializeComponent();
            inventory = DataAccess.instance?.GetInventory() ?? new List<Inventory> ();
            suppliers = DataAccess.instance?.GetSuppliers() ?? new List<Supplier>();

            //POPULATE SUPPLIERS
            suppliers.Insert(0, new Supplier()
            {
                Name = "All",
                SupplierID = 0
            });

            cbx_supplier.DataSource = suppliers;
            cbx_supplier.DisplayMember = "Name";

            //POPULATE DATA GRID
            supp_dataGrid.DataSource = inventory.
                Select(x => new
                {
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

        /////////
        //REFRESH
        /////////
        private void refresh() {
            inventory = DataAccess.instance.GetInventory();
            uint id = ((Supplier)cbx_supplier.SelectedItem).SupplierID;
            supp_dataGrid.DataSource = inventory.Where(x => id == x.SupplierID || id == 0).
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
            orderTotal();
        }


        /////////////
        //ORDER TOTAL
        /////////////
        public void orderTotal() {
            {
                double total = 0;
                // All items with price * qty

                foreach (DataGridViewRow row in supp_dataGrid.Rows) {
                    if (row.Cells["orderqty"].Value.ToString() != null || uint.Parse(row.Cells["orderqty"].Value.ToString()) > 0) {
                        total = total + Convert.ToDouble((uint.Parse(row.Cells["orderqty"].Value.ToString()) * (Convert.ToDouble(row.Cells["Price"].Value.ToString()))));
                    }
                }
                txt_supp_total.Text = total.ToString("C");
                txt_update_qty.Focus();
            }
        }


        ///////////
        //ON UPDATE
        ///////////
        private void btn_update_Click(object sender, EventArgs e) {
            if (supp_dataGrid.SelectedRows.Count > 0) {
                Inventory i = inventory.First(x => x.Id == uint.Parse(supp_dataGrid.SelectedRows[0].Cells["id"].Value.ToString()));


                if (uint.TryParse(txt_update_qty.Text.Trim(), out uint order)) i.OrderQty = order;
                else {
                    txt_update_qty.Focus();
                    txt_update_qty.SelectAll();
                    MessageBox.Show("Invalid Order Quantity");

                    return;
                }

                DataAccess.instance.UpdateItem(i);
            }
            txt_update_qty.Text = "";
            refresh();
            //orderTotal();
        }


        ///////////////////////
        //GET THE LIST OF ITEMS
        ///////////////////////
        public List<Inventory> listItems(Supplier orderSupplier) {
            inventory = DataAccess.instance.GetInventory();
            withQty = inventory.Where(x => (orderSupplier.SupplierID == x.SupplierID || orderSupplier.SupplierID == 0) && x.OrderQty > 0).
            OrderBy(x => x.Name)
            .ToList();

            return withQty;
        }


        ///////////////////////
        //ON PRINT BUTTON CLICK
        ///////////////////////
        private void btn_print_supp_Click(object sender, EventArgs e) {
            Supplier orderSupplier = (Supplier)cbx_supplier.SelectedItem;
            withQty = listItems(orderSupplier);
            new PurchaseOrder(orderSupplier, withQty).Print();
        }


        //////////////////////
        //ON CHANGING SUPPLIER
        //////////////////////
        private void cbx_supplier_SelectedIndexChanged(object sender, EventArgs e) {
            refresh();
        }


        ///////////////////
        //ON RECEIVED CLICK
        ///////////////////
        private void btn_received_Click(object sender, EventArgs e) {
            frmReceivedOrders receivedOrders = new frmReceivedOrders();
            receivedOrders.ShowDialog();

            refresh();
            txt_update_qty.Focus();
        }


        /////////////////////////////////
        //ON CHANGING DATA GRID SELECTION
        /////////////////////////////////
        private void supp_dataGrid_SelectionChanged(object sender, EventArgs e) {
            if (supp_dataGrid.SelectedRows.Count > 0) {
                Inventory i = inventory.First(x => x.Id == uint.Parse(supp_dataGrid.SelectedRows[0].Cells["id"].Value.ToString()));
                txt_update_qty.Text = i.OrderQty.ToString();
            }
        }

        private void Panel_SupplierOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
