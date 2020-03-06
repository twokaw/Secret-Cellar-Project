namespace SecretCellar
{
    partial class frmTransaction
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
            this.itemNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemNumber
            // 
            this.itemNumber.AutoSize = true;
            this.itemNumber.Location = new System.Drawing.Point(36, 30);
            this.itemNumber.Name = "itemNumber";
            this.itemNumber.Size = new System.Drawing.Size(104, 32);
            this.itemNumber.TabIndex = 0;
            this.itemNumber.Text = "ITEM #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2049, 949);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemNumber);
            this.Name = "frmTransaction";
            this.Text = "frmTransaction";
            this.Load += new System.EventHandler(this.frmTransaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemNumber;
        private System.Windows.Forms.Label label1;
    }
}