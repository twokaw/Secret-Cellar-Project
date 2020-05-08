namespace SecretCellar
{
    partial class frmDiscount
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
            this.rbtnLineItemDiscount = new System.Windows.Forms.RadioButton();
            this.rbtnDiscountTotalSale = new System.Windows.Forms.RadioButton();
            this.rbtnFixedDiscountTotalSale = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Discount = new System.Windows.Forms.Label();
            this.btnDiscountCancel = new System.Windows.Forms.Button();
            this.btnDiscountClear = new System.Windows.Forms.Button();
            this.btnApplyDiscount = new System.Windows.Forms.Button();
            this.LDiscountScreen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbtnLineItemDiscount
            // 
            this.rbtnLineItemDiscount.AutoSize = true;
            this.rbtnLineItemDiscount.FlatAppearance.BorderSize = 0;
            this.rbtnLineItemDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnLineItemDiscount.Location = new System.Drawing.Point(36, 100);
            this.rbtnLineItemDiscount.Name = "rbtnLineItemDiscount";
            this.rbtnLineItemDiscount.Size = new System.Drawing.Size(433, 50);
            this.rbtnLineItemDiscount.TabIndex = 0;
            this.rbtnLineItemDiscount.TabStop = true;
            this.rbtnLineItemDiscount.Text = "% Discount Line Item";
            this.rbtnLineItemDiscount.UseVisualStyleBackColor = true;
            this.rbtnLineItemDiscount.CheckedChanged += new System.EventHandler(this.rbtnLineItemDiscount_CheckedChanged);
            // 
            // rbtnDiscountTotalSale
            // 
            this.rbtnDiscountTotalSale.AutoSize = true;
            this.rbtnDiscountTotalSale.FlatAppearance.BorderSize = 0;
            this.rbtnDiscountTotalSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDiscountTotalSale.Location = new System.Drawing.Point(504, 100);
            this.rbtnDiscountTotalSale.Name = "rbtnDiscountTotalSale";
            this.rbtnDiscountTotalSale.Size = new System.Drawing.Size(496, 50);
            this.rbtnDiscountTotalSale.TabIndex = 1;
            this.rbtnDiscountTotalSale.TabStop = true;
            this.rbtnDiscountTotalSale.Text = "% Discount to Total Sale";
            this.rbtnDiscountTotalSale.UseVisualStyleBackColor = true;
            // 
            // rbtnFixedDiscountTotalSale
            // 
            this.rbtnFixedDiscountTotalSale.AutoSize = true;
            this.rbtnFixedDiscountTotalSale.FlatAppearance.BorderSize = 0;
            this.rbtnFixedDiscountTotalSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFixedDiscountTotalSale.Location = new System.Drawing.Point(1033, 100);
            this.rbtnFixedDiscountTotalSale.Name = "rbtnFixedDiscountTotalSale";
            this.rbtnFixedDiscountTotalSale.Size = new System.Drawing.Size(559, 50);
            this.rbtnFixedDiscountTotalSale.TabIndex = 2;
            this.rbtnFixedDiscountTotalSale.TabStop = true;
            this.rbtnFixedDiscountTotalSale.Text = "Fixed Discount to Total Sale";
            this.rbtnFixedDiscountTotalSale.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(690, 307);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 53);
            this.textBox1.TabIndex = 3;
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount.Location = new System.Drawing.Point(666, 258);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(297, 46);
            this.Discount.TabIndex = 4;
            this.Discount.Text = "Enter Discount";
            this.Discount.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDiscountCancel
            // 
            this.btnDiscountCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscountCancel.Location = new System.Drawing.Point(78, 422);
            this.btnDiscountCancel.Name = "btnDiscountCancel";
            this.btnDiscountCancel.Size = new System.Drawing.Size(239, 168);
            this.btnDiscountCancel.TabIndex = 5;
            this.btnDiscountCancel.Text = "Cancel";
            this.btnDiscountCancel.UseVisualStyleBackColor = true;
            // 
            // btnDiscountClear
            // 
            this.btnDiscountClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscountClear.Location = new System.Drawing.Point(702, 422);
            this.btnDiscountClear.Name = "btnDiscountClear";
            this.btnDiscountClear.Size = new System.Drawing.Size(239, 168);
            this.btnDiscountClear.TabIndex = 6;
            this.btnDiscountClear.Text = "Clear";
            this.btnDiscountClear.UseVisualStyleBackColor = true;
            // 
            // btnApplyDiscount
            // 
            this.btnApplyDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyDiscount.Location = new System.Drawing.Point(1353, 422);
            this.btnApplyDiscount.Name = "btnApplyDiscount";
            this.btnApplyDiscount.Size = new System.Drawing.Size(239, 168);
            this.btnApplyDiscount.TabIndex = 7;
            this.btnApplyDiscount.Text = "Apply Discount";
            this.btnApplyDiscount.UseVisualStyleBackColor = true;
            // 
            // LDiscountScreen
            // 
            this.LDiscountScreen.AutoSize = true;
            this.LDiscountScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDiscountScreen.Location = new System.Drawing.Point(586, 23);
            this.LDiscountScreen.Name = "LDiscountScreen";
            this.LDiscountScreen.Size = new System.Drawing.Size(485, 54);
            this.LDiscountScreen.TabIndex = 8;
            this.LDiscountScreen.Text = "Select Discount Type";
            // 
            // frmDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1716, 770);
            this.Controls.Add(this.LDiscountScreen);
            this.Controls.Add(this.btnApplyDiscount);
            this.Controls.Add(this.btnDiscountClear);
            this.Controls.Add(this.btnDiscountCancel);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rbtnFixedDiscountTotalSale);
            this.Controls.Add(this.rbtnDiscountTotalSale);
            this.Controls.Add(this.rbtnLineItemDiscount);
            this.Name = "frmDiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDiscount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnLineItemDiscount;
        private System.Windows.Forms.RadioButton rbtnDiscountTotalSale;
        private System.Windows.Forms.RadioButton rbtnFixedDiscountTotalSale;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.Button btnDiscountCancel;
        private System.Windows.Forms.Button btnDiscountClear;
        private System.Windows.Forms.Button btnApplyDiscount;
        private System.Windows.Forms.Label LDiscountScreen;
    }
}