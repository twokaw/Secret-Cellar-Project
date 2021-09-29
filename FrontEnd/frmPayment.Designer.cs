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
			this.txtCashAmt = new System.Windows.Forms.TextBox();
			this.btnMainMenu = new System.Windows.Forms.Button();
			this.paymentType = new System.Windows.Forms.DataGridView();
			this.TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AMOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LB_Due = new System.Windows.Forms.Label();
			this.LB_Total = new System.Windows.Forms.Label();
			this.LB_ChangeDue = new System.Windows.Forms.Label();
			this.btnCompleteSale = new System.Windows.Forms.Button();
			this.txt_TenderTransTotal = new System.Windows.Forms.TextBox();
			this.txtDue = new System.Windows.Forms.TextBox();
			this.btn_Cash = new System.Windows.Forms.Button();
			this.btn_Check = new System.Windows.Forms.Button();
			this.btn_Credit = new System.Windows.Forms.Button();
			this.btn_GiftCard = new System.Windows.Forms.Button();
			this.txtChange = new System.Windows.Forms.TextBox();
			this.txtNumber = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.chk_printReceipt = new System.Windows.Forms.CheckBox();
			this.lbl_credit = new System.Windows.Forms.Label();
			this.txt_credit_amount = new System.Windows.Forms.TextBox();
			this.lbl_customer = new System.Windows.Forms.Label();
			this.txt_customer = new System.Windows.Forms.TextBox();
			this.btn_cust_credit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.paymentType)).BeginInit();
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
			this.txtCashAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
			// 
			// btnMainMenu
			// 
			this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMainMenu.Location = new System.Drawing.Point(21, 426);
			this.btnMainMenu.Margin = new System.Windows.Forms.Padding(2);
			this.btnMainMenu.Name = "btnMainMenu";
			this.btnMainMenu.Size = new System.Drawing.Size(180, 55);
			this.btnMainMenu.TabIndex = 10;
			this.btnMainMenu.Text = "CLOSE WINDOW";
			this.btnMainMenu.UseVisualStyleBackColor = true;
			this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
			// 
			// paymentType
			// 
			this.paymentType.AllowUserToAddRows = false;
			this.paymentType.AllowUserToDeleteRows = false;
			this.paymentType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.paymentType.ColumnHeadersHeight = 28;
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
			this.TYPE.HeaderText = "TYPE";
			this.TYPE.MinimumWidth = 12;
			this.TYPE.Name = "TYPE";
			this.TYPE.ReadOnly = true;
			// 
			// AMOUNT
			// 
			this.AMOUNT.HeaderText = "AMOUNT";
			this.AMOUNT.MinimumWidth = 12;
			this.AMOUNT.Name = "AMOUNT";
			this.AMOUNT.ReadOnly = true;
			// 
			// LB_Due
			// 
			this.LB_Due.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LB_Due.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LB_Due.ForeColor = System.Drawing.Color.Crimson;
			this.LB_Due.Location = new System.Drawing.Point(531, 328);
			this.LB_Due.Margin = new System.Windows.Forms.Padding(0);
			this.LB_Due.Name = "LB_Due";
			this.LB_Due.Size = new System.Drawing.Size(179, 30);
			this.LB_Due.TabIndex = 16;
			this.LB_Due.Text = "Balance Due:";
			this.LB_Due.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LB_Total
			// 
			this.LB_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LB_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LB_Total.Location = new System.Drawing.Point(626, 291);
			this.LB_Total.Margin = new System.Windows.Forms.Padding(0);
			this.LB_Total.Name = "LB_Total";
			this.LB_Total.Size = new System.Drawing.Size(96, 30);
			this.LB_Total.TabIndex = 20;
			this.LB_Total.Text = "Total:";
			this.LB_Total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LB_ChangeDue
			// 
			this.LB_ChangeDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LB_ChangeDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LB_ChangeDue.Location = new System.Drawing.Point(536, 365);
			this.LB_ChangeDue.Margin = new System.Windows.Forms.Padding(0);
			this.LB_ChangeDue.Name = "LB_ChangeDue";
			this.LB_ChangeDue.Size = new System.Drawing.Size(179, 30);
			this.LB_ChangeDue.TabIndex = 21;
			this.LB_ChangeDue.Text = "Change Due:";
			this.LB_ChangeDue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnCompleteSale
			// 
			this.btnCompleteSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCompleteSale.Enabled = false;
			this.btnCompleteSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCompleteSale.Location = new System.Drawing.Point(675, 428);
			this.btnCompleteSale.Margin = new System.Windows.Forms.Padding(2);
			this.btnCompleteSale.Name = "btnCompleteSale";
			this.btnCompleteSale.Size = new System.Drawing.Size(180, 53);
			this.btnCompleteSale.TabIndex = 12;
			this.btnCompleteSale.Text = "COMPLETE SALE";
			this.btnCompleteSale.UseVisualStyleBackColor = true;
			this.btnCompleteSale.Click += new System.EventHandler(this.btnCompleteSale_Click);
			// 
			// txt_TenderTransTotal
			// 
			this.txt_TenderTransTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_TenderTransTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_TenderTransTotal.Location = new System.Drawing.Point(715, 295);
			this.txt_TenderTransTotal.Margin = new System.Windows.Forms.Padding(2);
			this.txt_TenderTransTotal.Name = "txt_TenderTransTotal";
			this.txt_TenderTransTotal.ReadOnly = true;
			this.txt_TenderTransTotal.Size = new System.Drawing.Size(140, 26);
			this.txt_TenderTransTotal.TabIndex = 26;
			this.txt_TenderTransTotal.TabStop = false;
			this.txt_TenderTransTotal.TextChanged += new System.EventHandler(this.txt_TransTotal_TextChanged);
			// 
			// txtDue
			// 
			this.txtDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDue.Location = new System.Drawing.Point(715, 331);
			this.txtDue.Margin = new System.Windows.Forms.Padding(2);
			this.txtDue.Name = "txtDue";
			this.txtDue.ReadOnly = true;
			this.txtDue.Size = new System.Drawing.Size(140, 26);
			this.txtDue.TabIndex = 27;
			this.txtDue.TabStop = false;
			// 
			// btn_Cash
			// 
			this.btn_Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Cash.Location = new System.Drawing.Point(21, 112);
			this.btn_Cash.Margin = new System.Windows.Forms.Padding(2);
			this.btn_Cash.Name = "btn_Cash";
			this.btn_Cash.Size = new System.Drawing.Size(161, 36);
			this.btn_Cash.TabIndex = 3;
			this.btn_Cash.Text = "CASH";
			this.btn_Cash.UseVisualStyleBackColor = true;
			this.btn_Cash.Click += new System.EventHandler(this.btn_Cash_Click);
			// 
			// btn_Check
			// 
			this.btn_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Check.Location = new System.Drawing.Point(186, 112);
			this.btn_Check.Margin = new System.Windows.Forms.Padding(2);
			this.btn_Check.Name = "btn_Check";
			this.btn_Check.Size = new System.Drawing.Size(161, 36);
			this.btn_Check.TabIndex = 4;
			this.btn_Check.Text = "CHECK";
			this.btn_Check.UseVisualStyleBackColor = true;
			this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
			// 
			// btn_Credit
			// 
			this.btn_Credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Credit.Location = new System.Drawing.Point(351, 112);
			this.btn_Credit.Margin = new System.Windows.Forms.Padding(2);
			this.btn_Credit.Name = "btn_Credit";
			this.btn_Credit.Size = new System.Drawing.Size(161, 36);
			this.btn_Credit.TabIndex = 5;
			this.btn_Credit.Text = "CREDIT CARD";
			this.btn_Credit.UseVisualStyleBackColor = true;
			this.btn_Credit.Click += new System.EventHandler(this.btn_Credit_Click);
			// 
			// btn_GiftCard
			// 
			this.btn_GiftCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_GiftCard.Location = new System.Drawing.Point(516, 112);
			this.btn_GiftCard.Margin = new System.Windows.Forms.Padding(2);
			this.btn_GiftCard.Name = "btn_GiftCard";
			this.btn_GiftCard.Size = new System.Drawing.Size(161, 36);
			this.btn_GiftCard.TabIndex = 6;
			this.btn_GiftCard.Text = "GIFT CARD";
			this.btn_GiftCard.UseVisualStyleBackColor = true;
			this.btn_GiftCard.Click += new System.EventHandler(this.btn_GiftCard_Click);
			// 
			// txtChange
			// 
			this.txtChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtChange.Location = new System.Drawing.Point(715, 368);
			this.txtChange.Margin = new System.Windows.Forms.Padding(2);
			this.txtChange.Name = "txtChange";
			this.txtChange.ReadOnly = true;
			this.txtChange.Size = new System.Drawing.Size(140, 26);
			this.txtChange.TabIndex = 32;
			this.txtChange.TabStop = false;
			// 
			// txtNumber
			// 
			this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumber.Location = new System.Drawing.Point(273, 41);
			this.txtNumber.Margin = new System.Windows.Forms.Padding(2);
			this.txtNumber.Name = "txtNumber";
			this.txtNumber.Size = new System.Drawing.Size(120, 29);
			this.txtNumber.TabIndex = 2;
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
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(518, 167);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(180, 51);
			this.btnDelete.TabIndex = 9;
			this.btnDelete.Text = "REMOVE SELECTED PAYMENT";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// chk_printReceipt
			// 
			this.chk_printReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chk_printReceipt.AutoSize = true;
			this.chk_printReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chk_printReceipt.Location = new System.Drawing.Point(516, 439);
			this.chk_printReceipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chk_printReceipt.Name = "chk_printReceipt";
			this.chk_printReceipt.Size = new System.Drawing.Size(136, 28);
			this.chk_printReceipt.TabIndex = 11;
			this.chk_printReceipt.Text = "Print Recipt";
			this.chk_printReceipt.UseVisualStyleBackColor = true;
			this.chk_printReceipt.CheckedChanged += new System.EventHandler(this.chk_printReceipt_CheckedChanged);
			// 
			// lbl_credit
			// 
			this.lbl_credit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_credit.AutoSize = true;
			this.lbl_credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_credit.Location = new System.Drawing.Point(604, 64);
			this.lbl_credit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_credit.Name = "lbl_credit";
			this.lbl_credit.Size = new System.Drawing.Size(57, 20);
			this.lbl_credit.TabIndex = 38;
			this.lbl_credit.Text = "Credit";
			// 
			// txt_credit_amount
			// 
			this.txt_credit_amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_credit_amount.BackColor = System.Drawing.SystemColors.Control;
			this.txt_credit_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_credit_amount.Location = new System.Drawing.Point(691, 58);
			this.txt_credit_amount.Margin = new System.Windows.Forms.Padding(2);
			this.txt_credit_amount.Name = "txt_credit_amount";
			this.txt_credit_amount.ReadOnly = true;
			this.txt_credit_amount.Size = new System.Drawing.Size(164, 29);
			this.txt_credit_amount.TabIndex = 37;
			this.txt_credit_amount.TabStop = false;
			// 
			// lbl_customer
			// 
			this.lbl_customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_customer.AutoSize = true;
			this.lbl_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_customer.Location = new System.Drawing.Point(575, 31);
			this.lbl_customer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_customer.Name = "lbl_customer";
			this.lbl_customer.Size = new System.Drawing.Size(86, 20);
			this.lbl_customer.TabIndex = 40;
			this.lbl_customer.Text = "Customer";
			// 
			// txt_customer
			// 
			this.txt_customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_customer.BackColor = System.Drawing.SystemColors.Control;
			this.txt_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_customer.Location = new System.Drawing.Point(691, 25);
			this.txt_customer.Margin = new System.Windows.Forms.Padding(2);
			this.txt_customer.Name = "txt_customer";
			this.txt_customer.ReadOnly = true;
			this.txt_customer.Size = new System.Drawing.Size(164, 29);
			this.txt_customer.TabIndex = 39;
			this.txt_customer.TabStop = false;
			// 
			// btn_cust_credit
			// 
			this.btn_cust_credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cust_credit.Location = new System.Drawing.Point(681, 112);
			this.btn_cust_credit.Margin = new System.Windows.Forms.Padding(2);
			this.btn_cust_credit.Name = "btn_cust_credit";
			this.btn_cust_credit.Size = new System.Drawing.Size(164, 36);
			this.btn_cust_credit.TabIndex = 7;
			this.btn_cust_credit.Text = "CUSTOMER CREDIT";
			this.btn_cust_credit.UseVisualStyleBackColor = true;
			this.btn_cust_credit.Click += new System.EventHandler(this.btn_cust_credit_Click);
			// 
			// frmPayment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(875, 494);
			this.Controls.Add(this.btn_cust_credit);
			this.Controls.Add(this.lbl_customer);
			this.Controls.Add(this.txt_customer);
			this.Controls.Add(this.lbl_credit);
			this.Controls.Add(this.txt_credit_amount);
			this.Controls.Add(this.chk_printReceipt);
			this.Controls.Add(this.btnDelete);
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
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label LB_EnterAmt;
        private System.Windows.Forms.TextBox txtCashAmt;
        private System.Windows.Forms.DataGridView paymentType;
        private System.Windows.Forms.Label LB_Due;
        private System.Windows.Forms.Label LB_Total;
        private System.Windows.Forms.Label LB_ChangeDue;
        private System.Windows.Forms.Button btnCompleteSale;
        private System.Windows.Forms.TextBox txt_TenderTransTotal;
        private System.Windows.Forms.TextBox txtDue;
        private System.Windows.Forms.Button btn_Cash;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Button btn_Credit;
        private System.Windows.Forms.Button btn_GiftCard;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMOUNT;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox chk_printReceipt;
        private System.Windows.Forms.Label lbl_credit;
        private System.Windows.Forms.TextBox txt_credit_amount;
        private System.Windows.Forms.Label lbl_customer;
        private System.Windows.Forms.TextBox txt_customer;
        private System.Windows.Forms.Button btn_cust_credit;
    }
}