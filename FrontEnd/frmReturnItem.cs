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
                return uint.Parse(TxtQty.Text);
            }
            set
            {
                if (TxtQty.Text != $"{value}")
                {
                    TxtQty.Text = $"{value}";
                    UpdateTotalPrice();
                }
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
                if(TxtFee.Text != $"{value:C}")
                {
                    TxtFee.Text = $"{value:C}";
                    UpdateTotalPrice();
                }
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
            LblQty.Text = item.Qty.ToString();
            RefundQty = 1;
            TxtQty.Enabled = item.Qty > 1;
        }

        private void TxtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void TxtQty_TextChanged(object sender, EventArgs e)
        {
            RefundQty = uint.Parse(TxtQty.Text);
        }

        private void TxtFee_TextChanged(object sender, EventArgs e)
        {
            RestockFee = uint.Parse(TxtFee.Text);
        }
    }
}
