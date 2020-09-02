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
            this.lblPropane = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_minus_ex = new System.Windows.Forms.Button();
            this.btn_plus_ex = new System.Windows.Forms.Button();
            this.txt_Qty_exchange = new System.Windows.Forms.TextBox();
            this.btn_plus_new = new System.Windows.Forms.Button();
            this.btn_minus_new = new System.Windows.Forms.Button();
            this.txt_Qty_new_p = new System.Windows.Forms.TextBox();
            this.lbl_change = new System.Windows.Forms.Label();
            this.lbl_new = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPropane
            // 
            this.lblPropane.AutoSize = true;
            this.lblPropane.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropane.Location = new System.Drawing.Point(231, 33);
            this.lblPropane.Name = "lblPropane";
            this.lblPropane.Size = new System.Drawing.Size(214, 55);
            this.lblPropane.TabIndex = 2;
            this.lblPropane.Text = "Propane";
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(223, 359);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(240, 49);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_minus_ex
            // 
            this.btn_minus_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus_ex.Location = new System.Drawing.Point(384, 143);
            this.btn_minus_ex.Name = "btn_minus_ex";
            this.btn_minus_ex.Size = new System.Drawing.Size(50, 44);
            this.btn_minus_ex.TabIndex = 7;
            this.btn_minus_ex.Text = "-";
            this.btn_minus_ex.UseVisualStyleBackColor = true;
            this.btn_minus_ex.Click += new System.EventHandler(this.btn_minus_ex_Click);
            // 
            // btn_plus_ex
            // 
            this.btn_plus_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus_ex.Location = new System.Drawing.Point(516, 143);
            this.btn_plus_ex.Name = "btn_plus_ex";
            this.btn_plus_ex.Size = new System.Drawing.Size(50, 44);
            this.btn_plus_ex.TabIndex = 8;
            this.btn_plus_ex.Text = "+";
            this.btn_plus_ex.UseVisualStyleBackColor = true;
            this.btn_plus_ex.Click += new System.EventHandler(this.btn_plus_ex_Click);
            // 
            // txt_Qty_exchange
            // 
            this.txt_Qty_exchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Qty_exchange.Location = new System.Drawing.Point(449, 143);
            this.txt_Qty_exchange.Name = "txt_Qty_exchange";
            this.txt_Qty_exchange.ReadOnly = true;
            this.txt_Qty_exchange.Size = new System.Drawing.Size(50, 44);
            this.txt_Qty_exchange.TabIndex = 5;
            this.txt_Qty_exchange.TextChanged += new System.EventHandler(this.txt_Qty_TextChanged);
            // 
            // btn_plus_new
            // 
            this.btn_plus_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus_new.Location = new System.Drawing.Point(516, 242);
            this.btn_plus_new.Name = "btn_plus_new";
            this.btn_plus_new.Size = new System.Drawing.Size(50, 44);
            this.btn_plus_new.TabIndex = 11;
            this.btn_plus_new.Text = "+";
            this.btn_plus_new.UseVisualStyleBackColor = true;
            this.btn_plus_new.Click += new System.EventHandler(this.btn_plus_new_Click);
            // 
            // btn_minus_new
            // 
            this.btn_minus_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus_new.Location = new System.Drawing.Point(384, 242);
            this.btn_minus_new.Name = "btn_minus_new";
            this.btn_minus_new.Size = new System.Drawing.Size(50, 44);
            this.btn_minus_new.TabIndex = 10;
            this.btn_minus_new.Text = "-";
            this.btn_minus_new.UseVisualStyleBackColor = true;
            this.btn_minus_new.Click += new System.EventHandler(this.btn_minus_new_Click);
            // 
            // txt_Qty_new_p
            // 
            this.txt_Qty_new_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Qty_new_p.Location = new System.Drawing.Point(449, 242);
            this.txt_Qty_new_p.Name = "txt_Qty_new_p";
            this.txt_Qty_new_p.ReadOnly = true;
            this.txt_Qty_new_p.Size = new System.Drawing.Size(50, 44);
            this.txt_Qty_new_p.TabIndex = 9;
            this.txt_Qty_new_p.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_change
            // 
            this.lbl_change.AutoSize = true;
            this.lbl_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_change.Location = new System.Drawing.Point(74, 147);
            this.lbl_change.Name = "lbl_change";
            this.lbl_change.Size = new System.Drawing.Size(304, 37);
            this.lbl_change.TabIndex = 12;
            this.lbl_change.Text = "Propane Exchange";
            this.lbl_change.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_new
            // 
            this.lbl_new.AutoSize = true;
            this.lbl_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_new.Location = new System.Drawing.Point(135, 245);
            this.lbl_new.Name = "lbl_new";
            this.lbl_new.Size = new System.Drawing.Size(222, 37);
            this.lbl_new.TabIndex = 13;
            this.lbl_new.Text = "New Propane";
            this.lbl_new.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmPropane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.lbl_new);
            this.Controls.Add(this.lbl_change);
            this.Controls.Add(this.btn_plus_new);
            this.Controls.Add(this.btn_minus_new);
            this.Controls.Add(this.txt_Qty_new_p);
            this.Controls.Add(this.btn_plus_ex);
            this.Controls.Add(this.btn_minus_ex);
            this.Controls.Add(this.txt_Qty_exchange);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lblPropane);
            this.Name = "frmPropane";
            this.Text = "Propane";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPropane;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minus_ex;
        private System.Windows.Forms.Button btn_plus_ex;
        private System.Windows.Forms.TextBox txt_Qty_exchange;
        private System.Windows.Forms.Button btn_plus_new;
        private System.Windows.Forms.Button btn_minus_new;
        private System.Windows.Forms.TextBox txt_Qty_new_p;
        private System.Windows.Forms.Label lbl_change;
        private System.Windows.Forms.Label lbl_new;
    }
}