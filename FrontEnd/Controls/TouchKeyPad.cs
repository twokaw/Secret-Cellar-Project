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
    public partial class TouchKeyPad : UserControl
    {
        public TextBox Target {get; set;}
        public TouchKeyPad()
        {
            InitializeComponent();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            insertText("0");
        }

        private void btn_00_Click(object sender, EventArgs e)
        {
            insertText("00");
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            insertText("1");
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            insertText("2");
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            insertText("3");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            insertText("4");
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            insertText("5");
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            insertText("6");
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            insertText("7");
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            insertText("8");
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            insertText("9");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Target.Focus();
            Target.Text = Target.Text.ToString().Remove(Target.Text.ToString().Length - 1, 1);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Target.Focus();
            Target.Clear();
        }

        private void insertText(string text)
        {
            Target.Focus();
            //if (Target.TextLength == Target.SelectionLength) Target.Clear();
            Target.AppendText(text);
        }
    }
}
