using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BibliotekSystem.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Navn er påkrevd")]
        [Display(Name = "Forfatternavn")]
        public string Name { get; set; } = string.Empty;

        public List<Book> Books { get; set; } = new List<Book>();
    }
}