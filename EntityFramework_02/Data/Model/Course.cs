using System;
using System.Collections.Generic;
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
    }
}
