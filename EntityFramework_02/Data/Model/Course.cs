using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_02.Data.Model
{
    internal class Course
    {
        public int Id { get; set; }
        public  required string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }

        public int TopicId { get; set; }
        public Topic Topic { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
        public ICollection<CourseInstructor> CourseInstructors { get; set; }

    }
}
