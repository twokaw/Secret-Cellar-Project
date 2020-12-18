using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretCellar
{
	public partial class frmSuspendedTransactionsNamePopUp : Form
	{
		public string nameOfSuspendedTransaction;


		public frmSuspendedTransactionsNamePopUp()
		{
			InitializeComponent();

			//TODO Show all the customers in the listUsers selection box
		}

		private void textBoxSuspendedTransactionName_TextChanged(object sender, EventArgs e)
		{
			//TODO Refresh the listUser selection box with names that match the text of this text field
		}

		private void textBoxSuspendedTransactionName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				this.nameOfSuspendedTransaction = textBoxSuspendedTransactionName.Text;
				this.Close();
			}
		}

		private void btnOkay_Click(object sender, EventArgs e)
		{
			this.nameOfSuspendedTransaction = textBoxSuspendedTransactionName.Text;
			this.Close();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void listUsers_SelectedIndexChanged(object sender, EventArgs e) {

		}
	}
}
