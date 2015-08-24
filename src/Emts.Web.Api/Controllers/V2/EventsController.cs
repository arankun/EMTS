using Emts.Web.Api.Models;
using System.Net.Http;
using System.Web.Http;

namespace App.Web.Api.Controllers.V2 {
    [RoutePrefix("api/{apiVersion:apiVersionConstraint(v2)}/events")]
    public class EventsController : ApiController
    {
        [Route("", Name = "AddEventRouteV2")]
        [HttpPost]
        public Event AddTask(HttpRequestMessage requestMessage, Event newTask)
        {
            return new Event
            {
                Title = "In v2, newTask.Subject = " + newTask.Title
            };
        }
    }
}
