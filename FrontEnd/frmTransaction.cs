using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Shared;

namespace SecretCellar
{


    public partial class frmTransaction : Form
    {

        private Transaction transaction = new Transaction();
        private DataAccess dataAccess;
        public frmTransaction()
        {
            InitializeComponent();
            txtBarcode.Focus();

        }



        private void frmTransaction_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            frmLogin login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
            }
            else
            {
                this.Dispose();
            }
            dataAccess = new DataAccess(Properties.Settings.Default.URL);

        }



        private void btnDiscount_Click(object sender, EventArgs e)
        {
            frmDiscount discount = new frmDiscount(transaction); //instantiates frmDiscount using discount
            discount.ShowDialog(); // opens form associated with discount instantiation
        }

        private void btnTender_Click(object sender, EventArgs e)
        {
            frmPayment payment = new frmPayment();
            if (payment.ShowDialog() == DialogResult.OK)
            {
                //transaction complete, clear the form
            }
            else
            {
                // return to transaction
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addRow(Transaction trans)
        {
            dataGridView1.Rows.Clear();

            double transactionTotal = 0.0;
            double transactionBottleDeposit = 0.0;

            foreach (Item item in trans.Items)
            {
                int row = dataGridView1.Rows.Add();
                using (var r = dataGridView1.Rows[row])
                {
                    // Populate tranaction datagrid row
                    r.Cells["Description"].Value = item.Name;
                    r.Cells["Price"].Value = item.Price.ToString("C");
                    r.Cells["Qty"].Value = item.NumSold;
                    r.Cells["Total"].Value = (item.Price * item.NumSold * (1 - item.Discount)).ToString("C");
                    r.Cells["BOTTLE_DEPOSIT"].Value = (item.NumSold * item.Bottles *.05).ToString("C");

                    // Sum subtotal values for the subtotal box
                    transactionTotal += item.Price * item.NumSold * (1 - item.Discount);
                    transactionBottleDeposit += item.NumSold * item.Bottles * .05;
                }
            }

            // Populate subtotal box
            txt_transSubTotal.Text = transactionTotal.ToString("C");
            txt_transBTLDPT.Text = transactionBottleDeposit.ToString("C");

        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void btnDryClean_Click(object sender, EventArgs e)
        {
            frmDryCleaning dryCleaning = new frmDryCleaning();
            if (dryCleaning.ShowDialog() == DialogResult.OK)
            {
                //Add dry cleaning
            }
            else
            {
                // do nothing
            }
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {         

        } 


        private void txtBarcode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Inventory i = dataAccess.GetItem(txtBarcode.Text.Trim());
                if (i != null)
                {
                    Item item = transaction.Items.FirstOrDefault(x => x.Id == i.Id);
                    if (item == null)
                    {
                        transaction.Items.Add(new Item(i.Name, i.Id, i.Barcode, i.Qty, 1, i.RetailPrice, !i.NonTaxable, i.ItemType, i.Bottles, 0, 0));
                    }
                    else
                    {
                        item.NumSold++;
                    }
                    addRow(transaction);
                }
                else
                    MessageBox.Show("Barcode not found");
                txtBarcode.Clear();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}