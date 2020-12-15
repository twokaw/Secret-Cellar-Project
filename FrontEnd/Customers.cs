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
    public partial class Customers : ManagedForm
    {
        public string customerName;
        public Customers()
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
            for(int i = 0; i < dataGridTabs.Rows.Count; i++)
            {
                if (dataGridTabs.Rows[i].Selected)
                {
                    dataGridTabs.Rows.RemoveAt(i);
                }
            }
        }

        private void btnPayOutTab_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 
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

        private void Customers_Load(object sender, EventArgs e)
        {

        }
    }
}
