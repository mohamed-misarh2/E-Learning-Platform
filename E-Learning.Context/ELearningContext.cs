using E_Learning.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E_Learning.Context
{
    public class ELearningContext: IdentityDbContext<User>
    {

        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderCourse> OrderCourses { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Topic> Topics { get; set; }

        public ELearningContext(DbContextOptions<ELearningContext> options) :base(options)
        { }

    }
}
