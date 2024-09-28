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
            modelBuilder.Entity<Subject>().HasData(
                new Subject { SubjectID = 1, SubjectName = "Arabic" },
                new Subject { SubjectID = 2, SubjectName = "English" },
                new Subject { SubjectID = 3, SubjectName = "Math" },
                new Subject { SubjectID = 4, SubjectName = "Science" },
                new Subject { SubjectID = 5, SubjectName = "History" }
                );

            modelBuilder.Entity<StudentSubject>()
              .HasKey(ss => new { ss.StudentID, ss.SubjectID });

            modelBuilder.Entity<StudentSubject>()
                .HasOne(ss => ss.Student)
                .WithMany(s => s.StudentSubjects)
                .HasForeignKey(ss => ss.StudentID);

            modelBuilder.Entity<StudentSubject>()
                .HasOne(ss => ss.Subject)
                .WithMany(s => s.StudentSubjects)
                .HasForeignKey(ss => ss.SubjectID);
                  

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }

    }
}
