using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning.Models
{
    public class OrderCourse:BaseEntity
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
