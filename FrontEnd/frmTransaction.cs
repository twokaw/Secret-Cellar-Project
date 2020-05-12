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
            frmDiscount discount = new frmDiscount(); //instantiates frmDiscount using discount
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
            foreach (Item item in trans.Items)
            {
                int row = dataGridView1.Rows.Add();
                using (var r = dataGridView1.Rows[row])
                {
                    r.Cells["Name"].Value = item.Name;
                    r.Cells["Price"].Value = item.Price;
                    r.Cells["Qty"].Value = item.NumSold;
                    r.Cells["Total"].Value = item.Price * item.NumSold;
                }
            }

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
                    uint Barcode = 0;
                    uint.TryParse(i.Barcode, out Barcode);
                    transaction.Items.Add(new Item(i.Name, i.InventoryID, Barcode, i.InventoryQty, 1, (decimal)i.RetailPrice, !i.NonTaxable, i.InventoryType, i.BottleDepositQty));
                }
                else
                {
                    item.NumSold++;
                }
                addRow(transaction);
            }
        }
    }
}