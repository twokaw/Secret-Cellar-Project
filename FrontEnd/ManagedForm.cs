using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SecretCellar
{
    public partial class ManagedForm : Form
    {
        private static readonly List<ManagedForm> _forms = new List<ManagedForm>();
        private static readonly Color _lightBlue = Color.FromArgb(255, 51, 153, 255);
        private static readonly Color _white = Color.FromArgb(255, 255, 255, 255);


        public static Color BackgroundColor {
            get { return Properties.Settings.Default.BackgroundColor; }
            set {
                Properties.Settings.Default.BackgroundColor = value;

                _forms.ForEach(x => x.BackColor = value);
            }
        }
        public static Color PanelColor {
            get { return Properties.Settings.Default.PanelColor; }
            set {
                Properties.Settings.Default.PanelColor = value;

                foreach (ManagedForm f in _forms) {
                    foreach (Panel panel in f.Controls.OfType<Panel>()) {
                        panel.BackColor = value;
                    }
                }
            }
        }
        
        public static Font FontStyle {
            get { return new Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte)0); }
            set {
                Properties.Settings.Default.FontSet = value;

                foreach (ManagedForm f in _forms) {
                    f.Font = value;

                    foreach (Control c in f.Controls) {
                        c.Font = value;
                    }
                }
            }
        }
        
        public static Color FontColor {
            get { return Properties.Settings.Default.FontColor; }
            set {
                Properties.Settings.Default.FontColor = value;

                foreach (ManagedForm form in _forms) {
                    form.ForeColor = value;

                    foreach (Control control in form.Controls) {
                        control.ForeColor = value;
                    }
                }
            }
        }
        public static Color ButtonColor {
            get { return Properties.Settings.Default.ButtonColor; }
            set {
                Properties.Settings.Default.ButtonColor = value;

                foreach (ManagedForm form in _forms) {
                    foreach (Control control in form.Controls.OfType<Button>()) {
                        control.BackColor = value;
                    }
                }
            }
        }
        public static Color ButtonFontColor {
            get { return Properties.Settings.Default.ButtonFontColor; }
            set {
                Properties.Settings.Default.ButtonFontColor = value;

                foreach (ManagedForm form in _forms) {
                    foreach (Control control in form.Controls.OfType<Button>()) {
                        control.ForeColor = value;
                    }
                }
            }
        }
        public static Color DataGridViewColor {
            get { return Properties.Settings.Default.GridColor; }
            set {
                Properties.Settings.Default.GridColor = value;

                foreach (ManagedForm f in _forms) {
                    foreach (DataGridView c in f.Controls.OfType<DataGridView>()) {
                        c.BackgroundColor = value;
                    }
                }
            }
        }
        public static Color DataGridViewRowColor {
            get { return Properties.Settings.Default.GridRowColor; }
            set {
                Properties.Settings.Default.GridRowColor = value;

                foreach (ManagedForm f in _forms) {
                    foreach (DataGridView c in f.Controls.OfType<DataGridView>()) {
                        c.RowsDefaultCellStyle.BackColor = value;
                    }
                }
            }
        }
        public static Color DataGridViewRowFontColor {
            get { return Properties.Settings.Default.GridRowFontColor; }
            set {
                Properties.Settings.Default.GridRowFontColor = value;

                foreach (ManagedForm f in _forms) {
                    foreach (DataGridView c in f.Controls.OfType<DataGridView>()) {
                        c.RowsDefaultCellStyle.ForeColor = value;
                    }
                }
            }
        }
        public static Color DataGridViewAlternateRowColor {
            get { return Properties.Settings.Default.GridAlternateRowColor; }
            set {
                Properties.Settings.Default.GridAlternateRowColor = value;

                foreach (ManagedForm f in _forms) {
                    foreach (DataGridView c in f.Controls.OfType<DataGridView>()) {
                        c.AlternatingRowsDefaultCellStyle.BackColor = value;
                    }
                }
            }
        }
        public static Color DataGridViewAlternateRowFontColor {
            get { return Properties.Settings.Default.GridAlternateRowFontColor; }
            set {
                Properties.Settings.Default.GridAlternateRowFontColor = value;

                foreach (ManagedForm f in _forms) {
                    foreach (DataGridView c in f.Controls.OfType<DataGridView>()) {
                        c.AlternatingRowsDefaultCellStyle.ForeColor = value;
                    }
                }
            }
        }
        public static DataGridViewCellStyle CellStyle {
            get {
                return new DataGridViewCellStyle {
                    BackColor = DataGridViewColor,
                    ForeColor = DataGridViewRowColor,
                    SelectionBackColor = _lightBlue,
                    SelectionForeColor = _white
                };
            }
        }
        public static DataGridViewCellStyle CellAlternateRowStyle {
            get {
                return new DataGridViewCellStyle {
                    BackColor = DataGridViewColor,
                    ForeColor = DataGridViewAlternateRowColor,
                    SelectionBackColor = _lightBlue,
                    SelectionForeColor = _white
                };
            }
        }


        public ManagedForm()
        {
            _forms.Add(this);
            Console.WriteLine($"Constructed: {_forms.Count}");
            base.FormClosed += ManagedForm_FormClosed;
            base.Load += ManagedForm_Load;
        }


        private void ManagedForm_FormClosed(object sender, FormClosedEventArgs e) {
            _forms.Remove(this);
            //if(Forms.Count == 0 )
            //    CommonFont = new Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Console.WriteLine($"Deconstructed: {_forms.Count}");
        }


        /// <summary>
        /// Sets the properties to default.
        /// </summary>
        public static void SetPropertiesToDefault() {
            BackgroundColor = Properties.Settings.Default.DefaultBackgroundColor;
            PanelColor = Properties.Settings.Default.DefaultPanelColor;
            //FontStyle = Properties.Settings.Default.DefaultFont;
            FontColor = Properties.Settings.Default.DefaultFontColor;
            ButtonColor = Properties.Settings.Default.DefaultButtonColor;
            ButtonFontColor = Properties.Settings.Default.DefaultButtonFontColor;
            DataGridViewColor = Properties.Settings.Default.DefaultGridColor;
            DataGridViewRowColor = Properties.Settings.Default.DefaultGridRowColor;
            DataGridViewRowFontColor = Properties.Settings.Default.DefaultGridRowFontColor;
            DataGridViewAlternateRowColor = Properties.Settings.Default.DefaultGridAlternateRowColor;
            DataGridViewAlternateRowFontColor = Properties.Settings.Default.DefaultGridAlternateRowFontColor;
        }


        private void ManagedForm_Load(object sender, EventArgs e)
        {
            base.BackColor = BackgroundColor;
            base.Font = FontStyle;

            base.ForeColor = FontColor;

            foreach (Control c in base.Controls)
            {
                c.Font = FontStyle;
                
                if (c.GetType() == typeof(DataGridView))
                {
                    ((DataGridView)c).DefaultCellStyle = CellStyle;
                    ((DataGridView)c).RowsDefaultCellStyle = CellStyle;
                    ((DataGridView)c).AlternatingRowsDefaultCellStyle = CellAlternateRowStyle;
                    ((DataGridView)c).BackgroundColor = DataGridViewColor;
                    ((DataGridView)c).RowsDefaultCellStyle.BackColor = DataGridViewRowColor;
                    ((DataGridView)c).RowsDefaultCellStyle.ForeColor = DataGridViewRowFontColor;
                    ((DataGridView)c).RowsDefaultCellStyle.SelectionForeColor = _white;
                    ((DataGridView)c).AlternatingRowsDefaultCellStyle.BackColor = DataGridViewAlternateRowColor;
                    ((DataGridView)c).AlternatingRowsDefaultCellStyle.ForeColor = DataGridViewAlternateRowFontColor;
                    ((DataGridView)c).AlternatingRowsDefaultCellStyle.SelectionForeColor = _white;
                }

                else if (c.GetType() == typeof(Panel))
                    ((Panel)c).BackColor = PanelColor;

                else if (c.GetType() == typeof(Button))
                {
                    c.BackColor = ButtonColor;
                    c.ForeColor = ButtonFontColor;
                }
            }

        }
    }
}
