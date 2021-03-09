using GraphQLBasic.IService;
using System.Collections.Generic;

namespace GraphQLBasic.Models
{
    public class Query
    {
        private IStudentService _studentService = null;

        public Query(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public List<Student> Students => _studentService.GetStudents();
    }
}
