using System;
using System.Windows.Forms;
using Shared;



namespace SecretCellar {
	public partial class frmEventsEdit : Form {
		private Event _eventToEdit;
		private uint _id = 0;


		public frmEventsEdit(Event eventFromForm) {
			InitializeComponent();

			dateTimePicker_EventDate.Format = DateTimePickerFormat.Custom;
			dateTimePicker_EventDate.CustomFormat = "MM/dd/yyyy hh:mm:ss";

			dateTimePicker_Duration.Format = DateTimePickerFormat.Custom;
			dateTimePicker_Duration.CustomFormat = "MM/dd/yyyy hh:mm:ss";

			//GET THE ID OF THE EVENT THAT'S BEING EDITED
			_id = eventFromForm.Id;

			//POPULATE THE FIELDS WITH THE EVENT'S INFO
			textBox_Name.Text = eventFromForm.Name;
			dateTimePicker_EventDate.Value = eventFromForm.EventDate;
			dateTimePicker_Duration.Value = eventFromForm.Duration;
			textBox_Quantity.Text = eventFromForm.Qty + "";
			textBox_AtDoor.Text = eventFromForm.AtDoor.ToString("C");
			textBox_Preorder.Text = eventFromForm.PreOrder.ToString("C");
			textBox_Price.Text = eventFromForm.Price.ToString("C");
			textBox_SupplierPrice.Text = eventFromForm.SupplierPrice.ToString("C");
			checkBox_NonTaxable.Checked = eventFromForm.NonTaxable;
			checkBox_NonTaxableLocal.Checked = eventFromForm.NonTaxableLocal;
		}


		private void button_UpdateEvent_Click(object sender, EventArgs e) {
			if (HasNoErrors()) {
				uint quantity = 9999;
				double supplierPrice = 0.0;

				//CHECK IF QUANTITY IS FILLED
				if (uint.TryParse(textBox_Quantity.Text, out uint uintValue)) {
					quantity = uintValue;
				}

				//CHECK IF SUPPLIER PRICE IS FILLED
				if (double.TryParse(textBox_SupplierPrice.Text.Substring(1), out double doubleValue)) {
					supplierPrice = doubleValue;
				}

				//CREATE A NEW EVENT WITH THE QUANTITY AND SUPPLIER PRICE UPDATED
				_eventToEdit = new Event(quantity, supplierPrice);

				//SET THE ID OF THE NEW EVENT TO THE EVENT THAT'S BEING EDITED
				_eventToEdit.Id = _id;

				//UPDATE THE VALUES OF THE NEW EVENT
				_eventToEdit.Name = textBox_Name.Text;
				_eventToEdit.EventDate = dateTimePicker_EventDate.Value;
				_eventToEdit.Duration = dateTimePicker_Duration.Value;
				_eventToEdit.PreOrder = double.Parse(textBox_Preorder.Text.Substring(1));
				_eventToEdit.AtDoor = double.Parse(textBox_AtDoor.Text.Substring(1));
				_eventToEdit.Price = double.Parse(textBox_Price.Text.Substring(1));
				_eventToEdit.NonTaxable = checkBox_NonTaxable.Checked;
				_eventToEdit.NonTaxableLocal = checkBox_NonTaxableLocal.Checked;

				_eventToEdit.TypeID = 26;
				_eventToEdit.IdTax = 4;

				//CREATE THE EVENT IN THE DATABASE
				DataAccess.instance.UpdateEvent(_eventToEdit);

				//CLOSE THE WINDOW
				this.Close();
			}
		}

		private void button_CloseWindow_Click(object sender, EventArgs e) {
			this.Close();
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

			//IF THE DURATION YEAR IS LESS THAN THE EVENT YEAR THEN ERROR
			if (durationYear < eventYear) {
				hasNoErrors = false;
				result += "Duration year cannot be before the Event Date year.\n";
			}

			//ELSE IF THE YEARS ARE THE SAME
			else if (durationYear == eventYear) {
				//IF THE DURATION MONTH IS LESS THAN THE EVENT MONTH THEN ERROR
				if (durationMonth < eventMonth) {
					hasNoErrors = false;
					result += "Duration month cannot be before the Event Date month.\n";
				}

				//ELSE IF THE MONTHS ARE THE SAME
				else if (durationMonth == eventMonth) {
					//IF THE DURATION DAY IS LESS THAN THE EVENT DAY THEN ERROR
					if (durationDay < eventDay) {
						hasNoErrors = false;
						result += "Duration day cannot be before the Event Date day.\n";
					}

					//ELSE IF THE DAYS ARE THE SAME
					else if (durationDay == eventDay) {
						//IF THE DURATION HOUR IS LESS THAN THE EVENT HOUR THEN ERROR
						if (durationHour < eventHour) {
							hasNoErrors = false;
							result += "Duration hour cannot be before the Event Date hour.\n";
						}

						//ELSE IF THE HOURS ARE THE SAME
						else if (durationHour == eventHour) {
							//IF THE DURATION MINUTE IS LESS THAN THE EVENT MINUTE THEN ERROR
							if (durationMinute < eventMinute) {
								hasNoErrors = false;
								result += "Duration minute cannot be before the Event Date minute.\n";
							}

							//ELSE IF THE MINUTES ARE THE SAME
							else if (durationMinute == eventMinute) {
								//IF THE DURATION SECOND IS LESS THAN THE EVENT SECOND THEN ERROR
								if (durationSecond < eventSecond) {
									hasNoErrors = false;
									result += "Duration second cannot be before the Event Date second.\n";
								}
							}
						}
					}
				}
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
