
namespace Shared
{
    public class Discount
    {
        public uint DiscountID { get; set; }
        public string DiscountName { get; set; }
        public uint Min { get; set; }
        public uint Max { get; set; }
        public double Amount { get; set; }

        // Determines if the transaction allows this dicount
        public bool Enabled { get; set; } = false;

        // Determines if it is currently active.  
        public bool Active { get; set; } = false;
    }
}
