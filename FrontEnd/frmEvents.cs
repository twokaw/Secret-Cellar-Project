using SecretCellar;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            allEvents.Show();
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
            createEvent.Show();

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
                    Console.WriteLine("I'm matched");
                    dataGridView_Events.Rows.Add(currentEvent.EventDate, currentEvent.Name, currentEvent.Price, currentEvent.Qty);
                }
            }
        }

		
	}
}
