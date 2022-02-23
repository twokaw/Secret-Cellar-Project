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

        private void frmOrdersPanels_Load(object sender, EventArgs e)
        {

        }
    }
}
