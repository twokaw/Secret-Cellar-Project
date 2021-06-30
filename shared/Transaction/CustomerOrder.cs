
using System;
using System.Collections.Generic;

namespace Shared
{
    public class CustomerOrderItem: BaseItem
    {
        public uint CustomerOrderItemID { get; set; }
        public uint OrderQty { get; set; }
        public uint DeliverQty { get; set; }
        public DateTime DeliverDate { get; set; }
    }

    public class CustomerOrder : BaseCustomer
    {
        public uint CustomerOrderID { get; set; }
        public List<CustomerOrderItem> Items { get; set; }
        public string OrderNote { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime RequestDate { get; set; }
        public double InvoiceAmount { get; set; }
        public double PaidAmount { get; set; }
        public DateTime PaidDate { get; set; }
        public CustomerOrder() : base() { Items = new List<CustomerOrderItem>(); }
    }
}
