using Microsoft.AspNetCore.Mvc;
using CIS296FinalProject.Data;
using System.Linq;

namespace CIS296FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MusicContext _context;

        public HomeController(ILogger<HomeController> logger, MusicContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            //  Get the latest albums to display on the home page
            var latestAlbums = _context.Albums.OrderByDescending(a => a.ReleaseDate).Take(5).ToList();

            // Pass the latest albums to the view
            return View(latestAlbums);
        }

    }
}
