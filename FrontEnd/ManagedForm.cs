using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SecretCellar
{
    public partial class ManagedForm : Form
    {
        private static Color _PanelColor = DefaultColor();
        private static Color _CommonDataGridViewColor = Default_DataGridView_Color();
        private static Color _ButtonFontColor = DefaultButtonFontColor();
        private static Color _ButtonColor = DefaultButtonColor();
        private static Font _Font = Default_Font();
        private static Color _FontColor = DefaultFontColor();

        private static DataGridViewCellStyle _CommonCell = Default_Cell_Style();
        private static readonly List<ManagedForm> _Forms = new List<ManagedForm>();
        


        public ManagedForm() {
            _Forms.Add(this);
            Console.WriteLine($"Constructed: {_Forms.Count}");
            base.BackColor = _PanelColor;

            foreach (DataGridView c in base.Controls) {
                c.DefaultCellStyle = _CommonCell;
            }

            base.Font = _Font;
            base.FormClosed += ManagedForm_FormClosed;
        }

        private void ManagedForm_FormClosed(object sender, FormClosedEventArgs e) {
            _Forms.Remove(this);
            //if(Forms.Count == 0 )
            //    CommonFont = new Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Console.WriteLine($"Deconstructed: {_Forms.Count}");
        }


        private static Color DefaultColor() { return Properties.Settings.Default.BackgroundColor; }
        private static Color DefaultFontColor() { return Properties.Settings.Default.FontColor; }
        private static Color DefaultButtonColor() { return Properties.Settings.Default.DefaultButtonColor; }
        private static Color DefaultButtonFontColor() { return Properties.Settings.Default.DefaultButtonFontColor; }
        private static Font Default_Font() { return new Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))); }
        private static DataGridViewCellStyle Default_Cell_Style() { return new DataGridViewCellStyle(); }


        public static Color Default_DataGridView_Color() { return Properties.Settings.Default.GridColor; }


        public static DataGridViewCellStyle DefaultCellStyle {
            get { return _CommonCell; }
        }


        public static Color DataGridViewBackColor {
            get { return _CommonDataGridViewColor; }

            set {
                _CommonDataGridViewColor = value;
                foreach (ManagedForm f in _Forms) {
                    foreach (DataGridView c in f.Controls.OfType<DataGridView>()) {
                        c.BackgroundColor = value;
                    }
                }
            }
        }


        public static Color PanelColor {
            get { return _PanelColor; }

            set {
                _PanelColor = value;
                _Forms.ForEach(x => x.BackColor = _PanelColor);
            }
        }


        public static Font FontStyle {
            get { return _Font; }

            set {
                _Font = value;
                foreach (ManagedForm f in _Forms) {
                    f.Font = _Font;

                    foreach (Control c in f.Controls) {
                        c.Font = _Font;
                    }
                }
            }
        }


        public static Color FontColor {
            get { return _FontColor; }

            set {
                _FontColor = value;

                foreach (ManagedForm form in _Forms) {
                    form.ForeColor = FontColor;

                    foreach (Control control in form.Controls) {
                        control.ForeColor = FontColor;
                    }
                }
            }
        }

        
        public static void SetDefaultCellStyle(DataGridViewCellStyle cell_style) {
            _CommonCell = cell_style;
            foreach (ManagedForm f in _Forms) {
                foreach (DataGridView c in f.Controls.OfType<DataGridView>()) {
                    c.DefaultCellStyle = _CommonCell;
                }
            }
        }


        


        public static void reset_Default_Properties() {   
            PanelColor = Properties.Settings.Default.DefaultBackgroundColor;
            DataGridViewBackColor = Properties.Settings.Default.DefaultGridColor;
            FontStyle = Properties.Settings.Default.DefaultFont;
        }


        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagedForm));
            this.SuspendLayout();
            // 
            // ManagedForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(231)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagedForm";
            this.ResumeLayout(false);

        }
    }
}
