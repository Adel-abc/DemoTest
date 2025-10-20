using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Models
{
    public class ArtPieces
    {
        [Key] public int Id { get; set; }
        [Required, MaxLength(150)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
        [Required, MinLength(1)]
        public decimal Price { get; set; }

        public int CustomerID { get; set; }
        [ForeignKey(nameof(CustomerID))]
        public Customer Customer { get; set; }
        public List<Category> Categories { get; set; }
    }
}
