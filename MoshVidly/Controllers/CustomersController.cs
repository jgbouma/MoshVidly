using MoshVidly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoshVidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers/RandomCustomer
        public ActionResult RandomCustomer()
        {
            var customer = new Customer() { Name = "Rider" };
            
            return View(customer);
        }
    }
}