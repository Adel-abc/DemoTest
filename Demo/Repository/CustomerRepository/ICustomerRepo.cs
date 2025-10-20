using Demo.Models;
using Demo.Repository.GenericRepository;

namespace Demo.Repository.CustomerRepository
{
    public interface ICustomerRepo : IGenericRepo<Customer>
    {
        Task<List<Customer>> GetCustomersWithAllInfo();
    }
}
