using System;
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
			Event newEvent;
			uint quantity = 9999;
			double supplierPrice = 0.0;

			//CHECK IF QUANTITY IS FILLED
			if (textBox_Quantity.Text.Replace(" ", "") != "" && IsOnlyNumbers(textBox_Quantity.Text)) {
				quantity = uint.Parse(textBox_Quantity.Text);
			}

			//CHECK IF SUPPLIER PRICE IS FILLED
			if (textBox_SupplierPrice.Text.Replace(" ", "") != "" && IsOnlyNumbers(textBox_SupplierPrice.Text)) {
				supplierPrice = double.Parse(textBox_Quantity.Text);
			}

			//CREATE THE EVENT
			newEvent = new Event(quantity, supplierPrice);

			newEvent.Name = textBox_Name.Text;
			newEvent.EventDate = dateTimePicker_Date.Value;
			newEvent.Duration = dateTimePicker_Duration.Value;
			newEvent.Barcode = textBox_Barcode.Text;
			newEvent.Price = double.Parse(textBox_Price.Text);
			newEvent.PreOrder = double.Parse(textBox_Preorder.Text);
			newEvent.AtDoor = double.Parse(textBox_AtDoor.Text);
			newEvent.TypeID = uint.Parse(textBox_TypeId.Text);
			newEvent.NonTaxable = checkBox_NonTaxable.Checked;
			newEvent.NonTaxableLocal = checkBox_NonTaxableLocal.Checked;

			//CREATE THE EVENT IN THE DATABASE
			DataAccess.instance.CreateEvent(newEvent);

			//CLOSE THE WINDOW
			this.Close();
		}


		private bool IsOnlyNumbers(string word) {
			foreach (char c in word) {
				if (c < '0' || c > '9') {
					return false;
				}
			}

			return true;
		}
	}
}
