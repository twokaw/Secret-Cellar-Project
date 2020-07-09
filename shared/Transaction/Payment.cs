namespace Shared
{
    public class Payment
    {
        public uint   PayId { get; set; }
        public string Method { get; set; }
        public string Number { get; set; }
        public double Amount { get; set; }
    }
}
