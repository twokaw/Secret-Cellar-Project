using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Shared;




namespace SecretCellar {
	public partial class frmInvoices : Form {



		public frmInvoices() {
			InitializeComponent();

			PopulateGrid();
		}


		/// <summary>
		/// Closes the form.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_CloseWindow_Click(object sender, EventArgs e) { this.Close(); }



		private void PopulateGrid() {
			List<Transaction> suspendedTransactions = DataAccess.instance.GetSuspendedTransactions();

			dataGridView_Invoices.DataSource = suspendedTransactions;
		}
	}
}
