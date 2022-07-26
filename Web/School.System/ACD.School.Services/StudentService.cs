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
    }
}