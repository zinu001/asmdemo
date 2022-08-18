using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace demoweb.Models
{
    //Country - Brand: 1 to Many
    public class Country
    {
        public int Id { get; set; }
        
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        
        public ICollection<Brand> Brands { get; set; }
    }
}
