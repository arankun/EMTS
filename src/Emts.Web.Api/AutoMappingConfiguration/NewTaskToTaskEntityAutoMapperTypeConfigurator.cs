using AutoMapper;
using Emts.Common.TypeMapping;
using Emts.Web.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emts.Web.Api.AutoMappingConfiguration {
    public class NewEventToEventEntityAutoMapperTypeConfigurator : IAutoMapperTypeConfigurator {
        public void Configure() {
            Mapper.CreateMap<NewEvent, Data.Entities.Event>()
                .ForMember(opt => opt.Version, x => x.Ignore())
                .ForMember(opt => opt.CreatedBy, x => x.Ignore())
                .ForMember(opt => opt.EventId, x => x.Ignore())
                .ForMember(opt => opt.CreatedDate, x => x.Ignore())
                .ForMember(opt => opt.StartDate, x => x.Ignore())
                .ForMember(opt => opt.Category, x => x.Ignore())
                .ForMember(opt => opt.Attendees, x => x.Ignore())
                .ForMember(opt => opt.Description, x => x.Ignore())
                .ForMember(opt => opt.EndDate, x => x.Ignore())
                .ForMember(opt => opt.State, x => x.Ignore())
                .ForMember(opt => opt.ZipCode, x => x.Ignore())
                .ForMember(opt => opt.Country, x => x.Ignore())
                .ForMember(opt => opt.Address1, x => x.Ignore())
                .ForMember(opt => opt.Title, x => x.Ignore());
        }
    }
}