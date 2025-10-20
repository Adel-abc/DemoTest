using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class Category
    {
        [Key] public int Id { get; set; }
        [Required] public string Name { get; set; }
        public List<ArtPieces> ArtPieces { get; set; }
    }
}
