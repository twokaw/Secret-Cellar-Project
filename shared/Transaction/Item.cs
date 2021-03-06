﻿
using System.Linq;

namespace Shared
{
    public class Item: BaseItem
    {

        public string Description
        {
            get
            {
                return $"{Name}{DiscountText}";
            }
        }

        public string DiscountText
        {
            get
            {
                return $"{((Discount > 0) ? $" *{Discount:P0} OFF*" : "")} {string.Join(" ", Discounts.Where(x => x.Enabled).Select(x => x.DiscountName))}";
            }
        }

        public double DiscountTotal
        {
            get
            {
                return (Price > 0) ? Price * NumSold * Discount : -Price;
            }
        }

        public double SubTotal
        {
            get
            {
                return (Price > 0) ? Price * NumSold : 0;
            }
        }
         
        public double AdjustedTotal
        {
            get
            {
                return Price * NumSold * ((Price > 0) ? (1 - Discount)  : 1);
            }
        }

        public uint NumSold { get; set; } 
        public double Discount { get; set; }
        public double Coupon { get; set; }

        public Item():base() { NumSold = 1; }

        public Item(string Name,
                    uint Id,
                    string Barcode,
                    uint Qty,
                    uint NumSold,
                    double Price,
                    bool NonTaxable,
                    string ItemType,
                    uint Bottles,
                    double Discount,
                    double Coupon) : base()
        {
            this.NumSold = NumSold;
            this.Barcode = Barcode;
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.NonTaxable = NonTaxable;
            this.ItemType = ItemType;
            this.Bottles = Bottles;
            this.Discount = Discount;
            this.Coupon = Coupon;
            AllQty.Add(new InventoryQty() { Qty = Qty });
        }
    }
}
