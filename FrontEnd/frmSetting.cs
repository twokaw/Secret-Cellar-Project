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
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void btn_commit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSettings_Activated(object sender, EventArgs e)
        {
            ApplyUserAccess();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {

        }
        private void ApplyUserAccess()
        {
            panEmployee1.Visible = DataAccess.instance.EmployeeAccess("Employee Admin");
            lb_Employee_Disabled.Visible = !DataAccess.instance.EmployeeAccess("Employee Admin");
        }
    }
}