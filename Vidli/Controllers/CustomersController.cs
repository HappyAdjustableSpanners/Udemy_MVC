using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Vidli.Models;
using Vidli.ViewModels;


namespace Vidli.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult ShowCustomers()
        {
            // define list of customers
            // use eager loading to also load in membership type object so we can refer to it
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            // define a view model
            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };


            return View(viewModel);
        }

        public ActionResult ShowCustomerDetails(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            var viewModel = new CustomerDetailsViewModel
            {
                Name = customer.Name,
                MembershipType = customer.MembershipType.Name,
                Birthdate = customer.Birthdate,
            };

            return View(viewModel);
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();

            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = membershipTypes
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();

            return RedirectToAction("ShowCustomers", "Customers");
        }
    }
}