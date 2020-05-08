namespace WebApi.Entities
{
    public class User
    {

        public uint EmployeeID { get; set; }
        public uint Pin { get; set; }
        public bool IsAdmin { get; set; }
        public string Token { get; set; }
    }
}
