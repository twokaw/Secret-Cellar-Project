using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Shared
{
    [Serializable]
    public class Transaction : ISerializable
    {
        // Define properties. The way I set them up, we can add accessors later.
        public uint InvoiceID { get; set; }
        public uint RegisterID { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public string Location { get; set; }
        public List<Item> Items { get; set; }
        public double Subtotal
        {
            get
            {
                double sub = 0;

                Items.ForEach(x => sub += x.Price * x.NumSold);

                return sub * (1 - Discount);
            }
        }
        public double LocalTax
        {
            get
            {
                double tax = 0;

                if (!TaxExempt)
                    Items.ForEach(x => tax += (x.NonTaxableLocal && x.Price > 0) ? x.Price * x.Discount * x.NumSold * (1 + x.local_sales_tax) : 0);

                return tax;
            }
        }
        public double Bottle_deposit
        {
            get
            {
                double tax = 0;

                Items.ForEach(x => tax += x.Bottles * x.NumSold * x.bottle_deposit);

                return tax;
            }
        }
        public double Tax
        {
            get
            {
                double tax = 0;

                if (!TaxExempt)
                    Items.ForEach(x => tax += (x.NonTaxable && x.Price > 0) ? x.Price * x.Discount * x.NumSold * (1 + x.sales_tax) : 0);

                return tax;
            }
        }
        public double Total
        {
            get
            {
                return Subtotal + Tax + LocalTax + Bottle_deposit ;
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
                }
                return "CASH";
            }
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
        public uint CustomerID { get; set; }

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

        // Deserialization constructor
        public Transaction(SerializationInfo info, StreamingContext ctxt)
        {
            InvoiceID = (uint)info.GetValue("InvoiceID", typeof(uint));
            RegisterID = (uint)info.GetValue("RegisterID", typeof(uint));
            TransactionDateTime = (DateTime)info.GetValue("TransactionDateTime", typeof(DateTime));
            Location = (string)info.GetValue("Location", typeof(string));
            Items = (List<Item>)info.GetValue("Items", typeof(List<Item>));
            Payments = (List<Payment>)info.GetValue("Payments", typeof(List<Payment>));
            Discount = (double)info.GetValue("double", typeof(double));
            TaxExempt = (bool)info.GetValue("TaxExempt", typeof(bool));
        }
        
        // Serialization method
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("InvoiceID", InvoiceID);
            info.AddValue("RegisterID", RegisterID);
            info.AddValue("TransactionDateTime", TransactionDateTime);
            info.AddValue("Location", Location);
            info.AddValue("Items", Items);
            info.AddValue("Discount", Discount);
            info.AddValue("Subtotal", Subtotal);
            info.AddValue("Payments", Payments);
            info.AddValue("Tax", Tax);
            info.AddValue("Total", Total);
            info.AddValue("TaxExempt", TaxExempt);
            info.AddValue("PayMethod", PayMethod);
            info.AddValue("PayNum", PayNum);
        }
    }
}
