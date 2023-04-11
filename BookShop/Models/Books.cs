using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace BookShop.Models
{
    [Table("Book")]
    public class Books 
    {

        public int Id { get; set; }

        [Required]
        [MaxLength()]
        public string? BookName { get; set; }
        [Required]
        [MaxLength()]
        public string? AuthorName { get; set; }

        [Required]

        
        public double Price { get; set; }
        public string? Image { get; set; }

        [Required]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public List<OrderDetail> OrderDetail { get; set; }

        public List<CartDetail> CartDetail { get; set; }
        [NotMapped]
        public string GenreName { get;set; }


    }
}
