using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businees.Services.Abstacts
{
   public  interface IStudentService
    {
        void DeleteStudent(int id);
        void AddStudent(Student student);
        void UpdateStudent(int id, Student student);

        Student GetStudent(Func<Student, bool>? predicate);
        List<Student> GetAllStudents(Func<Student, bool>? predicate);
    }
}
