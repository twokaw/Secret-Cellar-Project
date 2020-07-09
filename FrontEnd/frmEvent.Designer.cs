namespace SecretCellar
{
    partial class frmEvent
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewTab = new System.Windows.Forms.Button();
            this.btnAddToTab = new System.Windows.Forms.Button();
            this.btnDeleteTab = new System.Windows.Forms.Button();
            this.btnPayOutTab = new System.Windows.Forms.Button();
            this.dataGridTabs = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasedItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBoxAddTab = new System.Windows.Forms.GroupBox();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddTab = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTabs)).BeginInit();
            this.grpBoxAddTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Tabs";
            // 
            // btnNewTab
            // 
            this.btnNewTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnNewTab.Location = new System.Drawing.Point(101, 102);
            this.btnNewTab.Name = "btnNewTab";
            this.btnNewTab.Size = new System.Drawing.Size(139, 78);
            this.btnNewTab.TabIndex = 1;
            this.btnNewTab.Text = "New Tab";
            this.btnNewTab.UseVisualStyleBackColor = true;
            this.btnNewTab.Click += new System.EventHandler(this.btnNewTab_Click);
            // 
            // btnAddToTab
            // 
            this.btnAddToTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnAddToTab.Location = new System.Drawing.Point(265, 102);
            this.btnAddToTab.Name = "btnAddToTab";
            this.btnAddToTab.Size = new System.Drawing.Size(139, 78);
            this.btnAddToTab.TabIndex = 2;
            this.btnAddToTab.Text = "Add to Tab";
            this.btnAddToTab.UseVisualStyleBackColor = true;
            this.btnAddToTab.Click += new System.EventHandler(this.btnAddToTab_Click);
            // 
            // btnDeleteTab
            // 
            this.btnDeleteTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnDeleteTab.Location = new System.Drawing.Point(429, 102);
            this.btnDeleteTab.Name = "btnDeleteTab";
            this.btnDeleteTab.Size = new System.Drawing.Size(139, 78);
            this.btnDeleteTab.TabIndex = 3;
            this.btnDeleteTab.Text = "Delete Tab";
            this.btnDeleteTab.UseVisualStyleBackColor = true;
            this.btnDeleteTab.Click += new System.EventHandler(this.btnDeleteTab_Click);
            // 
            // btnPayOutTab
            // 
            this.btnPayOutTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnPayOutTab.Location = new System.Drawing.Point(593, 102);
            this.btnPayOutTab.Name = "btnPayOutTab";
            this.btnPayOutTab.Size = new System.Drawing.Size(139, 78);
            this.btnPayOutTab.TabIndex = 4;
            this.btnPayOutTab.Text = "Pay Out Tab";
            this.btnPayOutTab.UseVisualStyleBackColor = true;
            this.btnPayOutTab.Click += new System.EventHandler(this.btnPayOutTab_Click);
            // 
            // dataGridTabs
            // 
            this.dataGridTabs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTabs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.PurchasedItems,
            this.TotalPrice});
            this.dataGridTabs.Location = new System.Drawing.Point(94, 206);
            this.dataGridTabs.Name = "dataGridTabs";
            this.dataGridTabs.Size = new System.Drawing.Size(644, 150);
            this.dataGridTabs.TabIndex = 5;
            this.dataGridTabs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTabs_CellContentClick);
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.Width = 200;
            // 
            // PurchasedItems
            // 
            this.PurchasedItems.HeaderText = "Purchased Items";
            this.PurchasedItems.Name = "PurchasedItems";
            this.PurchasedItems.Width = 200;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Width = 200;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(297, 374);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(239, 93);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpBoxAddTab
            // 
            this.grpBoxAddTab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpBoxAddTab.Controls.Add(this.lblEnterName);
            this.grpBoxAddTab.Controls.Add(this.txtBoxName);
            this.grpBoxAddTab.Controls.Add(this.btnCancel);
            this.grpBoxAddTab.Controls.Add(this.btnAddTab);
            this.grpBoxAddTab.Location = new System.Drawing.Point(357, 242);
            this.grpBoxAddTab.Name = "grpBoxAddTab";
            this.grpBoxAddTab.Size = new System.Drawing.Size(362, 209);
            this.grpBoxAddTab.TabIndex = 7;
            this.grpBoxAddTab.TabStop = false;
            this.grpBoxAddTab.Text = "Add Tab";
            this.grpBoxAddTab.Visible = false;
            this.grpBoxAddTab.Enter += new System.EventHandler(this.grpBoxAddTab_Enter);
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblEnterName.Location = new System.Drawing.Point(108, 47);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(131, 25);
            this.lblEnterName.TabIndex = 3;
            this.lblEnterName.Text = "Enter Name:";
            this.lblEnterName.Visible = false;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(102, 76);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(147, 20);
            this.txtBoxName.TabIndex = 2;
            this.txtBoxName.Visible = false;
            this.txtBoxName.TextChanged += new System.EventHandler(this.txtBoxName_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 143);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddTab
            // 
            this.btnAddTab.Location = new System.Drawing.Point(79, 143);
            this.btnAddTab.Name = "btnAddTab";
            this.btnAddTab.Size = new System.Drawing.Size(75, 23);
            this.btnAddTab.TabIndex = 0;
            this.btnAddTab.Text = "Add Tab";
            this.btnAddTab.UseVisualStyleBackColor = true;
            this.btnAddTab.Visible = false;
            this.btnAddTab.Click += new System.EventHandler(this.btnAddTab_Click);
            // 
            // frmEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 488);
            this.Controls.Add(this.grpBoxAddTab);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGridTabs);
            this.Controls.Add(this.btnPayOutTab);
            this.Controls.Add(this.btnDeleteTab);
            this.Controls.Add(this.btnAddToTab);
            this.Controls.Add(this.btnNewTab);
            this.Controls.Add(this.label1);
            this.Name = "frmEvent";
            this.Text = "Event Tabs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTabs)).EndInit();
            this.grpBoxAddTab.ResumeLayout(false);
            this.grpBoxAddTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewTab;
        private System.Windows.Forms.Button btnAddToTab;
        private System.Windows.Forms.Button btnDeleteTab;
        private System.Windows.Forms.Button btnPayOutTab;
        private System.Windows.Forms.DataGridView dataGridTabs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasedItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpBoxAddTab;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
    }
}