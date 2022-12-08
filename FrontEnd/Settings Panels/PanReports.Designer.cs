
namespace SecretCellar.Settings_Panels
{
    partial class PanReports
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Run = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTypes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvTotal = new System.Windows.Forms.DataGridView();
            this.NameTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnInventoryCopy = new System.Windows.Forms.Button();
            this.BtnInvTypeCopy = new System.Windows.Forms.Button();
            this.BtnTotalCopy = new System.Windows.Forms.Button();
            this.DgvItems = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Run
            // 
            this.btn_Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Run.Location = new System.Drawing.Point(12, 18);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(87, 38);
            this.btn_Run.TabIndex = 0;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(500, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 34);
            this.label7.TabIndex = 25;
            this.label7.Text = "Inventory";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(255, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 34);
            this.label6.TabIndex = 23;
            this.label6.Text = "Inventory Type";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(12, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 34);
            this.label8.TabIndex = 21;
            this.label8.Text = "Total";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(436, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "End:";
            // 
            // dtp_end
            // 
            this.dtp_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_end.Location = new System.Drawing.Point(500, 18);
            this.dtp_end.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(174, 30);
            this.dtp_end.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(142, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Start:";
            // 
            // dtp_start
            // 
            this.dtp_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_start.Location = new System.Drawing.Point(213, 18);
            this.dtp_start.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(174, 30);
            this.dtp_start.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(206)))));
            this.panel1.Controls.Add(this.DgvItems);
            this.panel1.Controls.Add(this.dgvTypes);
            this.panel1.Controls.Add(this.DgvTotal);
            this.panel1.Controls.Add(this.BtnInventoryCopy);
            this.panel1.Controls.Add(this.BtnInvTypeCopy);
            this.panel1.Controls.Add(this.BtnTotalCopy);
            this.panel1.Controls.Add(this.btn_Run);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtp_end);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtp_start);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 345);
            this.panel1.TabIndex = 29;
            // 
            // dgvTypes
            // 
            this.dgvTypes.AllowUserToAddRows = false;
            this.dgvTypes.AllowUserToDeleteRows = false;
            this.dgvTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvTypes.Location = new System.Drawing.Point(255, 104);
            this.dgvTypes.Name = "dgvTypes";
            this.dgvTypes.ReadOnly = true;
            this.dgvTypes.RowHeadersVisible = false;
            this.dgvTypes.RowHeadersWidth = 62;
            this.dgvTypes.RowTemplate.Height = 28;
            this.dgvTypes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTypes.Size = new System.Drawing.Size(226, 229);
            this.dgvTypes.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Value";
            this.dataGridViewTextBoxColumn2.HeaderText = "Total";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // DgvTotal
            // 
            this.DgvTotal.AllowUserToAddRows = false;
            this.DgvTotal.AllowUserToDeleteRows = false;
            this.DgvTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTotal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameTotal,
            this.TotalValue});
            this.DgvTotal.Location = new System.Drawing.Point(12, 104);
            this.DgvTotal.Name = "DgvTotal";
            this.DgvTotal.ReadOnly = true;
            this.DgvTotal.RowHeadersVisible = false;
            this.DgvTotal.RowHeadersWidth = 62;
            this.DgvTotal.RowTemplate.Height = 28;
            this.DgvTotal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvTotal.Size = new System.Drawing.Size(227, 229);
            this.DgvTotal.TabIndex = 29;
            // 
            // NameTotal
            // 
            this.NameTotal.DataPropertyName = "Name";
            this.NameTotal.HeaderText = "Name";
            this.NameTotal.MinimumWidth = 8;
            this.NameTotal.Name = "NameTotal";
            this.NameTotal.ReadOnly = true;
            this.NameTotal.Width = 130;
            // 
            // TotalValue
            // 
            this.TotalValue.DataPropertyName = "Value";
            this.TotalValue.HeaderText = "Total";
            this.TotalValue.MinimumWidth = 8;
            this.TotalValue.Name = "TotalValue";
            this.TotalValue.ReadOnly = true;
            this.TotalValue.Width = 150;
            // 
            // BtnInventoryCopy
            // 
            this.BtnInventoryCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInventoryCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnInventoryCopy.Location = new System.Drawing.Point(748, 61);
            this.BtnInventoryCopy.Name = "BtnInventoryCopy";
            this.BtnInventoryCopy.Size = new System.Drawing.Size(72, 38);
            this.BtnInventoryCopy.TabIndex = 28;
            this.BtnInventoryCopy.Text = "Copy";
            this.BtnInventoryCopy.UseVisualStyleBackColor = true;
            this.BtnInventoryCopy.Click += new System.EventHandler(this.BtnInventoryCopy_Click);
            // 
            // BtnInvTypeCopy
            // 
            this.BtnInvTypeCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnInvTypeCopy.Location = new System.Drawing.Point(416, 61);
            this.BtnInvTypeCopy.Name = "BtnInvTypeCopy";
            this.BtnInvTypeCopy.Size = new System.Drawing.Size(72, 38);
            this.BtnInvTypeCopy.TabIndex = 27;
            this.BtnInvTypeCopy.Text = "Copy";
            this.BtnInvTypeCopy.UseVisualStyleBackColor = true;
            this.BtnInvTypeCopy.Click += new System.EventHandler(this.BtnInvTypeCopy_Click);
            // 
            // BtnTotalCopy
            // 
            this.BtnTotalCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnTotalCopy.Location = new System.Drawing.Point(162, 61);
            this.BtnTotalCopy.Name = "BtnTotalCopy";
            this.BtnTotalCopy.Size = new System.Drawing.Size(72, 38);
            this.BtnTotalCopy.TabIndex = 26;
            this.BtnTotalCopy.Text = "Copy";
            this.BtnTotalCopy.UseVisualStyleBackColor = true;
            this.BtnTotalCopy.Click += new System.EventHandler(this.BtnTotalCopy_Click);
            // 
            // DgvItems
            // 
            this.DgvItems.AllowUserToAddRows = false;
            this.DgvItems.AllowUserToDeleteRows = false;
            this.DgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Price});
            this.DgvItems.Location = new System.Drawing.Point(499, 105);
            this.DgvItems.Name = "DgvItems";
            this.DgvItems.ReadOnly = true;
            this.DgvItems.RowHeadersVisible = false;
            this.DgvItems.RowHeadersWidth = 62;
            this.DgvItems.RowTemplate.Height = 28;
            this.DgvItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvItems.Size = new System.Drawing.Size(321, 229);
            this.DgvItems.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn4.FillWeight = 50F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // PanReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "PanReports";
            this.Size = new System.Drawing.Size(832, 345);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnInventoryCopy;
        private System.Windows.Forms.Button BtnInvTypeCopy;
        private System.Windows.Forms.Button BtnTotalCopy;
        private System.Windows.Forms.DataGridView DgvTotal;
        private System.Windows.Forms.DataGridView dgvTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalValue;
        private System.Windows.Forms.DataGridView DgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}
