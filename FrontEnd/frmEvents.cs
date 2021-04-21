using Shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SecretCellar
{
    public partial class frmEvents : ManagedForm
    {
        private Transaction transaction;


        public frmEvents(Transaction transactionFromFrmTransaction)
        {
            InitializeComponent();
            transaction = transactionFromFrmTransaction;

            //SET THE ID COLUMN TO HIDDEN SO THAT THE ID IS STILL
            //ACCESSIBLE WHEN DELETING EVENTS
            dataGridView_Events.Columns["Id"].Visible = false;

            UpdateEventGrid();
        }

        private void event_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void frmEvents_Load(object sender, EventArgs e) {

        }

        private void dateTimePicker_Date_ValueChanged(object sender, EventArgs e) {
            UpdateEventGrid();
        }

        private void button_AllEvents_Click(object sender, EventArgs e) {
            FrmEventsAll allEvents = new FrmEventsAll();
            allEvents.ShowDialog();

            UpdateEventGrid();
        }

        private void button_AddCharge_Click(object sender, EventArgs e) {
            if (double.TryParse(txtCharge.Text, out double price)) {
                Item item = Transaction.ConvertInvtoItem(DataAccess.instance.GetItem("EVENT"));
                item.Price = price;
                transaction.Items.Add(item);
            }

            this.Close();
		}

        private void button_CreateEvent_Click(object sender, EventArgs e) {
            FrmEventsCreate createEvent = new FrmEventsCreate();
            createEvent.ShowDialog();

            UpdateEventGrid();
        }

        private void button_CloseWindow_Click(object sender, EventArgs e) {
            this.Close();
		}

        private void UpdateEventGrid() {
            //GET ALL THE EVENTS
            List<Event> listOfEvents = DataAccess.instance.GetEvent();

            //CLEAR THE EVENT GRID
            dataGridView_Events.Rows.Clear();

            //ADD ALL THE EVENTS
            foreach (Event currentEvent in listOfEvents) {
                string selectedDate = $"{dateTimePicker_Date.Value.Month}/{dateTimePicker_Date.Value.Day}/{dateTimePicker_Date.Value.Year}";
                string currentDate = $"{currentEvent.EventDate.Month}/{currentEvent.EventDate.Day}/{currentEvent.EventDate.Year}";

                if (currentDate == selectedDate) {
                    dataGridView_Events.Rows.Add(currentEvent.Id, currentEvent.EventDate, currentEvent.Name, currentEvent.Price, currentEvent.Qty);
                }
            }
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
	}
}
