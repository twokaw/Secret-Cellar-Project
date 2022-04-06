using NCR_Printer;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SecretCellar.Orders_Panels {
	public partial class Panel_History : UserControl {
        private readonly string searchForCustomerText = "Search for customer";
        private List<Transaction> transaction_history = null;
        Transaction SelectTransaction = null;

        public Panel_History() {
			InitializeComponent();

            transaction_history = DataAccess.instance?.GetTransactions();
            lstbox_customer.DataSource = DataAccess.instance?.GetCustomer();
            lstbox_customer.DisplayMember = "FullName";

            //POPULATE THE DATA GRID
            if (DataAccess.instance != null && transaction_history != null) { Populate(); }
        }

        /// <summary>
        /// REMOVE THE PLACEHOLDER TEXT WHEN CLICKING INTO THE TEXT BOX
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_CustomerName_Enter(object sender, EventArgs e) {
            if (textBox_CustomerName.Text == searchForCustomerText)
                textBox_CustomerName.Text = "";
        }

        /// <summary>
        /// RESET THE PLACEHOLDER TEXT IF THE TEXT BOX IS EMPTY
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_CustomerName_Leave(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(textBox_CustomerName.Text)) {
                textBox_CustomerName.Text = searchForCustomerText;

                lstbox_customer.DataSource = DataAccess.instance.GetCustomer();
            }
        }


        /// <summary>
        /// ON TEXT CHANGE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void textBox_CustomerName_TextChanged(object sender, EventArgs e) {

            if(int.TryParse(textBox_CustomerName.Text, out int receiptnumber))
                Populate();
            else
			    lstbox_customer.DataSource = DataAccess.instance.GetCustomer(textBox_CustomerName.Text);
            // if()
			/*Select(x => new {
                customerID = x.CustomerID,
                cust_name = $"{x.LastName}, {x.FirstName}"
            }).
              ToList();*/
		}

        /// <summary>
        /// ON SET CUSTOMER CLICK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_setCust_Click(object sender, EventArgs e) {
        }

        /// <summary>
        /// ON PRINT CLICK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// ON SET DATE CLICK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_setDate_Click(object sender, EventArgs e) {
            Populate();
        }

        /// <summary>
        /// ON DATA GRID SELECTION CHANGE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void transaction_dataGrid_SelectionChanged(object sender, EventArgs e) {
            if (transaction_dataGrid.SelectedRows.Count > 0) 
            {
                SelectTransaction = transaction_history.First(x => x.InvoiceID == uint.Parse(transaction_dataGrid.SelectedRows[0].Cells["trans_id"].Value.ToString()));

                var items = SelectTransaction.Items
                 .Select(x => new
                 {
                     part_Id = x.Id,
                     part_Name = x.Name,
                     part_Qty = x.NumSold,
                     part_price = x.Price
                 })
                   .ToList();

                dgv_Items.DataSource = items;
            }
        }

        private void lstbox_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Populate();
        }
                
        /// <summary>
        /// REFRESH THE DATA GRID
        /// </summary>
        private void Populate() {


            transaction_history = DataAccess.instance?.GetTransactions();

            if (transaction_history == null)
                transaction_dataGrid.Rows.Clear();
            else if(int.TryParse(textBox_CustomerName.Text, out int receiptnumber))
            {
                transaction_dataGrid.DataSource = transaction_history
                   .Where(x => x.InvoiceID == receiptnumber)
                   .Select(x => new
                   {
                       trans_id = x.InvoiceID,
                       trans_date = x.TransactionDateTime.ToString("MM/dd/yy"),
                       trans_total = x.Total.ToString("C")
                   })
                   .OrderBy(x => x.trans_id)
                   .ToList();
            }
            else
            {
                transaction_dataGrid.DataSource = transaction_history
                   .Where(x => (x.CustomerID == ((Customer)lstbox_customer.SelectedItem).CustomerID 
                            ||  ((Customer)lstbox_customer.SelectedItem).CustomerID == 0)
                            && x.TransactionDateTime > start_dateTime.Value 
                            && x.TransactionDateTime < end_dateTime.Value)
                   .Select(x => new
                    {
                      trans_id = x.InvoiceID,
                      trans_date = x.TransactionDateTime.ToString("MM/dd/yy"),
                      trans_total = x.Total.ToString("C")
                    })
                   .OrderBy(x => x.trans_id)
                   .ToList();
            }
        }

        private void end_dateTime_ValueChanged(object sender, EventArgs e)
        {
            Populate();
        }

        private void start_dateTime_ValueChanged(object sender, EventArgs e)
        {
            Populate();
        }

        private void btn_Returns_Click(object sender, EventArgs e)
        {
            uint id = uint.Parse(dgv_Items.SelectedRows[0].Cells[0].Value.ToString());
            Item i = SelectTransaction.Items.FirstOrDefault(x => x.Id == id);
            double item_total = SelectTransaction.ItemPriceTotal(i) / i.NumSold;
            frmReturnItem returnItem = new frmReturnItem(i, item_total);
            // MessageBox.Show($"Transaction: {id} \n Return {i.Name} \n Price: {i.Price} \n Refund Price: {SelectTransaction.ItemPriceTotal(i):C}");

            if(returnItem.ShowDialog() == DialogResult.OK  && returnItem.RefundQty > 0)
            {
                DataAccess.instance.ReturnItem(SelectTransaction.InvoiceID, id, returnItem.RefundQty,  returnItem.Restock);

                MessageBox.Show($"Refund for {returnItem.RefundQty} {i.Name } \n\nRefund amount: {returnItem.TotalRefundPrice:C}");
                LblLastRefund.Text = $"Refund amount: { returnItem.TotalRefundPrice:C}";
                DataAccess.instance.OpenCashDrawer();

                Populate();
            }
        }

        private void Panel_History_VisibleChanged(object sender, EventArgs e)
        {
            LblLastRefund.Text = "";
            Populate();
        }
    }
}
