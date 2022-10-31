using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        CustomerDBContext db = new CustomerDBContext();
        [HttpGet]
        public IEnumerable<Customer> get()
        {
            return db.Customers;
        }
        [HttpPost]
        public IActionResult post(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
            return Ok(new { status = "your record is added suceessfully" });
        }
        [HttpPut]
        public IActionResult put(Customer customer)
        {
            db.Customers.Update(customer);
            db.SaveChanges();
            return Ok(new { ststus = "your record is updated suceessfully" });
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var customer = db.Customers.Where(x => x.Id == id).FirstOrDefault();
            db.Customers.Remove(customer);
            db.SaveChanges();
            return Ok(new { ststus = "your record is deleted suceessfully" });
        }
    }
}
