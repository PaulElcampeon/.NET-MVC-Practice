using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class CustomersController : Controller
    {
        [Route("customers")]
        [Route("customers/index")]
        [Route("customers/home")]
        public ActionResult Index()
        {
            CustomerViewModel viewModel = new CustomerViewModel()
            {
                Customers = GetCustomers()
            };

            return View("~/Views/Customers/Index.cshtml", viewModel);
        }

        [Route("customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            List<Customer> filteredCustomers = GetCustomers().Where((e) => e.Id == id).ToList();

            if (filteredCustomers.Count == 0)
            {
                return View("~/Views/Customers/Details.cshtml", new Customer() { Id = 0 });
            }
            else
            {
                return View("~/Views/Customers/Details.cshtml", filteredCustomers[0]);
            }
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> Customers = new List<Customer>()
            {
                new Customer(){Name = "Rachel", Id = 1},
                new Customer(){Name = "Micahel", Id = 2},
                new Customer(){Name = "Talensces", Id = 3}
            };

            return Customers;
        }
    }
}