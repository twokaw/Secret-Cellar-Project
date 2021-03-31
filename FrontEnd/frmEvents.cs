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
        private Transaction transaction;


        public frmEvents(Transaction transactionFromFrmTransaction)
        {
            InitializeComponent();
            transaction = transactionFromFrmTransaction;
        }

        private void event_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void frmEvents_Load(object sender, EventArgs e) {

        }

		private void button_AddCharge_Click(object sender, EventArgs e) {
            if (double.TryParse(txtCharge.Text, out double price)) {
                Item item = Transaction.ConvertInvtoItem(DataAccess.instance.GetItem("EVENT"));
                item.Price = price;
                transaction.Items.Add(item);
            }

            this.Close();
		}

		private void button_CloseWindow_Click(object sender, EventArgs e) {
            this.Close();
		}
	}
}
