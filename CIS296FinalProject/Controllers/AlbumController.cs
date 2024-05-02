using CIS296FinalProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace MusicApplication.Controllers
{
    public class AlbumController : Controller
    {
        private readonly MusicContext _context;

        public AlbumController(MusicContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Redirect to the list action
            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            // Retrieve albums from the database
            var albums = _context.Albums.ToList();

            // Pass albums to the view
            return View(albums);
        }

        public IActionResult Details(int id)
        {
            // Retrieve album details from the database
            var album = _context.Albums.FirstOrDefault(a => a.Id == id);

            // Pass album details to the view
            return View(album);
        }
    }
}
