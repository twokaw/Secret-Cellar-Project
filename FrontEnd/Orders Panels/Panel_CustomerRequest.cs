using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;



namespace SecretCellar.Orders_Panels {
	public partial class Panel_CustomerRequest : UserControl {
        private string searchForCustomerText = "Search for customer";



        public Panel_CustomerRequest() {
			InitializeComponent();

            lst_customer.DataSource = DataAccess.instance?.GetCustomer();
            lst_customer.DisplayMember = "FullName";

            if (DataAccess.instance != null) { cust_notes_refresh(); }
        }


        /// <summary>
        /// Update the list of customer based on what is entered.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_CustomerName_TextChanged(object sender, EventArgs e) {
            lst_customer.DataSource = DataAccess.instance.GetCustomer(textBox_CustomerName.Text, true);
        }


        /// <summary>
        /// Remove the default text when entering the customer search bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_CustomerName_Enter(object sender, EventArgs e) {
            if (textBox_CustomerName.Text == searchForCustomerText) {
                textBox_CustomerName.Text = "";
            }
        }


        /// <summary>
        /// Add the default text when leaving the customer search bar and when it's empty.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_CustomerName_Leave(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(textBox_CustomerName.Text)) {
                textBox_CustomerName.Text = searchForCustomerText;

                lst_customer.DataSource = DataAccess.instance.GetCustomer(true);
            }
        }


        /// <summary>
        /// Add the product name with the selected customer to the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_prod_add_Click(object sender, EventArgs e) {

            CustomerNote note = new CustomerNote {
                IdCustomer = ((Customer)lst_customer.SelectedItem)?.CustomerID ?? 0,
                Note = txt_prod_name.Text,
                IdNoteType = 2
            };
            DataAccess.instance.NewCustomerNote(note);

            cust_notes_refresh();
            txt_prod_name.Text = "";
        }


        /// <summary>
        /// Remove the selected item from the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_prod_delete_Click(object sender, EventArgs e) {
            if (request_dataGrid.SelectedRows.Count > 0) {
                CustomerNote currentNote = new CustomerNote();
                currentNote.IdCustomer = uint.Parse(request_dataGrid.SelectedRows[0].Cells["customer_id"].Value.ToString());
                currentNote.IdNote = uint.Parse(request_dataGrid.SelectedRows[0].Cells["note_id"].Value.ToString());
                currentNote.IdNoteType = 2;
                currentNote.Note_Type = "Request";
                currentNote.NoteDate = DateTime.Parse(request_dataGrid.SelectedRows[0].Cells["note_date"].Value.ToString());
                currentNote.Note = request_dataGrid.SelectedRows[0].Cells["prod_name"].Value.ToString();
                /*List<CustomerNote> currentNotes = DataAccess.instance.GetCustomerNotes(selectedCustomer.CustomerID,2);

                foreach (CustomerNote note in currentNotes)
                {
                    if (note.IdNote == (uint.Parse(request_dataGrid.SelectedRows[0].Cells["note_id"].Value.ToString())))
                    {
                        currentNote = note;
                    }
                }
                */

                DataAccess.instance.DeleteCustomerNote(currentNote);
                cust_notes_refresh();
            }
        }


        /// <summary>
        /// Refresh the data grid.
        /// </summary>
        private void cust_notes_refresh() {
            //request_dataGrid.Rows.Clear();
            List<Customer> customers = DataAccess.instance.GetCustomer();
            List<CustomerNote> customerNotes = DataAccess.instance.GetCustomerNotes(2);

            if (customers != null && customerNotes != null) {
                // Old Linq way
                /*
                request_dataGrid.DataSource = from c in customers
                             join n in customerNotes
                             on c.CustomerID equals n.IdCustomer
                             orderby c.FullName
                             select new
                              {
                                customer_id = c.CustomerID,
                                customer_names = c.FullName ,
                                prod_name = n.Note
                              };
                */

                // Cool Kid way
                request_dataGrid.DataSource = customers.
                Join(customerNotes,
                     c => c.CustomerID,
                     n => n.IdCustomer,
                     (c, n) => new { customer_id = c.CustomerID, note_id = n.IdNote, note_date = n.NoteDate, customer_names = c.FullName, prod_name = n.Note }).
                OrderBy(x => x.customer_names).
                ToList();
            }
        }

    }
}
