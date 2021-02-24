using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretCellar {
	public partial class frmSuspendedTransactionsSelectReturnPaymentMethod : Form {
		public frmSuspendedTransactionsSelectReturnPaymentMethod(double paymentsTotal) {
			InitializeComponent();

			label_Result.Text = "Payment Total: " + paymentsTotal;


		}
	}
}
