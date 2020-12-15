using SecretCellar;
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
    public partial class frmEvents : ManagedForm
    {
        private Transaction events = null;
        public frmEvents(Transaction transaction)
        {
            InitializeComponent();
            events = transaction;
        }

        private void btnAddCharge_Click(object sender, EventArgs e)
        {
            addCharge();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void addCharge()
        {
            if (double.TryParse(txtCharge.Text, out double d))
            {
                Item i = DataAccess.ConvertInvtoItem(DataAccess.instance.GetItem("EVENT"));
                i.Price = d;
                events.Items.Add(i);
            }


        }

        private void event_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmEvents_Load(object sender, EventArgs e)
        {

        }
    }
}
