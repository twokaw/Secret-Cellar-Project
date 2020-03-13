using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Models
{
    public class Supplier : ISerializable
    {
        public string Name;
        public string PhoneNumber;

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("PhoneNumber", PhoneNumber);
        }
    }
}
