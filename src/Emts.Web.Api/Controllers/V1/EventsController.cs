using Emts.Web.Api.MaintenanceProcessing;
using Emts.Web.Api.Models;
using Emts.Web.Common;
using Emts.Web.Common.Routing;
using System.Net.Http;
using System.Web.Http;

namespace Emts.Web.Api.Controllers.V1 {
    [ApiVersion1RoutePrefix("events")]
    [UnitOfWorkActionFilter]
    public class EventsController : ApiController {
        private readonly IAddEventMaintenanceProcessor _addEventMaintenanceProcessor;


        public EventsController() { }
        public EventsController(IAddEventMaintenanceProcessor addEventMaintenanceProcessor) {
            _addEventMaintenanceProcessor = addEventMaintenanceProcessor;
        }

        [Route("", Name = "AddEventRoute")]
        [HttpPost]
        public Event AddEvent(HttpRequestMessage requestMessage, NewEvent newEvent) {
            var task = _addEventMaintenanceProcessor.AddEvent(newEvent);

            return task;
        }

        [HttpGet]
        public string Get() {
            return "test";
        }
    }
}
