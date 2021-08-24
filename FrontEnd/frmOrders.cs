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
using NCR_Printer;
using System.Drawing.Printing;
using System.IO;

namespace SecretCellar
{
    public partial class frmOrders : Form
    {

        private DataAccess dataAccess = new DataAccess(Properties.Settings.Default.URL);
        private List<Supplier> suppliers = null;
        private List<Inventory> inventory = null;
        private List<Transaction> transaction_history = null;
        List<Inventory> withQty = null;
        public string printTotal;
        //private List<Customer> customers = DataAccess.instance.GetCustomer();
        Transaction SelectTransaction = null;
        private List<Customer> cust = null;
        private List<Customer> wholeCust = null;
        Transaction items = new Transaction();
        private PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
        private PrintDocument printDocument1 = new PrintDocument();
        Margins margins = new Margins(100, 100, 100, 100);
        private string searchForCustomerText = "Search for customer";



        public frmOrders(Transaction transaction)
        {
            InitializeComponent();
            inventory = dataAccess.GetInventory();
            suppliers = dataAccess.GetSuppliers();
            suppliers.Insert(0, new Supplier()
            {
                Name = "All",
                SupplierID = 0
            });
            transaction_history = dataAccess.GetTransactions();

            //get wholesale customer list
            cust = dataAccess.GetCustomer();
            wholeCust = cust.Where(x => x.IsWholesale == true).
                OrderBy(x => x.LastName).
                ToList();
            // wholesale customer list end

            txt_update_qty.Focus();
            cbx_supplier.DataSource = suppliers;
            cbx_supplier.DisplayMember = "Name";
            lst_customer.DataSource = DataAccess.instance?.GetCustomer();
            lst_customer.DisplayMember = "FullName";
            //cbx_fullfill_supp.DataSource = suppliers;
            //cbx_fullfill_supp.DisplayMember = "Name";
            cbx_fullfill_cust.DataSource = cust;
            cbx_fullfill_cust.DisplayMember = "FullName";
            cbx_cust_custorder.DataSource = cust;
            cbx_supp_custorder.DataSource = suppliers;

            cbx_fullfill_cust.DataSource = DataAccess.instance.GetCustomerOrder();
            cbx_fullfill_cust.DisplayMember = "FullName";

            lstbox_customer.DataSource = DataAccess.instance?.GetCustomer();
            lstbox_customer.DisplayMember = "FullName";
            supp_dataGrid.Columns[5].DefaultCellStyle.Format = "C";
            fullfill_datagrid.Columns[5].DefaultCellStyle.Format = "C";
            orderTotal();

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
            if (cbx_fullfill_cust.SelectedItem != null)
            {
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
            }
            



            transaction_dataGrid.DataSource = transaction_history.
               Select(x => new
               {
                   trans_id = x.InvoiceID,
                   trans_date = x.TransactionDateTime.ToString("MM/dd/yyyy"),
                   trans_total = x.Total.ToString("C"),
               }).
               OrderBy(x => x.trans_id).
               ToList();

            cust_notes_refresh();

            //customer order tab
           /*
            custOrder_datagrid.DataSource = inventory.
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
           */
        }

