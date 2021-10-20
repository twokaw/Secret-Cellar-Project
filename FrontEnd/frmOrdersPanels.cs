using System;

namespace SecretCellar {
	public partial class frmOrdersPanels : ManagedForm
    {
		public frmOrdersPanels() {
			InitializeComponent();
		}

		public void refreshInv()
        {

        }
		private void btn_close_Click(object sender, EventArgs e) {
			this.Close();
		}
    }
}
