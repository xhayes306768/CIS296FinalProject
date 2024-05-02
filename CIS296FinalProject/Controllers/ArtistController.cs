using Microsoft.AspNetCore.Mvc;
using CIS296FinalProject.Data;
using System.Linq;

namespace CIS296FinalProject.Controllers
{
    public class ArtistController : Controller
    {
        private readonly MusicContext _context;

        public ArtistController(MusicContext context)
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
            // Retrieve artists from the database
            var artists = _context.Artists.ToList();

            // Pass artists to the view
            return View(artists);
        }

        public IActionResult Details(int id)
        {
            // Retrieve artist details from the database
            var artist = _context.Artists.FirstOrDefault(a => a.Id == id);

            // Pass artist details to the view
            return View(artist);
        }
    }
}
