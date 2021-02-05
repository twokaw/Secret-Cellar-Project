using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using NCR_Printer;
using Shared;
using System.Collections.Generic;


namespace SecretCellar
{
    public partial class frmTransaction : ManagedForm
    {

        private Transaction transaction = new Transaction();
        
        private Image logo = null;

        public frmTransaction()
        {
            InitializeComponent();
            DataAccess.instance = new DataAccess(Properties.Settings.Default.URL);
            txtBarcode.Focus();
            ReloadLogo();
            this.Size = new System.Drawing.Size(1366, 768);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(72, 72);


            string path = Properties.Settings.Default.FontPath;
            if (path.Length > 0 && path[0] == '.')
                path = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}{path.Substring(1)}";


            Receipt.DefaultLayout = new PrintLayout()
            {
                Header = Properties.Settings.Default.Header,
                Footer = Properties.Settings.Default.Footer,
                Logo = logo,
                FontDirectory = path,
                BarcodeName = Properties.Settings.Default.BarcodeFont,
                BarcodeFontSize = Properties.Settings.Default.BarcodeSize,
                FontName = Properties.Settings.Default.ReceiptFont,
                FontSize = Properties.Settings.Default.ReceiptFontSize
            };
            btnSuspendTransaction.Visible = false;
        }

