using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPI.Models;
using WEBAPI.services;
using WEBAPI.ViewModel;

namespace WEBAPI.Repository
{
    public class EmployeeRepository : IEmployeeServices
    {
        private Empcontext _empcontext;
        public EmployeeRepository(Empcontext empcontext)
        {
            _empcontext = empcontext;
        }
        ResponseModel IEmployeeServices.DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        Employee IEmployeeServices.GetEmployee(int id)
        {
            Employee employee = null;
            try
            {
                employee = _empcontext.Find<Employee>(id);
            }
            catch (System.Exception)
            {

                throw;
            }
            return employee;
        }

        List<Employee> IEmployeeServices.GetEmployeesList()
        {
            throw new NotImplementedException();
        }

        ResponseModel IEmployeeServices.SaveEmployee(Employee employeeModel)
        {
            throw new NotImplementedException();
        }
    }
}
