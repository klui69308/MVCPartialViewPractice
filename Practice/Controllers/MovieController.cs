using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice.Models;

namespace Practice.Controllers
{
    public class MovieController : Controller
    {
        List<Movie> Collection1 = new List<Movie>()
        {
            new Movie{ MovieID = 1, Name = "Hello World", Genre = "Action", Price = 100},
            new Movie{ MovieID = 2, Name = "Goodbye World", Genre = "Action", Price = 100}
        };
        // GET: Movie
        public PartialViewResult DisplayMovieCollection()
        {
            return PartialView();
        }
        public ActionResult Index()
        {
            return View(Collection1);
        }
    }
}