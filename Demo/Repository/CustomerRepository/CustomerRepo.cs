using Demo.ApplicationDbContextFolder;
using Demo.Models;
using Demo.Repository.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Demo.Repository.CustomerRepository
{
    public class CustomerRepo : GenericRepo<Customer>, ICustomerRepo
    {
        public CustomerRepo(AppDbContext context) : base(context) { }

        public async Task<List<Customer>> GetCustomersWithAllInfo()
        {
            return await _context.Customers.Include(x => x.ArtPieces).Include(x => x.LoyaltyCard).ToListAsync();
        }
    }
}
