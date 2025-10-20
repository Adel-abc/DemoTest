using System.ComponentModel.DataAnnotations;

namespace Demo.DTOsFolder.CustomerDTOFolder
{
    public class GetCustomersWithInfoDto
    {
        public int Id { get; set; }
        [Required, MaxLength(100)] public string Name { get; set; }
        [Required, EmailAddress] public string EmailAddress { get; set; }
        [Required, Phone] public string Phone { get; set; }
        public decimal totalAmount { get; set; }
        public List<ArtPiecesCustomerDto> ArtPieces { get; set; } = new List<ArtPiecesCustomerDto>();
        public LotaryCardCustoemrDto lotarycard { get; set; }
    }
    public class ArtPiecesCustomerDto
    {
        public string Title { get; set; }
        [MaxLength(500)]
        public string? Description { get; set; }
        [Required, MinLength(1)]
        public decimal Price { get; set; }
    }
    public class LotaryCardCustoemrDto
    {
        public int loyalID { get; set; }
        public string CardNumberdto { get; set; }
        public decimal Balancedto { get; set; }
    }
}
