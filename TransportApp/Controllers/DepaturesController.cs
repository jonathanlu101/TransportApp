using AutoMapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TransportApp.Dto;
using TransportApp.PTVApi.Api;
using TransportApp.PTVApi.Client;
using TransportApp.PTVApi.Model;

namespace TransportApp.Controllers
{
    [RoutePrefix("api/departures")]
    public class DeparturesController : ApiController
    {
        private string _devId;
        private string _apiKey;

        public DeparturesController()
        {
            _devId = ConfigurationManager.AppSettings["devId"];
            _apiKey = ConfigurationManager.AppSettings["apiKey"];
        }

        [Route("route_type/{routeType}/stop/{stopId}")]
        public IHttpActionResult GetDepaturesFromStop(int routeType, int stopId)
        {
            var departuresApi = new DeparturesApi(new PTVApi.Client.Configuration(new ApiClient("http://timetableapi.ptv.vic.gov.au", _devId, _apiKey)));
            var depaturesResponse = departuresApi.DeparturesGetForStop(routeType, stopId, maxResults: 5);

            List<DepartureDto> departuresResponse = new List<DepartureDto>();
            var routesApi = new RoutesApi(new PTVApi.Client.Configuration(new ApiClient("http://timetableapi.ptv.vic.gov.au", _devId, _apiKey)));
            var directionsApi = new DirectionsApi(new PTVApi.Client.Configuration(new ApiClient("http://timetableapi.ptv.vic.gov.au", _devId, _apiKey)));
            Dictionary<int, V3Route> routesDetail = new Dictionary<int, V3Route>();
            Dictionary<int, string> directionsName = new Dictionary<int, string>();

            foreach (V3Departure departure in depaturesResponse.Departures)
            {
                var detailedDeparture = Mapper.Map<V3Departure, DepartureDto>(departure);
                //Add Route Details to departure
                var routeId = departure.RouteId.Value;
                V3Route routeDetail;
                if (!routesDetail.Keys.Contains(routeId))
                {
                    routeDetail = routesApi.RoutesRouteFromId(routeId).Route;
                    routesDetail.Add(routeId, routeDetail);
                }
                else
                {
                    routeDetail = routesDetail[routeId];
                }
                detailedDeparture.RouteName = routeDetail.RouteName;
                detailedDeparture.RouteNumber = routeDetail.RouteNumber;

                //Add Directions Details to departure
                var directionId = departure.DirectionId.Value;
                String directionName;
                if (!directionsName.Keys.Contains(directionId))
                {
                    var directionResponse = directionsApi.DirectionsForRoute(routeId);
                    directionName = directionResponse.Directions.Find(d => d.DirectionId == directionId).DirectionName;
                    directionsName.Add(directionId, directionName);
                }
                else
                {
                    directionName = directionsName[directionId];
                }
                detailedDeparture.DirectionName = directionName;
                
                departuresResponse.Add(detailedDeparture);
            }

            return Ok(departuresResponse);
        }
    }
}
