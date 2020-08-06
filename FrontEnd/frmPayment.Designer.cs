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
            this.LB_EnterAmt = new System.Windows.Forms.Label();
            this.txtCashAmt = new System.Windows.Forms.TextBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.paymentType = new System.Windows.Forms.DataGridView();
            this.CASH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHECK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LB_Due = new System.Windows.Forms.Label();
            this.LB_Total = new System.Windows.Forms.Label();
            this.LB_ChangeDue = new System.Windows.Forms.Label();
            this.btnCompleteSale = new System.Windows.Forms.Button();
            this.LB_RemainingGiftCardBal = new System.Windows.Forms.Label();
            this.txt_TenderTransTotal = new System.Windows.Forms.TextBox();
            this.txtDue = new System.Windows.Forms.TextBox();
            this.btn_Cash = new System.Windows.Forms.Button();
            this.btn_Check = new System.Windows.Forms.Button();
            this.btn_Credit = new System.Windows.Forms.Button();
            this.btn_GiftCard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paymentType)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_EnterAmt
            // 
            this.LB_EnterAmt.AutoSize = true;
            this.LB_EnterAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_EnterAmt.Location = new System.Drawing.Point(583, 46);
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
            this.txtCashAmt.Location = new System.Drawing.Point(588, 100);
            this.txtCashAmt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtCashAmt.Name = "txtCashAmt";
            this.txtCashAmt.Size = new System.Drawing.Size(141, 39);
            this.txtCashAmt.TabIndex = 7;
            this.txtCashAmt.TextChanged += new System.EventHandler(this.txtCashAmt_TextChanged);
            this.txtCashAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(33, 601);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
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
            this.paymentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CASH,
            this.CHECK});
            this.paymentType.Location = new System.Drawing.Point(534, 238);
            this.paymentType.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.paymentType.Name = "paymentType";
            this.paymentType.RowHeadersVisible = false;
            this.paymentType.RowHeadersWidth = 102;
            this.paymentType.RowTemplate.Height = 40;
            this.paymentType.Size = new System.Drawing.Size(224, 106);
            this.paymentType.TabIndex = 9;
            this.paymentType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paymentType_CellContentClick);
            // 
            // CASH
            // 
            this.CASH.HeaderText = "TYPE";
            this.CASH.MinimumWidth = 12;
            this.CASH.Name = "CASH";
            this.CASH.Width = 150;
            // 
            // CHECK
            // 
            this.CHECK.HeaderText = "AMOUNT";
            this.CHECK.MinimumWidth = 12;
            this.CHECK.Name = "CHECK";
            this.CHECK.Width = 150;
            // 
            // LB_Due
            // 
            this.LB_Due.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Due.AutoSize = true;
            this.LB_Due.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Due.ForeColor = System.Drawing.Color.Crimson;
            this.LB_Due.Location = new System.Drawing.Point(942, 372);
            this.LB_Due.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Due.Name = "LB_Due";
            this.LB_Due.Size = new System.Drawing.Size(88, 37);
            this.LB_Due.TabIndex = 16;
            this.LB_Due.Text = "Due:";
            // 
            // LB_Total
            // 
            this.LB_Total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Total.AutoSize = true;
            this.LB_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Total.Location = new System.Drawing.Point(513, 372);
            this.LB_Total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_Total.Name = "LB_Total";
            this.LB_Total.Size = new System.Drawing.Size(137, 37);
            this.LB_Total.TabIndex = 20;
            this.LB_Total.Text = "TOTAL:";
            // 
            // LB_ChangeDue
            // 
            this.LB_ChangeDue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_ChangeDue.AutoSize = true;
            this.LB_ChangeDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ChangeDue.Location = new System.Drawing.Point(585, 460);
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
            this.btnCompleteSale.Location = new System.Drawing.Point(1004, 601);
            this.btnCompleteSale.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCompleteSale.Name = "btnCompleteSale";
            this.btnCompleteSale.Size = new System.Drawing.Size(266, 68);
            this.btnCompleteSale.TabIndex = 7;
            this.btnCompleteSale.Text = "Complete Sale";
            this.btnCompleteSale.UseVisualStyleBackColor = true;
            this.btnCompleteSale.Click += new System.EventHandler(this.btnCompleteSale_Click);
            // 
            // LB_RemainingGiftCardBal
            // 
            this.LB_RemainingGiftCardBal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_RemainingGiftCardBal.AutoSize = true;
            this.LB_RemainingGiftCardBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_RemainingGiftCardBal.Location = new System.Drawing.Point(500, 534);
            this.LB_RemainingGiftCardBal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_RemainingGiftCardBal.Name = "LB_RemainingGiftCardBal";
            this.LB_RemainingGiftCardBal.Size = new System.Drawing.Size(307, 37);
            this.LB_RemainingGiftCardBal.TabIndex = 25;
            this.LB_RemainingGiftCardBal.Text = "Remaining GC Bal:";
            // 
            // txt_TenderTransTotal
            // 
            this.txt_TenderTransTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenderTransTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenderTransTotal.Location = new System.Drawing.Point(646, 379);
            this.txt_TenderTransTotal.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txt_TenderTransTotal.Name = "txt_TenderTransTotal";
            this.txt_TenderTransTotal.ReadOnly = true;
            this.txt_TenderTransTotal.Size = new System.Drawing.Size(141, 35);
            this.txt_TenderTransTotal.TabIndex = 26;
            this.txt_TenderTransTotal.TabStop = false;
            this.txt_TenderTransTotal.TextChanged += new System.EventHandler(this.txt_TransTotal_TextChanged);
            // 
            // txtDue
            // 
            this.txtDue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDue.Location = new System.Drawing.Point(1032, 379);
            this.txtDue.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtDue.Name = "txtDue";
            this.txtDue.ReadOnly = true;
            this.txtDue.Size = new System.Drawing.Size(141, 35);
            this.txtDue.TabIndex = 27;
            this.txtDue.TabStop = false;
            // 
            // btn_Cash
            // 
            this.btn_Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cash.Location = new System.Drawing.Point(318, 166);
            this.btn_Cash.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_Cash.Name = "btn_Cash";
            this.btn_Cash.Size = new System.Drawing.Size(130, 45);
            this.btn_Cash.TabIndex = 28;
            this.btn_Cash.Text = "CASH";
            this.btn_Cash.UseVisualStyleBackColor = true;
            // 
            // btn_Check
            // 
            this.btn_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check.Location = new System.Drawing.Point(480, 166);
            this.btn_Check.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(130, 45);
            this.btn_Check.TabIndex = 29;
            this.btn_Check.Text = "CHECK";
            this.btn_Check.UseVisualStyleBackColor = true;
            // 
            // btn_Credit
            // 
            this.btn_Credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Credit.Location = new System.Drawing.Point(646, 166);
            this.btn_Credit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_Credit.Name = "btn_Credit";
            this.btn_Credit.Size = new System.Drawing.Size(164, 45);
            this.btn_Credit.TabIndex = 30;
            this.btn_Credit.Text = "CREDIT CARD";
            this.btn_Credit.UseVisualStyleBackColor = true;
            // 
            // btn_GiftCard
            // 
            this.btn_GiftCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GiftCard.Location = new System.Drawing.Point(843, 166);
            this.btn_GiftCard.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_GiftCard.Name = "btn_GiftCard";
            this.btn_GiftCard.Size = new System.Drawing.Size(130, 45);
            this.btn_GiftCard.TabIndex = 31;
            this.btn_GiftCard.Text = "GIFT CARD";
            this.btn_GiftCard.UseVisualStyleBackColor = true;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 685);
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
            this.Controls.Add(this.LB_RemainingGiftCardBal);
            this.Controls.Add(this.LB_ChangeDue);
            this.Controls.Add(this.LB_Due);
            this.Controls.Add(this.LB_Total);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
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
        private System.Windows.Forms.Label LB_RemainingGiftCardBal;
        private System.Windows.Forms.TextBox txt_TenderTransTotal;
        private System.Windows.Forms.TextBox txtDue;
        private System.Windows.Forms.Button btn_Cash;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Button btn_Credit;
        private System.Windows.Forms.Button btn_GiftCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn CASH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHECK;
    }
}