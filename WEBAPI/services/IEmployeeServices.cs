using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPI.Models;
using WEBAPI.ViewModel;

namespace WEBAPI.services
{
    interface IEmployeeServices
    {
        List<Employee> GetEmployeesList();
        Employee GetEmployee(int id);
        ResponseModel SaveEmployee(Employee employeeModel);
        ResponseModel DeleteEmployee(int id);
    }
}
