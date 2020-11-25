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
	public partial class frmSuspendTransaction : Form
	{
		public frmSuspendTransaction()
		{
			InitializeComponent();

			for (int i = 0; i < frmTransaction.chosenItems.Count; i++) {
				DataGridViewRow row = frmTransaction.chosenItems[i];
				int index = this.dataGridView.Rows.Add();

				for (int k=0; k<row.Cells.Count; k++) {
					DataGridViewCell cell = row.Cells[k];

					if (cell.Value != null) {
						this.dataGridView.Rows[index].Cells[k].Value = cell.Value.ToString();
					}
					else {
						this.dataGridView.Rows[index].Cells[k].Value = "";
					}
					
				}
			}
		}

		private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
