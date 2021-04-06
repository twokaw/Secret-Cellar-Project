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
			this.txtCharge = new System.Windows.Forms.TextBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.dataGridView_Events = new System.Windows.Forms.DataGridView();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtQty = new System.Windows.Forms.TextBox();
			this.lblQty = new System.Windows.Forms.Label();
			this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
			this.button_AddCharge = new System.Windows.Forms.Button();
			this.button_CloseWindow = new System.Windows.Forms.Button();
			this.button_AllEvents = new System.Windows.Forms.Button();
			this.button_CreateEvent = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Events)).BeginInit();
			this.SuspendLayout();
			// 
			// txtCharge
			// 
			this.txtCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
			this.txtCharge.Location = new System.Drawing.Point(262, 422);
			this.txtCharge.Margin = new System.Windows.Forms.Padding(4);
			this.txtCharge.Name = "txtCharge";
			this.txtCharge.Size = new System.Drawing.Size(157, 38);
			this.txtCharge.TabIndex = 5;
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitle.AutoSize = true;
			this.lblTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
			this.lblTitle.Location = new System.Drawing.Point(6, 419);
			this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(234, 39);
			this.lblTitle.TabIndex = 4;
			this.lblTitle.Text = "Event Charge:";
			// 
			// dataGridView_Events
			// 
			this.dataGridView_Events.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView_Events.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Events.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Event,
            this.Price,
            this.Qty});
			this.dataGridView_Events.Location = new System.Drawing.Point(13, 87);
			this.dataGridView_Events.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView_Events.Name = "dataGridView_Events";
			this.dataGridView_Events.RowHeadersWidth = 62;
			this.dataGridView_Events.Size = new System.Drawing.Size(843, 302);
			this.dataGridView_Events.TabIndex = 9;
			this.dataGridView_Events.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.event_dataGridView_CellContentClick);
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
			// txtQty
			// 
			this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
			this.txtQty.Location = new System.Drawing.Point(699, 422);
			this.txtQty.Margin = new System.Windows.Forms.Padding(4);
			this.txtQty.Name = "txtQty";
			this.txtQty.Size = new System.Drawing.Size(157, 38);
			this.txtQty.TabIndex = 10;
			// 
			// lblQty
			// 
			this.lblQty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblQty.AutoSize = true;
			this.lblQty.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
			this.lblQty.Location = new System.Drawing.Point(499, 419);
			this.lblQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblQty.Name = "lblQty";
			this.lblQty.Size = new System.Drawing.Size(178, 39);
			this.lblQty.TabIndex = 11;
			this.lblQty.Text = "Ticket Qty:";
			// 
			// dateTimePicker_Date
			// 
			this.dateTimePicker_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker_Date.Location = new System.Drawing.Point(13, 13);
			this.dateTimePicker_Date.Margin = new System.Windows.Forms.Padding(4);
			this.dateTimePicker_Date.Name = "dateTimePicker_Date";
			this.dateTimePicker_Date.Size = new System.Drawing.Size(594, 44);
			this.dateTimePicker_Date.TabIndex = 12;
			this.dateTimePicker_Date.ValueChanged += new System.EventHandler(this.dateTimePicker_Date_ValueChanged);
			// 
			// button_AddCharge
			// 
			this.button_AddCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_AddCharge.Location = new System.Drawing.Point(676, 484);
			this.button_AddCharge.Margin = new System.Windows.Forms.Padding(1);
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
			this.button_CloseWindow.Margin = new System.Windows.Forms.Padding(1);
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
			this.button_AllEvents.Margin = new System.Windows.Forms.Padding(1);
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
			this.button_CreateEvent.Location = new System.Drawing.Point(352, 484);
			this.button_CreateEvent.Margin = new System.Windows.Forms.Padding(1);
			this.button_CreateEvent.Name = "button_CreateEvent";
			this.button_CreateEvent.Size = new System.Drawing.Size(180, 55);
			this.button_CreateEvent.TabIndex = 17;
			this.button_CreateEvent.TabStop = false;
			this.button_CreateEvent.Text = "CREATE NEW EVENT";
			this.button_CreateEvent.UseVisualStyleBackColor = true;
			this.button_CreateEvent.Click += new System.EventHandler(this.button_CreateEvent_Click);
			// 
			// frmEvents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(869, 561);
			this.Controls.Add(this.button_CreateEvent);
			this.Controls.Add(this.button_AllEvents);
			this.Controls.Add(this.button_CloseWindow);
			this.Controls.Add(this.button_AddCharge);
			this.Controls.Add(this.dateTimePicker_Date);
			this.Controls.Add(this.lblQty);
			this.Controls.Add(this.txtQty);
			this.Controls.Add(this.dataGridView_Events);
			this.Controls.Add(this.txtCharge);
			this.Controls.Add(this.lblTitle);
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
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridView_Events;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
		private System.Windows.Forms.Button button_AddCharge;
		private System.Windows.Forms.Button button_CloseWindow;
		private System.Windows.Forms.Button button_AllEvents;
		private System.Windows.Forms.Button button_CreateEvent;
	}
}