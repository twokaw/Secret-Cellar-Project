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
	public partial class FrmEventsAll : Form {
		public FrmEventsAll() {
			InitializeComponent();

            //GET ALL THE EVENTS
            List<Event> listOfEvents = DataAccess.instance.GetEvent();

            //CLEAR THE EVENT GRID
            dataGridView_Events.Rows.Clear();

            //ADD ALL THE EVENTS
            foreach (Event currentEvent in listOfEvents) {
                Console.WriteLine("I'm matched");
                dataGridView_Events.Rows.Add(currentEvent.EventDate, currentEvent.Name, currentEvent.Price, currentEvent.Qty);
            }
        }

		private void button_CloseWindow_Click(object sender, EventArgs e) {
            this.Close();
		}
	}
}
