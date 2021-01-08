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
                Select(x => new{customerID = x.CustomerID, last_name = x.LastName, first_name = x.firstName, phone = x.PhoneNumber, email = x.Email, business_name = x.BusinessName,
                isWholesale = x.IsWholesale, customerDiscount = x.CustomerDiscount, addr1 = x.Address1, addr2 = x.Address2, city = x.City, state = x.State, zip =x.ZipCode}).
                OrderBy(x => x.last_name).
                ToList();

            //txt_lname = x.last_name;
            //cbo_wholesale.DataSource = isWholesale;
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
    }
}
