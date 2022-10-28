using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NCR_Printer;
using Shared;




namespace SecretCellar {
	public partial class frmInvoices : Form {
		private readonly string _defaultFilterString = "Filter...";
		private readonly frmTransaction _frmTransaction;

		private List<Transaction> _invoices = new List<Transaction>();
		private Transaction _selectedTransaction = null;

		public frmInvoices(frmTransaction frmTransaction) {
			InitializeComponent();

			_frmTransaction = frmTransaction;
			PopulateListOfInvoices();
		}


		private void btn_CloseWindow_Click(object sender, EventArgs e) { this.Close(); }
		private void textBox_Filter_Enter(object sender, EventArgs e) {
			if (textBox_Filter.Text != _defaultFilterString) { return; }

			textBox_Filter.Text = "";
		}
		private void textBox_Filter_Leave(object sender, EventArgs e) {
			if (textBox_Filter.Text.Replace(" ", "") != "") { return; }

			textBox_Filter.Text = _defaultFilterString;
		}
		private void textBox_Filter_TextChanged(object sender, EventArgs e) { PopulateListOfInvoices(); }


		/// <summary>
		/// Update the data grid based on the selected invoice.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void selectionList_Invoices_SelectedIndexChanged(object sender, EventArgs e) {
			if (selectionList_Invoices.SelectedItem == null) { return; }

			uint invoiceId = uint.Parse(selectionList_Invoices.SelectedItem.ToString().Split(new string[] { " | " }, StringSplitOptions.None)[0]);
			_selectedTransaction = _invoices.Find((invoice) => { return invoice.InvoiceID == invoiceId; });

			if (_selectedTransaction == null) { return; }

			dataGridView_InvoiceData.DataSource = _selectedTransaction.Items.Select(x => new {
				ItemName = x.Name,
				Price = x.Price,
				Quantity = x.Qty
			}).ToList();

			//ADD PAYMENTS
			double payments = 0;

			_selectedTransaction.Payments.ForEach(payment => {
				payments += payment.Amount;
			});

			currencyBox_MoneyDown.Text = payments.ToString();
			currencyBox_Total.Text = _selectedTransaction.Total.ToString();
		}


		/// <summary>
		/// Finalizes the invoice.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button_UpdatePayment_Click(object sender, EventArgs e) {
			if (_selectedTransaction == null) return;

			frmPayment frmPayment = new frmPayment(_selectedTransaction);
			frmPayment.ShowDialog();

            DataAccess.instance.ProcessTransaction(_selectedTransaction);
			PopulateListOfInvoices();
		}


		/// <summary>
		/// Displays the print preview for the selected invoice.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button_Print_Click(object sender, EventArgs e) {
			PrintPreviewDialog printPreview = new PrintPreviewDialog();
			Invoice invoiceDocument = new Invoice(_selectedTransaction, PurchaseOrder.LetterLayout);
			printPreview.Document = invoiceDocument.GetPrintPreviewDocument();
			printPreview.ShowDialog();
		}


		/// <summary>
		/// Toggles between showing the active invoices and the completed invoices.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void checkBox_ClosedInvoices_CheckedChanged(object sender, EventArgs e) {
			PopulateListOfInvoices();
            button_UpdatePayment.Enabled = !checkBox_ClosedInvoices.Checked;
        }


        /// <summary>
		/// Gets the invoices from the database and then populates the list of invoices.
		/// </summary>
        private void PopulateListOfInvoices() {
            List<Customer> customerList = DataAccess.instance.GetCustomer();
            _invoices = DataAccess.instance.GetTransactions().FindAll((transaction) => { return transaction.TranType == Transaction.TranactionType.Invoice || transaction.TranType == Transaction.TranactionType.ClosedInvoice; });

            _invoices.ForEach(x => x.CustomerName = customerList.FirstOrDefault(y => y.CustomerID == x.CustomerID)?.FullName);

            bool isShowingClosedInvoices = checkBox_ClosedInvoices.Checked;
            selectionList_Invoices.Items.Clear();
			string invoiceTitle;

			foreach (Transaction invoice in _invoices) {
				if ((isShowingClosedInvoices && invoice.TranType == Transaction.TranactionType.ClosedInvoice)
				|| (!isShowingClosedInvoices && invoice.TranType == Transaction.TranactionType.Invoice)) {
                    invoiceTitle = $"{invoice.InvoiceID} | {(!string.IsNullOrWhiteSpace(invoice.CustomerName) ? invoice.CustomerName : "No Name")}";

                    if (textBox_Filter.Text == "" || textBox_Filter.Text == _defaultFilterString || invoiceTitle.ToLower().Contains(textBox_Filter.Text.ToLower())) {
                        selectionList_Invoices.Items.Add(invoiceTitle);
                    }
                }
			}

			if (selectionList_Invoices.Items.Count > 0) selectionList_Invoices.SelectedIndex = 0;
			else { _selectedTransaction = null; selectionList_Invoices.SelectedIndex = -1; }
		}


		//DEBUG METHODS
		private void MakePayment(uint id, double paymentAmount) {
			Transaction t = DataAccess.instance.GetTransactions(id);
			t.Payments.Add(new Payment { Method = "Cash", Amount = paymentAmount, Number = null });
			DataAccess.instance.ProcessTransaction(t);
		}


		private void CreateDummyTransaction() {
			Transaction transaction = new Transaction {
				TranType = Transaction.TranactionType.Invoice,
				CustomerID = DataAccess.instance.GetCustomer()[1].CustomerID
			};

			Inventory inv = DataAccess.instance.GetItem("4099100139907");
			Inventory inv2 = DataAccess.instance.GetItem("086785470801");
			Inventory inv3 = DataAccess.instance.GetItem("811538010115");

			//Item item = new Item(inv.Name, inv.Id, inv.Barcode, inv.Qty, 0, inv.Price, false, inv.ItemType, inv.Bottles, 0, 0);
			//Item item2 = new Item(inv2.Name, inv2.Id, inv2.Barcode, inv2.Qty, 0, inv2.Price, false, inv2.ItemType, inv2.Bottles, 0, 0);
			//Item item3 = new Item(inv3.Name, inv3.Id, inv3.Barcode, inv3.Qty, 0, inv3.Price, false, inv3.ItemType, inv3.Bottles, 0, 0);

			//transaction.Items.Add(item);
			//transaction.Items.Add(item2);
			//transaction.Items.Add(item3);

			DataAccess.instance.ProcessTransaction(transaction);
		}
	}
}
