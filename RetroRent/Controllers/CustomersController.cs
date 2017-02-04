using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RetroRent.Models;
using RetroRent.ViewModels;

namespace RetroRent.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ViewResult Index()
        {
            var customers = GetCustomers();
            return View();
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.ID == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);

        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { ID = 1, Name = "Seppo Taalasmaa"  },
                new Customer { ID = 2, Name = "Ismo Laitela"  },
                new Customer { ID = 3, Name = "Aki Nikkinen"  },

            };
        }
    }
}
