using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SecretCellar
{
    public partial class frmDiscount : ManagedForm
    {
        public Transaction transaction = null;
        private List<int> selectedRows = new List<int>();

        public frmDiscount(Transaction items)
        {
            InitializeComponent();
            transaction = items;
            touchKeyPad1.Target = txtPercentTotalSale;
            txtPercentTotalSale.Select();
            populate();
        }

        private void btnSelectItems_Click(object sender, EventArgs e)
        {
            this.Show();
        }
        
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
            txtPercentTotalSale.Text = (transaction.Discount > 0.0) ? $"{transaction.Discount * 100}" : "";

            foreach (Item i in transaction.Items)
            {
                int row = dataGridSelectItems.Rows.Add();
                using (var r = dataGridSelectItems.Rows[row])
                {
                    r.Cells["ItemNumber"].Value = i.Id;
                    r.Cells["ItemDescription"].Value = i.Name;
                    r.Cells["RegularPrice"].Value = i.Price.ToString("c");
                    r.Cells["SalePrice"].Value = i.DiscountPrice.ToString("c");
                    r.Cells["Price"].Value = i.DiscountPrice > 0 ? i.DiscountPrice.ToString("c") : transaction.ItemPrice(i).ToString("c");
                    r.Cells["Discount"].Value = i.DiscountPrice > 0? "0%" : transaction.ItemDiscount(i).ToString("P0");//(Math.Floor(transaction.ItemDiscount(i) * 100) / 100).ToString("P0"); // 1 ((1-i.Discount)*transaction.Discount+i.Discount).ToString("P0");
                }
            }
        }

        public void selectItemDiscount() {
            //double currentdis = transaction.Discount;
            // dataGridSelectItems.SelectedRows for selected items
            if (txtPercentLineItem.Text != "") {
                //double discount_total = 0;
                foreach (DataGridViewRow row in dataGridSelectItems.SelectedRows) {
                    //double disval = Convert.ToDouble(row.Cells["Price"].Value.ToString().Replace("$", "").Replace("(", "").Replace(")", ""));

                    if (!row.Cells["Price"].Value.ToString().Contains("(")) {
                        Item i = transaction.Items.First((x) => x.Id == int.Parse(row.Cells["ItemNumber"].Value.ToString())); //&& (x.Price * (1 - x.Discount)).ToString("c") == row.Cells["Price"].Value.ToString());
                                                                                                                              //i.Discount = double.Parse(txtPercentLineItem.Text) / 100;  //if you add + i.discount it will keep a running total of discount instead of resetting to 0 like it currently does
                                                                                                                              //row.Cells["Price"].Value = i.Price.ToString("c");
                        if (i.DiscountPrice > 0) continue;
                        
                        i.Discount = double.Parse(txtPercentLineItem.Text) / 100;

                        // row.Cells["Discount"].Value = i.Discount+((1-i.Discount)*transaction.Discount).ToString("p0");
                        /*                                                                                                      // discount_total = discount_total + Convert.ToDouble(row.Cells["RegularPrice"].Value.ToString().Replace("$", "").Replace("(", "").Replace(")", "")) - Convert.ToDouble(row.Cells["Price"].Value.ToString().Replace("$", "").Replace("(", "").Replace(")", "")); ;
                        if (double.Parse(txtPercentLineItem.Text) == 0)
                        {
                            i.Discount = 0;
                        }

                        else if (double.Parse(txtPercentLineItem.Text) / 100 < i.Discount)
                        {
                            i.Discount = i.Discount + double.Parse(txtPercentLineItem.Text) / 100;
                        }

                        else if (i.Discount > 0 && double.Parse(txtPercentLineItem.Text) / 100 > i.Discount)
                        {
                            i.Discount = (i.Discount - .01) + double.Parse(txtPercentLineItem.Text) / 100;  //if you add + i.discount it will keep a running total of discount instead of resetting to 0 like it currently does
                                                                                                             //row.Cells["Price"].Value = i.Price.ToString("c");
                                                                                                             // row.Cells["Discount"].Value = i.Discount+((1-i.Discount)*transaction.Discount).ToString("p0");
                        }

                        else
                        {
                            i.Discount = i.Discount + double.Parse(txtPercentLineItem.Text) / 100;  //if you add + i.discount it will keep a running total of discount instead of resetting to 0 like it currently does
                                                                                                     //row.Cells["Price"].Value = i.Price.ToString("c");
                                                                                                     // row.Cells["Discount"].Value = i.Discount+((1-i.Discount)*transaction.Discount).ToString("p0");
                        }*/
                    }

                }
                txtPercentLineItem.Text = "";
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
            foreach (DataGridViewRow row in dataGridSelectItems.Rows) {
                double disval = Convert.ToDouble(txtPercentTotalSale.Text);//Convert.ToDouble(row.Cells["Price"].Value.ToString().Replace("$", "").Replace("(", "").Replace(")", ""));

                if (disval > 0 && !row.Cells["Price"].Value.ToString().Contains("(")) {
                    Item i = transaction.Items.First((x) => x.Id == int.Parse(row.Cells["ItemNumber"].Value.ToString()) && (x.Price * (1 - x.Discount)).ToString("c") == row.Cells["Price"].Value.ToString());
                    if (i.DiscountPrice > 0) continue;

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

        public bool coupons_discount()
        {
            if (double.TryParse(txtFixedDiscount.Value.ToString(), out double d) && d > 0.0)
            {
                transaction.Items.Add(new Item() { Price = -d, Name = "Coupon", QtySold = 1});
                return true;
            }
            return false;
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

        private void txtPercentTotalSale_Click(object sender, EventArgs e)
        {
            txtPercentTotalSale.SelectAll();
        }

		private void btn_ApplyDiscount_Click(object sender, EventArgs e) {
            /*
            foreach (DataGridViewRow row in dataGridSelectItems.Rows)
            {


                //double disval = Convert.ToDouble(row.Cells["Price"].Value.ToString().Replace("$", "").Replace("(", "").Replace(")", ""));

                if (!row.Cells["Price"].Value.ToString().Contains("("))
                {

                    Item i = transaction.Items.First((x) => x.Id == int.Parse(row.Cells["ItemNumber"].Value.ToString())); //&& (x.Price * (1 - x.Discount)).ToString("c") == row.Cells["Price"].Value.ToString());

                    if (double.Parse(txtPercentTotalSale.Text) == 0)
                    {
                        i.Discount = 0;
                    }

                    else if (double.Parse(txtPercentTotalSale.Text) / 100 < i.Discount)
                    {
                        i.Discount = i.Discount - double.Parse(txtPercentTotalSale.Text) / 100;
                    }

                    else if(i.Discount > 0 && double.Parse(txtPercentTotalSale.Text) / 100 > i.Discount) 
                    {
                        i.Discount = (i.Discount - .01) + double.Parse(txtPercentTotalSale.Text) / 100;  //if you add + i.discount it will keep a running total of discount instead of resetting to 0 like it currently does
                                                                                                         //row.Cells["Price"].Value = i.Price.ToString("c");
                                                                                                         // row.Cells["Discount"].Value = i.Discount+((1-i.Discount)*transaction.Discount).ToString("p0");
                    }

                    else
                    {
                        i.Discount = i.Discount + double.Parse(txtPercentTotalSale.Text) / 100;  //if you add + i.discount it will keep a running total of discount instead of resetting to 0 like it currently does
                                                                                                 //row.Cells["Price"].Value = i.Price.ToString("c");
                                                                                                 // row.Cells["Discount"].Value = i.Discount+((1-i.Discount)*transaction.Discount).ToString("p0");
                    }                                                              // discount_total = discount_total + Convert.ToDouble(row.Cells["RegularPrice"].Value.ToString().Replace("$", "").Replace("(", "").Replace(")", "")) - Convert.ToDouble(row.Cells["Price"].Value.ToString().Replace("$", "").Replace("(", "").Replace(")", "")); ;
                }
            }*/
            
            //populate();


            //original code
            if(double.TryParse(txtPercentTotalSale.Text.Replace("-", "").Trim(), out double percent) && percent > 0)
            {
                if (percent > 100)
                    MessageBox.Show("Percentage value may not exceed 100%");
                else
                {
                    transaction.Discount = percent / 100;
                    populate();
                }
            }
            txtPercentTotalSale.Text = "";
        }

		private void button_Coupon_Click(object sender, EventArgs e) {
            if (coupons_discount())
            {
                txtFixedDiscount.Clear();
                populate();
            }
        }

		private void button_Clear_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Do you want to reset line discount to zero", "Confirm Zero", MessageBoxButtons.YesNo)== DialogResult.Yes){
                txtFixedDiscount.Text = "";
                txtPercentLineItem.Text = "";
                txtPercentTotalSale.Text = (transaction.Discount * 100).ToString();
                resetselectItemDiscount();
            }
            //percent_discount();
            //txtFixedDiscount.Text = "";
            txtFixedDiscount.Focus();
            populate();
        }

		private void button_ApplyToItem_Click(object sender, EventArgs e) {
            selectItemDiscount();
        }

		private void button_Close_Click(object sender, EventArgs e) {
            this.Close();
		}

        private void txtCashAmt_Enter(object sender, EventArgs e)
        {
            touchKeyPad1.Target = (TextBox)sender;
        }
    }
}
