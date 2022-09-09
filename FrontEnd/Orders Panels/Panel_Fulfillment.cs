using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;




namespace SecretCellar.Orders_Panels {
	public partial class Panel_Fulfillment : UserControl {
        private List<Inventory> inventory = null;

        private readonly Dictionary<uint, Transaction> transactions = new Dictionary<uint, Transaction>();

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
            if (cbx_fullfill_cust.SelectedIndex >= 0)
            {
                if (frmManagerOverride.DidOverride("Update Delivered")) {
                    CustomerOrder custorder = DataAccess.instance.GetCustomerOrderforCustomer(((CustomerOrder)cbx_fullfill_cust.SelectedItem).CustomerID, false);

                    Inventory i = inventory.First(x => x.Id == uint.Parse(fullfill_datagrid.SelectedRows[0].Cells["id"].Value.ToString()));
                    CustomerOrderItem coid = custorder.Items.FirstOrDefault(x => x.Id == i.Id);

                    if (fullfill_datagrid.SelectedRows.Count > 0) {
                        uint tId = GetInvoiceID(custorder.CustomerID);
                        //i.AllQty.Add(new InventoryQty { Qty = custorder.qty });
                        // i.OrderQty.Add(new CustomerOrder {RequestQty = coid.RequestQty, DeliveredDate = DateTime.Now, SupplierPrice = 0 });
                        if (uint.TryParse(txt_deliverqty.Text.Trim(), out uint dqty)) {
                            coid.DeliverQty += dqty;
                            DataAccess.instance.UpdateCustomerOrderItem(custorder.CustomerID, tId, coid);
                            i.AllQty.Remove(new InventoryQty { Qty = Convert.ToUInt32(fullfill_datagrid.SelectedRows[0].Cells["qty"].Value.ToString()) - coid.DeliverQty });
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
                }
            }
            else
            {
                MessageBox.Show("Please select an item to deliver");
            }
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
            if (frmManagerOverride.DidOverride("Deliver All")) {
                CustomerOrder custorder = DataAccess.instance.GetCustomerOrderforCustomer(((CustomerOrder)cbx_fullfill_cust.SelectedItem).CustomerID, false);

                uint tId = GetInvoiceID(custorder.CustomerID);
                foreach (DataGridViewRow row in fullfill_datagrid.Rows) {
                    Inventory i = inventory.First(x => x.Id == uint.Parse(row.Cells["id"].Value.ToString()));
                    CustomerOrderItem coid = custorder.Items.FirstOrDefault(x => x.Id == i.Id);
                    coid.DeliverQty = uint.Parse(row.Cells["requestqty"].Value.ToString());
                    DataAccess.instance.UpdateCustomerOrderItem(custorder.CustomerID, tId, coid);
                }

                txt_deliverqty.Text = "";
                refreshcust();
                //RefreshFillment();
            }
        }

        private uint GetInvoiceID(uint customerId)
        {
            if (!transactions.ContainsKey(customerId) 
            || DialogResult.No == MessageBox.Show(this, "Would you like to use the current Invoice (Yes) or create a new one (No)", "User Current Invoice", MessageBoxButtons.YesNo))
            {
                transactions.Add(customerId, new Transaction()
                {
                    TranType = Transaction.TranactionType.Invoice
                });

                transactions[customerId].InvoiceID = DataAccess.instance.ProcessTransaction(transactions[customerId]);
            }

            return transactions[customerId].InvoiceID;
        }


        /// <summary>
        /// Deliver the selected items.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_deliver_selected_Click(object sender, EventArgs e) {
            if (frmManagerOverride.DidOverride("Deliver Selected")) {
                CustomerOrder custorder = DataAccess.instance.GetCustomerOrderforCustomer(((CustomerOrder)cbx_fullfill_cust.SelectedItem).CustomerID, false);

                List<CustomerOrderItem> items = new List<CustomerOrderItem>();

                foreach (DataGridViewRow row in fullfill_datagrid.SelectedRows) {
                    Inventory i = inventory.First(x => x.Id == uint.Parse(row.Cells["id"].Value.ToString()));
                    CustomerOrderItem coid = custorder.Items.FirstOrDefault(x => x.Id == i.Id);

                    uint requestQty = uint.Parse(row.Cells["requestqty"].Value.ToString());

                    if (i.AllQty.Count() == 0 || uint.Parse(row.Cells["requestqty"].Value.ToString()) > i.AllQty[0].Qty) {
                        uint onhand = i.AllQty.Count() == 0 ? 0 : i.AllQty[0].Qty;
                        switch (MessageBox.Show(this, $"Insufficient quantity to fullfil the order\n"
                                                    + $"Inventory: {onhand}\n"
                                                    + $"Request Qty: {requestQty}\n\n"
                                                    + $"Yes : Fulfill the full amount ({requestQty}) \n"
                                                    + $"No  : Fulfill inventory amount ({onhand}) \n"
                                                    + $"Cancel : Cancel Fulfillment",
                                                       "Insufficient quantity",
                                                    MessageBoxButtons.YesNoCancel)) {
                            case DialogResult.No:
                                requestQty = onhand;
                                break;
                            case DialogResult.Cancel:
                                return;
                        }
                    }

                    coid.DeliverQty = requestQty;
                    items.Add(coid);
                }

                uint tId = GetInvoiceID(custorder.CustomerID);

                foreach (CustomerOrderItem coi in items)
                    DataAccess.instance.UpdateCustomerOrderItem(custorder.CustomerID, tId, coi);

                txt_deliverqty.Text = "";
                RefreshFillment(custorder.CustomerID);
                //refreshcust();
            }
        }


        /// <summary>
        /// Refresh the datagrid by calling the RefreshFillment method that takes a customer id as a parameter.
        /// </summary>
        public void RefreshFillment() {
            inventory = DataAccess.instance.GetInventory();
            RefreshFillment(((CustomerOrder)cbx_fullfill_cust.SelectedItem).CustomerID);
        }


        /// <summary>
        /// Refresh the datagrid.
        /// </summary>
        /// <param name="customerId"></param>
        private void RefreshFillment(uint customerId) {

            uint custid = ((CustomerOrder)cbx_fullfill_cust.SelectedItem).CustomerID;
            List<CustomerOrder> items = DataAccess.instance?.GetCustomerOrder();  
            cbx_fullfill_cust.DataSource = items;
            cbx_fullfill_cust.SelectedItem = items.FirstOrDefault(x=>x.CustomerID == custid);
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
            if(cbx_fullfill_cust.Items.Count > 0)
            {
                uint cid = ((CustomerOrder)cbx_fullfill_cust.SelectedItem).CustomerID;
                RefreshFillment(cid);

            }
        }

        private void fullfill_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
