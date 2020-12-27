using MoshVidly.Models;
using MoshVidly.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoshVidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer> {
                new Customer { Name = "John Smith"},
                new Customer { Name = "Mary Williams"}
            };

            var viewModel = new IndexCustomerViewModel {
                Customers = customers
            };

            return View(viewModel);
        }
    }
}