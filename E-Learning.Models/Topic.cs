using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning.Models
{
    public class Topic : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; }

        public Topic()
        {
            Courses = new List<Course>();
        }
    }
}
