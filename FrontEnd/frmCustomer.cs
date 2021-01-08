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
                txt_lname.Text = i.LastName;
                txt_fname.Text = i.FirstName;
                txt_phone.Text = i.PhoneNumber;
                txt_email.Text = i.Email;
                txt_company.Text = i.BusinessName;
                cbo_wholesale.Text = i.IsWholesale?"True":"False";
                txt_custDisc.Text = i.CustomerDiscount.ToString();
                txt_addr1.Text = i.Address1;
                txt_addr2.Text = i.Address2;
                txt_city.Text = i.City;
                txt_state.Text = i.State;
                txt_zip.Text = i.ZipCode;

            }
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

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbo_wholesale_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_box_customer_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
