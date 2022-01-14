﻿
namespace SecretCellar {
	partial class frmEventsCreate {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEventsCreate));
			this.textBox_Quantity = new System.Windows.Forms.TextBox();
			this.label_Qty = new System.Windows.Forms.Label();
			this.label_Price = new System.Windows.Forms.Label();
			this.label_Date = new System.Windows.Forms.Label();
			this.label_Duration = new System.Windows.Forms.Label();
			this.label_Preorder = new System.Windows.Forms.Label();
			this.label_AtDoor = new System.Windows.Forms.Label();
			this.button_CreateEvent = new System.Windows.Forms.Button();
			this.button_CloseWindow = new System.Windows.Forms.Button();
			this.dateTimePicker_EventDate = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker_Duration = new System.Windows.Forms.DateTimePicker();
			this.textBox_Name = new System.Windows.Forms.TextBox();
			this.label_Name = new System.Windows.Forms.Label();
			this.label_NonTaxable = new System.Windows.Forms.Label();
			this.label_NonTaxableLocal = new System.Windows.Forms.Label();
			this.label_SupplierPrice = new System.Windows.Forms.Label();
			this.checkBox_NonTaxable = new System.Windows.Forms.CheckBox();
			this.checkBox_NonTaxableLocal = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox_SupplierPrice = new SecretCellar.CurrencyBox();
			this.textBox_AtDoor = new SecretCellar.CurrencyBox();
			this.textBox_Preorder = new SecretCellar.CurrencyBox();
			this.textBox_Price = new SecretCellar.CurrencyBox();
			this.SuspendLayout();
			// 
			// textBox_Quantity
			// 
			this.textBox_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Quantity.Location = new System.Drawing.Point(318, 159);
			this.textBox_Quantity.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_Quantity.Name = "textBox_Quantity";
			this.textBox_Quantity.Size = new System.Drawing.Size(305, 38);
			this.textBox_Quantity.TabIndex = 3;
			// 
			// label_Qty
			// 
			this.label_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label_Qty.AutoSize = true;
			this.label_Qty.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.label_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
			this.label_Qty.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label_Qty.Location = new System.Drawing.Point(158, 156);
			this.label_Qty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Qty.Name = "label_Qty";
			this.label_Qty.Size = new System.Drawing.Size(152, 39);
			this.label_Qty.TabIndex = 7;
			this.label_Qty.Text = "Quantity:";
			// 
			// label_Price
			// 
			this.label_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label_Price.AutoSize = true;
			this.label_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.label_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
			this.label_Price.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label_Price.Location = new System.Drawing.Point(206, 292);
			this.label_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Price.Name = "label_Price";
			this.label_Price.Size = new System.Drawing.Size(104, 39);
			this.label_Price.TabIndex = 9;
			this.label_Price.Text = "Price:";
			// 
			// label_Date
			// 
			this.label_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label_Date.AutoSize = true;
			this.label_Date.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
			this.label_Date.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label_Date.Location = new System.Drawing.Point(116, 61);
			this.label_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Date.Name = "label_Date";
			this.label_Date.Size = new System.Drawing.Size(194, 39);
			this.label_Date.TabIndex = 13;
			this.label_Date.Text = "Event Date:";
			// 
			// label_Duration
			// 
			this.label_Duration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label_Duration.AutoSize = true;
			this.label_Duration.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.label_Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
			this.label_Duration.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label_Duration.Location = new System.Drawing.Point(155, 111);
			this.label_Duration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Duration.Name = "label_Duration";
			this.label_Duration.Size = new System.Drawing.Size(155, 39);
			this.label_Duration.TabIndex = 15;
			this.label_Duration.Text = "Duration:";
			// 
			// label_Preorder
			// 
			this.label_Preorder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label_Preorder.AutoSize = true;
			this.label_Preorder.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.label_Preorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
			this.label_Preorder.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label_Preorder.Location = new System.Drawing.Point(152, 203);
			this.label_Preorder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Preorder.Name = "label_Preorder";
			this.label_Preorder.Size = new System.Drawing.Size(158, 39);
			this.label_Preorder.TabIndex = 17;
			this.label_Preorder.Text = "Preorder:";
			// 
			// label_AtDoor
			// 
			this.label_AtDoor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label_AtDoor.AutoSize = true;
			this.label_AtDoor.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.label_AtDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
			this.label_AtDoor.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label_AtDoor.Location = new System.Drawing.Point(169, 246);
			this.label_AtDoor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_AtDoor.Name = "label_AtDoor";
			this.label_AtDoor.Size = new System.Drawing.Size(141, 39);
			this.label_AtDoor.TabIndex = 19;
			this.label_AtDoor.Text = "At Door:";
			// 
			// button_CreateEvent
			// 
			this.button_CreateEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_CreateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_CreateEvent.Location = new System.Drawing.Point(443, 493);
			this.button_CreateEvent.Margin = new System.Windows.Forms.Padding(1);
			this.button_CreateEvent.Name = "button_CreateEvent";
			this.button_CreateEvent.Size = new System.Drawing.Size(180, 55);
			this.button_CreateEvent.TabIndex = 13;
			this.button_CreateEvent.Text = "CREATE EVENT";
			this.button_CreateEvent.UseVisualStyleBackColor = true;
			this.button_CreateEvent.Click += new System.EventHandler(this.button_CreateEvent_Click);
			// 
			// button_CloseWindow
			// 
			this.button_CloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_CloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_CloseWindow.Location = new System.Drawing.Point(10, 493);
			this.button_CloseWindow.Margin = new System.Windows.Forms.Padding(1);
			this.button_CloseWindow.Name = "button_CloseWindow";
			this.button_CloseWindow.Size = new System.Drawing.Size(180, 55);
			this.button_CloseWindow.TabIndex = 12;
			this.button_CloseWindow.Text = "CLOSE WINDOW";
			this.button_CloseWindow.UseVisualStyleBackColor = true;
			this.button_CloseWindow.Click += new System.EventHandler(this.button_CloseWindow_Click);
			// 
			// dateTimePicker_EventDate
			// 
			this.dateTimePicker_EventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker_EventDate.Location = new System.Drawing.Point(318, 72);
			this.dateTimePicker_EventDate.Name = "dateTimePicker_EventDate";
			this.dateTimePicker_EventDate.Size = new System.Drawing.Size(305, 26);
			this.dateTimePicker_EventDate.TabIndex = 1;
			// 
			// dateTimePicker_Duration
			// 
			this.dateTimePicker_Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker_Duration.Location = new System.Drawing.Point(318, 122);
			this.dateTimePicker_Duration.Name = "dateTimePicker_Duration";
			this.dateTimePicker_Duration.Size = new System.Drawing.Size(304, 26);
			this.dateTimePicker_Duration.TabIndex = 2;
			// 
			// textBox_Name
			// 
			this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Name.Location = new System.Drawing.Point(318, 13);
			this.textBox_Name.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_Name.Name = "textBox_Name";
			this.textBox_Name.Size = new System.Drawing.Size(305, 38);
			this.textBox_Name.TabIndex = 0;
			// 
			// label_Name
			// 
			this.label_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label_Name.AutoSize = true;
			this.label_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
			this.label_Name.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label_Name.Location = new System.Drawing.Point(193, 10);
			this.label_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Name.Name = "label_Name";
			this.label_Name.Size = new System.Drawing.Size(117, 39);
			this.label_Name.TabIndex = 25;
			this.label_Name.Text = "Name:";
			// 
			// label_NonTaxable
			// 
			this.label_NonTaxable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label_NonTaxable.AutoSize = true;
			this.label_NonTaxable.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.label_NonTaxable.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
			this.label_NonTaxable.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label_NonTaxable.Location = new System.Drawing.Point(90, 380);
			this.label_NonTaxable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_NonTaxable.Name = "label_NonTaxable";
			this.label_NonTaxable.Size = new System.Drawing.Size(220, 39);
			this.label_NonTaxable.TabIndex = 27;
			this.label_NonTaxable.Text = "Non Taxable:";
			// 
			// label_NonTaxableLocal
			// 
			this.label_NonTaxableLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label_NonTaxableLocal.AutoSize = true;
			this.label_NonTaxableLocal.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.label_NonTaxableLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
			this.label_NonTaxableLocal.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label_NonTaxableLocal.Location = new System.Drawing.Point(3, 425);
			this.label_NonTaxableLocal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_NonTaxableLocal.Name = "label_NonTaxableLocal";
			this.label_NonTaxableLocal.Size = new System.Drawing.Size(311, 39);
			this.label_NonTaxableLocal.TabIndex = 29;
			this.label_NonTaxableLocal.Text = "Non Taxable Local:";
			// 
			// label_SupplierPrice
			// 
			this.label_SupplierPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label_SupplierPrice.AutoSize = true;
			this.label_SupplierPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.label_SupplierPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
			this.label_SupplierPrice.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label_SupplierPrice.Location = new System.Drawing.Point(71, 338);
			this.label_SupplierPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_SupplierPrice.Name = "label_SupplierPrice";
			this.label_SupplierPrice.Size = new System.Drawing.Size(239, 39);
			this.label_SupplierPrice.TabIndex = 31;
			this.label_SupplierPrice.Text = "Supplier Price:";
			// 
			// checkBox_NonTaxable
			// 
			this.checkBox_NonTaxable.AutoSize = true;
			this.checkBox_NonTaxable.Location = new System.Drawing.Point(363, 401);
			this.checkBox_NonTaxable.Name = "checkBox_NonTaxable";
			this.checkBox_NonTaxable.Size = new System.Drawing.Size(15, 14);
			this.checkBox_NonTaxable.TabIndex = 8;
			this.checkBox_NonTaxable.UseVisualStyleBackColor = true;
			// 
			// checkBox_NonTaxableLocal
			// 
			this.checkBox_NonTaxableLocal.AutoSize = true;
			this.checkBox_NonTaxableLocal.Location = new System.Drawing.Point(363, 446);
			this.checkBox_NonTaxableLocal.Name = "checkBox_NonTaxableLocal";
			this.checkBox_NonTaxableLocal.Size = new System.Drawing.Size(15, 14);
			this.checkBox_NonTaxableLocal.TabIndex = 9;
			this.checkBox_NonTaxableLocal.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Location = new System.Drawing.Point(317, 255);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 29);
			this.label1.TabIndex = 32;
			this.label1.Text = "$";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label2.Location = new System.Drawing.Point(315, 301);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 29);
			this.label2.TabIndex = 33;
			this.label2.Text = "$";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Cursor = System.Windows.Forms.Cursors.Default;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label3.Location = new System.Drawing.Point(314, 347);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 29);
			this.label3.TabIndex = 34;
			this.label3.Text = "$";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Cursor = System.Windows.Forms.Cursors.Default;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label4.Location = new System.Drawing.Point(318, 212);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 29);
			this.label4.TabIndex = 35;
			this.label4.Text = "$";
			// 
			// textBox_SupplierPrice
			// 
			this.textBox_SupplierPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_SupplierPrice.Location = new System.Drawing.Point(345, 343);
			this.textBox_SupplierPrice.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_SupplierPrice.Name = "textBox_SupplierPrice";
			this.textBox_SupplierPrice.Size = new System.Drawing.Size(277, 38);
			this.textBox_SupplierPrice.TabIndex = 7;
			this.textBox_SupplierPrice.Text = "0.00";
			// 
			// textBox_AtDoor
			// 
			this.textBox_AtDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_AtDoor.Location = new System.Drawing.Point(345, 251);
			this.textBox_AtDoor.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_AtDoor.Name = "textBox_AtDoor";
			this.textBox_AtDoor.Size = new System.Drawing.Size(277, 38);
			this.textBox_AtDoor.TabIndex = 5;
			this.textBox_AtDoor.Text = "0.00";
			// 
			// textBox_Preorder
			// 
			this.textBox_Preorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Preorder.Location = new System.Drawing.Point(345, 206);
			this.textBox_Preorder.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_Preorder.Name = "textBox_Preorder";
			this.textBox_Preorder.Size = new System.Drawing.Size(277, 38);
			this.textBox_Preorder.TabIndex = 4;
			this.textBox_Preorder.Text = "0.00";
			// 
			// textBox_Price
			// 
			this.textBox_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Price.Location = new System.Drawing.Point(345, 297);
			this.textBox_Price.Margin = new System.Windows.Forms.Padding(4);
			this.textBox_Price.Name = "textBox_Price";
			this.textBox_Price.Size = new System.Drawing.Size(277, 38);
			this.textBox_Price.TabIndex = 6;
			this.textBox_Price.Text = "0.00";
			// 
			// frmEventsCreate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(67)))));
			this.ClientSize = new System.Drawing.Size(633, 558);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.checkBox_NonTaxableLocal);
			this.Controls.Add(this.checkBox_NonTaxable);
			this.Controls.Add(this.textBox_SupplierPrice);
			this.Controls.Add(this.label_SupplierPrice);
			this.Controls.Add(this.label_NonTaxableLocal);
			this.Controls.Add(this.label_NonTaxable);
			this.Controls.Add(this.textBox_Name);
			this.Controls.Add(this.label_Name);
			this.Controls.Add(this.dateTimePicker_Duration);
			this.Controls.Add(this.dateTimePicker_EventDate);
			this.Controls.Add(this.button_CloseWindow);
			this.Controls.Add(this.button_CreateEvent);
			this.Controls.Add(this.textBox_AtDoor);
			this.Controls.Add(this.label_AtDoor);
			this.Controls.Add(this.textBox_Preorder);
			this.Controls.Add(this.label_Preorder);
			this.Controls.Add(this.label_Duration);
			this.Controls.Add(this.label_Date);
			this.Controls.Add(this.textBox_Price);
			this.Controls.Add(this.label_Price);
			this.Controls.Add(this.textBox_Quantity);
			this.Controls.Add(this.label_Qty);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmEventsCreate";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Create Event";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox textBox_Quantity;
		private System.Windows.Forms.Label label_Qty;
		private SecretCellar.CurrencyBox textBox_Price;
		private System.Windows.Forms.Label label_Price;
		private System.Windows.Forms.Label label_Date;
		private System.Windows.Forms.Label label_Duration;
		private SecretCellar.CurrencyBox textBox_Preorder;
		private System.Windows.Forms.Label label_Preorder;
		private SecretCellar.CurrencyBox textBox_AtDoor;
		private System.Windows.Forms.Label label_AtDoor;
		private System.Windows.Forms.Button button_CreateEvent;
		private System.Windows.Forms.Button button_CloseWindow;
		private System.Windows.Forms.DateTimePicker dateTimePicker_EventDate;
		private System.Windows.Forms.DateTimePicker dateTimePicker_Duration;
		private System.Windows.Forms.TextBox textBox_Name;
		private System.Windows.Forms.Label label_Name;
		private System.Windows.Forms.Label label_NonTaxable;
		private System.Windows.Forms.Label label_NonTaxableLocal;
		private SecretCellar.CurrencyBox textBox_SupplierPrice;
		private System.Windows.Forms.Label label_SupplierPrice;
		private System.Windows.Forms.CheckBox checkBox_NonTaxable;
		private System.Windows.Forms.CheckBox checkBox_NonTaxableLocal;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}