
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
            this.label1.Location = new System.Drawing.Point(122, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item:";
            // 
            // LblItem
            // 
            this.LblItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblItem.Location = new System.Drawing.Point(214, 22);
            this.LblItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblItem.Name = "LblItem";
            this.LblItem.Size = new System.Drawing.Size(588, 58);
            this.LblItem.TabIndex = 1;
            this.LblItem.Text = "label2";
            this.LblItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblPrice
            // 
            this.LblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(214, 104);
            this.LblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(180, 58);
            this.LblPrice.TabIndex = 9;
            this.LblPrice.Text = "label7";
            this.LblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(110, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 32);
            this.label8.TabIndex = 8;
            this.label8.Text = "Price:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(570, 273);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 32);
            this.label11.TabIndex = 3;
            this.label11.Text = "Items:";
            // 
            // TxtQty
            // 
            this.TxtQty.Enabled = false;
            this.TxtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQty.Location = new System.Drawing.Point(214, 264);
            this.TxtQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtQty.Name = "TxtQty";
            this.TxtQty.Size = new System.Drawing.Size(313, 39);
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
            this.LblQty.Location = new System.Drawing.Point(668, 261);
            this.LblQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblQty.Name = "LblQty";
            this.LblQty.Size = new System.Drawing.Size(135, 58);
            this.LblQty.TabIndex = 5;
            this.LblQty.Text = "0";
            this.LblQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(132, 268);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 32);
            this.label14.TabIndex = 7;
            this.label14.Text = "Qty:";
            // 
            // LblTotalRefund
            // 
            this.LblTotalRefund.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTotalRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalRefund.Location = new System.Drawing.Point(216, 336);
            this.LblTotalRefund.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTotalRefund.Name = "LblTotalRefund";
            this.LblTotalRefund.Size = new System.Drawing.Size(316, 58);
            this.LblTotalRefund.TabIndex = 11;
            this.LblTotalRefund.Text = "label3";
            this.LblTotalRefund.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 348);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Refund:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Restock Fee:";
            // 
            // BtnOk
            // 
            this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOk.Location = new System.Drawing.Point(260, 479);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(264, 70);
            this.BtnOk.TabIndex = 16;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(538, 479);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(266, 70);
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
            this.LblRefund.Location = new System.Drawing.Point(668, 109);
            this.LblRefund.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRefund.Name = "LblRefund";
            this.LblRefund.Size = new System.Drawing.Size(135, 58);
            this.LblRefund.TabIndex = 19;
            this.LblRefund.Text = "label3";
            this.LblRefund.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(472, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "Refund Price:";
            // 
            // ChkRestock
            // 
            this.ChkRestock.AutoSize = true;
            this.ChkRestock.Checked = true;
            this.ChkRestock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkRestock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkRestock.Location = new System.Drawing.Point(72, 420);
            this.ChkRestock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChkRestock.Name = "ChkRestock";
            this.ChkRestock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ChkRestock.Size = new System.Drawing.Size(150, 36);
            this.ChkRestock.TabIndex = 21;
            this.ChkRestock.Text = ":Restock";
            this.ChkRestock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkRestock.UseVisualStyleBackColor = true;
            // 
            // TxtFee
            // 
            this.TxtFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFee.ForeColor = System.Drawing.Color.Black;
            this.TxtFee.Location = new System.Drawing.Point(214, 187);
            this.TxtFee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtFee.Name = "TxtFee";
            this.TxtFee.Size = new System.Drawing.Size(313, 39);
            this.TxtFee.TabIndex = 18;
            this.TxtFee.Text = "$0.00";
            this.TxtFee.Value = 0D;
            this.TxtFee.TextChanged += new System.EventHandler(this.TxtFee_TextChanged);
            this.TxtFee.Enter += new System.EventHandler(this.TxtFee_Enter);
            // 
            // frmReturnItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 568);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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