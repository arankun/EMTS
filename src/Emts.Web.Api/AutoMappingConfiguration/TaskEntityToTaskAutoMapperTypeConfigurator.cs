using AutoMapper;
using Emts.Common.TypeMapping;
using Emts.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emts.Web.Api.AutoMappingConfiguration {
    public class EventEntityToEventAutoMapperTypeConfigurator : IAutoMapperTypeConfigurator {
        public void Configure() {
            Mapper.CreateMap<Event, Models.Event>()
                .ForMember(opt => opt.Links, x => x.Ignore())
                .ForMember(opt => opt.Attendees, x => x.ResolveUsing<EventAssigneesResolver>());
        }
    }
}