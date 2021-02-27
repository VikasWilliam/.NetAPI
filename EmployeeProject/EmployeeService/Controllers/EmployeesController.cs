using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDataAccess;

namespace EmployeeService.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (EmployeeEntities entities = new EmployeeEntities())
            {
                return entities.Employees.ToList();
            }
        }
        public Employee Get(int id)
        {
            using (EmployeeEntities entities = new EmployeeEntities())
            {
                return entities.Employees.FirstOrDefault(e => e.ID == id);
            }
        }


    }


}
