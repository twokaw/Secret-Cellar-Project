using System;
using Shared;
using System.Windows.Forms;
namespace SecretCellar
{
    public partial class frmPropane : Form
    {
        public Transaction transaction = null;

        public frmPropane(Transaction items)
        {
            InitializeComponent();
            transaction = items;
            txt_Qty.Text = "1";
        }

        private void txt_Qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_propane_ex_Click(object sender, EventArgs e)
        {
           // Item i = transaction.Items.FirstOrDefault(x) => x.Id == int.Parse(row.Cells)
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
