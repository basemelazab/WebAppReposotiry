using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppReposotiry.Models;

namespace WebAppReposotiry.Reposotiry
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private GeneralDBEntities db;
        public EmployeeRepo()
        {
            db = new GeneralDBEntities();
        }
        public EmployeeRepo(GeneralDBEntities db)
        {
            db = this.db;
        }
        public void Add(Employee employee)
        {
            db.Employees.Add(employee);
        }

        public void Delete(int employeeId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return db.Employees;
        }

        public Employee GetEmployeeById(int employeeId)
        {
            return db.Employees.Single(model=>model.EmployeeId == employeeId);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}