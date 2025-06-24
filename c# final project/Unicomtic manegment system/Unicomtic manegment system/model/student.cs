using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicomtic_manegment_system.model
{
   
        public class Student
        {
            public int UTNumber { get; set; }
            public string StudentName { get; set; }
            public string DateBirth { get; set; } // format: "YYYY-MM-DD"
            public string NIC { get; set; }
            public string Coursename { get; set; }
        }
    }

