using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Shared;



namespace SecretCellar {
	public partial class frmEventsWaitlistCustomerList : Form {
		public Customer selectedCustomer;
		private List<Customer> customers;
		private string searchForCustomerText = "Search for customer";


		public frmEventsWaitlistCustomerList() {
			InitializeComponent();

			//GET THE LIST OF CUSTOMERS
			customers = DataAccess.instance.GetCustomer();

			//HIDE THE CUSTOMER ID COLUMN
			dataGridView_CustomerList.Columns[Customer_Id.Index].Visible = false;

			//POPULATE THE LIST WITH CUSTOMERS
			UpdateCustomerGrid();
		}


		//REFRESH THE DATA GRID AS THE USER TYPES IN THE FIELD
		private void textBox_CustomerName_TextChanged(object sender, EventArgs e) {
			UpdateCustomerGrid();
		}


		//REMOVE THE PLACEHOLDER TEXT WHEN CLICKING INTO THE TEXT BOX
		private void textBox_CustomerName_Enter(object sender, EventArgs e) {
			if (textBox_CustomerName.Text == searchForCustomerText) {
				textBox_CustomerName.Text = "";
			}
		}


		//RESET THE PLACEHOLDER TEXT IF THE TEXT BOX IS EMPTY
		private void textBox_CustomerName_Leave(object sender, EventArgs e) {
			if (string.IsNullOrEmpty(textBox_CustomerName.Text)) {
				textBox_CustomerName.Text = searchForCustomerText;
			}
		}


		//UPDATE THE SELECTED CUSTOMER VIA BUTTON
		private void button_SelectCustomer_Click(object sender, EventArgs e) {
			SelectCustomer();
		}


		//UPDATE THE SELECTED CUSTOMER VIA DOUBLE CLICK
		private void dataGridView_CustomerList_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			SelectCustomer();
		}


		//CLOSE THE WINDOW
		private void button_CloseWindow_Click(object sender, EventArgs e) {
			this.Close();
		}


		//REFRESH THE DATA GRID
		private void UpdateCustomerGrid() {
			dataGridView_CustomerList.Rows.Clear();

			foreach (Customer customer in customers) {
				if (textBox_CustomerName.Text == searchForCustomerText || (customer.FirstName + " " + customer.LastName).ToLower().Contains(textBox_CustomerName.Text.ToLower())) {
					dataGridView_CustomerList.Rows.Add(customer.CustomerID, customer.FirstName + " " + customer.LastName);
				}
			}
		}
		

		//SELECT THE CUSTOMER
		private void SelectCustomer() {
			foreach (Customer customer in customers) {
				if (uint.Parse(dataGridView_CustomerList.SelectedRows[0].Cells[Customer_Id.Index].Value.ToString()) == customer.CustomerID) {
					selectedCustomer = customer;
				}
			}

			this.Close();
		}

	}
}
