using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace asmdemo.Models
{
    //Author - Book: 1 to Many
    //Author - Category: Many to one
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }

        [Required]
        [Display(Name = "Category Name")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }




    }
}