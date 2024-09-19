using Microsoft.EntityFrameworkCore;
using taskoffcial.Models;

namespace taskoffcial.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().ToTable(nameof(Student));        

        }
        public DbSet<Student> students { get; set; }    

    }
}
