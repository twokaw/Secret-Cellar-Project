﻿
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
        public uint OrderQty { get; set; }
        public uint RequestQty { get; set; }
        public uint SuspendedQty { get; set; }
        public uint RequiredQty { get; set; }
        public int Vintage { get; set; }
        public string Description2 { get; set; }


        // Price in dollars
        public double Price { get; set; }
        public double DiscountPrice { get; set; }
        public bool NonTaxable { get; set; }
        public bool NonTaxableLocal { get; set; }
        public uint TypeID { get; set; }
        public string ItemType { get; set; }
        public bool Hidden { get; set; }
        public uint Bottles { get; set; }
        public List<Discount> Discounts { get; set; } = new List<Discount>();

        public double BulkDiscount {
            get 
            {
                double result = 0.0;

                foreach (Discount dis in Discounts.FindAll(x => x.Active))
                    result = Math.Max(result, dis.Amount);

                return result;
            }
        }


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

        public BaseItem() { }
        public BaseItem(BaseItem item) {
            this.Name = item.Name;
            this.Id = item.Id;
            this.Barcode = item.Barcode;
            this.OrderQty = item.OrderQty;
            this.RequestQty = item.RequestQty;
            this.RequiredQty = item.RequiredQty;
            this.Price = item.Price;
            this.DiscountPrice = item.DiscountPrice;
            this.NonTaxable = item.NonTaxable;
            this.NonTaxableLocal = item.NonTaxableLocal ;
            this.TypeID = item.TypeID;
            this.ItemType = item.ItemType;
            this.Hidden = item.Hidden;
            this.Bottles = item.Bottles;
            this.Discounts.AddRange(item.Discounts);
            this.AllQty.AddRange(item.AllQty);
        }
    }
}
 