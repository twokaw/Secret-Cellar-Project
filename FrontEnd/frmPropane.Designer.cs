﻿namespace SecretCellar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPropane));
            this.txt_ex_Qty = new System.Windows.Forms.TextBox();
            this.btn_minus_ex = new System.Windows.Forms.Button();
            this.btn_plus_ex = new System.Windows.Forms.Button();
            this.btn_plus_new = new System.Windows.Forms.Button();
            this.btn_minus_new = new System.Windows.Forms.Button();
            this.txt_new_Qty = new System.Windows.Forms.TextBox();
            this.lbl_prop_ex = new System.Windows.Forms.Label();
            this.lbl_prop_new = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_ex_Qty
            // 
            this.txt_ex_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ex_Qty.Location = new System.Drawing.Point(778, 48);
            this.txt_ex_Qty.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_ex_Qty.Name = "txt_ex_Qty";
            this.txt_ex_Qty.Size = new System.Drawing.Size(120, 62);
            this.txt_ex_Qty.TabIndex = 1;
            // 
            // btn_minus_ex
            // 
            this.btn_minus_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus_ex.Location = new System.Drawing.Point(615, 39);
            this.btn_minus_ex.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_minus_ex.Name = "btn_minus_ex";
            this.btn_minus_ex.Size = new System.Drawing.Size(124, 102);
            this.btn_minus_ex.TabIndex = 0;
            this.btn_minus_ex.Text = "-";
            this.btn_minus_ex.UseVisualStyleBackColor = true;
            this.btn_minus_ex.Click += new System.EventHandler(this.btn_minus_ex_Click);
            // 
            // btn_plus_ex
            // 
            this.btn_plus_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus_ex.Location = new System.Drawing.Point(939, 38);
            this.btn_plus_ex.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_plus_ex.Name = "btn_plus_ex";
            this.btn_plus_ex.Size = new System.Drawing.Size(124, 102);
            this.btn_plus_ex.TabIndex = 2;
            this.btn_plus_ex.Text = "+";
            this.btn_plus_ex.UseVisualStyleBackColor = true;
            this.btn_plus_ex.Click += new System.EventHandler(this.btn_plus_ex_Click);
            // 
            // btn_plus_new
            // 
            this.btn_plus_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus_new.Location = new System.Drawing.Point(939, 207);
            this.btn_plus_new.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_plus_new.Name = "btn_plus_new";
            this.btn_plus_new.Size = new System.Drawing.Size(124, 102);
            this.btn_plus_new.TabIndex = 5;
            this.btn_plus_new.Text = "+";
            this.btn_plus_new.UseVisualStyleBackColor = true;
            this.btn_plus_new.Click += new System.EventHandler(this.btn_plus_new_Click);
            // 
            // btn_minus_new
            // 
            this.btn_minus_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus_new.Location = new System.Drawing.Point(615, 207);
            this.btn_minus_new.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn_minus_new.Name = "btn_minus_new";
            this.btn_minus_new.Size = new System.Drawing.Size(124, 102);
            this.btn_minus_new.TabIndex = 3;
            this.btn_minus_new.Text = "-";
            this.btn_minus_new.UseVisualStyleBackColor = true;
            this.btn_minus_new.Click += new System.EventHandler(this.btn_minus_new_Click);
            // 
            // txt_new_Qty
            // 
            this.txt_new_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_new_Qty.Location = new System.Drawing.Point(778, 216);
            this.txt_new_Qty.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txt_new_Qty.Name = "txt_new_Qty";
            this.txt_new_Qty.Size = new System.Drawing.Size(120, 62);
            this.txt_new_Qty.TabIndex = 4;
            // 
            // lbl_prop_ex
            // 
            this.lbl_prop_ex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_prop_ex.AutoSize = true;
            this.lbl_prop_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prop_ex.Location = new System.Drawing.Point(20, 52);
            this.lbl_prop_ex.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_prop_ex.Name = "lbl_prop_ex";
            this.lbl_prop_ex.Size = new System.Drawing.Size(451, 55);
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
            this.lbl_prop_new.Location = new System.Drawing.Point(156, 208);
            this.lbl_prop_new.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_prop_new.Name = "lbl_prop_new";
            this.lbl_prop_new.Size = new System.Drawing.Size(328, 55);
            this.lbl_prop_new.TabIndex = 13;
            this.lbl_prop_new.Text = "New Propane";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.Location = new System.Drawing.Point(32, 393);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(300, 104);
            this.button_Cancel.TabIndex = 6;
            this.button_Cancel.Text = "CANCEL";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.Location = new System.Drawing.Point(768, 393);
            this.button_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(300, 104);
            this.button_Add.TabIndex = 7;
            this.button_Add.Text = "ADD";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // frmPropane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1084, 516);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.lbl_prop_new);
            this.Controls.Add(this.lbl_prop_ex);
            this.Controls.Add(this.btn_plus_new);
            this.Controls.Add(this.btn_minus_new);
            this.Controls.Add(this.txt_new_Qty);
            this.Controls.Add(this.btn_plus_ex);
            this.Controls.Add(this.btn_minus_ex);
            this.Controls.Add(this.txt_ex_Qty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPropane";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Propane";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_ex_Qty;
        private System.Windows.Forms.Button btn_minus_ex;
        private System.Windows.Forms.Button btn_plus_ex;
        private System.Windows.Forms.Button btn_plus_new;
        private System.Windows.Forms.Button btn_minus_new;
        private System.Windows.Forms.TextBox txt_new_Qty;
        private System.Windows.Forms.Label lbl_prop_ex;
        private System.Windows.Forms.Label lbl_prop_new;
		private System.Windows.Forms.Button button_Cancel;
		private System.Windows.Forms.Button button_Add;
	}
}