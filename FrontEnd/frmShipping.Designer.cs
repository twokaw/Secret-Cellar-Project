namespace SecretCellar
{
    partial class frmShipping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShipping));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddCharge = new System.Windows.Forms.Button();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(677, 372);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(267, 154);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddCharge
            // 
            this.btnAddCharge.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAddCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btnAddCharge.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddCharge.Location = new System.Drawing.Point(356, 372);
            this.btnAddCharge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddCharge.Name = "btnAddCharge";
            this.btnAddCharge.Size = new System.Drawing.Size(267, 154);
            this.btnAddCharge.TabIndex = 6;
            this.btnAddCharge.Text = "Add Charge";
            this.btnAddCharge.UseVisualStyleBackColor = false;
            this.btnAddCharge.Click += new System.EventHandler(this.btnAddCharge_Click);
            // 
            // txtCharge
            // 
            this.txtCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtCharge.Location = new System.Drawing.Point(706, 204);
            this.txtCharge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Size = new System.Drawing.Size(238, 38);
            this.txtCharge.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.lblTitle.Location = new System.Drawing.Point(342, 204);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(281, 39);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Shipping Charge:";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // frmShipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddCharge);
            this.Controls.Add(this.txtCharge);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmShipping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmShipping";
            this.Load += new System.EventHandler(this.frmShipping_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddCharge;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.Label lblTitle;
    }
}