using Microsoft.AspNetCore.Mvc;
using CIS296FinalProject.Data;
using System.Linq;

namespace CIS296FinalProject.Controllers
{
    public class SongController : Controller
    {
        private readonly MusicContext _context;

        public SongController(MusicContext context)
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
            // Retrieve songs from the database
            var songs = _context.Songs.ToList();

            // Pass songs to the view
            return View(songs);
        }

        public IActionResult Details(int id)
        {
            // Retrieve song details from the database
            var song = _context.Songs.FirstOrDefault(s => s.Id == id);

            // Pass song details to the view
            return View(song);
        }
    }
}
