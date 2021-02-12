using SecretCellar;
using System;
using Shared;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SecretCellar
{
    public partial class frmPropane : ManagedForm
    {
        public Transaction transaction = null;
        private const string PROPANEEXCHANGE = "PROPANEEXCHANGE";
        private const string PROPANENEW = "PROPANENEW";
        public frmPropane(Transaction items)
        {
            InitializeComponent();
            transaction = items;
            
            txt_ex_Qty.Text = ((transaction.Items.FirstOrDefault(x => x.Barcode == PROPANEEXCHANGE)?.NumSold) ?? 0).ToString();
            txt_new_Qty.Text = (transaction.Items.FirstOrDefault(x => x.Barcode == PROPANENEW)?.NumSold ?? 0).ToString();

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            transaction.ChangeItemQty(DataAccess.instance.GetItem(PROPANENEW), uint.Parse(txt_new_Qty.Text));
            transaction.ChangeItemQty(DataAccess.instance.GetItem(PROPANEEXCHANGE), uint.Parse(txt_ex_Qty.Text));
            this.Close();
        }

        private void frmPropane_Load(object sender, EventArgs e)
        {

        }

        private void btn_minus_ex_Click(object sender, EventArgs e)
        {
            txt_ex_Qty.Text = (Convert.ToUInt32(txt_ex_Qty.Text)-1).ToString();
        }

        private void btn_plus_ex_Click(object sender, EventArgs e)
        {
            txt_ex_Qty.Text = (Convert.ToUInt32(txt_ex_Qty.Text) + 1).ToString();
        }

        private void txt_ex_Qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_minus_new_Click(object sender, EventArgs e)
        {
            txt_new_Qty.Text = (Convert.ToUInt32(txt_new_Qty.Text) - 1).ToString();

        }

        private void btn_plus_new_Click(object sender, EventArgs e)
        {
            txt_new_Qty.Text = (Convert.ToUInt32(txt_new_Qty.Text) + 1).ToString();
        }

        private void txt_new_Qty_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
