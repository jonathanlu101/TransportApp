using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TransportApp.Dto;
using TransportApp.Models;
using TransportApp.PTVApi.Model;

namespace TransportApp.App_Start
{
    public static class AutoMapperConfiguration 
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<V3Departure, StopDepartureDto>();
                cfg.CreateMap<V3Departure, RouteDepartureDto>();
                cfg.CreateMap<V3StopGeosearch, StopDto>();
                cfg.CreateMap<FavouriteStopRouteDirectionDto, FavouriteStopRouteDirection>();
                cfg.CreateMap<FavouriteStopRouteDirection, FavouriteStopRouteDirectionDto>();
                cfg.CreateMap<V3StopDetails, PatternStopDto>();
            });
        }
    }
}