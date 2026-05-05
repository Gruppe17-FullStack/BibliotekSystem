using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BibliotekSystem.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Navn er påkrevd")]
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}