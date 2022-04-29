using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class EmployeeTypeModel
    {
        public uint TypeID { get; set; }
        public string TypeName { get; set; }
        public List<EmployeeRoleModel> Roles { get; set; } = new List<EmployeeRoleModel>();
    }
    public class EmployeeRoleModel
    {
        public uint RoleID { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
    }
}
