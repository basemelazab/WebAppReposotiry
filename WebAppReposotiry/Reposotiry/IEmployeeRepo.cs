using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppReposotiry.Models;

namespace WebAppReposotiry.Reposotiry
{
    public interface IEmployeeRepo
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int employeeId);
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(int employeeId);
        void Save();
    }
}
