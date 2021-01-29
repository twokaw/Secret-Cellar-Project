﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared;

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
            listbox_logos.DataSource = DataAccess.instance.GetImageFiles();
            lstTypes.DataSource = DataAccess.instance.GetInventoryType();
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

        private void cbx_tax_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tax tax = DataAccess.instance.GetTax(taxID);
            
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

        private void tab_General_Click(object sender, EventArgs e)
        {

        }

        private void btn_font_settings_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowDialog();
            CommonFontSetter = fontDlg.Font;
            
        }

        private void btn_panel_color_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog
            {
                Color = DataGridViewBackColor
            };

            if (colorPicker.ShowDialog() == DialogResult.OK)
                DataGridViewBackColor = colorPicker.Color;
        }

        private void btn_row_color_Click(object sender, EventArgs e)
        {
            DataGridViewCellStyle cs = DefaultCellStyle;

            ColorDialog gridcolor = new ColorDialog
            {
                Color = cs.BackColor
            };

            if (gridcolor.ShowDialog() == DialogResult.OK)

            {

                cs.BackColor = gridcolor.Color;
                cs.SelectionBackColor = Color.FromArgb(cs.BackColor.A, Math.Max(cs.BackColor.R - 25,0), Math.Max(cs.BackColor.G - 25,0), Math.Max(cs.BackColor.B - 25,0));
                SetDefaultCellStyle(cs);

            }
        }

        private void btn_commit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BackgroundColor = ManagedForm.MainWindowColor;
            Properties.Settings.Default.GridColor = ManagedForm.DataGridViewBackColor;
            Properties.Settings.Default.FontSet = ManagedForm.CommonFontSetter;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BackgroundColor = Properties.Settings.Default.DefaultBackgroundColor;
            Properties.Settings.Default.GridColor = Properties.Settings.Default.DefaultGridColor;
            Properties.Settings.Default.FontSet = Properties.Settings.Default.DefaultFont;
            reset_Default_Properties();
            Properties.Settings.Default.Save();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_change_image_Click(object sender, EventArgs e)
        {
           

           
            // open file dialog   
            OpenFileDialog image = new OpenFileDialog();
            // image filters  
            image.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp,;*.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png;";
            image.FilterIndex = 2;
            image.RestoreDirectory = true;
            //Open Image Dialog okay;
            if(image.ShowDialog() == DialogResult.OK)
            {

                pic_logo.Image = DataAccess.instance.ImportLogo(image.FileName);

            }
            
        }

        private void pic_logo_Click(object sender, EventArgs e)
        {

        }

        private void listbox_logos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listbox_logos.DataSource =  DataAccess.instance.GetImageFiles();
            pic_logo.Image = DataAccess.instance.GetImage(listbox_logos.Text);
        }

        private void btn_change_logo_Click(object sender, EventArgs e)
        {
            DataAccess.instance.ChangeLogo(listbox_logos.Text);
            
            
        }

        private void lstTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            InventoryType invType = DataAccess.instance.GetInventoryType(lstTypes.Text);
        }
    }

 
}