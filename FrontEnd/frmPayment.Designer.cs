namespace SecretCellar
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.LB_EnterAmt = new System.Windows.Forms.Label();
            this.txtCashAmt = new SecretCellar.CurrencyBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.paymentType = new System.Windows.Forms.DataGridView();
            this.TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LB_Due = new System.Windows.Forms.Label();
            this.LB_Total = new System.Windows.Forms.Label();
            this.LB_ChangeDue = new System.Windows.Forms.Label();
            this.btnCompleteSale = new System.Windows.Forms.Button();
            this.txt_TenderTransTotal = new SecretCellar.CurrencyBox();
            this.txtDue = new SecretCellar.CurrencyBox();
            this.btn_Cash = new System.Windows.Forms.Button();
            this.btn_Check = new System.Windows.Forms.Button();
            this.btn_Credit = new System.Windows.Forms.Button();
            this.btn_GiftCard = new System.Windows.Forms.Button();
            this.txtChange = new SecretCellar.CurrencyBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chk_printReceipt = new System.Windows.Forms.CheckBox();
            this.lbl_credit = new System.Windows.Forms.Label();
            this.txt_credit_amount = new SecretCellar.CurrencyBox();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.txt_customer = new System.Windows.Forms.TextBox();
            this.btn_cust_credit = new System.Windows.Forms.Button();
            this.btnBreakage = new System.Windows.Forms.Button();
            this.btnDonation = new System.Windows.Forms.Button();
            this.btn_RemoveAllPayments = new System.Windows.Forms.Button();
            this.gb_NoPayment = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.touchKeyPad1 = new SecretCellar.TouchKeyPad();
            ((System.ComponentModel.ISupportInitialize)(this.paymentType)).BeginInit();
            this.gb_NoPayment.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_EnterAmt
            // 
            this.LB_EnterAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_EnterAmt.Location = new System.Drawing.Point(17, 19);
            this.LB_EnterAmt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_EnterAmt.Name = "LB_EnterAmt";
            this.LB_EnterAmt.Size = new System.Drawing.Size(194, 20);
            this.LB_EnterAmt.TabIndex = 8;
            this.LB_EnterAmt.Text = "Enter Payment Amount";
            // 
            // txtCashAmt
            // 
            this.txtCashAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashAmt.Location = new System.Drawing.Point(21, 41);
            this.txtCashAmt.Margin = new System.Windows.Forms.Padding(2);
            this.txtCashAmt.Name = "txtCashAmt";
            this.txtCashAmt.Size = new System.Drawing.Size(190, 29);
            this.txtCashAmt.TabIndex = 1;
            this.txtCashAmt.Text = "0.00";
            this.txtCashAmt.Enter += new System.EventHandler(this.txtCashAmt_Enter);
            this.txtCashAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(48, 638);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(382, 52);
            this.btnMainMenu.TabIndex = 10;
            this.btnMainMenu.Text = "Close";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // paymentType
            // 
            this.paymentType.AllowUserToAddRows = false;
            this.paymentType.AllowUserToDeleteRows = false;
            this.paymentType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paymentType.ColumnHeadersHeight = 35;
            this.paymentType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TYPE,
            this.AMOUNT});
            this.paymentType.Location = new System.Drawing.Point(21, 167);
            this.paymentType.Margin = new System.Windows.Forms.Padding(2);
            this.paymentType.Name = "paymentType";
            this.paymentType.ReadOnly = true;
            this.paymentType.RowHeadersVisible = false;
            this.paymentType.RowHeadersWidth = 102;
            this.paymentType.RowTemplate.Height = 28;
            this.paymentType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paymentType.Size = new System.Drawing.Size(491, 225);
            this.paymentType.TabIndex = 8;
            // 
            // TYPE
            // 
            this.TYPE.HeaderText = "Type";
            this.TYPE.MinimumWidth = 12;
            this.TYPE.Name = "TYPE";
            this.TYPE.ReadOnly = true;
            // 
            // AMOUNT
            // 
            this.AMOUNT.HeaderText = "Amount";
            this.AMOUNT.MinimumWidth = 12;
            this.AMOUNT.Name = "AMOUNT";
            this.AMOUNT.ReadOnly = true;
            // 
            // LB_Due
            // 
            this.LB_Due.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Due.ForeColor = System.Drawing.Color.DarkRed;
            this.LB_Due.Location = new System.Drawing.Point(667, 558);
            this.LB_Due.Margin = new System.Windows.Forms.Padding(0);
            this.LB_Due.Name = "LB_Due";
            this.LB_Due.Size = new System.Drawing.Size(156, 30);
            this.LB_Due.TabIndex = 16;
            this.LB_Due.Text = "Balance Due:";
            this.LB_Due.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_Total
            // 
            this.LB_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Total.Location = new System.Drawing.Point(738, 521);
            this.LB_Total.Margin = new System.Windows.Forms.Padding(0);
            this.LB_Total.Name = "LB_Total";
            this.LB_Total.Size = new System.Drawing.Size(84, 30);
            this.LB_Total.TabIndex = 20;
            this.LB_Total.Text = "Total:";
            this.LB_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_ChangeDue
            // 
            this.LB_ChangeDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ChangeDue.Location = new System.Drawing.Point(648, 595);
            this.LB_ChangeDue.Margin = new System.Windows.Forms.Padding(0);
            this.LB_ChangeDue.Name = "LB_ChangeDue";
            this.LB_ChangeDue.Size = new System.Drawing.Size(174, 30);
            this.LB_ChangeDue.TabIndex = 21;
            this.LB_ChangeDue.Text = "Change Due:";
            this.LB_ChangeDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCompleteSale
            // 
            this.btnCompleteSale.Enabled = false;
            this.btnCompleteSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteSale.Location = new System.Drawing.Point(596, 637);
            this.btnCompleteSale.Margin = new System.Windows.Forms.Padding(2);
            this.btnCompleteSale.Name = "btnCompleteSale";
            this.btnCompleteSale.Size = new System.Drawing.Size(371, 53);
            this.btnCompleteSale.TabIndex = 12;
            this.btnCompleteSale.Text = "Complete Sale";
            this.btnCompleteSale.UseVisualStyleBackColor = true;
            this.btnCompleteSale.Click += new System.EventHandler(this.btnCompleteSale_Click);
            // 
            // txt_TenderTransTotal
            // 
            this.txt_TenderTransTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenderTransTotal.Location = new System.Drawing.Point(827, 525);
            this.txt_TenderTransTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TenderTransTotal.Name = "txt_TenderTransTotal";
            this.txt_TenderTransTotal.ReadOnly = true;
            this.txt_TenderTransTotal.Size = new System.Drawing.Size(140, 26);
            this.txt_TenderTransTotal.TabIndex = 26;
            this.txt_TenderTransTotal.TabStop = false;
            this.txt_TenderTransTotal.Text = "0.00";
            this.txt_TenderTransTotal.TextChanged += new System.EventHandler(this.txt_TransTotal_TextChanged);
            // 
            // txtDue
            // 
            this.txtDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDue.Location = new System.Drawing.Point(827, 561);
            this.txtDue.Margin = new System.Windows.Forms.Padding(2);
            this.txtDue.Name = "txtDue";
            this.txtDue.ReadOnly = true;
            this.txtDue.Size = new System.Drawing.Size(140, 26);
            this.txtDue.TabIndex = 27;
            this.txtDue.TabStop = false;
            this.txtDue.Text = "0.00";
            // 
            // btn_Cash
            // 
            this.btn_Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cash.Location = new System.Drawing.Point(20, 82);
            this.btn_Cash.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cash.Name = "btn_Cash";
            this.btn_Cash.Size = new System.Drawing.Size(149, 36);
            this.btn_Cash.TabIndex = 3;
            this.btn_Cash.Text = "Cash";
            this.btn_Cash.UseVisualStyleBackColor = true;
            this.btn_Cash.Click += new System.EventHandler(this.btn_Cash_Click);
            // 
            // btn_Check
            // 
            this.btn_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check.Location = new System.Drawing.Point(186, 82);
            this.btn_Check.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(149, 36);
            this.btn_Check.TabIndex = 4;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // btn_Credit
            // 
            this.btn_Credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Credit.Location = new System.Drawing.Point(350, 82);
            this.btn_Credit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Credit.Name = "btn_Credit";
            this.btn_Credit.Size = new System.Drawing.Size(149, 36);
            this.btn_Credit.TabIndex = 5;
            this.btn_Credit.Text = "Credit Card";
            this.btn_Credit.UseVisualStyleBackColor = true;
            this.btn_Credit.Click += new System.EventHandler(this.btn_Credit_Click);
            // 
            // btn_GiftCard
            // 
            this.btn_GiftCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GiftCard.Location = new System.Drawing.Point(515, 82);
            this.btn_GiftCard.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GiftCard.Name = "btn_GiftCard";
            this.btn_GiftCard.Size = new System.Drawing.Size(149, 36);
            this.btn_GiftCard.TabIndex = 6;
            this.btn_GiftCard.Text = "Gift Card";
            this.btn_GiftCard.UseVisualStyleBackColor = true;
            this.btn_GiftCard.Click += new System.EventHandler(this.btn_GiftCard_Click);
            // 
            // txtChange
            // 
            this.txtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(827, 598);
            this.txtChange.Margin = new System.Windows.Forms.Padding(2);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(140, 26);
            this.txtChange.TabIndex = 32;
            this.txtChange.TabStop = false;
            this.txtChange.Text = "0.00";
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(273, 41);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(120, 29);
            this.txtNumber.TabIndex = 2;
            this.txtNumber.Enter += new System.EventHandler(this.txtCashAmt_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Number";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(21, 31);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(202, 36);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Remove Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chk_printReceipt
            // 
            this.chk_printReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_printReceipt.Location = new System.Drawing.Point(469, 593);
            this.chk_printReceipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_printReceipt.Name = "chk_printReceipt";
            this.chk_printReceipt.Size = new System.Drawing.Size(152, 31);
            this.chk_printReceipt.TabIndex = 11;
            this.chk_printReceipt.Text = "Print Recipt";
            this.chk_printReceipt.UseVisualStyleBackColor = true;
            this.chk_printReceipt.CheckedChanged += new System.EventHandler(this.chk_printReceipt_CheckedChanged);
            // 
            // lbl_credit
            // 
            this.lbl_credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_credit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_credit.Location = new System.Drawing.Point(855, 12);
            this.lbl_credit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_credit.Name = "lbl_credit";
            this.lbl_credit.Size = new System.Drawing.Size(118, 25);
            this.lbl_credit.TabIndex = 38;
            this.lbl_credit.Text = "Credit:";
            this.lbl_credit.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_credit_amount
            // 
            this.txt_credit_amount.BackColor = System.Drawing.SystemColors.Control;
            this.txt_credit_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_credit_amount.Location = new System.Drawing.Point(859, 41);
            this.txt_credit_amount.Margin = new System.Windows.Forms.Padding(2);
            this.txt_credit_amount.Name = "txt_credit_amount";
            this.txt_credit_amount.ReadOnly = true;
            this.txt_credit_amount.Size = new System.Drawing.Size(79, 29);
            this.txt_credit_amount.TabIndex = 37;
            this.txt_credit_amount.TabStop = false;
            this.txt_credit_amount.Text = "0.00";
            // 
            // lbl_customer
            // 
            this.lbl_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customer.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbl_customer.Location = new System.Drawing.Point(688, 14);
            this.lbl_customer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(100, 24);
            this.lbl_customer.TabIndex = 40;
            this.lbl_customer.Text = "Customer:";
            this.lbl_customer.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_customer
            // 
            this.txt_customer.BackColor = System.Drawing.SystemColors.Control;
            this.txt_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer.Location = new System.Drawing.Point(691, 41);
            this.txt_customer.Margin = new System.Windows.Forms.Padding(2);
            this.txt_customer.Name = "txt_customer";
            this.txt_customer.ReadOnly = true;
            this.txt_customer.Size = new System.Drawing.Size(164, 29);
            this.txt_customer.TabIndex = 39;
            this.txt_customer.TabStop = false;
            // 
            // btn_cust_credit
            // 
            this.btn_cust_credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cust_credit.Location = new System.Drawing.Point(689, 82);
            this.btn_cust_credit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cust_credit.Name = "btn_cust_credit";
            this.btn_cust_credit.Size = new System.Drawing.Size(152, 36);
            this.btn_cust_credit.TabIndex = 7;
            this.btn_cust_credit.Text = "Customer Credit";
            this.btn_cust_credit.UseVisualStyleBackColor = true;
            this.btn_cust_credit.Click += new System.EventHandler(this.btn_cust_credit_Click);
            // 
            // btnBreakage
            // 
            this.btnBreakage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBreakage.Location = new System.Drawing.Point(12, 31);
            this.btnBreakage.Margin = new System.Windows.Forms.Padding(2);
            this.btnBreakage.Name = "btnBreakage";
            this.btnBreakage.Size = new System.Drawing.Size(136, 36);
            this.btnBreakage.TabIndex = 42;
            this.btnBreakage.Text = "Breakage";
            this.btnBreakage.UseVisualStyleBackColor = true;
            this.btnBreakage.Click += new System.EventHandler(this.btnBreakage_Click);
            // 
            // btnDonation
            // 
            this.btnDonation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonation.Location = new System.Drawing.Point(13, 81);
            this.btnDonation.Margin = new System.Windows.Forms.Padding(2);
            this.btnDonation.Name = "btnDonation";
            this.btnDonation.Size = new System.Drawing.Size(135, 36);
            this.btnDonation.TabIndex = 41;
            this.btnDonation.Text = "Donation";
            this.btnDonation.UseVisualStyleBackColor = true;
            this.btnDonation.Click += new System.EventHandler(this.btnDonation_Click);
            // 
            // btn_RemoveAllPayments
            // 
            this.btn_RemoveAllPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemoveAllPayments.Location = new System.Drawing.Point(21, 81);
            this.btn_RemoveAllPayments.Margin = new System.Windows.Forms.Padding(4);
            this.btn_RemoveAllPayments.Name = "btn_RemoveAllPayments";
            this.btn_RemoveAllPayments.Size = new System.Drawing.Size(202, 36);
            this.btn_RemoveAllPayments.TabIndex = 43;
            this.btn_RemoveAllPayments.Text = "Remove All";
            this.btn_RemoveAllPayments.UseVisualStyleBackColor = true;
            this.btn_RemoveAllPayments.Click += new System.EventHandler(this.btn_RemoveAllPayments_Click);
            // 
            // gb_NoPayment
            // 
            this.gb_NoPayment.Controls.Add(this.btnDonation);
            this.gb_NoPayment.Controls.Add(this.btnBreakage);
            this.gb_NoPayment.Location = new System.Drawing.Point(36, 442);
            this.gb_NoPayment.Margin = new System.Windows.Forms.Padding(2);
            this.gb_NoPayment.Name = "gb_NoPayment";
            this.gb_NoPayment.Padding = new System.Windows.Forms.Padding(2);
            this.gb_NoPayment.Size = new System.Drawing.Size(163, 145);
            this.gb_NoPayment.TabIndex = 44;
            this.gb_NoPayment.TabStop = false;
            this.gb_NoPayment.Text = "No Payment Options";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btn_RemoveAllPayments);
            this.groupBox1.Location = new System.Drawing.Point(207, 442);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(235, 145);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remove Payment";
            // 
            // touchKeyPad1
            // 
            this.touchKeyPad1.Location = new System.Drawing.Point(535, 147);
            this.touchKeyPad1.Margin = new System.Windows.Forms.Padding(4);
            this.touchKeyPad1.Name = "touchKeyPad1";
            this.touchKeyPad1.Size = new System.Drawing.Size(462, 363);
            this.touchKeyPad1.TabIndex = 46;
            this.touchKeyPad1.Target = null;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(993, 721);
            this.Controls.Add(this.touchKeyPad1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_NoPayment);
            this.Controls.Add(this.btn_cust_credit);
            this.Controls.Add(this.lbl_customer);
            this.Controls.Add(this.txt_customer);
            this.Controls.Add(this.lbl_credit);
            this.Controls.Add(this.txt_credit_amount);
            this.Controls.Add(this.chk_printReceipt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.btn_GiftCard);
            this.Controls.Add(this.btn_Credit);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.btn_Cash);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.paymentType);
            this.Controls.Add(this.btnCompleteSale);
            this.Controls.Add(this.LB_EnterAmt);
            this.Controls.Add(this.txtDue);
            this.Controls.Add(this.txtCashAmt);
            this.Controls.Add(this.txt_TenderTransTotal);
            this.Controls.Add(this.LB_ChangeDue);
            this.Controls.Add(this.LB_Due);
            this.Controls.Add(this.LB_Total);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentType)).EndInit();
            this.gb_NoPayment.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label LB_EnterAmt;
        private SecretCellar.CurrencyBox txtCashAmt;
        private System.Windows.Forms.DataGridView paymentType;
        private System.Windows.Forms.Label LB_Due;
        private System.Windows.Forms.Label LB_Total;
        private System.Windows.Forms.Label LB_ChangeDue;
        private System.Windows.Forms.Button btnCompleteSale;
        private SecretCellar.CurrencyBox txt_TenderTransTotal;
        private SecretCellar.CurrencyBox txtDue;
        private System.Windows.Forms.Button btn_Cash;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Button btn_Credit;
        private System.Windows.Forms.Button btn_GiftCard;
        private SecretCellar.CurrencyBox txtChange;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox chk_printReceipt;
        private System.Windows.Forms.Label lbl_credit;
        private SecretCellar.CurrencyBox txt_credit_amount;
        private System.Windows.Forms.Label lbl_customer;
        private System.Windows.Forms.TextBox txt_customer;
        private System.Windows.Forms.Button btn_cust_credit;
        private System.Windows.Forms.Button btnBreakage;
        private System.Windows.Forms.Button btnDonation;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMOUNT;
        private System.Windows.Forms.Button btn_RemoveAllPayments;
        private System.Windows.Forms.GroupBox gb_NoPayment;
        private System.Windows.Forms.GroupBox groupBox1;
        private SecretCellar.TouchKeyPad touchKeyPad1;
    }
}