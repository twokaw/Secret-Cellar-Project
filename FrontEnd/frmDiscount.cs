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
    public partial class frmDiscount : Form
    {
        private Transaction grid = null;
        private Item coupon;
        private double dollar;
        private double percent;
 
        public frmDiscount(Transaction items)
        {
            InitializeComponent();
            grid = items;
            populate();
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
            double d = 0.0;
            if (double.TryParse(txtPercentTotalSale.Text, out d))
            {
                grid.Discount = d;
            }
            if (double.TryParse(txtFixedDiscount.Text, out d))
            {
                coupon.Price = (-1 * (double.Parse(txtFixedDiscount.Text)));
                grid.Items.Add(coupon);
            }
            this.Close();

        }

        private List<int> selectedRows = new List<int>();
        private void dataGridSelectItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedRows.Contains(e.RowIndex))
                selectedRows.Remove(e.RowIndex);
            else
                selectedRows.Add(e.RowIndex);



            foreach (DataGridViewRow r in ((DataGridView)sender).Rows)
                if (r.Selected != selectedRows.Contains(r.Index))
                    r.Selected = selectedRows.Contains(r.Index);
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
                    r.Cells["ItemDescription"].Value = i.Description;
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
                Item i = grid.Items.First((x) => x.Id == int.Parse(row.Cells["ItemNumber"].Value.ToString()));
                i.Discount = double.Parse(txtPercentLineItem.Text) / 100;
                row.Cells["Price"].Value = (i.Price - (i.Price * i.Discount));
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
