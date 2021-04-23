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
			this.dataGridView_Events = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.textBox_Total = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Events)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView_Events
			// 
			this.dataGridView_Events.AllowUserToAddRows = false;
			this.dataGridView_Events.AllowUserToDeleteRows = false;
			this.dataGridView_Events.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView_Events.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Events.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Barcode,
            this.Date,
            this.Event,
            this.Price,
            this.Qty});
			this.dataGridView_Events.Location = new System.Drawing.Point(13, 87);
			this.dataGridView_Events.Name = "dataGridView_Events";
			this.dataGridView_Events.RowHeadersVisible = false;
			this.dataGridView_Events.RowHeadersWidth = 62;
			this.dataGridView_Events.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_Events.Size = new System.Drawing.Size(843, 302);
			this.dataGridView_Events.TabIndex = 9;
			this.dataGridView_Events.SelectionChanged += new System.EventHandler(this.dataGridView_Events_SelectionChanged);
			// 
			// Id
			// 
			this.Id.HeaderText = "Event Id";
			this.Id.Name = "Id";
			// 
			// Barcode
			// 
			this.Barcode.HeaderText = "Event Barcode";
			this.Barcode.Name = "Barcode";
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
			this.Qty.HeaderText = "Quantity";
			this.Qty.MinimumWidth = 8;
			this.Qty.Name = "Qty";
			// 
			// dateTimePicker_Date
			// 
			this.dateTimePicker_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker_Date.Location = new System.Drawing.Point(13, 18);
			this.dateTimePicker_Date.Name = "dateTimePicker_Date";
			this.dateTimePicker_Date.Size = new System.Drawing.Size(594, 44);
			this.dateTimePicker_Date.TabIndex = 12;
			this.dateTimePicker_Date.ValueChanged += new System.EventHandler(this.dateTimePicker_Date_ValueChanged);
			// 
			// button_AddCharge
			// 
			this.button_AddCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_AddCharge.Location = new System.Drawing.Point(676, 484);
			this.button_AddCharge.Name = "button_AddCharge";
			this.button_AddCharge.Size = new System.Drawing.Size(180, 55);
			this.button_AddCharge.TabIndex = 13;
			this.button_AddCharge.TabStop = false;
			this.button_AddCharge.Text = "ADD CHARGE";
			this.button_AddCharge.UseVisualStyleBackColor = true;
			this.button_AddCharge.Click += new System.EventHandler(this.button_AddCharge_Click);
			// 
			// button_CloseWindow
			// 
			this.button_CloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_CloseWindow.Location = new System.Drawing.Point(13, 484);
			this.button_CloseWindow.Name = "button_CloseWindow";
			this.button_CloseWindow.Size = new System.Drawing.Size(180, 55);
			this.button_CloseWindow.TabIndex = 15;
			this.button_CloseWindow.TabStop = false;
			this.button_CloseWindow.Text = "CLOSE WINDOW";
			this.button_CloseWindow.UseVisualStyleBackColor = true;
			this.button_CloseWindow.Click += new System.EventHandler(this.button_CloseWindow_Click);
			// 
			// button_AllEvents
			// 
			this.button_AllEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_AllEvents.Location = new System.Drawing.Point(676, 13);
			this.button_AllEvents.Name = "button_AllEvents";
			this.button_AllEvents.Size = new System.Drawing.Size(180, 55);
			this.button_AllEvents.TabIndex = 16;
			this.button_AllEvents.TabStop = false;
			this.button_AllEvents.Text = "ALL EVENTS";
			this.button_AllEvents.UseVisualStyleBackColor = true;
			this.button_AllEvents.Click += new System.EventHandler(this.button_AllEvents_Click);
			// 
			// button_CreateEvent
			// 
			this.button_CreateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_CreateEvent.Location = new System.Drawing.Point(455, 484);
			this.button_CreateEvent.Name = "button_CreateEvent";
			this.button_CreateEvent.Size = new System.Drawing.Size(180, 55);
			this.button_CreateEvent.TabIndex = 17;
			this.button_CreateEvent.TabStop = false;
			this.button_CreateEvent.Text = "CREATE NEW EVENT";
			this.button_CreateEvent.UseVisualStyleBackColor = true;
			this.button_CreateEvent.Click += new System.EventHandler(this.button_CreateEvent_Click);
			// 
			// button_DeleteEvent
			// 
			this.button_DeleteEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_DeleteEvent.Location = new System.Drawing.Point(239, 484);
			this.button_DeleteEvent.Name = "button_DeleteEvent";
			this.button_DeleteEvent.Size = new System.Drawing.Size(180, 55);
			this.button_DeleteEvent.TabIndex = 18;
			this.button_DeleteEvent.TabStop = false;
			this.button_DeleteEvent.Text = "DELETE EVENT";
			this.button_DeleteEvent.UseVisualStyleBackColor = true;
			this.button_DeleteEvent.Click += new System.EventHandler(this.button_DeleteEvent_Click);
			// 
			// label_Quantity
			// 
			this.label_Quantity.AutoSize = true;
			this.label_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Quantity.Location = new System.Drawing.Point(12, 413);
			this.label_Quantity.Name = "label_Quantity";
			this.label_Quantity.Size = new System.Drawing.Size(276, 39);
			this.label_Quantity.TabIndex = 19;
			this.label_Quantity.Text = "Quantity To Add:";
			// 
			// label_Total
			// 
			this.label_Total.AutoSize = true;
			this.label_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Total.Location = new System.Drawing.Point(576, 413);
			this.label_Total.Name = "label_Total";
			this.label_Total.Size = new System.Drawing.Size(104, 39);
			this.label_Total.TabIndex = 20;
			this.label_Total.Text = "Total:";
			// 
			// textBox_Quantity
			// 
			this.textBox_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Quantity.Location = new System.Drawing.Point(326, 416);
			this.textBox_Quantity.Name = "textBox_Quantity";
			this.textBox_Quantity.Size = new System.Drawing.Size(158, 38);
			this.textBox_Quantity.TabIndex = 21;
			this.textBox_Quantity.TextChanged += new System.EventHandler(this.textBox_Quantity_TextChanged);
			// 
			// textBox_Total
			// 
			this.textBox_Total.Enabled = false;
			this.textBox_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Total.Location = new System.Drawing.Point(698, 416);
			this.textBox_Total.Name = "textBox_Total";
			this.textBox_Total.Size = new System.Drawing.Size(158, 38);
			this.textBox_Total.TabIndex = 22;
			// 
			// frmEvents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(869, 555);
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
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmEvents";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Events";
			this.Load += new System.EventHandler(this.frmEvents_Load);
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
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
		private System.Windows.Forms.DataGridViewTextBoxColumn Date;
		private System.Windows.Forms.DataGridViewTextBoxColumn Event;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
		private System.Windows.Forms.Label label_Quantity;
		private System.Windows.Forms.Label label_Total;
		private System.Windows.Forms.TextBox textBox_Quantity;
		private System.Windows.Forms.TextBox textBox_Total;
	}
}