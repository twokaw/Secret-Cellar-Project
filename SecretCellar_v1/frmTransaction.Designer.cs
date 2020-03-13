namespace SecretCellar
{
    partial class frmTransaction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DISCOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOTTLE_DEPOSIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LB_SubTotal = new System.Windows.Forms.Label();
            this.LB_Tax = new System.Windows.Forms.Label();
            this.LB_TOTAL = new System.Windows.Forms.Label();
            this.LB_BTLDPT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ITEM,
            this.QTY,
            this.DESCRIPTION,
            this.PRICE,
            this.DISCOUNT,
            this.TAX,
            this.BOTTLE_DEPOSIT,
            this.TOTAL});
            this.dataGridView1.Location = new System.Drawing.Point(42, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1973, 457);
            this.dataGridView1.TabIndex = 2;
            // 
            // col_ITEM
            // 
            this.col_ITEM.HeaderText = "ITEM";
            this.col_ITEM.MinimumWidth = 12;
            this.col_ITEM.Name = "col_ITEM";
            this.col_ITEM.Width = 250;
            // 
            // QTY
            // 
            this.QTY.HeaderText = "QTY";
            this.QTY.MinimumWidth = 12;
            this.QTY.Name = "QTY";
            this.QTY.Width = 250;
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.HeaderText = "DESCRIPTION";
            this.DESCRIPTION.MinimumWidth = 12;
            this.DESCRIPTION.Name = "DESCRIPTION";
            this.DESCRIPTION.Width = 250;
            // 
            // PRICE
            // 
            this.PRICE.HeaderText = "PRICE";
            this.PRICE.MinimumWidth = 12;
            this.PRICE.Name = "PRICE";
            this.PRICE.Width = 250;
            // 
            // DISCOUNT
            // 
            this.DISCOUNT.HeaderText = "DISCOUNT";
            this.DISCOUNT.MinimumWidth = 12;
            this.DISCOUNT.Name = "DISCOUNT";
            this.DISCOUNT.Width = 250;
            // 
            // TAX
            // 
            this.TAX.HeaderText = "TAX";
            this.TAX.MinimumWidth = 12;
            this.TAX.Name = "TAX";
            this.TAX.Width = 250;
            // 
            // BOTTLE_DEPOSIT
            // 
            this.BOTTLE_DEPOSIT.HeaderText = "BOTTLE DEPOSIT";
            this.BOTTLE_DEPOSIT.MinimumWidth = 12;
            this.BOTTLE_DEPOSIT.Name = "BOTTLE_DEPOSIT";
            this.BOTTLE_DEPOSIT.Width = 250;
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.MinimumWidth = 12;
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Width = 250;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 602);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 106);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 780);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 106);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 962);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(265, 106);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(402, 962);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(265, 106);
            this.button4.TabIndex = 8;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(402, 780);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(265, 106);
            this.button5.TabIndex = 7;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(402, 602);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(265, 106);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(772, 962);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(265, 106);
            this.button7.TabIndex = 11;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(772, 780);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(265, 106);
            this.button8.TabIndex = 10;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(772, 602);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(265, 106);
            this.button9.TabIndex = 9;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1093, 649);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(330, 369);
            this.button10.TabIndex = 12;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LB_TOTAL);
            this.panel1.Controls.Add(this.LB_BTLDPT);
            this.panel1.Controls.Add(this.LB_Tax);
            this.panel1.Controls.Add(this.LB_SubTotal);
            this.panel1.Location = new System.Drawing.Point(1595, 577);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 285);
            this.panel1.TabIndex = 13;
            // 
            // LB_SubTotal
            // 
            this.LB_SubTotal.AutoSize = true;
            this.LB_SubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_SubTotal.Location = new System.Drawing.Point(23, 22);
            this.LB_SubTotal.Name = "LB_SubTotal";
            this.LB_SubTotal.Size = new System.Drawing.Size(180, 32);
            this.LB_SubTotal.TabIndex = 0;
            this.LB_SubTotal.Text = "SUB TOTAL";
            this.LB_SubTotal.Click += new System.EventHandler(this.label1_Click);
            // 
            // LB_Tax
            // 
            this.LB_Tax.AutoSize = true;
            this.LB_Tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Tax.Location = new System.Drawing.Point(23, 94);
            this.LB_Tax.Name = "LB_Tax";
            this.LB_Tax.Size = new System.Drawing.Size(73, 32);
            this.LB_Tax.TabIndex = 1;
            this.LB_Tax.Text = "TAX";
            // 
            // LB_TOTAL
            // 
            this.LB_TOTAL.AutoSize = true;
            this.LB_TOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TOTAL.Location = new System.Drawing.Point(23, 234);
            this.LB_TOTAL.Name = "LB_TOTAL";
            this.LB_TOTAL.Size = new System.Drawing.Size(111, 32);
            this.LB_TOTAL.TabIndex = 3;
            this.LB_TOTAL.Text = "TOTAL";
            // 
            // LB_BTLDPT
            // 
            this.LB_BTLDPT.AutoSize = true;
            this.LB_BTLDPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_BTLDPT.Location = new System.Drawing.Point(23, 162);
            this.LB_BTLDPT.Name = "LB_BTLDPT";
            this.LB_BTLDPT.Size = new System.Drawing.Size(137, 32);
            this.LB_BTLDPT.TabIndex = 2;
            this.LB_BTLDPT.Text = "BTL DPT";
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(2093, 1188);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmTransaction";
            this.Text = "frmTransaction";
            this.Load += new System.EventHandler(this.frmTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DISCOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAX;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOTTLE_DEPOSIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LB_TOTAL;
        private System.Windows.Forms.Label LB_BTLDPT;
        private System.Windows.Forms.Label LB_Tax;
        private System.Windows.Forms.Label LB_SubTotal;
    }
}