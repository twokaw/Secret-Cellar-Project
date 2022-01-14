using Shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;



namespace SecretCellar {
	public partial class frmEventsPreviousEvent : Form {
		List<Event> events = new List<Event>();



		public frmEventsPreviousEvent(string id) {
			InitializeComponent();

			uint eventId = uint.Parse(id);
			Event previousEvent = GetEvent(eventId);

			if (previousEvent == null) { return; }

			label_previousEventName.Text = previousEvent.Name;

			PreviousEventData previousEventData = DataAccess.instance.GetPreviousEventData(eventId);

			label_totalProfit.Text = previousEventData.AtDoorProfit + previousEventData.PreOrderProfit + "";
			label_totalSold.Text = previousEventData.AtDoorSold + previousEventData.PreOrderSold + "";
			label_atDoorProfit.Text = previousEventData.AtDoorProfit + "";
			label_atDoorSold.Text = previousEventData.AtDoorSold + "";
			label_preorderProfit.Text = previousEventData.PreOrderProfit + "";
			label_preorderSold.Text = previousEventData.PreOrderSold + "";
		}


		/// <summary>
		/// On close click.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button_close_Click(object sender, EventArgs e) { this.Close(); }


		/// <summary>
		/// Returns the event whose id matches the given id.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		private Event GetEvent(uint id) {
			events = DataAccess.instance.GetEvent();

			foreach (Event ev in events) {
				if (ev.Id == id) {
					return ev;
				}
			}

			return null;
		}
	}
}
