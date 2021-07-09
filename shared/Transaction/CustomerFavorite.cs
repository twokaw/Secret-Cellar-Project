using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class CustomerFavorite
    {
        public uint InventoryID { get; set; }
        public DateTime Lastused { get; set; }
    }

    public class CustomerFavorites
    {
        public uint CustomerID { get; set; }
        public List<CustomerFavorite> Favorites { get; set; } = new List<CustomerFavorite>();
    }
}
