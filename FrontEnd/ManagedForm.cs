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

        //DEFAULT VALUES
        //TODO Possibly can remove these and move the get methods of these into the PUBLIC ACCESSORS' get methods.
        public static Color _defaultPanelColor {
            get { return Properties.Settings.Default.BackgroundColor; }
            set { Properties.Settings.Default.BackgroundColor = value; }
        }
        public static Font _defaultFont {
            get { return new Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))); }
            set { Properties.Settings.Default.FontSet = value; }
        }
        public static Color _defaultFontColor {
            get { return Properties.Settings.Default.FontColor; }
            set { Properties.Settings.Default.FontColor = value; }
        }
        public static Color _defaultButtonColor {
            get { return Properties.Settings.Default.ButtonColor; }
            set { Properties.Settings.Default.ButtonColor = value; }
        }
        public static Color _defaultButtonFontColor {
            get { return Properties.Settings.Default.ButtonFontColor; }
            set { Properties.Settings.Default.ButtonFontColor = value; }
        }
        public static Color _defaultDataGridViewColor {
            get { return Properties.Settings.Default.GridColor; }
            set { Properties.Settings.Default.GridColor = value; }
        }
        public static Color _defaultDataGridViewRowColor {
            get { return Properties.Settings.Default.GridRowColor; }
            set { Properties.Settings.Default.GridRowColor = value; }
        }
        public static Color _defaultDataGridViewAlternateRowColor {
            get { return Properties.Settings.Default.GridAlternateRowColor; }
            set { Properties.Settings.Default.GridAlternateRowColor = value; }
        }
        public static DataGridViewCellStyle _defaultCellStyle {
            get {
                //TODO Grab the row, alternate row, and the background color and set it to this style before returning it.
                return new DataGridViewCellStyle();
            }
        }
        

        //PUBLIC ACCESSORS
        
        public static Color PanelColor {
            get { return _defaultPanelColor; }

            set {
                _defaultPanelColor = value;
                _forms.ForEach(x => x.BackColor = _defaultPanelColor);
            }
        }
        public static Font FontStyle {
            get { return _defaultFont; }

            set {
                _defaultFont = value;
                foreach (ManagedForm f in _forms) {
                    f.Font = _defaultFont;

                    foreach (Control c in f.Controls) {
                        c.Font = _defaultFont;
                    }
                }
            }
        }
        public static Color FontColor {
            get { return _defaultFontColor; }

            set {
                _defaultFontColor = value;

                foreach (ManagedForm form in _forms) {
                    form.ForeColor = FontColor;

                    foreach (Control control in form.Controls) {
                        control.ForeColor = FontColor;
                    }
                }
            }
        }
        public static Color ButtonColor {
            get { return _defaultButtonColor; }
            set {
                _defaultButtonColor = value;
                foreach (ManagedForm form in _forms) {
                    foreach (Control control in form.Controls.OfType<Button>()) {
                        control.BackColor = _defaultButtonColor;
                    }
                }
            }
        }
        public static Color ButtonFontColor {
            get { return _defaultButtonFontColor; }
            set {
                _defaultButtonFontColor = value;
                foreach (ManagedForm form in _forms) {
                    foreach (Control control in form.Controls.OfType<Button>()) {
                        control.ForeColor = _defaultButtonFontColor;
                    }
                }
            }
        }
        public static Color DataGridViewColor {
            get { return _defaultDataGridViewColor; }

            set {
                _defaultDataGridViewColor = value;
                foreach (ManagedForm f in _forms) {
                    foreach (DataGridView c in f.Controls.OfType<DataGridView>()) {
                        c.BackgroundColor = value;
                    }
                }
            }
        }
        public static Color DataGridViewRowColor {
            get { return _defaultDataGridViewRowColor; }

            set {
                _defaultDataGridViewRowColor = value;
                foreach (ManagedForm f in _forms) {
                    foreach (DataGridView c in f.Controls.OfType<DataGridView>()) {
                        c.RowsDefaultCellStyle.BackColor = value;
                    }
                }
            }
        }
        public static Color DataGridViewAlternateRowColor {
            get { return _defaultDataGridViewAlternateRowColor; }

            set {
                _defaultDataGridViewAlternateRowColor = value;
                foreach (ManagedForm f in _forms) {
                    foreach (DataGridView c in f.Controls.OfType<DataGridView>()) {
                        c.AlternatingRowsDefaultCellStyle.BackColor = value;
                    }
                }
            }
        }
        public static DataGridViewCellStyle CellStyle {
            get { return _defaultCellStyle; }
        }


        public ManagedForm() {
            _forms.Add(this);
            Console.WriteLine($"Constructed: {_forms.Count}");
            base.BackColor = _defaultPanelColor;

            foreach (DataGridView c in base.Controls) {
                c.DefaultCellStyle = _defaultCellStyle;
            }

            base.Font = _defaultFont;
            base.FormClosed += ManagedForm_FormClosed;
        }


        private void ManagedForm_FormClosed(object sender, FormClosedEventArgs e) {
            _forms.Remove(this);
            //if(Forms.Count == 0 )
            //    CommonFont = new Font("Microsoft Sans Serif", 12, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Console.WriteLine($"Deconstructed: {_forms.Count}");
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
            _defaultDataGridViewRowColor = Properties.Settings.Default.DefaultGridRowColor;
            _defaultDataGridViewAlternateRowColor = Properties.Settings.Default.DefaultGridAlternateRowColor;

            Properties.Settings.Default.Save();

            PanelColor = _defaultPanelColor;
            FontColor = _defaultFontColor;
            ButtonColor = _defaultButtonColor;
            ButtonFontColor = _defaultButtonFontColor;
            DataGridViewColor = _defaultDataGridViewColor;
            DataGridViewRowColor = _defaultDataGridViewRowColor;
            DataGridViewAlternateRowColor = _defaultDataGridViewAlternateRowColor;
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
