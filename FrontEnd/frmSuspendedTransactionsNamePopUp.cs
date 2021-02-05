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
		public Shared.Customer customer;


		public frmSuspendedTransactionsNamePopUp()
		{
			InitializeComponent();

			//PUT EACH CUSTOMER'S FIRST AND LAST NAME IN THE LIST TO CHOOSE FROM
			foreach (Shared.Customer customer in DataAccess.instance.GetCustomer()) { 
				listCustomers.Items.Add(customer.FirstName + " " + customer.LastName);
			}
		}

		private void textBoxSuspendedTransactionName_TextChanged(object sender, EventArgs e)
		{
			//CLEAR THE LIST OF NAMES BEFORE ADDING THEM BACK IN WITH THE FILTER
			listCustomers.Items.Clear();

			//GET THE CURRENT TYPED STRING
			string typedName = textBoxSuspendedTransactionName.Text;

			//FOR EACH CUSTOMER IN THE DATABASE, CHECK IF THE CUSTOMER NAME CONTAINS THE TYPED STRING
			DataAccess.instance.GetCustomer().ForEach(customer => {
				string customerName = customer.FirstName + " " + customer.LastName;
				
				if (customerName.ToLower().Contains(typedName.ToLower())) {
					listCustomers.Items.Add(customerName);
				}
			});

		}

		private void textBoxSuspendedTransactionName_KeyDown(object sender, KeyEventArgs e)
		{
			//ENSURE THAT A USER IS SELECTED AND SET IT TO 'nameOfSuspendedTransaction'
			if (e.KeyCode == Keys.Enter) {
				if (listCustomers.SelectedItem != null) {
					customer = findCustomer(listCustomers.SelectedItem.ToString());
				}

				this.Close();
			}
		}

		private void btnOkay_Click(object sender, EventArgs e)
		{
			//ENSURE THAT A USER IS SELECTED AND SET IT TO 'nameOfSuspendedTransaction'
			if (listCustomers.SelectedItem != null) {
				customer = findCustomer(listCustomers.SelectedItem.ToString());
			}

			this.Close();
		}

		private void listCustomers_SelectedIndexChanged(object sender, EventArgs e) {

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private Shared.Customer findCustomer(string customerName) {
			foreach (Shared.Customer customer in DataAccess.instance.GetCustomer()) {
				if (customerName.Equals(customer.FirstName + " " + customer.LastName)) {
					return customer;
				}
			}

			return null;
		}

		private void btn_CloseWindow_Click(object sender, EventArgs e) {
			this.Close();
		}
	}
}
