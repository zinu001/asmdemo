using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace demoweb.Models
{
    //Brand - Mobile : 1 to Many
    //Brand - Country : Many to 1
    public class Brand
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }
        
        public ICollection<Mobile> Mobiles { get; set; }

        [Required]
        [Display(Name = "Country Name")]
        public int CountryId { get; set; }
        
        public Country Country { get; set; }
    }
}
