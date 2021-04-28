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
	public partial class frmEventsAll : Form {
        public DateTime selectedDate = new DateTime(0001, 1, 1);


		public frmEventsAll() {
			InitializeComponent();

            //SET THE ID COLUMN TO HIDDEN SO THAT THE ID IS STILL
            //ACCESSIBLE WHEN DELETING EVENTS
            dataGridView_Events.Columns["Id"].Visible = false;

            UpdateEventGrid();
        }

        private void dataGridView_Events_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            //UPDATE THE SELECTED DATE FIELD WITH THE DATE THAT THE USER DOUBLE CLICKED ON
            selectedDate = DateTime.Parse(dataGridView_Events.SelectedRows[0].Cells[Date.Index].Value.ToString());

            this.Close();
        }

        private void button_CloseWindow_Click(object sender, EventArgs e) {
            this.Close();
		}

		private void button_DeleteEvent_Click(object sender, EventArgs e) {
            //GET ALL THE EVENTS
            List<Event> listOfEvents = DataAccess.instance.GetEvent();

            //LOOP THROUGH ALL OF THE SELECTED ROWS
            foreach (DataGridViewRow selectedRow in dataGridView_Events.SelectedRows) {

                //LOOP THROUGH ALL OF THE EVENTS
                foreach (Event currentEvent in listOfEvents) {
                    //IF THE ID OF THE SELECTED EVENT MATCHES AN EVENT, THEN DELETE THE EVENT
                    if (uint.Parse(selectedRow.Cells[Id.Index].Value.ToString()) == currentEvent.Id) {
                        DataAccess.instance.DeleteEvent(currentEvent.Id);

                        UpdateEventGrid();
                    }
                }
            }
        }

        private void UpdateEventGrid() {
            //GET ALL THE EVENTS
            List<Event> listOfEvents = DataAccess.instance.GetEvent();

            //CLEAR THE EVENT GRID
            dataGridView_Events.Rows.Clear();

            //ADD ALL THE EVENTS
            foreach (Event currentEvent in listOfEvents) {
                dataGridView_Events.Rows.Add(currentEvent.Id, currentEvent.EventDate, currentEvent.Name, currentEvent.Price, currentEvent.Qty);
            }
        }

	}
}
