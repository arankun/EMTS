using App.Web.Api.Models;
using App.Web.Common.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace App.Web.Api.Controllers.V1
{
    [ApiVersion1RoutePrefix("events")]
    public class EventsController : ApiController
    {
        [Route("", Name = "AddEventRoute")]
        [HttpPost]
        public Event AddTask(HttpRequestMessage requestMessage, Event newEvent)
        {
            return new Event
            {
                Title = "In v1, newEvent.Title = " + newEvent.Title
            };
        }
    }
}