        private void cust_notes_refresh()
        {
            //request_dataGrid.Rows.Clear();
            List<Customer> customers = DataAccess.instance.GetCustomer();

            List<CustomerNote> customerNotes = DataAccess.instance.GetCustomerNotes(2);

            if (customers != null && customerNotes != null)
            {
                // Old Linq way
                //request_dataGrid.DataSource = from c in customers
                //             join n in customerNotes
                //             on c.CustomerID equals n.IdCustomer
                //             orderby c.FullName
                //             select new
                //              {
                //                customer_id = c.CustomerID,
                //                customer_names = c.FullName ,
                //                prod_name = n.Note
                //              };

                // Cool Kid way
                request_dataGrid.DataSource = customers.
                Join(customerNotes,
                     c => c.CustomerID,
                     n => n.IdCustomer,
                     (c, n) => new { customer_id = c.CustomerID, note_id = n.IdNote, note_date = n.NoteDate, customer_names = c.FullName, prod_name = n.Note }).
                OrderBy(x => x.customer_names).
                ToList();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_prod_add_Click(object sender, EventArgs e)
        {

            CustomerNote note = new CustomerNote
            {
                IdCustomer = ((Customer)lst_customer.SelectedItem)?.CustomerID ?? 0,
                Note = txt_prod_name.Text,
                IdNoteType = 2
            };
            dataAccess.NewCustomerNote(note);

            cust_notes_refresh();
            txt_prod_name.Text = "";
        }

        private void refresh()
        {
            inventory = dataAccess.GetInventory();
            uint id = ((Supplier)cbx_supplier.SelectedItem).SupplierID;
            supp_dataGrid.DataSource = inventory.Where(x => id == x.SupplierID || id == 0).
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
            orderTotal();
            
        }

        private void frefresh()
        {
            inventory = dataAccess.GetInventory();
            uint id = ((Supplier)cbx_fullfill_cust.SelectedItem).SupplierID;
            fullfill_datagrid.DataSource = inventory.Where(x => id == x.SupplierID || id == 0).
            Select(x => new
            {
                fname = x.Name,
                fid = x.Id,
                ftype = x.ItemType,
                fqty = x.Qty,
                fbarcode = x.Barcode,
                fprice = x.SupplierPrice,
                fmin = x.InvMin,
                fmax = x.InvMax,
                forderqty = x.OrderQty
            }).
              OrderBy(x => x.fname).
              ToList();
        }

        private void populate()
        {
            transaction_dataGrid.DataSource = transaction_history.
              Select(x => new
              {
                  trans_id = x.InvoiceID,
                  trans_date = x.TransactionDateTime.ToString("MM/dd/yyyy"),
                  trans_total = x.Total.ToString("C"),
              }).
              OrderBy(x => x.trans_id).
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
            txt_update_qty.Text = "";
            refresh();
            //orderTotal();
        }

        private void supp_dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (supp_dataGrid.SelectedRows.Count > 0)
            {
                Inventory i = inventory.First(x => x.Id == uint.Parse(supp_dataGrid.SelectedRows[0].Cells["id"].Value.ToString()));
                txt_update_qty.Text = i.OrderQty.ToString();
            }
        }

        private void tranaction_dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (transaction_dataGrid.SelectedRows.Count > 0)
            {
                Transaction t = transaction_history.First(x => x.InvoiceID == uint.Parse(transaction_dataGrid.SelectedRows[0].Cells["trans_id"].Value.ToString()));
                SelectTransaction = t;
            }
        }
        private void btn_print_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog pripredlg = new PrintPreviewDialog();
            Receipt.DefaultLayout.Logo = DataAccess.instance.ImportLogo();
            Receipt rct = new Receipt(SelectTransaction);
            //rct.PrintImage(DataAccess.instance.ImportLogo());
            pripredlg.Document = rct.GetPrintPreviewDocument();
            pripredlg.ShowDialog();

            /*Receipt.DefaultLayout.Logo = DataAccess.instance.ImportLogo();
            new Receipt(SelectTransaction).Print();*/

        }

        private void btn_setCust_Click(object sender, EventArgs e)
        {
            transaction_dataGrid.DataSource = transaction_history.Where(x => ((Customer)lstbox_customer.SelectedItem).CustomerID == x.CustomerID).
              Select(x => new
              {
                  trans_id = x.InvoiceID,
                  trans_date = x.TransactionDateTime.ToString("MM/dd/yyyy"),
                  trans_total = x.Total.ToString("C"),

              }).
              OrderBy(x => x.trans_id).
              ToList();
        }

