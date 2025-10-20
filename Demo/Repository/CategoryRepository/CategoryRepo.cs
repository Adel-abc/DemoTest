using Demo.ApplicationDbContextFolder;
using Demo.Models;
using Demo.Repository.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Demo.Repository.CategoryRepository
{
    public class CategoryRepo : GenericRepo<Category>, ICategoryRepo
    {
        public CategoryRepo(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Category>> GetAllCategories()
        {
            return await _context.Categories.Include(x => x.ArtPieces).ToListAsync();
        }

        public Task<Category> GetCategoryWithPieces(int categoryid)
        {
            throw new NotImplementedException();
        }
    }
}
