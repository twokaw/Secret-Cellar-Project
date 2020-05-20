using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Item: BaseItem
    {

        public uint NumSold { get; set; }
        public double Discount { get; set; }
        public double Coupon { get; set; }

        public Item():base() { }

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
            this.Qty = Qty;
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
        }
    }
}
