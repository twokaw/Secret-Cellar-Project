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
		private frmTransaction transactionForm;

		public frmSuspendedTransactions(frmTransaction t)
		{
			InitializeComponent();
			transactionForm = t;

			//POPULATE THE LIST OF SUSPENDED TRANSACTIONS
			foreach(var transaction in suspendedTransactionsMap) {
				selectionListSuspendedTransactions.Items.Add(transaction.Key);
			}

			//DEFAULT SELECTED ITEM IN THE LIST OF SUSPENDED TRANSACTIONS TO 0
			if (suspendedTransactionsMap.Count > 0) {
				selectionListSuspendedTransactions.SelectedIndex = 0;
			}

		}

		private void dataGridViewSuspendedTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e) {

		}

		private void selectionListSuspendedTransactions_SelectedIndexChanged(object sender, EventArgs e) {
			if (suspendedTransactionsMap.Count > 0) {
				this.dataGridViewSuspendedTransaction.Rows.Clear();
				int index = selectionListSuspendedTransactions.SelectedIndex;
				currentTransaction = suspendedTransactionsMap.ElementAt(index).Value;

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
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			suspendedTransactionsMap.Remove(selectionListSuspendedTransactions.SelectedItem.ToString());

			//TODO fix this. It is mostly working but there are still some issues
			if (selectionListSuspendedTransactions.SelectedIndex != 0) {
				selectionListSuspendedTransactions.SelectedIndex = selectionListSuspendedTransactions.SelectedIndex - 1;
				selectionListSuspendedTransactions.Items.RemoveAt(selectionListSuspendedTransactions.SelectedIndex + 1);
			}
			else {
				selectionListSuspendedTransactions.SelectedIndex = selectionListSuspendedTransactions.SelectedIndex + 1;
				selectionListSuspendedTransactions.Items.RemoveAt(selectionListSuspendedTransactions.SelectedIndex - 1);
			}
			
			//CLEAR THE DATA GRID IF THERE ARE NO ITEMS LEFT
			if (selectionListSuspendedTransactions.Items.Count == 0) {
				dataGridViewSuspendedTransaction.Rows.Clear();
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			//TODO need to add code to delete the suspended transaction
			this.Close();
			transactionForm.importSuspendedTransaction(this.currentTransaction);
		}

		
	}
}
