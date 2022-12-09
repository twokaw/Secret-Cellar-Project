using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SecretCellar
{
    public partial class ManagedForm : Form
    {
        private static Color _panelColor = _defaultPanelColor;
        private static Color _dataGridViewColor = _defaultDataGridViewColor;
        private static Color _buttonFontColor = _defaultButtonFontColor;
        private static Color _buttonColor = _defaultButtonColor;
        private static Font _font = _defaultFont;
        private static Color _fontColor = _defaultFontColor;
        private static DataGridViewCellStyle _cellStyle = _defaultCellStyle;
        private static readonly List<ManagedForm> _forms = new List<ManagedForm>();
        
        //DEFAULT VALUES
        //TODO Make these public so I can access them in PanAppearance's Commit method.
        private static Color _defaultPanelColor {
            get { return Properties.Settings.Default.BackgroundColor; }
            set { Properties.Settings.Default.BackgroundColor = value; }
        }
        private static Font _defaultFont {
            get { return new Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))); }
            set { Properties.Settings.Default.FontSet = value; }
        }
        private static Color _defaultFontColor {
            get { return Properties.Settings.Default.FontColor; }
            set { Properties.Settings.Default.FontColor = value; }
        }
        private static Color _defaultButtonColor {
            get { return Properties.Settings.Default.ButtonColor; }
            set { Properties.Settings.Default.ButtonColor = value; }
        }
        private static Color _defaultButtonFontColor {
            get { return Properties.Settings.Default.ButtonFontColor; }
            set { Properties.Settings.Default.ButtonFontColor = value; }
        }
        private static Color _defaultDataGridViewColor {
            get { return Properties.Settings.Default.GridColor; }
            set { Properties.Settings.Default.GridColor = value; }
        }
        private static DataGridViewCellStyle _defaultCellStyle { get { return new DataGridViewCellStyle(); } }
        

        //PUBLIC ACCESSORS
        public static Color PanelColor {
            get { return _panelColor; }

            set {
                _panelColor = value;
                _forms.ForEach(x => x.BackColor = _panelColor);
            }
        }
        public static Font FontStyle {
            get { return _font; }

            set {
                _font = value;
                foreach (ManagedForm f in _forms) {
                    f.Font = _font;

                    foreach (Control c in f.Controls) {
                        c.Font = _font;
                    }
                }
            }
        }
        public static Color FontColor {
            get { return _fontColor; }

            set {
                _fontColor = value;

                foreach (ManagedForm form in _forms) {
                    form.ForeColor = FontColor;

                    foreach (Control control in form.Controls) {
                        control.ForeColor = FontColor;
                    }
                }
            }
        }
        public static Color ButtonColor {
            get { return _buttonColor; }
            set {
                _buttonColor = value;
                foreach (ManagedForm form in _forms) {
                    foreach (Control control in form.Controls.OfType<Button>()) {
                        control.BackColor = _buttonColor;
                    }
                }
            }
        }
        public static Color ButtonFontColor {
            get { return _buttonFontColor; }
            set {
                _buttonFontColor = value;
                foreach (ManagedForm form in _forms) {
                    foreach (Control control in form.Controls.OfType<Button>()) {
                        control.ForeColor = _buttonFontColor;
                    }
                }
            }
        }
        public static Color DataGridViewColor {
            get { return _dataGridViewColor; }

            set {
                _dataGridViewColor = value;
                foreach (ManagedForm f in _forms) {
                    foreach (DataGridView c in f.Controls.OfType<DataGridView>()) {
                        c.BackgroundColor = value;
                    }
                }
            }
        }
        public static DataGridViewCellStyle CellStyle {
            get { return _cellStyle; }
        }


        public ManagedForm() {
            _forms.Add(this);
            Console.WriteLine($"Constructed: {_forms.Count}");
            base.BackColor = _panelColor;

            foreach (DataGridView c in base.Controls) {
                c.DefaultCellStyle = _cellStyle;
            }

            base.Font = _font;
            base.FormClosed += ManagedForm_FormClosed;
        }


        private void ManagedForm_FormClosed(object sender, FormClosedEventArgs e) {
            _forms.Remove(this);
            //if(Forms.Count == 0 )
            //    CommonFont = new Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Console.WriteLine($"Deconstructed: {_forms.Count}");
        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cell_style"></param>
        public static void SetDefaultCellStyle(DataGridViewCellStyle cell_style) {
            _cellStyle = cell_style;
            foreach (ManagedForm f in _forms) {
                foreach (DataGridView c in f.Controls.OfType<DataGridView>()) {
                    c.DefaultCellStyle = _cellStyle;
                }
            }
        }


        /// <summary>
        /// Sets the properties to default then updates the forms.
        /// </summary>
        public static void SetPropertiesToDefault() {
            _defaultPanelColor = Properties.Settings.Default.DefaultBackgroundColor;
            //_DefaultFont = Properties.Settings.Default.DefaultFont;
            _defaultFontColor = Properties.Settings.Default.DefaultFontColor;
            _defaultButtonColor = Properties.Settings.Default.DefaultButtonColor;
            _defaultButtonFontColor = Properties.Settings.Default.DefaultButtonFontColor;
            _defaultDataGridViewColor = Properties.Settings.Default.DefaultGridColor;

            Properties.Settings.Default.Save();

            PanelColor = _defaultPanelColor;
            FontColor = _defaultFontColor;
            ButtonColor = _defaultButtonColor;
            ButtonFontColor = _defaultButtonFontColor;
            DataGridViewColor = _defaultDataGridViewColor;
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
