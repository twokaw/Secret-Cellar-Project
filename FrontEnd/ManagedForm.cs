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
            if(Forms.Count == 0 )
                CommonFont = new Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Console.WriteLine($"Deconstructed: {Forms.Count}");
        }

        private static Color DefaultColor()
        {
            return Properties.Settings.Default.BackgroundColor;
        }

        public static Color MainWindowColor
        {
            get
            {
                return CommonBackColor;
            }
            set
            {
            CommonBackColor = value;
            Forms.ForEach(x => x.BackColor = CommonBackColor);
            }
        }

        private static Font Default_Font()
        {
            return Properties.Settings.Default.FontSet;
        }

        public static Font CommonFontSetter
        {
            get
                {
                return CommonFont;
            }
            set
            {
                CommonFont = value;
                foreach (ManagedForm f in Forms)
                {
                    f.Font = CommonFont;
                   
                    foreach (Control c in f.Controls) {
                        c.Font = CommonFont;
                    }
                    
                }
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
            return Properties.Settings.Default.GridColor;
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
        public static void reset_Default_Properties()
        {   
                MainWindowColor = Properties.Settings.Default.DefaultBackgroundColor;
                DataGridViewBackColor = Properties.Settings.Default.DefaultGridColor;
                CommonFontSetter = Properties.Settings.Default.DefaultFont;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ManagedForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "ManagedForm";
            this.Load += new System.EventHandler(this.ManagedForm_Load);
            this.ResumeLayout(false);

        }

        private void ManagedForm_Load(object sender, EventArgs e)
        {

        }
    }
}
