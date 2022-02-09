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


            RefreshSupplier();
        }

        /////////
        //REFRESH
        /////////
        public void RefreshSupplier()
        {
            inventory = DataAccess.instance?.GetInventory() ?? new List<Inventory>();
            uint id = ((Supplier)cbx_supplier?.SelectedItem)?.SupplierID ?? 0;
            supp_dataGrid.DataSource = inventory.Where(x => (id == x.SupplierID || id == 0) 
                                                         && (!x.Hidden || chk_ShowHidden.Checked)
                                                         && (x.RequiredQty > 0 || !chk_OnlyRequired.Checked)).
               Select(x => new {
                   x.Name,
                   x.Id,
                   x.ItemType,
                   x.Qty,
                   x.Barcode,
                   Price = x.SupplierPrice,
                   minqty = x.InvMin,
                   maxqty = x.InvMax,
                   x.OrderQty,
                   x.RequiredQty
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
                        total += Convert.ToDouble((uint.Parse(row.Cells["orderqty"].Value.ToString()) * (Convert.ToDouble(row.Cells["Price"].Value.ToString()))));
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
            RefreshSupplier();
            //orderTotal();
        }


        ///////////////////////
        //GET THE LIST OF ITEMS
        ///////////////////////
        public List<Inventory> listItems(Supplier orderSupplier) {
            inventory = DataAccess.instance.GetInventory();
            withQty = inventory.Where(x => (orderSupplier.SupplierID == x.SupplierID || orderSupplier.SupplierID == 0) && x.RequiredQty > 0).
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
            RefreshSupplier();
        }


        ///////////////////
        //ON RECEIVED CLICK
        ///////////////////
        private void btn_received_Click(object sender, EventArgs e) {
            frmReceivedOrders receivedOrders = new frmReceivedOrders();
            receivedOrders.ShowDialog();

            RefreshSupplier();
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

        private void supp_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chk_ShowHidden_CheckedChanged(object sender, EventArgs e)
        {
            RefreshSupplier();
        }

        private void chk_OnlyRequired_CheckedChanged(object sender, EventArgs e)
        {
            RefreshSupplier();
        }
    }
}
