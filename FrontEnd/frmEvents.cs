using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;



namespace SecretCellar
{
    public partial class frmEvents : ManagedForm
    {
        /// <summary>
        /// Deletes the given event.
        /// </summary>
        /// <param name="selectedEvent"></param>
        public static void DeleteEvent(Event selectedEvent) {
            List<EventWaitlistItem> eventWaitlistItems = DataAccess.instance.GetEventsWaitlists().FindAll((item) => { return item.EventId == selectedEvent.Id; });
            if (eventWaitlistItems.Count > 0) { MessageBox.Show($"Cannot delete '{selectedEvent.Name}' while customers are on the waitlist for it.", "Error"); return; }

            bool doesHaveSoldData = false;
            double numOfticketsSold = 0;

            PreviousEventData previousEventData = DataAccess.instance.GetPreviousEventData(selectedEvent.Id);
            if (previousEventData != null) {
                numOfticketsSold = previousEventData.AtDoorSold + previousEventData.PreOrderSold;

                if (numOfticketsSold > 0) {
                    doesHaveSoldData = true;
                }
            }

            bool didAcceptSoldDataPopUp = false;

            if (doesHaveSoldData) {
                DialogResult dialogResult = MessageBox.Show($"Are you sure you want to hide the '{selectedEvent.Name}' event? There {(numOfticketsSold > 1 ? "are" : "is")} {numOfticketsSold} ticket{(numOfticketsSold > 1? "s" : "")} sold.", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) didAcceptSoldDataPopUp = true;
            }
            else didAcceptSoldDataPopUp = true;

            if (didAcceptSoldDataPopUp && frmManagerOverride.DidOverride("Delete Event")) {
                if (doesHaveSoldData) {
                    Inventory eventInventory = DataAccess.instance.GetInventory().First(x => x.Id == selectedEvent.Id);
                    if (eventInventory == null) return;

                    eventInventory.Hidden = true;
                    DataAccess.instance.UpdateItem(eventInventory);
                }
                else {
                    DataAccess.instance.DeleteEvent(selectedEvent.Id);
                }
            }
        }



        private Transaction _transaction;
        private Event _selectedEvent;
        

        public frmEvents(Transaction transactionFromFrmTransaction)
        {
            InitializeComponent();
            _transaction = transactionFromFrmTransaction;

            //SET THE ID, BARCODE, AND DURATION COLUMN TO HIDDEN
            dataGridView_Events.Columns["Id"].Visible = false;
            dataGridView_Events.Columns["Barcode"].Visible = false;
            dataGridView_Events.Columns["Duration"].Visible = false;

            //UPDATE THE SELECTED EVENT FIELD IF THE DATA GRID HAS ROWS
            if (dataGridView_Events.SelectedRows.Count > 0) {
                _selectedEvent = GetSelectedEvent();
            }
        }


        /// <summary>
        /// When the form loads, update the grid so the preorder/at door color is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEvents_Shown(object sender, EventArgs e) { UpdateEventGrid(); }

        private void dataGridView_Events_SelectionChanged(object sender, EventArgs e) {
            //UPDATE THE SELECTED EVENT FIELD
            if (dataGridView_Events.SelectedRows.Count > 0) {
                _selectedEvent = GetSelectedEvent();

                PreviousEventData previousEventData = DataAccess.instance.GetPreviousEventData(_selectedEvent.Id);
                if (previousEventData != null) {
                    if (previousEventData.AtDoorSold + previousEventData.PreOrderSold > 0) {
                        button_DeleteEvent.Text = "Hide";
                    }
                    else {
                        button_DeleteEvent.Text = "Delete";
                    }
                }
            }
            
            UpdateTotal();
        }

        private void textBox_Quantity_TextChanged(object sender, EventArgs e) {
            UpdateTotal();
        }

        private void frmEvents_Load(object sender, EventArgs e) {

        }

        private void dateTimePicker_Date_ValueChanged(object sender, EventArgs e) {
            UpdateEventGrid();
        }

        private void button_AllEvents_Click(object sender, EventArgs e) {
            frmEventsAll allEvents = new frmEventsAll();
            allEvents.ShowDialog();

            //IF THE SELECTED DATE FIELD IN THE ALL EVENTS FORM IS NOT THE DEFAULT
            //THAT MEANS THE USER DOUBLE CLICKED ON IT TO GO TO IT SO SET THE
            //DATE TIME PICKER ON THIS FORM TO THAT DATE
            if (allEvents.selectedDate != new DateTime(0001, 1, 1)) {
                dateTimePicker_Date.Value = allEvents.selectedDate;
                UpdateEventGrid();

                //SELECT THE SPECIFIC EVENT THAT THE USER CLICKED ON
                foreach (DataGridViewRow row in dataGridView_Events.Rows) {
                    if (row.Cells["Date"].Value.ToString() == dateTimePicker_Date.Value.ToString()) {
                        dataGridView_Events.CurrentCell = row.Cells["Date"];
					}
				}
			}

            //OTHERWISE JUST REFRESH THE DATA GRID VIEW WITH THE CURRENT DATE
            else {
                if (dataGridView_Events.Rows.Count > 0) {
                    //RESET THE SELECTED ROW TO THE FIRST ROW
                    dataGridView_Events.CurrentCell = dataGridView_Events.Rows[0].Cells["Date"];
                }

                UpdateEventGrid();
            }
        }

