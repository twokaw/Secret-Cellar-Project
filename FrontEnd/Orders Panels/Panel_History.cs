using NCR_Printer;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;




namespace SecretCellar.Orders_Panels {
	public partial class Panel_History : UserControl {
        private string searchForCustomerText = "Search for customer";
        private List<Transaction> transaction_history = null;
        Transaction SelectTransaction = null;



        public Panel_History() {
			InitializeComponent();

            transaction_history = DataAccess.instance?.GetTransactions();
            lstbox_customer.DataSource = DataAccess.instance?.GetCustomer();
            lstbox_customer.DisplayMember = "FullName";

            //POPULATE THE DATA GRID
            if (DataAccess.instance != null) { populate(); }
        }


        /////////////////////////////////////////////////////////////
        //REMOVE THE PLACEHOLDER TEXT WHEN CLICKING INTO THE TEXT BOX
        /////////////////////////////////////////////////////////////
        private void textBox_CustomerName_Enter(object sender, EventArgs e) {
            if (textBox_CustomerName.Text == searchForCustomerText) {
                textBox_CustomerName.Text = "";
            }
        }


        /////////////////////////////////////////////////////
        //RESET THE PLACEHOLDER TEXT IF THE TEXT BOX IS EMPTY
        /////////////////////////////////////////////////////
        private void textBox_CustomerName_Leave(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(textBox_CustomerName.Text)) {
                textBox_CustomerName.Text = searchForCustomerText;

                lstbox_customer.DataSource = DataAccess.instance.GetCustomer(true);
            }
        }


		////////////////
		//ON TEXT CHANGE
		////////////////
		private void textBox_CustomerName_TextChanged(object sender, EventArgs e) {
			lstbox_customer.DataSource = DataAccess.instance.GetCustomer(textBox_CustomerName.Text, true);
			/*Select(x => new {
                customerID = x.CustomerID,
                cust_name = $"{x.LastName}, {x.FirstName}"
            }).
              ToList();*/
		}


        ///////////////////////
        //REFRESH THE DATA GRID
        ///////////////////////
        private void btn_reset_Click(object sender, EventArgs e) {
            populate();
        }


        ///////////////////////
        //ON SET CUSTOMER CLICK
        ///////////////////////
        private void btn_setCust_Click(object sender, EventArgs e) {
            transaction_dataGrid.DataSource = transaction_history.Where(x => ((Customer)lstbox_customer.SelectedItem).CustomerID == x.CustomerID).
              Select(x => new {
                  trans_id = x.InvoiceID,
                  trans_date = x.TransactionDateTime.ToString("MM/dd/yyyy"),
                  trans_total = x.Total.ToString("C"),

              }).
              OrderBy(x => x.trans_id).
              ToList();
        }


        ////////////////
        //ON PRINT CLICK
        ////////////////
        private void btn_print_Click(object sender, EventArgs e) {
            PrintPreviewDialog pripredlg = new PrintPreviewDialog();
            Receipt.DefaultLayout.Logo = DataAccess.instance.ImportLogo();
            Receipt rct = new Receipt(SelectTransaction);
            //rct.PrintImage(DataAccess.instance.ImportLogo());
            pripredlg.Document = rct.GetPrintPreviewDocument();
            pripredlg.ShowDialog();

            /*Receipt.DefaultLayout.Logo = DataAccess.instance.ImportLogo();
            new Receipt(SelectTransaction).Print();*/

        }


        ///////////////////
        //ON SET DATE CLICK
        ///////////////////
        private void btn_setDate_Click(object sender, EventArgs e) {
            transaction_dataGrid.DataSource = transaction_history.Where(x => x.TransactionDateTime > start_dateTime.Value && x.TransactionDateTime < end_dateTime.Value).
             Select(x => new {
                 trans_id = x.InvoiceID,
                 trans_date = x.TransactionDateTime.ToString("MM/dd/yyyy"),
                 trans_total = x.Total.ToString("C"),

             }).
             OrderBy(x => x.trans_id).
             ToList();
        }


        ///////////////////////////////
        //ON DATA GRID SELECTION CHANGE
        ///////////////////////////////
        private void transaction_dataGrid_SelectionChanged(object sender, EventArgs e) {
            if (transaction_dataGrid.SelectedRows.Count > 0) {
                Transaction t = transaction_history.First(x => x.InvoiceID == uint.Parse(transaction_dataGrid.SelectedRows[0].Cells["trans_id"].Value.ToString()));
                SelectTransaction = t;
            }
        }


        ///////////////////////
        //REFRESH THE DATA GRID
        ///////////////////////
        private void populate() {
            transaction_dataGrid.DataSource = transaction_history.
              Select(x => new {
                  trans_id = x.InvoiceID,
                  trans_date = x.TransactionDateTime.ToString("MM/dd/yyyy"),
                  trans_total = x.Total.ToString("C"),
              }).
              OrderBy(x => x.trans_id).
              ToList();
        }
	}
}