        private void ReloadLogo()
        {
            DataAccess.instance.AddPictureBox(pictureBox1);
            
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            frmLogin login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
            }
            else
            {
                this.Dispose();
            }

            
            lbl_twentyone.Text = "21 AS OF: " + DateTime.Now.AddYears(-21).ToString("MM/dd/yyyy");
            lbl_twentyone.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            frmDiscount discount = new frmDiscount(transaction); //instantiates frmDiscount using discount
            discount.ShowDialog();
            RefreshDataGrid();// opens form associated with discount instantiation
        }

        private void btnTender_Click(object sender, EventArgs e)
        {
            if (transaction.Items.Count == 0)
                openCashDrawer();
            else
            {
                frmPayment payment = new frmPayment(transaction);
                if (payment.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        DataAccess.instance.ProcessTransaction(transaction);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error writing to the database\n Error: \n {ex.Message}");
                    }

                    if (transaction.Payments.FirstOrDefault(x => x.Method == "CASH" || x.Method == "CHECK") != null)
                        openCashDrawer();

                    if (payment.PrintReceipt) {
                    Receipt.DefaultLayout.Logo = DataAccess.instance.ImportLogo();
                    new Receipt(transaction).Print();
                    }

                    //transaction complete, clear the form
                    transaction = new Transaction();
                    RefreshDataGrid();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarcode.Focus();
        }

        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();

            double transactionBottleDeposit = 0.0;
            foreach (Item item in transaction.Items)
            {
                int row = dataGridView1.Rows.Add();
                using (var r = dataGridView1.Rows[row])
                {
                    // Populate tranaction datagrid row
                    r.Cells["Description"].Value = item.Description;
                    r.Cells["Discount"].Value = item.Discount.ToString("P0");
                    r.Cells["Price"].Value = (item.Price * (1 - item.Discount)).ToString("C");
                    r.Cells["Qty"].Value = item.NumSold;
                    r.Cells["Total"].Value = (item.Price * item.NumSold * (1 - item.Discount)).ToString("C");
                    r.Cells["BOTTLE_DEPOSIT"].Value = (item.NumSold * item.Bottles * .05).ToString("C");

                    transactionBottleDeposit += item.NumSold * item.Bottles * .05;
                }
            }

            // Populate subtotal box
            txt_transSubTotal.Text = transaction.Subtotal.ToString("C");
            txt_transBTLDPT.Text = transactionBottleDeposit.ToString("C");
            txt_itemTotal.Text = transaction.Subtotal.ToString("C");
            txt_transTax.Text = (transaction.Tax + transaction.LocalTax).ToString("C");
            txt_transDiscount.Text = transaction.DiscountTotal.ToString("C");
            txt_TransTotal.Text = transaction.Total.ToString("C");
            txt_Ship.Text = transaction.Shipping.ToString("C");
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string desc = dataGridView1.SelectedRows[0].Cells["DESCRIPTION"].Value.ToString();
                uint qty = uint.Parse(dataGridView1.SelectedRows[0].Cells["QTY"].Value.ToString());
                Item i = transaction.Items.First(x => x.Description == desc && x.NumSold == qty);
                transaction.Items.Remove(i);
                RefreshDataGrid();
            }

        }

        private void btnDryClean_Click(object sender, EventArgs e)
        {
            frmDryCleaning dryCleaning = new frmDryCleaning(transaction);

            dryCleaning.ShowDialog();
            RefreshDataGrid();
        }

        private void txtBarcode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && !string.IsNullOrWhiteSpace(txtBarcode.Text))
            {
                Inventory i = DataAccess.instance.GetItem(txtBarcode.Text.Trim());
                if (i != null)
                {
                    transaction.Add(i);
                    RefreshDataGrid();
                }
                else
                    MessageBox.Show("Barcode not found");
                txtBarcode.Clear();
            }
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            frmLookup lookup = new frmLookup(transaction); //instantiates frmLookup using Lookup
            lookup.ShowDialog(); // opens form associated with Lookup instantiation
            RefreshDataGrid();
        }

        private void txt_TransTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            frmEvents events = new frmEvents(transaction);

            events.ShowDialog();
            RefreshDataGrid();
        }

        private void btnShipping_Click(object sender, EventArgs e)
        {
            frmShipping shipping = new frmShipping(transaction);

            shipping.ShowDialog();
            RefreshDataGrid();
        }

        private void btnVoidTrx_Click(object sender, EventArgs e)
        {
            transaction = new Transaction();
            RefreshDataGrid();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtBarcode.Focus();
        }

        private void dataGridView1_RowsAdded(object sender, EventArgs e)
        {
            //IF THE COUNT IS BIGGER THAN 0, MEANING AT LEAST
            //ONE ITEM IS SELECTED, THEN SHOW THE SUSPEND TRANSACTION BUTTON
            if (transaction.Items.Count > 0) {
                btnSuspendTransaction.Visible = true;
            }
        }

        private void dataGridView1_RowsRemoved(object sender, EventArgs e)
        {
            //IF THE COUNT EQUALS 0, MEANING NOTHING IS SELECTED
            //THEN HIDE THE SUSPEND TRANSACTION BUTTON
            if (transaction.Items.Count == 0) {
                btnSuspendTransaction.Visible = false;
            }
        }

        private void openCashDrawer()
        {
            try
            {
                if (SerialPort.GetPortNames().Contains(Properties.Settings.Default.CashDrawerPort))
                    new CashDrawer(Properties.Settings.Default.CashDrawerPort).OpenDrawer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPropane_Click(object sender, EventArgs e)
        {
            frmPropane propane = new frmPropane(transaction);

            propane.ShowDialog();
            RefreshDataGrid();
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            frmCustom customItem = new frmCustom(transaction);

            customItem.ShowDialog();
            RefreshDataGrid();
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

        private void btnSuspendTransaction_Click(object sender, EventArgs e)
        {
            //IF A CUSTOMER DOESN'T EXIST FOR THE TRANSACTION, POP UP THE MENU TO ASK, OTHERWISE USE THE CURRENT CUSTOMER
            if (transaction.CustomerName == null || transaction.CustomerName.Equals("")) {
                Customer customer;

                //CREATE A POP UP MENU FOR THE USER TO SEARCH THROUGH CUSTOMER NAMES
                frmSuspendedTransactionsNamePopUp popUp = new frmSuspendedTransactionsNamePopUp();
                popUp.ShowDialog();

                customer = popUp.customer;

                //IF THE USER CANCELS OUT OF THE FORM OR DOESN'T SELECT A NAME, END THE FUNCTION
                if (customer == null) {
                    return;
                }

                transaction.CustomerName = customer.FirstName + " " + customer.LastName;
                transaction.CustomerID = customer.CustomerID;
			}

            DataAccess.instance.ProcessTransaction(transaction);

            //CLEAR THE CURRENT TRANSACTION AND THE dataGridView1 SINCE THEY'RE NOW SUSPENDED
            dataGridView1.Rows.Clear();
            transaction = new Transaction();

            //RESET ALL THE TOTALS
            txt_transSubTotal.Text = "$0.00";
            txt_transBTLDPT.Text = "$0.00";
            txt_itemTotal.Text = "$0.00";
            txt_transTax.Text = "$0.00";
            txt_transDiscount.Text = "$0.00";
            txt_TransTotal.Text = "$0.00";
            txt_Ship.Text = "$0.00";

            dataGridView1_RowsRemoved(this, e);
        }

        public void importSuspendedTransaction(Transaction suspendedTransaction) {
            //CLEAR WHATEVER WAS IN THE TRANSACTION ALREADY
            dataGridView1.Rows.Clear();
            transaction.Items.Clear();

            //RESET ALL THE TOTALS
            txt_transSubTotal.Text = "$0.00";
            txt_transBTLDPT.Text = "$0.00";
            txt_itemTotal.Text = "$0.00";
            txt_transTax.Text = "$0.00";
            txt_transDiscount.Text = "$0.00";
            txt_TransTotal.Text = "$0.00";
            txt_Ship.Text = "$0.00";

            transaction = suspendedTransaction;

            RefreshDataGrid();
        }

        private void caseDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (caseDiscount.Checked == true)
            {
                System.Windows.Forms.MessageBox.Show("Case Discounts Applied!");
            }
        }

        private void lbl_BARCODE_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_twentyone_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer(transaction); //instantiates frmCustomer using Lookup
            customer.ShowDialog(); // opens form associated with Lookup instantiation
            RefreshDataGrid();
        }
    }
}