        private void btn_setDate_Click(object sender, EventArgs e)
        {
            transaction_dataGrid.DataSource = transaction_history.Where(x => x.TransactionDateTime > start_dateTime.Value && x.TransactionDateTime < end_dateTime.Value).
             Select(x => new
             {
                 trans_id = x.InvoiceID,
                 trans_date = x.TransactionDateTime.ToString("MM/dd/yyyy"),
                 trans_total = x.Total.ToString("C"),

             }).
             OrderBy(x => x.trans_id).
             ToList();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void btn_prod_delete_Click(object sender, EventArgs e)
        {
            if (request_dataGrid.SelectedRows.Count > 0)
            {


                CustomerNote currentNote = new CustomerNote();
                currentNote.IdCustomer = uint.Parse(request_dataGrid.SelectedRows[0].Cells["customer_id"].Value.ToString());
                currentNote.IdNote = uint.Parse(request_dataGrid.SelectedRows[0].Cells["note_id"].Value.ToString());
                currentNote.IdNoteType = 2;
                currentNote.Note_Type = "Request";
                currentNote.NoteDate = DateTime.Parse(request_dataGrid.SelectedRows[0].Cells["note_date"].Value.ToString());
                currentNote.Note = request_dataGrid.SelectedRows[0].Cells["prod_name"].Value.ToString();
                /*List<CustomerNote> currentNotes = DataAccess.instance.GetCustomerNotes(selectedCustomer.CustomerID,2);

                foreach (CustomerNote note in currentNotes)
                {
                    if (note.IdNote == (uint.Parse(request_dataGrid.SelectedRows[0].Cells["note_id"].Value.ToString())))
                    {
                        currentNote = note;
                    }
                }
                */

                DataAccess.instance.DeleteCustomerNote(currentNote);
                cust_notes_refresh();
            }
        }

        public void orderTotal()
        {
            {
                double total = 0;
                // All items with price * qty

                foreach (DataGridViewRow row in supp_dataGrid.Rows)
                {
                    if (row.Cells["orderqty"].Value.ToString() != null || uint.Parse(row.Cells["orderqty"].Value.ToString()) > 0)
                    {
                        total = total + Convert.ToDouble((uint.Parse(row.Cells["orderqty"].Value.ToString()) * (Convert.ToDouble(row.Cells["Price"].Value.ToString()))));
                    }
                }
                txt_supp_total.Text = total.ToString("C");
                txt_update_qty.Focus();
            }
        }

        private void btn_recived_Click(object sender, EventArgs e)
        {
            frmReceivedOrders receivedOrders = new frmReceivedOrders();

            receivedOrders.ShowDialog();

            refresh();
            txt_update_qty.Focus();

        }

        public List<Inventory> listItems(Supplier orderSupplier)
        {
            
            inventory = dataAccess.GetInventory();
            withQty = inventory.Where(x => (orderSupplier.SupplierID == x.SupplierID || orderSupplier.SupplierID == 0) && x.OrderQty > 0).
             OrderBy(x => x.Name)
             .ToList();
            

            return withQty;
        }

        private void btn_print_supp_Click(object sender, EventArgs e)
        {
            Supplier orderSupplier = (Supplier)cbx_supplier.SelectedItem;
            withQty = listItems(orderSupplier);
            new PurchaseOrder(orderSupplier,withQty).Print();

        }

		private void textBox_CustomerName_TextChanged(object sender, EventArgs e) {
            lst_customer.DataSource = DataAccess.instance.GetCustomer(textBox_CustomerName.Text, true);
            /*Select(x => new {
                customerID = x.CustomerID,
                cust_name = $"{x.LastName}, {x.FirstName}"
            }).
              ToList();*/
        }


        //REMOVE THE PLACEHOLDER TEXT WHEN CLICKING INTO THE TEXT BOX
		private void textBox_CustomerName_Enter(object sender, EventArgs e) {
            if (textBox_CustomerName.Text == searchForCustomerText) {
                textBox_CustomerName.Text = "";
            }
		}
        
        
        //RESET THE PLACEHOLDER TEXT IF THE TEXT BOX IS EMPTY
		private void textBox_CustomerName_Leave(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(textBox_CustomerName.Text)) {
                textBox_CustomerName.Text = searchForCustomerText;

                lst_customer.DataSource = DataAccess.instance.GetCustomer(true);
            }
		}


		private void textBox_CustomerName_History_TextChanged(object sender, EventArgs e) {
            lstbox_customer.DataSource = DataAccess.instance.GetCustomer(textBox_CustomerName_History.Text, true);
            /*Select(x => new {
                customerID = x.CustomerID,
                cust_name = $"{x.LastName}, {x.FirstName}"
            }).
              ToList();*/
        }

        //cust order tab
        #region Customer Order Tab

        private void cbx_cust_custorder_SelectedIndexChanged(object sender, EventArgs e)
        {
            uint cid = ((Customer)cbx_cust_custorder.SelectedItem).CustomerID;
            RefreshFavorite(cid);
        }

        #endregion

