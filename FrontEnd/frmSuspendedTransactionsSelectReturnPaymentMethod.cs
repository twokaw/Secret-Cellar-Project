using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretCellar {
	public partial class frmSuspendedTransactionsSelectReturnPaymentMethod : Form {
		Shared.Transaction transaction = null;

		public frmSuspendedTransactionsSelectReturnPaymentMethod(Shared.Transaction transactionFromSuspendedTransactions) {
			InitializeComponent();
			transaction = transactionFromSuspendedTransactions;
			double paymentsTotal = 0;

			//GET THE PAYMENTS TOTAL
			foreach (Shared.Payment payment in transaction.Payments) {
				paymentsTotal += payment.Amount;
			}

			label_Result.Text = "Payment Total: $" + paymentsTotal;
		}

		private void button_Credit_Click(object sender, EventArgs e) {
			//TODO: Add applying credit code
			MessageBox.Show("Apply credit");

			this.Close();
		}

		private void button_ReturnPayment_Click(object sender, EventArgs e) {
			//TODO: Add return payment code
			MessageBox.Show("Return payment");

			this.Close();
		}

		private void button_CloseWindow_Click(object sender, EventArgs e) {
			this.Close();
		}
	}
}
