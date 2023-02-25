using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppReposotiry.Models;

namespace WebAppReposotiry.Reposotiry
{
    public class StudentRepo : IstudentRepo
    {
        private GeneralDBEntities db;
        public StudentRepo()
        {
            db = new GeneralDBEntities();
        }
        public void Add(Student student)
        {
           db.Students.Add(student);
        }

        public void Delete(int studentId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return db.Students;
        }

        public Student GetStudentById(int studentId)
        {
            return db.Students.Single(model=>model.StudentId == studentId);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}