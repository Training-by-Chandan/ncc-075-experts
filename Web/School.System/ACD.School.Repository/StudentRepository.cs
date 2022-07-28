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
            return db.Students.Where(p => !p.IsDeleted);
        }

        public Student GetById(int id)
        {
            var existing = db.Students.Find(id);
            if (existing == null || existing.IsDeleted) return null;

            return existing;
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

                return (true, "Deleted Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}