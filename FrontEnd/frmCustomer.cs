using SecretCellar;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SecretCellar
{
    public partial class frmCustomer : Form
    {
        private Transaction customer = null;
        private DataAccess dataAccess = new DataAccess(Properties.Settings.Default.URL);
        private List<Customer> customers = null;

        public frmCustomer(Transaction transaction)
        {
            customer = transaction;
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(72, 72);
            customers = dataAccess.GetCustomer();

            customer_data_grid.DataSource = customers.
                Select(x => new{customerID = x.CustomerID, last_name = x.LastName, first_name = x.FirstName, phone = x.PhoneNumber, email = x.Email, business_name = x.BusinessName,
                isWholesale = x.IsWholesale, customerDiscount = x.CustomerDiscount, addr1 = x.Address1, addr2 = x.Address2, city = x.City, state = x.State, zip =x.ZipCode}).
                OrderBy(x => x.last_name).
                ToList();

            
        }

        private void customergrid_SelectionChanged(object sender, EventArgs e)
        {


            if (customer_data_grid.SelectedRows.Count > 0)
            {
                Customer i = customers.First(x => x.CustomerID == uint.Parse(customer_data_grid.SelectedRows[0].Cells["customerID"].Value.ToString()));
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
                
                customer_data_grid.DataSource = customers.Where(x => x.IsWholesale).
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
            customer_data_grid.DataSource = customers.Where(x => (x.LastName.IndexOf(txt_customer.Text, StringComparison.OrdinalIgnoreCase) >= 0 || x.FirstName.IndexOf(txt_customer.Text, StringComparison.OrdinalIgnoreCase) >= 0)
            && chkbox_wholesale.Checked == false || chkbox_wholesale.Checked == true).

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
                  zip = x.ZipCode}).
                OrderBy(x => x.last_name).
                ToList();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            if (customer_data_grid.SelectedRows.Count > 0)
            {
                Customer i = customers.FirstOrDefault(x => x.LastName == txt_lname.Text.Trim() && x.FirstName == txt_fname.Text.Trim());

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
                   IsWholesale = cbo_wholesale.DroppedDown,
                    CustomerDiscount = int.Parse(txt_custDisc.Text),
                    PhoneNumber = txt_phone.Text.Trim(),
                    Address1 = txt_addr1.Text.Trim(),
                    Address2 = txt_addr2.Text.Trim(),
                    City = txt_city.Text.Trim(),
                    State = txt_state.Text.Trim(),
                    ZipCode = txt_zip.Text.Trim()
                };

                i.CustomerID = dataAccess.NewCustomer(i);
                customers.Add(i);
                refresh();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (customer_data_grid.SelectedRows.Count > 0)
            {
                Customer i = customers.FirstOrDefault(x => x.CustomerID == uint.Parse(customer_data_grid.SelectedRows[0].Cells["customerID"].Value.ToString()));

                i.LastName = txt_lname.Text;
                i.FirstName = txt_fname.Text;
                i.Email = txt_email.Text;
                i.BusinessName = txt_company.Text;
               // i.IsWholesale = (bool)cbo_wholesale.SelectedValue; following if statement does work
                if (cbo_wholesale.SelectedIndex == 0)
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


                i.CustomerID = dataAccess.UpdateCustomer(i);
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
                this.Close();
            }

        }
        private bool addCustomer()
        {
            /*
            if (customer_data_grid.SelectedRows.Count > 0)
            {
                Customer i = customers.FirstOrDefault(x => x.CustomerID == uint.Parse(customer_data_grid.SelectedRows[0].Cells["customerID"].Value.ToString()));

                Customer customer = DataAccess.ConvertInvtoItem(i);
                customer.Items.Add(customer);
                return true;
            }
            */
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
    }
}
