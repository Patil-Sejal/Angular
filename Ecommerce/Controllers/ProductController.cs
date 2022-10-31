using Ecommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        EcommerceContext db = new EcommerceContext();
        [HttpGet]
        public IEnumerable<Product> get()
        {
            return db.Products;
        }
        [HttpPost]
        public IActionResult post(Product customer)
        {
            db.Products.Add(customer);
            db.SaveChanges();
            return Ok(new { status = "your record is added suceessfully" });
        }
        [HttpPut]
        public IActionResult put(Product customer)
        {
            db.Products.Update(customer);
            db.SaveChanges();
            return Ok(new { status = "your record is updated suceessfully" });
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var customer = db.Products.Where(x => x.Id == id).FirstOrDefault();
            db.Products.Remove(customer);
            db.SaveChanges();
            return Ok(new { status = "your record is deleted suceessfully" });
        }
    }
}
