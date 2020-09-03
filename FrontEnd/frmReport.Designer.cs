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
            this.tabTransactions = new System.Windows.Forms.TabPage();
            this.txtTransNet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTransBottleDeposit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTransNonTax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTransTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgTrans = new System.Windows.Forms.DataGridView();
            this.colTransType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTransRun = new System.Windows.Forms.Button();
            this.tabPCustomer = new System.Windows.Forms.TabPage();
            this.btnOk = new System.Windows.Forms.Button();
            this.tabPage.SuspendLayout();
            this.tabTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrans)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage
            // 
            this.tabPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPage.Controls.Add(this.tabTransactions);
            this.tabPage.Controls.Add(this.tabPCustomer);
            this.tabPage.Location = new System.Drawing.Point(12, 12);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(757, 368);
            this.tabPage.TabIndex = 0;
            // 
            // tabTransactions
            // 
            this.tabTransactions.Controls.Add(this.txtTransNet);
            this.tabTransactions.Controls.Add(this.label5);
            this.tabTransactions.Controls.Add(this.txtTransBottleDeposit);
            this.tabTransactions.Controls.Add(this.label4);
            this.tabTransactions.Controls.Add(this.txtTransNonTax);
            this.tabTransactions.Controls.Add(this.label3);
            this.tabTransactions.Controls.Add(this.txtTax);
            this.tabTransactions.Controls.Add(this.label2);
            this.tabTransactions.Controls.Add(this.txtTransTotal);
            this.tabTransactions.Controls.Add(this.label1);
            this.tabTransactions.Controls.Add(this.dgTrans);
            this.tabTransactions.Controls.Add(this.btnTransRun);
            this.tabTransactions.Location = new System.Drawing.Point(4, 29);
            this.tabTransactions.Name = "tabTransactions";
            this.tabTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransactions.Size = new System.Drawing.Size(749, 335);
            this.tabTransactions.TabIndex = 0;
            this.tabTransactions.Text = "Transactions";
            this.tabTransactions.UseVisualStyleBackColor = true;
            // 
            // txtTransNet
            // 
            this.txtTransNet.Location = new System.Drawing.Point(591, 291);
            this.txtTransNet.Name = "txtTransNet";
            this.txtTransNet.Size = new System.Drawing.Size(100, 26);
            this.txtTransNet.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(453, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Net:";
            // 
            // txtTransBottleDeposit
            // 
            this.txtTransBottleDeposit.Location = new System.Drawing.Point(591, 259);
            this.txtTransBottleDeposit.Name = "txtTransBottleDeposit";
            this.txtTransBottleDeposit.Size = new System.Drawing.Size(100, 26);
            this.txtTransBottleDeposit.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(453, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bottle Deposit:";
            // 
            // txtTransNonTax
            // 
            this.txtTransNonTax.Location = new System.Drawing.Point(591, 227);
            this.txtTransNonTax.Name = "txtTransNonTax";
            this.txtTransNonTax.Size = new System.Drawing.Size(100, 26);
            this.txtTransNonTax.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "NonTax:";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(591, 195);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(100, 26);
            this.txtTax.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tax:";
            // 
            // txtTransTotal
            // 
            this.txtTransTotal.Location = new System.Drawing.Point(591, 163);
            this.txtTransTotal.Name = "txtTransTotal";
            this.txtTransTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTransTotal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total:";
            // 
            // dgTrans
            // 
            this.dgTrans.AllowUserToAddRows = false;
            this.dgTrans.AllowUserToDeleteRows = false;
            this.dgTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTrans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTransType,
            this.colTransQty,
            this.colTransDiscount,
            this.colTransTotal});
            this.dgTrans.Location = new System.Drawing.Point(22, 19);
            this.dgTrans.Name = "dgTrans";
            this.dgTrans.ReadOnly = true;
            this.dgTrans.RowHeadersVisible = false;
            this.dgTrans.RowHeadersWidth = 62;
            this.dgTrans.RowTemplate.Height = 28;
            this.dgTrans.Size = new System.Drawing.Size(411, 295);
            this.dgTrans.TabIndex = 1;
            // 
            // colTransType
            // 
            this.colTransType.HeaderText = "Type";
            this.colTransType.MinimumWidth = 8;
            this.colTransType.Name = "colTransType";
            this.colTransType.ReadOnly = true;
            this.colTransType.Width = 150;
            // 
            // colTransQty
            // 
            this.colTransQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colTransQty.HeaderText = "Qty";
            this.colTransQty.MinimumWidth = 8;
            this.colTransQty.Name = "colTransQty";
            this.colTransQty.ReadOnly = true;
            this.colTransQty.Width = 69;
            // 
            // colTransDiscount
            // 
            this.colTransDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colTransDiscount.HeaderText = "Discount";
            this.colTransDiscount.MinimumWidth = 8;
            this.colTransDiscount.Name = "colTransDiscount";
            this.colTransDiscount.ReadOnly = true;
            this.colTransDiscount.Width = 108;
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
            this.btnTransRun.Location = new System.Drawing.Point(660, 32);
            this.btnTransRun.Name = "btnTransRun";
            this.btnTransRun.Size = new System.Drawing.Size(70, 34);
            this.btnTransRun.TabIndex = 0;
            this.btnTransRun.Text = "&Run";
            this.btnTransRun.UseVisualStyleBackColor = true;
            // 
            // tabPCustomer
            // 
            this.tabPCustomer.Location = new System.Drawing.Point(4, 29);
            this.tabPCustomer.Name = "tabPCustomer";
            this.tabPCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPCustomer.Size = new System.Drawing.Size(749, 335);
            this.tabPCustomer.TabIndex = 1;
            this.tabPCustomer.Text = "Customer";
            this.tabPCustomer.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(660, 390);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(105, 35);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 437);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReport";
            this.Text = "Report";
            this.tabPage.ResumeLayout(false);
            this.tabTransactions.ResumeLayout(false);
            this.tabTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabTransactions;
        private System.Windows.Forms.TabPage tabPCustomer;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtTransNet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTransBottleDeposit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTransNonTax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTransTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgTrans;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransTotal;
        private System.Windows.Forms.Button btnTransRun;
    }
}