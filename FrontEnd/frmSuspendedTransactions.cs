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

namespace SecretCellar
{
	public partial class frmSuspendedTransactions : Form
	{
		public static ArrayList suspendedTransactionsList = new ArrayList();
		private frmTransaction transaction;

		public frmSuspendedTransactions(frmTransaction t)
		{
			InitializeComponent();
			transaction = t;

			//POPULATE THE LIST OF SUSPENDED TRANSACTIONS
			for (int i=0; i<suspendedTransactionsList.Count; i++) {
				listSuspendedTransactions.Items.Add(suspendedTransactionsList[i].ToString().Split(';')[0]);
			}

			//DEFAULT SELECTED ITEM IN THE LIST OF SUSPENDED TRANSACTIONS TO 0
			if (suspendedTransactionsList.Count > 0) {
				listSuspendedTransactions.SelectedIndex = 0;
			}

		}

		private void dataGridViewSuspendedTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void listSuspendedTransactions_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (suspendedTransactionsList.Count > 0) {
				//SET THE 'currentSuspendedTransaction' TO THE SELECTED ITEM IN THE SUSPENDED TRANSACTION LIST
				String currentSuspendedTransaction = suspendedTransactionsList[listSuspendedTransactions.SelectedIndex].ToString();
				String[] currentSuspendedTransactionSplit = currentSuspendedTransaction.Split(';');

				//FOR EACH ROW IN THE CURRENT SUSPENDED TRANSACTION
				this.dataGridViewSuspendedTransactions.Rows.Clear();

				for (int k = 1; k < currentSuspendedTransactionSplit.Length; k++) {
					int rowIndex = this.dataGridViewSuspendedTransactions.Rows.Add();
					String[] cells = currentSuspendedTransactionSplit[k].Split(',');

					//ADD EACH CELL FOR THE CURRENT ROW
					for (int j = 0; j < cells.Length; j++) {
						this.dataGridViewSuspendedTransactions.Rows[rowIndex].Cells[j].Value = cells[j];
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
			transaction.importSuspendedTransaction(this.dataGridViewSuspendedTransactions.Rows);
		}
	}
}
