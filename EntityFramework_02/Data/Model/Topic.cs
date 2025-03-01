using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_02.Data.Model
{
    internal class Topic
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
