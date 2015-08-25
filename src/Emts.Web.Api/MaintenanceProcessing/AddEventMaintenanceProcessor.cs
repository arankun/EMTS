using Emts.Common.TypeMapping;
using Emts.Data.QueryProcessors;
using Emts.Web.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emts.Web.Api.MaintenanceProcessing {
    public class AddEventMaintenanceProcessor : IAddEventMaintenanceProcessor {
        private readonly IAutoMapper _autoMapper;
        private readonly IAddEventQueryProcessor _queryProcessor;

        public AddEventMaintenanceProcessor(IAddEventQueryProcessor queryProcessor,
            IAutoMapper autoMapper) {
            _queryProcessor = queryProcessor;
            _autoMapper = autoMapper;
        }

        public Event AddEvent(NewEvent newEvent) {
            var taskEntity = _autoMapper.Map<Data.Entities.Event>(newEvent);

            _queryProcessor.AddEvent(taskEntity);

            var task = _autoMapper.Map<Event>(taskEntity);

            return task;
        }
    }
}