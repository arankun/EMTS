using System.Collections.Generic;

namespace Emts.Web.Api.Areas.RouteDebugger.Models
{
    public class RouteDataInfo
    {
        public string RouteTemplate { get; set; }

        public KeyValuePair<string, string>[] Data { get; set; }
    }
}
