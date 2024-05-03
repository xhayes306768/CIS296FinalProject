using CIS296FinalProject.Data;

namespace CIS296FinalProject.Models.Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly MusicContext _context;
        private IAlbumRepository _albumRepository;

        public UnitOfWork(MusicContext context)
        {
            _context = context;
        }

        public IAlbumRepository AlbumRepository
        {
            get
            {
                if (_albumRepository == null)
                    _albumRepository = new AlbumRepository(_context);
                return _albumRepository;
            }
        }

        // Other repository properties and methods...

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
