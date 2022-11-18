
using System;
using System.Linq;

namespace Shared
{
    public class Item : BaseItem
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
                return $"{((Discount > 0) ? $" *{CalculatedDiscount:P0} OFF*" : "")} {string.Join(" ", Discounts.Where(x => x.Enabled && x.Active).Select(x => x.DiscountName))}";
            }
        }

        public double DiscountTotal
        {
            get
            {
                double price;
                if (DiscountPrice > 0)
                    price = (Price - DiscountPrice) * NumSold;
                else
                    price = (Price > 0) ? Price * NumSold * CalculatedDiscount : -Price;

                return Math.Round(price, 2, MidpointRounding.AwayFromZero);
            }
        }

        public double SubTotal
        {
            get
            {
                double price;

                if (DiscountPrice > 0) 
                    price = DiscountPrice * NumSold;
                else 
                    price = (Price > 0) ? Price * NumSold : 0;

                return Math.Round(price, 2, MidpointRounding.AwayFromZero);
            }
        }

        public double AdjustedTotal
        {
            get
            {
                double price;

                if (DiscountPrice > 0) 
                    price = DiscountPrice * NumSold;                
                else 
                    price = Price * NumSold * ((Price > 0) ? (1 - CalculatedDiscount) : 1);
                

                return Math.Round(price, 2, MidpointRounding.AwayFromZero);
            }
        }

        public uint NumSold
        {
            get
            {
                return QtySold - QtyRefunded;
            }
        }
        public uint QtySold { get; set; } = 0;
        public uint QtyRefunded { get; set; } = 0;
        public bool DecrementInventory { get; set; } = true;
        public double Discount { get; set; }
        public double CalculatedDiscount {
            get
            {
                return Math.Max(Discount, BulkDiscount);
            }
        }
        public double Coupon { get; set; }

        public Item() : base() { QtySold = 1; }
        public Item(BaseItem item) : base(item) { QtySold = 1; }

        public Item(string Name,
                    uint Id,
                    string Barcode,
                    uint Qty,
                    uint NumSold,
                    double Price,
                    double DiscountPrice,
                    bool NonTaxable,
                    string ItemType,
                    uint Bottles,
                    double Discount,
                    double Coupon) : base()
        {
            this.QtySold = NumSold;
            this.Barcode = Barcode;
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.DiscountPrice = DiscountPrice;
            this.NonTaxable = NonTaxable;
            this.ItemType = ItemType;
            this.Bottles = Bottles;
            this.Discount = Discount;
            this.Coupon = Coupon;
            AllQty.Add(new InventoryQty() { Qty = Qty });
        }
    }
}
