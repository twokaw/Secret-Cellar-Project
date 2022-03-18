using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Shared;




namespace SecretCellar {
	public partial class frmInvoices : Form {
		private readonly string _defaultFilterString = "Filter...";



		public frmInvoices() {
			InitializeComponent();

			PopulateListOfInvoices();
		}


		/// <summary>
		/// On filter focus.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void textBox_Filter_Enter(object sender, EventArgs e) {
			if (textBox_Filter.Text != _defaultFilterString) { return; }

			textBox_Filter.Text = "";
		}


		/// <summary>
		/// On filter unfocus.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void textBox_Filter_Leave(object sender, EventArgs e) {
			if (textBox_Filter.Text != "".Replace(" ", "")) { return; }

			textBox_Filter.Text = _defaultFilterString;
		}


		/// <summary>
		/// Closes the form.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_CloseWindow_Click(object sender, EventArgs e) { this.Close(); }


		/// <summary>
		/// Update the data grid based on the selected invoice.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void selectionList_Invoices_SelectedIndexChanged(object sender, EventArgs e) {
			if (selectionList_Invoices.SelectedItems.Count == 0) { return; }


		}


		/// <summary>
		/// Populates the list invoices.
		/// </summary>
		private void PopulateListOfInvoices() {
			List<Transaction> suspendedTransactions = DataAccess.instance.GetSuspendedTransactions();
			List<Transaction> invoices = suspendedTransactions.FindAll((transaction) => { return transaction.TranType == Transaction.TranactionType.Invoice; });

			dataGridView_Invoices.DataSource = invoices;
		}

	}
}
