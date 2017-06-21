using MbmStore.Models;
using MbmStore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        private Repository repository = new Repository();
        public ActionResult Customer()
        {
            ViewBag.Customers = repository.Customers;
            return View();
        }
    }
}