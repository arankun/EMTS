using Emts.Web.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emts.Web.Api.MaintenanceProcessing {
    public interface IAddEventMaintenanceProcessor {
        Event AddEvent(NewEvent newTask);
    }
}