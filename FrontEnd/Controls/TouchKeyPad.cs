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
        //private int CursorPosition = 0;
        public TouchKeyPad()
        {
            InitializeComponent();
        }

        private void btn_00_Click(object sender, EventArgs e)
        {
            insertText(0);
            insertText(0);
        }

        private void btn_0_Click(object sender, EventArgs e) { insertText(0); }
        private void btn_1_Click(object sender, EventArgs e) { insertText(1); }
        private void btn_2_Click(object sender, EventArgs e) { insertText(2); }
        private void btn_3_Click(object sender, EventArgs e) { insertText(3); }
        private void btn_4_Click(object sender, EventArgs e) { insertText(4); }
        private void btn_5_Click(object sender, EventArgs e) { insertText(5); }
        private void btn_6_Click(object sender, EventArgs e) { insertText(6); }
        private void btn_7_Click(object sender, EventArgs e) { insertText(7); }
        private void btn_8_Click(object sender, EventArgs e) { insertText(8); }
        private void btn_9_Click(object sender, EventArgs e) { insertText(9); }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int decimalIndex = Target.Text.IndexOf('.');
            string targetText = Target.Text;

            if (Target.Text.Contains('.'))
            {
                targetText = targetText.Substring(0, targetText.Length - 1);
                targetText = targetText.Replace(".", "");
                targetText = targetText.Insert(decimalIndex - 1, ".");
                Target.Text = targetText;
            }
            else if(targetText.Length > 0)
            { 
                Target.Text = targetText.Remove(targetText.Length -1);
            }
            return;

            /*
            int decimalIndex = Target.Text.IndexOf('.');
            string targetText = Target.Text;
            targetText = targetText.Substring(0, targetText.Length - 1);
            Target.Clear();
            targetText = targetText.Replace(".", "");
            targetText = targetText.Insert(decimalIndex - 1, ".");
            Target.Text = targetText;
            return;
            */

            /*
            string text = Target.Text.ToString();
            Target.Text = text.Remove(text.Length -1);
            return;
            int decimalIndex = Target.Text.IndexOf('.');
            string newAmount = "";
            string targetText = Target.Text;
            targetText = targetText.Replace(".", "");
            targetText = targetText.Substring(0, targetText.Length - 1);

            for(int i = 0; i< targetText.Length; i++)
            {
                if (i +1 == decimalIndex)
                {
                    newAmount += ".";
                }
                newAmount += Target.Text[i];
            }

            */
            //Target.Text = newAmount;
            //string oldtext = Target.Text.ToString();
            //string text;
            //Target.Focus();
            //this.CursorPosition = Target.Text.Length;
            //Target.Text = "0" + Target.Text.ToString().Substring(0, Target.Text.ToString().Length - 1);//.Remove(Target.Text.ToString().Length - 1, 1);
            //this.CursorPosition = this.CursorPosition - 1;*/
            //text = Target.Text.ToString().Remove(Target.Text.ToString().Length - 1, 1);
            //Target.Text = Target.Text.ToString().TrimEnd();
            //Target.Text.Replace(oldtext,"0"+text);

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Target.Focus();
            Target.Clear();
        }

        //private void insertText(string text)
        //{
        //    Target.Focus();

        //    if (Target.GetType() == typeof(CurrencyBox))
        //    {
        //        if()
        //    }
        //        if()
        //        ((CurrencyBox)Target).Value += ((CurrencyBox)Target).Value * 10 + int.Parse(text);
        //    else
        //    //if (Target.TextLength == Target.SelectionLength) Target.Clear();
        //    if (Target.TextLength + text.Length <= Target.MaxLength)
        //        Target.AppendText(text);
        //}
        private void insertText(int value)
        {
            Target.Focus();

            if (value == -1)
                if (Target.GetType() == typeof(CurrencyBox))
                    ((CurrencyBox)Target).Value *= -1;
                else
                {
                    if (Target.Text.Contains("-"))
                        Target.Text = Target.Text.Replace("-", "");
                    else
                        Target.Text = $"-{Target.Text}";
                }
            else if (Target.GetType() == typeof(CurrencyBox))
                ((CurrencyBox)Target).Value = ((CurrencyBox)Target).Value * 10 + ((double)value)/100;
            else
            {
                string text = value.ToString().Trim();
                if (Target.TextLength + text.Length <= Target.MaxLength)
                    Target.AppendText(text);
            }
        }
    }
}
