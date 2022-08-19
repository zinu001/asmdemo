using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace asmdemo.Models
{
    //Book - Category : Many to One
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Book name must be at least 3 characters")]
        [MaxLength(30)]
        public string Name { get; set; }


        [Required]
        [Range(1, 100)]
        public int Quantity { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public string Description { get; set; }

        public Category Category { get; set; }

        [Required]
        [Display(Name = "Category name")]
        public int CategoryId { get; set; }


        //Book - Order: 1 to Many
        public ICollection<Order> Orders { get; set; }

        //Book - Author: Many to one
        public Author Author { get; set; }

        [Required]
        [Display(Name = "Author name")]
        public int AuthorId { get; set; }
    }
}