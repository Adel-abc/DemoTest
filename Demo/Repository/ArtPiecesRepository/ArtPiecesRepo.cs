using Demo.ApplicationDbContextFolder;
using Demo.Models;
using Demo.Repository.GenericRepository;

namespace Demo.Repository.ArtPiecesRepository
{
    public class ArtPiecesRepo : GenericRepo<ArtPiecesRepo>, IArtPiecesRepo
    {
        public ArtPiecesRepo(AppDbContext context) : base(context)
        { }

        public async Task AddArtPiece(ArtPieces entity)
        {
            await _context.ArtPieces.AddAsync(entity);
        }
    }
}
