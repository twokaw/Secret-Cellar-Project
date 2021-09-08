using System;
using System.Linq;
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


        public frmAddPrinter(Printer printer)
        {
            InitializeComponent();

            newPrinter = printer;

            cbx_manufact.DataSource = DataAccess.instance.GetPrinterMake();
            cbx_manufact.SelectedItem = printer.Make;
            txt_print_model.Text = printer.Model;
            cbx_manufact.Enabled = false;
            txt_print_model.Enabled = false;
            populate();


        }


        private void btn_add_print_Click(object sender, EventArgs e)
        {
            if (txt_print_model.Text == "" || txt_drawer_code.Text == "" || txt_new_cut_code.Text == "") {
                MessageBox.Show("Model, Drawer Code, and Cut Code need to be filled out.", "Error");
			}
            else {
                newPrinter = new Printer
                {
                    Make = cbx_manufact.Text,
                    Model = txt_print_model.Text
                };
                newPrinter.Codes.Add(new PrinterCode { Cutter = txt_new_cut_code.Text, Drawer = txt_drawer_code.Text });
                newPrinter.ModelId=DataAccess.instance.UpdatePrinter(newPrinter);

                //this.DialogResult = DialogResult.OK;
                populate();
                clear_print_codes();
			}
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        

        private void btn_add_codes_Click(object sender, EventArgs e)
        {
            if (newPrinter != null && newPrinter.ModelId > 0)
            {
                newPrinter.Codes.Add(new PrinterCode { Cutter = txt_new_cut_code.Text, Drawer = txt_drawer_code.Text });
                DataAccess.instance.UpdatePrinter(newPrinter);
                clear_print_codes();

                populate();
            }
            else
            {
                MessageBox.Show("Must add new printer before adding codes");
            }

            //this.DialogResult = DialogResult.OK;
        }


        private void clear_print_codes()
        {
            txt_drawer_code.Text = "";
            txt_new_cut_code.Text = "";
        }


        private void btn_delete_codes_Click(object sender, EventArgs e)
        {
            if (grid_print_codes.SelectedRows.Count > 0) {
                PrinterCode pc = newPrinter.Codes.First(x => x.CodeId == (uint)grid_print_codes.SelectedRows[0].Cells["CodeId"].Value);
                newPrinter.Codes.Remove(pc);
                DataAccess.instance.UpdatePrinter(newPrinter);
                populate();
			}
        }


        private void populate() {
            newPrinter = DataAccess.instance.GetPrinter(newPrinter.ModelId);
            grid_print_codes.AutoGenerateColumns = false;
            grid_print_codes.DataSource = newPrinter.Codes;
        }
    }
}
