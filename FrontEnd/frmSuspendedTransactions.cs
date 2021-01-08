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
		Transaction currentTransaction = null;
		public static Dictionary<string, Transaction> suspendedTransactionsMap = new Dictionary<string, Transaction>();
		List<Transaction> suspendedTransactions;
		private frmTransaction transactionForm;

		public frmSuspendedTransactions(frmTransaction formTransaction)
		{
			InitializeComponent();
			transactionForm = formTransaction;
			suspendedTransactions = DataAccess.instance.GetSuspendedTransactions();

			//POPULATE THE LIST OF SUSPENDED TRANSACTIONS CUSTOMER NAMES
			foreach (Transaction t in suspendedTransactions) {
				selectionListSuspendedTransactions.Items.Add(t.CustomerName);
			}

			/* can be deleted once everything is working
			//POPULATE THE LIST OF SUSPENDED TRANSACTIONS
			foreach(var transaction in suspendedTransactionsMap) {
				selectionListSuspendedTransactions.Items.Add(transaction.Key);
			}
			*/

			//DEFAULT SELECTED ITEM IN THE LIST OF SUSPENDED TRANSACTIONS TO 0
			if (suspendedTransactionsMap.Count > 0) {
				selectionListSuspendedTransactions.SelectedIndex = 0;
			}

		}

		private void dataGridViewSuspendedTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e) {

		}

		private void selectionListSuspendedTransactions_SelectedIndexChanged(object sender, EventArgs e) {
			//IF THERE IS AT LEAST ONE SUSPENDED TRANSACTION THEN CONTINUE
			if (suspendedTransactions.Count > 0) {
				this.dataGridViewSuspendedTransaction.Rows.Clear();

				//GET THE NAME OF THE ITEM SELECTED AND MATCH IT TO THE TRANSACTION IN THE MAP
				string suspendedTransactionCustomer = selectionListSuspendedTransactions.SelectedItem.ToString();

				foreach (Transaction t in suspendedTransactions) {
					if (t.CustomerName.Equals(suspendedTransactionCustomer)) {
						currentTransaction = t;
					}
				}

				//ADD EACH ROW IN THE TRANSACTION TO THE ROW IN THE VIEW
				foreach (Item item in currentTransaction.Items) {
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


			/*
			//IF THERE IS AT LEAST ONE TRANSACTION IN THE MAP THEN CONTINUE
			if (suspendedTransactionsMap.Count > 0) {
				this.dataGridViewSuspendedTransaction.Rows.Clear();

				//GET THE NAME OF THE ITEM SELECTED AND MATCH IT TO THE TRANSACTION IN THE MAP
				int index = selectionListSuspendedTransactions.SelectedIndex;
				currentTransaction = suspendedTransactionsMap.ElementAt(index).Value;

				//ADD EACH ROW IN THE TRANSACTION TO THE ROW IN THE VIEW
				foreach (Item item in currentTransaction.Items) {
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
			*/

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (selectionListSuspendedTransactions.Items.Count > 0) {
				string selectedItem = selectionListSuspendedTransactions.SelectedItem.ToString();

				//IF THE USER DELETES THE FIRST ITEM IN THE LIST
				if (selectionListSuspendedTransactions.SelectedIndex == 0 && selectionListSuspendedTransactions.Items.Count > 1) {
					selectionListSuspendedTransactions.SelectedIndex += 1;
					selectionListSuspendedTransactions.Items.RemoveAt(selectionListSuspendedTransactions.SelectedIndex-1);
				}

				//IF THE USER DELETES THE ONLY ITEM IN THE LIST
				else if (selectionListSuspendedTransactions.SelectedIndex == 0) {
					//THE ITEM IN THE MAP NEEDS TO BE REMOVED FIRST OTHERWISE IT WILL ERROR
					suspendedTransactionsMap.Remove(selectedItem);
					selectionListSuspendedTransactions.Items.RemoveAt(selectionListSuspendedTransactions.SelectedIndex);
				}

				//IF THE USER DELETES THE LAST ITEM IN THE LIST
				else if (selectionListSuspendedTransactions.SelectedIndex == selectionListSuspendedTransactions.Items.Count-1 && selectionListSuspendedTransactions.Items.Count > 1) {
					selectionListSuspendedTransactions.SelectedIndex -= 1;
					selectionListSuspendedTransactions.Items.RemoveAt(selectionListSuspendedTransactions.SelectedIndex+1);
				}

				//IF THE USER DELETES AN ITEM IN THE MIDDLE
				else {
					selectionListSuspendedTransactions.SelectedIndex -= 1;
					selectionListSuspendedTransactions.Items.RemoveAt(selectionListSuspendedTransactions.SelectedIndex+1);
					selectionListSuspendedTransactions.SelectedIndex += 1;
				}

				//TODO: change this to remove from the database
				//REMOVE THE TRANSACTION FROM THE MAP (DATABASE)
				suspendedTransactionsMap.Remove(selectedItem);
			}
			
			//CLEAR THE DATA GRID AND MAP IF THERE ARE NO ITEMS LEFT
			if (selectionListSuspendedTransactions.Items.Count == 0) {
				dataGridViewSuspendedTransaction.Rows.Clear();
				suspendedTransactionsMap.Clear();
				currentTransaction = null;
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (currentTransaction != null && currentTransaction.Items.Count > 0) {
				//CREATE A NEW TRANSACTION THAT CONTAINS ITEMS IN THE CURRENT TRANSACTION
				Transaction t = new Transaction();
				foreach (Item item in currentTransaction.Items) {
					t.Items.Add(item);
				}

				//REMOVE THE ITEM THAT IS SELECTED AND CLOSE THE FORM
				btnDelete_Click(sender, e);
				this.Close();

				//CALL THE IMPORT FUNCTION
				transactionForm.importSuspendedTransaction(t);
			}
		}
	}
}
