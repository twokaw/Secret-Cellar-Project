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
        private List<Customer> customers = DataAccess.instance.GetCustomer();
        Transaction SelectTransaction = null;
        //private List<Customer> cust = null;
        
        private PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
        private PrintDocument printDocument1 = new PrintDocument();

        // Declare a string to hold the entire document contents.
        private string documentContents;

        // Declare a variable to hold the portion of the document that
        // is not printed.
        private string stringToPrint;
        public frmOrders(Transaction transaction)
        {
            InitializeComponent();
            inventory = dataAccess.GetInventory();
            suppliers = dataAccess.GetSuppliers();
            transaction_history = dataAccess.GetTransactions();
            //cust = dataAccess.GetCustomer();
            cbx_supplier.DataSource = suppliers;
            cbx_supplier.DisplayMember = "Name";
            lstbox_customer.DataSource = DataAccess.instance?.GetCustomer();
            lstbox_customer.DisplayMember = "FullName";
            printDocument1.PrintPage += new PrintPageEventHandler(btn_print_Click);

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

            transaction_dataGrid.DataSource = transaction_history.
               Select(x => new {
                  trans_id = x.InvoiceID,
                   trans_date = x.TransactionDateTime.ToString("MM/dd/yyyy"),
                   trans_total = x.Total.ToString("C"),
               }).
               OrderBy(x => x.trans_id).
               ToList();

            request_dataGrid.DataSource = customers.
                Select(x => new {
                    customerID = x.CustomerID,
                    cust_name = $"{x.LastName}, {x.FirstName}"
                }).
                OrderBy(x => x.cust_name).
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
           
           CustomerNote note = new CustomerNote();
            note.IdCustomer = uint.Parse(txt_cust_name.Text);
            note.Note = txt_prod_name.Text;
            dataAccess.NewCustomerNote(note);
        
        }

        private void cust_refresh()
        {
            request_dataGrid.DataSource = customers.Where(x => (x.LastName.IndexOf(txt_cust_name.Text, StringComparison.OrdinalIgnoreCase) >= 0) || x.FirstName.IndexOf(txt_cust_name.Text, StringComparison.OrdinalIgnoreCase) >= 0).

              Select(x => new {
                  customerID = x.CustomerID,
                  cust_name = $"{x.LastName}, {x.FirstName}"
              }).
                OrderBy(x => x.cust_name).
                ToList();
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

        private void populate()
        {
            transaction_dataGrid.DataSource = transaction_history.
              Select(x => new {
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
            refresh();
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
            pripredlg.Document = rct.GetPrintDocument();
            pripredlg.ShowDialog();

            /*Receipt.DefaultLayout.Logo = DataAccess.instance.ImportLogo();
            new Receipt(SelectTransaction).Print();*/

        }

        private void btn_set_cust_Click(object sender, EventArgs e)
        {
            transaction_dataGrid.DataSource = transaction_history.Where(x => ((Customer)lstbox_customer.SelectedItem).CustomerID == x.CustomerID).
              Select(x => new {
                  trans_id = x.InvoiceID,
                  trans_date = x.TransactionDateTime.ToString("MM/dd/yyyy"),
                  trans_total = x.Total.ToString("C"),
                  
              }).
              OrderBy(x => x.trans_id).
              ToList();
            
        }


    

        private void btn_setCust_Click(object sender, EventArgs e)
        {
            transaction_dataGrid.DataSource = transaction_history.Where(x => ((Customer)lstbox_customer.SelectedItem).CustomerID == x.CustomerID).
              Select(x => new {
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
             Select(x => new {
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

      
    }
}
