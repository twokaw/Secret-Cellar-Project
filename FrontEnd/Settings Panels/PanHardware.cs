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
            Printer currentPrinter = DataAccess.instance.GetPrinter((uint)Properties.Settings.Default.PrinterModelId);
           // printerNames = DataAccess.instance.GetPrinter();
            InitializeComponent();
            cbx_com_port.DataSource = System.IO.Ports.SerialPort.GetPortNames();
            lst_print_model.DisplayMember = "Model";
            Refresh(currentPrinter?.Make, currentPrinter?.Model);
            // cbx_manufact.DataSource = DataAccess.instance.GetPrinterMake();
            //cbx_manufact.SelectedItem = currentPrinter?.Make ?? cbx_manufact.Items[0];
            //lst_print_model.DataSource = printerNames.Where(x => x.Make == cbx_manufact.SelectedItem.ToString()).ToList();
            //lst_print_model.DataSource = printerNames;

            //if (lst_print_model.Items.Count > 0)
            //{
            //    int index = lst_print_model.FindString(currentPrinter?.Model);
            //    lst_print_model.SetSelected((index >= 0) ? index : 0, true);
            //}
            //lst_print_model.SelectedItem = currentPrinter;
           // populate();
            
            
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

            if(addPrinter.ShowDialog() == DialogResult.OK)
                Refresh(addPrinter?.newPrinter?.Make, addPrinter?.newPrinter?.Model);
        }

        private void lst_print_model_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate();
        }

        private void populate()
        {
            grid_print_codes.AutoGenerateColumns = false;
            grid_print_codes.DataSource = ((Printer)lst_print_model?.SelectedItem)?.Codes;
        }

        private void cbx_manufact_SelectedIndexChanged(object sender, EventArgs e)
        {
            string makeId = cbx_manufact.Text;

            lst_print_model.DataSource = printerNames.Where(x => x.Make == makeId).ToList();
        }

        private void btn_set_printer_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PrinterModelId =(int)((Printer)lst_print_model.SelectedItem).ModelId;
            Properties.Settings.Default.PrintCodeId = int.Parse(grid_print_codes.SelectedRows[0].Cells["CodeId"].Value.ToString());
            Properties.Settings.Default.Save();
        }

        private void Refresh(string make, string model)
        {
            printerNames = DataAccess.instance.GetPrinter();
            cbx_manufact.DataSource = DataAccess.instance.GetPrinterMake();
            cbx_manufact.SelectedItem = make ?? cbx_manufact.Items[0];
            lst_print_model.DataSource = printerNames.Where(x => x.Make == cbx_manufact.SelectedItem.ToString()).ToList();
            
            if (lst_print_model.Items.Count > 0)
            {
                int index = lst_print_model.FindString(model);
                lst_print_model.SetSelected((index >= 0) ? index : 0, true);
            }
            populate();
        }
    }
}
