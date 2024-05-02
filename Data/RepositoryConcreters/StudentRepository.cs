using Core.Models;
using Core.RepositoryAbstracts;
using Data.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepositoryConcreters
{
    public class StudentRepository : IStudentRepository
    {
        ApDBContext dBContext;
        public StudentRepository()
        {
            dBContext = new ApDBContext();
        }
        public void Add(Student student)
        {
           dBContext.Students.Add(student);
        }

        public int Commit()
        {
            return dBContext.SaveChanges();
        }

        public void Delete(Student student)
        {
           dBContext.Students.Remove(student);
        }

        public Student Get(Func<Student, bool>? predicate)
        {
            return predicate == null ?
             dBContext.Students.FirstOrDefault() :
             dBContext.Students.FirstOrDefault(predicate);
        }

        public List<Student> GetAll(Func<Student, bool>? predicate)
        {
            return predicate == null ?
              dBContext.Students.ToList() :
              dBContext.Students.Where(predicate).ToList();
        }
    }
}
