using System.Collections.Generic;
using ClassRegistry.Domains;

namespace ClassRegistry.Services
{
    public interface ICourseService
    {
        List<Course> Get();
    }
}