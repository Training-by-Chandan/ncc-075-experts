using ACD.School.Data;
using ACD.School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACD.School.Repository
{
    public interface IStudentRepository
    {
        (bool, string) Create(Student model);

        IQueryable<Student> GetAll();

        Student GetById(int id);
    }

    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext db;

        public StudentRepository(
            ApplicationDbContext db
            )
        {
            this.db = db;
        }

        public IQueryable<Student> GetAll()
        {
            return db.Students;
        }

        public Student GetById(int id)
        {
            return db.Students.Find(id);
        }

        public (bool, string) Create(Student model)
        {
            try
            {
                db.Students.Add(model);
                db.SaveChanges();

                return (true, "Added Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}