using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_02.Data.Model
{
    internal class CourseInstructor
    {

        [Key]
        public int Inst_ID { get; set; }
        public Instructor Instructor { get; set; }

        [Key]
        public int Course_ID { get; set; }
        public Course Course { get; set; }

        public string Evaluate { get; set; }
    }
}
