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
    public partial class frmPropane : Form
    {
        public Transaction transaction = null;

        public frmPropane(Transaction items)
        {
            InitializeComponent();
            transaction = items;
            //txt_ex_Qty.Text = transaction.Items.Numsold()
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPropane_Load(object sender, EventArgs e)
        {

        }

        private void btn_minus_ex_Click(object sender, EventArgs e)
        {

        }

        private void btn_plus_ex_Click(object sender, EventArgs e)
        {

        }

        private void txt_ex_Qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_minus_new_Click(object sender, EventArgs e)
        {

        }

        private void btn_plus_new_Click(object sender, EventArgs e)
        {

        }

        private void txt_new_Qty_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
