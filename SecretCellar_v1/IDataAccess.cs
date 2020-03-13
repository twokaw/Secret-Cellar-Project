using SecretCellar.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretCellar
{
    public interface IDataAccess
    {
        User GetUser(int pin);
    }
}
