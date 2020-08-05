using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Event: BaseItem
    {
        public Double PreOrder { get; set; }
        public Double AtDoor { get; set; }
        public DateTime Duration { get; set; }
        public DateTime EventDate { get; set; }
    }
}
