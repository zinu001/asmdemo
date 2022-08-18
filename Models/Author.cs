using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace asm2.Models
{
    //Author - Book: 1 to Many
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }

        public ICollection<CategoryAuthor> CategoryAuthors { get; set; }

    }
}