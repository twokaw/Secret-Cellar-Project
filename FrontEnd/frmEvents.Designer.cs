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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvents));
			this.dataGridView_Events = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PreorderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AtDoorPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
			this.button_AddCharge = new System.Windows.Forms.Button();
			this.button_CloseWindow = new System.Windows.Forms.Button();
			this.button_AllEvents = new System.Windows.Forms.Button();
			this.button_CreateEvent = new System.Windows.Forms.Button();
			this.button_DeleteEvent = new System.Windows.Forms.Button();
			this.label_Quantity = new System.Windows.Forms.Label();
			this.label_Total = new System.Windows.Forms.Label();
			this.textBox_Quantity = new System.Windows.Forms.TextBox();
			this.textBox_Total = new SecretCellar.CurrencyBox();
			this.button_EditEvent = new System.Windows.Forms.Button();
			this.button_WaitList = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Events)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView_Events
			// 
			this.dataGridView_Events.AllowUserToAddRows = false;
			this.dataGridView_Events.AllowUserToDeleteRows = false;
			this.dataGridView_Events.AllowUserToResizeColumns = false;
			this.dataGridView_Events.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridView_Events.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView_Events.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView_Events.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(196)))));
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView_Events.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_Events.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Events.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Barcode,
            this.Date,
            this.Duration,
            this.Event,
            this.PreorderPrice,
            this.AtDoorPrice,
            this.Qty});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView_Events.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView_Events.Location = new System.Drawing.Point(14, 109);
			this.dataGridView_Events.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dataGridView_Events.Name = "dataGridView_Events";
			this.dataGridView_Events.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView_Events.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView_Events.RowHeadersVisible = false;
			this.dataGridView_Events.RowHeadersWidth = 62;
			this.dataGridView_Events.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridView_Events.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridView_Events.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_Events.Size = new System.Drawing.Size(937, 353);
			this.dataGridView_Events.TabIndex = 2;
			this.dataGridView_Events.TabStop = false;
			this.dataGridView_Events.SelectionChanged += new System.EventHandler(this.dataGridView_Events_SelectionChanged);
			// 
			// Id
			// 
			this.Id.DataPropertyName = "eventId";
			this.Id.HeaderText = "Event Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			// 
			// Barcode
			// 
			this.Barcode.DataPropertyName = "eventBarcode";
			this.Barcode.HeaderText = "Event Barcode";
			this.Barcode.Name = "Barcode";
			this.Barcode.ReadOnly = true;
			// 
			// Date
			// 
			this.Date.DataPropertyName = "eventDate";
			this.Date.HeaderText = "Event Date";
			this.Date.MinimumWidth = 8;
			this.Date.Name = "Date";
			this.Date.ReadOnly = true;
			// 
			// Duration
			// 
			this.Duration.DataPropertyName = "eventDuration";
			this.Duration.HeaderText = "Event Duration";
			this.Duration.Name = "Duration";
			this.Duration.ReadOnly = true;
			// 
			// Event
			// 
			this.Event.DataPropertyName = "eventName";
			this.Event.HeaderText = "Event Name";
			this.Event.MinimumWidth = 8;
			this.Event.Name = "Event";
			this.Event.ReadOnly = true;
			// 
			// PreorderPrice
			// 
			this.PreorderPrice.DataPropertyName = "preorderPrice";
			this.PreorderPrice.HeaderText = "Preorder Price";
			this.PreorderPrice.Name = "PreorderPrice";
			this.PreorderPrice.ReadOnly = true;
			// 
			// AtDoorPrice
			// 
			this.AtDoorPrice.DataPropertyName = "atDoorPrice";
			this.AtDoorPrice.HeaderText = "At Door Price";
			this.AtDoorPrice.MinimumWidth = 8;
			this.AtDoorPrice.Name = "AtDoorPrice";
			this.AtDoorPrice.ReadOnly = true;
			// 
			// Qty
			// 
			this.Qty.DataPropertyName = "quantity";
			this.Qty.HeaderText = "Quantity";
			this.Qty.MinimumWidth = 8;
			this.Qty.Name = "Qty";
			this.Qty.ReadOnly = true;
			// 
			// dateTimePicker_Date
			// 
			this.dateTimePicker_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker_Date.Location = new System.Drawing.Point(14, 22);
			this.dateTimePicker_Date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dateTimePicker_Date.Name = "dateTimePicker_Date";
			this.dateTimePicker_Date.Size = new System.Drawing.Size(660, 44);
			this.dateTimePicker_Date.TabIndex = 0;
			this.dateTimePicker_Date.ValueChanged += new System.EventHandler(this.dateTimePicker_Date_ValueChanged);
			// 
			// button_AddCharge
			// 
			this.button_AddCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_AddCharge.Location = new System.Drawing.Point(751, 632);
			this.button_AddCharge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button_AddCharge.Name = "button_AddCharge";
			this.button_AddCharge.Size = new System.Drawing.Size(200, 69);
			this.button_AddCharge.TabIndex = 9;
			this.button_AddCharge.Text = "Add Charge";
			this.button_AddCharge.UseVisualStyleBackColor = true;
			this.button_AddCharge.Click += new System.EventHandler(this.button_AddCharge_Click);
			// 
			// button_CloseWindow
			// 
			this.button_CloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_CloseWindow.Location = new System.Drawing.Point(14, 632);
			this.button_CloseWindow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button_CloseWindow.Name = "button_CloseWindow";
			this.button_CloseWindow.Size = new System.Drawing.Size(200, 69);
			this.button_CloseWindow.TabIndex = 8;
			this.button_CloseWindow.Text = "Close Window";
			this.button_CloseWindow.UseVisualStyleBackColor = true;
			this.button_CloseWindow.Click += new System.EventHandler(this.button_CloseWindow_Click);
			// 
			// button_AllEvents
			// 
			this.button_AllEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_AllEvents.Location = new System.Drawing.Point(751, 16);
			this.button_AllEvents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button_AllEvents.Name = "button_AllEvents";
			this.button_AllEvents.Size = new System.Drawing.Size(200, 69);
			this.button_AllEvents.TabIndex = 1;
			this.button_AllEvents.Text = "All Events";
			this.button_AllEvents.UseVisualStyleBackColor = true;
			this.button_AllEvents.Click += new System.EventHandler(this.button_AllEvents_Click);
			// 
			// button_CreateEvent
			// 
			this.button_CreateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_CreateEvent.Location = new System.Drawing.Point(14, 545);
			this.button_CreateEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button_CreateEvent.Name = "button_CreateEvent";
			this.button_CreateEvent.Size = new System.Drawing.Size(200, 69);
			this.button_CreateEvent.TabIndex = 4;
			this.button_CreateEvent.Text = "Create New Event";
			this.button_CreateEvent.UseVisualStyleBackColor = true;
			this.button_CreateEvent.Click += new System.EventHandler(this.button_CreateEvent_Click);
			// 
			// button_DeleteEvent
			// 
			this.button_DeleteEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_DeleteEvent.Location = new System.Drawing.Point(259, 545);
			this.button_DeleteEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button_DeleteEvent.Name = "button_DeleteEvent";
			this.button_DeleteEvent.Size = new System.Drawing.Size(200, 69);
			this.button_DeleteEvent.TabIndex = 5;
			this.button_DeleteEvent.Text = "Delete Event";
			this.button_DeleteEvent.UseVisualStyleBackColor = true;
			this.button_DeleteEvent.Click += new System.EventHandler(this.button_DeleteEvent_Click);
			// 
			// label_Quantity
			// 
			this.label_Quantity.AutoSize = true;
			this.label_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Quantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label_Quantity.Location = new System.Drawing.Point(12, 483);
			this.label_Quantity.Name = "label_Quantity";
			this.label_Quantity.Size = new System.Drawing.Size(292, 39);
			this.label_Quantity.TabIndex = 19;
			this.label_Quantity.Text = "Quantity To Add:";
			// 
			// label_Total
			// 
			this.label_Total.AutoSize = true;
			this.label_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Total.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label_Total.Location = new System.Drawing.Point(641, 483);
			this.label_Total.Name = "label_Total";
			this.label_Total.Size = new System.Drawing.Size(110, 39);
			this.label_Total.TabIndex = 20;
			this.label_Total.Text = "Total:";
			// 
			// textBox_Quantity
			// 
			this.textBox_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Quantity.Location = new System.Drawing.Point(294, 483);
			this.textBox_Quantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBox_Quantity.Name = "textBox_Quantity";
			this.textBox_Quantity.Size = new System.Drawing.Size(175, 38);
			this.textBox_Quantity.TabIndex = 3;
			this.textBox_Quantity.TextChanged += new System.EventHandler(this.textBox_Quantity_TextChanged);
			// 
			// textBox_Total
			// 
			this.textBox_Total.Enabled = false;
			this.textBox_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Total.Location = new System.Drawing.Point(776, 483);
			this.textBox_Total.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBox_Total.Name = "textBox_Total";
			this.textBox_Total.Size = new System.Drawing.Size(175, 38);
			this.textBox_Total.TabIndex = 22;
			this.textBox_Total.Text = "0.00";
			this.textBox_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// button_EditEvent
			// 
			this.button_EditEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_EditEvent.Location = new System.Drawing.Point(503, 545);
			this.button_EditEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button_EditEvent.Name = "button_EditEvent";
			this.button_EditEvent.Size = new System.Drawing.Size(200, 69);
			this.button_EditEvent.TabIndex = 6;
			this.button_EditEvent.Text = "Edit Event";
			this.button_EditEvent.UseVisualStyleBackColor = true;
			this.button_EditEvent.Click += new System.EventHandler(this.button_EditEvent_Click);
			// 
			// button_WaitList
			// 
			this.button_WaitList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_WaitList.Location = new System.Drawing.Point(751, 545);
			this.button_WaitList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button_WaitList.Name = "button_WaitList";
			this.button_WaitList.Size = new System.Drawing.Size(200, 69);
			this.button_WaitList.TabIndex = 7;
			this.button_WaitList.Text = "Event Waitlist";
			this.button_WaitList.UseVisualStyleBackColor = true;
			this.button_WaitList.Click += new System.EventHandler(this.button_WaitList_Click);
			// 
			// frmEvents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(206)))));
			this.ClientSize = new System.Drawing.Size(966, 709);
			this.Controls.Add(this.button_WaitList);
			this.Controls.Add(this.button_EditEvent);
			this.Controls.Add(this.textBox_Total);
			this.Controls.Add(this.textBox_Quantity);
			this.Controls.Add(this.label_Total);
			this.Controls.Add(this.label_Quantity);
			this.Controls.Add(this.button_DeleteEvent);
			this.Controls.Add(this.button_CreateEvent);
			this.Controls.Add(this.button_AllEvents);
			this.Controls.Add(this.button_CloseWindow);
			this.Controls.Add(this.button_AddCharge);
			this.Controls.Add(this.dateTimePicker_Date);
			this.Controls.Add(this.dataGridView_Events);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmEvents";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Events";
			this.Load += new System.EventHandler(this.frmEvents_Load);
			this.Shown += new System.EventHandler(this.frmEvents_Shown);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Events)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_Events;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
		private System.Windows.Forms.Button button_AddCharge;
		private System.Windows.Forms.Button button_CloseWindow;
		private System.Windows.Forms.Button button_AllEvents;
		private System.Windows.Forms.Button button_CreateEvent;
		private System.Windows.Forms.Button button_DeleteEvent;
		private System.Windows.Forms.Label label_Quantity;
		private System.Windows.Forms.Label label_Total;
		private System.Windows.Forms.TextBox textBox_Quantity;
		private SecretCellar.CurrencyBox textBox_Total;
		private System.Windows.Forms.Button button_EditEvent;
		private System.Windows.Forms.Button button_WaitList;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
		private System.Windows.Forms.DataGridViewTextBoxColumn Date;
		private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
		private System.Windows.Forms.DataGridViewTextBoxColumn Event;
		private System.Windows.Forms.DataGridViewTextBoxColumn PreorderPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn AtDoorPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
	}
}