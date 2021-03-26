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
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new SizeF(72, 72);
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {

        }

        private void btn_commit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}