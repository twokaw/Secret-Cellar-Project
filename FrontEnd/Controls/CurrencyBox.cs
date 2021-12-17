using System;
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
            if (!base.Text.Contains("."))
                base.Text += ".00";
            else if ("." == base.Text.Substring(base.Text.Length - 2, 1))
                base.Text += "0";

            base.OnTextChanged(e);

            this.Text = FormatText(this.Text);

            
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

                this.Text = FormatText(value);

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
        
        private string FormatText(string value)
        {
            value = value.Replace(".", "").TrimStart('0');
            value = value.PadLeft(3, '0');
            value = value.Insert(value.Length - 2, ".");
            Console.WriteLine($"CursorPosition preFormat : {CursorPosition}");
            CursorPosition = Math.Min(value.Length, CursorPosition);
            Console.WriteLine($"CursorPosition Format : {CursorPosition}");
            return value;
        }
    }
}
