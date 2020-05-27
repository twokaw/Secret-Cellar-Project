﻿
using System.Collections.Generic;

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
        public List<Discount> Discount { get; set; } = new List<Discount>();
    }

}
