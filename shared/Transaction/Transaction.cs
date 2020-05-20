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
        public double Subtotal { get; set; }
        public double LocalTax { get; set; }
        public double Tax { get; set; }
        public double Total { get; set; }
        public bool TaxExempt { get; set; }
        public string PayMethod { get; set; }
        public string PayNum { get; set; }  // Credit card digits, check num, or nothing for cash
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
            Subtotal   = 0.0;
            Tax        = 0.0;
            Total      = 0.0;
            TaxExempt  = false;
            PayMethod  = "";
            PayNum     = "";
            Discount = 0.0;
            
        }

        // Parameterized constructor
        public Transaction(uint InvoiceID,
                           uint RegisterID,
                           DateTime TransactionDateTime,
                           string Location,
                           List<Item> Items,
                           double Discount,
                           double Subtotal,
                           double Tax,
                           double Total,
                           bool TaxExempt,
                           string PayMethod,
                           string PayNum,
                           double LocalTax,
                           uint EmployeeID,
                           uint CustomerID)
        {
            this.InvoiceID  = InvoiceID;
            this.RegisterID = RegisterID;
            this.TransactionDateTime = TransactionDateTime;
            this.Location   = Location;
            this.Items      = Items;
            this.Discount   = Discount; // Will this be applied before or after subtotal is calculated?
            this.Subtotal   = Subtotal;
            this.Tax        = Tax;
            this.Total      = Total;
            this.TaxExempt  = TaxExempt;
            this.PayMethod  = PayMethod;
            this.PayNum     = PayNum;
            this.LocalTax = LocalTax;
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
            Discount = (double)info.GetValue("double", typeof(double));
            Subtotal = (double)info.GetValue("Subtotal", typeof(double));
            Tax = (double)info.GetValue("Tax", typeof(double));
            Total = (double)info.GetValue("Total", typeof(double));
            TaxExempt = (bool)info.GetValue("TaxExempt", typeof(bool));
            PayMethod = (string)info.GetValue("PayMethod", typeof(string));
            PayNum = (string)info.GetValue("PayNum", typeof(string));
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
            info.AddValue("Tax", Tax);
            info.AddValue("Total", Total);
            info.AddValue("TaxExempt", TaxExempt);
            info.AddValue("PayMethod", PayMethod);
            info.AddValue("PayNum", PayNum);
        }
    }
}
