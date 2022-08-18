using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace asmdemo.Models
{
    // Category - Book: 1 to many
    // Category - Author: many to many
    public class Category
    {
        public int Id { get; set; }
        [MinLength(3, ErrorMessage = "Category name must be at least 3 character")]
        [MaxLength(15)]
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Book> Books { get; set; }

        public ICollection<Author> Authors { get; set; }

        public ICollection<CategoryAuthor> CategoryAuthors { get; set; }
        public object Authors { get; internal set; }
    }
}
