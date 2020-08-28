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
            this.label1 = new System.Windows.Forms.Label();
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paymentType)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_EnterAmt
            // 
            this.LB_EnterAmt.AutoSize = true;
            this.LB_EnterAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_EnterAmt.Location = new System.Drawing.Point(584, 46);
            this.LB_EnterAmt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_EnterAmt.Name = "LB_EnterAmt";
            this.LB_EnterAmt.Size = new System.Drawing.Size(157, 29);
            this.LB_EnterAmt.TabIndex = 8;
            this.LB_EnterAmt.Text = "Enter Amount";
            this.LB_EnterAmt.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCashAmt
            // 
            this.txtCashAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashAmt.Location = new System.Drawing.Point(590, 95);
            this.txtCashAmt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCashAmt.Name = "txtCashAmt";
            this.txtCashAmt.Size = new System.Drawing.Size(140, 39);
            this.txtCashAmt.TabIndex = 7;
            this.txtCashAmt.TextChanged += new System.EventHandler(this.txtCashAmt_TextChanged);
            this.txtCashAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(33, 602);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(194, 68);
            this.btnMainMenu.TabIndex = 6;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 37);
            this.label1.TabIndex = 24;
            this.label1.Text = "PAYMENT";
            // 
            // paymentType
            // 
            this.paymentType.AllowUserToAddRows = false;
            this.paymentType.AllowUserToDeleteRows = false;
            this.paymentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentType.ColumnHeadersHeight = 28;
            this.paymentType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TYPE,
            this.AMOUNT});
            this.paymentType.Location = new System.Drawing.Point(318, 234);
            this.paymentType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paymentType.Name = "paymentType";
            this.paymentType.ReadOnly = true;
            this.paymentType.RowHeadersVisible = false;
            this.paymentType.RowHeadersWidth = 102;
            this.paymentType.RowTemplate.Height = 28;
            this.paymentType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paymentType.Size = new System.Drawing.Size(656, 254);
            this.paymentType.TabIndex = 9;
            this.paymentType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paymentType_CellContentClick);
            // 
            // TYPE
            // 
            this.TYPE.HeaderText = "TYPE";
            this.TYPE.MinimumWidth = 12;
            this.TYPE.Name = "TYPE";
            this.TYPE.ReadOnly = true;
            this.TYPE.Width = 150;
            // 
            // AMOUNT
            // 
            this.AMOUNT.HeaderText = "AMOUNT";
            this.AMOUNT.MinimumWidth = 12;
            this.AMOUNT.Name = "AMOUNT";
            this.AMOUNT.ReadOnly = true;
            this.AMOUNT.Width = 150;
            // 
            // LB_Due
            // 
            this.LB_Due.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Due.AutoSize = true;
            this.LB_Due.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Due.ForeColor = System.Drawing.Color.Crimson;
            this.LB_Due.Location = new System.Drawing.Point(400, 558);
            this.LB_Due.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Due.Name = "LB_Due";
            this.LB_Due.Size = new System.Drawing.Size(220, 37);
            this.LB_Due.TabIndex = 16;
            this.LB_Due.Text = "Balance Due:";
            this.LB_Due.Click += new System.EventHandler(this.LB_Due_Click);
            // 
            // LB_Total
            // 
            this.LB_Total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Total.AutoSize = true;
            this.LB_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Total.Location = new System.Drawing.Point(526, 503);
            this.LB_Total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Total.Name = "LB_Total";
            this.LB_Total.Size = new System.Drawing.Size(104, 37);
            this.LB_Total.TabIndex = 20;
            this.LB_Total.Text = "Total:";
            // 
            // LB_ChangeDue
            // 
            this.LB_ChangeDue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_ChangeDue.AutoSize = true;
            this.LB_ChangeDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ChangeDue.Location = new System.Drawing.Point(405, 612);
            this.LB_ChangeDue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_ChangeDue.Name = "LB_ChangeDue";
            this.LB_ChangeDue.Size = new System.Drawing.Size(216, 37);
            this.LB_ChangeDue.TabIndex = 21;
            this.LB_ChangeDue.Text = "Change Due:";
            // 
            // btnCompleteSale
            // 
            this.btnCompleteSale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCompleteSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteSale.Location = new System.Drawing.Point(849, 592);
            this.btnCompleteSale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCompleteSale.Name = "btnCompleteSale";
            this.btnCompleteSale.Size = new System.Drawing.Size(266, 68);
            this.btnCompleteSale.TabIndex = 7;
            this.btnCompleteSale.Text = "Complete Sale";
            this.btnCompleteSale.UseVisualStyleBackColor = true;
            this.btnCompleteSale.Click += new System.EventHandler(this.btnCompleteSale_Click);
            // 
            // txt_TenderTransTotal
            // 
            this.txt_TenderTransTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenderTransTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenderTransTotal.Location = new System.Drawing.Point(634, 508);
            this.txt_TenderTransTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TenderTransTotal.Name = "txt_TenderTransTotal";
            this.txt_TenderTransTotal.ReadOnly = true;
            this.txt_TenderTransTotal.Size = new System.Drawing.Size(140, 35);
            this.txt_TenderTransTotal.TabIndex = 26;
            this.txt_TenderTransTotal.TabStop = false;
            this.txt_TenderTransTotal.TextChanged += new System.EventHandler(this.txt_TransTotal_TextChanged);
            // 
            // txtDue
            // 
            this.txtDue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDue.Location = new System.Drawing.Point(634, 565);
            this.txtDue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDue.Name = "txtDue";
            this.txtDue.ReadOnly = true;
            this.txtDue.Size = new System.Drawing.Size(140, 35);
            this.txtDue.TabIndex = 27;
            this.txtDue.TabStop = false;
            // 
            // btn_Cash
            // 
            this.btn_Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cash.Location = new System.Drawing.Point(318, 166);
            this.btn_Cash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cash.Name = "btn_Cash";
            this.btn_Cash.Size = new System.Drawing.Size(130, 45);
            this.btn_Cash.TabIndex = 28;
            this.btn_Cash.Text = "CASH";
            this.btn_Cash.UseVisualStyleBackColor = true;
            this.btn_Cash.Click += new System.EventHandler(this.btn_Cash_Click);
            // 
            // btn_Check
            // 
            this.btn_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check.Location = new System.Drawing.Point(480, 166);
            this.btn_Check.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(130, 45);
            this.btn_Check.TabIndex = 29;
            this.btn_Check.Text = "CHECK";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // btn_Credit
            // 
            this.btn_Credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Credit.Location = new System.Drawing.Point(646, 166);
            this.btn_Credit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Credit.Name = "btn_Credit";
            this.btn_Credit.Size = new System.Drawing.Size(164, 45);
            this.btn_Credit.TabIndex = 30;
            this.btn_Credit.Text = "CREDIT CARD";
            this.btn_Credit.UseVisualStyleBackColor = true;
            this.btn_Credit.Click += new System.EventHandler(this.btn_Credit_Click);
            // 
            // btn_GiftCard
            // 
            this.btn_GiftCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GiftCard.Location = new System.Drawing.Point(843, 166);
            this.btn_GiftCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_GiftCard.Name = "btn_GiftCard";
            this.btn_GiftCard.Size = new System.Drawing.Size(130, 45);
            this.btn_GiftCard.TabIndex = 31;
            this.btn_GiftCard.Text = "GIFT CARD";
            this.btn_GiftCard.UseVisualStyleBackColor = true;
            this.btn_GiftCard.Click += new System.EventHandler(this.btn_GiftCard_Click);
            // 
            // txtChange
            // 
            this.txtChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(634, 618);
            this.txtChange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(140, 35);
            this.txtChange.TabIndex = 32;
            this.txtChange.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(94, 348);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 39);
            this.textBox2.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 298);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 29);
            this.label2.TabIndex = 34;
            this.label2.Text = "Check CC GC Number";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1000, 334);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(192, 35);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "DELETE ITEM";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1803, 685);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_ChangeDue);
            this.Controls.Add(this.LB_Due);
            this.Controls.Add(this.LB_Total);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPayment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMOUNT;
        private System.Windows.Forms.Button btnDelete;
    }
}