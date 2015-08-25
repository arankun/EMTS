using Emts.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emts.Data.QueryProcessors {
    public interface IAddEventQueryProcessor {
        void AddEvent(Event task);
    }
}
