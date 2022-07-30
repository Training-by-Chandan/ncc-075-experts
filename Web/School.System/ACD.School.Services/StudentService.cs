using ACD.School.Models;
using ACD.School.Repository;
using ACD.School.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACD.School.Services
{
    public interface IStudentService
    {
        (bool, string) Create(StudentCreateViewModel model);

        (bool, string) Delete(int id);

        List<StudentViewModel> GetAll();

        (bool, string) HardDelete(int id);
    }

    public class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;

        public StudentService(
            IStudentRepository studentRepository
            )
        {
            this.studentRepository = studentRepository;
        }

        public (bool, string) Create(StudentCreateViewModel model)
        {
            try
            {
                var student = new Student()
                {
                    Name = model.Name,
                    PhoneNumber = model.PhoneNumber,
                    Email = model.Email,
                    CreatedDate = DateTime.Now
                };

                return studentRepository.Create(student);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        /// <summary>
        /// Soft delete
        /// </summary>
        /// <returns></returns>
        public (bool, string) Delete(int id)
        {
            try
            {
                var existing = studentRepository.GetById(id);
                if (existing == null) return (false, $"Record with {id} not found");

                existing.IsDeleted = true;
                return studentRepository.Edit(existing);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) HardDelete(int id)
        {
            try
            {
                var existing = studentRepository.GetById(id);
                if (existing == null) return (false, $"Record with {id} not found");

                return studentRepository.Delete(existing);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public List<StudentViewModel> GetAll()
        {
            var data = studentRepository.GetAll();

            var ret = data.Select(p => new StudentViewModel()
            {
                Id = p.Id,
                Email = p.Email,
                Name = p.Name,
                CreatedDate = p.CreatedDate,
                PhoneNumber = p.PhoneNumber
            });
            return ret.ToList();
        }
    }
}