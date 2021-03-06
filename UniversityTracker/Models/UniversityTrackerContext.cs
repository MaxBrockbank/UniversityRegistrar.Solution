using Microsoft.EntityFrameworkCore;

namespace UniversityTracker.Models
{
  public class UniversityTrackerContext : DbContext
  {
    public virtual DbSet<Student> Students {get; set;}
    public DbSet<Course> Courses { get; set;  }
    public DbSet<Enrollment> Enrollment { get; set; }

    public UniversityTrackerContext(DbContextOptions options) : base(options) { }
  }
}