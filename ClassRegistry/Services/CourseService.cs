using ClassRegistry.Domains;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ClassRegistry.Services
{
    public class CourseService : ICourseService
    {
        //public List<Course> Get()
        //{
        //    List<Course> list = null;

        //    string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        //    using (SqlConnection conn = new SqlConnection(connStr))
        //    {
        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.CommandText = "Courses_SelectAll";
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Connection = conn;
        //            conn.Open();

        //            using (SqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                if (reader.HasRows)
        //                {

        //                    while (reader.Read())
        //                    {
        //                        if (list == null)
        //                        {
        //                            list = new List<Course>();
        //                        }

        //                        Course c = new Course();
        //                        int startingIndex = 0;

        //                        c.Id = reader.GetInt64(startingIndex++);
        //                        c.Name = reader.GetString(startingIndex++);
        //                        c.Description = reader.GetString(startingIndex++);

        //                        list.Add(c);
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    return list;
        //}

        public List<Course> GetCourseList()
        {
            List<Course> courseList = new List<Course>();

            QuikStorEntities qse = new QuikStorEntities();

            var c = qse.Courses.ToList();

            foreach (var item in c)
            {
                Course course = new Course();

                course.Id = item.id;
                course.Name = item.name;
                course.Description = item.description;

                courseList.Add(course);
            }
             
            return courseList;
        }

        public List<Student> GetStudentsByCourse(int id)
        {
            List<Student> studentList = new List<Student>();

            QuikStorEntities qse = new QuikStorEntities();

            var s = qse.StudentCourses.Where(i => i.course_id == id)
                .Select(x => x.Student)
                .Distinct();

            foreach (var item in s)
            {
                Student pupil = new Student();

                pupil.first_name = item.first_name;
                pupil.last_name = item.last_name;

                studentList.Add(pupil);
            }

            return studentList;
        }
    }
}