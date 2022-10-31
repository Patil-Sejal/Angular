using Api_Consuming_Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api_Consuming_Login.Controllers
{
    public class LoginController : ApiController
    {
        [Route("Api/Login/UserLogin")]
        [HttpPost]
        public Response Login(Login lg)
        {
            EmpDBEntities EB = new EmpDBEntities();
            var obj = EB.Login(lg.UserName, lg.Password).ToList <Login_Result>().FirstOrDefault();
            if(obj.Status==0)
            {
                return new Response { Status = "invalid", Message = "invalidUser" };
            }
            if (obj.Status == -1)
            {
                return new Response { Status = "invalid", Message = "invalidUser" };
            }
            else 
            {
                return new Response { Status = "Success", Message = lg.UserName };
            }
        }
        [Route("Api/Login/CreateContact")]
        [HttpPost]
        public object CreateContact(Registration rg) {
            try
            {
                EmpDBEntities EE = new EmpDBEntities();
                Employeemaster EM = new Employeemaster();
                if(EM.UserId==0)
                {
                    EM.UserName = rg.UserName;
                    EM.LoginName = rg.LoginName;
                    EM.Password = rg.Password;
                    EM.Status = rg.Status;
                    EM.Address = rg.Address;
                    EM.ContactNo = rg.ContactNo;
                    EM.Email = rg.Email;
                    EM.IsApporved = rg.IsApporved;
                    EM.TotalCnt = rg.TotalCnt;
                    EE.Employeemasters.Add(EM);
                    EE.SaveChanges();
                    return new Response { Status = "Success", Message = "Successfully saved" };
                }
            }
            catch (Exception)
            {

                throw;
            }
            return new Response { Status = "Error", Message = "Invalid data" };
        }
    }
}
