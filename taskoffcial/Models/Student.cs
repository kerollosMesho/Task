using System.ComponentModel.DataAnnotations;

namespace taskoffcial.Models
{
    public class Student
    {
        [Key]
        [Display(Name = "ID")]
        public int StudentID { get; set; }

        [Required]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Birth date")]
        [DataType(DataType.Date)]
        public DateTime? birthDay { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        public ICollection<StudentSubject> StudentSubjects { get; set; } = new List<StudentSubject>();

    }
}
