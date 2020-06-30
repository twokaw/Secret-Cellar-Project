using SecretCellar;
using Shared;
using System;
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
    public partial class frmLookup : Form
    {
        private Transaction lookUp = null;
        private DataAccess dataAccess = new DataAccess(Properties.Settings.Default.URL);
        private List<Inventory> inventory = null;
        private List<Supplier> suppliers = null;
        private List<InventoryType> types = null;
        public frmLookup(Transaction transaction)
        {
            lookUp = transaction;
            InitializeComponent();
            inventory = dataAccess.GetInventory();
            suppliers = dataAccess.GetSuppliers();
            types = dataAccess.GetInventoryType();

            LookupView.DataSource = inventory.
                Select(x => new { Name = x.Name, Id = x.Id, ItemType = x.ItemType, Qty = x.Qty, Barcode = x.Barcode, Price = x.Price }).
                OrderBy(x => x.Name).
                ToList();

            cbo_Supplier.DataSource = suppliers;
            cboType.DataSource = types;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (addCharge())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool addCharge()
        {
            if (LookupView.SelectedRows.Count > 0)
            {
                Inventory i = inventory.First(x => x.Id == uint.Parse(LookupView.SelectedRows[0].Cells["id"].Value.ToString()));

                Item item = DataAccess.ConvertInvtoItem(i);
                lookUp.Items.Add(item);
                return true;
            }
            return false;
        }
        private void txtCharge_TextChanged(object sender, EventArgs e)
        {

        }

        private void populate()
        {



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //BindingSource dv = ((DataTable)LookupView.DataSource).DefaultView;
            //dv.RowFilter = $"Description like '%{txtlookup.Text}%'";


            //LookupView.DataSource = inventory.Where(x => x.Name.Contains(txtlookup.Text) || x.Barcode.Contains(txtlookup.Text)).
            //    Select(x => new { Name = x.Name, Id = x.Id, ItemType = x.ItemType, Qty = x.Qty, Barcode = x.Barcode, Price = x.Price }).ToList();

            refresh();
        }

        private void LookupView_SelectionChanged(object sender, EventArgs e)
        {


            if (LookupView.SelectedRows.Count > 0)
            {
                Inventory i = inventory.First(x => x.Id == uint.Parse(LookupView.SelectedRows[0].Cells["id"].Value.ToString()));
                txtName.Text = i.Name;
                txt_qty.Text = i.Qty.ToString();
                cboType.Text = i.ItemType;
                txtBarcode.Text = i.Barcode;
                txtPrice.Text = i.Price.ToString();
                cbo_Supplier.Text = suppliers.First(x=>x.SupplierID == i.SupplierID).Name;
                txtNetPrice.Text = i.SupplierPrice.ToString();



            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (LookupView.SelectedRows.Count > 0)
            {
                Inventory i = inventory.First(x => x.Id == uint.Parse(LookupView.SelectedRows[0].Cells["id"].Value.ToString()));
                i.Name= txtName.Text ;
                if (uint.TryParse(txt_qty.Text, out uint qty)) i.Qty= qty; 
                else 
                {
                    txt_qty.Focus();
                    txt_qty.SelectAll();
                    MessageBox.Show("Invalid Quantity");
                    return;
                }
               // i.ItemType = cboType.Text;
                i.TypeID = types.First(x => x.TypeName == cboType.Text).TypeId;
                dataAccess.UpdateItem(i);
                refresh();
            }
            
        }
        private void refresh()
        {
            LookupView.DataSource = inventory.Where(x => x.Name.Contains(txtlookup.Text) || x.Barcode.Contains(txtlookup.Text)).
               Select(x => new { Name = x.Name, Id = x.Id, ItemType = x.ItemType, Qty = x.Qty, Barcode = x.Barcode, Price = x.Price }).
               OrderBy(x => x.Name).
               ToList();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            if (LookupView.SelectedRows.Count > 0)
            {
                Inventory i = inventory.First(x => x.Id == uint.Parse(LookupView.SelectedRows[0].Cells["id"].Value.ToString()));
                i.Name = txtName.Text;
                i.Barcode = txtBarcode.Text;
                if (uint.TryParse(txt_qty.Text, out uint qty)) i.Qty = qty;
                else
                {
                    txt_qty.Focus();
                    txt_qty.SelectAll();
                    MessageBox.Show("Invalid Quantity");
                    return;
                }
                if (uint.TryParse(txtPrice.Text, out uint price)) i.RetailPrice = price;
                else
                {
                    txtPrice.Focus();
                    txtPrice.SelectAll();
                    MessageBox.Show("Invalid Price");
                    return;
                }
                if (uint.TryParse(txtNetPrice.Text, out uint netprice)) i.Price = netprice;
                else
                {
                    txtNetPrice.Focus();
                    txtNetPrice.SelectAll();
                    MessageBox.Show("Invalid Net Price");
                    return;
                }
                //i.ItemType = cboType.Text;
                i.TypeID = types.First(x => x.TypeName == cboType.Text).TypeId;
                i.SupplierID = suppliers.First(x => x.Name ==  cbo_Supplier.Text).SupplierID;

                dataAccess.InsertItem(i);
                refresh();
            }
        }
    }
}
