using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Learning.Models
{
    public class Order : BaseEntity
    {
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public string Status { get; set; } = "pending";
        public string PaymentMethod { get; set; } = string.Empty;
        public string? TransactionId { get; set; }
        public string? PaymentProcessor { get; set; }

        // Foreign Key
        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<OrderCourse> OrderCourses { get; set; } = new List<OrderCourse>();
    }
}
