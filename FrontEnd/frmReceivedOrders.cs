using System;
using Shared;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;



namespace SecretCellar {
    public partial class frmReceivedOrders : ManagedForm {
        public frmReceivedOrders() {
            InitializeComponent();

			List<Supplier> suppliers = DataAccess.instance.GetSuppliers();
            suppliers.Insert(0, new Supplier() {
                Name = "All",
                SupplierID = 0
            });

            txt_received_qty.Focus();
            received_dataGrid.Columns[5].DefaultCellStyle.Format = "C";
            cbx_supplier.DataSource = suppliers;
            cbx_supplier.DisplayMember = "Name";
            cbx_supplier.SelectedIndex = 0;
        }


        private void cbx_supplier_SelectedIndexChanged(object sender, EventArgs e) { RefreshTable(); }


        private void btn_update_Click(object sender, EventArgs e) {
            if (received_dataGrid.SelectedRows.Count <= 0) {
				txt_received_qty.Focus();
				txt_received_qty.SelectAll();
				MessageBox.Show("Quantity received needs to be greater than 0.");
				return;
			}

			Inventory inventory = DataAccess.instance.GetInventory().First(x => x.Id == uint.Parse(received_dataGrid.SelectedRows[0].Cells["id"].Value.ToString()));
            if (inventory == null) {
				txt_received_qty.Focus();
				txt_received_qty.SelectAll();
				MessageBox.Show("Inventory item was not found.");
				return;
			}

			if (uint.TryParse(txt_received_qty.Text.Trim(), out uint quantityToReceive)) {
                if (quantityToReceive > inventory.OrderQty) {
                    if (!frmManagerOverride.DidOverride("Quantity to receive is greater than quantity ordered.")) {
						txt_received_qty.Focus();
						txt_received_qty.SelectAll();
						return;
					}
				}

				if (inventory.OrderQty >= quantityToReceive) inventory.OrderQty -= quantityToReceive;
				else inventory.OrderQty = 0;

				if (inventory.AllQty.Count == 0) {
					inventory.AllQty.Add(new InventoryQty { Qty = quantityToReceive, PurchasedDate = DateTime.Now, SupplierPrice = 0 });
				}
				else {
					inventory.AllQty[0].Qty += quantityToReceive;
					inventory.AllQty[0].PurchasedDate = DateTime.Now;
				}
			}
			else {
				txt_received_qty.Focus();
				txt_received_qty.SelectAll();
				MessageBox.Show("Invalid Quantity");
				return;
			}

			DataAccess.instance.UpdateItem(inventory);

			RefreshTable();
            txt_received_qty.Text = "";
        }


		private void btn_all_received_Click(object sender, EventArgs e) {
			foreach (DataGridViewRow row in received_dataGrid.Rows) {
				Inventory inventory = DataAccess.instance.GetInventory().First(x => x.Id == uint.Parse(row.Cells["id"].Value.ToString()));
				if (inventory == null) {
					MessageBox.Show("Inventory item was not found.");
					continue;
				}

				if (inventory.AllQty.Count == 0) {
					inventory.AllQty.Add(new InventoryQty { Qty = inventory.OrderQty, PurchasedDate = DateTime.Now, SupplierPrice = 0 });
				}
				else {
					inventory.AllQty[0].Qty += inventory.OrderQty;
					inventory.AllQty[0].PurchasedDate = DateTime.Now;
				}

				inventory.OrderQty = 0;
				DataAccess.instance.UpdateItem(inventory);
			}

			RefreshTable();
		}


		private void RefreshTable() {
            uint id = ((Supplier)cbx_supplier.SelectedItem).SupplierID;

            received_dataGrid.DataSource = DataAccess.instance.GetInventory().Where(x => (id == x.SupplierID || id == 0) && x.OrderQty > 0)
                .Select(x => new {
                   Name = x.Name,
                   Id = x.Id,
                   ItemType = x.ItemType,
                   Qty = x.Qty,
                   Barcode = x.Barcode,
                   Price = x.SupplierPrice,
                   minqty = x.InvMin,
                   maxqty = x.InvMax,
                   orderqty = x.OrderQty
                })
                .OrderBy(x => x.Name)
                .ToList();
        }


        private void btn_close_Click(object sender, EventArgs e) { this.Close(); }

        
        private void frmReceivedOrders_Load(object sender, EventArgs e) { }
    }
}
