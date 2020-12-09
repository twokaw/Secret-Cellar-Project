using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SecretCellar
{
    public partial class ManagedForm : Form
    {
        private static Color CommonBackColor = DefaultColor();
        private static Font CommonFont = Default_Font();
        private static DataGridViewCellStyle CommonCell = Default_Cell_Style();
        private static readonly List<ManagedForm> Forms = new List<ManagedForm>();
        private static Color CommonDataGridViewColor = Default_DataGridView_Color();

        public static DataGridViewCellStyle DefaultCellStyle 
        { 
            get
            {
                return CommonCell;
            }
        }
        public ManagedForm()
        {
            Forms.Add(this);
            Console.WriteLine($"Constructed: {Forms.Count}");
            base.BackColor = CommonBackColor;
            foreach (DataGridView c in base.Controls)
            {
                c.DefaultCellStyle = CommonCell;
            }
            base.Font = CommonFont;
            base.FormClosed += ManagedForm_FormClosed;
        }

        private void ManagedForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.Remove(this);
            Console.WriteLine($"Deconstructed: {Forms.Count}");
        }

        private static Color DefaultColor()
        {
            return Color.DarkSlateGray;
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
        private static DataGridViewCellStyle Default_Cell_Style()
        {
            return new DataGridViewCellStyle();
        }
        public static void SetDefaultCellStyle(DataGridViewCellStyle cell_style)
        {

            CommonCell = cell_style;
            foreach (ManagedForm f in Forms)
            {


                foreach (DataGridView c in f.Controls.OfType<DataGridView>())
                {
                    c.DefaultCellStyle = CommonCell;
                }

            }
        }

        public static Color Default_DataGridView_Color()
        {
            return Color.Gray;
        }
        public static Color DataGridViewBackColor
        {
            get
            {
                return CommonDataGridViewColor;
            }
            set
            {
                CommonDataGridViewColor = value;
                foreach (ManagedForm f in Forms)
                {

                    foreach (DataGridView c in f.Controls.OfType<DataGridView>())
                    {
                        c.BackgroundColor = value;
                    }

                }
            }
        }
    }
}
