using ClassRegistry.Domains;
using ClassRegistry.Models.Responses;
using ClassRegistry.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClassRegistry.Controllers.Api
{

    [RoutePrefix("api/courses")]

    public class CourseApiController : BaseApiController
    {
        private ICourseService _courseService;

        public CourseApiController (ICourseService courtService)
        {
            _courseService = courtService;
        }
        
        [Route, HttpGet]
        public HttpResponseMessage Get()
        {
            ItemsResponse<Course> responseData = new ItemsResponse<Course>();
            responseData.Items = _courseService.Get();

            return Request.CreateResponse(HttpStatusCode.OK, responseData);
           
        }

        //[Route("{id:int}/students"), HttpGet]
        //public HttpResponseMessage Get(int id)
        //{
        //    return null;
        //}

    }
}
