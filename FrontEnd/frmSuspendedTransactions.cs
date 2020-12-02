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

		public frmSuspendedTransactions()
		{
			InitializeComponent();

			//FOR EACH SUSPENDED TRANSACTION
			for (int i=0; i<suspendedTransactionsList.Count; i++) {
				String currentSuspendedTransaction = suspendedTransactionsList[i].ToString();
				String[] currentSuspendedTransactionSplit = currentSuspendedTransaction.Split(';');

				listSuspendedTransactions.Items.Add(currentSuspendedTransactionSplit[0]);

				//FOR EACH ROW IN THE CURRENT SUSPENDED TRANSACTION
				for (int k=1; k<currentSuspendedTransactionSplit.Length; k++) {
					int rowIndex = this.dataGridViewSuspendedTransactions.Rows.Add();
					String[] cells = currentSuspendedTransactionSplit[k].Split(',');
					
					for (int j=0; j<cells.Length; j++) {
						this.dataGridViewSuspendedTransactions.Rows[rowIndex].Cells[j].Value = cells[j];
					}
				}
			}

			/*
			if (frmTransaction.chosenItems != null) {
				//LOOP THROUGH EACH OF THE 'chosenItems' ROWS IN THE TRANSACTION FORM
				for (int i=0; i<frmTransaction.chosenItems.Count; i++) {
					DataGridViewRow row = frmTransaction.chosenItems[i];
					int index = this.dataGridViewSuspendedTransactions.Rows.Add();

					//FOR EACH CELL IN EACH ROW
					for (int k=0; k<row.Cells.Count; k++) {
						DataGridViewCell cell = row.Cells[k];

						//ADD EACH CELL VALUE
						if (cell.Value != null) {
							this.dataGridViewSuspendedTransactions.Rows[index].Cells[k].Value = cell.Value.ToString();
						}
						else {
							this.dataGridViewSuspendedTransactions.Rows[index].Cells[k].Value = "";
						}
					
					}
				}
			}
			*/

		}

		private void dataGridViewSuspendedTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void listSuspendedTransactions_SelectedIndexChanged(object sender, EventArgs e)
		{
			//TODO add code that will get the currently selected item and match it in the array/sql database
			//to then display in the dataGridView


		}

		private void btnDelete_Click(object sender, EventArgs e)
		{

		}
	}
}
