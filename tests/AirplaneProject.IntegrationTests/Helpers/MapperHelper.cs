using AirplaneProject.Application.AutoMapper;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneProject.IntegrationTests.Helpers
{
    class MapperHelper
    {
        public static IMapper ConfigMapper() {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DtoToDomainMappingProfile());
                cfg.AddProfile(new DomainToDtoMappingProfile());
            }).CreateMapper();
        }

    }
}
