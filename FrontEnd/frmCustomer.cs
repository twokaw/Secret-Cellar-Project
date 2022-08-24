using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;



namespace SecretCellar
{
    public partial class frmCustomer : Form
    {
        private Transaction _importedTransaction = null;
        private string _lastSortedColumnName = "";



        public frmCustomer(Transaction transaction)
        {
            InitializeComponent();
            cmb_State.ValueMember = "Initial";
            cmb_State.DisplayMember = "StateName";
            cmb_State.DataSource = DataAccess.StateList;

            _importedTransaction = transaction;

            customer_data_grid.DataSource = DataAccess.instance.GetCustomer().
                Select(x => new{customerID = x.CustomerID, last_name = x.LastName, first_name = x.FirstName, phone = x.PhoneNumber, email = x.Email, business_name = x.BusinessName,
                isWholesale = x.IsWholesale, customerDiscount = x.CustomerDiscount, addr1 = x.Address1, addr2 = x.Address2, city = x.City, state = x.State, zip =x.ZipCode, Credit = x.Credit}).
                OrderBy(x => x.last_name).
                ToList();
        }

        private void customergrid_SelectionChanged(object sender, EventArgs e)
        {
            if (customer_data_grid.SelectedRows.Count > 0)
            {
                Customer i = DataAccess.instance.GetCustomer(uint.Parse(customer_data_grid.SelectedRows[0].Cells["customerID"].Value.ToString()));

                List<Transaction> suspendedTransactions = DataAccess.instance.GetSuspendedTransactions();
                List<Transaction> filteredSuspendedTransactions = suspendedTransactions.FindAll((transaction) => { return transaction.CustomerID == i.CustomerID; });
                button_delete.Enabled = filteredSuspendedTransactions.Count == 0;
                button_UpdateCredit.Enabled = i.CustomerID != 0;
                btn_update.Enabled = i.CustomerID != 0;

                SelectCustomer(i);
            }
        }

        private void SelectCustomer(Customer cust)
        {
            txt_lname.Text = cust.LastName;
            txt_fname.Text = cust.FirstName;
            txt_phone.Text = cust.PhoneNumber;
            txt_email.Text = cust.Email;
            txt_company.Text = cust.BusinessName;
            cbo_wholesale.Text = cust.IsWholesale ? "True" : "False";
            txt_custDisc.Text = cust.CustomerDiscount.ToString();
            txt_addr1.Text = cust.Address1;
            txt_addr2.Text = cust.Address2;
            txt_city.Text = cust.City;
            cmb_State.SelectedValue  = cust.State;
            txt_zip.Text = cust.ZipCode;
        }


        private void frmCustomer_Load(object sender, EventArgs e)
        {
            cmb_State.SelectedValue = DataAccess.instance.DefaultState;
        }

        private void chkbox_wholesale_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_wholesale.Checked)
            {
                
                customer_data_grid.DataSource = DataAccess.instance.GetCustomer().
                Where(x => x.IsWholesale).
                Select(x => new {
                    customerID = x.CustomerID,
                    last_name = x.LastName,
                    first_name = x.FirstName,
                    phone = x.PhoneNumber,
                    email = x.Email,
                    business_name = x.BusinessName,
                    isWholesale = x.IsWholesale,
                    customerDiscount = x.CustomerDiscount,
                    addr1 = x.Address1,
                    addr2 = x.Address2,
                    city = x.City,
                    state = x.State,
                    zip = x.ZipCode
                }).
                    OrderBy(x => x.last_name).
                    ToList();
            }
            else
            {
                refresh();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            
        }

