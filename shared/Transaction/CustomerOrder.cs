using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class CustomerOrderItems : BaseItem
    {
        public uint CustomerOrderItemID;
        public uint OrderQty;
        public uint DeliverQty;
        public DateTime DeliverDate;
    }

    public class CustomerOrder : BaseCustomer
    {
        public uint CustomerOrderID;
        public List<CustomerOrderItems> Items;
        public string OrderNote;
        public DateTime DeliveryDate;
        public DateTime RequestDate;
        public double PaidAmount;
        public CustomerOrder() : base() { Items = new List<CustomerOrderItems>(); }
    }
}
