using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared;

namespace SecretCellar.Settings_Panels
{
    public partial class frmAddPrinter : Form
    {
        public Printer newPrinter = null;
        public frmAddPrinter()
        {
            InitializeComponent();
            
            cbx_manufact.DataSource = DataAccess.instance.GetPrinterMake();
            
        }

        private void btn_add_print_Click(object sender, EventArgs e)
        {
            newPrinter = new Printer
            {
                Make = cbx_manufact.Text,
                Model = txt_print_model.Text
            };
            newPrinter.Codes.Add(new PrinterCode { Cutter = txt_new_cut_code.Text, Drawer = txt_drawer_code.Text });
            DataAccess.instance.UpdatePrinter(newPrinter);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
