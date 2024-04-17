using Microsoft.AspNetCore.Mvc;
using Movies.Models;

namespace Movies.Controllers
{
    public class MovieController : Controller
    {

        private MovieContext Context { get; set; }

        public MovieController(MovieContext ctx)
        {
            Context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add New Movie";
            return View("Edit", new Movie());
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
