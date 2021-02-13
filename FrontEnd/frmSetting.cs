using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretCellar
{
    public partial class FrmSettings : ManagedForm
    {
        
        private ToolTip ProgramTips = new ToolTip();

        public FrmSettings()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(72, 72);
            //lstTypes.DataSource = DataAccess.instance.GetInventoryType();
            ////InventoryType invType = DataAccess.instance.GetInventoryType(lstTypes.Text);
            //cbx_tax.DataSource = DataAccess.instance.GetTax();
            //lstTypes.DisplayMember = "TypeName";
            //cbx_tax.DisplayMember = "TaxName";
            List<Discount> all_Discounts = DataAccess.instance.GetDiscount();
            //all_Discounts.ForEach(x => chk_lst_discount.Items.Add(x.DiscountName));


        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            // Set up the delays for the ToolTip.
            ProgramTips.AutoPopDelay = 10000;
            ProgramTips.InitialDelay = 1000;
            ProgramTips.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            ProgramTips.ShowAlways = true;
            // Set up the ToolTip text for the Button and Checkbox.
            ProgramTips.SetToolTip(this.btn_commit, "Click commit to make changes permanent otherwise will reset on program close");
            //ProgramTips.SetToolTip(this.checkBox1, "My checkBox1");
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog
            {
                Color = Color.Gray
            };

            if (colorPicker.ShowDialog() == DialogResult.OK)
                MainWindowColor = colorPicker.Color;
        }

        private void btn_commit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_header_Click(object sender, EventArgs e)
        {

        }

        private void btn_foot_Click(object sender, EventArgs e)
        {

        }

        private void btn_rec_font_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_tax_Click(object sender, EventArgs e)
        {

        }
    }
}