        private void button_CreateEvent_Click(object sender, EventArgs e) {
            frmEventsCreate createEvent = new frmEventsCreate();
            createEvent.ShowDialog();

            UpdateEventGrid();
        }

        private void button_AddCharge_Click(object sender, EventArgs e) {
            if (dataGridView_Events.SelectedRows.Count == 0) { return; }
            
            //GET THE FIRST SELECTED ROW
            DataGridViewCellCollection selectedRow = dataGridView_Events.SelectedRows[0].Cells;

            //TRY TO PARSE THE TEXT IN THE QUANTITY FIELD AS A UINT
            if (!uint.TryParse(textBox_Quantity.Text, out uint quantity)) { MessageBox.Show("Quantity is not a valid number.", "Error"); return; }

            //IF THE QUANTITY TO ADD IS MORE THAN WHAT IS AVAILABLE, SHOW AN ERROR
            if (!uint.TryParse(selectedRow["Qty"].Value.ToString(), out uint selectedEventQuantity)) { MessageBox.Show("Event Quantity is invalid", "Error"); return; }

            if (quantity > selectedEventQuantity) {
                MessageBox.Show($"Quantity to add is more than what is available.", "Error");
                return;
            }

            //GET THE SELECTED ROW'S BARCODE AND CONVERT IT TO AN ITEM
            Item item = Transaction.ConvertInvtoItem(DataAccess.instance.GetItem(selectedRow["Barcode"].Value.ToString()), quantity);
            item.TypeID = DataAccess.instance.GetInventoryType("EVENT").TypeId;

            //UPDATE THE PRICE OF THE ITEM WITH THE SELECTED ROW'S PRICE
            if (dataGridView_Events.SelectedRows[0].Cells["PreorderPrice"].Style.ForeColor == Color.Red) {
                item.Price = double.Parse(selectedRow["PreorderPrice"].Value.ToString().Substring(1));
            }
            else {
                item.Price = double.Parse(selectedRow["AtDoorPrice"].Value.ToString().Substring(1));
            }

            //ADD THE ITEM TO THE TRANSACTION
            _transaction.Items.Add(item);

            this.Close();
        }

        private void button_DeleteEvent_Click(object sender, EventArgs e) {
            if (dataGridView_Events.SelectedRows.Count == 0) { return; }

            DeleteEvent(_selectedEvent);
            UpdateEventGrid();
        }

        private void button_EditEvent_Click(object sender, EventArgs e) {
            if (dataGridView_Events.SelectedRows.Count > 0) {
                frmEventsEdit eventsEdit = new frmEventsEdit(_selectedEvent);
                eventsEdit.ShowDialog();

                UpdateEventGrid();
			}
        }

        private void button_WaitList_Click(object sender, EventArgs e) {
            frmEventsWaitlist eventsWaitList = new frmEventsWaitlist(_selectedEvent);
            eventsWaitList.ShowDialog();
        }

        private void button_CloseWindow_Click(object sender, EventArgs e) {
            this.Close();
		}

