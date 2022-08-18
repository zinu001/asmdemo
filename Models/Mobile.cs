using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace demoweb.Models
{
    public enum Color
    {
        Black,
        White,
        Grey,
        Yellow,
        Blue
    }
    //Mobile - Brand : Many to One
    public class Mobile
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Mobile name must be at least 3 characters")]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [Range(1, 100)]
        public int Quantity { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public Color Color { get; set; }

        [Required]
        [Url]
        public string Image { get; set; }

        public Brand Brand { get; set; }
        
        [Required]
        [Display(Name = "Brand name")]
        public int BrandId { get; set; }

        //Mobile - Order: 1 to Many
        public ICollection<Order> Orders { get; set; }
    }
}
