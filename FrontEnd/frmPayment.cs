using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Shared;

namespace SecretCellar
{
    public partial class frmPayment : ManagedForm
    {
        public bool PrintReceipt { get; set; }
        private Transaction transaction = null;
        private Customer currentCustomer = null;
        private bool TaxFree = false;
        private List<PaymentMethod> payMethods;
        public frmPayment(Transaction transaction)
        {
            InitializeComponent();
            payMethods = DataAccess.instance.GetPaymentMethods();

            this.transaction = transaction;
            txt_TenderTransTotal.Text = transaction.Total.ToString("C");
            txt_CashOnly.Text = (transaction.Total * (double)(1 - (payMethods.FirstOrDefault(x => x.PayMethod == "CASH").PercentOffset / 100))).ToString("C");

            txtCashAmt.Focus();
            TaxFree = transaction.TaxExempt;

            if (transaction.CustomerID > 0)
            {
                currentCustomer = DataAccess.instance.GetCustomer(transaction.CustomerID);
                txt_customer.Text = $"{currentCustomer.LastName}, {currentCustomer.FirstName}";
                txt_credit_amount.Text = $"{currentCustomer.Credit}";
                btn_cust_credit.Enabled = true;
            }
            else
                btn_cust_credit.Enabled = false;

            RefreshGrid();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCompleteSale_Click(object sender, EventArgs e)
        {
            if (transaction.Payments[0].Method == "BREAKAGE")
                transaction.Items.ForEach(x => x.Price = x.SupplierPrice);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

       

        private void NumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) 
             && !char.IsDigit(e.KeyChar) 
             && e.KeyChar != '.' 
             || (e.KeyChar == '.' && ((TextBox)sender).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            PrintReceipt = Properties.Settings.Default.PrintReceipt;
            chk_printReceipt.Checked = PrintReceipt;
        }

        private void btn_Cash_Click(object sender, EventArgs e)     { UpdatePayment("CASH"); }
        private void btn_Check_Click(object sender, EventArgs e)    { UpdatePayment("CHECK", txtNumber.Text.Trim()); }
        private void btn_Credit_Click(object sender, EventArgs e)   { UpdatePayment("CREDIT CARD", txtNumber.Text.Trim()); }
        private void btn_GiftCard_Click(object sender, EventArgs e) { UpdatePayment("GIFT CARD", txtNumber.Text.Trim()); }
        private void btnDonation_Click(object sender, EventArgs e)  { RemovePayments("DONATE"); }
        private void btnBreakage_Click(object sender, EventArgs e)  { RemovePayments("BREAKAGE"); }
        private void btn_RemoveAllPayments_Click(object sender, EventArgs e)  { RemovePayments(); }

        private void UpdatePayment(string method, string number = null)
        {
            if(transaction.Payments.Count == 1 
               && (transaction.Payments[0].Method == "DONATE" || transaction.Payments[0].Method == "BREAKAGE"))
            {
                transaction.Payments.Clear();
                transaction.TaxExempt = TaxFree;
            }    

            if (double.TryParse(txtCashAmt.Text, out double amount))
                transaction.AddPayment(new Payment { Method = method, Amount = amount, Number = number });

            RefreshGrid();
        }

        private void RemovePayments(string method = "")
        {
            transaction.Payments.Clear();

            if (!string.IsNullOrWhiteSpace(method) && double.TryParse(txt_TenderTransTotal.Text.Replace("$", ""), out double amount))
            {
                transaction.AddPayment(new Payment { Method = method, Amount = amount });
                transaction.TaxExempt = method == "DONATE" || method == "BREAKAGE" || TaxFree;
            }
            
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            double amountPayed = 0;

            paymentType.Rows.Clear();
            txtCashAmt.Clear();
            txtNumber.Clear();

            bool cashonly = true;
            foreach (Payment p in transaction.Payments)
            {
                int row = paymentType.Rows.Add();
                
                using (var r = paymentType.Rows[row])
                {
                    // Populate Payment datagrid row
                    r.Cells["TYPE"].Value = p.Method;
                    r.Cells["AMOUNT"].Value = p.Amount.ToString("C");
                    amountPayed += p.Amount;

                   cashonly &= p.Method.ToUpper() == "CASH" || p.Method.ToUpper() == "CHECK";
                }
            }
            double total = Math.Round(transaction.Total, 2);
            double totalCash = Math.Round(transaction.Total * (double)(1 - (payMethods.FirstOrDefault(x => x.PayMethod == "CASH").PercentOffset / 100)), 2);

            if (amountPayed >= total ||
               cashonly && amountPayed >= totalCash)
            {
                btnCompleteSale.Enabled = true;
                txtChange.Text = (amountPayed - (cashonly ? totalCash : total)).ToString("C");
                txtDue.Text = "$0.00";
            }
            else
            {
                btnCompleteSale.Enabled = false;
                txtDue.Text = ((cashonly ? totalCash : total) - amountPayed).ToString("C");
                txtChange.Text = "$0.00";
            }
            txtCashAmt.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (paymentType.SelectedRows.Count > 0)
            {
                string TYPE = paymentType.SelectedRows[0].Cells["TYPE"].Value.ToString();
                double amt = double.Parse(paymentType.SelectedRows[0].Cells["AMOUNT"].Value.ToString().Substring(1));
                Payment p = transaction.Payments.First(x => x.Method == TYPE && x.Amount == amt);
                transaction.Payments.Remove(p);

                //checks to see if the deletion is customer credit so that it doesn't add too much back to customer credit
                if (TYPE == "CUSTOMER CREDIT") {
                    txt_credit_amount.Text = (Convert.ToDouble(txt_credit_amount.Text) + amt).ToString();
                    currentCustomer.Credit = Convert.ToDouble(txt_credit_amount.Text);
                }

                RefreshGrid();
            }
        }

        private void chk_printReceipt_CheckedChanged(object sender, EventArgs e)
        {
            PrintReceipt = chk_printReceipt.Checked;
        }

        private void btn_cust_credit_Click(object sender, EventArgs e)
        {
            double creditAmount = Convert.ToDouble(txt_credit_amount.Text);
            double due = (Convert.ToDouble(txtDue.Text.Replace("$","")));

            if (txtCashAmt.Text == "")
            {
                if (creditAmount <= 0) {
                    if (MessageBox.Show("Do you want to Create a Negative Credit?", "Create Balance", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        creditAmount = due;
                    else
                        return;
                }
                else
                    creditAmount = Math.Min(creditAmount, due);
            }
            else
                creditAmount = Math.Min(due, Convert.ToDouble(txtCashAmt.Text.Trim()));

            txtCashAmt.Text = creditAmount.ToString();
            UpdatePayment("CUSTOMER CREDIT");

            txt_credit_amount.Text =  (Convert.ToDouble(txt_credit_amount.Text.Trim())- creditAmount).ToString();
            currentCustomer.Credit = Convert.ToDouble(txt_credit_amount.Text);
        }

        private void txtCashAmt_Enter(object sender, EventArgs e)
        {
            touchKeyPad1.Target = (TextBox)sender;
        }
    }
}
