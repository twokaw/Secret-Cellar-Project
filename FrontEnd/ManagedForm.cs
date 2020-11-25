using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SecretCellar
{
    public partial class ManagedForm : Form
    {

        private static Color CommonBackColor = DefaultColor();
        private static Font CommonFont = Default_Font();
        private static readonly List<ManagedForm> Forms = new List<ManagedForm>();
        private static bool flag = false;
        public ManagedForm()
        {
            Forms.Add(this);
            Console.WriteLine($"Constructed: {Forms.Count}");
            base.BackColor = CommonBackColor;
            base.Font = CommonFont;
            Font f;

            if (flag)
            {
                SetBackColor(Color.SandyBrown);
                f = new Font(CommonFont.Name, CommonFont.Size + 3, CommonFont.Style);

            }
            else
            {
                SetBackColor(Color.Beige);
                f = new Font(CommonFont.Name, CommonFont.Size - 3, CommonFont.Style);

            }

            flag = !flag;
            SetFont(f);

            base.FormClosed += ManagedForm_FormClosed;
        }

        private void ManagedForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.Remove(this);
            Console.WriteLine($"Deconstructed: {Forms.Count}");
        }

        private static Color DefaultColor()
        {
            return Color.Black;
        }

        public static void SetBackColor(Color c)
        {
            CommonBackColor = c;
            Forms.ForEach(x => x.BackColor = CommonBackColor);
        }

        private static Font Default_Font()
        {
            return new Font("Arial", 11);
        }

        public static void SetFont(Font font)
        {
            CommonFont = font;
            foreach(ManagedForm f in Forms)
            {
                f.Font = CommonFont;
                /*
                foreach (Control c in f.Controls) {
                    c.Font = CommonFont;
                }
                */
            }
        }
    }
}
