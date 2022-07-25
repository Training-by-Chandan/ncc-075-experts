using School.System.Data;
using School.System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.System.Repository
{
    public interface IStudentRepository
    {
        (bool, string) Create(Student model);

        (bool, string) Delete(Student model);

        (bool, string) Edit(Student model);

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

        public (bool, string) Edit(Student model)
        {
            try
            {
                db.Students.Update(model);
                db.SaveChanges();
                return (true, "Updated Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Delete(Student model)
        {
            try
            {
                db.Students.Remove(model);
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