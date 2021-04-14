﻿using System;
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
	public partial class FrmEventsAll : Form {
		public FrmEventsAll() {
			InitializeComponent();

            UpdateEventGrid();
        }

		private void button_CloseWindow_Click(object sender, EventArgs e) {
            this.Close();
		}

		private void button_DeleteEvent_Click(object sender, EventArgs e) {
            //GET ALL THE EVENTS
            List<Event> listOfEvents = DataAccess.instance.GetEvent();
            DataGridViewSelectedRowCollection selectedRows = dataGridView_Events.SelectedRows;

            //LOOP THROUGH ALL OF THE SELECTED ROWS
            foreach (DataGridViewRow row in selectedRows) {

                //LOOP THROUGH ALL OF THE EVENTS
                foreach (Event currentEvent in listOfEvents) {

                    //IF THE ID OF THE SELECTED EVENT MATCHES AN EVENT, THEN DELETE THE EVENT
                    if (uint.Parse(row.Cells["Id"].Value.ToString()) == currentEvent.Id) {
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
                dataGridView_Events.Rows.Add(currentEvent.EventDate, currentEvent.Name, currentEvent.Price, currentEvent.Qty);
            }
        }
	}
}
