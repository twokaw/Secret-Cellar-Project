using System;

namespace Shared
{
    public class CustomerNote: NoteType
    {
        public uint IdCustomer { get; set; }
        public uint IdNote { get; set; }
        public string Note { get; set; }
        public DateTime NoteDate { get; set; }

    }
}
