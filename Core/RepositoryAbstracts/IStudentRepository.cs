using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.RepositoryAbstracts
{
    public  interface IStudentRepository
    {
        void Add(Student student);
        void Delete(Student student);
        Student Get(Func<Student, bool> ? predicate);
        List<Student> GetAll(Func<Student,bool> ? predicate);
        int Commit();
    }
}
