using System.Collections.Generic;
using GraphQLBasic.IService;
using GraphQLBasic.Models;

namespace GraphQLBasic.Services
{
    public class StudentService : IStudentService
    {
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            for (int i = 1; i <= 9; i++)
            {
                students.Add(new Student()
                {
                    StudentId = i,
                    Name = "Stu" + i,
                    Roll = "100" + i
                });
            }

            return students;
        }
    }
}
