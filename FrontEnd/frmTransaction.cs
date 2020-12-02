﻿using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web.UI;
using System.Windows.Forms;
using NCR_Printer;
using Shared;

namespace SecretCellar
{
    public partial class frmTransaction : Form
    {

        private Transaction transaction = new Transaction();
        private DataAccess dataAccess;
        private Image logo = null;
        public static DataGridViewRowCollection chosenItems;
        public frmTransaction()
        {
            InitializeComponent();
            txtBarcode.Focus();
            ReloadLogo();

            string path = Properties.Settings.Default.FontPath;
            if (path.Length > 0 && path[0] == '.')
                path =  $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}{path.Substring(1)}";


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

            if (!string.IsNullOrEmpty(Properties.Settings.Default.Logo))
            {
                string logoPath = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\{Properties.Settings.Default.Logo}";

                if(Directory.Exists(logoPath))
                    logo = Image.FromFile(logoPath);
            }

            if(logo == null)
                logo = Properties.Resources.Logo;
            pictureBox1.Image = logo;
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

            dataAccess = new DataAccess(Properties.Settings.Default.URL);
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            frmDiscount discount = new frmDiscount(transaction); //instantiates frmDiscount using discount
            discount.ShowDialog();
            addRow(transaction);// opens form associated with discount instantiation
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

                    if (payment.PrintReceipt) 
                        new Receipt(transaction).Print();

                    //transaction complete, clear the form
                    transaction = new Transaction();
                    addRow(transaction);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarcode.Focus();
        }

        private void addRow(Transaction trans)
        {
            dataGridView1.Rows.Clear();

            double transactionBottleDeposit = 0.0;
            foreach (Item item in trans.Items)
            {
                int row = dataGridView1.Rows.Add();
                using (var r = dataGridView1.Rows[row])
                {
                    // Populate tranaction datagrid row
                    r.Cells["Description"].Value = item.Description;
                    r.Cells["Discount"].Value =  item.Discount.ToString("P0");
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
                Item i =   transaction.Items.First(x => x.Description == desc  && x.NumSold == qty );
                transaction.Items.Remove(i);
                addRow(transaction);
            }

        }

        private void btnDryClean_Click(object sender, EventArgs e)
        {
            frmDryCleaning dryCleaning = new frmDryCleaning(transaction);
           
            dryCleaning.ShowDialog();
            addRow(transaction);
        }

        private void txtBarcode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && !string.IsNullOrWhiteSpace(txtBarcode.Text))
            {
                Inventory i = dataAccess.GetItem(txtBarcode.Text.Trim());
                if (i != null)
                {
                    Item item = transaction.Items.FirstOrDefault(x => x.Id == i.Id);
                    if (item == null)
                    {
                        transaction.Items.Add(DataAccess.ConvertInvtoItem(i));
                    }
                    else
                    {
                        item.NumSold++;
                    }
                    addRow(transaction);
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
            addRow(transaction);

        }

        private void txt_TransTotal_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            frmEvents events = new frmEvents(transaction);

            events.ShowDialog();
            addRow(transaction);
        }

        private void btnShipping_Click(object sender, EventArgs e)
        {
            frmShipping shipping = new frmShipping(transaction);

            shipping.ShowDialog();
            addRow(transaction);
        }

        private void btnVoidTrx_Click(object sender, EventArgs e)
        {
            transaction = new Transaction();
            addRow(transaction);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtBarcode.Focus();
        }

        private void dataGridView1_RowsAdded(object sender, EventArgs e)
		{
            //UPDATE THE STATIC 'chosenItems' field
            chosenItems = this.dataGridView1.Rows;

            //IF THE COUNT IS BIGGER THAN 0, MEANING AT LEAST
            //ONE ITEM IS SELECTED, THEN SHOW THE SUSPEND TRANSACTION BUTTON
            if (chosenItems.Count > 0) {
                btnSuspendTransaction.Visible = true;
            }
        }
        private void dataGridView1_RowsRemoved(object sender, EventArgs e)
		{
            //UPDATE THE STATIC 'chosenItems' field
            chosenItems = this.dataGridView1.Rows;

            //IF THE COUNT EQUALS 0, MEANING NOTHING IS SELECTED
            //THEN HIDE THE SUSPEND TRANSACTION BUTTON
            if (chosenItems.Count == 0) {
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPropane_Click(object sender, EventArgs e)
        {
            frmPropane propane= new frmPropane(transaction);

            propane.ShowDialog();
            addRow(transaction);
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            frmCustom customItem = new frmCustom(transaction);

            customItem.ShowDialog();
            addRow(transaction);
        }

        private void pb_settings_Click(object sender, EventArgs e)
        {
            FrmSetting setting= new FrmSetting();
            setting.ShowDialog();
        }

		private void btnSuspendedTransactions_Click(object sender, EventArgs e)
		{
            frmSuspendedTransactions suspendedTransactions = new frmSuspendedTransactions();
            suspendedTransactions.ShowDialog();
		}

		private void btnSuspendTransaction_Click(object sender, EventArgs e)
		{
            //CREATE A POP UP MENU FOR THE USER TO ENTER THE NAME OF THE TRANSACTION TO BE SUSPENDED
            frmSuspendedTransactionsNamePopUp popUp = new frmSuspendedTransactionsNamePopUp();
            popUp.ShowDialog();

            String transactionInfo = popUp.nameOfSuspendedTransaction + ";";

            //GET ALL THE SELECTED ITEMS INTO A STRING ARRAY TO SEND TO 'frmSuspendedTransactions'
            if (frmTransaction.chosenItems != null) {
                //LOOP THROUGH EACH OF THE 'chosenItems' ROWS IN THE TRANSACTION FORM
                for (int i=0; i<chosenItems.Count; i++) {
                    DataGridViewRow row = chosenItems[i];
                    
                    //FOR EACH CELL IN EACH ROW
                    for (int k=0; k<row.Cells.Count; k++) {
                        DataGridViewCell cell = row.Cells[k];

                        //ADD EACH CELL VALUE
                        if (cell.Value != null) {
                           if (k == row.Cells.Count-1) {
                                transactionInfo = transactionInfo + cell.Value.ToString();
                            }
                           else {
                                transactionInfo = transactionInfo + cell.Value.ToString() + ",";
						   }
                        }
                        else {
                            if (k == row.Cells.Count-1) {
                                transactionInfo = transactionInfo + " ";
                            }
                            else {
                                transactionInfo = transactionInfo + " ,";
                            }
                        }
                    }

                    transactionInfo = transactionInfo + ";";
                }
            }

            //UPDATE THE STRING ARRAYLIST FIELD IN 'frmSuspendedTransactions'
            frmSuspendedTransactions.suspendedTransactionsList.Add(transactionInfo);
        }
	}
}