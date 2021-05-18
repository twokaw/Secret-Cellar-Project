using System;
using SecretCellar;
using Shared;
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
    public partial class frmReceivedOrders : Form

    {
        private DataAccess dataAccess = new DataAccess(Properties.Settings.Default.URL);
        private List<Supplier> suppliers = null;
        private List<Inventory> inventory = null;
        public frmReceivedOrders()
        {
            InitializeComponent();
            inventory = dataAccess.GetInventory();
            suppliers = dataAccess.GetSuppliers();
            suppliers.Insert(0, new Supplier()
            {
                Name = "All",
                SupplierID = 0

            });

            txt_received_qty.Focus();
            received_dataGrid.Columns[5].DefaultCellStyle.Format = "C";
            cbx_supplier.DataSource = suppliers;
            cbx_supplier.DisplayMember = "Name";

            received_dataGrid.DataSource = inventory.Where(x => x.OrderQty > 0).
               Select(x => new {
                   Name = x.Name,
                   Id = x.Id,
                   ItemType = x.ItemType,
                   Qty = x.Qty,
                   Barcode = x.Barcode,
                   Price = x.SupplierPrice,
                   minqty = x.InvMin,
                   maxqty = x.InvMax,
                   orderqty = x.OrderQty
               }).
               OrderBy(x => x.Name).
               ToList();
        }

        private void cbx_supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            uint id = ((Supplier)cbx_supplier.SelectedItem).SupplierID;
            received_dataGrid.DataSource = inventory.Where(x => (id == x.SupplierID || id == 0) && x.OrderQty > 0).
               Select(x => new {
                   Name = x.Name,
                   Id = x.Id,
                   ItemType = x.ItemType,
                   Qty = x.Qty,
                   Barcode = x.Barcode,
                   Price = x.SupplierPrice,
                   minqty = x.InvMin,
                   maxqty = x.InvMax,
                   orderqty = x.OrderQty
               }).
               OrderBy(x => x.Name).
               ToList();
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
