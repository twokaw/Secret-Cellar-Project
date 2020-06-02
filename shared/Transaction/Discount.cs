
namespace Shared
{
    public class Discount
    {
        public uint DiscountID { get; set; }
        public string DiscountName { get; set; }
        public uint Min { get; set; }
        public uint Max { get; set; }
        public double Amount { get; set; }
        public bool Enabled { get; set; }
        public Discount()
        {
            Enabled = false;
        }
    }
}
