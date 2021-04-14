
namespace SecretCellar {
	partial class FrmEventsAll {
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
			this.dataGridView_Events = new System.Windows.Forms.DataGridView();
			this.button_CloseWindow = new System.Windows.Forms.Button();
			this.button_DeleteEvent = new System.Windows.Forms.Button();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Date,
            this.Event,
            this.Price,
            this.Qty});
			this.dataGridView_Events.Location = new System.Drawing.Point(13, 13);
			this.dataGridView_Events.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView_Events.Name = "dataGridView_Events";
			this.dataGridView_Events.RowHeadersVisible = false;
			this.dataGridView_Events.RowHeadersWidth = 62;
			this.dataGridView_Events.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_Events.Size = new System.Drawing.Size(547, 302);
			this.dataGridView_Events.TabIndex = 10;
			// 
			// button_CloseWindow
			// 
			this.button_CloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_CloseWindow.Location = new System.Drawing.Point(13, 328);
			this.button_CloseWindow.Margin = new System.Windows.Forms.Padding(1);
			this.button_CloseWindow.Name = "button_CloseWindow";
			this.button_CloseWindow.Size = new System.Drawing.Size(180, 55);
			this.button_CloseWindow.TabIndex = 16;
			this.button_CloseWindow.TabStop = false;
			this.button_CloseWindow.Text = "CLOSE WINDOW";
			this.button_CloseWindow.UseVisualStyleBackColor = true;
			this.button_CloseWindow.Click += new System.EventHandler(this.button_CloseWindow_Click);
			// 
			// button_DeleteEvent
			// 
			this.button_DeleteEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_DeleteEvent.Location = new System.Drawing.Point(380, 328);
			this.button_DeleteEvent.Margin = new System.Windows.Forms.Padding(1);
			this.button_DeleteEvent.Name = "button_DeleteEvent";
			this.button_DeleteEvent.Size = new System.Drawing.Size(180, 55);
			this.button_DeleteEvent.TabIndex = 17;
			this.button_DeleteEvent.TabStop = false;
			this.button_DeleteEvent.Text = "DELETE EVENT";
			this.button_DeleteEvent.UseVisualStyleBackColor = true;
			this.button_DeleteEvent.Click += new System.EventHandler(this.button_DeleteEvent_Click);
			// 
			// Id
			// 
			this.Id.HeaderText = "Event Id";
			this.Id.Name = "Id";
			this.Id.Visible = false;
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
			// FrmEventsAll
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(573, 393);
			this.Controls.Add(this.button_DeleteEvent);
			this.Controls.Add(this.button_CloseWindow);
			this.Controls.Add(this.dataGridView_Events);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmEventsAll";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "All Events";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Events)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView_Events;
		private System.Windows.Forms.Button button_CloseWindow;
		private System.Windows.Forms.Button button_DeleteEvent;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Date;
		private System.Windows.Forms.DataGridViewTextBoxColumn Event;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
	}
}