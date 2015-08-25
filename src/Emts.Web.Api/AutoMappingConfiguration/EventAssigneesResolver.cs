using AutoMapper;
using Emts.Common.TypeMapping;
using Emts.Data.Entities;
using Emts.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emts.Web.Api.AutoMappingConfiguration {
    public class EventAssigneesResolver : ValueResolver<Event, List<User>> {

        public IAutoMapper AutoMapper {
            get { return WebContainerManager.Get<IAutoMapper>(); }
        }

        protected override List<User> ResolveCore(Event source) {
            return source.Attendees.Select(x => AutoMapper.Map<User>(x)).ToList();
        }
    }
}