using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class BaseItem
    {
        public string Name { get; set; }     // Name of product
        public uint Id { get; set; }
        public string Barcode { get; set; }
        public uint Qty { get; set; }
        public double Price { get; set; }   // Price in dollars
        public bool NonTaxable { get; set; }
        public bool NonTaxableLocal { get; set; }
        public string ItemType { get; set; }
        public uint Bottles { get; set; }
    }
}
