namespace SecretCellar
{
    partial class frmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabSales = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTransTotal = new SecretCellar.CurrencyBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTax = new SecretCellar.CurrencyBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTransNet = new SecretCellar.CurrencyBox();
            this.txtTransNonTax = new SecretCellar.CurrencyBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTransBottleDeposit = new SecretCellar.CurrencyBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgTrans = new System.Windows.Forms.DataGridView();
            this.colTransType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTransRun = new System.Windows.Forms.Button();
            this.tabPCustomer = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.dgCustomerOrders = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Customer_Total = new SecretCellar.CurrencyBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgCustomers = new System.Windows.Forms.DataGridView();
            this.dccol_Customer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Customer_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabTransactions = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTransDate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTransItems = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTransTotalValue = new SecretCellar.CurrencyBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTransId = new System.Windows.Forms.TextBox();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colTransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.btnOk = new System.Windows.Forms.Button();
            this.tabPage.SuspendLayout();
            this.tabSales.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrans)).BeginInit();
            this.tabPCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
            this.tabTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage
            // 
            this.tabPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPage.Controls.Add(this.tabSales);
            this.tabPage.Controls.Add(this.tabPCustomer);
            this.tabPage.Controls.Add(this.tabTransactions);
            this.tabPage.Controls.Add(this.tabOrders);
            this.tabPage.Location = new System.Drawing.Point(8, 8);
            this.tabPage.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(615, 350);
            this.tabPage.TabIndex = 0;
            // 
            // tabSales
            // 
            this.tabSales.Controls.Add(this.panel1);
            this.tabSales.Controls.Add(this.label7);
            this.tabSales.Controls.Add(this.dateTimePicker2);
            this.tabSales.Controls.Add(this.label6);
            this.tabSales.Controls.Add(this.dateTimePicker1);
            this.tabSales.Controls.Add(this.dgTrans);
            this.tabSales.Controls.Add(this.btnTransRun);
            this.tabSales.Location = new System.Drawing.Point(4, 27);
            this.tabSales.Margin = new System.Windows.Forms.Padding(2);
            this.tabSales.Name = "tabSales";
            this.tabSales.Padding = new System.Windows.Forms.Padding(2);
            this.tabSales.Size = new System.Drawing.Size(607, 319);
            this.tabSales.TabIndex = 0;
            this.tabSales.Text = "Sales";
            this.tabSales.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTransTotal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTax);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTransNet);
            this.panel1.Controls.Add(this.txtTransNonTax);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTransBottleDeposit);
            this.panel1.Location = new System.Drawing.Point(404, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 145);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total:";
            // 
            // txtTransTotal
            // 
            this.txtTransTotal.Location = new System.Drawing.Point(111, 13);
            this.txtTransTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTransTotal.Name = "txtTransTotal";
            this.txtTransTotal.Size = new System.Drawing.Size(68, 24);
            this.txtTransTotal.TabIndex = 3;
            this.txtTransTotal.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tax:";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(111, 37);
            this.txtTax.Margin = new System.Windows.Forms.Padding(2);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(68, 24);
            this.txtTax.TabIndex = 5;
            this.txtTax.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "NonTax:";
            // 
            // txtTransNet
            // 
            this.txtTransNet.Location = new System.Drawing.Point(111, 109);
            this.txtTransNet.Margin = new System.Windows.Forms.Padding(2);
            this.txtTransNet.Name = "txtTransNet";
            this.txtTransNet.Size = new System.Drawing.Size(68, 24);
            this.txtTransNet.TabIndex = 11;
            this.txtTransNet.Text = "0.00";
            // 
            // txtTransNonTax
            // 
            this.txtTransNonTax.Location = new System.Drawing.Point(111, 61);
            this.txtTransNonTax.Margin = new System.Windows.Forms.Padding(2);
            this.txtTransNonTax.Name = "txtTransNonTax";
            this.txtTransNonTax.Size = new System.Drawing.Size(68, 24);
            this.txtTransNonTax.TabIndex = 7;
            this.txtTransNonTax.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "My Cost:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bottle Deposit:";
            // 
            // txtTransBottleDeposit
            // 
            this.txtTransBottleDeposit.Location = new System.Drawing.Point(111, 85);
            this.txtTransBottleDeposit.Margin = new System.Windows.Forms.Padding(2);
            this.txtTransBottleDeposit.Name = "txtTransBottleDeposit";
            this.txtTransBottleDeposit.Size = new System.Drawing.Size(68, 24);
            this.txtTransBottleDeposit.TabIndex = 9;
            this.txtTransBottleDeposit.Text = "0.00";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(412, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "End:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.CustomFormat = "M/d/yy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(471, 49);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(112, 24);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(412, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Start:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CustomFormat = "M/d/yy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(471, 22);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 24);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dgTrans
            // 
            this.dgTrans.AllowUserToAddRows = false;
            this.dgTrans.AllowUserToDeleteRows = false;
            this.dgTrans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTrans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTransType,
            this.colTransQty,
            this.colTransDiscount,
            this.colTransTotal});
            this.dgTrans.Location = new System.Drawing.Point(15, 12);
            this.dgTrans.Margin = new System.Windows.Forms.Padding(2);
            this.dgTrans.Name = "dgTrans";
            this.dgTrans.ReadOnly = true;
            this.dgTrans.RowHeadersVisible = false;
            this.dgTrans.RowHeadersWidth = 62;
            this.dgTrans.RowTemplate.Height = 28;
            this.dgTrans.Size = new System.Drawing.Size(384, 293);
            this.dgTrans.TabIndex = 1;
            // 
            // colTransType
            // 
            this.colTransType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTransType.HeaderText = "Type";
            this.colTransType.MinimumWidth = 8;
            this.colTransType.Name = "colTransType";
            this.colTransType.ReadOnly = true;
            // 
            // colTransQty
            // 
            this.colTransQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colTransQty.HeaderText = "Qty";
            this.colTransQty.MinimumWidth = 8;
            this.colTransQty.Name = "colTransQty";
            this.colTransQty.ReadOnly = true;
            this.colTransQty.Width = 59;
            // 
            // colTransDiscount
            // 
            this.colTransDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colTransDiscount.HeaderText = "Discount";
            this.colTransDiscount.MinimumWidth = 8;
            this.colTransDiscount.Name = "colTransDiscount";
            this.colTransDiscount.ReadOnly = true;
            // 
            // colTransTotal
            // 
            this.colTransTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTransTotal.HeaderText = "Total";
            this.colTransTotal.MinimumWidth = 8;
            this.colTransTotal.Name = "colTransTotal";
            this.colTransTotal.ReadOnly = true;
            // 
            // btnTransRun
            // 
            this.btnTransRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransRun.Location = new System.Drawing.Point(515, 96);
            this.btnTransRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransRun.Name = "btnTransRun";
            this.btnTransRun.Size = new System.Drawing.Size(68, 27);
            this.btnTransRun.TabIndex = 0;
            this.btnTransRun.Text = "&Run";
            this.btnTransRun.UseVisualStyleBackColor = true;
            // 
            // tabPCustomer
            // 
            this.tabPCustomer.Controls.Add(this.label12);
            this.tabPCustomer.Controls.Add(this.dgCustomerOrders);
            this.tabPCustomer.Controls.Add(this.label11);
            this.tabPCustomer.Controls.Add(this.textBox1);
            this.tabPCustomer.Controls.Add(this.comboBox1);
            this.tabPCustomer.Controls.Add(this.label10);
            this.tabPCustomer.Controls.Add(this.label8);
            this.tabPCustomer.Controls.Add(this.txt_Customer_Total);
            this.tabPCustomer.Controls.Add(this.label9);
            this.tabPCustomer.Controls.Add(this.textBox2);
            this.tabPCustomer.Controls.Add(this.dgCustomers);
            this.tabPCustomer.Location = new System.Drawing.Point(4, 27);
            this.tabPCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.tabPCustomer.Name = "tabPCustomer";
            this.tabPCustomer.Padding = new System.Windows.Forms.Padding(2);
            this.tabPCustomer.Size = new System.Drawing.Size(607, 319);
            this.tabPCustomer.TabIndex = 1;
            this.tabPCustomer.Text = "Customer";
            this.tabPCustomer.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(296, 140);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 18);
            this.label12.TabIndex = 15;
            this.label12.Text = "Orders";
            // 
            // dgCustomerOrders
            // 
            this.dgCustomerOrders.AllowUserToAddRows = false;
            this.dgCustomerOrders.AllowUserToDeleteRows = false;
            this.dgCustomerOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCustomerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomerOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colCustomerQty,
            this.colCustomerStatus,
            this.dataGridViewTextBoxColumn2});
            this.dgCustomerOrders.Location = new System.Drawing.Point(277, 172);
            this.dgCustomerOrders.Margin = new System.Windows.Forms.Padding(2);
            this.dgCustomerOrders.Name = "dgCustomerOrders";
            this.dgCustomerOrders.ReadOnly = true;
            this.dgCustomerOrders.RowHeadersVisible = false;
            this.dgCustomerOrders.RowHeadersWidth = 62;
            this.dgCustomerOrders.RowTemplate.Height = 28;
            this.dgCustomerOrders.Size = new System.Drawing.Size(327, 143);
            this.dgCustomerOrders.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // colCustomerQty
            // 
            this.colCustomerQty.HeaderText = "Qty";
            this.colCustomerQty.Name = "colCustomerQty";
            this.colCustomerQty.ReadOnly = true;
            // 
            // colCustomerStatus
            // 
            this.colCustomerStatus.HeaderText = "Status";
            this.colCustomerStatus.Name = "colCustomerStatus";
            this.colCustomerStatus.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.HeaderText = "Type";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 69;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(321, 82);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 18);
            this.label11.TabIndex = 12;
            this.label11.Text = "Transactions:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(436, 79);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 24);
            this.textBox1.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(436, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 26);
            this.comboBox1.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(382, 52);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(378, 117);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Total:";
            // 
            // txt_Customer_Total
            // 
            this.txt_Customer_Total.Location = new System.Drawing.Point(436, 114);
            this.txt_Customer_Total.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Customer_Total.Name = "txt_Customer_Total";
            this.txt_Customer_Total.Size = new System.Drawing.Size(96, 24);
            this.txt_Customer_Total.TabIndex = 7;
            this.txt_Customer_Total.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(378, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Name:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(436, 18);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(96, 24);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dgCustomers
            // 
            this.dgCustomers.AllowUserToAddRows = false;
            this.dgCustomers.AllowUserToDeleteRows = false;
            this.dgCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dccol_Customer_Name,
            this.col_Customer_Type});
            this.dgCustomers.Location = new System.Drawing.Point(4, 18);
            this.dgCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.dgCustomers.Name = "dgCustomers";
            this.dgCustomers.ReadOnly = true;
            this.dgCustomers.RowHeadersVisible = false;
            this.dgCustomers.RowHeadersWidth = 62;
            this.dgCustomers.RowTemplate.Height = 28;
            this.dgCustomers.Size = new System.Drawing.Size(269, 297);
            this.dgCustomers.TabIndex = 2;
            // 
            // dccol_Customer_Name
            // 
            this.dccol_Customer_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dccol_Customer_Name.HeaderText = "Name";
            this.dccol_Customer_Name.MinimumWidth = 8;
            this.dccol_Customer_Name.Name = "dccol_Customer_Name";
            this.dccol_Customer_Name.ReadOnly = true;
            // 
            // col_Customer_Type
            // 
            this.col_Customer_Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.col_Customer_Type.HeaderText = "Type";
            this.col_Customer_Type.MinimumWidth = 8;
            this.col_Customer_Type.Name = "col_Customer_Type";
            this.col_Customer_Type.ReadOnly = true;
            this.col_Customer_Type.Width = 69;
            // 
            // tabTransactions
            // 
            this.tabTransactions.Controls.Add(this.label14);
            this.tabTransactions.Controls.Add(this.txtTransDate);
            this.tabTransactions.Controls.Add(this.label13);
            this.tabTransactions.Controls.Add(this.txtTransItems);
            this.tabTransactions.Controls.Add(this.label15);
            this.tabTransactions.Controls.Add(this.txtTransTotalValue);
            this.tabTransactions.Controls.Add(this.label16);
            this.tabTransactions.Controls.Add(this.txtTransId);
            this.tabTransactions.Controls.Add(this.dgItems);
            this.tabTransactions.Controls.Add(this.dataGridView2);
            this.tabTransactions.Location = new System.Drawing.Point(4, 27);
            this.tabTransactions.Margin = new System.Windows.Forms.Padding(2);
            this.tabTransactions.Name = "tabTransactions";
            this.tabTransactions.Padding = new System.Windows.Forms.Padding(2);
            this.tabTransactions.Size = new System.Drawing.Size(607, 319);
            this.tabTransactions.TabIndex = 2;
            this.tabTransactions.Text = "Transactions";
            this.tabTransactions.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(424, 46);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 18);
            this.label14.TabIndex = 25;
            this.label14.Text = "Date:";
            // 
            // txtTransDate
            // 
            this.txtTransDate.Location = new System.Drawing.Point(485, 43);
            this.txtTransDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtTransDate.Name = "txtTransDate";
            this.txtTransDate.Size = new System.Drawing.Size(106, 24);
            this.txtTransDate.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(424, 78);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 18);
            this.label13.TabIndex = 23;
            this.label13.Text = "Items:";
            // 
            // txtTransItems
            // 
            this.txtTransItems.Location = new System.Drawing.Point(485, 75);
            this.txtTransItems.Margin = new System.Windows.Forms.Padding(2);
            this.txtTransItems.Name = "txtTransItems";
            this.txtTransItems.Size = new System.Drawing.Size(106, 24);
            this.txtTransItems.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(424, 108);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 18);
            this.label15.TabIndex = 17;
            this.label15.Text = "Total:";
            // 
            // txtTransTotalValue
            // 
            this.txtTransTotalValue.Location = new System.Drawing.Point(485, 105);
            this.txtTransTotalValue.Margin = new System.Windows.Forms.Padding(2);
            this.txtTransTotalValue.Name = "txtTransTotalValue";
            this.txtTransTotalValue.Size = new System.Drawing.Size(106, 24);
            this.txtTransTotalValue.TabIndex = 18;
            this.txtTransTotalValue.Text = "0.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(424, 17);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 18);
            this.label16.TabIndex = 19;
            this.label16.Text = "ID:";
            // 
            // txtTransId
            // 
            this.txtTransId.Location = new System.Drawing.Point(485, 14);
            this.txtTransId.Margin = new System.Windows.Forms.Padding(2);
            this.txtTransId.Name = "txtTransId";
            this.txtTransId.Size = new System.Drawing.Size(106, 24);
            this.txtTransId.TabIndex = 20;
            // 
            // dgItems
            // 
            this.dgItems.AllowUserToAddRows = false;
            this.dgItems.AllowUserToDeleteRows = false;
            this.dgItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgItems.Location = new System.Drawing.Point(266, 142);
            this.dgItems.Margin = new System.Windows.Forms.Padding(2);
            this.dgItems.Name = "dgItems";
            this.dgItems.ReadOnly = true;
            this.dgItems.RowHeadersVisible = false;
            this.dgItems.RowHeadersWidth = 62;
            this.dgItems.RowTemplate.Height = 28;
            this.dgItems.Size = new System.Drawing.Size(325, 166);
            this.dgItems.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Status";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn6.HeaderText = "Type";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 69;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTransactionID,
            this.colTransactionDate});
            this.dataGridView2.Location = new System.Drawing.Point(10, 14);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(252, 294);
            this.dataGridView2.TabIndex = 15;
            // 
            // colTransactionID
            // 
            this.colTransactionID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTransactionID.HeaderText = "Transaction";
            this.colTransactionID.MinimumWidth = 8;
            this.colTransactionID.Name = "colTransactionID";
            this.colTransactionID.ReadOnly = true;
            // 
            // colTransactionDate
            // 
            this.colTransactionDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colTransactionDate.HeaderText = "Date";
            this.colTransactionDate.MinimumWidth = 8;
            this.colTransactionDate.Name = "colTransactionDate";
            this.colTransactionDate.ReadOnly = true;
            this.colTransactionDate.Width = 68;
            // 
            // tabOrders
            // 
            this.tabOrders.Location = new System.Drawing.Point(4, 27);
            this.tabOrders.Margin = new System.Windows.Forms.Padding(2);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(2);
            this.tabOrders.Size = new System.Drawing.Size(607, 319);
            this.tabOrders.TabIndex = 3;
            this.tabOrders.Text = "Orders";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(517, 362);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(98, 35);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(629, 405);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabPage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report";
            this.tabPage.ResumeLayout(false);
            this.tabSales.ResumeLayout(false);
            this.tabSales.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrans)).EndInit();
            this.tabPCustomer.ResumeLayout(false);
            this.tabPCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
            this.tabTransactions.ResumeLayout(false);
            this.tabTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabSales;
        private System.Windows.Forms.TabPage tabPCustomer;
        private System.Windows.Forms.Button btnOk;
        private SecretCellar.CurrencyBox txtTransNet;
        private System.Windows.Forms.Label label5;
        private SecretCellar.CurrencyBox txtTransBottleDeposit;
        private System.Windows.Forms.Label label4;
        private SecretCellar.CurrencyBox txtTransNonTax;
        private System.Windows.Forms.Label label3;
        private SecretCellar.CurrencyBox txtTax;
        private System.Windows.Forms.Label label2;
        private SecretCellar.CurrencyBox txtTransTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgTrans;
        private System.Windows.Forms.Button btnTransRun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabPage tabTransactions;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private SecretCellar.CurrencyBox txt_Customer_Total;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dgCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dccol_Customer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Customer_Type;
        private System.Windows.Forms.DataGridView dgCustomerOrders;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTransDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTransItems;
        private System.Windows.Forms.Label label15;
        private SecretCellar.CurrencyBox txtTransTotalValue;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTransId;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionDate;
    }
}