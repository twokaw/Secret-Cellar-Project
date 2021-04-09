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
	public partial class FrmEventsCreate : Form {
		public FrmEventsCreate() {
			InitializeComponent();
		}

		private void button_CloseWindow_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void button_CreateEvent_Click(object sender, EventArgs e) {
			
			//newEvent.Qty = uint.Parse(textBox_Quantity.Text); --READ ONLY CAN'T SET

			//CREATE A NEW EVENT
			Event newEvent = new Event() {
				Name = textBox_Name.Text,
				EventDate = dateTimePicker_Date.Value,
				Duration = dateTimePicker_Duration.Value,
				Barcode = textBox_Barcode.Text,
				Price = double.Parse(textBox_Price.Text),
				//SupplierPrice = uint.Parse(textBox_TypeId.Text), --READ ONLY
				PreOrder = double.Parse(textBox_Preorder.Text),
				AtDoor = double.Parse(textBox_AtDoor.Text),
				TypeID = uint.Parse(textBox_TypeId.Text),
				NonTaxable = checkBox_NonTaxable.Checked,
				NonTaxableLocal = checkBox_NonTaxableLocal.Checked
			};

			//CREATE THE EVENT IN THE DATABASE
			DataAccess.instance.CreateEvent(newEvent);
		}

	}
}
