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
using System.Text.RegularExpressions;

namespace SecretCellar
{
    public partial class frmDiscount : ManagedForm
    {
        public Transaction transaction = null;
        

        
        
 
        public frmDiscount(Transaction items)
        {
            InitializeComponent();
            transaction = items;
            txtPercentTotalSale.Text = "0";//(transaction.Discount * 100).ToString();
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


        private void lblPercentTotalSale_Click(object sender, EventArgs e)
        {

        }

        private void txtPercentLineItem_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void btnSelectItems_Click(object sender, EventArgs e)
        {
            
            this.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFixedDiscount.Text = "0";
            txtPercentLineItem.Text = "0";
            txtPercentTotalSale.Text = (transaction.Discount*100).ToString();
            resetselectItemDiscount();
            //percent_discount();
            txtFixedDiscount.Text = "";
            populate();
        }

        private void btnApplyDiscount_Click(object sender, EventArgs e)
        {
            transaction.Discount = Convert.ToDouble(txtPercentTotalSale.Text)/100;
            //percent_discount();
            populate();

     

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
            txtPercentTotalSale.Text = (transaction.Discount * 100).ToString();

            foreach (Item i in transaction.Items)
            {
                int row = dataGridSelectItems.Rows.Add();
                using (var r = dataGridSelectItems.Rows[row])
                {
                    r.Cells["ItemNumber"].Value = i.Id;
                    r.Cells["ItemDescription"].Value = i.Description;
                    r.Cells["RegularPrice"].Value = i.Price.ToString("c");
                    r.Cells["Price"].Value = transaction.ItemPrice(i).ToString("c");
                    r.Cells["Discount"].Value = ((1-i.Discount)*transaction.Discount+i.Discount).ToString("P0");
                }
            }
        }

        private void btnApplyToItem_Click(object sender, EventArgs e)
        {
            selectItemDiscount();
        }

        public void selectItemDiscount()
        {
            //double currentdis = transaction.Discount;
            // dataGridSelectItems.SelectedRows for selected items
            if (txtPercentLineItem.Text != "")
            {
                //double discount_total = 0;
                foreach (DataGridViewRow row in dataGridSelectItems.SelectedRows)
                {


                    //double disval = Convert.ToDouble(row.Cells["Price"].Value.ToString().Replace("$", "").Replace("(", "").Replace(")", ""));

                    if (!row.Cells["Price"].Value.ToString().Contains("("))
                    {

                        Item i = transaction.Items.First((x) => x.Id == int.Parse(row.Cells["ItemNumber"].Value.ToString())); //&& (x.Price * (1 - x.Discount)).ToString("c") == row.Cells["Price"].Value.ToString());
                        i.Discount = double.Parse(txtPercentLineItem.Text) / 100;  //if you add + i.discount it will keep a running total of discount instead of resetting to 0 like it currently does
                        //row.Cells["Price"].Value = i.Price.ToString("c");
                       // row.Cells["Discount"].Value = i.Discount+((1-i.Discount)*transaction.Discount).ToString("p0");
                       // discount_total = discount_total + Convert.ToDouble(row.Cells["RegularPrice"].Value.ToString().Replace("$", "").Replace("(", "").Replace(")", "")) - Convert.ToDouble(row.Cells["Price"].Value.ToString().Replace("$", "").Replace("(", "").Replace(")", "")); ;
                    }
                }
                populate();
                //transaction.Discount = discount_total;
                //transaction.Discount = discount_total + currentdis;
                //txt_discountTotal.Text = transaction.DiscountTotal.ToString("c");
            }
        }
        public void percent_discount()
        {
            //double curdis = transaction.Discount;
            /*double disval = Convert.ToDouble(txt_discountTotal.Text.Substring(1));
            
            if (double.TryParse(txtPercentTotalSale.Text, out double d))
            {
                transaction.Discount = d/100;
            }
            transaction.Discount = transaction.Discount + curdis;
            disval = disval + transaction.Discount;
            //txt_discountTotal.Text = transaction.DiscountTotal.ToString("c");
            txt_discountTotal.Text = disval.ToString();//(Convert.ToDouble(txt_discountTotal.Text.Substring(1))+ transaction.Discount + transaction.DiscountTotal).ToString("c");

            */
            double discount_total = 0;
            foreach (DataGridViewRow row in dataGridSelectItems.Rows)
            {


                double disval = Convert.ToDouble(txtPercentTotalSale.Text);//Convert.ToDouble(row.Cells["Price"].Value.ToString().Replace("$", "").Replace("(", "").Replace(")", ""));

                if (disval > 0 && !row.Cells["Price"].Value.ToString().Contains("("))
                {

                    Item i = transaction.Items.First((x) => x.Id == int.Parse(row.Cells["ItemNumber"].Value.ToString()) && (x.Price * (1 - x.Discount)).ToString("c") == row.Cells["Price"].Value.ToString());
                    i.Discount = disval/100;//(double.Parse(txtPercentLineItem.Text) / 100) + i.Discount;
                    row.Cells["Price"].Value = (i.Price - (i.Price * i.Discount)).ToString("c");
                    row.Cells["Discount"].Value = i.Discount.ToString("p0");
                    discount_total = discount_total + Convert.ToDouble(row.Cells["RegularPrice"].Value.ToString().Replace("$", "").Replace("(", "").Replace(")", "")) - Convert.ToDouble(row.Cells["Price"].Value.ToString().Replace("$", "").Replace("(", "").Replace(")", "")); ;
                }
            }
            //transaction.Discount = discount_total;
            //transaction.Discount = discount_total + curdis;
            txt_discountTotal.Text = discount_total.ToString("c");
        }
        public void coupons_discount()
        {
         
            if (double.TryParse(txtFixedDiscount.Text, out double d))
            {
                transaction.Items.Add(new Item() { Price = -d, Name = "Coupon", NumSold = 1});
            }
            
        }

        public void resetselectItemDiscount()
        {
            // dataGrid all rows

            foreach (DataGridViewRow row in dataGridSelectItems.Rows)
                {
                Item i = transaction.Items.First((x) => x.Id == int.Parse(row.Cells["ItemNumber"].Value.ToString()));// && (x.Price * (1 - x.Discount)).ToString("c") == row.Cells["Price"].Value.ToString());
                    i.Discount = 0;
                    
                }
            populate();
            
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

            sum = sum + transaction.Discount;
            
        }

        private void txtPercentTotalSale_Click(object sender, EventArgs e)
        {
            txtPercentTotalSale.SelectAll();
        }

        private void txtPercentTotalSale_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
