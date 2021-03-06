﻿using System;
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
		private Shared.Transaction transaction = null;
		private double paymentsTotal = 0;
		
		
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
			//REMOVE ALL THE PAYMENTS FROM THE TRANSACTION
			transaction.Payments.Clear();
			DataAccess.instance.ProcessTransaction(transaction);
			
			//GET THE CUSTOMER AND UPDATE THE CREDIT
			Shared.Customer customer = DataAccess.instance.GetCustomer(transaction.CustomerID);
			customer.Credit += paymentsTotal;
			DataAccess.instance.UpdateCustomer(customer);

			this.Close();
		}
		
		private void button_Cash_Click(object sender, EventArgs e) {
			//REMOVE ALL THE PAYMENTS FROM THE TRANSACTION
			transaction.Payments.Clear();
			DataAccess.instance.ProcessTransaction(transaction);

			//OPEN THE DRAWER
			DataAccess.instance.OpenCashDrawer();

			//HIDE AND CLOSE THE SELECTION FORM
			this.Visible = false;
			this.Close();

			//SHOW A MESSAGE BOX WITH THE TOTAL AMOUNT SO IT'S ON SCREEN AFTER THE DRAWER OPENS
			MessageBox.Show("$" + paymentsTotal, "Total");
		}
		
		private void button_CloseWindow_Click(object sender, EventArgs e) {
			this.Close();
		}

		
	}
}
