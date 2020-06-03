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
            this.LB_CheckAmt = new System.Windows.Forms.Label();
            this.LB_Due = new System.Windows.Forms.Label();
            this.LB_Check = new System.Windows.Forms.Label();
            this.LB_CC = new System.Windows.Forms.Label();
            this.LB_Cash = new System.Windows.Forms.Label();
            this.LB_Total = new System.Windows.Forms.Label();
            this.LB_ChangeDue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_TenderTransTotal = new System.Windows.Forms.TextBox();
            this.LB_RemainingGiftCardBal = new System.Windows.Forms.Label();
            this.btnCompleteSale = new System.Windows.Forms.Button();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.txtCheck = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.txtCreditCardAmt = new System.Windows.Forms.TextBox();
            this.LB_CreditCardAmt = new System.Windows.Forms.Label();
            this.txtCheckAmt = new System.Windows.Forms.TextBox();
            this.txtGiftAmt = new System.Windows.Forms.TextBox();
            this.LB_GiftCertificate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LB_EnterCashAmt = new System.Windows.Forms.Label();
            this.txtCashAmt = new System.Windows.Forms.TextBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_CheckAmt
            // 
            this.LB_CheckAmt.AutoSize = true;
            this.LB_CheckAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CheckAmt.Location = new System.Drawing.Point(80, 177);
            this.LB_CheckAmt.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LB_CheckAmt.Name = "LB_CheckAmt";
            this.LB_CheckAmt.Size = new System.Drawing.Size(130, 20);
            this.LB_CheckAmt.TabIndex = 3;
            this.LB_CheckAmt.Text = "Enter Check Amt";
            this.LB_CheckAmt.Click += new System.EventHandler(this.lCheckAmt_Click);
            // 
            // LB_Due
            // 
            this.LB_Due.AutoSize = true;
            this.LB_Due.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Due.ForeColor = System.Drawing.Color.Crimson;
            this.LB_Due.Location = new System.Drawing.Point(26, 203);
            this.LB_Due.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LB_Due.Name = "LB_Due";
            this.LB_Due.Size = new System.Drawing.Size(62, 26);
            this.LB_Due.TabIndex = 16;
            this.LB_Due.Text = "Due:";
            // 
            // LB_Check
            // 
            this.LB_Check.AutoSize = true;
            this.LB_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Check.Location = new System.Drawing.Point(26, 156);
            this.LB_Check.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LB_Check.Name = "LB_Check";
            this.LB_Check.Size = new System.Drawing.Size(75, 24);
            this.LB_Check.TabIndex = 17;
            this.LB_Check.Text = "Check:";
            // 
            // LB_CC
            // 
            this.LB_CC.AutoSize = true;
            this.LB_CC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CC.Location = new System.Drawing.Point(26, 109);
            this.LB_CC.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LB_CC.Name = "LB_CC";
            this.LB_CC.Size = new System.Drawing.Size(44, 24);
            this.LB_CC.TabIndex = 18;
            this.LB_CC.Text = "CC:";
            // 
            // LB_Cash
            // 
            this.LB_Cash.AutoSize = true;
            this.LB_Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Cash.ForeColor = System.Drawing.Color.Green;
            this.LB_Cash.Location = new System.Drawing.Point(26, 60);
            this.LB_Cash.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LB_Cash.Name = "LB_Cash";
            this.LB_Cash.Size = new System.Drawing.Size(63, 24);
            this.LB_Cash.TabIndex = 19;
            this.LB_Cash.Text = "Cash:";
            // 
            // LB_Total
            // 
            this.LB_Total.AutoSize = true;
            this.LB_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Total.Location = new System.Drawing.Point(26, 16);
            this.LB_Total.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LB_Total.Name = "LB_Total";
            this.LB_Total.Size = new System.Drawing.Size(92, 26);
            this.LB_Total.TabIndex = 20;
            this.LB_Total.Text = "TOTAL:";
            // 
            // LB_ChangeDue
            // 
            this.LB_ChangeDue.AutoSize = true;
            this.LB_ChangeDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ChangeDue.Location = new System.Drawing.Point(26, 247);
            this.LB_ChangeDue.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LB_ChangeDue.Name = "LB_ChangeDue";
            this.LB_ChangeDue.Size = new System.Drawing.Size(151, 26);
            this.LB_ChangeDue.TabIndex = 21;
            this.LB_ChangeDue.Text = "Change Due:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_TenderTransTotal);
            this.panel1.Controls.Add(this.LB_RemainingGiftCardBal);
            this.panel1.Controls.Add(this.btnCompleteSale);
            this.panel1.Controls.Add(this.txtCash);
            this.panel1.Controls.Add(this.txtCheck);
            this.panel1.Controls.Add(this.txtCC);
            this.panel1.Controls.Add(this.LB_ChangeDue);
            this.panel1.Controls.Add(this.LB_Total);
            this.panel1.Controls.Add(this.LB_Cash);
            this.panel1.Controls.Add(this.LB_CC);
            this.panel1.Controls.Add(this.LB_Check);
            this.panel1.Controls.Add(this.LB_Due);
            this.panel1.Location = new System.Drawing.Point(316, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 413);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_TenderTransTotal
            // 
            this.txt_TenderTransTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenderTransTotal.Location = new System.Drawing.Point(183, 16);
            this.txt_TenderTransTotal.Margin = new System.Windows.Forms.Padding(1);
            this.txt_TenderTransTotal.Name = "txt_TenderTransTotal";
            this.txt_TenderTransTotal.ReadOnly = true;
            this.txt_TenderTransTotal.Size = new System.Drawing.Size(95, 26);
            this.txt_TenderTransTotal.TabIndex = 26;
            this.txt_TenderTransTotal.TabStop = false;
            this.txt_TenderTransTotal.TextChanged += new System.EventHandler(this.txt_TransTotal_TextChanged);
            // 
            // LB_RemainingGiftCardBal
            // 
            this.LB_RemainingGiftCardBal.AutoSize = true;
            this.LB_RemainingGiftCardBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_RemainingGiftCardBal.Location = new System.Drawing.Point(26, 291);
            this.LB_RemainingGiftCardBal.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LB_RemainingGiftCardBal.Name = "LB_RemainingGiftCardBal";
            this.LB_RemainingGiftCardBal.Size = new System.Drawing.Size(217, 26);
            this.LB_RemainingGiftCardBal.TabIndex = 25;
            this.LB_RemainingGiftCardBal.Text = "Remaining GC Bal:";
            // 
            // btnCompleteSale
            // 
            this.btnCompleteSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteSale.Location = new System.Drawing.Point(98, 334);
            this.btnCompleteSale.Margin = new System.Windows.Forms.Padding(1);
            this.btnCompleteSale.Name = "btnCompleteSale";
            this.btnCompleteSale.Size = new System.Drawing.Size(177, 44);
            this.btnCompleteSale.TabIndex = 7;
            this.btnCompleteSale.Text = "Complete Sale";
            this.btnCompleteSale.UseVisualStyleBackColor = true;
            this.btnCompleteSale.Click += new System.EventHandler(this.btnCompleteSale_Click);
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(183, 60);
            this.txtCash.Margin = new System.Windows.Forms.Padding(1);
            this.txtCash.Name = "txtCash";
            this.txtCash.ReadOnly = true;
            this.txtCash.Size = new System.Drawing.Size(95, 26);
            this.txtCash.TabIndex = 24;
            // 
            // txtCheck
            // 
            this.txtCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheck.Location = new System.Drawing.Point(183, 158);
            this.txtCheck.Margin = new System.Windows.Forms.Padding(1);
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.ReadOnly = true;
            this.txtCheck.Size = new System.Drawing.Size(95, 26);
            this.txtCheck.TabIndex = 23;
            // 
            // txtCC
            // 
            this.txtCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCC.Location = new System.Drawing.Point(183, 111);
            this.txtCC.Margin = new System.Windows.Forms.Padding(1);
            this.txtCC.Name = "txtCC";
            this.txtCC.ReadOnly = true;
            this.txtCC.Size = new System.Drawing.Size(95, 26);
            this.txtCC.TabIndex = 22;
            // 
            // txtCreditCardAmt
            // 
            this.txtCreditCardAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditCardAmt.Location = new System.Drawing.Point(108, 127);
            this.txtCreditCardAmt.Margin = new System.Windows.Forms.Padding(1);
            this.txtCreditCardAmt.Name = "txtCreditCardAmt";
            this.txtCreditCardAmt.Size = new System.Drawing.Size(95, 26);
            this.txtCreditCardAmt.TabIndex = 0;
            this.txtCreditCardAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // LB_CreditCardAmt
            // 
            this.LB_CreditCardAmt.AutoSize = true;
            this.LB_CreditCardAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CreditCardAmt.Location = new System.Drawing.Point(54, 101);
            this.LB_CreditCardAmt.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LB_CreditCardAmt.Name = "LB_CreditCardAmt";
            this.LB_CreditCardAmt.Size = new System.Drawing.Size(157, 20);
            this.LB_CreditCardAmt.TabIndex = 1;
            this.LB_CreditCardAmt.Text = "Enter Offline CC Amt";
            this.LB_CreditCardAmt.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCheckAmt
            // 
            this.txtCheckAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckAmt.Location = new System.Drawing.Point(108, 207);
            this.txtCheckAmt.Margin = new System.Windows.Forms.Padding(1);
            this.txtCheckAmt.Name = "txtCheckAmt";
            this.txtCheckAmt.Size = new System.Drawing.Size(95, 26);
            this.txtCheckAmt.TabIndex = 2;
            this.txtCheckAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // txtGiftAmt
            // 
            this.txtGiftAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiftAmt.Location = new System.Drawing.Point(108, 291);
            this.txtGiftAmt.Margin = new System.Windows.Forms.Padding(1);
            this.txtGiftAmt.Name = "txtGiftAmt";
            this.txtGiftAmt.Size = new System.Drawing.Size(95, 26);
            this.txtGiftAmt.TabIndex = 4;
            this.txtGiftAmt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtGiftAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // LB_GiftCertificate
            // 
            this.LB_GiftCertificate.AutoSize = true;
            this.LB_GiftCertificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_GiftCertificate.Location = new System.Drawing.Point(59, 262);
            this.LB_GiftCertificate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LB_GiftCertificate.Name = "LB_GiftCertificate";
            this.LB_GiftCertificate.Size = new System.Drawing.Size(154, 20);
            this.LB_GiftCertificate.TabIndex = 5;
            this.LB_GiftCertificate.Text = "Enter Gift Certificate";
            this.LB_GiftCertificate.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LB_EnterCashAmt);
            this.panel2.Controls.Add(this.txtCashAmt);
            this.panel2.Controls.Add(this.btnMainMenu);
            this.panel2.Controls.Add(this.LB_GiftCertificate);
            this.panel2.Controls.Add(this.txtGiftAmt);
            this.panel2.Controls.Add(this.LB_CheckAmt);
            this.panel2.Controls.Add(this.txtCheckAmt);
            this.panel2.Controls.Add(this.LB_CreditCardAmt);
            this.panel2.Controls.Add(this.txtCreditCardAmt);
            this.panel2.Location = new System.Drawing.Point(38, 58);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 414);
            this.panel2.TabIndex = 23;
            // 
            // LB_EnterCashAmt
            // 
            this.LB_EnterCashAmt.AutoSize = true;
            this.LB_EnterCashAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_EnterCashAmt.Location = new System.Drawing.Point(88, 27);
            this.LB_EnterCashAmt.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LB_EnterCashAmt.Name = "LB_EnterCashAmt";
            this.LB_EnterCashAmt.Size = new System.Drawing.Size(122, 20);
            this.LB_EnterCashAmt.TabIndex = 8;
            this.LB_EnterCashAmt.Text = "Enter Cash Amt";
            this.LB_EnterCashAmt.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCashAmt
            // 
            this.txtCashAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashAmt.Location = new System.Drawing.Point(108, 56);
            this.txtCashAmt.Margin = new System.Windows.Forms.Padding(1);
            this.txtCashAmt.Name = "txtCashAmt";
            this.txtCashAmt.Size = new System.Drawing.Size(95, 26);
            this.txtCashAmt.TabIndex = 7;
            this.txtCashAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOnly);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(72, 334);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(1);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(129, 44);
            this.btnMainMenu.TabIndex = 6;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "PAYMENT";
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 499);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPayment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LB_CheckAmt;
        private System.Windows.Forms.Label LB_Due;
        private System.Windows.Forms.Label LB_Check;
        private System.Windows.Forms.Label LB_CC;
        private System.Windows.Forms.Label LB_Cash;
        private System.Windows.Forms.Label LB_Total;
        private System.Windows.Forms.Label LB_ChangeDue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCompleteSale;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.TextBox txtCheck;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.TextBox txtCreditCardAmt;
        private System.Windows.Forms.Label LB_CreditCardAmt;
        private System.Windows.Forms.TextBox txtCheckAmt;
        private System.Windows.Forms.TextBox txtGiftAmt;
        private System.Windows.Forms.Label LB_GiftCertificate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_EnterCashAmt;
        private System.Windows.Forms.TextBox txtCashAmt;
        private System.Windows.Forms.Label LB_RemainingGiftCardBal;
        private System.Windows.Forms.TextBox txt_TenderTransTotal;
    }
}