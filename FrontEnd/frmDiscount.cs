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
    public partial class frmDiscount : Form
    {
        private Transaction grid = null;
        private Item coupon;
        private decimal dollar;
        private decimal percent;
 
        public frmDiscount(Transaction items)
        {
            InitializeComponent();
            grid = items;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblFixedDiscount_Click(object sender, EventArgs e)
        {

        }

        private void txtFixedDiscount_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPercentTotalSale_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lblPercentTotalSale_Click(object sender, EventArgs e)
        {

        }

        private void txtPercentLineItem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblPercentLineItem_Click(object sender, EventArgs e)
        {

        }

        private void lblEnterLineItem_Click(object sender, EventArgs e)
        {

        }

        private void txtEnterLineItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectItems_Click(object sender, EventArgs e)
        {
            // frmSelectItems newfrom = new frmSelectItems();
            this.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFixedDiscount.Text = null;
            txtPercentLineItem.Text = null;
            txtPercentTotalSale.Text = null;
        }

        private void btnApplyDiscount_Click(object sender, EventArgs e)
        {
            grid.Discount = decimal.Parse(txtPercentTotalSale.Text);
            coupon.Price = (-1 * (decimal.Parse(txtFixedDiscount.Text)));
            grid.Items.Add(coupon);
            grid.Subtotal = (grid.Subtotal + (grid.Subtotal * grid.Discount));

            this.Close();

        }

        private void dataGridSelectItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void populate()
        {
            dataGridSelectItems.Rows.Clear();

            foreach (Item i in grid.Items)
            {
                int row = dataGridSelectItems.Rows.Add();
                using (var r = dataGridSelectItems.Rows[row])
                {
                    r.Cells["ItemNumber"].Value = i.Id;
                    r.Cells["ItemDesscription"].Value = i.Name;
                    r.Cells["Price"].Value = i.Price;
                }
            }
        }

        private void btnApplyToItem_Click(object sender, EventArgs e)
        {
            selectItemDiscount();
        }

        public void selectItemDiscount()
        {
            // dataGridSelectItems.SelectedRows for selected items
            foreach(DataGridViewRow row in dataGridSelectItems.SelectedRows)
            {
                Item i = grid.Items.First((x) => x.Id == (int)row.Cells["ItemNumber"].Value);
                i.Discount = decimal.Parse(txtPercentLineItem.Text);
                row.Cells["Price"].Value = (i.Price - (i.Price * i.Discount));
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
