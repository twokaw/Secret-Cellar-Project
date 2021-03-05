using System.Collections.Generic;
using System.Linq;

namespace Shared
{
    public class PrinterCode
    {
        public uint CodeId { get; set; }
        public string Drawer { get; set; }
        public string Cutter { get; set; }
        public string PartialCutter { get; set; }
    }

    public class Printer
    {
        public uint ModelId { get; set; }
        public uint MakeId { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }

        public uint CodeId { get; set; }

        public List<PrinterCode> Codes{ get; set; }
        public string Drawer 
        {
            get 
            {

                return Codes?.FirstOrDefault(x => x.CodeId == CodeId)?.Drawer?? Codes[0].Drawer;
            }
        }
        public string Cutter
        {
            get
            {
                return Codes?.FirstOrDefault(x => x.CodeId == CodeId)?.Cutter ?? Codes[0].Cutter;
            }
        }
        public string PartialCutter
        {
            get
            {
                return Codes?.FirstOrDefault(x => x.CodeId == CodeId)?.PartialCutter ?? Codes[0].PartialCutter;
            }
        }
        public Printer() { Codes = new List<PrinterCode>(); }
    }
}
