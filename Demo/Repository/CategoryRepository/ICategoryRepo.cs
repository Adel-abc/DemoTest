using Demo.Models;
using Demo.Repository.GenericRepository;

namespace Demo.Repository.CategoryRepository
{
    public interface ICategoryRepo : IGenericRepo<Category>
    {
        Task<List<Category>> GetAllCategories();
        Task<Category> GetCategoryWithPieces(int categoryid);
    }
}
