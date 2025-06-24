using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicomtic_manegment_system.model
{
    internal class Course
    {
        public int Courseid { get; set; }         // Unique course ID entered by user
        public string CourseName { get; set; }    // Course name
        public string subjectName { get; set; }   // Subject name
    }
}
