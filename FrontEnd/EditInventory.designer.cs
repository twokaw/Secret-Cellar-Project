namespace SecretCellar
{
    partial class EditInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditInventory));
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtItemDesc = new System.Windows.Forms.TextBox();
            this.txtSupplyPrice = new System.Windows.Forms.TextBox();
            this.txtBottleDeposite = new System.Windows.Forms.TextBox();
            this.txtSupplierPhone = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtMarkUp = new System.Windows.Forms.TextBox();
            this.txtLowStock = new System.Windows.Forms.TextBox();
            this.txtExistingQty = new System.Windows.Forms.TextBox();
            this.txtAddToQty = new System.Windows.Forms.TextBox();
            this.txtSalesPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboProdClass = new System.Windows.Forms.ComboBox();
            this.cboSupplierName = new System.Windows.Forms.ComboBox();
            this.btnEditSup = new System.Windows.Forms.Button();
            this.btnDeleteSup = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBrowseInv = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnCalcMarkUp = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(168, 18);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(148, 26);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            // 
            // txtItemDesc
            // 
            this.txtItemDesc.Location = new System.Drawing.Point(168, 58);
            this.txtItemDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtItemDesc.Name = "txtItemDesc";
            this.txtItemDesc.Size = new System.Drawing.Size(148, 26);
            this.txtItemDesc.TabIndex = 1;
            this.txtItemDesc.TextChanged += new System.EventHandler(this.txtItemDesc_TextChanged);
            // 
            // txtSupplyPrice
            // 
            this.txtSupplyPrice.Location = new System.Drawing.Point(168, 98);
            this.txtSupplyPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSupplyPrice.Name = "txtSupplyPrice";
            this.txtSupplyPrice.Size = new System.Drawing.Size(148, 26);
            this.txtSupplyPrice.TabIndex = 2;
            this.txtSupplyPrice.TextChanged += new System.EventHandler(this.txtSupplyPrice_TextChanged);
            // 
            // txtBottleDeposite
            // 
            this.txtBottleDeposite.Location = new System.Drawing.Point(480, 300);
            this.txtBottleDeposite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBottleDeposite.Name = "txtBottleDeposite";
            this.txtBottleDeposite.Size = new System.Drawing.Size(148, 26);
            this.txtBottleDeposite.TabIndex = 5;
            this.txtBottleDeposite.TextChanged += new System.EventHandler(this.txtBottleDeposite_TextChanged);
            // 
            // txtSupplierPhone
            // 
            this.txtSupplierPhone.Location = new System.Drawing.Point(480, 220);
            this.txtSupplierPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSupplierPhone.Name = "txtSupplierPhone";
            this.txtSupplierPhone.Size = new System.Drawing.Size(148, 26);
            this.txtSupplierPhone.TabIndex = 9;
            this.txtSupplierPhone.TextChanged += new System.EventHandler(this.txtSupplierPhone_TextChanged);
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(168, 300);
            this.txtTax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(148, 26);
            this.txtTax.TabIndex = 10;
            this.txtTax.TextChanged += new System.EventHandler(this.txtTax_TextChanged);
            // 
            // txtMarkUp
            // 
            this.txtMarkUp.Location = new System.Drawing.Point(168, 260);
            this.txtMarkUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMarkUp.Name = "txtMarkUp";
            this.txtMarkUp.Size = new System.Drawing.Size(148, 26);
            this.txtMarkUp.TabIndex = 11;
            this.txtMarkUp.TextChanged += new System.EventHandler(this.txtMarkUp_TextChanged);
            // 
            // txtLowStock
            // 
            this.txtLowStock.Location = new System.Drawing.Point(754, 178);
            this.txtLowStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLowStock.Name = "txtLowStock";
            this.txtLowStock.Size = new System.Drawing.Size(148, 26);
            this.txtLowStock.TabIndex = 12;
            this.txtLowStock.TextChanged += new System.EventHandler(this.txtLowStock_TextChanged);
            // 
            // txtExistingQty
            // 
            this.txtExistingQty.Location = new System.Drawing.Point(480, 180);
            this.txtExistingQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtExistingQty.Name = "txtExistingQty";
            this.txtExistingQty.Size = new System.Drawing.Size(148, 26);
            this.txtExistingQty.TabIndex = 13;
            this.txtExistingQty.TextChanged += new System.EventHandler(this.txtExistingQty_TextChanged);
            // 
            // txtAddToQty
            // 
            this.txtAddToQty.Location = new System.Drawing.Point(168, 178);
            this.txtAddToQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddToQty.Name = "txtAddToQty";
            this.txtAddToQty.Size = new System.Drawing.Size(148, 26);
            this.txtAddToQty.TabIndex = 14;
            this.txtAddToQty.TextChanged += new System.EventHandler(this.txtAddToQty_TextChanged);
            // 
            // txtSalesPrice
            // 
            this.txtSalesPrice.Location = new System.Drawing.Point(480, 260);
            this.txtSalesPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalesPrice.Name = "txtSalesPrice";
            this.txtSalesPrice.Size = new System.Drawing.Size(148, 26);
            this.txtSalesPrice.TabIndex = 15;
            this.txtSalesPrice.TextChanged += new System.EventHandler(this.txtSalesPrice_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Barcode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 305);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tax %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mark Up %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Supplier Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(658, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Low Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Existing Qty";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Add to Qty";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 143);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Prod. Class";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 103);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Supply Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 63);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Item Desc";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(357, 226);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Supplier Phone";
            // 
            // cboProdClass
            // 
            this.cboProdClass.FormattingEnabled = true;
            this.cboProdClass.Location = new System.Drawing.Point(168, 137);
            this.cboProdClass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboProdClass.Name = "cboProdClass";
            this.cboProdClass.Size = new System.Drawing.Size(148, 28);
            this.cboProdClass.TabIndex = 29;
            this.cboProdClass.SelectedIndexChanged += new System.EventHandler(this.cboProdClass_SelectedIndexChanged);
            // 
            // cboSupplierName
            // 
            this.cboSupplierName.FormattingEnabled = true;
            this.cboSupplierName.Location = new System.Drawing.Point(168, 218);
            this.cboSupplierName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSupplierName.Name = "cboSupplierName";
            this.cboSupplierName.Size = new System.Drawing.Size(148, 28);
            this.cboSupplierName.TabIndex = 30;
            this.cboSupplierName.SelectedIndexChanged += new System.EventHandler(this.cboSupplierName_SelectedIndexChanged);
            // 
            // btnEditSup
            // 
            this.btnEditSup.Location = new System.Drawing.Point(648, 215);
            this.btnEditSup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditSup.Name = "btnEditSup";
            this.btnEditSup.Size = new System.Drawing.Size(112, 35);
            this.btnEditSup.TabIndex = 31;
            this.btnEditSup.Text = "Edit Sup.";
            this.btnEditSup.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSup
            // 
            this.btnDeleteSup.Location = new System.Drawing.Point(770, 217);
            this.btnDeleteSup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteSup.Name = "btnDeleteSup";
            this.btnDeleteSup.Size = new System.Drawing.Size(112, 35);
            this.btnDeleteSup.TabIndex = 32;
            this.btnDeleteSup.Text = "Delete Sup.";
            this.btnDeleteSup.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(357, 305);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "Bottle Deposite";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(357, 265);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 20);
            this.label16.TabIndex = 35;
            this.label16.Text = "Sales Pirce";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(63, 457);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(204, 95);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBrowseInv
            // 
            this.btnBrowseInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseInv.Location = new System.Drawing.Point(495, 578);
            this.btnBrowseInv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowseInv.Name = "btnBrowseInv";
            this.btnBrowseInv.Size = new System.Drawing.Size(204, 95);
            this.btnBrowseInv.TabIndex = 37;
            this.btnBrowseInv.Text = "Browse Inv.";
            this.btnBrowseInv.UseVisualStyleBackColor = true;
            this.btnBrowseInv.Click += new System.EventHandler(this.btnBrowseInv_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(922, 457);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(204, 95);
            this.btnMainMenu.TabIndex = 38;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnCalcMarkUp
            // 
            this.btnCalcMarkUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcMarkUp.Location = new System.Drawing.Point(636, 457);
            this.btnCalcMarkUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalcMarkUp.Name = "btnCalcMarkUp";
            this.btnCalcMarkUp.Size = new System.Drawing.Size(204, 95);
            this.btnCalcMarkUp.TabIndex = 39;
            this.btnCalcMarkUp.Text = "Calc Mark Up";
            this.btnCalcMarkUp.UseVisualStyleBackColor = true;
            this.btnCalcMarkUp.Click += new System.EventHandler(this.btnCalcMarkUp_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(350, 457);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(204, 95);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // EditInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1160, 692);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCalcMarkUp);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnBrowseInv);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnDeleteSup);
            this.Controls.Add(this.btnEditSup);
            this.Controls.Add(this.cboSupplierName);
            this.Controls.Add(this.cboProdClass);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalesPrice);
            this.Controls.Add(this.txtAddToQty);
            this.Controls.Add(this.txtExistingQty);
            this.Controls.Add(this.txtLowStock);
            this.Controls.Add(this.txtMarkUp);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtSupplierPhone);
            this.Controls.Add(this.txtBottleDeposite);
            this.Controls.Add(this.txtSupplyPrice);
            this.Controls.Add(this.txtItemDesc);
            this.Controls.Add(this.txtBarcode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Inventory";
            this.Load += new System.EventHandler(this.EditInventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtItemDesc;
        private System.Windows.Forms.TextBox txtSupplyPrice;
        private System.Windows.Forms.TextBox txtBottleDeposite;
        private System.Windows.Forms.TextBox txtSupplierPhone;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtMarkUp;
        private System.Windows.Forms.TextBox txtLowStock;
        private System.Windows.Forms.TextBox txtExistingQty;
        private System.Windows.Forms.TextBox txtAddToQty;
        private System.Windows.Forms.TextBox txtSalesPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboProdClass;
        private System.Windows.Forms.ComboBox cboSupplierName;
        private System.Windows.Forms.Button btnEditSup;
        private System.Windows.Forms.Button btnDeleteSup;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBrowseInv;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnCalcMarkUp;
        private System.Windows.Forms.Button btnAdd;
    }
}

