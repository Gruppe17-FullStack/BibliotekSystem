using System.ComponentModel.DataAnnotations;

namespace BibliotekSystem.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tittel er påkrevd")]
        [StringLength(100)]
        public string Title { get; set; }

        [Required(ErrorMessage = "ISBN er påkrevd")]
        public string ISBN { get; set; }

        public int PublishedYear { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}