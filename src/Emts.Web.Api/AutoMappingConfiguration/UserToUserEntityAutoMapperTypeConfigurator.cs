using AutoMapper;
using Emts.Common.TypeMapping;
using Emts.Web.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emts.Web.Api.AutoMappingConfiguration {
    public class UserToUserEntityAutoMapperTypeConfigurator : IAutoMapperTypeConfigurator {
        public void Configure() {
            Mapper.CreateMap<User, Data.Entities.User>()
                .ForMember(opt => opt.Version, x => x.Ignore());
        }
    }
}