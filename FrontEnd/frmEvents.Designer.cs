namespace SecretCellar
{
    partial class frmEvents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvents));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddCharge = new System.Windows.Forms.Button();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.event_Calendar = new System.Windows.Forms.MonthCalendar();
            this.event_dataGridView = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.event_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(611, 478);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(346, 125);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddCharge
            // 
            this.btnAddCharge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCharge.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAddCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btnAddCharge.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddCharge.Location = new System.Drawing.Point(274, 478);
            this.btnAddCharge.Name = "btnAddCharge";
            this.btnAddCharge.Size = new System.Drawing.Size(346, 125);
            this.btnAddCharge.TabIndex = 6;
            this.btnAddCharge.Text = "Add Charge";
            this.btnAddCharge.UseVisualStyleBackColor = false;
            this.btnAddCharge.Click += new System.EventHandler(this.btnAddCharge_Click);
            // 
            // txtCharge
            // 
            this.txtCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtCharge.Location = new System.Drawing.Point(926, 12);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(160, 38);
            this.txtCharge.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.lblTitle.Location = new System.Drawing.Point(675, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(234, 39);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Event Charge:";
            // 
            // event_Calendar
            // 
            this.event_Calendar.Location = new System.Drawing.Point(110, 154);
            this.event_Calendar.MaximumSize = new System.Drawing.Size(2, 2);
            this.event_Calendar.Name = "event_Calendar";
            this.event_Calendar.TabIndex = 8;
            // 
            // event_dataGridView
            // 
            this.event_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.event_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.event_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Event,
            this.Price,
            this.Qty});
            this.event_dataGridView.Location = new System.Drawing.Point(520, 154);
            this.event_dataGridView.Name = "event_dataGridView";
            this.event_dataGridView.RowHeadersWidth = 62;
            this.event_dataGridView.Size = new System.Drawing.Size(707, 245);
            this.event_dataGridView.TabIndex = 9;
            this.event_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.event_dataGridView_CellContentClick);
            // 
            // Date
            // 
            this.Date.HeaderText = "Event Date";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            // 
            // Event
            // 
            this.Event.HeaderText = "Event Name";
            this.Event.MinimumWidth = 8;
            this.Event.Name = "Event";
            // 
            // Price
            // 
            this.Price.HeaderText = "Event Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty on Hand";
            this.Qty.MinimumWidth = 8;
            this.Qty.Name = "Qty";
            // 
            // textQty
            // 
            this.textQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.textQty.Location = new System.Drawing.Point(926, 93);
            this.textQty.Name = "textQty";
            this.textQty.Size = new System.Drawing.Size(160, 38);
            this.textQty.TabIndex = 10;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.lblQty.Location = new System.Drawing.Point(675, 93);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(178, 39);
            this.lblQty.TabIndex = 11;
            this.lblQty.Text = "Ticket Qty:";
            // 
            // frmEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1272, 615);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.textQty);
            this.Controls.Add(this.event_dataGridView);
            this.Controls.Add(this.event_Calendar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddCharge);
            this.Controls.Add(this.txtCharge);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEvents";
            ((System.ComponentModel.ISupportInitialize)(this.event_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddCharge;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MonthCalendar event_Calendar;
        private System.Windows.Forms.DataGridView event_dataGridView;
        private System.Windows.Forms.TextBox textQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
    }
}