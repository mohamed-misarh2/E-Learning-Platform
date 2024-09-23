using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning.Models
{
    public class Course : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? CourseImage { get; set; }
        public string? PromotionalVideo { get; set; }
        public decimal RatingAverage { get; set; } = 0;
        public int RatingCount { get; set; } = 0;
        public int EnrollmentsCount { get; set; } = 0;


        // Foreign Keys
        public int UserId { get; set; }
        public User Instructor { get; set; }

        public int TopicId { get; set; }
        public Topic Topic { get; set; }



        // Relationships
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
