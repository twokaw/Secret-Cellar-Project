using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NCR_Printer;
using Shared;

namespace SecretCellar.Orders_Panels {
	public partial class Panel_SupplierOrder : ManagedPanel {
        private List<Inventory> _inventory = null;


        public Panel_SupplierOrder() {
			InitializeComponent();

			List<Supplier> suppliers = DataAccess.instance?.GetSuppliers() ?? new List<Supplier>();

            //POPULATE SUPPLIERS
            suppliers.Insert(0, new Supplier() {
                Name = "All",
                SupplierID = 0
            });

            cbx_supplier.DataSource = suppliers;
            cbx_supplier.DisplayMember = "Name";
            RefreshDataGrid();
        }


        /// <summary>
        /// Updates the selected item's order quantity.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_update_Click(object sender, EventArgs e) {
            if (supp_dataGrid.SelectedRows.Count > 0) {
                Inventory i = _inventory.First(x => x.Id == uint.Parse(supp_dataGrid.SelectedRows[0].Cells["id"].Value.ToString()));

                if (uint.TryParse(txt_update_qty.Text.Trim(), out uint newOrderQuantity)) i.OrderQty = newOrderQuantity;
                else {
                    txt_update_qty.Focus();
                    txt_update_qty.SelectAll();
                    MessageBox.Show("Invalid Order Quantity");

                    return;
                }

                DataAccess.instance.UpdateItem(i);
            }

            txt_update_qty.Text = "";
            RefreshDataGrid();
        }


        /// <summary>
        /// Prints the selected supplier's list of items.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_print_supp_Click(object sender, EventArgs e) {
            Supplier orderSupplier = (Supplier)cbx_supplier.SelectedItem;
            new PurchaseOrder(orderSupplier, ListItems(orderSupplier)).Print();
        }


        /// <summary>
        /// Open the ReceivedOrders form. Then refreshes the datagrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_received_Click(object sender, EventArgs e) {
            frmReceivedOrders receivedOrders = new frmReceivedOrders();
            receivedOrders.ShowDialog();

            RefreshDataGrid();
            txt_update_qty.Focus();
        }


		/// <summary>
		/// On selection change, get the selected item's order quantity and put it in the Update Quantity field.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void supp_dataGrid_SelectionChanged(object sender, EventArgs e) {
			if (supp_dataGrid.SelectedRows.Count > 0) {
				Inventory i = _inventory.First(x => x.Id == uint.Parse(supp_dataGrid.SelectedRows[0].Cells["id"].Value.ToString()));
				txt_update_qty.Text = i.OrderQty.ToString();
			}
		}


		private void chk_ShowHidden_CheckedChanged(object sender, EventArgs e) { RefreshDataGrid(); }

        private void chk_OnlyRequired_CheckedChanged(object sender, EventArgs e) { RefreshDataGrid(); }

		private void cbx_supplier_SelectedIndexChanged(object sender, EventArgs e) { RefreshDataGrid(); }


        /// <summary>
        /// Gets the list of items from the given supplier.
        /// </summary>
        /// <param name="orderSupplier"></param>
        /// <returns></returns>
		public List<Inventory> ListItems(Supplier orderSupplier) {
			_inventory = DataAccess.instance.GetInventory();
			return _inventory.Where(x => (orderSupplier.SupplierID == x.SupplierID || orderSupplier.SupplierID == 0) && x.RequiredQty > 0).OrderBy(x => x.Name).ToList();
		}


		/// <summary>
		/// Updates the order total.
		/// </summary>
		public void UpdateOrderTotal() {
			double total = 0;
			// All items with price * qty

			foreach (DataGridViewRow row in supp_dataGrid.Rows)
				if (row.Cells["orderqty"].Value.ToString() != null || uint.Parse(row.Cells["orderqty"].Value.ToString()) > 0)
					total += Convert.ToDouble((uint.Parse(row.Cells["orderqty"].Value.ToString()) * (Convert.ToDouble(row.Cells["Price"].Value.ToString()))));

			txt_supp_total.Text = total.ToString("C");
			txt_update_qty.Focus();
		}


		/// <summary>
		/// Refreshes the datagrid.
		/// </summary>
		public void RefreshDataGrid() {
			_inventory = DataAccess.instance?.GetInventory() ?? new List<Inventory>();
			uint id = ((Supplier)cbx_supplier?.SelectedItem)?.SupplierID ?? 0;
			supp_dataGrid.DataSource = _inventory.Where(x => (id == x.SupplierID || id == 0)
														 && (!x.Hidden || chk_ShowHidden.Checked)
														 && (x.RequiredQty > 0 || !chk_OnlyRequired.Checked))
				.Select(x => new {
					x.Name,
					x.Id,
					x.ItemType,
					x.Qty,
					x.Barcode,
					Price = x.SupplierPrice,
					minqty = x.InvMin,
					maxqty = x.InvMax,
					x.OrderQty,
					x.RequiredQty,
					x.RequestQty
				})
				.OrderBy(x => x.Name)
				.ToList();

			UpdateOrderTotal();
		}
	}
}
