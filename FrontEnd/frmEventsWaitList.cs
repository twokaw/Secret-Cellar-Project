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
	public partial class frmEventsWaitList : Form {
		private Transaction _transaction;
		private Customer _transactionCustomer;
		private Event _selectedEvent;

		public frmEventsWaitList(Event selectedEvent, Transaction transactionFromForm) {
			InitializeComponent();

			//UPDATE THE PRIVATE FIELDS WITH THE INCOMING PARAMETERS
			_transaction = transactionFromForm;
			_transactionCustomer = DataAccess.instance.GetCustomer(_transaction.CustomerID);
			_selectedEvent = selectedEvent;

			//SET THE CUSTOMER NAME TEXT BOX
			textBox_Customer.Text = _transactionCustomer.FirstName + " " + _transactionCustomer.LastName;

			//UPDATE THE DATA GRID VIEW WITH THE CUSTOMERS CURRENTLY ON THE WAITLIST FOR THE SELECTED EVENT
			UpdateWaitListGrid(_selectedEvent);
		}

		private void button_CustomerList_Click(object sender, EventArgs e) {
			//CREATE A NEW CUSTOMER FORM
			frmCustomer customerForm = new frmCustomer(_transaction);
			customerForm.ShowDialog();

			//UPDATE THE CUSTOMER WITH THE NEW ID SELECTED FROM THE CUSTOMER FORM
			_transactionCustomer = DataAccess.instance.GetCustomer(_transaction.CustomerID);

			//UPDATE THE CUSTOMER NAME TEXT BOX
			textBox_Customer.Text = _transactionCustomer.FirstName + " " + _transactionCustomer.LastName;
		}

		private void button_Remove_Click(object sender, EventArgs e) {
			if (dataGridView_Customers.SelectedRows.Count > 0) {
				int selectedCustomerId = int.Parse(dataGridView_Customers.SelectedRows[0].Cells[Id.Index].Value.ToString());

				//TODO: Call the method to remove the customer by id from the waitlist database.

			}
		}

		private void button_Add_Click(object sender, EventArgs e) {
			//TODO: Call the method to add the transactionCustomer to the waitlist database.

			//METHOD(selectedEvent.Id)
		}

		private void button_Close_Click(object sender, EventArgs e) {
			this.Close();
		}


		private void UpdateWaitListGrid(Event selectedEvent) {
			//TODO: Call method to get the customers on the waitlist for an event by id
			//Customer customers = METHOD(selectedEvent.Id)

			//CLEAR THE CUSTOMER GRID
			dataGridView_Customers.Rows.Clear();

			//ADD ALL THE CUSTOMERS
			//foreach (Customer customer in customers) {
			//	dataGridView_Customers.Rows.Add(customer.CustomerID, customer.FirstName + " " + customer.LastName, customer.date);
			//}
			//}
		}
	}
}
