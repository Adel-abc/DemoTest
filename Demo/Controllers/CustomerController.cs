using Demo.ApplicationDbContextFolder;
using Demo.DTOsFolder.CustomerDTOFolder;
using Demo.Models;
using Demo.Repository.CustomerRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Validations;

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepo db;
        public CustomerController(ICustomerRepo _db)
        {  db = _db; }

        [HttpGet("GetCustomerWithAllInfo")]
        public async Task<IActionResult> GetAll()
        {
            var cus = await db.GetCustomersWithAllInfo();
            //var loyal = new LoyaltyCard();

            //string strID = cus.Select(x => x.LoyaltyCard.Id).ToString();
            //int intID = int.Parse(strID);
            //loyal.Id = intID;
            //loyal.CardNumber = cus.Select(x => x.LoyaltyCard.CardNumber).ToString();

            //var str = cus.Select(x => x.LoyaltyCard.Balance ).ToString();
            //decimal deciNum = decimal.Parse(str);
            //loyal.Balance = deciNum;
            var res = cus.Select(x => new GetCustomersWithInfoDto
            {
                Id = x.Id,
                Name = x.Name,
                EmailAddress = x.EmailAddress,
                Phone = x.Phone,
                totalAmount = x.ArtPieces.Sum(x => x.Price),

                ArtPieces = x.ArtPieces.Select(o => new ArtPiecesCustomerDto
                {
                    Title = o.Title,
                    Description = o.Description,
                    Price = o.Price
                }).ToList(),

                lotarycard = new LotaryCardCustoemrDto
                {
                    loyalID = x.LoyaltyCard.Id,
                    CardNumberdto = x.LoyaltyCard.CardNumber,
                    Balancedto = x.LoyaltyCard.Balance
                }
            }).OrderByDescending(x => x.totalAmount).ToList();



            return Ok(res);
        }
    }
}
