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
		public static ArrayList suspendedTransactionsList = new ArrayList();
		public static Dictionary<string, Transaction> suspendedTransactions = new Dictionary<string, Transaction>();
		private frmTransaction transactionForm;

		public frmSuspendedTransactions(frmTransaction t)
		{
			InitializeComponent();
			transactionForm = t;

			//POPULATE THE LIST OF SUSPENDED TRANSACTIONS
			foreach(var transaction in suspendedTransactions) {
				listSuspendedTransactions.Items.Add(transaction.Key);
			}

			/* CAN DELETE
			for (int i=0; i<transactions.Count; i++) {
				listSuspendedTransactions.Items.Add(transactions.Keys.FirstOrDefault()); //.ToString().Split(';')[0]);
			}
			*/

			//DEFAULT SELECTED ITEM IN THE LIST OF SUSPENDED TRANSACTIONS TO 0
			if (suspendedTransactions.Count > 0) {
				listSuspendedTransactions.SelectedIndex = 0;
			}

		}

		private void dataGridViewSuspendedTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void listSuspendedTransactions_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (suspendedTransactions.Count > 0) {
				this.dataGridViewSuspendedTransactions.Rows.Clear();
				int index = listSuspendedTransactions.SelectedIndex;
				Transaction currentTransaction = suspendedTransactions.ElementAt(index).Value;

				foreach (Item item in currentTransaction.Items) {
					int rowIndex = dataGridViewSuspendedTransactions.Rows.Add();

					using (var currentRow = dataGridViewSuspendedTransactions.Rows[rowIndex]) {
						currentRow.Cells[0].Value = item.Description;
						currentRow.Cells[1].Value = item.NumSold;
						currentRow.Cells[2].Value = (item.Price * (1 - item.Discount)).ToString("C");
						currentRow.Cells[3].Value = item.Discount.ToString("P0");

						//TODO FIX THE TAX AMOUNT
						currentRow.Cells[4].Value = "tax goes here";
						currentRow.Cells[5].Value = (item.NumSold * item.Bottles * .05).ToString("C");
						currentRow.Cells[6].Value = (item.Price * item.NumSold * (1 - item.Discount)).ToString("C");
					}
				}
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			//TODO This is what will error when you try to delete something. It changes the selected index which then calls the changed event function and that's where it errors
			suspendedTransactionsList.RemoveAt(listSuspendedTransactions.SelectedIndex);
			this.dataGridViewSuspendedTransactions.Rows.Clear();
			
			if (listSuspendedTransactions.SelectedIndex > 0) {
				listSuspendedTransactions.SelectedIndex = listSuspendedTransactions.SelectedIndex - 1;
				listSuspendedTransactions.Items.RemoveAt(listSuspendedTransactions.SelectedIndex);
			}
			
			
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			//TODO need to add code to delete the suspended transaction
			this.Close();
			transactionForm.importSuspendedTransaction(this.dataGridViewSuspendedTransactions.Rows);
		}
	}
}
