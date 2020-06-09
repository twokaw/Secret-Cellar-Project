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
using System.Windows.Forms;

namespace SecretCellar
{
    public partial class frmLookup : Form
    {
        private Transaction lookUp = null;
        private DataAccess dataAccess = new DataAccess(Properties.Settings.Default.URL);
        private List<Inventory> inventory= null;
        public frmLookup(Transaction transaction)
        {
            lookUp = transaction;
            InitializeComponent();
            inventory = dataAccess.GetInventory();
            populate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addCharge();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double addCharge()
        {
            // if (double.TryParse(txtPercentTotalSale.Text, out d))
           // lookUp.Subtotal += double.Parse(txtCharge.Text);
            return lookUp.Subtotal;
        }
        private void txtCharge_TextChanged(object sender, EventArgs e)
        {

        }

        private void populate()
        {
            LookupView.DataSource = inventory;
            /*LookupView.Rows.Clear();

            foreach (Inventory i in inventory.Where(x => (x.Qty > 0)))
            {
                int row = LookupView.Rows.Add();
                using (var r = LookupView.Rows[row])
                {
                    r.Cells["ItemId"].Value = i.Id;
                    r.Cells["Description"].Value = i.Name;
                    r.Cells["CLASS"].Value = i.ItemType;
                    r.Cells["Qty"].Value = i.Qty;
                    r.Cells["Barcode"].Value = i.Barcode;
                    r.Cells["Price"].Value = i.RetailPrice;
                }
            }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //BindingSource dv = ((DataTable)LookupView.DataSource).DefaultView;
            //dv.RowFilter = $"Description like '%{txtlookup.Text}%'";
           
            LookupView.DataSource = inventory.Where(x=> x.Name.Contains(txtlookup.Text) || x.Barcode.Contains(txtlookup.Text)).
                Select (x=> new { Name = x.Name, Id = x.Id, ItemType = x.ItemType, Qty = x.Qty, Barcode = x.Barcode, Price = x.Price }).ToList();
        }
    }
}
