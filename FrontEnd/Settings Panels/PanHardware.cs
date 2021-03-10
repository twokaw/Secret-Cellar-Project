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
    public partial class PanHardware : UserControl
    {
        private List<Printer> printerNames;
        public PanHardware()
        {
            printerNames = DataAccess.instance.GetPrinter();
            InitializeComponent();
            cbx_com_port.DataSource = System.IO.Ports.SerialPort.GetPortNames();
            cbx_manufact.DataSource = DataAccess.instance.GetPrinterMake();
            
            lst_print_model.DataSource = printerNames;
            lst_print_model.DisplayMember = "Model";
            
            
        }

        private void btn_set_comm_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CashDrawerPort = cbx_com_port.SelectedItem.ToString();
            Properties.Settings.Default.Save();
        }

        private void btn_comm_default_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CashDrawerPort = "COM3";
            Properties.Settings.Default.Save();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_new_print_Click(object sender, EventArgs e)
        {
            frmAddPrinter addPrinter = new frmAddPrinter();

            addPrinter.ShowDialog();
        }

        private void lst_print_model_SelectedIndexChanged(object sender, EventArgs e)
        {
           string makeId  = cbx_manufact.Text;

            lst_print_model.DataSource = printerNames.Where(x => x.Make == makeId).ToList();

             
        }
    }
}
