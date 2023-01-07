using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SecretCellar
{
    public partial class ManagedPanel : UserControl {
        public ManagedPanel() { base.Load += ManagedPanel_Load; }


        private void ManagedPanel_Load(object sender, EventArgs e)
        {
            base.BackColor = ManagedForm.PanelColor;
            base.ForeColor = ManagedForm.PanelFontColor;
            base.Font = ManagedForm.FontStyle;

            foreach (Control c in base.Controls)
            {
                UpdateColors(c);
            }
        }


        /// <summary>
        /// Recursively loops through all the sub panels to update the buttons, datagrids, and panel colors.
        /// </summary>
        /// <param name="c"></param>
        private void UpdateColors(Control c) {
            c.Font = ManagedForm.FontStyle;

            if (c.GetType() == typeof(Button)) {
                c.BackColor = ManagedForm.ButtonColor;
                c.ForeColor = ManagedForm.ButtonFontColor;
            }
            else if (c.GetType() == typeof(DataGridView)) {
                ((DataGridView)c).DefaultCellStyle = ManagedForm.CellStyle;
                ((DataGridView)c).RowsDefaultCellStyle = ManagedForm.CellStyle;
                ((DataGridView)c).AlternatingRowsDefaultCellStyle = ManagedForm.CellAlternateRowStyle;
                ((DataGridView)c).BackgroundColor = ManagedForm.DataGridViewColor;
                ((DataGridView)c).RowsDefaultCellStyle.BackColor = ManagedForm.DataGridViewRowColor;
                ((DataGridView)c).RowsDefaultCellStyle.ForeColor = ManagedForm.DataGridViewRowFontColor;
                ((DataGridView)c).RowsDefaultCellStyle.SelectionBackColor = ManagedForm.LIGHT_BLUE;
                ((DataGridView)c).RowsDefaultCellStyle.SelectionForeColor = ManagedForm.WHITE;
                ((DataGridView)c).AlternatingRowsDefaultCellStyle.BackColor = ManagedForm.DataGridViewAlternateRowColor;
                ((DataGridView)c).AlternatingRowsDefaultCellStyle.ForeColor = ManagedForm.DataGridViewAlternateRowFontColor;
                ((DataGridView)c).AlternatingRowsDefaultCellStyle.SelectionBackColor = ManagedForm.LIGHT_BLUE;
                ((DataGridView)c).AlternatingRowsDefaultCellStyle.SelectionForeColor = ManagedForm.WHITE;
            }
            else if (c.GetType() == typeof(Panel)) {
                ((Panel)c).BackColor = ManagedForm.PanelColor;
                ((Panel)c).ForeColor = ManagedForm.PanelFontColor;

                foreach (Control cc in c.Controls) {
                    UpdateColors(cc);
                }
            }
            else if (c.GetType() == typeof(FlowLayoutPanel)) {
                ((FlowLayoutPanel)c).BackColor = ManagedForm.BackgroundColor;

                foreach (Control cc in c.Controls) {
                    UpdateColors(cc);
                }
            }
            else if (c.GetType() == typeof(GroupBox)) {
                ((GroupBox)c).BackColor = ManagedForm.BackgroundColor;
                ((GroupBox)c).ForeColor = ManagedForm.FontColor;

                foreach (Control cc in c.Controls) {
                    UpdateColors(cc);
                }
            }
        }
    }
}
