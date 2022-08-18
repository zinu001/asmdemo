namespace asmdemo.Models
{
    public class CategoryAuthor
    {
        public int CategoryId { get; set; }

        public int AuthorId { get; set; }

        public Category Category { get; set; }

        public Author Author { get; set; }
    }
}