        private void txt_customer_TextChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            customer_data_grid.DataSource = DataAccess.instance.GetCustomer(txt_customer.Text).
              Select(x => new {
                  customerID = x.CustomerID,
                  last_name = x.LastName,
                  first_name = x.FirstName,
                  phone = x.PhoneNumber,
                  email = x.Email,
                  business_name = x.BusinessName,
                  isWholesale = x.IsWholesale,
                  customerDiscount = x.CustomerDiscount,
                  addr1 = x.Address1,
                  addr2 = x.Address2,
                  city = x.City,
                  state = x.State,
                  zip = x.ZipCode,
                  Credit = x.Credit}).
                OrderBy(x => x.last_name).
                ToList();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            if (customer_data_grid.SelectedRows.Count > 0)
            {
                Customer i = DataAccess.instance.GetCustomer().FirstOrDefault(x => x.LastName == txt_lname.Text.Trim() && x.FirstName == txt_fname.Text.Trim());

                if (i != null)
                {
                    if(MessageBox.Show($@"Customer already exists.  Would you like to edit this customer?
Last Name: {i.LastName}
First Name: {i.FirstName}
E-mail: {i.Email}
BusinessName: {i.BusinessName}
Address: 
                    {i.Address1}{(string.IsNullOrWhiteSpace ( i.Address2) ? "": $",{i.Address2}")} 
  {i.City}, {i.State} {i.ZipCode}","Customer Exists", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SelectCustomer(i);
                        return;
                    }
                }
                else {
                    if (txt_lname.Text.Replace(" ", "") != "" && txt_fname.Text.Replace(" ", "") != "") {
                        i = new Customer {
                            LastName = txt_lname.Text.Trim(),
                            FirstName = txt_fname.Text.Trim(),
                            Email = txt_email.Text.Trim(),
                            BusinessName = txt_company.Text.Trim(),
                            IsWholesale = cbo_wholesale.SelectedIndex != 0,
                            CustomerDiscount = double.TryParse(txt_custDisc.Text, out double disc) ? disc : 0,
                            PhoneNumber = txt_phone.Text,
                            Address1 = txt_addr1.Text.Trim(),
                            Address2 = txt_addr2.Text.Trim(),
                            City = txt_city.Text.Trim(),
                            State = (string)cmb_State.SelectedValue,
                            ZipCode = txt_zip.Text.Trim()
                        };

                        i.CustomerID = DataAccess.instance.NewCustomer(i);
                        refresh();
                    }
                    else {
                        MessageBox.Show("First and Last name cannot be empty.", "Error");
					}
				}
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (customer_data_grid.SelectedRows.Count > 0)
            {
                if (txt_lname.Text.Replace(" ", "") != "" && txt_fname.Text.Replace(" ", "") != "") {
                    Customer i = DataAccess.instance.GetCustomer(uint.Parse(customer_data_grid.SelectedRows[0].Cells["customerID"].Value.ToString()));

                    i.LastName = txt_lname.Text;
                    i.FirstName = txt_fname.Text;
                    i.Email = txt_email.Text;
                    i.BusinessName = txt_company.Text;
                    // i.IsWholesale = (bool)cbo_wholesale.SelectedValue; following if statement does work
                    if (cbo_wholesale.SelectedIndex == 1) {
                        i.IsWholesale = true;
                    }
                    else {
                        i.IsWholesale = false;
                    }

                    if (txt_custDisc.Text == null) {
                        i.CustomerDiscount = 0;
                    }
                    else {
                        i.CustomerDiscount = Convert.ToUInt32(txt_custDisc.Text);
                    }

                    i.PhoneNumber = txt_phone.Text;
                    i.Address1 = txt_addr1.Text;
                    i.Address2 = txt_addr2.Text;
                    i.City = txt_city.Text;
                    i.State = (string)cmb_State.SelectedValue;
                    i.ZipCode = txt_zip.Text;


                    i.CustomerID = DataAccess.instance.UpdateCustomer(i);
                    //  customers.Add(i);
                    //  dataAccess.UpdateCustomer(i);
                    refresh();
                }
                else {
                    MessageBox.Show("First and Last name cannot be empty.", "Error");
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if (addCustomer())
            {
                this.DialogResult = DialogResult.OK;
                //transaction.txt_current_cust.Text = customer.CustomerID;
                this.Close();
            }

            /*else
            {
                if(MessageBox.Show("Transaction Customer already set do you want to change customers? ","Customer Error", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        addCustomer();
                        this.DialogResult = DialogResult.OK;
                    }
               
            }*/

        }
        private bool addCustomer()
        {
            if (customer_data_grid.SelectedRows.Count > 0)
            {
                Customer i = DataAccess.instance.GetCustomer(uint.Parse(customer_data_grid.SelectedRows[0].Cells["customerID"].Value.ToString()));
                _importedTransaction.CustomerID = i.CustomerID;

                return true;
            }
            
            return false;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_lname.Text = "";
            txt_fname.Text = "";
            txt_phone.Text = "";
            txt_email.Text = "";
            txt_company.Text = "";
            cbo_wholesale.SelectedIndex = 0;
            txt_custDisc.Text = "";
            txt_addr1.Text = "";
            txt_addr2.Text = "";
            txt_city.Text = "";
            cmb_State.SelectedValue = DataAccess.instance.DefaultState;
            txt_zip.Text = "";
        }

		private void button_UpdateCredit_Click(object sender, EventArgs e) {
            Customer customer = DataAccess.instance.GetCustomer(uint.Parse(customer_data_grid.SelectedRows[0].Cells["customerID"].Value.ToString()));
            frmCustomerCredit frmCustomerCredit = new frmCustomerCredit(customer);
            frmCustomerCredit.ShowDialog();
            refresh();
        }

		private void button_delete_Click(object sender, EventArgs e) {
            if (customer_data_grid.SelectedRows.Count > 0) {
                Customer customer = DataAccess.instance.GetCustomer(uint.Parse(customer_data_grid.SelectedRows[0].Cells["customerID"].Value.ToString()));

                DataAccess.instance.DeleteCustomer(customer);

                refresh();
			}
        }

        private void customer_data_grid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            string columnName = customer_data_grid.Columns[e.ColumnIndex].Name;
            int currentColumn = customer_data_grid.FirstDisplayedScrollingColumnIndex;
            List<Customer> customers = new List<Customer>();

            foreach (DataGridViewRow row in customer_data_grid.Rows) {
                if (uint.TryParse(row.Cells[0].Value.ToString(), out uint customerId)) {
                    Customer customer = DataAccess.instance.GetCustomer(customerId);
                    customers.Add(customer);
                }
            }

            var customersFiltered = customers.Select(x => new {
                customerID = x.CustomerID,
                last_name = x.LastName,
                first_name = x.FirstName,
                phone = x.PhoneNumber,
                email = x.Email,
                business_name = x.BusinessName,
                isWholesale = x.IsWholesale,
                customerDiscount = x.CustomerDiscount,
                addr1 = x.Address1,
                addr2 = x.Address2,
                city = x.City,
                state = x.State,
                zip = x.ZipCode,
                Credit = x.Credit
            });

            if (columnName == _lastSortedColumnName) {
                customersFiltered = customersFiltered.Reverse().ToList();
            }
            else {
                customersFiltered = customersFiltered
                .OrderBy(x => {
                    switch (columnName) {
                        case "last_name": { return x.last_name; }
                        case "first_name": { return x.first_name; }
                        case "phone": { return x.phone; }
                        case "email": { return x.email; }
                        case "Credit": { return x.Credit + ""; }
                        case "business_name": { return x.business_name; }
                        case "isWholesale": { return x.isWholesale + ""; }
                        case "customer_discount": { return x.customerDiscount + ""; }
                        case "addr1": { return x.addr1; }
                        case "addr2": { return x.addr2; }
                        case "city": { return x.city; }
                        case "state": { return x.state; }
                        case "zip": { return x.zip; }
                        default: { return x.last_name; }
                    }
                })
                .ToList();
            }

            customer_data_grid.DataSource = customersFiltered;
            _lastSortedColumnName = columnName;
            customer_data_grid.FirstDisplayedScrollingColumnIndex = currentColumn;
        }
    }
}
