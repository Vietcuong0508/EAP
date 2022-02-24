using EmployeeClient.EmployeeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;

namespace EmployeeClient.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        private EmployeeService.Employee employee1 = new EmployeeService.Employee();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            employee1.Add(employee);
            return View("Search");
        }
        public ActionResult Search(string name)
        {
            var result = employee1.Search(name);
            return View(result);
        }
    }
}