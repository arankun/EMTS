using Emts.Web.Api.Models;
using Emts.Web.Common.Routing;
using System.Net.Http;
using System.Web.Http;

namespace Emts.Web.Api.Controllers.V1 {
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
