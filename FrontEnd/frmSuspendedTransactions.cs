using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Shared;



namespace SecretCellar
{
	public partial class frmSuspendedTransactions : ManagedForm {
		private readonly frmTransaction TRANSACTION_FORM;
		private readonly Transaction CURRENT_TRANSACTION;

		private List<Transaction> suspendedTransactionsList;
		private Transaction selectedSuspendedTransaction;
		
		

		public frmSuspendedTransactions(frmTransaction formTransaction, Transaction currentTransaction)
		{
			InitializeComponent();
			TRANSACTION_FORM = formTransaction;
			CURRENT_TRANSACTION = currentTransaction;
			suspendedTransactionsList = DataAccess.instance.GetSuspendedTransactions();

			PopulateListOfTransactions();
		}


		/// <summary>
		/// On selection change.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void selectionListSuspendedTransactions_SelectedIndexChanged(object sender, EventArgs e) {
			if (selectionListSuspendedTransactions.Items.Count == 0) { return; }

			uint transactionId = GetTransactionId(selectionListSuspendedTransactions.SelectedItem.ToString());
			if (transactionId == 0) { return; }

			selectedSuspendedTransaction = DataAccess.instance.GetTransactions(transactionId);
			PopulateGrid(selectedSuspendedTransaction.Items);
		}


		/// <summary>
		/// Delete the suspended transaction. If the transaction has a payment, a window will pop up to choose whether to push that payment to credit and open the cash drawer to pay out cash.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnDelete_Click(object sender, EventArgs e) {
			if (selectionListSuspendedTransactions.Items.Count == 0 || selectedSuspendedTransaction == null) { return; }
			
			//ENSURE THAT THE TRANSACTION DOESN'T HAVE PAYMENTS STILL
			if (selectedSuspendedTransaction.Payments.Count > 0) {
				DialogResult hasPaymentsMessageBox = MessageBox.Show("Cannot delete transaction. There are still outstanding payments. Would you like to remove the payments?", "Error", MessageBoxButtons.YesNo);

				if (hasPaymentsMessageBox != DialogResult.Yes) { return; }

				//SHOW THE FORM TO DISPLAY THE PAYMENTS AMOUNT AND SELECT THE PAYMENT RETURN METHOD
				frmSuspendedTransactionsSelectReturnPaymentMethod selectReturnPaymentMethod = new frmSuspendedTransactionsSelectReturnPaymentMethod(selectedSuspendedTransaction);
				selectReturnPaymentMethod.ShowDialog();

				if (selectReturnPaymentMethod.DidDeleteTransaction) {
					PopulateListOfTransactions();
                }
			}
			else {
				if (frmManagerOverride.DidOverride("Delete Transaction")) {
					//DELETE THE TRANSACTION FROM THE DATABASE
					DataAccess.instance.DeleteTransaction(selectedSuspendedTransaction.InvoiceID);

					PopulateListOfTransactions();
				}
			}
		}


		/// <summary>
		/// Add the suspended transaction to the current transaction.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnAdd_Click(object sender, EventArgs e) {
			if (selectedSuspendedTransaction == null || selectedSuspendedTransaction.Items.Count == 0) { return; }

			//CLOSE THE WINDOW AND CALL THE IMPORT FUNCTION
			this.Close();
			TRANSACTION_FORM.ImportTransaction(selectedSuspendedTransaction);
		}


		/// <summary>
		/// Close the form.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_CloseWindow_Click(object sender, EventArgs e) { this.Close(); }


		/// <summary>
		/// Gets the transaction id from the given string.
		/// </summary>
		/// <param name="transactionIdString"></param>
		/// <returns>The transaction id or null if it can't get the id from the string.</returns>
		private uint GetTransactionId(string transactionIdString) {
			transactionIdString = transactionIdString.Substring(0, transactionIdString.IndexOf(" | "));

			if (uint.TryParse(transactionIdString, out uint transactionId)) {
				return transactionId;
			}

			return 0;
		}


		/// <summary>
		/// Populates the list of transactions.
		/// </summary>
		private void PopulateListOfTransactions() {
			suspendedTransactionsList = DataAccess.instance.GetSuspendedTransactions();
			selectionListSuspendedTransactions.Items.Clear();

			foreach (Transaction t in suspendedTransactionsList) {
				if (t.InvoiceID == CURRENT_TRANSACTION.InvoiceID) { continue; }	//THIS CHECK IS SO THAT IT DOESN'T SHOW THE TRANSACTION IN THE LIST OF SUSPENDED TRANSACTIONS IF IT'S BEEN ADDED IT TO THE CURRENT TRANSACTION

				Customer customer = DataAccess.instance.GetCustomer(t.CustomerID);

				//POPULATE THE CUSTOMER NAME IN THE LIST
				if (customer != null && !customer.FirstName.Equals("") && !customer.LastName.Equals("")) {
					selectionListSuspendedTransactions.Items.Add($"{t.InvoiceID} | {customer.FirstName} {customer.LastName}");
				}
				else {
					selectionListSuspendedTransactions.Items.Add($"{t.InvoiceID} | No Name");
				}
			}

			//DEFAULT SELECTED ITEM IN THE LIST TO THE FIRST ONE
			if (selectionListSuspendedTransactions.Items.Count == 0) { dataGridViewSuspendedTransaction.DataSource = null; return; }

			selectionListSuspendedTransactions.SelectedIndex = 0;
		}


		/// <summary>
		/// Populates the grid with the given items list.
		/// </summary>
		/// <param name="items"></param>
		private void PopulateGrid(List<Item> items) {
            List<InventoryType> types = DataAccess.instance.GetInventoryType();
            List<Tax> taxes = DataAccess.instance.GetTax();

            dataGridViewSuspendedTransaction.DataSource = items
			.Select(x => {
                InventoryType inventoryType = types.Find((t) => x.ItemType == t.TypeName);
                Tax tax = null;

                if (inventoryType != null) {
                    tax = taxes.Find((t) => { return inventoryType.IdTax == t.IdTax; });
                }

                double taxBottleDeposit = tax != null ? tax.BottleDeposit : 0;
                double bottleDeposit = x.NumSold * x.Bottles * taxBottleDeposit;
                double itemPrice = x.DiscountPrice > 0 ? x.DiscountPrice : (x.Price * (1 - x.Discount));

                return new {
					description = x.Description,
					qty = x.NumSold,
					price = x.Price.ToString("C"),
					DISCOUNTPRICE = x.DiscountPrice.ToString("C"),
					discount = x.DiscountPrice > 0 ? "0%" : (Math.Floor(selectedSuspendedTransaction.ItemDiscount(x) * 100) / 100).ToString("P0"),
                    bottleDeposit = bottleDeposit.ToString("C"),
					total = (itemPrice * x.NumSold + bottleDeposit).ToString("C")
				};
			})
			.ToList();
		}
	}
}
