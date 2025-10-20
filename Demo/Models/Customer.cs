using System.ComponentModel.DataAnnotations;
using Microsoft.Identity.Client;

namespace Demo.Models
{
    public class Customer
    {
        [Key] public int Id { get; set; }
        [Required, MaxLength(100)] public string Name { get ; set; }
        [Required, EmailAddress] public string EmailAddress { get; set; }
        [Required, Phone] public string Phone { get; set; }
        public List<ArtPieces> ArtPieces { get; set; }
        public LoyaltyCard LoyaltyCard { get; set; }
    }
}
