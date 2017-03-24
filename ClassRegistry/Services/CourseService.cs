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
        public List<Course> Get()
        {
            List<Course> list = null;

            string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "dbo.Fruits_SelectAll";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {

                            while (reader.Read())
                            {
                                if (list == null)
                                {
                                    list = new List<Course>();
                                }

                                Course c = new Course();
                                int startingIndex = 0;

                                c.Id = reader.GetInt32(startingIndex++);
                                c.Name = reader.GetString(startingIndex++);
                                c.Description = reader.GetString(startingIndex++);

                                list.Add(c);
                            }
                        }
                    }
                }
            }

            return list;
        }


    }
}