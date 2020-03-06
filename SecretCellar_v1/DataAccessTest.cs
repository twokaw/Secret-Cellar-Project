using SecretCellar.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretCellar
{
    public class DataAccessTest: IDataAccess
    {
        public User GetUser(int pin)
        {
            User user;
            if (pin == 0)
                return new User()
                {
                    pin = pin,
                    FirstName = "Generic"
                };
            else if (pin == 123)
            {
                user = new User()
                {
                    pin = pin,
                    FirstName = "Admin"
                };
            }
            else if (pin == 456)
            {
                user = new User();
                user.pin = pin;
                user.FirstName = "Manager";
            }
            else
                user = null;

            return user;
        }
    }
}
