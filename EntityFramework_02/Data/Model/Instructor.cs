using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_02.Data.Model
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public decimal HourRate { get; set; }

        public Department Department { get; set; }

        public int DepartmentId { get; set; }

        public ICollection<CourseInstructor> CourseInstructors { get; set; }


    }
}
