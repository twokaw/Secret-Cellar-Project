using NCR_Printer;
using Shared;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace SecretCellar
{
    public partial class frmTransaction : ManagedForm
    {
        private Transaction transaction;
        private Identification Id;
        private Customer CurrentCustomer = null;
        private Image Logo = null;

        public frmTransaction()
        {
            InitializeComponent();


            txtBarcode.Focus();
            ReloadLogo();
            //this.Size = new System.Drawing.Size(1366, 768);
            label_currentCustomerValue.Text = "";

            string path = Properties.Settings.Default.FontPath;
            if (path.Length > 0 && path[0] == '.')
                path = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}{path.Substring(1)}";
            Logo = DataAccess.instance.ImportLogo();
            PrintLayout receiptLayout = new PrintLayout()
            {
                Header = Properties.Settings.Default.Header,
                Footer = Properties.Settings.Default.Footer,
                Logo = Logo,
                FontDirectory = path,
                BarcodeName = Properties.Settings.Default.BarcodeFont,
                BarcodeFontSize = Properties.Settings.Default.BarcodeSize,
                FontName = Properties.Settings.Default.ReceiptFont,
                FontSize = Properties.Settings.Default.ReceiptFontSize
            };

            PrintLayout letterLayout = new PrintLayout()
            {
                Width = 850,
                Height = 1100,
                Header = Properties.Settings.Default.Header,
                Footer = Properties.Settings.Default.Footer,
                Logo = Logo,
                FontDirectory = path,
                BarcodeName = Properties.Settings.Default.BarcodeFont,
                BarcodeFontSize = Properties.Settings.Default.BarcodeSize,
                FontName = Properties.Settings.Default.ReceiptFont,
                FontSize = Properties.Settings.Default.ReceiptFontSize
            };
       
            Receipt.DefaultLayout = receiptLayout;
            PurchaseOrder.LetterLayout = letterLayout;
            pic_susp.Visible = false;
            /*
             foreach(DataGridViewColumn  col in dataGridView1.Columns)
                 col.CellStyle = new DataGridViewCellStyle { BackColor = Color.Purple, SelectionBackColor = Color.Purple , Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Bold), Alignment = DataGridViewContentAlignment.MiddleCenter };
            */

            dataGridView1.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.Purple, SelectionBackColor = Color.Purple, Font = new Font("Microsoft Sans Serif", 11f, System.Drawing.FontStyle.Bold), Alignment = DataGridViewContentAlignment.MiddleCenter };
            // dataGridView1.Refresh();
        }

        private void ReloadLogo()
        {
            DataAccess.instance.AddPictureBox(pictureBox1);
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            UserLogin();

            // lbl_twentyone.Text = $"21 AS OF: {DateTime.Now.AddYears(-21):MM/dd/yy}";
            lbl_twentyone.Font = new Font("Microsoft Sans Serif", 16, System.Drawing.FontStyle.Bold);
            transaction = CreateTransaction();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            frmDiscount discount = new frmDiscount(transaction); //instantiates frmDiscount using discount
            discount.ShowDialog();
            RefreshDataGrid();// opens form associated with discount instantiation
            txtBarcode.Focus();
        }

        private void Tender()
        {
            txtBarcode.Focus();
            if (transaction.Items.Count > 0 || CurrentCustomer != null) {

                if(!CheckAge(Id) && DialogResult.No == MessageBox.Show($"Is patron over the age of { AgeCheckRequire()}"))
                {
                    return;
                }

                frmPayment payment = new frmPayment(transaction);

                if (payment.ShowDialog() == DialogResult.OK) {
                    try 
                    {
                        DataAccess.instance.ProcessTransaction(transaction);
                    }
                    catch (Exception ex) {
                        MessageBox.Show($"Error writing to the database\n Error:\n {ex.Message}");
                        DataAccess.instance.LogError(ex, "btnTender_Click", "Error writing to the database");
                    }

                    if (transaction.Payments.FirstOrDefault(x => x.Method == "CASH" || x.Method == "CHECK") != null || payment.Change > 0.0 && !transaction.ChangetoCredit)
                        DataAccess.instance.OpenCashDrawer();

                    Customer customer = null;
                    if (transaction.CustomerID > 0)
                        customer = DataAccess.instance.GetCustomer(transaction.CustomerID);

                    if (payment.Change > 0.0) {
                        if (transaction.ChangetoCredit) {
                            customer.Credit += payment.Change;
                            DataAccess.instance.UpdateCustomer(customer);
                        }
                        else
                            MessageBox.Show($"Change due to customer:\n\n {payment.Change:C}", "Change");
                    }

                    if (payment.PrintReceipt) {
                        Receipt.DefaultLayout.Logo = DataAccess.instance.ImportLogo();
                        new Receipt(transaction, customer).Print();
                    }

                    CurrentCustomer = null;
                    lbl_CreditValue.Visible = false;
                    lbl_Credit.Visible = false;
                    //transaction complete, clear the form
                    transaction = CreateTransaction();
                    transaction.EnableBulkDiscount = caseDiscount.Checked;
                    label_currentCustomerValue.Text = "d";
                    RefreshDataGrid();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex > -1)
            {
                QuantityChange qtychange = new QuantityChange(int.Parse(dataGridView1?.Rows[e.RowIndex]?.Cells["QTY"]?.Value.ToString()));

                if (qtychange.ShowDialog() == DialogResult.OK)
                {
                    Item i = transaction.Items.FirstOrDefault(x => x.Id == uint.Parse(dataGridView1.Rows[e.RowIndex]?.Cells["ItemID"]?.Value.ToString()));
                    i.QtySold = (uint)qtychange.UpdatedQty;
                    transaction.GetQualifiedBulkDiscounts();
                }  
                
                RefreshDataGrid();
                txtBarcode.Focus();
            }
            else
            {
                txtBarcode.Focus();
            }
        }

        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();

            List<InventoryType> types = DataAccess.instance.GetInventoryType();
            List<Tax> taxes = DataAccess.instance.GetTax();
            double transactionBottleDeposit = 0.0;

            foreach (Item item in transaction.Items)
            {
                InventoryType inventoryType = types.Find((t) => item.ItemType == t.TypeName);
                Tax tax = null;

                if (inventoryType != null) {
                    tax = taxes.Find((t) => { return inventoryType.IdTax == t.IdTax; });
                }

                double taxBottleDeposit = tax != null ? tax.BottleDeposit : 0;
                double bottleDeposit = (item.NumSold * item.Bottles * taxBottleDeposit);
                double itemPrice = item.DiscountPrice > 0 ? item.DiscountPrice : (item.Price * (1 - item.Discount));

                int row = dataGridView1.Rows.Add();
                using (var r = dataGridView1.Rows[row])
                {
                    // Populate tranaction datagrid row
                    r.Cells["Description"].Value = item.Name;
                    r.Cells["Discount"].Value = item.DiscountPrice > 0 ? "0%" : (Math.Floor(transaction.ItemDiscount(item) * 100) / 100).ToString("P0");  //item.Discount.ToString("P0");
                    r.Cells["List_Price"].Value = item.Price.ToString("C");
                    r.Cells["Sale_Price"].Value = itemPrice.ToString("C");
                    r.Cells["Qty"].Value = item.NumSold;
                    r.Cells["Total"].Value = (itemPrice * item.NumSold + bottleDeposit).ToString("C");
                    r.Cells["BOTTLE_DEPOSIT"].Value = bottleDeposit.ToString("C");
                    r.Cells["ItemID"].Value = item.Id;

                    transactionBottleDeposit += item.NumSold * item.Bottles * taxBottleDeposit;
                }
            }

            // Populate subtotal box
            txt_itemTotal.Text = transaction.ItemTotal.ToString("C");
            txt_transSubTotal.Text = transaction.Subtotal.ToString("C");
            txt_transBTLDPT.Text = transactionBottleDeposit.ToString("C");
            txt_transTax.Text = (transaction.Tax + transaction.LocalTax).ToString("C");
            txt_transDiscount.Text = transaction.DiscountTotal.ToString("C");
            txt_TransTotal.Text = transaction.Total.ToString("C");

            if (transaction.CustomerID >= 0) {
                if (transaction.CustomerID == 0) { 
                    label_currentCustomerValue.Text = "N/A";
                    lbl_Credit.Visible = false;
                    lbl_CreditValue.Visible = false;
                }
                else 
                {
                    if((CurrentCustomer?.CustomerID ?? -1.0) != transaction.CustomerID)
                        CurrentCustomer = DataAccess.instance.GetCustomer(transaction.CustomerID);

                    label_currentCustomerValue.Text = $"{CurrentCustomer.LastName}, {CurrentCustomer.FirstName}";
                    lbl_CreditValue.Visible = CurrentCustomer.Credit != 0.0;
                    lbl_Credit.Visible = CurrentCustomer.Credit != 0.0;

                    if (CurrentCustomer.Credit != 0.0)
                    {
                        lbl_CreditValue.Text = $"{CurrentCustomer.Credit:c2}";
                        lbl_CreditValue.ForeColor = (CurrentCustomer.Credit < 0.0) ? Color.DarkRed : Color.Blue;
                    }
                }
            }
            CheckAge(Id);
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string name = dataGridView1.SelectedRows[0].Cells["DESCRIPTION"].Value.ToString();
                uint qty = uint.Parse(dataGridView1.SelectedRows[0].Cells["QTY"].Value.ToString());
                Item i = transaction.Items.First(x => x.Name == name && x.NumSold == qty);
                transaction.Items.Remove(i);
                transaction.GetQualifiedBulkDiscounts();
                RefreshDataGrid();
                txtBarcode.Focus();
            }
        }

        private void btnDryClean_Click(object sender, EventArgs e)
        {   
           // frmDryCleaning dryCleaning = new frmDryCleaning(transaction);
            frmCustom dryCleaning = new frmCustom(transaction, "SERVICE", "Dry Cleaning");
            dryCleaning.ShowDialog();
            RefreshDataGrid();
            txtBarcode.Focus();
        }

        private void txtBarcode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && !string.IsNullOrWhiteSpace(txtBarcode.Text)) {
                Customer customer = DataAccess.instance.GetCustomerByPhone(txtBarcode.Text.Trim());

                if (customer != null) {
                    transaction.CustomerID = customer.CustomerID;
                    RefreshDataGrid();
                }
                else {
                    Identification id = Identification.CheckId(txtBarcode.Text);
                    
                    if (id != null)
                    {
                        CheckAge(id);
                    }
                    else
                    {
                        Inventory i = DataAccess.instance.GetItem(txtBarcode.Text.Trim());
                        if (i != null) {
                            transaction.Add(i);
                            RefreshDataGrid();
                        }
                        else
                        {
                            DataAccess.instance.ShowLookupFormWithBarcode(transaction, txtBarcode.Text.Trim());
                            RefreshDataGrid();
                        }
                    }
                }

                txtBarcode.Clear();
            }
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
			DataAccess.instance.ShowLookupForm(transaction, "Add to Cart", txtBarcode.Text);
			RefreshDataGrid();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            frmEvents events = new frmEvents(transaction);

            events.ShowDialog();
            RefreshDataGrid();
            txtBarcode.Focus();
        }

        private void btnShipping_Click(object sender, EventArgs e)
        {
            frmCustom shipping = new frmCustom(transaction, "SERVICE", "Shipping");

            shipping.ShowDialog();
            RefreshDataGrid();
            txtBarcode.Focus();
        }

        private void btnVoidTrx_Click(object sender, EventArgs e) {
            //ENSURE THAT THE TRANSACTION DOESN'T HAVE PAYMENTS STILL
            if (transaction.Payments.Count > 0) 
            {
                MessageBox.Show("Cannot void transaction. There are still outstanding payments.", "Error");
                return;
            }

            if (transaction.TranType == Transaction.TranactionType.Suspended) 
            {
                if (frmManagerOverride.DidOverride("Void Suspended Transaction")) 
                    VoidTransaction();
            }
            else 
            {
                VoidTransaction();
            }
        }

        private void VoidTransaction() {
            //PROCESS THE TRANSACTION IN CASE THE USER DELETED ANY PAYMENTS
            uint transactionId = DataAccess.instance.ProcessTransaction(transaction);

            //DELETE THE TRANSACTION FROM THE DATABASE
            DataAccess.instance.DeleteTransaction(transactionId);

            transaction = CreateTransaction();
            label_currentCustomerValue.Text = "";
            RefreshDataGrid();
            txtBarcode.Focus();
        }

        private void dataGridView1_Click(object sender, EventArgs e) =>
            txtBarcode.Focus();

        private void dataGridView1_RowsAdded(object sender, EventArgs e)
        {
            //IF THE COUNT IS BIGGER THAN 0 SHOW THE SUSPEND TRANSACTION BUTTON
            if (transaction.Items.Count > 0)
            {
                pic_susp.Visible = true;
            }
        }

        private void dataGridView1_RowsRemoved(object sender, EventArgs e)
        {
            //IF THE COUNT EQUALS 0 HIDE THE SUSPEND TRANSACTION BUTTON
            if (transaction.Items.Count == 0)
            {
                pic_susp.Visible = false;
            }
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            frmCustom customItem = new frmCustom(transaction);

            customItem.ShowDialog();
            RefreshDataGrid();
            txtBarcode.Focus();
        }

        private void pb_settings_Click(object sender, EventArgs e)
        {
            FrmSettings setting = new FrmSettings();
            setting.ShowDialog();
        }

        private void btnSuspendedTransactions_Click(object sender, EventArgs e)
        {
            frmSuspendedTransactions suspendedTransactions = new frmSuspendedTransactions(this, transaction);
            suspendedTransactions.ShowDialog();
        }

        private void SuspendTransaction() {
            if (transaction.TranType == Transaction.TranactionType.Closed)
                transaction.TranType = Transaction.TranactionType.Suspended;

            //REMOVE ANY COUPONS BEFORE PROCESSING SO IT DOESN'T CREATE A SECOND SUSPENDED TRANSACTION
            for (int i=transaction.Items.Count-1; i>=0; i--) {
                Item item = transaction.Items[i];

                if (item.Name == "Coupon") {
                    transaction.Items.RemoveAt(i);
                }
			}

            //PROCESS THE TRANSACTION TO SUSPEND IT
            DataAccess.instance.ProcessTransaction(transaction);

            transaction = CreateTransaction();
            
            Clear();

            //HIDE THE SUSPEND TRANSACTION BUTTON
            pic_susp.Visible = false;

            //CLEAR THE CURRENT CUSTOMER
            label_currentCustomerValue.Text = "";
        }

        public void ImportTransaction(Transaction newTransaction)
        {
            transaction.Items.Clear();

            Clear();
            transaction = newTransaction;
            caseDiscount.Checked = transaction.EnableBulkDiscount;
        }
        private void Clear()
        {

            //CLEAR WHATEVER WAS IN THE TRANSACTION ALREADY
            dataGridView1.Rows.Clear();

            //RESET ALL THE TOTALS
            txt_transSubTotal.Text = "$0.00";
            txt_transBTLDPT.Text = "$0.00";
            txt_itemTotal.Text = "$0.00";
            txt_transTax.Text = "$0.00";
            txt_transDiscount.Text = "$0.00";
            txt_TransTotal.Text = "$0.00";

            RefreshDataGrid();
            ClearAge();
        }

        private void button_Invoices_Click(object sender, EventArgs e) {
            frmInvoices frmInvoices = new frmInvoices(this);
            frmInvoices.ShowDialog();
        }

        private void caseDiscount_CheckedChanged(object sender, EventArgs e)
        {
            transaction.EnableBulkDiscount = caseDiscount.Checked;
            RefreshDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer(transaction); //instantiates frmCustomer using Lookup
            customer.ShowDialog(); // opens form associated with Lookup instantiation
            RefreshDataGrid();
            txtBarcode.Focus();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            //frmOrders order = new frmOrders(transaction);
            //order.ShowDialog();

            //frmOrdersPanels ordersPanels = new frmOrdersPanels();
            //ordersPanels.ShowDialog();
            DataAccess.instance.ShowOrdersForm();
        }

        private void frmTransaction_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_signout_Click(object sender, EventArgs e) 
        {
            UserLogin();
        }

        public void UserLogin()
        {
            this.Visible = false;
            frmLogin login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                lbl_emp_logged_on.Text = DataAccess.currentUser.ToString();
                //ApplyUserAccess(); //Don't need to disable buttons since manager override exists.
                this.Visible = true;
            }
            else
            {
                this.Dispose();
            }
        }

        private void ApplyUserAccess()
        {
            // Lookup -- Lookup give you the ability to lookup items
            btnLookup.Enabled = DataAccess.instance.EmployeeAccess("Lookup");

            // Employee Admin -- Employee Admin give you the ability to add, delete, modify and change permissions for any employee
            /* This is in the Setting Form */

            // Cash Drawer -- Cash drawer give the ability to open the cash drawer at any time
            btn_cashDrawer.Enabled = DataAccess.instance.EmployeeAccess("Cash Drawer");

            // Orders --  Orders gives you access to Customer and Vendor orders
            btn_order.Enabled = DataAccess.instance.EmployeeAccess("Orders");

            // Event -- Event gives you the ability to modify events
            btnEvents.Enabled = DataAccess.instance.EmployeeAccess("Event");

            // Shipping  -- Shipping give you the ability to add shipping to an order
            btnShipping.Enabled = DataAccess.instance.EmployeeAccess("Shipping");

            // Custom -- Custom gives you the ability to add a custom item to a transaction
            btnCustom.Enabled = DataAccess.instance.EmployeeAccess("Custom");

            // Discount - Discount gives you the ability to add discounts to a transaction
            btnDiscount.Enabled = DataAccess.instance.EmployeeAccess("Discount");

            // Customer -- Customer give you the ability to add and edit customers
            /* This is in the Setting Form */

            // Settings -- Settings gives you access to hardware changes and other preferences
            pb_settings.Enabled = DataAccess.instance.EmployeeAccess("Settings");

            // Invoice -- Ability to create Invoices
            /* Is in the Orders Form and the Invoices Form */
        }

        private void btn_cashDrawer_Click(object sender, EventArgs e)
        {
            if (frmManagerOverride.DidOverride("Open Cash Drawer")) DataAccess.instance.OpenCashDrawer();
        }

        private void btnSuspend_Click(object sender, EventArgs e)
        {
            frmSuspendedTransactions suspendedTransactions = new frmSuspendedTransactions(this, transaction);
            suspendedTransactions.ShowDialog();
        }

        private void pic_susp_Click(object sender, EventArgs e)
        {
            SuspendTransaction();
        }

        private void pic_susp_MouseHover(object sender, EventArgs e)
        {
            pic_susp.Image = ImgLstTenderButton.Images[3];
        }

        private void pic_susp_MouseLeave(object sender, EventArgs e)
        {
            pic_susp.Image = ImgLstTenderButton.Images[2];
        }

        private void pic_transaction_Click(object sender, EventArgs e)
        {
            Tender();
        }

        private void pic_transaction_MouseHover(object sender, EventArgs e)
        {
            pic_transaction.Image = ImgLstTenderButton.Images[1];  
        }

        private void pic_transaction_MouseLeave(object sender, EventArgs e)
        {
            pic_transaction.Image = ImgLstTenderButton.Images[0]; 
        }

        private Transaction CreateTransaction()
        {
            ClearAge();
            return new Transaction()
            {
                EnableBulkDiscount = caseDiscount.Checked
            };
        }
        private void  ClearAge()
        {
            lbl_twentyone.Text = "";
            Id = null;
        }

        private bool CheckAge(int age = -1)
        {
            if (age < 0) 
                age = AgeCheckRequire();

            if (age > 0)
            {
                lbl_twentyone.Text = $"Verify age over {age}: {DateTime.Now.AddYears(-age):MM/dd/yy}";
                lbl_twentyone.ForeColor = Color.Firebrick;
                return false;
            }
            else
                lbl_twentyone.Text = "";
            return true;
        }

        private bool CheckAge(Identification id, int age = -1)
        {
            bool result = false;
            if (age < 0)
                age = AgeCheckRequire();

            Id = id;

            if (Id == null)
                result = CheckAge(age);
            else
            {
                Id.AgeRequirement = age;

                if ( Id.Underage)
                { 
                    lbl_twentyone.Text = $"Invalid - Under Age";
                    lbl_twentyone.ForeColor = Color.Firebrick;
                }

                else if (Id.Expired)
                { 
                    lbl_twentyone.Text = $"Invalid - Expired Licence";
                    lbl_twentyone.ForeColor = Color.Firebrick; 
                }

                else if (Id.Valid)
                {
                    lbl_twentyone.Text = $"Legal Age";
                    lbl_twentyone.ForeColor = Color.DarkGreen;
                    return true;
                }
                else
                    result = CheckAge(age);
            }
            return result;
        }

        int AgeCheckRequire()
        {
            if(transaction == null || transaction.Items.Count == 0) 
                return 0;
            else
                return transaction.Items.Max(x => (x.ItemType == "WINE" || x.ItemType == "BEER" || x.ItemType == "LIQUOR") ? 21 : (x.ItemType == "PROPANE" ? 18 : 0));
        }
    }
}