        private void btnFavoritesAdd_Click(object sender, EventArgs e)
        {
            uint cid = ((Customer)cbx_cust_custorder.SelectedItem).CustomerID;
            Transaction t = new Transaction();
            frmLookup fl = new frmLookup(t);
            fl.ShowDialog();

            foreach (Item i in t.Items)
                DataAccess.instance.AddCustomerFavorite(cid, i.Id);

            RefreshFavorite(cid);
        }

       private void  RefreshFavorite(uint customerId)
        {
            List<CustomerFavorite> custFav = DataAccess.instance.GetCustomerFavorite(customerId).Favorites;
            List<CustomerOrderItem> custItems = (DataAccess.instance.GetCustomerOrderforCustomer(customerId)?.Items ?? new List<CustomerOrderItem>()).Where(x => x.DeliverQty < x.RequestQty).ToList();

            custOrder_datagrid.DataSource = inventory
                .GroupJoin(custFav, i => i.Id, f => f.InventoryID, (i, f) => new
                {
                    Inv = i,
                    Fav = f.SingleOrDefault()
                })
                // .Where(x => x.Fav.InventoryID != 0 && !x.Inv.Hidden  ) //&& x.Fav.InventoryID == x.Inv.Id 
                .GroupJoin(custItems, i => i.Inv.Id, o => o.Id, (i, o) => new
                {
                    i.Inv,
                    i.Fav,
                    Ord = o.SingleOrDefault()
                }) 
                .Where(x => (x.Fav != null && !x.Inv.Hidden || x.Ord != null) )
                .Select(x => new
                {
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
    /*
      //REMOVE THE PLACEHOLDER TEXT WHEN CLICKING INTO THE TEXT BOX
        private void textBox_CustomerName_History_Enter(object sender, EventArgs e) {
            if (textBox_CustomerName_History.Text == searchForCustomerText) {
                textBox_CustomerName_History.Text = "";
            }
        }


        //RESET THE PLACEHOLDER TEXT IF THE TEXT BOX IS EMPTY
        private void textBox_CustomerName_History_Leave(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(textBox_CustomerName_History.Text)) {
                textBox_CustomerName_History.Text = searchForCustomerText;

                lstbox_customer.DataSource = DataAccess.instance.GetCustomer(true);
            }
        }
	}
    */
        private void btnFavoritesRemove_Click(object sender, EventArgs e)
        {
            uint cid = ((Customer)cbx_cust_custorder.SelectedItem).CustomerID;
            uint iid = inventory.FirstOrDefault(x => x.Name == custOrder_datagrid.SelectedRows[0].Cells["CustOrdName"].Value.ToString()).Id;
            
            DataAccess.instance.DeleteCustomerFavorite(cid, iid);

            RefreshFavorite(cid);
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            Transaction t = new Transaction
            {
                CustomerID = ((Customer)cbx_cust_custorder.SelectedItem).CustomerID
            };

            frmLookup fl = new frmLookup(t);
            fl.ShowDialog();

            if (t.Items.Count > 0)
            {
                CustomerOrder co = DataAccess.instance.GetCustomerOrderforCustomer(t.CustomerID) ?? new CustomerOrder() 
                { CustomerID = t.CustomerID
                };
                foreach (Item i in t.Items)
                {
                    CustomerOrderItem coi = co.Items.FirstOrDefault(x => x.Id == i.Id);

                    if (coi == null)
                        dataAccess.NewCustomerOrderItem(co.CustomerID, new CustomerOrderItem { Id = i.Id, RequestQty = 1 });
                    else
                    {
                        coi.RequestQty++;
                        dataAccess.UpdateCustomerOrderItem(coi);
                    }
                }

                //DataAccess.instance.UpdateCustomerOrderforCustomer(co);
            }

            RefreshFavorite(t.CustomerID);
        }

        private void custOrder_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (custOrder_datagrid.SelectedRows.Count > 0)
            //    txt_orderqty_custorder.Text = request_dataGrid.SelectedRows[0].Cells["Requsted"].Value.ToString();
        }

        private void custOrder_datagrid_SelectionChanged(object sender, EventArgs e)
        {
            if (custOrder_datagrid.SelectedRows.Count > 0)
                txt_orderqty_custorder.Text = (custOrder_datagrid.SelectedRows[0].Cells["Requsted"].Value ?? 0).ToString();
        }

        private void btn_update_custorder_Click(object sender, EventArgs e)
        {
            if (custOrder_datagrid.SelectedRows.Count > 0)
            {
                uint cid = ((Customer)cbx_cust_custorder.SelectedItem).CustomerID;
                if(cid > 0)
                { 
                    uint iid = Convert.ToUInt32( custOrder_datagrid.SelectedRows[0].Cells["CustOrd_id"].Value?.ToString());

                    CustomerOrder co = DataAccess.instance.GetCustomerOrderforCustomer(cid) ?? new CustomerOrder();
                    CustomerOrderItem coi = co.Items.FirstOrDefault(x => x.Id == iid) ?? new CustomerOrderItem
                    {
                        Id = iid
                    };

                    if (coi == null || coi.CustomerOrderItemID == 0)
                        dataAccess.NewCustomerOrderItem(cid, new CustomerOrderItem
                        {
                            Id = iid,
                            RequestQty = Convert.ToUInt32(txt_orderqty_custorder.Text)
                        });
                    else
                    {
                        coi.RequestQty = Convert.ToUInt32(txt_orderqty_custorder.Text);
                        DataAccess.instance.UpdateCustomerOrderItem(coi);
                    }
                    
                    //DataAccess.instance.UpdateCustomerOrder(co);
                    RefreshFavorite(cid);
                }
            }
        }

        private void txt_orderqty_custorder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        //fullfillment tab

        private void btn_delivered_update_Click(object sender, EventArgs e)
        {
            CustomerOrder custorder = DataAccess.instance.GetCustomerOrderforCustomer(((Customer)cbx_cust_custorder.SelectedItem).CustomerID, false);

            Inventory i = inventory.First(x => x.Id == uint.Parse(fullfill_datagrid.SelectedRows[0].Cells["id"].Value.ToString()));
            CustomerOrderItem coid = custorder.Items.FirstOrDefault(x => x.Id == i.Id);


            if (fullfill_datagrid.SelectedRows.Count > 0)
            {
                

                //i.AllQty.Add(new InventoryQty { Qty = custorder.qty });
               // i.OrderQty.Add(new CustomerOrder {RequestQty = coid.RequestQty, DeliveredDate = DateTime.Now, SupplierPrice = 0 });
                if (uint.TryParse(txt_deliverqty.Text.Trim(), out uint dqty)) 
                {
                    coid.DeliverQty = dqty;
                    dataAccess.UpdateCustomerOrderItem(coid);
                }
                else
                {
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

        private void refreshcust()
        {
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
        }

        private void btn_deliver_all_Click(object sender, EventArgs e)
        {

            CustomerOrder custorder = DataAccess.instance.GetCustomerOrderforCustomer(((Customer)cbx_cust_custorder.SelectedItem).CustomerID, false);

            
            foreach (DataGridViewRow row in fullfill_datagrid.Rows)
            {
                Inventory i = inventory.First(x => x.Id == uint.Parse(row.Cells["id"].Value.ToString()));
                CustomerOrderItem coid = custorder.Items.FirstOrDefault(x => x.Id == i.Id);
                coid.DeliverQty = uint.Parse(row.Cells["RequstQty"].Value.ToString());
                dataAccess.UpdateCustomerOrderItem(coid);

            }

            txt_deliverqty.Text = "";
            refreshcust();


        }

        private void btn_deliver_selected_Click(object sender, EventArgs e)
        {
            CustomerOrder custorder = DataAccess.instance.GetCustomerOrderforCustomer(((Customer)cbx_cust_custorder.SelectedItem).CustomerID, false);


            foreach (DataGridViewRow row in fullfill_datagrid.SelectedRows)
            {
                Inventory i = inventory.First(x => x.Id == uint.Parse(row.Cells["id"].Value.ToString()));
                CustomerOrderItem coid = custorder.Items.FirstOrDefault(x => x.Id == i.Id);
                coid.DeliverQty = uint.Parse(row.Cells["RequstQty"].Value.ToString());
                dataAccess.UpdateCustomerOrderItem(coid);

            }

            txt_deliverqty.Text = "";
            refreshcust();
        }
    }
    
}