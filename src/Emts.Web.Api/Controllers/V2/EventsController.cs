using App.Web.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace App.Web.Api.Controllers.V2
{
    [RoutePrefix("api/{apiVersion:apiVersionConstraint(v2)}/events")]
    public class EventsController : ApiController
    {
        [Route("", Name = "AddEventRouteV2")]
        [HttpPost]
        public Event AddTask(HttpRequestMessage requestMessage, Models.Event newTask)
        {
            return new Event
            {
                Title = "In v2, newTask.Subject = " + newTask.Title
            };
        }
    }
}
