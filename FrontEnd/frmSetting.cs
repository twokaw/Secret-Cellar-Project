﻿using Shared;
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

        private void FrmSetting_Load(object sender, EventArgs e)
        {

        }

        private void btn_commit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panReports1_Load(object sender, EventArgs e)
        {

        }
    }
}