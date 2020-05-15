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
using NCR_Printer;

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
            frmDiscount discount = new frmDiscount(); //instantiates frmDiscount using discount
            discount.ShowDialog(); // opens form associated with discount instantiation
        }

        private void btnTender_Click(object sender, EventArgs e)
        {
            frmPayment payment = new frmPayment();
            if (payment.ShowDialog() == DialogResult.OK)
            {
                //transaction complete, clear the form
                Image logo = Image.FromFile("CHANGEME!");
                Receipt r = new Receipt(transaction, "The Secret Cellar\n(319) 841-2172\n1205 Curtis Bridge Rd NE", "Thank you!\nCheck our website for events and classes\nwww.SecretCellarwines.com", logo);
                r.print();
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

            double transactionTotal = 0;
            double transactionBottleDeposit = 0;

            foreach (Item item in trans.Items)
            {
                int row = dataGridView1.Rows.Add();
                using (var r = dataGridView1.Rows[row])
                {
                    r.Cells["Description"].Value = item.Name;
                    r.Cells["Price"].Value = item.Price;
                    r.Cells["Qty"].Value = item.NumSold;
                    r.Cells["Total"].Value = item.Price * item.NumSold * (1 - item.Discount);
                    transactionTotal += Convert.ToDouble(r.Cells["Total"].Value.ToString());
                    transactionBottleDeposit += item.NumSold * item.NumBottles;
                    r.Cells["BOTTLE DEPOSIT"].Value = item.NumSold * item.NumBottles *.05;
                }
                
            }
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
                Item item = transaction.Items.FirstOrDefault(x => x.Id == i.InventoryID);
                if (item == null)
                {
                    /*uint Barcode = 0;
                    uint.TryParse(i.Barcode, out Barcode);*/
                    transaction.Items.Add(new Item(i.Name, i.InventoryID, i.Barcode, i.InventoryQty, 1, (decimal)i.RetailPrice, !i.NonTaxable, i.InventoryType, i.BottleDepositQty, 0.0M, 0.0M));
                }
                else
                {
                    item.NumSold++;
                }
                addRow(transaction);
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