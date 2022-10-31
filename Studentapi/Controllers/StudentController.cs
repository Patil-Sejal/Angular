using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Studentapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studentapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StudentController : ControllerBase
    {
        CollegeContext db = new CollegeContext();
        [HttpGet]
        public IEnumerable<Student> get()
        {
            return db.Students;
        }
        [HttpPost]
        public IActionResult post(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            return Ok(new { status = "your record is added suceessfully" });
        }
        [HttpPut]
        public IActionResult put(Student student)
        {
            db.Students.Update(student);
            db.SaveChanges();
            return Ok(new { status = "your record is updated suceessfully" });
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var student = db.Students.Where(x => x.Sid  == id).FirstOrDefault();
            db.Students.Remove(student);
            db.SaveChanges();
            return Ok(new { status = "your record is deleted suceessfully" });
        }
    }
}
