using System.Collections.Generic;
using ClassRegistry.Domains;

namespace ClassRegistry.Services
{
    public interface ICourseService
    {
        // List<Course> Get();
        List<Course> GetCourseList();
        List<Student> GetStudentsByCourse(int id);


    }
}