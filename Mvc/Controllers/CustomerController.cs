using Microsoft.AspNetCore.Mvc;
using Mvc.Models.context;
using Mvc.Models.entity;
using Mvc.Models.vmodel;

namespace Mvc.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult ListCustomer() {
            NorthwindContext context = new NorthwindContext();
            List<Customer> customerList= context.Customers.ToList();

            CustomerListResponse customerListResponse= new CustomerListResponse();
            customerListResponse.list = new List<CustomerList>();
            foreach (Customer c in customerList)
            {
                CustomerList clist = new CustomerList();
                clist.Address = c.Address;
                clist.Phone = c.Phone;
                clist.ContactName = c.ContactName;
                clist.City = c.City;
                clist.CompanyName = c.CompanyName;
                clist.Country = c.Country;
                customerListResponse.list.Add(clist);
            }

            return View(customerListResponse);
        }


    }
}
