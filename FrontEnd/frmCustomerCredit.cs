using System;
using System.Windows.Forms;
using Shared;

namespace SecretCellar {
	public partial class frmCustomerCredit : Form {
		Customer customer = null;
		double oldCredit = 0;
		double newCredit = 0;

		public frmCustomerCredit(Customer c) {
			InitializeComponent();

			customer = c;
			newCredit = customer.Credit;
			oldCredit = customer.Credit;

			this.label_CustomersCredit.Text = "Current Credit:";
			this.label_CustomersCreditValue.Text = $"{newCredit:c2}";
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

		private void button_Confirm_Click(object sender, EventArgs e) {
			if (frmManagerOverride.DidOverride("Update Credit")) {
				customer.Credit = newCredit;
				DataAccess.instance.UpdateCustomer(customer);
				Close();
            }
		}

		private void updateCredit(string method) {
			if (method.Equals("reset")) {
				newCredit = oldCredit;
				this.label_CustomersCreditValue.Text = $"{newCredit:c2}";
				
				button_Confirm.Enabled = false;
			}
			else if (double.TryParse(textBox_NewCreditAmount.Text, out double value)) {
				switch(method) {
					case "add":
						newCredit += value;
						break;
					case "subtract":
						newCredit -= value;
						break;
					case "force":
						newCredit = value;
						break;
				}

				button_Confirm.Enabled = true;
				label_CustomersCreditValue.Text = $"{newCredit:c2}";
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

        private void txtCashAmt_Enter(object sender, EventArgs e)
        {
			touchKeyPad1.Target = (TextBox)sender;
		}
    }
}
