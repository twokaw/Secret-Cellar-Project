using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared;

namespace SecretCellar
{
    public partial class frmBrowseInventory : Form
    {
        private List<Inventory> grid;
        
        public frmBrowseInventory(List<Inventory> inventoryList)
        {
            grid = inventoryList;
            InitializeComponent();
        }

        private void frmBrowseInventory_Load(object sender, EventArgs e)
        {

        }
        private void rbtnRadioShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnRadioShowAll.Checked == true)
            {
                rbtnRadioShowInStock.Checked = false;
                rbtnRadioShowOutOfStock.Checked = false;
                populate();
            }
        }

        private void rbtnRadioShowInStock_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRadioShowInStock.Checked == true)
            {
                rbtnRadioShowAll.Checked = false;
                rbtnRadioShowOutOfStock.Checked = false;
                populate();
            }

        }

        private void rbtnRadioShowOutOfStock_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRadioShowOutOfStock.Checked == true)
            {
                rbtnRadioShowInStock.Checked = false;
                rbtnRadioShowAll.Checked = false;
                populate();

            }
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grid.Count; i++)
            {
                if (grid[i].Name.Contains(txtBoxSearch.Text))
                {
                    populate();
                }
            }
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

        private void populate()
        {
            dataGridInventory.Rows.Clear();

            foreach (Inventory i in grid.Where(x => (x.Qty > 0 || !rbtnRadioShowInStock.Checked) && (x.Qty == 0 || !rbtnRadioShowOutOfStock.Checked)))
            {
                int row = dataGridInventory.Rows.Add();
                using (var r = dataGridInventory.Rows[row])
                {
                    r.Cells["ItemId"].Value = i.Id;
                    r.Cells["ItemDesc"].Value = i.Name;
                    r.Cells["CLASS"].Value = i.ItemType;
                    r.Cells["InvCount"].Value = i.Qty;
                    r.Cells["SUPPLIER"].Value = i.SupplierID;
                    r.Cells["SalesPrice"].Value = i.Price;
                }
            }
        }

        private void dataGridInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
