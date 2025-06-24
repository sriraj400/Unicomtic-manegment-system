using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicomtic_manegment_system.model
{
    public class Exame
    {
     
        public int UtNumber { get; set; }         // UT number
        public int ExameId { get; set; }          // Unique exam ID
        public string ExameDate { get; set; }     // Exam date (format: yyyy-MM-dd)
        public string SubjectName { get; set; }
        public string CourseName { get; set; } // Subject name
        public int Marks { get; set; }
    }
}
