namespace SecretCellar
{
    partial class frmPropane
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
            this.btn_propane_ex = new System.Windows.Forms.Button();
            this.btn_propane_new = new System.Windows.Forms.Button();
            this.lblPropane = new System.Windows.Forms.Label();
            this.dataGrid_propane = new System.Windows.Forms.DataGridView();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_Qty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_propane)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_propane_ex
            // 
            this.btn_propane_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_propane_ex.Location = new System.Drawing.Point(72, 135);
            this.btn_propane_ex.Name = "btn_propane_ex";
            this.btn_propane_ex.Size = new System.Drawing.Size(240, 49);
            this.btn_propane_ex.TabIndex = 0;
            this.btn_propane_ex.Text = "Propane Exchange";
            this.btn_propane_ex.UseVisualStyleBackColor = true;
            this.btn_propane_ex.Click += new System.EventHandler(this.btn_propane_ex_Click);
            // 
            // btn_propane_new
            // 
            this.btn_propane_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_propane_new.Location = new System.Drawing.Point(72, 256);
            this.btn_propane_new.Name = "btn_propane_new";
            this.btn_propane_new.Size = new System.Drawing.Size(240, 49);
            this.btn_propane_new.TabIndex = 1;
            this.btn_propane_new.Text = "New Propane";
            this.btn_propane_new.UseVisualStyleBackColor = true;
            // 
            // lblPropane
            // 
            this.lblPropane.AutoSize = true;
            this.lblPropane.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropane.Location = new System.Drawing.Point(383, 36);
            this.lblPropane.Name = "lblPropane";
            this.lblPropane.Size = new System.Drawing.Size(214, 55);
            this.lblPropane.TabIndex = 2;
            this.lblPropane.Text = "Propane";
            // 
            // dataGrid_propane
            // 
            this.dataGrid_propane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_propane.Location = new System.Drawing.Point(584, 135);
            this.dataGrid_propane.Name = "dataGrid_propane";
            this.dataGrid_propane.Size = new System.Drawing.Size(413, 170);
            this.dataGrid_propane.TabIndex = 3;
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(332, 389);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(240, 49);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_Qty
            // 
            this.txt_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Qty.Location = new System.Drawing.Point(419, 203);
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(50, 44);
            this.txt_Qty.TabIndex = 5;
            this.txt_Qty.TextChanged += new System.EventHandler(this.txt_Qty_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Qty";
            // 
            // btn_minus
            // 
            this.btn_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus.Location = new System.Drawing.Point(354, 203);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(50, 44);
            this.btn_minus.TabIndex = 7;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            // 
            // btn_plus
            // 
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus.Location = new System.Drawing.Point(486, 203);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(50, 44);
            this.btn_plus.TabIndex = 8;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            // 
            // frmPropane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 450);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Qty);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.dataGrid_propane);
            this.Controls.Add(this.lblPropane);
            this.Controls.Add(this.btn_propane_new);
            this.Controls.Add(this.btn_propane_ex);
            this.Name = "frmPropane";
            this.Text = "Propane";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_propane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_propane_ex;
        private System.Windows.Forms.Button btn_propane_new;
        private System.Windows.Forms.Label lblPropane;
        private System.Windows.Forms.DataGridView dataGrid_propane;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txt_Qty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_plus;
    }
}