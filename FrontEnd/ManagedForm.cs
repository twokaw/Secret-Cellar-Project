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
        public static DataGridViewCellStyle CellStyle {
            get {
                //TODO Grab the row, alternate row, and the background color and set it to this style before returning it.
                return new DataGridViewCellStyle();
            }
        }


        public ManagedForm() {
            _forms.Add(this);
            Console.WriteLine($"Constructed: {_forms.Count}");
            base.BackColor = BackgroundColor;

            foreach (DataGridView c in base.Controls) {
                c.DefaultCellStyle = CellStyle;
            }

            base.Font = DefaultFont;
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
            BackgroundColor = Properties.Settings.Default.DefaultBackgroundColor;
            PanelColor = Properties.Settings.Default.DefaultPanelColor;
            //FontStyle = Properties.Settings.Default.DefaultFont;
            FontColor = Properties.Settings.Default.DefaultFontColor;
            ButtonColor = Properties.Settings.Default.DefaultButtonColor;
            ButtonFontColor = Properties.Settings.Default.DefaultButtonFontColor;
            DataGridViewColor = Properties.Settings.Default.DefaultGridColor;
            DataGridViewRowColor = Properties.Settings.Default.DefaultGridRowColor;
            DataGridViewAlternateRowColor = Properties.Settings.Default.DefaultGridAlternateRowColor;
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
