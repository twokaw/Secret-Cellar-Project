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
            this.txt_ex_Qty = new System.Windows.Forms.TextBox();
            this.btn_minus_ex = new System.Windows.Forms.Button();
            this.btn_plus_ex = new System.Windows.Forms.Button();
            this.btn_plus_new = new System.Windows.Forms.Button();
            this.btn_minus_new = new System.Windows.Forms.Button();
            this.txt_new_Qty = new System.Windows.Forms.TextBox();
            this.lbl_prop_ex = new System.Windows.Forms.Label();
            this.lbl_prop_new = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPropane
            // 
            this.lblPropane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPropane.AutoSize = true;
            this.lblPropane.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropane.Location = new System.Drawing.Point(255, 30);
            this.lblPropane.Name = "lblPropane";
            this.lblPropane.Size = new System.Drawing.Size(214, 55);
            this.lblPropane.TabIndex = 2;
            this.lblPropane.Text = "Propane";
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(229, 375);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(240, 49);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_ex_Qty
            // 
            this.txt_ex_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ex_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ex_Qty.Location = new System.Drawing.Point(492, 138);
            this.txt_ex_Qty.Name = "txt_ex_Qty";
            this.txt_ex_Qty.Size = new System.Drawing.Size(50, 44);
            this.txt_ex_Qty.TabIndex = 5;
            this.txt_ex_Qty.TextChanged += new System.EventHandler(this.txt_ex_Qty_TextChanged);
            // 
            // btn_minus_ex
            // 
            this.btn_minus_ex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minus_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus_ex.Location = new System.Drawing.Point(427, 138);
            this.btn_minus_ex.Name = "btn_minus_ex";
            this.btn_minus_ex.Size = new System.Drawing.Size(50, 44);
            this.btn_minus_ex.TabIndex = 7;
            this.btn_minus_ex.Text = "-";
            this.btn_minus_ex.UseVisualStyleBackColor = true;
            this.btn_minus_ex.Click += new System.EventHandler(this.btn_minus_ex_Click);
            // 
            // btn_plus_ex
            // 
            this.btn_plus_ex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_plus_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus_ex.Location = new System.Drawing.Point(559, 138);
            this.btn_plus_ex.Name = "btn_plus_ex";
            this.btn_plus_ex.Size = new System.Drawing.Size(50, 44);
            this.btn_plus_ex.TabIndex = 8;
            this.btn_plus_ex.Text = "+";
            this.btn_plus_ex.UseVisualStyleBackColor = true;
            this.btn_plus_ex.Click += new System.EventHandler(this.btn_plus_ex_Click);
            // 
            // btn_plus_new
            // 
            this.btn_plus_new.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_plus_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus_new.Location = new System.Drawing.Point(559, 235);
            this.btn_plus_new.Name = "btn_plus_new";
            this.btn_plus_new.Size = new System.Drawing.Size(50, 44);
            this.btn_plus_new.TabIndex = 11;
            this.btn_plus_new.Text = "+";
            this.btn_plus_new.UseVisualStyleBackColor = true;
            this.btn_plus_new.Click += new System.EventHandler(this.btn_plus_new_Click);
            // 
            // btn_minus_new
            // 
            this.btn_minus_new.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minus_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus_new.Location = new System.Drawing.Point(427, 235);
            this.btn_minus_new.Name = "btn_minus_new";
            this.btn_minus_new.Size = new System.Drawing.Size(50, 44);
            this.btn_minus_new.TabIndex = 10;
            this.btn_minus_new.Text = "-";
            this.btn_minus_new.UseVisualStyleBackColor = true;
            this.btn_minus_new.Click += new System.EventHandler(this.btn_minus_new_Click);
            // 
            // txt_new_Qty
            // 
            this.txt_new_Qty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_new_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_new_Qty.Location = new System.Drawing.Point(492, 235);
            this.txt_new_Qty.Name = "txt_new_Qty";
            this.txt_new_Qty.Size = new System.Drawing.Size(50, 44);
            this.txt_new_Qty.TabIndex = 9;
            this.txt_new_Qty.TextChanged += new System.EventHandler(this.txt_new_Qty_TextChanged);
            // 
            // lbl_prop_ex
            // 
            this.lbl_prop_ex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_prop_ex.AutoSize = true;
            this.lbl_prop_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prop_ex.Location = new System.Drawing.Point(63, 143);
            this.lbl_prop_ex.Name = "lbl_prop_ex";
            this.lbl_prop_ex.Size = new System.Drawing.Size(304, 37);
            this.lbl_prop_ex.TabIndex = 12;
            this.lbl_prop_ex.Text = "Propane Exchange";
            // 
            // lbl_prop_new
            // 
            this.lbl_prop_new.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_prop_new.AutoSize = true;
            this.lbl_prop_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prop_new.Location = new System.Drawing.Point(63, 235);
            this.lbl_prop_new.Name = "lbl_prop_new";
            this.lbl_prop_new.Size = new System.Drawing.Size(222, 37);
            this.lbl_prop_new.TabIndex = 13;
            this.lbl_prop_new.Text = "New Propane";
            // 
            // frmPropane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.lbl_prop_new);
            this.Controls.Add(this.lbl_prop_ex);
            this.Controls.Add(this.btn_plus_new);
            this.Controls.Add(this.btn_minus_new);
            this.Controls.Add(this.txt_new_Qty);
            this.Controls.Add(this.btn_plus_ex);
            this.Controls.Add(this.btn_minus_ex);
            this.Controls.Add(this.txt_ex_Qty);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lblPropane);
            this.Name = "frmPropane";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Propane";
            this.Load += new System.EventHandler(this.frmPropane_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPropane;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txt_ex_Qty;
        private System.Windows.Forms.Button btn_minus_ex;
        private System.Windows.Forms.Button btn_plus_ex;
        private System.Windows.Forms.Button btn_plus_new;
        private System.Windows.Forms.Button btn_minus_new;
        private System.Windows.Forms.TextBox txt_new_Qty;
        private System.Windows.Forms.Label lbl_prop_ex;
        private System.Windows.Forms.Label lbl_prop_new;
    }
}