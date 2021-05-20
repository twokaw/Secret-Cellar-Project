using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;

namespace NCR_Printer
{
    public class PrintLayout
    {

        public string PageType { get; set; } = "receipt";
        public int Width { get; set; } = 280;
        public Image Logo { get; set; }
        public string Footer { get; set; }
        public string Header { get; set; }
        public int DesctiptionWidth { get; set; } = 29;

        /// <summary>
        /// The default font will be 3of9 barcode font (Free 3 of 9).  3of9 wraps the barcode text in *
        /// feel free to use your barcode font
        /// </summary>
        public Font BarcodeFont { get; set; }
        public bool Is3of9 { get; set; } = true;

        public string BarcodeName
        {
            get
            {
                return BarcodeFont.Name;
            }
            set
            {
                BarcodeFont = FetchFont(value, _BarcodeFontSize);
            }
        }

        private float _BarcodeFontSize { get; set; } = 36;
        public float BarcodeFontSize
        {
            get
            {
                return _BarcodeFontSize;
            }
            set
            {
                _BarcodeFontSize = value;
                BarcodeFont = FetchFont(BarcodeName, _BarcodeFontSize);
            }
        }

        public Font TextFont { get; set; }
        public string TextFontName
        {
            get { return TextFont.Name; }
            set { TextFont = FetchFont(BarcodeName, _TextFontSize); }
        }

        private float _TextFontSize { get; set; } = 36;

        private Font FetchFont(string fontname, float size)
        {
            FontFamily fontFamily = FontCollection.Families.FirstOrDefault(x => x.Name == fontname);

            if (fontFamily == null)
                return new Font(fontname, size, FontStyle.Regular);
            else
                return new Font(fontFamily, size);
        }
        public string FontName { get; set; } = "Arial";
        public float FontSize { get; set; } = 11;

        /// <summary>
        /// This will refresh font collection from the folder
        /// </summary>
        public void RefreshFontCollection()
        {
            if (_FontDirectory == null)
                _FontDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            FontCollection = new PrivateFontCollection();

            foreach (string f in Directory.GetFiles(_FontDirectory))
                FontCollection.AddFontFile(Path.Combine(_FontDirectory, f));
        }

        public string _FontDirectory;

        public string FontDirectory
        {
            get { return _FontDirectory; }
            set
            {
                _FontDirectory = value;
                RefreshFontCollection();
            }
        }

        public PrivateFontCollection FontCollection = new PrivateFontCollection();
        public PrintLayout() : this(null, null, 36, "Arial", 11) { }
        public PrintLayout(string barcodeName, float barcodeFontSize = 36) : this(null, barcodeName, barcodeFontSize, "Arial", 11) { }
        public PrintLayout(string fontDirectory, string barcodeName, float barcodeFontSize = 36) : this(fontDirectory, barcodeName, barcodeFontSize, "Arial", 11) { }
        public PrintLayout(string barcodeName, float barcodeFontSize, string textName, float textFontSize) : this(null, barcodeName, barcodeFontSize, textName, textFontSize) { }
        public PrintLayout(string fontDirectory, string barcodeName, float barcodeFontSize, string textName, float textFontSize)
        {
            FontDirectory = fontDirectory;
            _BarcodeFontSize = barcodeFontSize;
            BarcodeFont = FetchFont(barcodeName, barcodeFontSize);

            _TextFontSize = textFontSize;
            TextFont = FetchFont(textName, textFontSize);
        }
    }
}
