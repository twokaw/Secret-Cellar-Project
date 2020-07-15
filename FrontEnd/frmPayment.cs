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
            private void addRow(Payment payment)
            {
                paymentType.Rows.Clear();
                if (btn_Cash)
            }
        }
    }
}
