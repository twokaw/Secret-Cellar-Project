
using System;
using System.Collections.Generic;

namespace Shared
{
    public class BaseItem : Tax
    {
        public string Name { get; set; }     // Name of product
        public uint Id { get; set; }
        public string Barcode { get; set; }
        public uint Qty { 
            get
            { 
                uint qty = 0;
                AllQty.ForEach(x => qty += x.Qty);
                return qty;
            } 
        }
        // Price in dollars
        public double Price { get; set; }   
        public bool NonTaxable { get; set; }
        public bool NonTaxableLocal { get; set; }
        public uint TypeID { get; set; }
        public string ItemType { get; set; }
        public bool Hidden { get; set; }
        public uint Bottles { get; set; }
        public List<Discount> Discounts { get; set; } = new List<Discount>();
        public double SupplierPrice {
            get
            {
                double price = 0.0;
                DateTime last = DateTime.MinValue;
                AllQty.ForEach(x =>
                {
                    if (last < x.PurchasedDate)
                    {
                        last = x.PurchasedDate;
                        price = x.SupplierPrice;
                    }
                });

                return price;
            }
        }

        public List<InventoryQty> AllQty { get; set; } = new List<InventoryQty>();
    }

}
 