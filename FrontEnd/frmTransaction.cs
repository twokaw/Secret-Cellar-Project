using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretCellar
{

    //public class Item
    //{
        //public string barcode;
        //public string description;
        //public double price;
        //public int qty;
    //}

    public partial class frmTransaction : Form
    {

        //private List<Item> items = new List<Item>();
        //private List<Item> inventory = new List<Item>();



        
        public frmTransaction()
        {
            InitializeComponent();
           
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

        private void addRow(AddTransaction trans)
        {
            //DataGridViewRow row = dataGridView1.Rows.Add()
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
    }
}
