using System;
using System.Windows.Forms;

namespace SecretCellar
{
    public class CurrencyBox: TextBox
    {
        public CurrencyBox() : base(){
            this.TextAlign = HorizontalAlignment.Right;

            this.Text = "0.00";
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
                DeleteChar();

            e.Handled = true;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            this.SelectionStart = 0;
            this.SelectAll();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            
            this.Text = "0.00";
            //this.SelectionStart = 0;

        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            // between 0 and 9
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                insertChar(e.KeyChar);
            e.Handled = true;
        }

        private void insertChar(char character)
        {
            int start = this.SelectionStart;
            if (this.TextLength == this.SelectionLength)
                this.Clear();

            string value = this.Text;

            value = value.Insert(start, $"{character}");

            this.Text = FormatText(value);

            this.SelectionStart = start + 1;
            this.SelectionLength = 0;
        }

        private void DeleteChar()
        {
            if (this.TextLength == this.SelectionLength)
                this.Clear();
            else
            {
                int start = this.SelectionStart;
                string value = this.Text;

                if (start > 0 && value.Substring(start - 1, 1) == ".")
                    start++;

                value = value.Remove(start - 1, 1);
                this.Text = FormatText(value);

                this.SelectionStart = start + 1;
                this.SelectionLength = 0;
            }
        }
        
        private string FormatText(string value)
        {
            value = value.Replace(".", "").TrimStart('0');
            value = value.PadLeft(3, '0');
            value = value.Insert(value.Length - 2, ".");
            return value;
        }
    }
}
