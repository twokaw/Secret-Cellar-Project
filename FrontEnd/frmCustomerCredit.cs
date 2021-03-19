using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared;

namespace SecretCellar {
	public partial class frmCustomerCredit : Form {
		Customer customer = null;

		public frmCustomerCredit(Customer c) {
			InitializeComponent();

			customer = c;
			this.label_CustomersCredit.Text = customer.FirstName + "'s Credit:";
			this.label_CustomersCreditValue.Text = "$" + customer.Credit;
		}

		private void button_SubtractCredit_Click(object sender, EventArgs e) {
			updateCredit("subtract");
		}

		private void button_AddCredit_Click(object sender, EventArgs e) {
			updateCredit("add");
		}

		private void button_ResetCredit_Click(object sender, EventArgs e) {
			updateCredit("reset");
		}

		private void button_ForceChange_Click(object sender, EventArgs e) {
			updateCredit("force");
		}

		private void button_CloseWindow_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void updateCredit(string method) {
			double value;

			if (method.Equals("reset")) {
				customer.Credit = 0;
				DataAccess.instance.UpdateCustomer(customer);
				this.label_CustomersCreditValue.Text = "$" + customer.Credit;
			}
			else if (double.TryParse(textBox_NewCreditAmount.Text, out value)) {
				switch(method) {
					case "add":
						customer.Credit += value;
						break;
					case "subtract":
						customer.Credit -= value;
						break;
					case "force":
						customer.Credit = value;
						break;
				}

				DataAccess.instance.UpdateCustomer(customer);
				this.label_CustomersCreditValue.Text = "$" + customer.Credit;
			}
			else {
				if (textBox_NewCreditAmount.Text.Replace(" ", "").Equals("")) {
					MessageBox.Show("Value cannot be empty.", "Error");
				}
				else {
					MessageBox.Show("Value can only be numbers.", "Error");
				}
			}
		}


	}
}
