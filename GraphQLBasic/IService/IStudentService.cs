using System.Collections.Generic;
using GraphQLBasic.Models;

namespace GraphQLBasic.IService
{
    public interface IStudentService
    {
        List<Student> GetStudents();
    }
}
