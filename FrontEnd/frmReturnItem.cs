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
    public partial class frmReturnItem : Form
    {
        public double RefundPrice
        {
            get
            {
                return double.Parse(LblRefund.Text.Replace("$", ""));
            }
            set
            {
                LblRefund.Text = $"{value:C}";
            }
        }
        public double TotalRefundPrice
        {
            get
            {
                return double.Parse(LblTotalRefund.Text.Replace("$", ""));
            }
            set
            {
                LblTotalRefund.Text = $"{value:C}";
            }
        }

        public uint RefundQty
        {
            get
            {
                return uint.Parse($"0{TxtQty.Text}");
            }
            set
            {
                value = Math.Min(value, uint.Parse(LblQty.Text));
                TxtQty.Text = (value > 0)?$"{value}": "";
                UpdateTotalPrice();
            }
        }
        public bool Restock
        {
            get
            {
                return ChkRestock.Checked;
            }
            set
            {
                ChkRestock.Checked = value;
            }
        }

        public double RestockFee
        {
            get
            {
                return double.Parse(TxtFee.Text.Replace("$", ""));
            }
            set
            {
                TxtFee.Text = $"{value:C}";
                UpdateTotalPrice();
            }
        }
        private void UpdateTotalPrice()
        {
            TotalRefundPrice = Math.Max(RefundQty * RefundPrice - RestockFee, 0);
        }

        public frmReturnItem(Item item, double refundPrice)
        {
            InitializeComponent();

            RefundPrice = refundPrice;
            LblItem.Text = item.Name;
            LblPrice.Text = $"{item.Price:C}";
            LblTotalRefund.Text = $"{RefundPrice:C}";
            LblQty.Text = $"{item.NumSold}";
            RefundQty = 1;
            TxtQty.Enabled = item.Qty > 1;
        }

        private void TxtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void TxtQty_TextChanged(object sender, EventArgs e)
        {
            if (TxtQty.Text == "")
                RefundQty = 0;
            else
                RefundQty = uint.Parse(TxtQty.Text);
        }

        private void TxtFee_TextChanged(object sender, EventArgs e)
        {

            RestockFee = double.Parse(TxtFee.Text.Replace("$", ""));
        }

        private void TxtFee_Enter(object sender, EventArgs e)
        {
            TxtFee.SelectAll();
        }

        private void TxtQty_Enter(object sender, EventArgs e)
        {
            TxtQty.SelectAll();
        }
    }
}
