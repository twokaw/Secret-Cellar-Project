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
    public partial class FrmSettings : ManagedForm
    {
        public FrmSettings() {
            InitializeComponent();

            ApplyUserAccess();
        }

        private void btn_commit_Click(object sender, EventArgs e) { Close(); }

        private void ApplyUserAccess() {
            bool canAccessSettings = DataAccess.instance.EmployeeAccess("Settings");
            panReports1.Visible = canAccessSettings;
            panHardware.Visible = canAccessSettings;
            panTypes.Visible = canAccessSettings;
            panDiscount1.Visible = canAccessSettings;
            panAppearance1.Visible = canAccessSettings;
            panReceipt1.Visible = canAccessSettings;
            panTax1.Visible = canAccessSettings;
            panDefaults1.Visible = canAccessSettings;
            panEmployeeTypes1.Visible = canAccessSettings;
            panEmployee1.HandleToggleButtons(canAccessSettings);
        }
    }
}