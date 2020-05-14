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
    public partial class frmEvent : Form
    {
        public string customerName;
        public frmEvent()
        {
            InitializeComponent();
        }

        private void btnNewTab_Click(object sender, EventArgs e)
        {
            grpBoxAddTab.Visible = true;
            lblEnterName.Visible = true;
            txtBoxName.Visible = true;
            btnAddTab.Visible = true;
            btnCancel.Visible = true;
        }

        private void dataGridTabs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddToTab_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteTab_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in ((DataGridView)sender).Rows)
                if(r.Selected == true)
                {
                    
                }
        }

        private void btnPayOutTab_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* public void selectTab()
         {
             // dataGridSelectItems.SelectedRows for selected items
             foreach (DataGridViewRow row in dataGridTabs.SelectedRows)
             {
                 Item i = grid.Items.First((x) => x.Id == int.Parse(row.Cells["ItemNumber"].Value.ToString()));
                 i.Discount = decimal.Parse(txtPercentLineItem.Text) / 100;
                 row.Cells["Price"].Value = (i.Price - (i.Price * i.Discount));
             }
         } */

        private void grpBoxAddTab_Enter(object sender, EventArgs e)
        {

        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddTab_Click(object sender, EventArgs e)
        {
            addRow(txtBoxName.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grpBoxAddTab.Visible = false;
            lblEnterName.Visible = false;
            txtBoxName.Visible = false;
            btnAddTab.Visible = false;
            btnCancel.Visible = false;
        }

        private void addRow(string name)
        {
            dataGridTabs.Rows.Add(name);
        }
    }
}
