using Businees.Services.Abstacts;
using Businees.Services.Concreters;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Controllers
{
    public  class StudentController
    {
        IStudentService studentService=new StudentService();
        public void AddStudent()
        {
            Console.WriteLine("Enter the name: ");
            string name=Console.ReadLine();
            Console.WriteLine("Enter the surname: ");
            string surname=Console.ReadLine();
            int age, point;
            do
            {
                Console.WriteLine("Enter the age: ");

            } while (!int.TryParse(Console.ReadLine(),out age));

            do
            {
                Console.WriteLine("Enter the point: ");

            } while (!int.TryParse(Console.ReadLine(), out point));

            Student student = new Student()
            {
                Name = name,
                Surname=surname,
                Age=age,
                Point=point

            };
            studentService.AddStudent(student);
        }
        public void DeleteStudent()
        {
           
            int id;
            do
            {
                Console.WriteLine("Enter the delete id of student: ");

            } while (!int.TryParse(Console.ReadLine(), out id));
            studentService.DeleteStudent(id);
        }
        public void UpdateStudent()
        {
            int id;
            do
            {
                Console.WriteLine("Enter the update id of student: ");

            } while (!int.TryParse(Console.ReadLine(), out id));

            Console.WriteLine("Enter the name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the surname: ");
            string surname = Console.ReadLine();
            int age, point;
            do
            {
                Console.WriteLine("Enter the age: ");

            } while (!int.TryParse(Console.ReadLine(), out age));

            do
            {
                Console.WriteLine("Enter the point: ");

            } while (!int.TryParse(Console.ReadLine(), out point));
            Student student = new Student()
            {
                Name = name,
                Surname = surname,
                Age = age,
                Point = point

            };
            studentService.UpdateStudent(id, student);

        }
        public Student GetStudent()
        {
            if(studentService.GetAllStudents(null) == null)
            {
                Console.WriteLine("Sinifde sagird yoxdur!");
            }
            int id;
            do
            {
                Console.WriteLine("Enter the get id of student: ");

            } while (!int.TryParse(Console.ReadLine(), out id));
            Student student=studentService.GetStudent(x=>x.Id == id);
            return student;
        }
        public void  GetAllStudents()
        {
            if (studentService.GetAllStudents(null) == null) {
                Console.WriteLine("Sinifde sagird yoxdur!");
            }
            else

            {
                Console.WriteLine("Sagirdler: ");
                foreach (var student in studentService.GetAllStudents(null))
                {
                    Console.WriteLine(student);
                }
            }
           
        }
        
    }
}
