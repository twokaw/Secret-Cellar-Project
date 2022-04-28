
namespace Shared
{
    public class EmployeeModel
    {
        public uint EmpID { get; set; }
        public uint PinNumber { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public EmployeeTypeModel EmployeeType { get; set; } 
    }
}