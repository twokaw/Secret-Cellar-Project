using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;




namespace SecretCellar.Orders_Panels {
	public partial class Panel_Fulfillment : UserControl {
        private List<Inventory> inventory = null;



        public Panel_Fulfillment() {
			InitializeComponent();

            inventory = DataAccess.instance?.GetInventory();

            cbx_fullfill_cust.DataSource = DataAccess.instance?.GetCustomerOrder();
            cbx_fullfill_cust.DisplayMember = "FullName";
            fullfill_datagrid.Columns[7].DefaultCellStyle.Format = "C";
            fullfill_datagrid.Columns[8].DefaultCellStyle.Format = "C";

            if (cbx_fullfill_cust.SelectedItem != null) {
                RefreshFillment();
                /*
                fullfill_datagrid.DataSource = ((CustomerOrder)cbx_fullfill_cust.SelectedItem).Items.
                               Select(x => new
                               {
                                   fname = x.Name,
                                   fid = x.Id,
                                   ftype = x.ItemType,
                                   fqty = x.Qty,
                                   fbarcode = x.Barcode,
                                   fprice = x.Price,
                                   frequestqty = x.RequestQty
                               }).
                               OrderBy(x => x.fname).
                               ToList();
                */
            }
        }


        /// <summary>
        /// Set the delivered quantity of the selected item by the amount in the Qty Delivered text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delivered_update_Click(object sender, EventArgs e) {
            CustomerOrder custorder = DataAccess.instance.GetCustomerOrderforCustomer(((CustomerOrder)cbx_fullfill_cust.SelectedItem).CustomerID, false);

            Inventory i = inventory.First(x => x.Id == uint.Parse(fullfill_datagrid.SelectedRows[0].Cells["Id"].Value.ToString()));
            CustomerOrderItem coid = custorder.Items.FirstOrDefault(x => x.Id == i.Id);

            if (fullfill_datagrid.SelectedRows.Count > 0) {
                //i.AllQty.Add(new InventoryQty { Qty = custorder.qty });
                // i.OrderQty.Add(new CustomerOrder {RequestQty = coid.RequestQty, DeliveredDate = DateTime.Now, SupplierPrice = 0 });
                if (uint.TryParse(txt_deliverqty.Text.Trim(), out uint dqty)) {
                    coid.DeliverQty = dqty;
                    DataAccess.instance.UpdateCustomerOrderItem(coid);
                }
                else {
                    txt_deliverqty.Focus();
                    txt_deliverqty.SelectAll();
                    MessageBox.Show("Invalid Order Quantity");

                    return;
                }
            }

            /*
            else if (uint.TryParse(txt_deliverqty.Text.Trim(), out uint order))
            {

                if (coid.RequestQty >= order)
                {
                    coid.RequestQty -= order;
                }
                else
                {
                    i.OrderQty = 0;
                }
            }
            */

            txt_deliverqty.Text = "";
            refreshcust();
            //RefreshFillment();
        }

        private void refreshcust()
        {
            RefreshFillment(((CustomerOrder)cbx_fullfill_cust.SelectedItem).CustomerID);
            /*fullfill_datagrid.DataSource = ((CustomerOrder)cbx_fullfill_cust.SelectedItem).Items.
               Select(x => new
               {
                   fname = x.Name,
                   fid = x.Id,
                   ftype = x.ItemType,
                   fqty = x.Qty,
                   fbarcode = x.Barcode,
                   fprice = x.Price,
                   frequestqty = x.RequestQty
               }).
               OrderBy(x => x.fname).
               ToList();
            */
        }

        /// <summary>
        /// Deliver all the items.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_deliver_all_Click(object sender, EventArgs e) {
            CustomerOrder custorder = DataAccess.instance.GetCustomerOrderforCustomer(((CustomerOrder)cbx_fullfill_cust.SelectedItem).CustomerID, false);

            foreach (DataGridViewRow row in fullfill_datagrid.Rows) {
                Inventory i = inventory.First(x => x.Id == uint.Parse(row.Cells["id"].Value.ToString()));
                CustomerOrderItem coid = custorder.Items.FirstOrDefault(x => x.Id == i.Id);
                coid.DeliverQty = uint.Parse(row.Cells["requestqty"].Value.ToString());
                DataAccess.instance.UpdateCustomerOrderItem(coid);
            }

            txt_deliverqty.Text = "";
            refreshcust();
            //RefreshFillment();
        }


        /// <summary>
        /// Deliver the selected items.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_deliver_selected_Click(object sender, EventArgs e) {
            CustomerOrder custorder = DataAccess.instance.GetCustomerOrderforCustomer(((CustomerOrder)cbx_fullfill_cust.SelectedItem).CustomerID, false);

            foreach (DataGridViewRow row in fullfill_datagrid.SelectedRows) {
                Inventory i = inventory.First(x => x.Id == uint.Parse(row.Cells["id"].Value.ToString()));
                CustomerOrderItem coid = custorder.Items.FirstOrDefault(x => x.Id == i.Id);
                coid.DeliverQty = uint.Parse(row.Cells["requestqty"].Value.ToString());
                DataAccess.instance.UpdateCustomerOrderItem(coid);
            }

            txt_deliverqty.Text = "";
            RefreshFillment(custorder.CustomerID);
            //refreshcust();
        }


        /// <summary>
        /// Refresh the datagrid by calling the RefreshFillment method that takes a customer id as a parameter.
        /// </summary>
        private void RefreshFillment() {
            RefreshFillment(((CustomerOrder)cbx_fullfill_cust.SelectedItem).CustomerID);
        }


        /// <summary>
        /// Refresh the datagrid.
        /// </summary>
        /// <param name="customerId"></param>
        private void RefreshFillment(uint customerId) {
            List<CustomerOrderItem> custItems = (DataAccess.instance.GetCustomerOrderforCustomer(customerId)?.Items ?? new List<CustomerOrderItem>())./*Where(x => x.DeliverQty < x.RequestQty).*/ToList();

            fullfill_datagrid.DataSource = inventory
                .GroupJoin(custItems, i => i.Id, o => o.Id, (i, o) => new {
                    Inv = i,
                    Ord = o.SingleOrDefault()
                })
                .Where(x => (x.Ord != null))
                .Select(x => new {
                    id = x.Inv.Id,
                    barcode = x.Inv.Barcode,
                    name = x.Inv.Name,
                    qty = x.Inv.Qty,
                    orderqty = x.Inv.OrderQty,
                    requestqty = x.Ord.RequestQty,
                    price = x.Inv.Price,
                    due = x.Ord.RequestQty * x.Inv.Price - x.Ord.Paid
                })
                .ToList();
        }


        // frefresh updates fullfillment datagrid refresh on customer selection change
        private void frefresh(object sender, EventArgs e)
        {
            /*fullfill_datagrid.DataSource = ((CustomerOrder)cbx_fullfill_cust.SelectedItem).Items.
                              Select(x => new
                              {
                                  fname = x.Name,
                                  fid = x.Id,
                                  ftype = x.ItemType,
                                  fqty = x.Qty,
                                  fbarcode = x.Barcode,
                                  fprice = x.Price,
                                  frequestqty = x.RequestQty
                              }).
                              OrderBy(x => x.fname).
                              ToList();

        private void cbx_fullfill_cust_SelectedIndexChanged(object sender, EventArgs e)
        {
           */
            uint cid = ((CustomerOrder)cbx_fullfill_cust.SelectedItem).CustomerID;
            RefreshFillment(cid);
        }

    }
}
