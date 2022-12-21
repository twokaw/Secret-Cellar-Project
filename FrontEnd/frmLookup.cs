﻿using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SecretCellar
{
    public partial class frmLookup : ManagedForm
    {
        private Transaction currentTransaction = null;
        private List<Supplier> suppliers = null;
        private List<InventoryType> types = null;
        private List<Discount> discounts = null;
        private string descriptionAndBarcodeSearchText = "Enter Description/Barcode";
        private bool refreshingItems = false;

        public frmLookup() {
            InitializeComponent();
            suppliers = DataAccess.instance.GetSuppliers();
            types = DataAccess.instance.GetInventoryType();
            discounts = DataAccess.instance.GetDiscount();
            txtlookup.Focus();

            RefreshInv();

            cbo_Supplier.DataSource = suppliers;
            cboType.DataSource = types;
            cbxSupplyFilter.Items.Add("");
            cbxSupplyFilter.Items.AddRange((string[])suppliers.Select(x => x.Name).ToArray());
            cbxTypeFilter.Items.Add("");
            cbxTypeFilter.Items.AddRange((string[])types.Select(x => x.TypeName).ToArray());


            foreach (Discount discount in discounts)
            {
                checkListBox_Discounts.Items.Add(discount.DiscountName);
                checkListBox_Discounts.SetItemChecked(checkListBox_Discounts.Items.Count - 1, false);
            }
        }

        public void SubmitButtonText(string value = "Add to Cart") { btn_add.Text = value; }

        public frmLookup(Transaction transaction) : base() { SetTransaction(transaction); }
        
        public void SetTransaction(Transaction transaction) { currentTransaction = transaction; }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (addCharge())
            {
                this.DialogResult = DialogResult.OK;
                txtlookup.Text = "";
                this.Close();
            }
        }

        private void button_Broken_Click(object sender, EventArgs e) {
            if (LookupView.SelectedRows.Count > 0) {
                Inventory i = DataAccess.instance.GetInventory().First(x => x.Id == uint.Parse(LookupView.SelectedRows[0].Cells["id"].Value.ToString()));

                i.Price = 0;
                i.BottleDeposit = 0;
                i.LocalSalesTax = 0;
                i.SalesTax = 0;

                currentTransaction.Add(i);

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
                Inventory i = DataAccess.instance.GetInventory().First(x => x.Id == uint.Parse(LookupView.SelectedRows[0].Cells["id"].Value.ToString()));

                currentTransaction.Add(i);
                return true;
            }
            return false;
        }


        private void textBox1_TextChanged(object sender, EventArgs e) { RefreshInv(); }


        private void LookupView_SelectionChanged(object sender, EventArgs e)
        {
            btn_update.Text = "Update Item";
            ToggleDeleteButton();

            if (!refreshingItems && LookupView.SelectedRows.Count > 0 )
            {
                Inventory i = DataAccess.instance.GetInventory().First(x => x.Id == uint.Parse(LookupView.SelectedRows[0].Cells["id"].Value.ToString()));
                txtName.Text = i.Name;
                txt_qty.Text = i.Qty.ToString();
                cboType.Text = types.First(x => x.TypeId == i.TypeID).TypeName;
                txtBarcode.Text = i.Barcode;
                txtPrice.Text = i.Price.ToString();
                currencyBox_discountPrice.Text = i.DiscountPrice.ToString();

                Supplier supplier = suppliers.FirstOrDefault(x => x.SupplierID == i.SupplierID);
                cbo_Supplier.Text = supplier != null? supplier.Name : "";
                txt_net_price.Text = i.SupplierPrice.ToString();
                txtProd_Qty.Text = i.Bottles.ToString();
                txt_markup.Text = ((i.Price - i.SupplierPrice) / i.SupplierPrice).ToString("P");
                txt_min_qty.Text = i.InvMin.ToString();
                txt_max_qty.Text = i.InvMax.ToString();
                txt_order_qty.Text = i.OrderQty.ToString();
                chk_hide_item.Checked = i.Hidden;

                // CLEAR ALL THE DISCOUNTS THAT ARE IN THE DISCOUNTS LIST ALREADY
                checkListBox_Discounts.Items.Clear();

                InventoryType type;
                //ADD EACH DISCOUNT OF THE MATCHED INVENTORY TYPE TO THE CHECK BOX LIST AND SET IT TO TRUE
                foreach (Discount discount in discounts)
                {
                    checkListBox_Discounts.Items.Add(discount.DiscountName);

                    if(i.Discounts.Exists(x=>x.DiscountName == discount.DiscountName))
                        checkListBox_Discounts.SetItemChecked(checkListBox_Discounts.Items.Count - 1, true);
                    /*
                    type = types.FirstOrDefault(x => x.TypeName == i.ItemType);

                    if (type?.Discount.FirstOrDefault(x => x.DiscountName == discount.DiscountName) != null)
                        checkListBox_Discounts.SetItemChecked(checkListBox_Discounts.Items.Count - 1, true);
                    */
                }
            }
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            if (btn_update.Text == "New Item")
            {
                if (frmManagerOverride.DidOverride("Create New Item")) {
                    New_item();
                    btn_update.Text = "Update Item";
                }
            }
            else if (LookupView.SelectedRows.Count > 0)
            {
                if (txtName.Text.Replace(" ", "") != "" && txtBarcode.Text.Replace(" ", "") != "") {
                    if (frmManagerOverride.DidOverride("Update Item")) {
                        Inventory i = DataAccess.instance.GetInventory().First(x => x.Id == uint.Parse(LookupView.SelectedRows[0].Cells["id"].Value.ToString()));

                        i.Name = txtName.Text.Trim();
                        i.Barcode = txtBarcode.Text.Trim();


                        if (!uint.TryParse(txt_qty.Text, out uint qty)) {
                            txt_qty.Focus();
                            txt_qty.SelectAll();
                            MessageBox.Show("Invalid Quantity");
                            return;
                        }

                        if (!double.TryParse(txt_net_price.Value.ToString(), out double netprice)) {
                            txt_net_price.Focus();
                            txt_net_price.SelectAll();
                            MessageBox.Show("Invalid Supply Price");
                            return;
                        }

                        // find the inventory price object
                        InventoryQty inventoryQty = i.AllQty.FirstOrDefault(x => x.SupplierPrice == netprice);

                        // if it is not found then create it and add it
                        if (inventoryQty == null) {
                            inventoryQty = new InventoryQty {
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
                        else if (i.Qty < qty) {
                            inventoryQty.Qty += qty - i.Qty;
                            inventoryQty.PurchasedDate = DateTime.Now;
                        }

                        // The Qty was written off
                        else if (i.Qty > qty) {
                            qty = i.Qty - qty;
                            foreach (InventoryQty iq in i.AllQty.OrderBy(x => x.PurchasedDate).ToArray()) {
                                if (iq.Qty >= qty) {
                                    iq.Qty -= qty;
                                    break;
                                }
                                else {
                                    qty -= iq.Qty;
                                    iq.Qty = 0;
                                }
                            }
                        }

                        if (double.TryParse(txtPrice.Value.ToString(), out double price)) i.Price = price;
                        else {
                            txtPrice.Focus();
                            txtPrice.SelectAll();
                            MessageBox.Show("Invalid Price");
                            return;
                        }

                        if (double.TryParse(currencyBox_discountPrice.Value.ToString(), out double discountPrice)) i.DiscountPrice = discountPrice;
                        else {
                            txtPrice.Focus();
                            txtPrice.SelectAll();
                            MessageBox.Show("Invalid Discount Price");
                            return;
                        }

                        if (uint.TryParse(txtProd_Qty.Text, out uint product)) i.Bottles = product;
                        else {
                            txtProd_Qty.Focus();
                            txtProd_Qty.SelectAll();
                            MessageBox.Show("Invalid Product Quantity");
                            return;
                        }

                        if (uint.TryParse(txt_min_qty.Text.Trim(), out uint min)) i.InvMin = min;
                        else {
                            txt_min_qty.Focus();
                            txtPrice.SelectAll();
                            MessageBox.Show("Invalid Minimum Quantity");
                            return;
                        }

                        if (uint.TryParse(txt_max_qty.Text.Trim(), out uint max)) i.InvMax = max;
                        else {
                            txt_max_qty.Focus();
                            txtPrice.SelectAll();
                            MessageBox.Show("Invalid Maximum Quantity");
                            return;
                        }

                        if (uint.TryParse(txt_order_qty.Text.Trim(), out uint order)) i.OrderQty = order;
                        else {
                            txt_min_qty.Focus();
                            txtPrice.SelectAll();
                            MessageBox.Show("Invalid Order Quantity");
                            return;
                        }
                        //i.InvMin = uint.Parse(txt_min_qty.Text.Trim());
                        //i.InvMax = uint.Parse(txt_max_qty.Text.Trim());
                        //i.OrderQty = uint.Parse(txt_order_qty.Text.Trim());
                        i.Hidden = chk_hide_item.Checked;

                        i.ItemType = cboType.Text;
                        i.TypeID = types.First(x => x.TypeName == cboType.Text).TypeId;
                        i.SupplierID = suppliers.First(x => x.Name == cbo_Supplier.Text).SupplierID;

                        i.Discounts.Clear();

                        foreach(string disc in checkListBox_Discounts.CheckedItems)
                            i.Discounts.Add(discounts.First(x => x.DiscountName == disc));
                        
                        DataAccess.instance.UpdateItem(i);

                        RefreshInv();
                    }
                }
                else {
                     MessageBox.Show("Name and Barcode cannot be empty.", "Error");
				}
            }
        }


        private void New_item()
        {
            //if (LookupView.SelectedRows.Count > 0)
           // {
                if (txtName.Text.Replace(" ", "") != "" && txtBarcode.Text.Replace(" ", "") != "") {
                    Inventory i = DataAccess.instance.GetInventory().FirstOrDefault(x => x.Barcode == txtBarcode.Text);

                    if (i == null)
                        i = new Inventory();
                    else {
                        txtBarcode.Focus();
                        txtBarcode.SelectAll();
                        MessageBox.Show("Barcode already used");
                        return;
                    }

                    i.Name = txtName.Text.Trim();
                    i.Barcode = txtBarcode.Text.Trim();

                    if (!uint.TryParse(txt_qty.Text, out uint qty)) {
                        txt_qty.Focus();
                        txt_qty.SelectAll();
                        MessageBox.Show("Invalid Quantity");
                        return;
                    }

                    if (!double.TryParse(txt_net_price.Text, out double netprice)) {
                        txt_net_price.Focus();
                        txt_net_price.SelectAll();
                        MessageBox.Show("Invalid Supply Price");
                        return;
                    }

                    i.AllQty.Add(new InventoryQty {
                        Qty = qty,
                        SupplierPrice = netprice,
                        PurchasedDate = DateTime.Now
                    });

                    if (double.TryParse(txtPrice.Text, out double price)) i.Price = price;
                    else {
                        txtPrice.Focus();
                        txtPrice.SelectAll();
                        MessageBox.Show("Invalid Price");
                        return;
                    }

                    if (double.TryParse(currencyBox_discountPrice.Text, out double discountPrice)) i.DiscountPrice = discountPrice;
                    else {
                        txtPrice.Focus();
                        txtPrice.SelectAll();
                        MessageBox.Show("Invalid Discount Price");
                        return;
                    }

                    if (uint.TryParse(txtProd_Qty.Text, out uint product)) i.Bottles = product;
                    else {
                        txtProd_Qty.Focus();
                        txtProd_Qty.SelectAll();
                        MessageBox.Show("Invalid Product Quantity");
                        return;
                    }
                    i.ItemType = cboType.Text;
                    i.TypeID = types.First(x => x.TypeName == cboType.Text).TypeId;
                    i.SupplierID = suppliers.First(x => x.Name == cbo_Supplier.Text).SupplierID;

                    if (uint.TryParse(txt_min_qty.Text.Trim(), out uint min)) i.InvMin = min;
                    else {
                        txt_min_qty.Focus();
                        txt_min_qty.SelectAll();
                        MessageBox.Show("Invalid Min Qty");
                        return;
                    }

                    if (uint.TryParse(txt_max_qty.Text.Trim(), out uint max)) i.InvMax = max;
                    else {
                        txt_max_qty.Focus();
                        txt_max_qty.SelectAll();
                        MessageBox.Show("Invalid Max Qty");
                        return;
                    }

                    //i.InvMax = uint.Parse(txt_max_qty.Text.Trim());
                    //i.OrderQty = uint.Parse(txt_order_qty.Text.Trim());

                    i.Id = DataAccess.instance.InsertItem(i);
                    
                }
                else {
                    MessageBox.Show("Name and Barcode cannot be empty.", "Error");
                }

            RefreshInv();
            // }
        }


        private void cbxTypeFilter_SelectedIndexChanged(object sender, EventArgs e) { RefreshInv(); }
        private void cbxSupplyFilter_SelectedIndexChanged(object sender, EventArgs e) { RefreshInv(); }
        private void cbxOnlyItemsWithInventory_CheckedChanged(object sender, EventArgs e) { RefreshInv(); }
        private void chk_box_show_hidden_CheckedChanged(object sender, EventArgs e) { RefreshInv(); }

        private void btn_clear_info_Click(object sender, EventArgs e)
        {
            btn_update.Text = "New Item";
            txtName.Text = "";
            cboType.SelectedIndex = 1;
            txtBarcode.Text = "";
            cbo_Supplier.SelectedIndex = 1;
            txt_qty.Text = "0";
            txtPrice.Text = "";
            currencyBox_discountPrice.Text = "";
            txt_net_price.Text = "";
            txtProd_Qty.Text = "0";
            txt_min_qty.Text = "0";
            txt_order_qty.Text = "0";
            txt_max_qty.Text = "0";
            chk_hide_item.Checked = false;
            txtName.Focus();
        }

		private void txtlookup_Enter(object sender, EventArgs e) {
            if (txtlookup.Text == descriptionAndBarcodeSearchText) {
                txtlookup.Text = "";
            }
        }

		private void txtlookup_Leave(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtlookup.Text)) {
                txtlookup.Text = descriptionAndBarcodeSearchText;
            }
        }

        public void RefreshInv() {
            if (LookupView != null)
            {
                refreshingItems = true;
                int quantity = cbxOnlyItemsWithInventory.Checked ? 0 : -1;

                LookupView.DataSource = DataAccess.instance.GetInventory()
                    .Where(x => (x.Name.IndexOf(txtlookup.Text, StringComparison.OrdinalIgnoreCase) >= 0
                              || x.Barcode.IndexOf(txtlookup.Text, StringComparison.OrdinalIgnoreCase) >= 0
                              || txtlookup.Text == descriptionAndBarcodeSearchText
                              || txtlookup.Text == "")
                    && (cbxTypeFilter.Text == "" || cbxTypeFilter.Text == x.ItemType)
                    && (cbxSupplyFilter.Text == "" || suppliers.First(s => s.Name == cbxSupplyFilter.Text).SupplierID == x.SupplierID)
                    && x.Hidden == chk_box_show_hidden.Checked).
                       Select(x => new
                       {
                           x.Name,
                           x.Id,
                           x.ItemType,
                           x.Qty,
                           x.Barcode,
                           Price = x.DiscountPrice > 0 ? x.DiscountPrice : x.Price,
                           x.InvMin,
                           x.InvMax,
                           x.OrderQty
                       }).
                       Where(x => x.Qty > quantity).
                       OrderBy(x => x.Name).
                       ToList();

                refreshingItems = false;
            }
        }

        private void LookupView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(btn_update.Text != "Update Item")
                LookupView_SelectionChanged(sender, null);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            txtlookup.Text = "";
            this.Close();
        }

		private void button_DeleteItem_Click(object sender, EventArgs e) {
            if (LookupView.SelectedRows.Count > 0 
            && frmManagerOverride.DidOverride("Delete Item")) {
                string barcode = LookupView.SelectedRows[0].Cells["Barcode"].Value.ToString();
                Inventory item = DataAccess.instance.GetItem(barcode);

                DataAccess.instance.DeleteItem(item);
            }
		}

        /// <summary>
        /// Looks through all the suspended transactions's items to see if any of the id's match the selected item's id.
        /// If it does, it disables the delete button.
        /// </summary>
        private void ToggleDeleteButton() {
            if (LookupView.SelectedRows.Count == 0) { return; }

            bool selectedItemIsInSuspendedTransaction = false;
            List<Transaction> suspendedTransactions = DataAccess.instance.GetSuspendedTransactions();

            if(suspendedTransactions != null)
            {
                foreach (Transaction suspendedTransaction in suspendedTransactions) 
                {
                    foreach (Item item in suspendedTransaction.Items) 
                    {
                        uint selectedItemId = uint.Parse(LookupView.SelectedRows[0].Cells["Id"].Value.ToString());

                        if (item.Id == selectedItemId) { selectedItemIsInSuspendedTransaction = true; break; }
                    }

                    if (selectedItemIsInSuspendedTransaction) break; 
                }
            }

            if (selectedItemIsInSuspendedTransaction) { button_DeleteItem.Enabled = false; }
            else { button_DeleteItem.Enabled = true; }
        }
	}
}
