using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Book
    {
        [Key]
        [ScaffoldColumn(false)]
        [Required(ErrorMessage ="Id is required")]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Author Name is required")]
        [MaxLength(20)]
        public string AuthorName { get; set; }

        [Required(ErrorMessage = "Publisher Name is required")]
        [MaxLength(20)]
        public string PublisherName { get; set; }

        [Required(ErrorMessage ="Date is required")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }

        [Required(ErrorMessage ="Price is required")]
        [Range(100,500,ErrorMessage ="Between 100 to 500")]
        public int Price { get; set; }

        [Required(ErrorMessage ="Date is required")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }



    }
}
