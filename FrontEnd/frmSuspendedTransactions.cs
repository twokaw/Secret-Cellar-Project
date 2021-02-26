using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared;

namespace SecretCellar
{
	public partial class frmSuspendedTransactions : Form
	{
		private frmTransaction transactionForm;
		private List<Transaction> suspendedTransactions;
		private List<uint> suspendedTransactionsIdTracker;
		private Transaction selectedTransaction;
		

		public frmSuspendedTransactions(frmTransaction formTransaction, Transaction transactionFromFormTransaction)
		{
			InitializeComponent();
			transactionForm = formTransaction;
			suspendedTransactions = DataAccess.instance.GetSuspendedTransactions();
			suspendedTransactionsIdTracker = new List<uint>();

			//POPULATE THE LIST OF SUSPENDED TRANSACTIONS CUSTOMER NAMES
			foreach (Transaction t in suspendedTransactions) {
				if (t.InvoiceID != transactionFromFormTransaction.InvoiceID) {
					//ADD THE TRANSACTION INVOICE ID TO THE TRACKER
					suspendedTransactionsIdTracker.Add(t.InvoiceID);

					//GET THE CUSTOMER OF THE SUSPENDED TRANSACTION
					Customer customer = DataAccess.instance.GetCustomer(t.CustomerID);

					//POPULATE THE CUSTOMER NAME IN THE LIST
					if (customer != null && !customer.FirstName.Equals("") && !customer.LastName.Equals("")) {
						selectionListSuspendedTransactions.Items.Add(customer.FirstName + " " + customer.LastName);
					}
					else {
						selectionListSuspendedTransactions.Items.Add("No Name");
					}
				}
			}

			//DEFAULT SELECTED ITEM IN THE LIST OF SUSPENDED TRANSACTIONS TO 0
			if (suspendedTransactions.Count > 0) {
				selectionListSuspendedTransactions.SelectedIndex = 0;
			}
		}

		private void dataGridViewSuspendedTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e) {

		}

		private void selectionListSuspendedTransactions_SelectedIndexChanged(object sender, EventArgs e) {
			//IF THERE IS AT LEAST ONE SUSPENDED TRANSACTION THEN CONTINUE
			if (suspendedTransactions.Count > 0 && selectionListSuspendedTransactions.SelectedIndex > 0) {
				this.dataGridViewSuspendedTransaction.Rows.Clear();

				//GET THE TRANSACTION OF THE CURRENTLY SELECTED CUSTOMER VIA THE TRACKER
				uint transactionId = suspendedTransactionsIdTracker.ElementAt(selectionListSuspendedTransactions.SelectedIndex);
				selectedTransaction = DataAccess.instance.GetTransactions(transactionId);

				//ADD EACH ROW IN THE TRANSACTION TO THE ROW IN THE VIEW
				foreach (Item item in selectedTransaction.Items) {
					int rowIndex = dataGridViewSuspendedTransaction.Rows.Add();

					using (var currentRow = dataGridViewSuspendedTransaction.Rows[rowIndex]) {
						currentRow.Cells[0].Value = item.Description;
						currentRow.Cells[1].Value = item.NumSold;
						currentRow.Cells[2].Value = (item.Price * (1 - item.Discount)).ToString("C");
						currentRow.Cells[3].Value = item.Discount.ToString("P0");
						currentRow.Cells[4].Value = "";
						currentRow.Cells[5].Value = (item.NumSold * item.Bottles * .05).ToString("C");
						currentRow.Cells[6].Value = (item.Price * item.NumSold * (1 - item.Discount)).ToString("C");
					}
				}
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (selectionListSuspendedTransactions.Items.Count > 0 && selectedTransaction != null) {
				int selectedIndex = selectionListSuspendedTransactions.SelectedIndex;

				//ENSURE THAT THE TRANSACTION DOESN'T HAVE PAYMENTS STILL
				if (selectedTransaction.Payments.Count > 0) {
					DialogResult result = MessageBox.Show("Cannot delete transaction. There are still outstanding payments. Would you like to remove the payments?", "Error", MessageBoxButtons.YesNo);

					if (result == DialogResult.No) {
						return;
					}
					else if (result == DialogResult.Yes) {
						double paymentsTotal = 0;
						
						//GET THE PAYMENTS TOTAL
						foreach (Payment payment in selectedTransaction.Payments) {
							paymentsTotal += payment.Amount;
						}

						//SHOW THE FORM TO DISPLAY THE PAYMENTS AMOUNT AND SELECT THE PAYMENT RETURN METHOD
						frmSuspendedTransactionsSelectReturnPaymentMethod selectReturnPaymentMethod = new frmSuspendedTransactionsSelectReturnPaymentMethod(paymentsTotal);
						DialogResult returnPaymentResult = selectReturnPaymentMethod.ShowDialog();

						if (returnPaymentResult == DialogResult.Abort) {
							return;
						}
					}
				}

				//DELETE THE TRANSACTION FROM THE DATABASE
				DataAccess.instance.DeleteTransaction(selectedTransaction.InvoiceID);

				//IF THE USER DELETES THE FIRST ITEM IN THE LIST
				if (selectedIndex == 0 && selectionListSuspendedTransactions.Items.Count > 1) {
					selectionListSuspendedTransactions.SelectedIndex += 1;
				}

				//IF THE USER DELETES THE LAST ITEM IN THE LIST
				else if (selectedIndex == selectionListSuspendedTransactions.Items.Count - 1 && selectionListSuspendedTransactions.Items.Count > 1) {
					selectionListSuspendedTransactions.SelectedIndex -= 1;
				}

				//IF THE USER DELETES AN ITEM IN THE MIDDLE
				else if (selectedIndex > 0 && selectedIndex < selectionListSuspendedTransactions.Items.Count - 1) {
					selectionListSuspendedTransactions.SelectedIndex -= 1;
				}

				//REMOVE THE TRANSACTION FROM THE TRACKER AND FROM THE LIST
				suspendedTransactionsIdTracker.RemoveAt(selectedIndex);
				selectionListSuspendedTransactions.Items.RemoveAt(selectedIndex);
			}

			//CLEAR THE DATA GRID AND TRACKER IF THERE ARE NO ITEMS LEFT
			if (selectionListSuspendedTransactions.Items.Count == 0) {
				dataGridViewSuspendedTransaction.Rows.Clear();
				suspendedTransactionsIdTracker.Clear();
				selectedTransaction = null;
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (selectedTransaction != null && selectedTransaction.Items.Count > 0) {
				//CREATE A NEW TRANSACTION FROM THE SELECTED TRANSACTION
				Transaction newTransaction = new Transaction(selectedTransaction.InvoiceID,
												selectedTransaction.RegisterID,
												selectedTransaction.TransactionDateTime,
												selectedTransaction.Location,
												selectedTransaction.Items,
												selectedTransaction.Discount,
												selectedTransaction.TaxExempt,
												selectedTransaction.Payments,
												selectedTransaction.EmployeeID,
												selectedTransaction.CustomerID);
				
				//UPDATE THE CUSTOMER INFORMATION
				Customer customer = DataAccess.instance.GetCustomer(newTransaction.CustomerID);
				newTransaction.CustomerName = customer.FirstName + " " + customer.LastName;

				//CLOSE THE WINDOW AND CALL THE IMPORT FUNCTION
				this.Close();
				transactionForm.importSuspendedTransaction(newTransaction);
			}
		}

		private void btn_CloseWindow_Click(object sender, EventArgs e) {
			this.Close();
		}

	}
}
