using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MbmStore.Infrastructure;
using System.Web.Mvc;
using MbmStore.Models;

namespace MbmStore.Controllers
{
    public class InvoiceController : Controller
    {
        private IEnumerable<Invoice> invoices;


        // GET: Invoice
        private Repository repository = new Repository();
        public ActionResult Index()
        {
            ViewBag.Invoices = repository.Invoices;
            
            
            // declare the list
            List<SelectListItem> customers = new List<SelectListItem>();
            
            // generate the dropdown list
            foreach (Invoice invoice in repository.Invoices)
            {
                customers.Add(new SelectListItem
                {
                    Text = invoice.Customer.Firstname + " " + invoice.Customer.Lastname,
                    Value = invoice.Customer.PersonId.ToString()
                });
                // removes duplicate entries with same ID from a IEnumerable
                customers = customers.GroupBy(x => x.Value).Select(y => y.First()).OrderBy(z => z.Text).ToList<SelectListItem>();

                ViewBag.CustomerId = customers;
            }

            return View();
        }
        [HttpPost]
        public ActionResult Index(int? CustomerId)
        {

            // declare the list
            List<SelectListItem> customers = new List<SelectListItem>();

            foreach (Invoice invoice in repository.Invoices)
            {
                customers.Add(new SelectListItem
                {
                    Text = invoice.Customer.Firstname + " " + invoice.Customer.Lastname,
                    Value = invoice.Customer.PersonId.ToString()
                });
                // removes duplicate entries with same ID from a IEnumerable
                customers = customers.GroupBy(x => x.Value).Select(y => y.First()).OrderBy(z => z.Text).ToList<SelectListItem>();

                ViewBag.CustomerId = customers;
            }
            if (CustomerId != null)
            {
                // select invoices for a customer with linq
                invoices = repository.Invoices.Where(r => r.Customer.PersonId == CustomerId);
            }
            else
            {
                invoices = repository.Invoices;
            }
            ViewBag.Invoices = invoices;
            return View();
        }
    }
}