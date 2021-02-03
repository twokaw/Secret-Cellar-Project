namespace SecretCellar
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.tab_receipt = new System.Windows.Forms.TabControl();
            this.tab_Hardware = new System.Windows.Forms.TabPage();
            this.tab_Types = new System.Windows.Forms.TabPage();
            this.chk_lst_discount = new System.Windows.Forms.CheckedListBox();
            this.lbl_discount = new System.Windows.Forms.Label();
            this.btn_type_clear = new System.Windows.Forms.Button();
            this.lbl_typename = new System.Windows.Forms.Label();
            this.txt_typename = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_update_type = new System.Windows.Forms.Button();
            this.btn_new_type = new System.Windows.Forms.Button();
            this.lbl_localTax = new System.Windows.Forms.Label();
            this.txt_localTax = new System.Windows.Forms.TextBox();
            this.lbl_salesTax = new System.Windows.Forms.Label();
            this.txt_salesTax = new System.Windows.Forms.TextBox();
            this.lbl_bottleDep = new System.Windows.Forms.Label();
            this.txt_bottleDep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_tax = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstTypes = new System.Windows.Forms.ListBox();
            this.tab_Appearance = new System.Windows.Forms.TabPage();
            this.btn_change_logo = new System.Windows.Forms.Button();
            this.listbox_logos = new System.Windows.Forms.ListBox();
            this.btn_change_image = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_row_color = new System.Windows.Forms.Button();
            this.btn_font_settings = new System.Windows.Forms.Button();
            this.btn_panel_color = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.tab_Reports = new System.Windows.Forms.TabPage();
            this.btn_Run = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSalesVendor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSalesInvType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtSalesTotals = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.tab_Reciept = new System.Windows.Forms.TabPage();
            this.btn_rec_font = new System.Windows.Forms.Button();
            this.btn_foot = new System.Windows.Forms.Button();
            this.btn_header = new System.Windows.Forms.Button();
            this.btn_commit = new System.Windows.Forms.Button();
            this.tab_receipt.SuspendLayout();
            this.tab_Types.SuspendLayout();
            this.tab_Appearance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.tab_Reports.SuspendLayout();
            this.tab_Reciept.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_receipt
            // 
            this.tab_receipt.Controls.Add(this.tab_Hardware);
            this.tab_receipt.Controls.Add(this.tab_Types);
            this.tab_receipt.Controls.Add(this.tab_Appearance);
            this.tab_receipt.Controls.Add(this.tab_Reports);
            this.tab_receipt.Controls.Add(this.tab_Reciept);
            this.tab_receipt.Location = new System.Drawing.Point(71, 15);
            this.tab_receipt.Margin = new System.Windows.Forms.Padding(4);
            this.tab_receipt.Name = "tab_receipt";
            this.tab_receipt.SelectedIndex = 0;
            this.tab_receipt.Size = new System.Drawing.Size(848, 332);
            this.tab_receipt.TabIndex = 0;
            // 
            // tab_Hardware
            // 
            this.tab_Hardware.Location = new System.Drawing.Point(4, 25);
            this.tab_Hardware.Margin = new System.Windows.Forms.Padding(4);
            this.tab_Hardware.Name = "tab_Hardware";
            this.tab_Hardware.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Hardware.Size = new System.Drawing.Size(840, 303);
            this.tab_Hardware.TabIndex = 0;
            this.tab_Hardware.Text = "Hardware";
            this.tab_Hardware.UseVisualStyleBackColor = true;
            // 
            // tab_Types
            // 
            this.tab_Types.Controls.Add(this.chk_lst_discount);
            this.tab_Types.Controls.Add(this.lbl_discount);
            this.tab_Types.Controls.Add(this.btn_type_clear);
            this.tab_Types.Controls.Add(this.lbl_typename);
            this.tab_Types.Controls.Add(this.txt_typename);
            this.tab_Types.Controls.Add(this.label12);
            this.tab_Types.Controls.Add(this.btn_update_type);
            this.tab_Types.Controls.Add(this.btn_new_type);
            this.tab_Types.Controls.Add(this.lbl_localTax);
            this.tab_Types.Controls.Add(this.txt_localTax);
            this.tab_Types.Controls.Add(this.lbl_salesTax);
            this.tab_Types.Controls.Add(this.txt_salesTax);
            this.tab_Types.Controls.Add(this.lbl_bottleDep);
            this.tab_Types.Controls.Add(this.txt_bottleDep);
            this.tab_Types.Controls.Add(this.label3);
            this.tab_Types.Controls.Add(this.cbx_tax);
            this.tab_Types.Controls.Add(this.label2);
            this.tab_Types.Controls.Add(this.label1);
            this.tab_Types.Controls.Add(this.lstTypes);
            this.tab_Types.Location = new System.Drawing.Point(4, 25);
            this.tab_Types.Margin = new System.Windows.Forms.Padding(4);
            this.tab_Types.Name = "tab_Types";
            this.tab_Types.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Types.Size = new System.Drawing.Size(840, 303);
            this.tab_Types.TabIndex = 1;
            this.tab_Types.Text = "Types";
            this.tab_Types.UseVisualStyleBackColor = true;
            this.tab_Types.Click += new System.EventHandler(this.TabTypes_Click);
            // 
            // chk_lst_discount
            // 
            this.chk_lst_discount.FormattingEnabled = true;
            this.chk_lst_discount.Location = new System.Drawing.Point(464, 49);
            this.chk_lst_discount.Name = "chk_lst_discount";
            this.chk_lst_discount.Size = new System.Drawing.Size(184, 89);
            this.chk_lst_discount.TabIndex = 21;
            this.chk_lst_discount.SelectedIndexChanged += new System.EventHandler(this.chk_lst_discount_SelectedIndexChanged);
            // 
            // lbl_discount
            // 
            this.lbl_discount.AutoSize = true;
            this.lbl_discount.Location = new System.Drawing.Point(484, 21);
            this.lbl_discount.Name = "lbl_discount";
            this.lbl_discount.Size = new System.Drawing.Size(76, 16);
            this.lbl_discount.TabIndex = 20;
            this.lbl_discount.Text = "Discounts";
            // 
            // btn_type_clear
            // 
            this.btn_type_clear.Location = new System.Drawing.Point(694, 45);
            this.btn_type_clear.Name = "btn_type_clear";
            this.btn_type_clear.Size = new System.Drawing.Size(113, 23);
            this.btn_type_clear.TabIndex = 18;
            this.btn_type_clear.Text = "Clear";
            this.btn_type_clear.UseVisualStyleBackColor = true;
            // 
            // lbl_typename
            // 
            this.lbl_typename.AutoSize = true;
            this.lbl_typename.Location = new System.Drawing.Point(216, 71);
            this.lbl_typename.Name = "lbl_typename";
            this.lbl_typename.Size = new System.Drawing.Size(89, 16);
            this.lbl_typename.TabIndex = 17;
            this.lbl_typename.Text = "Type Name";
            // 
            // txt_typename
            // 
            this.txt_typename.Location = new System.Drawing.Point(216, 95);
            this.txt_typename.Name = "txt_typename";
            this.txt_typename.Size = new System.Drawing.Size(129, 22);
            this.txt_typename.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(216, 87);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = " ";
            // 
            // btn_update_type
            // 
            this.btn_update_type.Location = new System.Drawing.Point(694, 222);
            this.btn_update_type.Name = "btn_update_type";
            this.btn_update_type.Size = new System.Drawing.Size(113, 23);
            this.btn_update_type.TabIndex = 14;
            this.btn_update_type.Text = "Update Type";
            this.btn_update_type.UseVisualStyleBackColor = true;
            this.btn_update_type.Click += new System.EventHandler(this.btn_update_type_Click);
            // 
            // btn_new_type
            // 
            this.btn_new_type.Location = new System.Drawing.Point(694, 159);
            this.btn_new_type.Name = "btn_new_type";
            this.btn_new_type.Size = new System.Drawing.Size(113, 23);
            this.btn_new_type.TabIndex = 13;
            this.btn_new_type.Text = "New Type";
            this.btn_new_type.UseVisualStyleBackColor = true;
            this.btn_new_type.Click += new System.EventHandler(this.btn_new_type_Click);
            // 
            // lbl_localTax
            // 
            this.lbl_localTax.AutoSize = true;
            this.lbl_localTax.Location = new System.Drawing.Point(468, 232);
            this.lbl_localTax.Name = "lbl_localTax";
            this.lbl_localTax.Size = new System.Drawing.Size(76, 16);
            this.lbl_localTax.TabIndex = 12;
            this.lbl_localTax.Text = "Local Tax";
            // 
            // txt_localTax
            // 
            this.txt_localTax.Location = new System.Drawing.Point(465, 251);
            this.txt_localTax.Name = "txt_localTax";
            this.txt_localTax.Size = new System.Drawing.Size(129, 22);
            this.txt_localTax.TabIndex = 11;
            // 
            // lbl_salesTax
            // 
            this.lbl_salesTax.AutoSize = true;
            this.lbl_salesTax.Location = new System.Drawing.Point(465, 167);
            this.lbl_salesTax.Name = "lbl_salesTax";
            this.lbl_salesTax.Size = new System.Drawing.Size(78, 16);
            this.lbl_salesTax.TabIndex = 9;
            this.lbl_salesTax.Text = "Sales Tax";
            // 
            // txt_salesTax
            // 
            this.txt_salesTax.Location = new System.Drawing.Point(465, 191);
            this.txt_salesTax.Name = "txt_salesTax";
            this.txt_salesTax.Size = new System.Drawing.Size(129, 22);
            this.txt_salesTax.TabIndex = 8;
            // 
            // lbl_bottleDep
            // 
            this.lbl_bottleDep.AutoSize = true;
            this.lbl_bottleDep.Location = new System.Drawing.Point(219, 181);
            this.lbl_bottleDep.Name = "lbl_bottleDep";
            this.lbl_bottleDep.Size = new System.Drawing.Size(106, 16);
            this.lbl_bottleDep.TabIndex = 6;
            this.lbl_bottleDep.Text = "Bottle Deposit";
            // 
            // txt_bottleDep
            // 
            this.txt_bottleDep.Location = new System.Drawing.Point(219, 205);
            this.txt_bottleDep.Name = "txt_bottleDep";
            this.txt_bottleDep.Size = new System.Drawing.Size(129, 22);
            this.txt_bottleDep.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tax Type";
            // 
            // cbx_tax
            // 
            this.cbx_tax.FormattingEnabled = true;
            this.cbx_tax.Location = new System.Drawing.Point(216, 142);
            this.cbx_tax.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_tax.Name = "cbx_tax";
            this.cbx_tax.Size = new System.Drawing.Size(224, 24);
            this.cbx_tax.TabIndex = 3;
            this.cbx_tax.SelectedIndexChanged += new System.EventHandler(this.cbx_tax_type_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = " ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory Type";
            // 
            // lstTypes
            // 
            this.lstTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstTypes.FormattingEnabled = true;
            this.lstTypes.ItemHeight = 16;
            this.lstTypes.Location = new System.Drawing.Point(28, 42);
            this.lstTypes.Margin = new System.Windows.Forms.Padding(4);
            this.lstTypes.Name = "lstTypes";
            this.lstTypes.Size = new System.Drawing.Size(152, 244);
            this.lstTypes.TabIndex = 0;
            this.lstTypes.SelectedIndexChanged += new System.EventHandler(this.lstTypes_SelectedIndexChanged);
            // 
            // tab_Appearance
            // 
            this.tab_Appearance.Controls.Add(this.btn_change_logo);
            this.tab_Appearance.Controls.Add(this.listbox_logos);
            this.tab_Appearance.Controls.Add(this.btn_change_image);
            this.tab_Appearance.Controls.Add(this.btn_reset);
            this.tab_Appearance.Controls.Add(this.btn_row_color);
            this.tab_Appearance.Controls.Add(this.btn_font_settings);
            this.tab_Appearance.Controls.Add(this.btn_panel_color);
            this.tab_Appearance.Controls.Add(this.btn_color);
            this.tab_Appearance.Controls.Add(this.pic_logo);
            this.tab_Appearance.Location = new System.Drawing.Point(4, 25);
            this.tab_Appearance.Margin = new System.Windows.Forms.Padding(1);
            this.tab_Appearance.Name = "tab_Appearance";
            this.tab_Appearance.Size = new System.Drawing.Size(840, 303);
            this.tab_Appearance.TabIndex = 2;
            this.tab_Appearance.Text = "Appearance";
            this.tab_Appearance.UseVisualStyleBackColor = true;
            this.tab_Appearance.Click += new System.EventHandler(this.tab_General_Click);
            // 
            // btn_change_logo
            // 
            this.btn_change_logo.Location = new System.Drawing.Point(334, 154);
            this.btn_change_logo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_change_logo.Name = "btn_change_logo";
            this.btn_change_logo.Size = new System.Drawing.Size(145, 24);
            this.btn_change_logo.TabIndex = 8;
            this.btn_change_logo.Text = "Change Logo";
            this.btn_change_logo.UseVisualStyleBackColor = true;
            this.btn_change_logo.Click += new System.EventHandler(this.btn_change_logo_Click);
            // 
            // listbox_logos
            // 
            this.listbox_logos.FormattingEnabled = true;
            this.listbox_logos.ItemHeight = 16;
            this.listbox_logos.Location = new System.Drawing.Point(318, 89);
            this.listbox_logos.Margin = new System.Windows.Forms.Padding(2);
            this.listbox_logos.Name = "listbox_logos";
            this.listbox_logos.Size = new System.Drawing.Size(182, 52);
            this.listbox_logos.TabIndex = 7;
            this.listbox_logos.SelectedIndexChanged += new System.EventHandler(this.listbox_logos_SelectedIndexChanged);
            // 
            // btn_change_image
            // 
            this.btn_change_image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_change_image.AutoSize = true;
            this.btn_change_image.Location = new System.Drawing.Point(79, 225);
            this.btn_change_image.Name = "btn_change_image";
            this.btn_change_image.Size = new System.Drawing.Size(181, 26);
            this.btn_change_image.TabIndex = 5;
            this.btn_change_image.Text = "Import Image";
            this.btn_change_image.UseVisualStyleBackColor = true;
            this.btn_change_image.Click += new System.EventHandler(this.btn_change_image_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reset.AutoSize = true;
            this.btn_reset.Location = new System.Drawing.Point(530, 228);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(181, 26);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "Default Settings";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_row_color
            // 
            this.btn_row_color.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_row_color.AutoSize = true;
            this.btn_row_color.Location = new System.Drawing.Point(530, 170);
            this.btn_row_color.Name = "btn_row_color";
            this.btn_row_color.Size = new System.Drawing.Size(181, 26);
            this.btn_row_color.TabIndex = 3;
            this.btn_row_color.Text = "Row Color Settings";
            this.btn_row_color.UseVisualStyleBackColor = true;
            this.btn_row_color.Click += new System.EventHandler(this.btn_row_color_Click);
            // 
            // btn_font_settings
            // 
            this.btn_font_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_font_settings.AutoSize = true;
            this.btn_font_settings.Location = new System.Drawing.Point(530, 138);
            this.btn_font_settings.Name = "btn_font_settings";
            this.btn_font_settings.Size = new System.Drawing.Size(181, 26);
            this.btn_font_settings.TabIndex = 2;
            this.btn_font_settings.Text = "Font Settings";
            this.btn_font_settings.UseVisualStyleBackColor = true;
            this.btn_font_settings.Click += new System.EventHandler(this.btn_font_settings_Click);
            // 
            // btn_panel_color
            // 
            this.btn_panel_color.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_panel_color.AutoSize = true;
            this.btn_panel_color.Location = new System.Drawing.Point(530, 107);
            this.btn_panel_color.Name = "btn_panel_color";
            this.btn_panel_color.Size = new System.Drawing.Size(181, 26);
            this.btn_panel_color.TabIndex = 1;
            this.btn_panel_color.Text = "Panel Color Settings";
            this.btn_panel_color.UseVisualStyleBackColor = true;
            this.btn_panel_color.Click += new System.EventHandler(this.btn_panel_color_Click);
            // 
            // btn_color
            // 
            this.btn_color.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_color.AutoSize = true;
            this.btn_color.Location = new System.Drawing.Point(530, 76);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(181, 26);
            this.btn_color.TabIndex = 0;
            this.btn_color.Text = "Color Settings";
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.Location = new System.Drawing.Point(8, 89);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(305, 118);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 6;
            this.pic_logo.TabStop = false;
            this.pic_logo.Click += new System.EventHandler(this.pic_logo_Click);
            // 
            // tab_Reports
            // 
            this.tab_Reports.Controls.Add(this.btn_Run);
            this.tab_Reports.Controls.Add(this.label7);
            this.tab_Reports.Controls.Add(this.TxtSalesVendor);
            this.tab_Reports.Controls.Add(this.label6);
            this.tab_Reports.Controls.Add(this.TxtSalesInvType);
            this.tab_Reports.Controls.Add(this.label8);
            this.tab_Reports.Controls.Add(this.TxtSalesTotals);
            this.tab_Reports.Controls.Add(this.label5);
            this.tab_Reports.Controls.Add(this.dtp_end);
            this.tab_Reports.Controls.Add(this.label4);
            this.tab_Reports.Controls.Add(this.dtp_start);
            this.tab_Reports.Location = new System.Drawing.Point(4, 25);
            this.tab_Reports.Margin = new System.Windows.Forms.Padding(1);
            this.tab_Reports.Name = "tab_Reports";
            this.tab_Reports.Size = new System.Drawing.Size(840, 303);
            this.tab_Reports.TabIndex = 3;
            this.tab_Reports.Text = "Reports";
            this.tab_Reports.UseVisualStyleBackColor = true;
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(17, 15);
            this.btn_Run.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(80, 22);
            this.btn_Run.TabIndex = 15;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(597, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Vendor";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtSalesVendor
            // 
            this.TxtSalesVendor.Location = new System.Drawing.Point(597, 110);
            this.TxtSalesVendor.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSalesVendor.Multiline = true;
            this.TxtSalesVendor.Name = "TxtSalesVendor";
            this.TxtSalesVendor.ReadOnly = true;
            this.TxtSalesVendor.Size = new System.Drawing.Size(192, 184);
            this.TxtSalesVendor.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(387, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Inventory Type";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtSalesInvType
            // 
            this.TxtSalesInvType.Location = new System.Drawing.Point(387, 110);
            this.TxtSalesInvType.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSalesInvType.Multiline = true;
            this.TxtSalesInvType.Name = "TxtSalesInvType";
            this.TxtSalesInvType.ReadOnly = true;
            this.TxtSalesInvType.Size = new System.Drawing.Size(192, 184);
            this.TxtSalesInvType.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(177, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtSalesTotals
            // 
            this.TxtSalesTotals.Location = new System.Drawing.Point(177, 110);
            this.TxtSalesTotals.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSalesTotals.Multiline = true;
            this.TxtSalesTotals.Name = "TxtSalesTotals";
            this.TxtSalesTotals.ReadOnly = true;
            this.TxtSalesTotals.Size = new System.Drawing.Size(192, 184);
            this.TxtSalesTotals.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "End:";
            // 
            // dtp_end
            // 
            this.dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_end.Location = new System.Drawing.Point(271, 54);
            this.dtp_end.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_end.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(122, 22);
            this.dtp_end.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Start:";
            // 
            // dtp_start
            // 
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_start.Location = new System.Drawing.Point(75, 54);
            this.dtp_start.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_start.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(122, 22);
            this.dtp_start.TabIndex = 1;
            // 
            // tab_Reciept
            // 
            this.tab_Reciept.Controls.Add(this.btn_rec_font);
            this.tab_Reciept.Controls.Add(this.btn_foot);
            this.tab_Reciept.Controls.Add(this.btn_header);
            this.tab_Reciept.Location = new System.Drawing.Point(4, 25);
            this.tab_Reciept.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tab_Reciept.Name = "tab_Reciept";
            this.tab_Reciept.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tab_Reciept.Size = new System.Drawing.Size(840, 303);
            this.tab_Reciept.TabIndex = 4;
            this.tab_Reciept.Text = "Receipt";
            this.tab_Reciept.UseVisualStyleBackColor = true;
            // 
            // btn_rec_font
            // 
            this.btn_rec_font.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rec_font.AutoSize = true;
            this.btn_rec_font.Location = new System.Drawing.Point(312, 161);
            this.btn_rec_font.Name = "btn_rec_font";
            this.btn_rec_font.Size = new System.Drawing.Size(181, 26);
            this.btn_rec_font.TabIndex = 8;
            this.btn_rec_font.Text = "Change Receipt Font";
            this.btn_rec_font.UseVisualStyleBackColor = true;
            // 
            // btn_foot
            // 
            this.btn_foot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_foot.AutoSize = true;
            this.btn_foot.Location = new System.Drawing.Point(312, 127);
            this.btn_foot.Name = "btn_foot";
            this.btn_foot.Size = new System.Drawing.Size(181, 26);
            this.btn_foot.TabIndex = 7;
            this.btn_foot.Text = "Change Reciept Footer";
            this.btn_foot.UseVisualStyleBackColor = true;
            // 
            // btn_header
            // 
            this.btn_header.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_header.AutoSize = true;
            this.btn_header.Location = new System.Drawing.Point(312, 97);
            this.btn_header.Name = "btn_header";
            this.btn_header.Size = new System.Drawing.Size(185, 26);
            this.btn_header.TabIndex = 6;
            this.btn_header.Text = "Change Receipt Header";
            this.btn_header.UseVisualStyleBackColor = true;
            // 
            // btn_commit
            // 
            this.btn_commit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_commit.AutoSize = true;
            this.btn_commit.Location = new System.Drawing.Point(380, 355);
            this.btn_commit.Name = "btn_commit";
            this.btn_commit.Size = new System.Drawing.Size(295, 26);
            this.btn_commit.TabIndex = 4;
            this.btn_commit.Text = "Commit";
            this.btn_commit.UseVisualStyleBackColor = true;
            this.btn_commit.Click += new System.EventHandler(this.btn_commit_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 402);
            this.Controls.Add(this.btn_commit);
            this.Controls.Add(this.tab_receipt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSetting";
            this.Load += new System.EventHandler(this.FrmSetting_Load);
            this.tab_receipt.ResumeLayout(false);
            this.tab_Types.ResumeLayout(false);
            this.tab_Types.PerformLayout();
            this.tab_Appearance.ResumeLayout(false);
            this.tab_Appearance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.tab_Reports.ResumeLayout(false);
            this.tab_Reports.PerformLayout();
            this.tab_Reciept.ResumeLayout(false);
            this.tab_Reciept.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_receipt;
        private System.Windows.Forms.TabPage tab_Hardware;
        private System.Windows.Forms.TabPage tab_Types;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstTypes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_tax;
        private System.Windows.Forms.TabPage tab_Appearance;
        private System.Windows.Forms.TabPage tab_Reports;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button btn_font_settings;
        private System.Windows.Forms.Button btn_panel_color;
        private System.Windows.Forms.Button btn_row_color;
        private System.Windows.Forms.Button btn_commit;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TabPage tab_Reciept;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSalesVendor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSalesInvType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtSalesTotals;
        private System.Windows.Forms.Button btn_change_image;
        private System.Windows.Forms.Button btn_rec_font;
        private System.Windows.Forms.Button btn_foot;
        private System.Windows.Forms.Button btn_header;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.ListBox listbox_logos;
        private System.Windows.Forms.Button btn_change_logo;
        private System.Windows.Forms.TextBox txt_bottleDep;
        private System.Windows.Forms.Label lbl_salesTax;
        private System.Windows.Forms.TextBox txt_salesTax;
        private System.Windows.Forms.Label lbl_bottleDep;
        private System.Windows.Forms.Label lbl_localTax;
        private System.Windows.Forms.TextBox txt_localTax;
        private System.Windows.Forms.Button btn_update_type;
        private System.Windows.Forms.Button btn_new_type;
        private System.Windows.Forms.Label lbl_typename;
        private System.Windows.Forms.TextBox txt_typename;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_type_clear;
        private System.Windows.Forms.Label lbl_discount;
        private System.Windows.Forms.CheckedListBox chk_lst_discount;
    }
}