using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MbmStore.Infrastructure;
using MbmStore.Models;

namespace MbmStore.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        private Repository repository = new Repository();
        public ActionResult Index()
        {
            ViewBag.Products = repository.Products;
            return View();
        }
    }
}