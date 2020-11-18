﻿using System;
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
    public partial class FrmSetting : Form
    {
        private readonly DataAccess dataAccess = new DataAccess();

        public FrmSetting()
        {
            InitializeComponent();
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            lstTypes.DataSource = dataAccess.GetInventoryType();
        }

        private void CaseDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (caseDiscount.Checked)
            {
                // Do something when CheckBox is checked  
            }
            else
            {
                // Do something here when CheckBox is not checked  
            }
        }
    }
}
