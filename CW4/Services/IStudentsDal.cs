using CW4.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CW4.Services
{
    public interface IStudentsDal
    {
        public IEnumerable<Student> GetStudents();
    }
}
