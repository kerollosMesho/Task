using System.ComponentModel.DataAnnotations;

namespace taskoffcial.Models
{
    public class Student
    {
        [Key]
        [Display(Name ="ID")]
        public int? StudentID { get; set; }

        [Required]
        [Display (Name ="stdName")]
        public String StudentName { get; set; }
        
        [Required]
        [Display (Name ="em")]
        public String Email { get; set; }

     [Display (Name ="Birth date")]
        [DataType(DataType.Date)]
        public DateTime? birthDay { get; set; }
       
       [Required]
        [Display (Name ="AD")]
        public string  Adress { get; set; }

       /* [Required]
        [Display(Name = "sub")]
        public string Subject { get; set; }*/
    }
}
