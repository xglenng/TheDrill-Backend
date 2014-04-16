using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nancy;

namespace InternalService
{
    public class HealthModule : NancyModule
    {
        public HealthModule()
        {
            Get["/health"] = x =>
                {
                    return new Response { StatusCode = HttpStatusCode.NoContent };
                };
        }
    }
}
