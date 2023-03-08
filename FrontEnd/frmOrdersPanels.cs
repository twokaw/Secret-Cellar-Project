using System;

namespace SecretCellar {
	public partial class frmOrdersPanels : ManagedForm
    {
		public frmOrdersPanels() {
			InitializeComponent();
		}

		public void refreshInv()
        {
            panel_Fulfillment1.RefreshDatagrid();
            panel_CustomerOrder1.RefreshFavorite();
            panel_SupplierOrder1.RefreshSupplier();
        }

		private void btn_close_Click(object sender, EventArgs e) {
			this.Close();
		}


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            if (tabControl1.SelectedIndex == 3) { //3 is the Fulfillment tab
                panel_Fulfillment1.RefreshCustomerOrderList();
                panel_Fulfillment1.RefreshDatagrid();
            }
        }
    }
}
