using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Shared;




namespace SecretCellar {
	public partial class frmInvoices : Form {
		private readonly string _defaultFilterString = "Filter...";
		private List<Transaction> _invoices = new List<Transaction>();
		private readonly frmTransaction _frmTransaction;


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
			if (selectionList_Invoices.SelectedItems.Count == 0) { return; }

			uint invoiceId = uint.Parse(selectionList_Invoices.SelectedItem.ToString().Split(new string[] { " | " }, StringSplitOptions.None)[0]);
			Transaction currentInvoice = _invoices.Find((invoice) => { return invoice.InvoiceID == invoiceId; });

			if (currentInvoice == null) return;

			dataGridView_InvoiceData.DataSource = currentInvoice.Items.Select(x => new {
				ItemName = x.Name,
				Price = x.Price,
				Quantity = x.Qty
			}).ToList();

			//ADD PAYMENTS
			double payments = 0;

			currentInvoice.Payments.ForEach(payment => {
				payments += payment.Amount;
			});

			currencyBox_MoneyDown.Text = payments.ToString();

			//ADD TOTAL
			double total = 0;

			currentInvoice.Items.ForEach(item => {
				total += item.Price * item.Qty;
			});

			currencyBox_Total.Text = total.ToString();
		}


		/// <summary>
		/// Populates the list invoices.
		/// </summary>
		private void PopulateListOfInvoices() {
			List<Transaction> transactions = DataAccess.instance.GetTransactions();
			_invoices = transactions.FindAll((transaction) => { return transaction.TranType == Transaction.TranactionType.Invoice; });

			selectionList_Invoices.Items.Clear();

			foreach (Transaction invoice in _invoices) {
				string invoiceTitle = $"{invoice.InvoiceID} | {(!string.IsNullOrWhiteSpace(invoice.CustomerName) ? invoice.CustomerName : "No Name")}";

				if (textBox_Filter.Text == "" || textBox_Filter.Text == _defaultFilterString || invoiceTitle.ToLower().Contains(textBox_Filter.Text.ToLower())) {
					selectionList_Invoices.Items.Add(invoiceTitle);
				}
			}

			if (selectionList_Invoices.Items.Count > 0) selectionList_Invoices.SelectedIndex = 0;
		}


		/// <summary>
		/// Finalizes the invoice.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button_Finalize_Click(object sender, EventArgs e) {
			if (selectionList_Invoices.SelectedItem == null) return;

			string selectedTransactionIdString = selectionList_Invoices.SelectedItem.ToString().Split(new string[] { " | " }, StringSplitOptions.None)[0];
			
			if (uint.TryParse(selectedTransactionIdString, out uint transactionId)) {
				Transaction selectedTransaction = DataAccess.instance.GetTransactions(transactionId);

				if (selectedTransaction != null) {
					frmPayment frmPayment = new frmPayment(selectedTransaction);

					frmPayment.FormClosed += (objectSender, eventArgs) => { DataAccess.instance.ProcessTransaction(selectedTransaction); };	//This probably needs to be removed from the formClosed delegate.

					frmPayment.ShowDialog();

				}
			}

			PopulateListOfInvoices();
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

			Item item = new Item(inv.Name, inv.Id, inv.Barcode, inv.Qty, 0, inv.Price, false, inv.ItemType, inv.Bottles, 0, 0);
			Item item2 = new Item(inv2.Name, inv2.Id, inv2.Barcode, inv2.Qty, 0, inv2.Price, false, inv2.ItemType, inv2.Bottles, 0, 0);
			Item item3 = new Item(inv3.Name, inv3.Id, inv3.Barcode, inv3.Qty, 0, inv3.Price, false, inv3.ItemType, inv3.Bottles, 0, 0);

			transaction.Items.Add(item);
			transaction.Items.Add(item2);
			transaction.Items.Add(item3);

			DataAccess.instance.ProcessTransaction(transaction);
		}
    }
}
