using System;
using System.ComponentModel.DataAnnotations;

namespace asmdemo.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int BookId { get; set; } // connect to Book table

        public Book Book { get; set; } // get data in book table

        public string CustomerEmail { get; set; }
        [Required]
        public int OrderQuantity { get; set; }
        [Required]
        public double OrderPrice { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime OrderDate { get; set; }

    }
}
