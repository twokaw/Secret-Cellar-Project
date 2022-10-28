
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shared
{
    public class CustomerOrderItem: BaseItem
    {
        public uint CustomerOrderItemID { get; set; }
        public DateTime RequestDate { get; set; }
        public uint DeliverQty { get; set; }
        public DateTime DeliverDate { get; set; }
        public double Paid { get; set; }
        public DateTime PaidDate { get; set; }
    }

    public class CustomerOrder : BaseCustomer
    {
        public List<CustomerOrderItem> Items { get; set; }
        public string OrderNote { get; set; }
        public DateTime DeliveryDate { get { return (Items.Count > 0) ? Items.Max(i => i.DeliverDate) : new DateTime(); } }
        public DateTime RequestDate { get { return (Items.Count > 0) ? Items.Min(i => i.RequestDate) : new DateTime(); } }
        public double UnpaidAmount { get { return Math.Round(Items.Sum(i => i.RequestQty * i.Price - i.Paid), 2, MidpointRounding.AwayFromZero); } }
        public double InvoiceAmount { get { return Math.Round(Items.Sum(i => i.RequestQty * i.Price), 2, MidpointRounding.AwayFromZero); } }
        public double PaidAmount { get { return Math.Round(Items.Sum(i => i.Paid), 2, MidpointRounding.AwayFromZero); } }
        public DateTime PaidDate { get { return (Items.Count > 0) ? Items.Max(i => i.PaidDate) : new DateTime(); } }
        public CustomerOrder() : base() { Items = new List<CustomerOrderItem>(); }
    }
}
