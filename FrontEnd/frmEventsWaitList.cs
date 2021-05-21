using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Shared;


namespace SecretCellar {
	public partial class frmEventsWaitlist : Form {
		private Event _selectedEvent;


		public frmEventsWaitlist(Event selectedEvent) {
			InitializeComponent();
			
			//SET THE ID COLUMNS TO HIDDEN SO THAT THEY ARE STILL ACCESSIBLE
			dataGridView_Customers.Columns[EventId.Index].Visible = false;
			dataGridView_Customers.Columns[CustomerId.Index].Visible = false;

			//UPDATE THE PRIVATE FIELDS WITH THE INCOMING PARAMETERS
			_selectedEvent = selectedEvent;

			//UPDATE THE DATA GRID VIEW WITH THE CUSTOMERS CURRENTLY ON THE WAITLIST FOR THE SELECTED EVENT
			UpdateWaitListGrid();
		}


		//REMOVE THE SELECTED CUSTOMER TO THE WAITLIST
		private void button_Remove_Click(object sender, EventArgs e) {
			if (_selectedEvent != null && dataGridView_Customers.SelectedRows.Count > 0) {
				uint selectedCustomerId = uint.Parse(dataGridView_Customers.SelectedRows[0].Cells[CustomerId.Index].Value.ToString());

				DataAccess.instance.DeleteEventWaitlistItem(_selectedEvent.Id, selectedCustomerId);
				UpdateWaitListGrid();
			}
		}


		//ADD THE SELECTED CUSTOMER TO THE WAITLIST
		private void button_Add_Click(object sender, EventArgs e) {
			if (_selectedEvent != null) {
				List<EventWaitlistItem> waitListItems = DataAccess.instance.GetEventsWaitlists();
				bool isInWaitlist = false;

				//CREATE A NEW CUSTOMER LIST FORM
				frmEventsWaitlistCustomerList customerList = new frmEventsWaitlistCustomerList();
				customerList.ShowDialog();

				if (customerList.selectedCustomer != null) {
					//CHECK IF THE CUSTOMER IS IN THE WAITLIST ALREADY
					foreach (EventWaitlistItem waitlistItem in waitListItems) {
						if (_selectedEvent.Id == waitlistItem.EventId && customerList.selectedCustomer.CustomerID == waitlistItem.CustomerId) {
							isInWaitlist = true;
						}
					}

					if (!isInWaitlist) {
						DataAccess.instance.AddEventWaitlistItem(new EventWaitlistItem(_selectedEvent.Id,
																					   customerList.selectedCustomer.CustomerID,
																					   customerList.selectedCustomer.FirstName + " " + customerList.selectedCustomer.LastName,
																					   DateTime.Now
																					   ));
						UpdateWaitListGrid();
					}
					else {
						MessageBox.Show("Customer is already in this waitlist", "Error");
					}
				}
			}
			else {
				MessageBox.Show("Cannot add customer. There was no event selected.", "Error");
			}
		}


		//CLOSE THE FORM
		private void button_Close_Click(object sender, EventArgs e) {
			this.Close();
		}


		//UPDATE THE GRID
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

				dataGridView_Customers.Sort(dataGridView_Customers.Columns[Date.Index], System.ComponentModel.ListSortDirection.Ascending);
			}
		}
	}
}
