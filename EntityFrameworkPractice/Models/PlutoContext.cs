using System.Data.Entity;
using System.Data.Entity.Core.Objects;

namespace EntityFrameworkPractice.Models
{
    public class PlutoContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public PlutoContext() : base("name=PlutoDBConnection")
        {
            
        }

    }
}