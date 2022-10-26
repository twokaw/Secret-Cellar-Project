﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace Shared
{

    public class Transaction
    {
        public enum TranactionType
        {
            Closed = 0,
            Suspended = 1,
            Invoice = 2,
            Hold = 3
        }

        public uint InvoiceID { get; set; }
        public uint RegisterID { get; set; }
        public TranactionType TranType { get; set; } = TranactionType.Closed;
        public DateTime TransactionDateTime { get; set; }
        public string Location { get; set; }
        public List<Item> Items { get; set; }
        public bool ChangetoCredit { get; set; }
        public double ItemTotal
        {
            get
            {
                double sub = 0;
                // All items with price * qty
                Items.ForEach(x => sub += x.SubTotal );

                return Math.Round(sub, 2, MidpointRounding.AwayFromZero);
            }
        }

        public double DiscountTotal
        {
            get
            {
                double sub = 0;

                // All items discounts + coupons

                // for each item with a positive value
                //  (item * num) * ItemDiscount + ((item * num) * (1 - ItemDiscount)) * transaction discount 
                // 
                //   Coupons are negative, to get the discount they will need to be negated to make them po

                Items.ForEach(x => sub += x.DiscountTotal + ((x.AdjustedTotal > 0) ? (x.AdjustedTotal * Discount) : 0));

                return Math.Round(sub, 2, MidpointRounding.AwayFromZero);
            }
        }

        public double LocalTax
        {
            get
            {
                double tax = 0;

                if (!TaxExempt)
                    Items.ForEach(x => tax += (!x.NonTaxableLocal ) ? ItemPrice(x) * x.LocalSalesTax : 0);
                return Math.Round(tax, 2, MidpointRounding.AwayFromZero);
            }
        }
        public double Bottle_deposit
        {
            get
            {
                double tax = 0;

                Items.ForEach(x => tax += x.Bottles * x.NumSold * x.BottleDeposit);

                return Math.Round(tax, 2, MidpointRounding.AwayFromZero);
            }
        }

        public double ItemPrice(Item i)
        {
            // Get item 
            return Math.Round(i.AdjustedTotal * ((i.AdjustedTotal > 0) ? (1 - Discount) : 1), 2, MidpointRounding.AwayFromZero);
        }

        public double ItemDiscount(Item i)
        {
            // Get item 
            return Math.Round((1 - i.Discount) * Discount + i.Discount, 2, MidpointRounding.AwayFromZero) ;
        }
        public double Subtotal
        {
            get
            {
                double value = 0;

                if (!TaxExempt)
                    Items.ForEach(x => value += ItemPrice(x));

                return Math.Round(value, 2, MidpointRounding.AwayFromZero);
            }
        }

        public double Tax
        {
            get
            {
                double tax = 0;

                if (!TaxExempt)
                    Items.ForEach(x => tax += ItemTax(x));

                return Math.Round(tax, 2, MidpointRounding.AwayFromZero);
            }
        }
        public double ItemTax(Item i)
        {
            if (!TaxExempt)
                return Math.Round((!i.NonTaxable) ? ItemPrice(i) * i.SalesTax : 0, 2, MidpointRounding.AwayFromZero);
            else
                return 0;
        }

        public double ItemLocalTax(Item i)
        {
            if (!TaxExempt)
                return Math.Round((!i.NonTaxable) ? ItemPrice(i) * i.LocalSalesTax : 0, 2, MidpointRounding.AwayFromZero);
            else
                return 0;
        }


        public double ItemPriceTotal(Item i)
        {
            return Math.Round(ItemTax(i) + ItemLocalTax(i) + ItemPrice(i) + i.BottleDeposit, 2, MidpointRounding.AwayFromZero);
        }

        public double Total
        {
            get
            {
                return Math.Round(Subtotal + Tax + LocalTax + Bottle_deposit + Shipping, 2, MidpointRounding.AwayFromZero);
            }
        }
        public bool TaxExempt { get; set; }
        public List<Payment> Payments { get; set; }
        public string PayMethod
        {
            get
            { 
                if (Payments != null && Payments.Count > 0)
                {
                    if (Payments.Exists(x => x.Method.ToUpper() == "CREDIT"))
                        return "CREDIT";

                    else if (Payments.Exists(x => x.Method.ToUpper() == "CHECK"))
                        return "CHECK";

                    else if (Payments.Exists(x => x.Method.ToUpper() == "GIFT"))
                        return "GIFT";

                    else if (Payments.Exists(x => x.Method.ToUpper() == "CUSTOMER CREDIT"))
                        return "CUSTOMER CREDIT";
                }
                return "CASH";
            }
        }
        public double AddPayment(Payment pay)
        {
            if (pay.Method != "CASH" && pay.Method != "CUSTOMER CREDIT" || Payments.FirstOrDefault(x => x.Method == pay.Method) == null)
                Payments.Add(pay);
            else
                Payments.First(x => x.Method == pay.Method).Amount += pay.Amount;

            double TotalPayment = 0;
            Payments.ForEach(x => TotalPayment += x.Amount);
            return Math.Round(TotalPayment, 2, MidpointRounding.AwayFromZero);
        }
        public string PayNum
        {
            get
            {
                string meth = PayMethod;

                if (meth != "CASH")
                    return Payments.Find(x => x.Method.ToUpper() == meth).Number;

                return "";
            }  // Credit card digits, check num, or nothing for cash
        }
        public double Discount { get; set; }
        public uint EmployeeID { get; set; }

        // Add the customer name from ID, if customer ID is 0 then the name is not in the database. 
        public string CustomerName { get; set; }
        public uint CustomerID { get; set; }
        public double Shipping { get; set; }
        
        // Default constructor
        public Transaction()
        {
            TransactionDateTime = DateTime.Now;
            InvoiceID  = 0;
            RegisterID = 1;
            Location   = "";
            Items      = new List<Item>();
            Payments = new List<Payment>();
            TaxExempt  = false;
            Discount = 0.0;
            
        }

        // Parameterized constructor
        public Transaction(uint InvoiceID,
                           uint RegisterID,
                           DateTime TransactionDateTime,
                           string Location,
                           List<Item> Items,
                           double Discount,
                           bool TaxExempt,
                           List<Payment> Payments,
                           uint EmployeeID,
                           uint CustomerID)
        {
            this.InvoiceID  = InvoiceID;
            this.RegisterID = RegisterID;
            this.TransactionDateTime = TransactionDateTime;
            this.Location   = Location;
            this.Items      = Items;
            this.Discount   = Discount;
            this.TaxExempt  = TaxExempt;
            this.Payments   = Payments;
            this.EmployeeID = EmployeeID;
            this.CustomerID = CustomerID;
        }

        public List<Discount> GetBulkDiscounts()
        {
            List<Discount> d = new List<Discount>();

            // NOTE: get all Discounts!
            foreach (Item i in Items)
                foreach (Discount dat in i.Discounts)
                    if (d.FirstOrDefault(x => x.DiscountID == dat.DiscountID) == null)
                        d.Add(dat);

            return d;
        }

        public List<Discount> GetQualifiedBulkDiscounts()
        {
            List<Discount> result = new List<Discount>();

            int count = 0;
            foreach (Discount dis in GetBulkDiscounts().Where(x => x.Enabled))
            {
                count = Items.Count(i => i.Discounts.Any(x => x.DiscountID == dis.DiscountID) && i.Discount == 0.0);
                if (count >= dis.Min && count <= dis.Max)
                {
                    result.Add(dis);
                }
            }

            return result;
        }

        public void EnableBulkDiscount(Discount discount, bool enabled)
        {
            foreach (Item i in Items)
                foreach (Discount x in i.Discounts)
                    if (x.DiscountID == discount.DiscountID)
                        x.Enabled = enabled;
        }
        public void EnableBulkDiscount(bool enabled)
        {
            foreach (Item i in Items)
                foreach (Discount x in i.Discounts)
                    x.Enabled = enabled;
        }



        public void Add(Item item)
        {
            Item i = Items.FirstOrDefault(x => x.Id == item.Id && x.Price == item.Price);

            if (i == null)
                Items.Add(item);
            else
            {
                i.QtySold += item.QtySold;
                i.QtyRefunded += item.QtyRefunded;
            }

            GetQualifiedBulkDiscounts();
        }

        public void Add(Inventory inv) { Add(ConvertInvtoItem(inv)); }

        public bool ChangeItemQty(Inventory inv, uint qty) { return ChangeItemQty(ConvertInvtoItem(inv), qty); }

        public bool ChangeItemQty(Item item, uint qty)
        {
            bool result = false;
            Item i = Items.FirstOrDefault(x => x.Barcode == item.Barcode);

            if (qty == 0)
            {
                if (i != null)
                {
                    Items.Remove(i);
                    result = true;
                }
            }
            else
            {
                if (i != null && i.NumSold != qty)
                {
                    i.QtySold = qty;
                    result = true;
                }
                else if (i == null)
                {
                    i =item;
                    if (i != null)
                    {
                        i.QtySold = qty;
                        Items.Add(i);
                        result = true;
                    }
                    else
                        throw new Exception("Barcode not in the database");
                }
            }
            return result;
        }

        public static Item ConvertInvtoItem(Inventory inv)
        {
            return new Item
            {
                Name = inv.Name,
                Id = inv.Id,
                Barcode = inv.Barcode,
                AllQty = inv.AllQty,
                BottleDeposit = inv.BottleDeposit,
                QtySold = 1,
                Price = inv.Price,
                DiscountPrice = inv.DiscountPrice,
                NonTaxable = inv.NonTaxable,
                ItemType = inv.ItemType,
                Bottles = inv.Bottles,
                SalesTax = inv.SalesTax,
                LocalSalesTax = inv.LocalSalesTax,
                IdTax = inv.IdTax,
                NonTaxableLocal = inv.NonTaxableLocal,
                Discounts = inv.Discounts
            };
        }

        public static Item ConvertInvtoItem(Inventory inv, uint numSold) {
            return new Item {
                Name = inv.Name,
                Id = inv.Id,
                Barcode = inv.Barcode,
                AllQty = inv.AllQty,
                BottleDeposit = inv.BottleDeposit,
                QtySold = numSold,
                Price = inv.Price,
                DiscountPrice = inv.DiscountPrice,
                NonTaxable = inv.NonTaxable,
                ItemType = inv.ItemType,
                Bottles = inv.Bottles,
                SalesTax = inv.SalesTax,
                LocalSalesTax = inv.LocalSalesTax,
                IdTax = inv.IdTax,
                NonTaxableLocal = inv.NonTaxableLocal,
                Discounts = inv.Discounts
            };
        }

        public static Item ConvertInvtoItem(CustomerOrderItem inv)
        {
            return new Item
            {
                Name = inv.Name,
                Id = inv.Id,
                Barcode = inv.Barcode,
                AllQty = inv.AllQty,
                BottleDeposit = inv.BottleDeposit,
                QtySold = inv.DeliverQty,
                Price = inv.Price,
                DiscountPrice = inv.DiscountPrice,
                NonTaxable = inv.NonTaxable,
                ItemType = inv.ItemType,
                Bottles = inv.Bottles,
                SalesTax = inv.SalesTax,
                LocalSalesTax = inv.LocalSalesTax,
                IdTax = inv.IdTax,
                NonTaxableLocal = inv.NonTaxableLocal,
                Discounts = inv.Discounts
            };
        }
    }
}
