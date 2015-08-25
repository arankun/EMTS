using AutoMapper;
using Emts.Common.TypeMapping;
using Emts.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emts.Web.Api.AutoMappingConfiguration {
    public class UserEntityToUserAutoMapperTypeConfigurator : IAutoMapperTypeConfigurator {
        public void Configure() {
            Mapper.CreateMap<User, Models.User>()
                .ForMember(opt => opt.Links, x => x.Ignore());
        }
    }
}