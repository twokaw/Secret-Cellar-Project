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

            customer_data_grid.DataSource = customer.
                Select(x => new { Name = x.Name, Id = x.Id }).
                OrderBy(x = x.Name).
                ToList();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
