using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Shared;
using System.Linq;



namespace SecretCellar {
	public partial class frmEventsAll : Form {
        public DateTime selectedDate = new DateTime(0001, 1, 1);
        private bool isArchivedEvents = false;


		public frmEventsAll() {
			InitializeComponent();

            //SET THE ID COLUMN TO HIDDEN SO THAT THE ID IS STILL ACCESSIBLE WHEN DELETING EVENTS
            dataGridView_Events.Columns["Id"].Visible = false;

            UpdateEventGrid();
        }


        /// <summary>
        /// Update the selected date field with the date that the user double clicked on.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_Events_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (isArchivedEvents) {
                //TODO Create a form to display the data for the selected archived event.

			}
            else {
                selectedDate = DateTime.Parse(dataGridView_Events.SelectedRows[0].Cells["Date"].Value.ToString());
                this.Close();
            }
        }


        /// <summary>
        /// Close the window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CloseWindow_Click(object sender, EventArgs e) { this.Close(); }


        /// <summary>
        /// Switches the view to the previous events.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_PreviousEvents_Click(object sender, EventArgs e) {
            isArchivedEvents = !isArchivedEvents;

            if (isArchivedEvents) { button_PreviousEvents.Text = "UPCOMING EVENTS"; label_Events.Text = "Previous Events"; }
            else { button_PreviousEvents.Text = "PREVIOUS EVENTS"; label_Events.Text = "Upcoming Events"; }

            UpdateEventGrid();
        }


        /// <summary>
        /// Deletes the selected event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_DeleteEvent_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow selectedRow in dataGridView_Events.SelectedRows) {
                List<Event> listOfEvents = DataAccess.instance.GetEvent();

                //LOOP THROUGH ALL OF THE EVENTS
                foreach (Event currentEvent in listOfEvents) {
                    //IF THE ID OF THE SELECTED EVENT MATCHES AN EVENT, THEN DELETE THE EVENT
                    if (uint.Parse(selectedRow.Cells["Id"].Value.ToString()) == currentEvent.Id) {
                        DataAccess.instance.DeleteEvent(currentEvent.Id);
                        break;
                    }
                }
            }

            UpdateEventGrid();
        }


        /// <summary>
        /// Refresh the grid
        /// </summary>
        private void UpdateEventGrid() {
            if (isArchivedEvents) {
                dataGridView_Events.DataSource = DataAccess.instance.GetEvent()
                .Select(x => new {
                    eventId = x.Id,
                    eventDate = x.EventDate,
                    eventName = x.Name,
                    preorderPrice = x.PreOrder.ToString("C"),
                    atDoorPrice = x.AtDoor.ToString("C"),
                    eventQuantity = x.Qty
                })
                .Where(x => x.eventDate.Year < DateTime.Now.Year
                    || x.eventDate.Year == DateTime.Now.Year && x.eventDate.Month < DateTime.Now.Month
                    || x.eventDate.Year == DateTime.Now.Year && x.eventDate.Month == DateTime.Now.Month && x.eventDate.Day < DateTime.Now.Day
                    || x.eventDate.Year == DateTime.Now.Year && x.eventDate.Month == DateTime.Now.Month && x.eventDate.Day == DateTime.Now.Day && x.eventDate.Hour < DateTime.Now.Hour
                    || x.eventDate.Year == DateTime.Now.Year && x.eventDate.Month == DateTime.Now.Month && x.eventDate.Day == DateTime.Now.Day && x.eventDate.Hour == DateTime.Now.Hour && x.eventDate.Minute < DateTime.Now.Minute)
                .OrderBy(x => x.eventDate)
                .ToList();
            }
            else {
                dataGridView_Events.DataSource = DataAccess.instance.GetEvent()
                .Select(x => new {
                    eventId = x.Id,
                    eventDate = x.EventDate,
                    eventName = x.Name,
                    preorderPrice = x.PreOrder.ToString("C"),
                    atDoorPrice = x.AtDoor.ToString("C"),
                    eventQuantity = x.Qty
                })
                .Where(x => x.eventDate.Year > DateTime.Now.Year
                    || x.eventDate.Year == DateTime.Now.Year && x.eventDate.Month > DateTime.Now.Month
                    || x.eventDate.Year == DateTime.Now.Year && x.eventDate.Month == DateTime.Now.Month && x.eventDate.Day > DateTime.Now.Day
                    || x.eventDate.Year == DateTime.Now.Year && x.eventDate.Month == DateTime.Now.Month && x.eventDate.Day == DateTime.Now.Day && x.eventDate.Hour > DateTime.Now.Hour
                    || x.eventDate.Year == DateTime.Now.Year && x.eventDate.Month == DateTime.Now.Month && x.eventDate.Day == DateTime.Now.Day && x.eventDate.Hour == DateTime.Now.Hour && x.eventDate.Minute > DateTime.Now.Minute)
                .OrderBy(x => x.eventDate)
                .ToList();
            }
        }

		
	}
}
