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
        public Transaction transaction = null;

        
        
 
        public frmDiscount(Transaction items)
        {
            InitializeComponent();
            transaction = items;
            txtPercentTotalSale.Text = (transaction.Discount * 100).ToString();
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
            
            this.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFixedDiscount.Clear();
            txtPercentLineItem.Clear();
            txtPercentTotalSale.Clear();
        }

        private void btnApplyDiscount_Click(object sender, EventArgs e)
        {
            percent_discount();
           

     

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
            txt_discountTotal.Text = transaction.DiscountTotal.ToString("c");
            dataGridSelectItems.Rows.Clear();

            foreach (Item i in transaction.Items)
            {
                int row = dataGridSelectItems.Rows.Add();
                using (var r = dataGridSelectItems.Rows[row])
                {
                    r.Cells["ItemNumber"].Value = i.Id;
                    r.Cells["ItemDescription"].Value = i.Description;
                    r.Cells["Price"].Value = ((1-i.Discount)* i.Price).ToString("c");
                    r.Cells["Discount"].Value = i.Discount.ToString("p0");
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
            if(txtPercentLineItem.Text != "")
            foreach(DataGridViewRow row in dataGridSelectItems.SelectedRows)
            {
                 Item i= transaction.Items.First((x) => x.Id == int.Parse(row.Cells["ItemNumber"].Value.ToString())&& (x.Price*(1-x.Discount)).ToString("c") == row.Cells["Price"].Value.ToString());
                i.Discount = double.Parse(txtPercentLineItem.Text) / 100;
                row.Cells["Price"].Value = (i.Price - (i.Price * i.Discount)).ToString("c");
                row.Cells["Discount"].Value = i.Discount.ToString("p0");
            }
            txt_discountTotal.Text = transaction.DiscountTotal.ToString("c");
        }

        public void percent_discount()
        {
            
            if (double.TryParse(txtPercentTotalSale.Text, out double d))
            {
                transaction.Discount = d/100;
            }
            txt_discountTotal.Text = transaction.DiscountTotal.ToString("c");
        }
        public void coupons_discount()
        {
         
            if (double.TryParse(txtFixedDiscount.Text, out double d))
            {
                transaction.Items.Add(new Item() { Price = -d, Name = "Coupon", NumSold = 1});
            }
            
        }

       

        private void txtPercentTotalSale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // transaction.Items.Remove(() { Price = 0, Name = "Coupon", NumSold = 0 });
            this.Close();
        }

        private void digit_only(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
                e.Handled = true;
        }

        private void txtFixedDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.' || txtFixedDiscount.Text.Contains('.')) && e.KeyChar != 8 && e.KeyChar != 127)
                e.Handled = true;
        }

        private void txt_discountTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void coupon_btn_Click(object sender, EventArgs e)
        {
            coupons_discount();
            txtFixedDiscount.Clear();
            populate();
         
        }
        private void update_Discount_Total()
        {

            double sum = 0.0;

            foreach (int i in dataGridSelectItems.Rows)
            {
                sum += i;
            }
            
        }
    }
}
