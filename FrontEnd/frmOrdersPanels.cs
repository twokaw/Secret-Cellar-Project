using System;

namespace SecretCellar {
	public partial class frmOrdersPanels : ManagedForm
    {
		public frmOrdersPanels() {
			InitializeComponent();
		}

		public void refreshInv()
        {
            panel_Fulfillment1.RefreshFillment();
            panel_CustomerOrder1.RefreshFavorite();
            panel_SupplierOrder1.RefreshSupplier();
        }
		private void btn_close_Click(object sender, EventArgs e) {
			this.Close();
		}

        private void tab_CustomerRequest_Click(object sender, EventArgs e)
        {

        }

        private void tab_SupplierOrder_Click(object sender, EventArgs e)
        {

        }

        private void panel_SupplierOrder1_Load(object sender, EventArgs e)
        {

        }

        private void tab_CustomerOrder_Click(object sender, EventArgs e)
        {

        }

        private void panel_CustomerOrder1_Load(object sender, EventArgs e)
        {

        }

        private void tab_Fulfillment_Click(object sender, EventArgs e)
        {

        }

        private void panel_Fulfillment1_Load(object sender, EventArgs e)
        {

        }

        private void tab_History_Click(object sender, EventArgs e)
        {

        }

        private void panel_History1_Load(object sender, EventArgs e)
        {

        }

        private void frmOrdersPanels_Load(object sender, EventArgs e)
        {

        }
    }
}
