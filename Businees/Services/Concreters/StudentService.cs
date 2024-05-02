using Businees.Services.Abstacts;
using Core.Models;
using Core.RepositoryAbstracts;
using Data.RepositoryConcreters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businees.Services.Concreters
{
    public class StudentService:IStudentService
    {
        IStudentRepository studentRepository= new StudentRepository();

        public void AddStudent(Student student)
        {
            if (!studentRepository.GetAll(null).Any(x => x.Name == student.Name))
            {
                studentRepository.Add(student);
                studentRepository.Commit();
            }
        }

        public void DeleteStudent(int id)
        {
            var student = studentRepository.Get(x => x.Id == id);
            if (student == null) throw new NullReferenceException();

            studentRepository.Delete(student);
            studentRepository.Commit();
        }

        public List<Student> GetAllStudents(Func<Student, bool>? predicate)
        {
           return studentRepository.GetAll(predicate);
        }

        public Student GetStudent(Func<Student, bool>? predicate)
        {
            return studentRepository.Get(predicate);
        }

        public void UpdateStudent(int id, Student student)
        {
            var oldStudent = studentRepository.Get(x => x.Id == id);
            if(oldStudent == null) throw new NullReferenceException();
            if (!studentRepository.GetAll(null).Any(x => x.Name == student.Name))
            {
                oldStudent.Name = student.Name;
                oldStudent.Surname = student.Surname;
                oldStudent.Age = student.Age;
                oldStudent.Point=student.Point;
                studentRepository.Commit();
            }

        }
    }
}
