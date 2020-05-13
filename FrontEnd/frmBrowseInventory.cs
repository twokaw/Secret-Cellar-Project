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
    public partial class frmBrowseInventory : Form
    {
        public frmBrowseInventory()
        {
            InitializeComponent();
        }

        private void frmBrowseInventory_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rbtnRadioShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnRadioShowAll.Checked == true)
            {
                rbtnRadioShowInStock.Checked = false;
                rbtnRadioShowOutOfStock.Checked = false;
            }
        }

        private void rbtnRadioShowInStock_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRadioShowInStock.Checked == true)
            {
                rbtnRadioShowAll.Checked = false;
                rbtnRadioShowOutOfStock.Checked = false;
            }

        }

        private void rbtnRadioShowOutOfStock_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRadioShowOutOfStock.Checked == true)
            {
                rbtnRadioShowInStock.Checked = false;
                rbtnRadioShowAll.Checked = false;
            }
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
