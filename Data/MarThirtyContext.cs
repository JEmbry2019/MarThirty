using MarThirty.Models;
using Microsoft.EntityFrameworkCore;

namespace MarThirty.Data
{
    //Creates a new database context named StudentInformationContext
    public class MarThirtyContext : DbContext
    {
        public MarThirtyContext(DbContextOptions<MarThirtyContext> options) : base(options)
        {
        }

        //This is where we register our models as entities
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Camper> Campers { get; set; }
    }
}