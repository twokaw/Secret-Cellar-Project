using System;
using System.Windows.Forms;
using Shared;



namespace SecretCellar {
	public partial class frmEventsCreate : Form {
		public frmEventsCreate() {
			InitializeComponent();

			dateTimePicker_EventDate.Format = DateTimePickerFormat.Custom;
			dateTimePicker_EventDate.CustomFormat = "MM/dd/yyyy hh:mm tt";

			dateTimePicker_Duration.Format = DateTimePickerFormat.Custom;
			dateTimePicker_Duration.CustomFormat = "MM/dd/yyyy hh:mm tt";
		}

		private void button_CloseWindow_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void button_CreateEvent_Click(object sender, EventArgs e) {
			if (HasNoErrors()) {
				if (frmManagerOverride.DidOverride("Create Event")) {
					uint quantity = 9999;
					double supplierPrice = 0.0;

					//CHECK IF QUANTITY IS FILLED
					if (uint.TryParse(textBox_Quantity.Text, out uint uintValue)) {
						quantity = uintValue;
					}

					//CHECK IF SUPPLIER PRICE IS FILLED
					if (double.TryParse(textBox_SupplierPrice.Text, out double doubleValue)) {
						supplierPrice = doubleValue;
					}

					//CREATE THE EVENT
					Event newEvent = new Event(quantity, supplierPrice);

					newEvent.Name = textBox_Name.Text;
					newEvent.EventDate = dateTimePicker_EventDate.Value;
					newEvent.Duration = dateTimePicker_Duration.Value;
					newEvent.PreOrder = textBox_Preorder.Value;
					newEvent.AtDoor = textBox_AtDoor.Value;
					newEvent.Price = textBox_Price.Value;
					newEvent.NonTaxable = checkBox_NonTaxable.Checked;
					newEvent.NonTaxableLocal = checkBox_NonTaxableLocal.Checked;

					newEvent.TypeID = 26;
					newEvent.IdTax = 4;

					//CREATE THE EVENT IN THE DATABASE
					DataAccess.instance.CreateEvent(newEvent);

					//CLOSE THE WINDOW
					this.Close();
				}
			}
		}


		private bool IsEmpty(string word) {
			return word.Replace(" ", "") == "" ? true : false;
		}

		private bool HasNoErrors() {
			bool hasNoErrors = true;
			string result = "";

			//CHECK NAME
			if (IsEmpty(textBox_Name.Text)) {
				hasNoErrors = false;
				result += "Name field is not filled.\n";
			}

			//CHECK TO MAKE SURE DURATION IS AFTER EVENT DATE
			#region DATE COMPARISON
			int eventYear = dateTimePicker_EventDate.Value.Year;
			int eventMonth = dateTimePicker_EventDate.Value.Month;
			int eventDay = dateTimePicker_EventDate.Value.Day;
			int eventHour = dateTimePicker_EventDate.Value.Hour;
			int eventMinute = dateTimePicker_EventDate.Value.Minute;
			int eventSecond = dateTimePicker_EventDate.Value.Second;

			int durationYear = dateTimePicker_Duration.Value.Year;
			int durationMonth = dateTimePicker_Duration.Value.Month;
			int durationDay = dateTimePicker_Duration.Value.Day;
			int durationHour = dateTimePicker_Duration.Value.Hour;
			int durationMinute = dateTimePicker_Duration.Value.Minute;
			int durationSecond = dateTimePicker_Duration.Value.Second;
			
			if (durationYear < eventYear) {
				hasNoErrors = false;
				result += "Duration year cannot be before the Event Date year.\n";
			}
			else if (durationMonth < eventMonth) {
				hasNoErrors = false;
				result += "Duration month cannot be before the Event Date month.\n";
			}
			else if (durationDay < eventDay) {
				hasNoErrors = false;
				result += "Duration day cannot be before the Event Date day.\n";
			}
			else if (durationHour < eventHour) {
				hasNoErrors = false;
				result += "Duration hour cannot be before the Event Date hour.\n";
			}
			else if (durationMinute < eventMinute) {
				hasNoErrors = false;
				result += "Duration minute cannot be before the Event Date minute.\n";
			}
			else if (durationSecond < eventSecond) {
				hasNoErrors = false;
				result += "Duration second cannot be before the Event Date second.\n";
			}
			#endregion

			//CHECK PRE ORDER
			if (IsEmpty(textBox_Preorder.Text)) {
				hasNoErrors = false;
				result += "Preorder field is not filled.\n";
			}

			//CHECK AT DOOR
			if (IsEmpty(textBox_AtDoor.Text)) {
				hasNoErrors = false;
				result += "At Door field is not filled.\n";
			}

			//CHECK PRICE
			if (IsEmpty(textBox_Price.Text)) {
				hasNoErrors = false;
				result += "Price field is not filled.\n";
			}

			//DISPLAY THE ERRORS IF ANY
			if (result != "") {
				MessageBox.Show(result, "Error");
			}

			return hasNoErrors;
		}
	}
}
