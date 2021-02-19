namespace SecretCellar
{
    partial class frmCustom
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddCharge = new System.Windows.Forms.Button();
            this.txt_charge_am = new System.Windows.Forms.TextBox();
            this.lbl_custom = new System.Windows.Forms.Label();
            this.txt_descript = new System.Windows.Forms.TextBox();
            this.lbl_Descript = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(484, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(178, 125);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddCharge
            // 
            this.btnAddCharge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCharge.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAddCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btnAddCharge.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddCharge.Location = new System.Drawing.Point(139, 300);
            this.btnAddCharge.Name = "btnAddCharge";
            this.btnAddCharge.Size = new System.Drawing.Size(178, 125);
            this.btnAddCharge.TabIndex = 6;
            this.btnAddCharge.Text = "Add Charge";
            this.btnAddCharge.UseVisualStyleBackColor = false;
            this.btnAddCharge.Click += new System.EventHandler(this.btnAddCharge_Click);
            // 
            // txt_charge_am
            // 
            this.txt_charge_am.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_charge_am.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txt_charge_am.Location = new System.Drawing.Point(464, 213);
            this.txt_charge_am.Name = "txt_charge_am";
            this.txt_charge_am.Size = new System.Drawing.Size(160, 38);
            this.txt_charge_am.TabIndex = 5;
            this.txt_charge_am.TextChanged += new System.EventHandler(this.txt_charge_am_TextChanged);
            // 
            // lbl_custom
            // 
            this.lbl_custom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_custom.AutoSize = true;
            this.lbl_custom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_custom.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.lbl_custom.Location = new System.Drawing.Point(172, 210);
            this.lbl_custom.Name = "lbl_custom";
            this.lbl_custom.Size = new System.Drawing.Size(264, 39);
            this.lbl_custom.TabIndex = 4;
            this.lbl_custom.Text = "Custom Charge:";
            // 
            // txt_descript
            // 
            this.txt_descript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_descript.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txt_descript.Location = new System.Drawing.Point(479, 143);
            this.txt_descript.Name = "txt_descript";
            this.txt_descript.Size = new System.Drawing.Size(225, 38);
            this.txt_descript.TabIndex = 9;
            this.txt_descript.TextChanged += new System.EventHandler(this.txt_descript_TextChanged);
            // 
            // lbl_Descript
            // 
            this.lbl_Descript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Descript.AutoSize = true;
            this.lbl_Descript.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_Descript.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.lbl_Descript.Location = new System.Drawing.Point(84, 143);
            this.lbl_Descript.Name = "lbl_Descript";
            this.lbl_Descript.Size = new System.Drawing.Size(389, 39);
            this.lbl_Descript.TabIndex = 8;
            this.lbl_Descript.Text = "Custom Item Description";
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_title.AutoSize = true;
            this.lbl_title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Bold);
            this.lbl_title.Location = new System.Drawing.Point(271, 51);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(220, 39);
            this.lbl_title.TabIndex = 10;
            this.lbl_title.Text = "Custom Item";
            // 
            // frmCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txt_descript);
            this.Controls.Add(this.lbl_Descript);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddCharge);
            this.Controls.Add(this.txt_charge_am);
            this.Controls.Add(this.lbl_custom);
            this.Name = "frmCustom";
            this.Text = "frmCustom";
            this.Load += new System.EventHandler(this.frmCustom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddCharge;
        private System.Windows.Forms.TextBox txt_charge_am;
        private System.Windows.Forms.Label lbl_custom;
        private System.Windows.Forms.TextBox txt_descript;
        private System.Windows.Forms.Label lbl_Descript;
        private System.Windows.Forms.Label lbl_title;
    }
}