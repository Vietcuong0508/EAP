using EmployeeS.Data;
using EmployeeS.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private MyDBContext db = new MyDBContext();
        public Employee Add(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return employee;
        }

        public List<Employee> Search(string name)
        {
            if (name != null)
            {
                var employee = from em in db.Employees
                         .Where(e => e.Department.Equals(name))
                               select em;
                return employee.ToList();
            }
            else
            {
                return db.Employees.ToList();
            }
        }
    }
}
