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
		private List<Shared.Customer> customerList;

		public frmSuspendedTransactionsNamePopUp()
		{
			InitializeComponent();

			//PUT EACH CUSTOMER'S FIRST AND LAST NAME IN THE LIST TO CHOOSE FROM
			customerList = DataAccess.instance.GetCustomer();

			foreach (Shared.Customer customer in customerList) { 
				listUsers.Items.Add(customer.FirstName + " " + customer.LastName);
			}
		}

		private void textBoxSuspendedTransactionName_TextChanged(object sender, EventArgs e)
		{
			//CLEAR THE LIST OF NAMES BEFORE ADDING THEM BACK IN WITH THE FILTER
			listUsers.Items.Clear();

			//GET THE CURRENT TYPED STRING
			string typedName = textBoxSuspendedTransactionName.Text;

			//FOR EACH CUSTOMER IN THE DATABASE, CHECK IF THE CUSTOMER NAME CONTAINS THE TYPED STRING
			customerList.ForEach(customer => {
				string customerName = customer.FirstName + " " + customer.LastName;
				
				if (customerName.ToLower().Contains(typedName.ToLower())) {
					listUsers.Items.Add(customerName);
				}
			});

		}

		private void textBoxSuspendedTransactionName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				//TODO add code to grab the selected text in the listUsers

				this.nameOfSuspendedTransaction = textBoxSuspendedTransactionName.Text;
				this.Close();
			}
		}

		private void btnOkay_Click(object sender, EventArgs e)
		{
			//TODO add code to grab the selected text in the listUsers

			this.nameOfSuspendedTransaction = textBoxSuspendedTransactionName.Text;
			this.Close();
		}

		private void listUsers_SelectedIndexChanged(object sender, EventArgs e) {
			//TODO possibly something like this
			//textBoxSuspendedTransactionName.Text = listUsers.SelectedItem.ToString();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		
	}
}
