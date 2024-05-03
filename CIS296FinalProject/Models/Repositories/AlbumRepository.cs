using CIS296FinalProject.Data;

namespace CIS296FinalProject.Models.Repositories
{
    public class AlbumRepository: IAlbumRepository
    {
        private readonly MusicContext _context;

        public AlbumRepository(MusicContext context)
        {
            _context = context;
        }

        public IEnumerable<Album> GetAll()
        {
            return _context.Albums.ToList();
        }

        public Album GetById(int id)
        {
            return _context.Albums.Find(id);
        }

        public IEnumerable<Album> GetFilteredAndSorted(string searchTerm, string sortBy)
        {
            var query = _context.Albums.AsQueryable();

            // Apply filtering
            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(a => a.Title.Contains(searchTerm) || a.Artist.Contains(searchTerm));
            }

            // Apply sorting
            switch (sortBy)
            {
                case "title":
                    query = query.OrderBy(a => a.Title);
                    break;
                case "artist":
                    query = query.OrderBy(a => a.Artist);
                    break;
                    // Add more sorting options as needed...
            }

            return query.ToList();
        }

    }
}
