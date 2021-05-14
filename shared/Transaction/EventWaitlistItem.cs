using System;

namespace Shared
{
    public class EventWaitlistItem
    {
        public uint EventId { get; set; }
        public uint CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime DateAdded { get; set; }


        public EventWaitlistItem() {
            EventId = 0;
            CustomerId = 0;
            CustomerName = "";
            DateAdded = new DateTime(0001, 01, 01);
        }

        public EventWaitlistItem(uint eventId, uint customerId, string customerName, DateTime dateAdded) {
            EventId = eventId;
            CustomerId = customerId;
            CustomerName = customerName;
            DateAdded = dateAdded;
		}
    }
}
