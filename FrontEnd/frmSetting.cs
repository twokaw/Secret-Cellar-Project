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

        private void btn_header_Click(object sender, EventArgs e)
        {
             Properties.Settings.Default.Header =txt_receipt_header.Text;
        }

        private void btn_foot_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Footer = txt_receipt_footer.Text;
        }

        private void btn_rec_font_Click(object sender, EventArgs e)
           
        {

            Font currentFont = new Font(Properties.Settings.Default.ReceiptFont,Properties.Settings.Default.ReceiptFontSize);
            FontDialog fontDlg = new FontDialog();
            fontDlg.MaxSize = 14;
            fontDlg.MinSize = 8;
            fontDlg.Font = currentFont;

            fontDlg.ShowDialog();
            Properties.Settings.Default.ReceiptFont = fontDlg.Font.Name;
            Properties.Settings.Default.ReceiptFontSize = fontDlg.Font.Size;
            Properties.Settings.Default.Save();

        }

        private void btn_receipt_font_reset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ReceiptFont = "Arial";
            Properties.Settings.Default.ReceiptFontSize = 9;
            Properties.Settings.Default.Save();
        }

        private void lst_tax_list_SelectedIndexChanged(object sender, EventArgs e)
        {

            txt_tax_type_name.Text = ((Tax)lst_tax_list.SelectedItem).TaxName;
            txt_bottle_dep.Text = ((Tax)lst_tax_list.SelectedItem).BottleDeposit.ToString();
            txt_sales_tax.Text = ((Tax)lst_tax_list.SelectedItem).SalesTax.ToString();
            txt_local_tax.Text = ((Tax)lst_tax_list.SelectedItem).LocalSalesTax.ToString();

         
        }

        private void btn_update_tax_Click(object sender, EventArgs e)
        {
            Tax i = new Tax();
            i.TaxName = txt_tax_type_name.Text.Trim();
            i.BottleDeposit = Convert.ToDouble(txt_bottle_dep.Text);
            i.SalesTax = Convert.ToDouble(txt_sales_tax.Text);
            i.IdTax = ((Tax)cbx_tax.SelectedItem).IdTax;

            DataAccess.instance.UpdateTax(i);
        }

        private void btn_clear_tax_info_Click(object sender, EventArgs e)
        {
            txt_tax_type_name.Text = "";
            txt_bottle_dep.Text = "";
            txt_sales_tax.Text = "";
            txt_local_tax.Text = "";
        }

        private void btn_new_tax_Click(object sender, EventArgs e)
        {
            if (((List<Tax>)lst_tax_list.DataSource).FirstOrDefault(x => x.TaxName == lst_tax_list.Text) != null)
            {
                Tax i = new Tax();
                i.TaxName = txt_tax_type_name.Text.Trim();
                i.BottleDeposit = Convert.ToDouble(txt_bottle_dep.Text);
                i.SalesTax = Convert.ToDouble(txt_sales_tax.Text);
                i.IdTax = ((Tax)cbx_tax.SelectedItem).IdTax;
                
                DataAccess.instance.UpdateTax(i);
            }
        }
    }
}