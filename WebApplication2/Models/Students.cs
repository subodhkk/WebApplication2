using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Students
    {
        [Key]
        [ScaffoldColumn(false)]
        public int RollNo { get; set; }


        [Display(Name ="Student Name")]
        [Required(ErrorMessage ="Name Is required")]
        public string Name { get; set; }


        [Required(ErrorMessage ="Age is required")]
        [Range(18,60,ErrorMessage ="Age should be between 18 t0 60")]
        public int Age { get; set; }


        [Required(ErrorMessage ="Email is required")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Not in correct format")]
        public string EmailId { get; set; }


        [Required(ErrorMessage = "City is required")]
        [MaxLength(20)]
        public string City { get; set; }


        [Required(ErrorMessage ="Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
