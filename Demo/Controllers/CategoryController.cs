using Demo.DTOsFolder.CategoryDTOFolder;
using Demo.Repository.CategoryRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepo _categoryRepo;
        public CategoryController(ICategoryRepo _repo) { _categoryRepo = _repo; }

        [HttpGet("GetAllCategories")]
        public async Task<IActionResult> GatCategories()
        {
            var categories = await _categoryRepo.GetAllCategories();

            var response = categories.Select(x => new GetAllCategoriesDto
            {
                Name = x.Name,
                TotalNumberOfPieces = x.ArtPieces.Count(),
                pieces = x.ArtPieces.Select(x => new Pieces
                {
                    Title = x.Title,
                    Description = x.Description,
                    Price = x.Price
                }).ToList()
            }).OrderByDescending(x => x.TotalNumberOfPieces).ToList();
            return Ok(response);
        }

        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    var category = _categoryRepo
        //    return Ok();
        //}
    }
}
