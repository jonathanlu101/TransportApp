using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TransportApp.Dto;
using TransportApp.PTVApi.Model;

namespace TransportApp.App_Start
{
    public static class AutoMapperConfiguration 
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<V3Departure, DepartureDto>();
            });
        }
    }
}