        private void UpdateEventGrid() {
            List<Event> events = DataAccess.instance.GetEvent();
            List<Inventory> inventories = DataAccess.instance.GetInventory();

            events = events.FindAll((e) => {
                Inventory eventInventory = inventories.Find((i) => { return i.Id == e.Id; });
                if (eventInventory == null) return false;

                return !eventInventory.Hidden;
            });

            dataGridView_Events.DataSource = events
            .Select(x => new {
                eventId = x.Id,
                eventBarcode = x.Barcode,
                eventDate = x.EventDate,
                eventDuration = x.Duration,
                eventName = x.Name,
                preorderPrice = x.PreOrder.ToString("C"),
                atDoorPrice = x.AtDoor.ToString("C"),
                quantity = x.Qty    //quantity = x.Qty - (DataAccess.instance.GetPreviousEventData(x.Id).PreOrderSold + DataAccess.instance.GetPreviousEventData(x.Id).AtDoorSold)
            })
            .Where(x => x.eventDate.Year <= dateTimePicker_Date.Value.Year
                    && dateTimePicker_Date.Value.Year <= x.eventDuration.Year
                    && x.eventDate.Month <= dateTimePicker_Date.Value.Month && dateTimePicker_Date.Value.Month <= x.eventDuration.Month
                    && x.eventDate.Day <= dateTimePicker_Date.Value.Day && dateTimePicker_Date.Value.Day <= x.eventDuration.Day)
            .ToList();

            for (int i=0; i<dataGridView_Events.Rows.Count; i++) {
                Event currentEvent = DataAccess.instance.GetEvent(uint.Parse(dataGridView_Events.Rows[i].Cells["Id"].Value.ToString()));

                if (IsTodayBeforeEvent(currentEvent)) {
                    dataGridView_Events.Rows[i].Cells["PreorderPrice"].Style.ForeColor = Color.Red;
                    dataGridView_Events.Rows[i].Cells["PreorderPrice"].Style.SelectionForeColor = Color.Red;
                }
                else {
                    dataGridView_Events.Rows[i].Cells["AtDoorPrice"].Style.ForeColor = Color.Red;
                    dataGridView_Events.Rows[i].Cells["AtDoorPrice"].Style.SelectionForeColor = Color.Red;
                }
			}

            /*
            //GET ALL THE EVENTS
            List<Event> listOfEvents = DataAccess.instance.GetEvent();

            //CLEAR THE EVENT GRID
            dataGridView_Events.Rows.Clear();

            //ADD ALL THE EVENTS
            foreach (Event currentEvent in listOfEvents) {
                if (ShouldShowEvent(dateTimePicker_Date, currentEvent)) {
                    //IF THE DATE IS BEFORE TODAY, SHOW THE PREORDER AMOUNT
                    if (IsTodayBeforeEvent(currentEvent)) {
                        dataGridView_Events.Rows.Add(currentEvent.Id, currentEvent.Barcode, currentEvent.EventDate, currentEvent.Duration, currentEvent.Name, currentEvent.PreOrder, currentEvent.Qty);
                    }

                    //ELSE SHOW THE AT DOOR AMOUNT
                    else {
                        dataGridView_Events.Rows.Add(currentEvent.Id, currentEvent.Barcode, currentEvent.EventDate, currentEvent.Duration, currentEvent.Name, currentEvent.AtDoor, currentEvent.Qty);
					}
                }
            }
            */
            
            //CLEAR OUT THE SELECTED EVENT IF THERE ARE NO ROWS
            if (dataGridView_Events.Rows.Count == 0) {
                _selectedEvent = null;
                button_DeleteEvent.Text = "Delete";
            }
        }

        private void UpdateTotal() {
            if (uint.TryParse(textBox_Quantity.Text, out uint quantity) && dataGridView_Events.SelectedRows.Count > 0) {
                double price;

                if (dataGridView_Events.SelectedRows[0].Cells["PreorderPrice"].Style.ForeColor == Color.Red) {
                    price = double.Parse(dataGridView_Events.SelectedRows[0].Cells["PreorderPrice"].Value.ToString().Substring(1));
                }
                else {
                    price = double.Parse(dataGridView_Events.SelectedRows[0].Cells["AtDoorPrice"].Value.ToString().Substring(1));
                }

                if (quantity != 0) { textBox_Total.Text = "$" + quantity * price; }
            }
            else {
                textBox_Total.Text = "$0";
            }
        }

        private Event GetSelectedEvent() {
            if (dataGridView_Events.SelectedRows.Count == 0) { return null; }

            //GET ALL THE EVENTS
            List<Event> listOfEvents = DataAccess.instance.GetEvent();

            //LOOP THROUGH ALL OF THE EVENTS
            foreach (Event currentEvent in listOfEvents) {
                //IF THE ID OF THE SELECTED EVENT MATCHES AN EVENT, RETURN IT
                if (uint.Parse(dataGridView_Events.SelectedRows[0].Cells["Id"].Value.ToString()) == currentEvent.Id) {
                    return currentEvent;
                }
            }

            return null;
        }

        private bool ShouldShowEvent(DateTimePicker selectedDate, Event currentEvent) {
            DateTime startDate = currentEvent.EventDate;
            DateTime endDate = currentEvent.Duration;

            if (startDate.Year <= selectedDate.Value.Year && selectedDate.Value.Year <= endDate.Year
            && startDate.Month <= selectedDate.Value.Month && selectedDate.Value.Month <= endDate.Month
            && startDate.Day <= selectedDate.Value.Day && selectedDate.Value.Day <= endDate.Day) {
                return true;
            }
            else {
                return false;
			}
		}

        private bool IsTodayBeforeEvent(Event currentEvent) {
            if (currentEvent.EventDate.Year > DateTime.Now.Year) {
                return true;
            }
            else if (currentEvent.EventDate.Year == DateTime.Now.Year && currentEvent.EventDate.Month > DateTime.Now.Month) {
                return true;
            }
            else if (currentEvent.EventDate.Year == DateTime.Now.Year && currentEvent.EventDate.Month == DateTime.Now.Month && currentEvent.EventDate.Day > DateTime.Now.Day) {
                return true;
            }
            else if (currentEvent.EventDate.Year == DateTime.Now.Year && currentEvent.EventDate.Month == DateTime.Now.Month && currentEvent.EventDate.Day == DateTime.Now.Day
            && currentEvent.EventDate.Hour > DateTime.Now.Hour) {
                return true;
            }
            else if (currentEvent.EventDate.Year == DateTime.Now.Year && currentEvent.EventDate.Month == DateTime.Now.Month && currentEvent.EventDate.Day == DateTime.Now.Day
            && currentEvent.EventDate.Hour == DateTime.Now.Hour && currentEvent.EventDate.Minute > DateTime.Now.Minute) {
                return true;
            }
            else {
                return false;
			}
		}
	}
}
