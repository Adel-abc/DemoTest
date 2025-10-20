using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Demo.DTOsFolder.CustomerDTOFolder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Demo.Models
{
    [Index(nameof(CardNumber), IsUnique = true)]
    public class LoyaltyCard
    {
        [Key] public int Id { get; set; }
        [Required]
        public string CardNumber { get; set; }
        public decimal Balance { get; set; }
        public int CustomerID { get; set; }
        [ForeignKey(nameof(CustomerID))]        
        public Customer Custoemr { get; set; }
    }
}
