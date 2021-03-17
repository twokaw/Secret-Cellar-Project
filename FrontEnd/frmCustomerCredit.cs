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
			this.label_CustomersCreditValue.Text = customer.Credit + "";
		}

		private void button_SubtractCredit_Click(object sender, EventArgs e) {

		}

		private void button_AddCredit_Click(object sender, EventArgs e) {

		}

		private void button_ResetCredit_Click(object sender, EventArgs e) {

		}

		private void button_ForceChange_Click(object sender, EventArgs e) {

		}

		private void button_CloseWindow_Click(object sender, EventArgs e) {
			this.Close();
		}

		
	}
}
