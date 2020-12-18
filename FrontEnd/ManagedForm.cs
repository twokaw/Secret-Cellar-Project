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

        public ManagedForm()
        {
            if(Forms.Count == 0)
            {
                CommonBackColor = DefaultColor();
                CommonFont = Default_Font();
            }
            Forms.Add(this);
    }

        private void ManagedForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.Remove(this);
            if(Forms.Count == 0)
                CommonFont = new Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private static Color DefaultColor()
        {
            return Color.Beige;
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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ManagedForm
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "ManagedForm";
            this.Load += new System.EventHandler(this.ManagedForm_Load);
            this.ResumeLayout(false);

        }

        private void ManagedForm_Load(object sender, EventArgs e)
        {
            base.BackColor = CommonBackColor;
            base.Font = CommonFont;
            base.FormClosed += ManagedForm_FormClosed;
        }
    }
}
