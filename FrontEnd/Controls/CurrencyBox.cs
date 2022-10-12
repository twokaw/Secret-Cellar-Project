using System;
using System.Drawing;
using System.Windows.Forms;

namespace SecretCellar
{
    public class CurrencyBox: TextBox
    {
        private int CursorPosition = 0;
        public CurrencyBox() : base(){
            this.TextAlign = HorizontalAlignment.Left;
            this.Text = "0.00";
            this.CursorPosition = this.TextLength;
        }


        public double Value
        {
            get
            {
                return ToNumber();
            }
            set 
            {
                this.Text = FormatText(value);
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Right)
            {
                CursorPosition = Math.Min(this.TextLength,  ++CursorPosition);
                Console.WriteLine($"CursorPosition on Right : {CursorPosition}");
            }

            if (e.KeyCode == Keys.Left)
            {
                CursorPosition = Math.Max(0, --CursorPosition);
                Console.WriteLine($"CursorPosition on Left : {CursorPosition}");
            }
                

            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                DeleteChar();
                e.Handled = true;
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            this.SelectAll();
            CursorPosition = this.TextLength;
            Console.WriteLine($"CursorPosition on click : {CursorPosition}");
        }

        protected override void OnTextChanged(EventArgs e)
        {
            string newText = base.Text;
            if (!newText.Contains("."))
                newText += ".00";
            else if ("." == newText.Substring(newText.Length - 2, 1))
                newText += "0";

            newText = FormatText(newText);
            base.OnTextChanged(e);

            if (base.Text != newText)
            {
                this.Text = FormatText(newText);
            }

            
            //CursorPosition = TextLength;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            // between 0 and 9
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                InsertChar(e.KeyChar);

            e.Handled = true;
        }

        private void InsertChar(char character)
        {
            if (this.TextLength == this.SelectionLength)
                this.Clear();

            string value = this.Text;
            if (this.TextLength < this.MaxLength)
            {
                value = value.Insert(CursorPosition, $"{character}");
                CursorPosition++;

                this.Text = FormatText(ToNumber(value) * 10);

                Console.WriteLine($"CursorPosition INSERT : {CursorPosition}");
                this.SelectionStart = CursorPosition;
                this.SelectionLength = 0;
            }
        }

        private void DeleteChar()
        {
            if (this.TextLength == this.SelectionLength)
                this.Clear();
            else
            {
                Console.WriteLine($"CursorPosition: {CursorPosition}");

                string value = this.Text;

                if (CursorPosition > 0 && value.Substring(CursorPosition - 1, 1) == ".")
                    CursorPosition++;

                Console.WriteLine($"CursorPosition period check : {CursorPosition}");

                if (CursorPosition > 0 && this.TextLength > 4) CursorPosition--;
                Console.WriteLine($"CursorPosition negative check : {CursorPosition}");
                value = value.Remove(Math.Min(CursorPosition, value.Length -1), 1);
                this.Text = FormatText(value);

                Console.WriteLine($"CursorPosition selection set : {CursorPosition}");
                this.SelectionStart = CursorPosition ;
                this.SelectionLength = 0;
            }
        }

        private string FormatText(double value)
        {
            this.ForeColor = (value < 0) ? Color.DarkRed : Color.Black;
            return $"{value:C}";
        }
        private static readonly char[] NEGATIVE = "+()".ToCharArray();
        private string FormatText(string value)
        {
            value = value.Replace("$", "");
            double val = 1;
            if (value.IndexOfAny(NEGATIVE) != -1)
                val = -1;

            if (double.TryParse(value.Replace("(", "").Replace(")", "").Replace("-", ""), out double baseValue))
            {
                value = $"{val * baseValue:C}";
                CursorPosition = Math.Min(value.Length, CursorPosition);
            }
            else if (val < 0)
            {
                CursorPosition = 2;
                value= "$()";
            }
            else 
            {
                CursorPosition = 1;
                value = "$";
            }

            this.ForeColor = (val < 0) ? Color.DarkRed : Color.Black;
            return value;
        }
        private double ToNumber()
        {
           return ToNumber(this.Text);
        }
        private double ToNumber(string val)
        {
            double res = 0.0;
            val = val.Replace("$", "");
            if (val.Contains("("))
            {
                if(double.TryParse(val.Replace("(", "").Replace(")", ""), out  res))
                    res *= -1;
            }
            else
                _ = double.TryParse(val, out res);

            return res;
        }
    }

}
