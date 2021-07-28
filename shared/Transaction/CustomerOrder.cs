
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shared
{
    public class CustomerOrderItem: BaseItem
    {
        public uint CustomerOrderItemID { get; set; }
        public uint RequestQty { get; set; }
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
        public DateTime DeliveryDate { get { return Items.Max(i => i.DeliverDate); } }
        public DateTime RequestDate { get { return Items.Min(i => i.RequestDate); } }
        public double UnpaidAmount { get { return Items.Sum(i => i.RequestQty * i.Price - i.Paid); } }
        public double InvoiceAmount { get { return Items.Sum(i => i.RequestQty * i.Price); } }
        public double PaidAmount { get { return Items.Sum(i => i.Paid); } }
        public DateTime PaidDate { get { return Items.Max(i => i.PaidDate); } }
        public CustomerOrder() : base() { Items = new List<CustomerOrderItem>(); }
    }
}
