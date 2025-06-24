using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicomtic_manegment_system.model
{
    internal class Loginadmin
    {
        
        public string UserName { get; set; }
        public string Password { get; set; }

        public Loginadmin() { }

        public Loginadmin( string userName, string password)
        {
           
            UserName = userName;
            Password = password;
        }
    }
}
