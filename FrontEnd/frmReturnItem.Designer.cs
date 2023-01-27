
namespace SecretCellar
{
    partial class frmReturnItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturnItem));
            this.label1 = new System.Windows.Forms.Label();
            this.LblItem = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtQty = new System.Windows.Forms.TextBox();
            this.LblQty = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LblTotalRefund = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblRefund = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChkRestock = new System.Windows.Forms.CheckBox();
            this.TxtFee = new SecretCellar.CurrencyBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item:";
            // 
            // LblItem
            // 
            this.LblItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblItem.Location = new System.Drawing.Point(143, 15);
            this.LblItem.Name = "LblItem";
            this.LblItem.Size = new System.Drawing.Size(392, 40);
            this.LblItem.TabIndex = 1;
            this.LblItem.Text = "label2";
            this.LblItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblPrice
            // 
            this.LblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(143, 72);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(120, 40);
            this.LblPrice.TabIndex = 9;
            this.LblPrice.Text = "label7";
            this.LblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(73, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Price:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(380, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 24);
            this.label11.TabIndex = 3;
            this.label11.Text = "Items:";
            // 
            // TxtQty
            // 
            this.TxtQty.Enabled = false;
            this.TxtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQty.Location = new System.Drawing.Point(143, 182);
            this.TxtQty.Name = "TxtQty";
            this.TxtQty.Size = new System.Drawing.Size(210, 29);
            this.TxtQty.TabIndex = 2;
            this.TxtQty.Text = "1";
            this.TxtQty.TextChanged += new System.EventHandler(this.TxtQty_TextChanged);
            this.TxtQty.Enter += new System.EventHandler(this.TxtQty_Enter);
            this.TxtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQty_KeyPress);
            // 
            // LblQty
            // 
            this.LblQty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblQty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQty.Location = new System.Drawing.Point(445, 180);
            this.LblQty.Name = "LblQty";
            this.LblQty.Size = new System.Drawing.Size(90, 40);
            this.LblQty.TabIndex = 5;
            this.LblQty.Text = "0";
            this.LblQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(88, 185);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 24);
            this.label14.TabIndex = 7;
            this.label14.Text = "Qty:";
            // 
            // LblTotalRefund
            // 
            this.LblTotalRefund.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTotalRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalRefund.Location = new System.Drawing.Point(144, 232);
            this.LblTotalRefund.Name = "LblTotalRefund";
            this.LblTotalRefund.Size = new System.Drawing.Size(211, 40);
            this.LblTotalRefund.TabIndex = 11;
            this.LblTotalRefund.Text = "label3";
            this.LblTotalRefund.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Refund:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Restock Fee:";
            // 
            // BtnOk
            // 
            this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOk.Location = new System.Drawing.Point(173, 330);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(176, 48);
            this.BtnOk.TabIndex = 16;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(359, 330);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(177, 48);
            this.BtnCancel.TabIndex = 17;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // LblRefund
            // 
            this.LblRefund.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblRefund.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRefund.Location = new System.Drawing.Point(445, 75);
            this.LblRefund.Name = "LblRefund";
            this.LblRefund.Size = new System.Drawing.Size(90, 40);
            this.LblRefund.TabIndex = 19;
            this.LblRefund.Text = "label3";
            this.LblRefund.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Refund Price:";
            // 
            // ChkRestock
            // 
            this.ChkRestock.AutoSize = true;
            this.ChkRestock.Checked = true;
            this.ChkRestock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkRestock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkRestock.Location = new System.Drawing.Point(48, 290);
            this.ChkRestock.Name = "ChkRestock";
            this.ChkRestock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChkRestock.Size = new System.Drawing.Size(101, 28);
            this.ChkRestock.TabIndex = 21;
            this.ChkRestock.Text = ":Restock";
            this.ChkRestock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkRestock.UseVisualStyleBackColor = true;
            // 
            // TxtFee
            // 
            this.TxtFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFee.ForeColor = System.Drawing.Color.Black;
            this.TxtFee.Location = new System.Drawing.Point(143, 129);
            this.TxtFee.Name = "TxtFee";
            this.TxtFee.Size = new System.Drawing.Size(210, 29);
            this.TxtFee.TabIndex = 18;
            this.TxtFee.Text = "$0.00";
            this.TxtFee.Value = 0D;
            this.TxtFee.TextChanged += new System.EventHandler(this.TxtFee_TextChanged);
            this.TxtFee.Enter += new System.EventHandler(this.TxtFee_Enter);
            // 
            // frmReturnItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 392);
            this.Controls.Add(this.ChkRestock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblRefund);
            this.Controls.Add(this.TxtFee);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblTotalRefund);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.LblQty);
            this.Controls.Add(this.TxtQty);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LblItem);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReturnItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Return";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblItem;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtQty;
        private System.Windows.Forms.Label LblQty;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LblTotalRefund;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;
        private CurrencyBox TxtFee;
        private System.Windows.Forms.Label LblRefund;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ChkRestock;
    }
}