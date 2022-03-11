
using System.Drawing;

namespace SecretCellar {
	partial class frmEventsAll {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEventsAll));
			this.dataGridView_Events = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PreorderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AtDoorPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button_CloseWindow = new System.Windows.Forms.Button();
			this.button_DeleteEvent = new System.Windows.Forms.Button();
			this.label_Events = new System.Windows.Forms.Label();
			this.button_showPreviousEventData = new System.Windows.Forms.Button();
			this.checkBox_ShowPreviousEvents = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Events)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView_Events
			// 
			this.dataGridView_Events.AllowUserToAddRows = false;
			this.dataGridView_Events.AllowUserToDeleteRows = false;
			this.dataGridView_Events.AllowUserToResizeColumns = false;
			this.dataGridView_Events.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridView_Events.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView_Events.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView_Events.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView_Events.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(196)))));
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView_Events.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_Events.ColumnHeadersHeight = 28;
			this.dataGridView_Events.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView_Events.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Date,
            this.EventName,
            this.PreorderPrice,
            this.AtDoorPrice,
            this.Qty});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(51)))), ((int)(((byte)(69)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Ivory;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView_Events.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView_Events.Location = new System.Drawing.Point(13, 41);
			this.dataGridView_Events.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView_Events.Name = "dataGridView_Events";
			this.dataGridView_Events.ReadOnly = true;
			this.dataGridView_Events.RowHeadersVisible = false;
			this.dataGridView_Events.RowHeadersWidth = 62;
			this.dataGridView_Events.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_Events.Size = new System.Drawing.Size(664, 304);
			this.dataGridView_Events.TabIndex = 0;
			this.dataGridView_Events.TabStop = false;
			this.dataGridView_Events.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Events_CellDoubleClick);
			// 
			// Id
			// 
			this.Id.DataPropertyName = "eventId";
			this.Id.HeaderText = "Event Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			// 
			// Date
			// 
			this.Date.DataPropertyName = "eventDate";
			this.Date.HeaderText = "Event Date";
			this.Date.MinimumWidth = 8;
			this.Date.Name = "Date";
			this.Date.ReadOnly = true;
			// 
			// EventName
			// 
			this.EventName.DataPropertyName = "eventName";
			this.EventName.HeaderText = "Event Name";
			this.EventName.MinimumWidth = 8;
			this.EventName.Name = "EventName";
			this.EventName.ReadOnly = true;
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
			this.Qty.DataPropertyName = "eventQuantity";
			this.Qty.HeaderText = "Quantity";
			this.Qty.MinimumWidth = 8;
			this.Qty.Name = "Qty";
			this.Qty.ReadOnly = true;
			// 
			// button_CloseWindow
			// 
			this.button_CloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_CloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_CloseWindow.Location = new System.Drawing.Point(13, 355);
			this.button_CloseWindow.Margin = new System.Windows.Forms.Padding(1);
			this.button_CloseWindow.Name = "button_CloseWindow";
			this.button_CloseWindow.Size = new System.Drawing.Size(180, 55);
			this.button_CloseWindow.TabIndex = 1;
			this.button_CloseWindow.Text = "Close Window";
			this.button_CloseWindow.UseVisualStyleBackColor = true;
			this.button_CloseWindow.Click += new System.EventHandler(this.button_CloseWindow_Click);
			// 
			// button_DeleteEvent
			// 
			this.button_DeleteEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_DeleteEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_DeleteEvent.Location = new System.Drawing.Point(497, 355);
			this.button_DeleteEvent.Margin = new System.Windows.Forms.Padding(1);
			this.button_DeleteEvent.Name = "button_DeleteEvent";
			this.button_DeleteEvent.Size = new System.Drawing.Size(180, 55);
			this.button_DeleteEvent.TabIndex = 2;
			this.button_DeleteEvent.Text = "Delete Event";
			this.button_DeleteEvent.UseVisualStyleBackColor = true;
			this.button_DeleteEvent.Click += new System.EventHandler(this.button_DeleteEvent_Click);
			// 
			// label_Events
			// 
			this.label_Events.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Events.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label_Events.Location = new System.Drawing.Point(9, 9);
			this.label_Events.Name = "label_Events";
			this.label_Events.Size = new System.Drawing.Size(231, 23);
			this.label_Events.TabIndex = 4;
			this.label_Events.Text = "Upcoming Events";
			// 
			// button_showPreviousEventData
			// 
			this.button_showPreviousEventData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_showPreviousEventData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_showPreviousEventData.Location = new System.Drawing.Point(255, 355);
			this.button_showPreviousEventData.Margin = new System.Windows.Forms.Padding(1);
			this.button_showPreviousEventData.Name = "button_showPreviousEventData";
			this.button_showPreviousEventData.Size = new System.Drawing.Size(180, 55);
			this.button_showPreviousEventData.TabIndex = 5;
			this.button_showPreviousEventData.Text = "Show Event Data";
			this.button_showPreviousEventData.UseVisualStyleBackColor = true;
			this.button_showPreviousEventData.Click += new System.EventHandler(this.button_showPreviousEventData_Click);
			// 
			// checkBox_ShowPreviousEvents
			// 
			this.checkBox_ShowPreviousEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBox_ShowPreviousEvents.AutoSize = true;
			this.checkBox_ShowPreviousEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_ShowPreviousEvents.Location = new System.Drawing.Point(528, 12);
			this.checkBox_ShowPreviousEvents.Name = "checkBox_ShowPreviousEvents";
			this.checkBox_ShowPreviousEvents.Size = new System.Drawing.Size(149, 22);
			this.checkBox_ShowPreviousEvents.TabIndex = 6;
			this.checkBox_ShowPreviousEvents.Text = "Previous Events";
			this.checkBox_ShowPreviousEvents.UseVisualStyleBackColor = true;
			this.checkBox_ShowPreviousEvents.CheckedChanged += new System.EventHandler(this.checkBox_ShowPreviousEvents_CheckedChanged);
			// 
			// frmEventsAll
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(206)))));
			this.ClientSize = new System.Drawing.Size(690, 418);
			this.Controls.Add(this.checkBox_ShowPreviousEvents);
			this.Controls.Add(this.button_showPreviousEventData);
			this.Controls.Add(this.label_Events);
			this.Controls.Add(this.button_DeleteEvent);
			this.Controls.Add(this.button_CloseWindow);
			this.Controls.Add(this.dataGridView_Events);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmEventsAll";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "All Events";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Events)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView_Events;
		private System.Windows.Forms.Button button_CloseWindow;
		private System.Windows.Forms.Button button_DeleteEvent;
		private System.Windows.Forms.Label label_Events;
		private System.Windows.Forms.Button button_showPreviousEventData;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreorderPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtDoorPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
		private System.Windows.Forms.CheckBox checkBox_ShowPreviousEvents;
	}
}