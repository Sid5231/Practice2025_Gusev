using Microsoft.EntityFrameworkCore;
using Practice2025_Gusev.Models;

namespace Practice2025_Gusev


{
    public class Practice2025Context : DbContext
    {
        public Practice2025Context(DbContextOptions<Practice2025Context> options) 
            : base(options) 
        {
            
        }
        public DbSet<Group> groups { get; set; }
        public DbSet<Institute> institutes { get; set; }
        public DbSet<Specialty> specialties { get; set; }
        public DbSet<Student> students { get; set; }

    }
}
