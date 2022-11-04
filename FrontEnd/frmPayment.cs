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
        public double AmountPayed { get; set; } = 0.0;
        public double Change { get; set; } = 0.0;

        public frmPayment(Transaction transaction)
        {
            InitializeComponent();
            payMethods = DataAccess.instance.GetPaymentMethods();

            this.transaction = transaction;
            txt_TenderTransTotal.Text = transaction.Total.ToString("C");
            txt_CashOnly.Text = (transaction.Total * (double)(1 - (payMethods.FirstOrDefault(x => x.PayMethod == "CASH").PercentOffset / 100))).ToString("C");

            txtCashAmt.Focus();
            TaxFree = transaction.TaxExempt;

            btn_PayTab.Visible = false;
            bool showCustomer = transaction.CustomerID > 0;

            if (showCustomer)
            {
                currentCustomer = DataAccess.instance.GetCustomer(transaction.CustomerID);
                txt_customer.Text = currentCustomer.FullName;
                txt_credit_amount.Value = currentCustomer.Credit;

                btn_PayTab.Visible = currentCustomer.Credit < 0;
            }

            btn_cust_credit.Visible  = showCustomer;
            chk_ChangetoCredit.Enabled = showCustomer;
            lbl_credit.Visible = showCustomer;
            lbl_customer.Visible = showCustomer;
            txt_customer.Visible = showCustomer;
            txt_credit_amount.Visible = showCustomer;
            btn_cust_credit.Enabled = showCustomer;
            chk_ChangetoCredit.Enabled = showCustomer;
            chk_ChangetoCredit.Checked = transaction.Items.Count == 0;

            RefreshGrid();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCompleteSale_Click(object sender, EventArgs e)
        {
            if (transaction.Payments.Count > 0 && transaction.Payments[0].Method == "BREAKAGE")
                transaction.Items.ForEach(x => x.Price = x.SupplierPrice);

            transaction.ChangetoCredit = chk_ChangetoCredit.Checked;  

         //   DataAccess.instance.UpdateCustomer(currentCustomer);
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

        private void btn_PayTab_Click(object sender, EventArgs e)   
        {
            double payAmount = txtCashAmt.Value;

            if (payAmount == 0.0)
                payAmount = Math.Abs(txt_credit_amount.Value)* -1; 
            else
                payAmount = Math.Abs(payAmount) * -1;

            txtCashAmt.Value = payAmount;
            UpdatePayment("TAB PAYMENT");

            txt_credit_amount.Value -= payAmount;
            currentCustomer.Credit  = txt_credit_amount.Value;
        }

        private void btn_cust_credit_Click(object sender, EventArgs e)
        {
            double creditAmount = txt_credit_amount.Value ;
            double due = txtDue.Value;
            double payAmount = txtCashAmt.Value;

            if  (payAmount == 0.0)
            {
                if (creditAmount <= 0) 
                    payAmount = due;
                else
                    payAmount = Math.Min(creditAmount, due);
            }
            if(payAmount > creditAmount 
                && MessageBox.Show("Do you want to create a Negative Credit?", "Create Balance", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            txtCashAmt.Text = $"{payAmount :c}";
            UpdatePayment("CUSTOMER CREDIT", $"{payAmount}");

            txt_credit_amount.Text = $"{creditAmount - payAmount}";
            currentCustomer.Credit = Convert.ToDouble(txt_credit_amount.Text.Substring(1));
        }
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
            double amount = txtCashAmt.Value;
            if (amount < 0.0)
            {
                transaction.AddPayment(new Payment { Method = method, Amount = amount, Number = number });
                RefreshGrid();
            }
            else if ( amount > 0.0)
            {
                transaction.AddPayment(new Payment { Method = method, Amount = amount, Number = number });
                RefreshGrid();
            }
            else if ((method == "CREDIT CARD"
                  || method == "CHECK" && !IsCashonly(true))
                  && double.TryParse(txtDue.Text.Replace("$", ""), out double cardbalance) && cardbalance > 0.0)
            {
                transaction.AddPayment(new Payment { Method = method, Amount = cardbalance, Number = number });
                RefreshGrid();
            }
            else if (method == "CHECK" && double.TryParse(txt_CashOnly.Text.Replace("$", ""), out double cashBalance) && cashBalance > 0.0)
            {
                transaction.AddPayment(new Payment { Method = method, Amount = cashBalance, Number = number });
                RefreshGrid();
            }
            else
            {
                txtCashAmt.Focus();
            }
            
            if (method == "TAB PAYMENT")
                btn_cust_credit.Enabled = false;
        }

        private void RemovePayments(string method = "")
        {
            double credit = txt_credit_amount.Value;

            foreach (Payment p in transaction.Payments)
            {
                if (p.Method == "CUSTOMER CREDIT")
                    credit += p.Amount;

                if (p.Method == "TAB PAYMENT")
                    credit -= p.Amount;
            }
            btn_cust_credit.Enabled = true;

            txt_credit_amount.Value = credit;
            currentCustomer.Credit = credit;

            paymentType.Rows.Clear();
            transaction.Payments.Clear();

            transaction.TaxExempt = TaxFree;
            
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            paymentType.Rows.Clear();
            txtCashAmt.Clear();
            txtNumber.Clear();
            AmountPayed = 0;
            bool cashonly = transaction.Payments.Count > 0;
            foreach (Payment p in transaction.Payments)
            {
                int row = paymentType.Rows.Add();
                
                using (var r = paymentType.Rows[row])
                {
                    // Populate Payment datagrid row
                    r.Cells["TYPE"].Value = p.Method;
                    r.Cells["AMOUNT"].Value = p.Amount.ToString("C");
                    AmountPayed += p.Amount;

                   cashonly &= p.Method.ToUpper() == "CASH" || p.Method.ToUpper() == "CHECK";
                }
            }

            double total = Math.Round(transaction.Total, 2);
            double totalCash = Math.Round(transaction.Total * (double)(1 - (payMethods.FirstOrDefault(x => x.PayMethod == "CASH").PercentOffset / 100)), 2);

            if (AmountPayed >= total ||
               cashonly && AmountPayed >= totalCash)
            {
                btnCompleteSale.Enabled = true;

                Change = AmountPayed - (cashonly ? totalCash : total);
                txtChange.Text = $"{Change:C}";
                txtDue.Text = "$0.00";
            }
            else
            {
                btnCompleteSale.Enabled = false;
                txtDue.Text = ((cashonly ? totalCash : total) - AmountPayed).ToString("C");
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
                    double credit = txt_credit_amount.Value;
                    credit += amt;
                    txt_credit_amount.Value = credit;
                    currentCustomer.Credit = credit;
                }
                if (TYPE == "TAB PAYMENT")
                    btn_PayTab.Enabled = true;
                RefreshGrid();
            }
        }

        private void chk_printReceipt_CheckedChanged(object sender, EventArgs e)
        {
            PrintReceipt = chk_printReceipt.Checked;
        }

        private void txtCashAmt_Enter(object sender, EventArgs e)
        {
            touchKeyPad1.Target = (TextBox)sender;
        }

        private bool IsCashonly(bool cashonly = false)
        {
            cashonly |= transaction.Payments.Count > 0;
            foreach (Payment p in transaction.Payments)
            {
                int row = paymentType.Rows.Add();
                
                using (var r = paymentType.Rows[row])
                {
                    // Populate Payment datagrid row
                    r.Cells["TYPE"].Value = p.Method;
                    r.Cells["AMOUNT"].Value = p.Amount.ToString("C");

                   cashonly &= p.Method.ToUpper() == "CASH" || p.Method.ToUpper() == "CHECK";
                }
            }
            return cashonly;
        }

    }
}
