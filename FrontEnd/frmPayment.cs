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
        private Transaction Transaction = null;
        private readonly Customer CurrentCustomer = null;
        private bool TaxFree = false;
        private readonly List<PaymentMethod> PayMethods;
        public double AmountPayed { get; set; } = 0.0;
        public double Change { get; set; } = 0.0;

        public frmPayment(Transaction transaction)
        {
            InitializeComponent();
            PayMethods = DataAccess.instance.GetPaymentMethods();

            this.Transaction = transaction;
            txt_TenderTransTotal.Text = transaction.Total.ToString("C");

            if(PayMethods.FirstOrDefault(x => x.PayMethod == "CASH").PercentOffset != 0)
            {
                txt_CashOnly.Text = (transaction.Total 
                                  * (double)(1 - (PayMethods.FirstOrDefault(x => x.PayMethod == "CASH").PercentOffset / 100))).ToString("C");
            }
            else
            {
                lbCashTotal.Visible = false;
                txt_CashOnly.Visible = false;
                LB_Total.Text = "Total";
            }

            txtCashAmt.Focus();
            TaxFree = transaction.TaxExempt;

            btn_PayTab.Visible = false;
            bool showCustomer = transaction.CustomerID > 0;

            if (showCustomer)
            {
                CurrentCustomer = DataAccess.instance.GetCustomer(transaction.CustomerID);
                txt_customer.Text = CurrentCustomer.FullName;
                txt_credit_amount.Value = CurrentCustomer.Credit;
                btn_PayTab.Visible = CurrentCustomer.Credit < 0;
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
            if (Transaction.Payments.Count > 0 && Transaction.Payments[0].Method == "BREAKAGE")
                Transaction.Items.ForEach(x => x.Price = x.SupplierPrice);

            Transaction.ChangetoCredit = chk_ChangetoCredit.Checked;  

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
            double payAmount = Math.Round(txtCashAmt.Value, MidpointRounding.AwayFromZero);

            if (payAmount == 0.0)
                payAmount = Math.Abs(txt_credit_amount.Value)* -1; 
            else
                payAmount = Math.Abs(payAmount) * -1;

            txtCashAmt.Value = payAmount;
            UpdatePayment("TAB PAYMENT");

            txt_credit_amount.Value -= payAmount;
            CurrentCustomer.Credit  = txt_credit_amount.Value;
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
                && MessageBox.Show("Do you want to create a negative credit?", "Create Balance", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            txtCashAmt.Text = $"{payAmount :c}";
            UpdatePayment("CUSTOMER CREDIT", $"{payAmount}");

            txt_credit_amount.Text = $"{creditAmount - payAmount}";
            CurrentCustomer.Credit = Convert.ToDouble(txt_credit_amount.Text.Substring(1));
        }
        private void btnDonation_Click(object sender, EventArgs e)  { RemovePayments("DONATE"); }
        private void btnBreakage_Click(object sender, EventArgs e)  { RemovePayments("BREAKAGE"); }
        private void btn_RemoveAllPayments_Click(object sender, EventArgs e)  { RemovePayments(); }
        private void UpdatePayment(string method, string number = null)
        {
            if(Transaction.Payments.Count == 1 
               && (Transaction.Payments[0].Method == "DONATE" || Transaction.Payments[0].Method == "BREAKAGE"))
            {
                Transaction.Payments.Clear();
                Transaction.TaxExempt = TaxFree;
            }
            double amount = txtCashAmt.Value;
            if (amount != 0.0)
            {
                Transaction.AddPayment(new Payment { Method = method, Amount = amount, Number = number });
                RefreshGrid();
            }
            else if ((method == "CREDIT CARD"
                  || method == "CHECK" && !IsCashonly(true))
                  && double.TryParse(txtDue.Text.Replace("$", ""), out double cardBalance) && cardBalance > 0.0)
            {
                cardBalance = Math.Round(cardBalance, 2, MidpointRounding.AwayFromZero);
                Transaction.AddPayment(new Payment { Method = method, Amount = cardBalance, Number = number });
                RefreshGrid();
            }
            else if (method == "CHECK" && double.TryParse(txt_CashOnly.Text.Replace("$", ""), out double checkBalance) && checkBalance > 0.0)
            {
                checkBalance = Math.Round(checkBalance, 2, MidpointRounding.AwayFromZero);
                Transaction.AddPayment(new Payment { Method = method, Amount = checkBalance, Number = number });
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
            double credit = Math.Round(txt_credit_amount.Value, 2, MidpointRounding.AwayFromZero);

            foreach (Payment p in Transaction.Payments)
            {
                if (p.Method == "CUSTOMER CREDIT")
                    credit += p.Amount;

                if (p.Method == "TAB PAYMENT")
                    credit -= p.Amount;
            }
            btn_cust_credit.Enabled = true;

            txt_credit_amount.Value = credit;
            if (CurrentCustomer != null) CurrentCustomer.Credit = credit;

            paymentType.Rows.Clear();
            Transaction.Payments.Clear();

            Transaction.TaxExempt = TaxFree;
            
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            paymentType.Rows.Clear();
            txtCashAmt.Clear();
            txtNumber.Clear();
            AmountPayed = 0;
            bool cashonly = Transaction.Payments.Count > 0;
            foreach (Payment p in Transaction.Payments)
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

            double total = Math.Round(Transaction.Total, 2);
            double totalCash = Math.Round(Transaction.Total * (double)(1 - (PayMethods.FirstOrDefault(x => x.PayMethod == "CASH").PercentOffset / 100)), 2);

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
                Payment p = Transaction.Payments.First(x => x.Method == TYPE && x.Amount == amt);
                Transaction.Payments.Remove(p);

                //checks to see if the deletion is customer credit so that it doesn't add too much back to customer credit
                if (TYPE == "CUSTOMER CREDIT") {
                    double credit = txt_credit_amount.Value;
                    credit += amt;
                    txt_credit_amount.Value = credit;
                    CurrentCustomer.Credit = credit;
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
            cashonly |= Transaction.Payments.Count > 0;
            foreach (Payment p in Transaction.Payments)
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
