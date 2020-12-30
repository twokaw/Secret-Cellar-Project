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
    public partial class frmLookup : ManagedForm
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
            cbxSupplyFilter.Items.Add("");
            cbxSupplyFilter.Items.AddRange((string[])suppliers.Select(x => x.Name).ToArray());
            cbxTypeFilter.Items.Add("");
            cbxTypeFilter.Items.AddRange((string[])types.Select(x => x.TypeName).ToArray());
            
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
                cboType.Text = types.First(x => x.TypeId == i.TypeID).TypeName;
                txtBarcode.Text = i.Barcode;
                txtPrice.Text = i.Price.ToString();
                cbo_Supplier.Text = suppliers.First(x => x.SupplierID == i.SupplierID).Name;
                txtNetPrice.Text = i.SupplierPrice.ToString();
                txtProd_Qty.Text = i.Bottles.ToString();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (LookupView.SelectedRows.Count > 0)
            {
                Inventory i = inventory.First(x => x.Id == uint.Parse(LookupView.SelectedRows[0].Cells["id"].Value.ToString()));

                i.Name = txtName.Text;
                i.Barcode = txtBarcode.Text;


                if (!uint.TryParse(txt_qty.Text, out uint qty))
                {
                    txt_qty.Focus();
                    txt_qty.SelectAll();
                    MessageBox.Show("Invalid Quantity");
                    return;
                }

                if (!double.TryParse(txtNetPrice.Text, out double netprice))
                {
                    txtNetPrice.Focus();
                    txtNetPrice.SelectAll();
                    MessageBox.Show("Invalid Supply Price");
                    return;
                }

                // find the inventory price object
                InventoryQty inventoryQty = i.AllQty.FirstOrDefault(x => x.SupplierPrice == netprice);

                // if it is not found then create it and add it
                if (inventoryQty == null)
                {
                    inventoryQty = new InventoryQty
                    {
                        Qty = 0,
                        SupplierPrice = netprice,
                        PurchasedDate = DateTime.Now
                    };

                    i.AllQty.Add(inventoryQty);
                }

                // if the supply price is the same and there is only 1 supply price then we can just set the qty
                if (i.AllQty.Count == 1 && i.AllQty[0].SupplierPrice == netprice)
                    inventoryQty.Qty = qty;

                // New inventory was added to the specific supply price.  Items of this price are now the default price
                else if (i.Qty < qty)
                {
                    inventoryQty.Qty += qty - i.Qty;
                    inventoryQty.PurchasedDate = DateTime.Now;
                }

                // The Qty was written off
                else if (i.Qty > qty)
                {
                    qty = i.Qty - qty;
                    foreach (InventoryQty iq in i.AllQty.OrderBy(x => x.PurchasedDate).ToArray())
                    {
                        if (iq.Qty >= qty)
                        {
                            iq.Qty -= qty;
                            break;
                        }
                        else
                        {
                            qty -= iq.Qty;
                            iq.Qty = 0;
                        }
                    }
                }

                if (double.TryParse(txtPrice.Text, out double price)) i.Price = price;
                else
                {
                    txtPrice.Focus();
                    txtPrice.SelectAll();
                    MessageBox.Show("Invalid Price");
                    return;
                }
                if (uint.TryParse(txtProd_Qty.Text, out uint product)) i.Bottles = product;
                else
                {
                    txtProd_Qty.Focus();
                    txtProd_Qty.SelectAll();
                    MessageBox.Show("Invalid Product Quantity");
                    return;
                }

                i.ItemType = cboType.Text;
                i.TypeID = types.First(x => x.TypeName == cboType.Text).TypeId;
                i.SupplierID = suppliers.First(x => x.Name == cbo_Supplier.Text).SupplierID;
                dataAccess.UpdateItem(i);
                refresh();
            }

        }
        private void refresh()
        {
            LookupView.DataSource = inventory.Where(x =>( x.Name.IndexOf(txtlookup.Text, StringComparison.OrdinalIgnoreCase) >= 0 || x.Barcode.IndexOf(txtlookup.Text, StringComparison.OrdinalIgnoreCase) >=0)
            && (cbxTypeFilter.Text == "" || cbxTypeFilter.Text == x.ItemType) 
            && (cbxSupplyFilter.Text == "" || suppliers.First (s => s.Name ==cbxSupplyFilter.Text).SupplierID == x.SupplierID)).
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
                Inventory i = inventory.FirstOrDefault(x => x.Barcode == txtBarcode.Text);

                if (i == null)
                    i = new Inventory();
                else
                {
                    txtBarcode.Focus();
                    txtBarcode.SelectAll();
                    MessageBox.Show("Barcode already used");
                    return;
                }

                i.Name = txtName.Text;
                i.Barcode = txtBarcode.Text;

                if (!uint.TryParse(txt_qty.Text, out uint qty))
                {
                    txt_qty.Focus();
                    txt_qty.SelectAll();
                    MessageBox.Show("Invalid Quantity");
                    return;
                }

                if (!double.TryParse(txtNetPrice.Text, out double netprice))
                {
                    txtNetPrice.Focus();
                    txtNetPrice.SelectAll();
                    MessageBox.Show("Invalid Supply Price");
                    return;
                }

                i.AllQty.Add(new InventoryQty
                {
                    Qty = qty,
                    SupplierPrice = netprice,
                    PurchasedDate = DateTime.Now
                });

                if (double.TryParse(txtPrice.Text, out double price)) i.Price = price;
                else
                {
                    txtPrice.Focus();
                    txtPrice.SelectAll();
                    MessageBox.Show("Invalid Price");
                    return;
                }
                if (uint.TryParse(txtProd_Qty.Text, out uint product)) i.Bottles = product;
                else
                {
                    txtProd_Qty.Focus();
                    txtProd_Qty.SelectAll();
                    MessageBox.Show("Invalid Product Quantity");
                    return;
                }
                i.ItemType = cboType.Text;
                i.TypeID = types.First(x => x.TypeName == cboType.Text).TypeId;
                i.SupplierID = suppliers.First(x => x.Name == cbo_Supplier.Text).SupplierID;

                i.Id = dataAccess.InsertItem(i);
                inventory.Add(i);
                refresh();
            }
        }

        private void txtBtl_Deposit_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btl_Dep_Lb_Click(object sender, EventArgs e)
        {

        }

        private void txtNetPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void LookupView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbxTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxSupplyFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void cbxOnlyItemsWithInventory_CheckedChanged(object sender, EventArgs e)
        {
            //WHEN THE CHECKBOX IS CHECKED CALL THE REFRESH CODE BUT ADD 'WHERE QTY DOES NOT EQUAL 0'
            if (cbxOnlyItemsWithInventory.Checked) {
                LookupView.DataSource = inventory.Where(x => (x.Name.IndexOf(txtlookup.Text, StringComparison.OrdinalIgnoreCase) >= 0 || x.Barcode.IndexOf(txtlookup.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                && (cbxTypeFilter.Text == "" || cbxTypeFilter.Text == x.ItemType)
                && (cbxSupplyFilter.Text == "" || suppliers.First(s => s.Name == cbxSupplyFilter.Text).SupplierID == x.SupplierID)).
                    Select(x => new { Name = x.Name, Id = x.Id, ItemType = x.ItemType, Qty = x.Qty, Barcode = x.Barcode, Price = x.Price }).
                    Where(x => x.Qty != 0).
                    OrderBy(x => x.Name).
                    ToList();
            }

            //OTHERWISE JUST REFRESH LIKE NORMAL TO BRING ALL THE ITEMS IN
            else {
                refresh();
			}
		}

        private void frmLookup_Load(object sender, EventArgs e)
        {

        }
    }
}
