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
		}


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
