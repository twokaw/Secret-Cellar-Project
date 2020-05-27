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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.LB_CheckAmt.Location = new System.Drawing.Point(213, 422);
            this.LB_CheckAmt.Name = "LB_CheckAmt";
            this.LB_CheckAmt.Size = new System.Drawing.Size(322, 46);
            this.LB_CheckAmt.TabIndex = 3;
            this.LB_CheckAmt.Text = "Enter Check Amt";
            this.LB_CheckAmt.Click += new System.EventHandler(this.lCheckAmt_Click);
            // 
            // LB_Due
            // 
            this.LB_Due.AutoSize = true;
            this.LB_Due.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Due.ForeColor = System.Drawing.Color.Crimson;
            this.LB_Due.Location = new System.Drawing.Point(69, 484);
            this.LB_Due.Name = "LB_Due";
            this.LB_Due.Size = new System.Drawing.Size(145, 63);
            this.LB_Due.TabIndex = 16;
            this.LB_Due.Text = "Due:";
            // 
            // LB_Check
            // 
            this.LB_Check.AutoSize = true;
            this.LB_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Check.Location = new System.Drawing.Point(69, 372);
            this.LB_Check.Name = "LB_Check";
            this.LB_Check.Size = new System.Drawing.Size(176, 54);
            this.LB_Check.TabIndex = 17;
            this.LB_Check.Text = "Check:";
            // 
            // LB_CC
            // 
            this.LB_CC.AutoSize = true;
            this.LB_CC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CC.Location = new System.Drawing.Point(69, 260);
            this.LB_CC.Name = "LB_CC";
            this.LB_CC.Size = new System.Drawing.Size(107, 54);
            this.LB_CC.TabIndex = 18;
            this.LB_CC.Text = "CC:";
            // 
            // LB_Cash
            // 
            this.LB_Cash.AutoSize = true;
            this.LB_Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Cash.ForeColor = System.Drawing.Color.Green;
            this.LB_Cash.Location = new System.Drawing.Point(69, 143);
            this.LB_Cash.Name = "LB_Cash";
            this.LB_Cash.Size = new System.Drawing.Size(151, 54);
            this.LB_Cash.TabIndex = 19;
            this.LB_Cash.Text = "Cash:";
            // 
            // LB_Total
            // 
            this.LB_Total.AutoSize = true;
            this.LB_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Total.Location = new System.Drawing.Point(69, 38);
            this.LB_Total.Name = "LB_Total";
            this.LB_Total.Size = new System.Drawing.Size(222, 63);
            this.LB_Total.TabIndex = 20;
            this.LB_Total.Text = "TOTAL:";
            // 
            // LB_ChangeDue
            // 
            this.LB_ChangeDue.AutoSize = true;
            this.LB_ChangeDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ChangeDue.Location = new System.Drawing.Point(69, 589);
            this.LB_ChangeDue.Name = "LB_ChangeDue";
            this.LB_ChangeDue.Size = new System.Drawing.Size(355, 63);
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
            this.panel1.Location = new System.Drawing.Point(843, 138);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 982);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_TenderTransTotal
            // 
            this.txt_TenderTransTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenderTransTotal.Location = new System.Drawing.Point(488, 38);
            this.txt_TenderTransTotal.Name = "txt_TenderTransTotal";
            this.txt_TenderTransTotal.ReadOnly = true;
            this.txt_TenderTransTotal.Size = new System.Drawing.Size(247, 53);
            this.txt_TenderTransTotal.TabIndex = 26;
            this.txt_TenderTransTotal.TabStop = false;
            this.txt_TenderTransTotal.TextChanged += new System.EventHandler(this.txt_TransTotal_TextChanged);
            // 
            // LB_RemainingGiftCardBal
            // 
            this.LB_RemainingGiftCardBal.AutoSize = true;
            this.LB_RemainingGiftCardBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_RemainingGiftCardBal.Location = new System.Drawing.Point(69, 694);
            this.LB_RemainingGiftCardBal.Name = "LB_RemainingGiftCardBal";
            this.LB_RemainingGiftCardBal.Size = new System.Drawing.Size(507, 63);
            this.LB_RemainingGiftCardBal.TabIndex = 25;
            this.LB_RemainingGiftCardBal.Text = "Remaining GC Bal:";
            // 
            // btnCompleteSale
            // 
            this.btnCompleteSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteSale.Location = new System.Drawing.Point(261, 796);
            this.btnCompleteSale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompleteSale.Name = "btnCompleteSale";
            this.btnCompleteSale.Size = new System.Drawing.Size(472, 105);
            this.btnCompleteSale.TabIndex = 7;
            this.btnCompleteSale.Text = "Complete Sale";
            this.btnCompleteSale.UseVisualStyleBackColor = true;
            this.btnCompleteSale.Click += new System.EventHandler(this.btnCompleteSale_Click);
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(488, 143);
            this.txtCash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(247, 53);
            this.txtCash.TabIndex = 24;
            // 
            // txtCheck
            // 
            this.txtCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheck.Location = new System.Drawing.Point(488, 377);
            this.txtCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.Size = new System.Drawing.Size(247, 53);
            this.txtCheck.TabIndex = 23;
            // 
            // txtCC
            // 
            this.txtCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCC.Location = new System.Drawing.Point(488, 265);
            this.txtCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(247, 53);
            this.txtCC.TabIndex = 22;
            // 
            // txtCreditCardAmt
            // 
            this.txtCreditCardAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditCardAmt.Location = new System.Drawing.Point(288, 303);
            this.txtCreditCardAmt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreditCardAmt.Name = "txtCreditCardAmt";
            this.txtCreditCardAmt.Size = new System.Drawing.Size(247, 53);
            this.txtCreditCardAmt.TabIndex = 0;
            // 
            // LB_CreditCardAmt
            // 
            this.LB_CreditCardAmt.AutoSize = true;
            this.LB_CreditCardAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CreditCardAmt.Location = new System.Drawing.Point(144, 241);
            this.LB_CreditCardAmt.Name = "LB_CreditCardAmt";
            this.LB_CreditCardAmt.Size = new System.Drawing.Size(392, 46);
            this.LB_CreditCardAmt.TabIndex = 1;
            this.LB_CreditCardAmt.Text = "Enter Offline CC Amt";
            this.LB_CreditCardAmt.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(288, 494);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 53);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(288, 694);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(247, 53);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LB_GiftCertificate
            // 
            this.LB_GiftCertificate.AutoSize = true;
            this.LB_GiftCertificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_GiftCertificate.Location = new System.Drawing.Point(157, 625);
            this.LB_GiftCertificate.Name = "LB_GiftCertificate";
            this.LB_GiftCertificate.Size = new System.Drawing.Size(379, 46);
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
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.LB_CheckAmt);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.LB_CreditCardAmt);
            this.panel2.Controls.Add(this.txtCreditCardAmt);
            this.panel2.Location = new System.Drawing.Point(101, 138);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 984);
            this.panel2.TabIndex = 23;
            // 
            // LB_EnterCashAmt
            // 
            this.LB_EnterCashAmt.AutoSize = true;
            this.LB_EnterCashAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_EnterCashAmt.Location = new System.Drawing.Point(235, 64);
            this.LB_EnterCashAmt.Name = "LB_EnterCashAmt";
            this.LB_EnterCashAmt.Size = new System.Drawing.Size(301, 46);
            this.LB_EnterCashAmt.TabIndex = 8;
            this.LB_EnterCashAmt.Text = "Enter Cash Amt";
            this.LB_EnterCashAmt.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCashAmt
            // 
            this.txtCashAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCashAmt.Location = new System.Drawing.Point(288, 134);
            this.txtCashAmt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCashAmt.Name = "txtCashAmt";
            this.txtCashAmt.Size = new System.Drawing.Size(247, 53);
            this.txtCashAmt.TabIndex = 7;
            this.txtCashAmt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(192, 796);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(344, 105);
            this.btnMainMenu.TabIndex = 6;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 63);
            this.label1.TabIndex = 24;
            this.label1.Text = "PAYMENT";
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1925, 1061);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
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