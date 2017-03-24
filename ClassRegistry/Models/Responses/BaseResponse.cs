using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassRegistry.Models.Responses
{
    public abstract class BaseResponse
    {
        public bool IsSuccessful { get; set; }

    }
}