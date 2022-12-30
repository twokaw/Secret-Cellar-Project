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

namespace SecretCellar.Settings_Panels
{
    public partial class PanDefaults : ManagedPanel
    { 
        bool loaded = false;
        public PanDefaults()
        {
            InitializeComponent();
        }

        private void cmb_State_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(loaded)
                DataAccess.instance.DefaultState = (string)cmb_State.SelectedValue;
        }

        private void PanDefaults_Load(object sender, EventArgs e)
        {
            if (DataAccess.instance != null)
            {
                cmb_State.ValueMember = "Initial";
                cmb_State.DisplayMember = "StateName";
                cmb_State.DataSource = DataAccess.StateList;
                cmb_State.SelectedValue = DataAccess.instance.DefaultState;
                loaded = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
