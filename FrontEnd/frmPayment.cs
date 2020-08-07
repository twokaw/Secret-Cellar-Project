using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared;

namespace SecretCellar
{
    public partial class frmPayment : Form
    {

        private Transaction transaction = null;


        public frmPayment(Transaction transaction)
        {
            InitializeComponent();

            this.transaction = transaction;
            txt_TenderTransTotal.Text = transaction.Total.ToString("C");
            
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lCheckAmt_Click(object sender, EventArgs e)
        {

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCompleteSale_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        //possibly a duplicate and not needed
        private void txt_TransTotal_TextChanged(object sender, EventArgs e)
        {
            txt_TenderTransTotal.Text = transaction.Total.ToString("C");
        }

        private void NumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) 
             && !char.IsDigit(e.KeyChar) 
             && e.KeyChar != '.' 
             || (e.KeyChar == '.' && ((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {

        }

        private void txtCashAmt_TextChanged(object sender, EventArgs e)
        {

        }

        private void paymentType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btn_Cash_Click(object sender, EventArgs e)
        {
            transaction.Payments.Add(new Payment { Method = "CASH", Amount = double.Parse(txtCashAmt.Text) });
            RefreshGrid();
        }

        private void LB_Due_Click(object sender, EventArgs e)
        {

        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            transaction.Payments.Add(new Payment { Method = "CHECK", Amount = double.Parse(txtCashAmt.Text) });
            RefreshGrid();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Credit_Click(object sender, EventArgs e)
        {
            transaction.Payments.Add(new Payment { Method = "CREDIT CARD", Amount = double.Parse(txtCashAmt.Text) });
            RefreshGrid();
        }

        private void btn_GiftCard_Click(object sender, EventArgs e)
        {
            transaction.Payments.Add(new Payment { Method = "GIFT CARD", Amount = double.Parse(txtCashAmt.Text) });
            RefreshGrid();
        }
        private void RefreshGrid()
        {
            double amountPayed = 0;
            paymentType.Rows.Clear();
            txtCashAmt.Clear();
            foreach (Payment p in transaction.Payments)
            {
                int row = paymentType.Rows.Add();
                
                using (var r = paymentType.Rows[row])
                {
                    // Populate Payment datagrid row
                    r.Cells["TYPE"].Value = p.Method;
                    r.Cells["AMOUNT"].Value = p.Amount.ToString("C");
                    amountPayed += p.Amount;

                    
                }
                if(amountPayed >= transaction.Total)
                {
                    btnCompleteSale.Enabled = true;
                    txtChange.Text = (amountPayed - transaction.Total).ToString("C");
                    txtDue.Text = "$0.00";
                }
                else
                {
                    btnCompleteSale.Enabled = false;
                    txtDue.Text = (transaction.Total - amountPayed).ToString("C");
                    txtChange.Text = "$0.00";
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (paymentType.SelectedRows.Count > 0)
            {
                string TYPE = paymentType.SelectedRows[0].Cells["TYPE"].Value.ToString();
                double amt = double.Parse(paymentType.SelectedRows[0].Cells["AMOUNT"].Value.ToString().Substring(1));
                Payment p = transaction.Payments.First(x => x.Method == TYPE && x.Amount == amt);
                transaction.Payments.Remove(p);
                RefreshGrid();
            }
        }
    }
}
