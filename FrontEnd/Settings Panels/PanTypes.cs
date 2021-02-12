using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretCellar.Settings_Panels
{
    public partial class PanTypes : UserControl
    {
        public PanTypes()
        {
            InitializeComponent();
        }

        private void PanTypes_Load(object sender, EventArgs e)
        {
            lstTypes.DataSource = DataAccess.instance.GetInventoryType();
            cbx_tax.DataSource = DataAccess.instance.GetTax();
            lstTypes.DisplayMember = "TypeName";
            cbx_tax.DisplayMember = "TaxName";
        }

        private void lstTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_bottleDep.Text = ((InventoryType)lstTypes.SelectedItem).BottleDeposit.ToString();
            txt_salesTax.Text = ((InventoryType)lstTypes.SelectedItem).SalesTax.ToString();
            txt_localTax.Text = ((InventoryType)lstTypes.SelectedItem).LocalSalesTax.ToString();
        }
    }
}
