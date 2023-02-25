using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppReposotiry.Models;
using WebAppReposotiry.Reposotiry;

namespace WebAppReposotiry.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            IEmployeeRepo empolyeeRepo = new EmployeeRepo();
            Employee employee = new Employee()
            {
                Department = "IT",
                Name ="Basem",
                Salary =5000,
            };

            empolyeeRepo.Add(employee);
            empolyeeRepo.Save();
            return Content("Data Successfully Added.");
           
        }
    }
}