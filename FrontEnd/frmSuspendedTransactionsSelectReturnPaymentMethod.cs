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
	public partial class frmSuspendedTransactionsSelectReturnPaymentMethod : ManagedForm {
		private Shared.Transaction transaction = null;
		private double paymentsTotal = 0;
		private bool _didDeleteTransaction = false;

		public bool DidDeleteTransaction { get { return _didDeleteTransaction; } }


		
		public frmSuspendedTransactionsSelectReturnPaymentMethod(Shared.Transaction selectedSuspendedTransaction) {
			InitializeComponent();
			transaction = selectedSuspendedTransaction;

			//GET THE PAYMENTS TOTAL
			foreach (Shared.Payment payment in transaction.Payments) {
				paymentsTotal += payment.Amount;
			}

			label_Result.Text = "Payment Total: $" + paymentsTotal;
		}

		private void button_Credit_Click(object sender, EventArgs e) {
			if (frmManagerOverride.DidOverride("Add Credit To Customer")) {
				//REMOVE ALL THE PAYMENTS FROM THE TRANSACTION
				transaction.Payments.Clear();
				DataAccess.instance.ProcessTransaction(transaction);
			
				//GET THE CUSTOMER AND UPDATE THE CREDIT
				Shared.Customer customer = DataAccess.instance.GetCustomer(transaction.CustomerID);
				customer.Credit += paymentsTotal;
				DataAccess.instance.UpdateCustomer(customer);

				DataAccess.instance.DeleteTransaction(transaction.InvoiceID);
				_didDeleteTransaction = true;

				this.Close();
			}
		}
		
		private void button_Cash_Click(object sender, EventArgs e) {
			if (frmManagerOverride.DidOverride("Give Cash Back To Customer")) {
				//REMOVE ALL THE PAYMENTS FROM THE TRANSACTION
				transaction.Payments.Clear();
				DataAccess.instance.ProcessTransaction(transaction);
				DataAccess.instance.DeleteTransaction(transaction.InvoiceID);
				_didDeleteTransaction = true;

				//OPEN THE DRAWER
				DataAccess.instance.OpenCashDrawer();

				//HIDE THE SELECTION FORM
				this.Visible = false;
				this.Close();

				//SHOW A MESSAGE BOX WITH THE TOTAL AMOUNT SO IT'S ON SCREEN AFTER THE DRAWER OPENS
				MessageBox.Show("$" + paymentsTotal, "Total");
			}
		}
		
		private void button_CloseWindow_Click(object sender, EventArgs e) {
			this.Close();
		}

		
	}
}
