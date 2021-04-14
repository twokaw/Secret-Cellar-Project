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
    public partial class QuantityChange : Form
    {
        public int UpdatedQty { get; set; }
        public QuantityChange(int qty)
        {
            InitializeComponent();
            txt_qty.Text = qty.ToString();
            txt_qty.Focus();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            txt_qty.Text = txt_qty.Text.ToString().Remove(txt_qty.Text.ToString().Length - 1, 1);
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_qty.Focus();
            if (txt_qty.TextLength == txt_qty.SelectionLength) txt_qty.Clear();

            txt_qty.AppendText("1");
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_qty.Focus();
            if (txt_qty.TextLength == txt_qty.SelectionLength) txt_qty.Clear();
            txt_qty.AppendText("2");
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_qty.Focus();
            if (txt_qty.TextLength == txt_qty.SelectionLength) txt_qty.Clear();
            txt_qty.AppendText("3");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_qty.Focus();
            if (txt_qty.TextLength == txt_qty.SelectionLength) txt_qty.Clear();
            txt_qty.AppendText("4");
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_qty.Focus();
            if (txt_qty.TextLength == txt_qty.SelectionLength) txt_qty.Clear();
            txt_qty.AppendText("5");
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_qty.Focus();
            if (txt_qty.TextLength == txt_qty.SelectionLength) txt_qty.Clear();
            txt_qty.AppendText("6");
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_qty.Focus();
            if (txt_qty.TextLength == txt_qty.SelectionLength) txt_qty.Clear();
            txt_qty.AppendText("7");
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_qty.Focus();
            if (txt_qty.TextLength == txt_qty.SelectionLength) txt_qty.Clear();
            txt_qty.AppendText("8");
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_qty.Focus();
            if (txt_qty.TextLength == txt_qty.SelectionLength) txt_qty.Clear();
            txt_qty.AppendText("9");
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_qty.Focus();
            if (txt_qty.TextLength == txt_qty.SelectionLength) txt_qty.Clear();
            txt_qty.AppendText("0");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_qty.Text = "";
            txt_qty.Focus();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            UpdatedQty = int.Parse(txt_qty.Text);
        }
    }
}
