using System.ComponentModel.DataAnnotations;

namespace taskoffcial.Models
{
    public class Subject
    {
        public int SubjectID { get; set; }

        [Required]
        public string SubjectName { get; set; }

        // Navigation property for many-to-many relationship
        public ICollection<StudentSubject> StudentSubjects { get; set; } = new List<StudentSubject>();
    }
}
