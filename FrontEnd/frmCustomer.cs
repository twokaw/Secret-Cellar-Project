﻿using Shared;
using System;
using System.Linq;
using System.Web.UI.WebControls;
using System.Windows.Forms;



namespace SecretCellar
{
    public partial class frmCustomer : Form
    {
        private Transaction customer = null;

        public frmCustomer(Transaction transaction)
        {
            customer = transaction;
            InitializeComponent();

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
            txt_state.Text = cust.State;
            txt_zip.Text = cust.ZipCode;
        }


        private void frmCustomer_Load(object sender, EventArgs e)
        {

        }

        private void customer_data_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnl_change_info_Paint(object sender, PaintEventArgs e)
        {

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

        private void cbo_wholesale_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                Customer i = DataAccess.instance.GetCustomer(true).FirstOrDefault(x => x.LastName == txt_lname.Text.Trim() && x.FirstName == txt_fname.Text.Trim());

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
                
                i = new Customer
                {
                    LastName = txt_lname.Text.Trim(),
                    FirstName = txt_fname.Text.Trim(),
                    Email = txt_email.Text.Trim(),
                    BusinessName = txt_company.Text.Trim(),
                    IsWholesale = cbo_wholesale.SelectedIndex != 0,
                    CustomerDiscount = double.TryParse(txt_custDisc.Text,out double disc)?disc:0,
                    PhoneNumber = txt_phone.Text,
                    Address1 = txt_addr1.Text.Trim(),
                    Address2 = txt_addr2.Text.Trim(),
                    City = txt_city.Text.Trim(),
                    State = txt_state.Text.Trim(),
                    ZipCode = txt_zip.Text.Trim()
                };

                i.CustomerID = DataAccess.instance.NewCustomer(i);
                refresh();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (customer_data_grid.SelectedRows.Count > 0)
            {
                Customer i = DataAccess.instance.GetCustomer(uint.Parse(customer_data_grid.SelectedRows[0].Cells["customerID"].Value.ToString()), true);

                i.LastName = txt_lname.Text;
                i.FirstName = txt_fname.Text;
                i.Email = txt_email.Text;
                i.BusinessName = txt_company.Text;
               // i.IsWholesale = (bool)cbo_wholesale.SelectedValue; following if statement does work
                if (cbo_wholesale.SelectedIndex == 1)
                {
                    i.IsWholesale = true;
                }
                else
                {
                    i.IsWholesale = false;
                }

                if (txt_custDisc.Text == null)
                {
                    i.CustomerDiscount = 0;
                }
                else
                {
                    i.CustomerDiscount = Convert.ToUInt32(txt_custDisc.Text);
                }

                i.PhoneNumber = txt_phone.Text;
                i.Address1 = txt_addr1.Text;
                i.Address2 = txt_addr2.Text;
                i.City = txt_city.Text;
                i.State = txt_state.Text;
                i.ZipCode = txt_zip.Text;


                i.CustomerID = DataAccess.instance.UpdateCustomer(i);
              //  customers.Add(i);
              //  dataAccess.UpdateCustomer(i);
                refresh();
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

        }
        private bool addCustomer()
        {
            if (customer_data_grid.SelectedRows.Count > 0)
            {
                Customer i = DataAccess.instance.GetCustomer(uint.Parse(customer_data_grid.SelectedRows[0].Cells["customerID"].Value.ToString()), true);

                customer.CustomerID = i.CustomerID;
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
            cbo_wholesale.SelectedIndex = 1;
            txt_custDisc.Text = "";
            txt_addr1.Text = "";
            txt_addr2.Text = "";
            txt_city.Text = "";
            txt_state.Text = "";
            txt_zip.Text = "";
        }

		private void button_UpdateCredit_Click(object sender, EventArgs e) {
            Customer customer = DataAccess.instance.GetCustomer(uint.Parse(customer_data_grid.SelectedRows[0].Cells["customerID"].Value.ToString()), true);

            frmCustomerCredit frmCustomerCredit = new frmCustomerCredit(customer);
            DialogResult result = frmCustomerCredit.ShowDialog();

            if (result.Equals(DialogResult.OK)) {
                refresh();
			}
        }
	}
}
