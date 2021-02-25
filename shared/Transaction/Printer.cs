using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Printer
    {
        public uint ModelId { get; set; }
        public uint MakeId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Drawer { get; set; }
        public string Cutter { get; set; }
        public string PartialCutter { get; set; }
    }
}
