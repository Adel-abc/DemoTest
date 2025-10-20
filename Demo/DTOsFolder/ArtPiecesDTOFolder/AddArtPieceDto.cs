using System.ComponentModel.DataAnnotations;

namespace Demo.DTOsFolder.ArtPiecesDTOFolder
{
    public class AddArtPieceDto
    {
        public string Title { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
        [Required, MinLength(1)]
        public decimal Price { get; set; }

        public int CustomerID { get; set; }
        public List<int> Categories { get; set; }
    }
}
