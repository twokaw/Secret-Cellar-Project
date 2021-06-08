using System;
using Shared;
using System.Linq;




namespace SecretCellar
{
    public partial class frmPropane : ManagedForm
    {
        public Transaction transaction = null;
        private const string PROPANEEXCHANGE = "PROPANEEXCHANGE";
        private const string PROPANENEW = "PROPANENEW";
        public frmPropane(Transaction t)
        {
            InitializeComponent();
            transaction = t;
            txt_ex_Qty.Focus();
            txt_ex_Qty.Text = ((transaction.Items.FirstOrDefault(x => x.Barcode == PROPANEEXCHANGE)?.NumSold) ?? 0).ToString();
            txt_new_Qty.Text = (transaction.Items.FirstOrDefault(x => x.Barcode == PROPANENEW)?.NumSold ?? 0).ToString();

        }



        /////////////////
        //ADD THE CHARGES
        /////////////////
        private void button_Add_Click(object sender, EventArgs e) {
            transaction.ChangeItemQty(DataAccess.instance.GetItem(PROPANENEW), uint.Parse(txt_new_Qty.Text));
            transaction.ChangeItemQty(DataAccess.instance.GetItem(PROPANEEXCHANGE), uint.Parse(txt_ex_Qty.Text));

            this.Close();
        }


        //////////////////
        //CLOSE THE WINDOW
        //////////////////
        private void button_Cancel_Click(object sender, EventArgs e) {
            this.Close();
        }


        /////////////////////////////////////
        //SUBTRACT 1 FROM THE EXCHANGE AMOUNT
        /////////////////////////////////////
        private void btn_minus_ex_Click(object sender, EventArgs e)
        {
            txt_ex_Qty.Text = (Convert.ToUInt32(txt_ex_Qty.Text)-1).ToString();
        }


        //////////////////////////////
        //ADD 1 TO THE EXCHANGE AMOUNT
        //////////////////////////////
        private void btn_plus_ex_Click(object sender, EventArgs e)
        {
            txt_ex_Qty.Text = (Convert.ToUInt32(txt_ex_Qty.Text) + 1).ToString();
        }


        ////////////////////////////////
        //SUBTRACT 1 FROM THE NEW AMOUNT
        ////////////////////////////////
        private void btn_minus_new_Click(object sender, EventArgs e)
        {
            txt_new_Qty.Text = (Convert.ToUInt32(txt_new_Qty.Text) - 1).ToString();

        }


        /////////////////////////
        //ADD 1 TO THE NEW AMOUNT
        /////////////////////////
        private void btn_plus_new_Click(object sender, EventArgs e)
        {
            txt_new_Qty.Text = (Convert.ToUInt32(txt_new_Qty.Text) + 1).ToString();
        }
	}
}
