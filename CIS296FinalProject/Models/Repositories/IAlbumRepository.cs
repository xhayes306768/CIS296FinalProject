namespace CIS296FinalProject.Models.Repositories
{
    public interface IAlbumRepository
    {
        IEnumerable<Album> GetAll();
        Album GetById(int id);

    }

    public interface IUnitOfWork : IDisposable
    {
        IAlbumRepository AlbumRepository { get; }
        // Other repositories as needed...

        void SaveChanges();
    }


}
