using Ecommerce.Models;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public class CategoryController : ControllerBase
    {
        EcommerceContext db = new EcommerceContext();
        [HttpGet]
        public IEnumerable<Category> get()
        {
            return db.Categories;
        }
        [HttpPost]
        public IActionResult post(Category customer)
        {
            db.Categories.Add(customer);
            db.SaveChanges();
            return Ok(new { status = "your record is added suceessfully" });
        }
        [HttpPut]
        public IActionResult put(Category customer)
        {
            db.Categories.Update(customer);
            db.SaveChanges();
            return Ok(new { status = "your record is updated suceessfully" });
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var customer = db.Categories.Where(x => x.Id == id).FirstOrDefault();
            db.Categories.Remove(customer);
            db.SaveChanges();
            return Ok(new { status = "your record is deleted suceessfully" });
        }
    }
}
