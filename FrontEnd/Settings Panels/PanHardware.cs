using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretCellar.Settings_Panels
{
    public partial class PanHardware : UserControl
    {
        public PanHardware()
        {
            InitializeComponent();
            cbx_com_port.DataSource = System.IO.Ports.SerialPort.GetPortNames();
            //cbx_manufact.DataSource = 
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
    }
}
