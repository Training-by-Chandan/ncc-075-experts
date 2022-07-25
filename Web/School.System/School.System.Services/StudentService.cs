using School.System.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.System.Services
{
    public interface IStudentService
    {
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
    }
}