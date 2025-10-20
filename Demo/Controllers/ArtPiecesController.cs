using Demo.DTOsFolder.ArtPiecesDTOFolder;
using Demo.Models;
using Demo.Repository.ArtPiecesRepository;
using Demo.Repository.GenericRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtPiecesController : ControllerBase
    {
        private readonly IArtPiecesRepo _artPiecesRepo;
        private readonly IGenericRepo<Category> _genericRepo;

        public ArtPiecesController(IArtPiecesRepo artPiecesRepo, IGenericRepo<Category> repo)
        {
            _artPiecesRepo = artPiecesRepo;
            _genericRepo = repo;
        }

        [HttpPost]
        public async Task<IActionResult> addArtPiece(AddArtPieceDto dto)
        {
            var res = new ArtPieces
            {
                Title = dto.Title,
                Description = dto.Description,
                Price = dto.Price,
                CustomerID = dto.CustomerID,
                Categories = new List<Category>()
            };

            foreach(var category in dto.Categories)
            {
                var check = await _genericRepo.GetById(category);
                if (check != null)
                {
                    res.Categories.Add(check);
                }
            }
            return Ok();
        }
    }
}
