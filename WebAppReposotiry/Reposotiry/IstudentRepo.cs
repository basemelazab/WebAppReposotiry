using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppReposotiry.Models;

namespace WebAppReposotiry.Reposotiry
{
    public interface IstudentRepo
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int studentId);
        void Add (Student student);
        void Update (Student student);
        void Delete (int studentId);
        void Save();

    }
}
