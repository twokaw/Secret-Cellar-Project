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
            dataGridView_Events.Columns["Barcode"].Visible = false;

            UpdateEventGrid();
        }

        private void dataGridView_Events_SelectionChanged(object sender, EventArgs e) {
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
                    if (row.Cells[Date.Index].Value.ToString() == dateTimePicker_Date.Value.ToString()) {
                        dataGridView_Events.CurrentCell = row.Cells[Date.Index];
					}
				}
			}

            //OTHERWISE JUST REFRESH THE DATA GRID VIEW WITH THE CURRENT DATE
            else {
                if (dataGridView_Events.Rows.Count > 0) {
                    //RESET THE SELECTED ROW TO THE FIRST ROW
                    dataGridView_Events.CurrentCell = dataGridView_Events.Rows[0].Cells[Date.Index];
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
            //GET THE FIRST SELECTED ROW
            DataGridViewCellCollection selectedRow = dataGridView_Events.SelectedRows[0].Cells;

            //TRY TO PARSE THE TEXT IN THE QUANTITY FIELD AS A UINT
            if (uint.TryParse(textBox_Quantity.Text, out uint quantity)) {

                //IF THE QUANTITY TO ADD IS MORE THAN WHAT IS AVAILABLE, SHOW AN ERROR
                if (quantity > uint.Parse(selectedRow[Qty.Index].Value.ToString())) {
                    MessageBox.Show("Quantity to add is more than what is available.", "Error");
                    return;
                }

                //GET THE SELECTED ROW'S BARCODE AND CONVERT IT TO AN ITEM
                Item item = Transaction.ConvertInvtoItem(DataAccess.instance.GetItem(selectedRow[Barcode.Index].Value.ToString()), quantity);

                //UPDATE THE PRICE OF THE ITEM WITH THE SELECTED ROW'S PRICE
                item.Price = double.Parse(selectedRow[Price.Index].Value.ToString());

                //ADD THE ITEM TO THE TRANSACTION
                transaction.Items.Add(item);

                this.Close();
            }
            else {
                MessageBox.Show("Quantity is not a valid number.", "Error");
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
                    dataGridView_Events.Rows.Add(currentEvent.Id, currentEvent.Barcode, currentEvent.EventDate, currentEvent.Name, currentEvent.Price, currentEvent.Qty);
                }
            }
        }

        private void UpdateTotal() {
            if (uint.TryParse(textBox_Quantity.Text, out uint quantity)) {
                double price = double.Parse(dataGridView_Events.SelectedRows[0].Cells[Price.Index].Value.ToString());

                textBox_Total.Text = "$" + quantity * price;
            }
            else {
                textBox_Total.Text = "$0";
            }
        }

		private void dataGridView_Events_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            //GET THE ID OF THE EVENT THAT WAS UPDATED
            uint id = uint.Parse(dataGridView_Events.Rows[e.RowIndex].Cells[Id.Index].Value.ToString());

            //CREATE A VARIABLE FOR THE EVENT THAT IS BEING UPDATED
            Event updatedEvent = DataAccess.instance.GetEvent(id);

            switch (e.ColumnIndex) {
				case 2:
                    if (DateTime.TryParse(dataGridView_Events.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out DateTime dateResult)) {
                        updatedEvent.EventDate = dateResult;
					}
                    else {
                        MessageBox.Show("Unable to update date.", "Error");
                    }

                    break;
                case 3:
                    updatedEvent.Name = dataGridView_Events.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                    break;
                case 4:
                    if (double.TryParse(dataGridView_Events.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out double priceResult)) {
                        updatedEvent.Price = priceResult;
                    }
                    else {
                        MessageBox.Show("Unable to update price.", "Error");
                    }

                    break;
                case 5:
                    MessageBox.Show("Unable to update quantity.", "Error");
                    //if (uint.TryParse(dataGridView_Events.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out uint quantityResult)) {
                    //    updatedEvent.qty = quantityResult;
                    //}

                    break;
			}

            
            //UPDATE THE EVENT
            DataAccess.instance.UpdateEvent(updatedEvent);
		}
	}
}
