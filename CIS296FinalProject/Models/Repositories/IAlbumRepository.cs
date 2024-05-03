namespace CIS296FinalProject.Models.Repositories
{
    public interface IAlbumRepository
    {
        IEnumerable<Album> GetAll();
        Album GetById(int id);
        IEnumerable<Album> GetFilteredAndSorted(string searchTerm, string sortBy);

    }

    public interface IUnitOfWork : IDisposable
    {
        IAlbumRepository AlbumRepository { get; }
       

        void SaveChanges();
    }


}
