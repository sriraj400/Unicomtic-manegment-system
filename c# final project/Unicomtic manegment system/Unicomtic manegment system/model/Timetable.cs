using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicomtic_manegment_system.model
{
    internal class Timetable
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public string Session { get; set; }
        public string Lab { get; set; }
        public string Subject { get; set; }
    }
}
