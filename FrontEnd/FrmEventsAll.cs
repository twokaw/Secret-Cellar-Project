using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Shared;
using System.Linq;



namespace SecretCellar {
	public partial class frmEventsAll : Form {
        public DateTime selectedDate = new DateTime(0001, 1, 1);


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
            selectedDate = DateTime.Parse(dataGridView_Events.SelectedRows[0].Cells["Date"].Value.ToString());
            this.Close();
        }


        private void button_CloseWindow_Click(object sender, EventArgs e) {
            this.Close();
		}


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
            dataGridView_Events.DataSource = DataAccess.instance.GetEvent()
            .Select(x => new {
                eventId = x.Id,
                eventDate = x.EventDate,
                eventName = x.Name,
                preorderPrice = x.PreOrder.ToString("C"),
                atDoorPrice = x.AtDoor.ToString("C"),
                eventQuantity = x.Qty
            })
            .OrderBy(x => x.eventDate)
            .ToList();
        }

	}
}
