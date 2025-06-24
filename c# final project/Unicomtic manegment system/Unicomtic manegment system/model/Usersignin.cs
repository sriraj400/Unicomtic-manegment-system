using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicomtic_manegment_system.model
{
    internal class Usersignin
    {
      
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string Phone_no { get; set; }
        public string NIC_no { get; set; }

        // Image stored as byte[] for saving in DB
        public byte[] UserImage { get; set; }
    }
}
