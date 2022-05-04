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
    public partial class PanEmployee : UserControl
    {
        public PanEmployee()
        {
            InitializeComponent();
        }

        private void employee_panel_MouseMove(object sender, MouseEventArgs e)
        {
            Console.WriteLine($"{e.X}, {e.Y}");
        }
    }
}
