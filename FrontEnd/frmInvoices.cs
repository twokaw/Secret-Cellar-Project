using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Shared;




namespace SecretCellar {
	public partial class frmInvoices : Form {
		private readonly string _defaultFilterString = "Filter...";
		private List<Transaction> _invoices = new List<Transaction>();



		public frmInvoices() {
			InitializeComponent();

			List<Transaction> transactions = DataAccess.instance.GetTransactions();
			_invoices = transactions.FindAll((transaction) => { return transaction.TranType == Transaction.TranactionType.Invoice; });

			PopulateListOfInvoices();
		}


		private void textBox_Filter_Enter(object sender, EventArgs e) {
			if (textBox_Filter.Text != _defaultFilterString) { return; }

			textBox_Filter.Text = "";
		}
		private void textBox_Filter_Leave(object sender, EventArgs e) {
			if (textBox_Filter.Text.Replace(" ", "") != "") { return; }

			textBox_Filter.Text = _defaultFilterString;
		}
		private void btn_CloseWindow_Click(object sender, EventArgs e) { this.Close(); }


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
			foreach (Transaction invoice in _invoices) {
				selectionList_Invoices.Items.Add($"{invoice.InvoiceID} | {invoice.CustomerName}");
			}
		}


		private void button_Finalize_Click(object sender, EventArgs e) {

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
