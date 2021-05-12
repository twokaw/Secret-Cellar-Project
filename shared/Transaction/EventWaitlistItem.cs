using System;

namespace Shared
{
    public class EventWaitlistItem
    {
        public int EventId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime DateAdded { get; set; }


        public EventWaitlistItem() {
            EventId = -1;
            CustomerId = -1;
            CustomerName = "";
            DateAdded = new DateTime(0001, 01, 01);
        }

        public EventWaitlistItem(int eventId, int customerId, string customerName, DateTime dateAdded) {
            EventId = eventId;
            CustomerId = customerId;
            CustomerName = customerName;
            DateAdded = dateAdded;
		}
    }
}
