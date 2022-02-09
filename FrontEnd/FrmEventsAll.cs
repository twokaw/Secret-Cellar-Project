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
            button_showPreviousEventData.Visible = false;

            UpdateEventGrid();
        }


        /// <summary>
        /// Update the selected date field with the date that the user double clicked on.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_Events_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            selectedDate = DateTime.Parse(dataGridView_Events.SelectedRows[0].Cells["Date"].Value.ToString());
            this.Close();
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

            if (isArchivedEvents) {
                button_PreviousEvents.Text = "SHOW UPCOMING EVENTS";
                label_Events.Text = "Previous Events";
                button_showPreviousEventData.Visible = true;
            }
            else {
                button_PreviousEvents.Text = "SHOW PREVIOUS EVENTS";
                label_Events.Text = "Upcoming Events";
                button_showPreviousEventData.Visible = false;
            }

            UpdateEventGrid();
        }


        /// <summary>
        /// Deletes the selected event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_DeleteEvent_Click(object sender, EventArgs e) {
            if (dataGridView_Events.SelectedRows.Count == 0) { return; }
            
            List<Event> listOfEvents = DataAccess.instance.GetEvent();
            List<EventWaitlistItem> eventWaitlistItems = DataAccess.instance.GetEventsWaitlists();

            foreach (DataGridViewRow selectedRow in dataGridView_Events.SelectedRows) {
                Event selectedEvent = listOfEvents.Find((ev) => { return uint.Parse(selectedRow.Cells["Id"].Value.ToString()) == ev.Id; });
                if (selectedEvent == null) { continue; }  //SANITY CHECK

                List<EventWaitlistItem> filteredList = eventWaitlistItems.FindAll((item) => { return item.EventId == selectedEvent.Id; });

                if (filteredList.Count > 0) { MessageBox.Show($"Cannot delete '{selectedEvent.Name}' while customers are on the waitlist for it.", "Error"); continue; }

                DataAccess.instance.DeleteEvent(selectedEvent.Id);
            }

            UpdateEventGrid();
        }


        /// <summary>
        /// Shows the selected previous event's data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_showPreviousEventData_Click(object sender, EventArgs e) {
            if (dataGridView_Events.SelectedRows.Count == 0) { return; }

            string id = dataGridView_Events.SelectedRows[0].Cells["Id"].Value.ToString();

            frmEventsPreviousEvent previousEventform = new frmEventsPreviousEvent(id);
            previousEventform.ShowDialog();
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
                    || x.eventDate.Year == DateTime.Now.Year && x.eventDate.Month == DateTime.Now.Month && x.eventDate.Day == DateTime.Now.Day && x.eventDate.Hour == DateTime.Now.Hour && x.eventDate.Minute >= DateTime.Now.Minute)
                .OrderBy(x => x.eventDate)
                .ToList();
            }
        }
	}
}
