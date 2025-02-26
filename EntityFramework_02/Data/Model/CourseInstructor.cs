using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_02.Data.Model
{
    internal class CourseInstructor
    {
        public int InstructorId { get; set; }
        public int CourseId { get; set; }

        public string Evaluate { get; set; }
    }
}
