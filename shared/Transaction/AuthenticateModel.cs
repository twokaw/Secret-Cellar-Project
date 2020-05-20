using System.ComponentModel.DataAnnotations;

namespace Shared
{
    public class AuthenticateModel
    {
        [Required]
        public uint EmployeeID { get; set; }

        [Required]
        public uint Pin { get; set; }
    }
}