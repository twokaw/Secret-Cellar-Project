﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SecretCellar.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.3.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost:5000")]
        public string URL {
            get {
                return ((string)(this["URL"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("logo.png")]
        public string Logo {
            get {
                return ((string)(this["Logo"]));
            }
            set {
                this["Logo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1205 Curtis Bridge Road NE\r\nShueyville, IA 52338\r\n 319-841-2172")]
        public string Header {
            get {
                return ((string)(this["Header"]));
            }
            set {
                this["Header"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("COM3")]
        public string CashDrawerPort {
            get {
                return ((string)(this["CashDrawerPort"]));
            }
            set {
                this["CashDrawerPort"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool PrintReceipt {
            get {
                return ((bool)(this["PrintReceipt"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".\\Resources")]
        public string FontPath {
            get {
                return ((string)(this["FontPath"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Arial")]
        public string ReceiptFont {
            get {
                return ((string)(this["ReceiptFont"]));
            }
            set {
                this["ReceiptFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("9")]
        public float ReceiptFontSize {
            get {
                return ((float)(this["ReceiptFontSize"]));
            }
            set {
                this["ReceiptFontSize"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int ReceiptWidth {
            get {
                return ((int)(this["ReceiptWidth"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Thank You Come Again!\r\n\r\n*****************************")]
        public string Footer {
            get {
                return ((string)(this["Footer"]));
            }
            set {
                this["Footer"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Free 3 of 9")]
        public string BarcodeFont {
            get {
                return ((string)(this["BarcodeFont"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("36")]
        public int BarcodeSize {
            get {
                return ((int)(this["BarcodeSize"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("230, 232, 238")]
        public global::System.Drawing.Color BackgroundColor {
            get {
                return ((global::System.Drawing.Color)(this["BackgroundColor"]));
            }
            set {
                this["BackgroundColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60, 67, 77")]
        public global::System.Drawing.Color GridColor {
            get {
                return ((global::System.Drawing.Color)(this["GridColor"]));
            }
            set {
                this["GridColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Microsoft Sans Serif, 12pt, style=Bold")]
        public global::System.Drawing.Font FontSet {
            get {
                return ((global::System.Drawing.Font)(this["FontSet"]));
            }
            set {
                this["FontSet"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1024, 768")]
        public global::System.Drawing.Size MainFormSize {
            get {
                return ((global::System.Drawing.Size)(this["MainFormSize"]));
            }
            set {
                this["MainFormSize"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("230, 232, 238")]
        public global::System.Drawing.Color DefaultBackgroundColor {
            get {
                return ((global::System.Drawing.Color)(this["DefaultBackgroundColor"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60, 67, 77")]
        public global::System.Drawing.Color DefaultGridColor {
            get {
                return ((global::System.Drawing.Color)(this["DefaultGridColor"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Microsoft Sans Serif, 12pt")]
        public global::System.Drawing.Font DefaultFont {
            get {
                return ((global::System.Drawing.Font)(this["DefaultFont"]));
            }
            set {
                this["DefaultFont"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("12")]
        public float DefaultFontSize {
            get {
                return ((float)(this["DefaultFontSize"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Bold")]
        public string DefaultFontStyle {
            get {
                return ((string)(this["DefaultFontStyle"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int PrinterModelId {
            get {
                return ((int)(this["PrinterModelId"]));
            }
            set {
                this["PrinterModelId"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int PrintCodeId {
            get {
                return ((int)(this["PrintCodeId"]));
            }
            set {
                this["PrintCodeId"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("IA")]
        public string DefaultState {
            get {
                return ((string)(this["DefaultState"]));
            }
            set {
                this["DefaultState"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("22, 22, 22")]
        public global::System.Drawing.Color DefaultFontColor {
            get {
                return ((global::System.Drawing.Color)(this["DefaultFontColor"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("22, 22, 22")]
        public global::System.Drawing.Color FontColor {
            get {
                return ((global::System.Drawing.Color)(this["FontColor"]));
            }
            set {
                this["FontColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("64, 70, 96")]
        public global::System.Drawing.Color ButtonColor {
            get {
                return ((global::System.Drawing.Color)(this["ButtonColor"]));
            }
            set {
                this["ButtonColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color ButtonFontColor {
            get {
                return ((global::System.Drawing.Color)(this["ButtonFontColor"]));
            }
            set {
                this["ButtonFontColor"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("64, 70, 96")]
        public global::System.Drawing.Color DefaultButtonColor {
            get {
                return ((global::System.Drawing.Color)(this["DefaultButtonColor"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("White")]
        public global::System.Drawing.Color DefaultButtonFontColor {
            get {
                return ((global::System.Drawing.Color)(this["DefaultButtonFontColor"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("41, 55, 86")]
        public global::System.Drawing.Color DefaultGridRowColor {
            get {
                return ((global::System.Drawing.Color)(this["DefaultGridRowColor"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("152, 177, 203")]
        public global::System.Drawing.Color DefaultGridAlternateRowColor {
            get {
                return ((global::System.Drawing.Color)(this["DefaultGridAlternateRowColor"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("41, 55, 86")]
        public global::System.Drawing.Color GridRowColor {
            get {
                return ((global::System.Drawing.Color)(this["GridRowColor"]));
            }
            set {
                this["GridRowColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("152, 177, 203")]
        public global::System.Drawing.Color GridAlternateRowColor {
            get {
                return ((global::System.Drawing.Color)(this["GridAlternateRowColor"]));
            }
            set {
                this["GridAlternateRowColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("213, 223, 234")]
        public global::System.Drawing.Color PanelColor {
            get {
                return ((global::System.Drawing.Color)(this["PanelColor"]));
            }
            set {
                this["PanelColor"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("213, 223, 234")]
        public global::System.Drawing.Color DefaultPanelColor {
            get {
                return ((global::System.Drawing.Color)(this["DefaultPanelColor"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("233, 233, 233")]
        public global::System.Drawing.Color DefaultGridRowFontColor {
            get {
                return ((global::System.Drawing.Color)(this["DefaultGridRowFontColor"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("233, 233, 233")]
        public global::System.Drawing.Color GridRowFontColor {
            get {
                return ((global::System.Drawing.Color)(this["GridRowFontColor"]));
            }
            set {
                this["GridRowFontColor"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("22, 22, 22")]
        public global::System.Drawing.Color DefaultGridAlternateRowFontColor {
            get {
                return ((global::System.Drawing.Color)(this["DefaultGridAlternateRowFontColor"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("22, 22, 22")]
        public global::System.Drawing.Color GridAlternateRowFontColor {
            get {
                return ((global::System.Drawing.Color)(this["GridAlternateRowFontColor"]));
            }
            set {
                this["GridAlternateRowFontColor"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("22, 22, 22")]
        public global::System.Drawing.Color DefaultPanelFontColor {
            get {
                return ((global::System.Drawing.Color)(this["DefaultPanelFontColor"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("22, 22, 22")]
        public global::System.Drawing.Color PanelFontColor {
            get {
                return ((global::System.Drawing.Color)(this["PanelFontColor"]));
            }
            set {
                this["PanelFontColor"] = value;
            }
        }
    }
}
