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
	public partial class frmEventsWaitlist : Form {
		private Transaction _transaction;
		private Customer _transactionCustomer;
		private Event _selectedEvent;


		public frmEventsWaitlist(Event selectedEvent, Transaction transactionFromForm) {
			InitializeComponent();
			
			//SET THE ID COLUMNS TO HIDDEN SO THAT THEY ARE STILL ACCESSIBLE
			dataGridView_Customers.Columns[EventId.Index].Visible = false;
			dataGridView_Customers.Columns[CustomerId.Index].Visible = false;

			//UPDATE THE PRIVATE FIELDS WITH THE INCOMING PARAMETERS
			_transaction = transactionFromForm;
			_transactionCustomer = DataAccess.instance.GetCustomer(_transaction.CustomerID);
			_selectedEvent = selectedEvent;

			//SET THE CUSTOMER NAME TEXT BOX
			textBox_Customer.Text = _transactionCustomer.FirstName + " " + _transactionCustomer.LastName;

			//UPDATE THE DATA GRID VIEW WITH THE CUSTOMERS CURRENTLY ON THE WAITLIST FOR THE SELECTED EVENT
			UpdateWaitListGrid();
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
			if (_selectedEvent != null && dataGridView_Customers.SelectedRows.Count > 0) {
				uint selectedCustomerId = uint.Parse(dataGridView_Customers.SelectedRows[0].Cells[CustomerId.Index].Value.ToString());

				DataAccess.instance.DeleteEventWaitlistItem(_selectedEvent.Id, selectedCustomerId);
				UpdateWaitListGrid();
			}
		}

		private void button_Add_Click(object sender, EventArgs e) {
			if (_selectedEvent != null) {
				List<EventWaitlistItem> waitListItems = DataAccess.instance.GetEventsWaitlists();
				bool isInWaitlist = false;

				//CHECK IF THE CUSTOMER IS IN THE WAITLIST ALREADY
				foreach (EventWaitlistItem waitlistItem in waitListItems) {
					if (_selectedEvent.Id == waitlistItem.EventId && _transactionCustomer.CustomerID == waitlistItem.CustomerId) {
						isInWaitlist = true;
					}
				}

				if (isInWaitlist) {
					MessageBox.Show("Customer is already in this waitlist", "Error");
				}
				else {
					DataAccess.instance.AddEventWaitlistItem(new EventWaitlistItem(_selectedEvent.Id, _transactionCustomer.CustomerID, _transactionCustomer.FirstName + " " + _transactionCustomer.LastName, DateTime.Now));
					UpdateWaitListGrid();
				}
			}
		}

		private void button_Close_Click(object sender, EventArgs e) {
			this.Close();
		}


		private void UpdateWaitListGrid() {
			if (_selectedEvent != null) {
				List<EventWaitlistItem> waitListItems = DataAccess.instance.GetEventsWaitlists();
				
				//CLEAR THE CUSTOMER GRID
				dataGridView_Customers.Rows.Clear();

				//ADD ALL THE CUSTOMERS THAT MATCH THE SELECTED EVENT
				foreach (EventWaitlistItem waitlistItem in waitListItems) {
					if (_selectedEvent.Id == waitlistItem.EventId) {
						dataGridView_Customers.Rows.Add(waitlistItem.EventId, waitlistItem.CustomerId, waitlistItem.CustomerName, waitlistItem.DateAdded);
					}
				}
			}
		}
	}
}
