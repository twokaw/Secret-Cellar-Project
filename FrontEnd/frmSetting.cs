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


/*
            listbox_logos.DataSource = DataAccess.instance.GetImageFiles();
            lstTypes.DataSource = DataAccess.instance.GetInventoryType();
            lst_tax_list.DataSource = DataAccess.instance.GetTax();
            //InventoryType invType = DataAccess.instance.GetInventoryType(lstTypes.Text);
            cbx_tax.DataSource = DataAccess.instance.GetTax();
            lst_tax_list.DisplayMember = "TaxName";
            lstTypes.DisplayMember = "TypeName";
            cbx_tax.DisplayMember = "TaxName";
            List<Discount> all_Discounts = DataAccess.instance.GetDiscount();
            all_Discounts.ForEach(x => chk_lst_discount.Items.Add(x.DiscountName));

            //lstTypes.DataSource = DataAccess.instance.GetInventoryType();
            ////InventoryType invType = DataAccess.instance.GetInventoryType(lstTypes.Text);
            //cbx_tax.DataSource = DataAccess.instance.GetTax();
            //lstTypes.DisplayMember = "TypeName";
            //cbx_tax.DisplayMember = "TaxName";
            List<Discount> all_Discounts = DataAccess.instance.GetDiscount();
            //all_Discounts.ForEach(x => chk_lst_discount.Items.Add(x.DiscountName));
*/

        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {

        }
        /*
        private void btn_color_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog
            {
                Color = Color.Gray
            };

            if (colorPicker.ShowDialog() == DialogResult.OK)
                MainWindowColor = colorPicker.Color;
        }
        */

        private void btn_commit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}