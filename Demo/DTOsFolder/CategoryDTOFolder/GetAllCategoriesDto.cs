using Demo.Models;
using System.ComponentModel.DataAnnotations;

namespace Demo.DTOsFolder.CategoryDTOFolder
{
    public class GetAllCategoriesDto
    {
        [Required] public string Name { get; set; }
        public List<Pieces> pieces { get; set; }
        public int TotalNumberOfPieces { get; set; }
    }
    public class Pieces
    {
        public string Title { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
        [Required, MinLength(1)]
        public decimal Price  { get; set; }
    }
}
