using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;



namespace SecretCellar.Orders_Panels {
	public partial class Panel_CustomerOrder : UserControl {
		public Panel_CustomerOrder() {
			InitializeComponent();

			cbx_cust_custorder.DataSource = DataAccess.instance?.GetCustomer() ?? new List<Customer> ();

			if (DataAccess.instance != null) {
				cbx_supp_custorder.Items.Add("");
				cbx_supp_custorder.Items.AddRange(DataAccess.instance.GetSuppliers().Select(x => x.Name).ToArray());
			}
		}


		/// <summary>
		/// On selected index change.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbx_cust_custorder_SelectedIndexChanged(object sender, EventArgs e) {
			uint cid = ((Customer)cbx_cust_custorder.SelectedItem).CustomerID;
			RefreshFavorite(cid);
		}


		/// <summary>
		/// On click add favorites.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnFavoritesAdd_Click(object sender, EventArgs e) {
			uint cid = ((Customer)cbx_cust_custorder.SelectedItem).CustomerID;
			Transaction t = new Transaction();
			DataAccess.instance.ShowLookupForm(t, "Add to Favorites");

			foreach (Item i in t.Items)
				DataAccess.instance.AddCustomerFavorite(cid, i.Id);

			RefreshFavorite(cid);
		}


		/// <summary>
		/// On click remove favorites.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnFavoritesRemove_Click(object sender, EventArgs e) {
			if (custOrder_datagrid.SelectedRows.Count > 0) {
				uint cid = ((Customer)cbx_cust_custorder.SelectedItem).CustomerID;
				uint iid = DataAccess.instance.GetInventory().FirstOrDefault(x => x.Name == custOrder_datagrid.SelectedRows[0].Cells["CustOrdName"].Value.ToString()).Id;

				DataAccess.instance.DeleteCustomerFavorite(cid, iid);

				RefreshFavorite(cid);
			}
		}


		/// <summary>
		/// On click Add Order.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnAddOrder_Click(object sender, EventArgs e) {

			Transaction t = new Transaction {
				CustomerID = ((Customer)cbx_cust_custorder.SelectedItem).CustomerID
			};

			DataAccess.instance.ShowLookupForm(t);

			if (t.Items.Count > 0) {
				CustomerOrder co = DataAccess.instance.GetCustomerOrderforCustomer(t.CustomerID) ?? new CustomerOrder() {
					CustomerID = t.CustomerID
				};

				foreach (Item i in t.Items) {
					CustomerOrderItem coi = co.Items.FirstOrDefault(x => x.Id == i.Id);

					if (coi == null)
						DataAccess.instance.NewCustomerOrderItem(co.CustomerID, new CustomerOrderItem { Id = i.Id, RequestQty = 1 });
					else {
						coi.RequestQty++;
						DataAccess.instance.UpdateCustomerOrderItem(coi);
					}
				}

				//DataAccess.instance.UpdateCustomerOrderforCustomer(co);
			}

			RefreshFavorite(t.CustomerID);
		}


		/// <summary>
		/// On click update order.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_update_custorder_Click(object sender, EventArgs e) {
			if (custOrder_datagrid.SelectedRows.Count > 0) {
				uint cid = ((Customer)cbx_cust_custorder.SelectedItem).CustomerID;
				if (cid > 0) {
					uint iid = Convert.ToUInt32(custOrder_datagrid.SelectedRows[0].Cells["CustOrd_id"].Value?.ToString());

					CustomerOrder co = DataAccess.instance.GetCustomerOrderforCustomer(cid) ?? new CustomerOrder();
					CustomerOrderItem coi = co.Items.FirstOrDefault(x => x.Id == iid) ?? new CustomerOrderItem {
						Id = iid
					};

					if (coi == null)
						DataAccess.instance.NewCustomerOrderItem(cid, new CustomerOrderItem {
							Id = iid,
							RequestQty = Convert.ToUInt32(txt_orderqty_custorder.Text)
						});
					else {
						coi.RequestQty = Convert.ToUInt32(txt_orderqty_custorder.Text);
						coi.CustomerOrderItemID = cid;
						DataAccess.instance.UpdateCustomerOrderItem(coi);
					}

					//DataAccess.instance.UpdateCustomerOrder(co);
					RefreshFavorite(cid);
				}
			}
		}


		/// <summary>
		/// On Keypress.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txt_orderqty_custorder_KeyPress(object sender, KeyPressEventArgs e) {
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}


		/// <summary>
		/// When the supplier checkbox is changed.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbx_supp_custorder_SelectedIndexChanged(object sender, EventArgs e) {
			uint cid = ((Customer)cbx_cust_custorder.SelectedItem).CustomerID;
			RefreshFavorite(cid);
		}


		/// <summary>
		/// Refresh the favorites list.
		/// </summary>
		/// <param name="customerId"></param>
		private void RefreshFavorite(uint customerId) {
			List<CustomerFavorite> custFav = DataAccess.instance.GetCustomerFavorite(customerId).Favorites;
			List<CustomerOrderItem> custItems = (DataAccess.instance.GetCustomerOrderforCustomer(customerId)?.Items ?? new List<CustomerOrderItem>()).Where(x => x.DeliverQty < x.RequestQty).ToList();

			custOrder_datagrid.DataSource = DataAccess.instance.GetInventory()
				.GroupJoin(custFav, i => i.Id, f => f.InventoryID, (i, f) => new {
					Inv = i,
					Fav = f.SingleOrDefault()
				})
				//.Where(x => x.Fav.InventoryID != 0 && !x.Inv.Hidden)
				.GroupJoin(custItems, i => i.Inv.Id, o => o.Id, (i, o) => new {
					i.Inv,
					i.Fav,
					Ord = o.SingleOrDefault()
				})
				.Where(x => x.Fav != null && (!x.Inv.Hidden || x.Ord != null) &&
							(cbx_supp_custorder.Text == "" ||
							 DataAccess.instance?.GetSuppliers().First(supplier => supplier.Name == cbx_supp_custorder.Text).SupplierID == x.Inv.SupplierID))
				.Select(x => new {
					x.Inv.Id,
					x.Inv.Name,
					x.Inv.Qty,
					x.Inv.OrderQty,
					Requsted = x.Ord?.RequestQty,
					x.Inv.Price,
					x.Fav?.Lastused
				})
				.ToList();
		}

        private void custOrder_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
