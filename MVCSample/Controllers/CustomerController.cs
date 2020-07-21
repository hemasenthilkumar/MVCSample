using MVCSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSample.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            List<Customer> l1 = new List<Customer>();
            Customer c = new Customer();
            c.Id = 1;
            c.Name = "John Smith";
            Customer c1 = new Customer();
            c1.Id = 2;
            c1.Name = "Mary Williams";
            l1.Add(c);
            l1.Add(c1);
            return View(l1);
        }
        [Route("Customer/ details /{id}")]
        public ActionResult details(int id)
        {
            if (id == 1)
                return Content("John Smith");
            else
                return Content("Mary Williams");
        }
    }

   
}