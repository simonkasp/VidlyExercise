using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _dbContext;

        public CustomersController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = _dbContext.Customers.Include(m => m.MembershipType).SingleOrDefault(c => c.Id == id);
            return View(customer);
        }

        // GET: Customers

        public ActionResult New()
        {
            var membershipTypes = _dbContext.MembershipTypes.ToList();

            var newCustomerViewModel = new CustomerFormViewModel()
            {
                Customer = new Customer(),
                MembershipTypes = membershipTypes
            };
            
            return View("CustomerForm", newCustomerViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var customerViewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MembershipTypes = _dbContext.MembershipTypes.ToList()
                };

                return View("CustomerForm", customerViewModel);
            }

            if (customer.Id == 0)
                _dbContext.Customers.Add(customer);
            else
            {
                var customerInDb = _dbContext.Customers.Single(c => c.Id == customer.Id);

                customerInDb.Name = customer.Name;
                customerInDb.BirthDate = customer.BirthDate;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
            }
            
            _dbContext.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

        public ActionResult Edit(int id)
        {
            var customer = _dbContext.Customers.SingleOrDefault(c => c.Id == id);
            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _dbContext.MembershipTypes.ToList()
            };

            return View("CustomerForm", viewModel);
        }

        public ActionResult Index()
        {
            var customers = _dbContext.Customers.Include(m => m.MembershipType).ToList();

            return View(customers);
        }

    }
}