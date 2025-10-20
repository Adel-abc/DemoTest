using Demo.Models;
using Demo.Repository.GenericRepository;

namespace Demo.Repository.ArtPiecesRepository
{
    public interface IArtPiecesRepo: IGenericRepo<ArtPiecesRepo>
    {
        Task AddArtPiece(ArtPieces entity);
    }
}
