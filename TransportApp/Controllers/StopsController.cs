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
    //[Authorize]
    [RoutePrefix("api/stops")]
    public class StopsController : ApiController
    {
        private string _devId;
        private string _apiKey;

        public StopsController()
        {
            _devId = ConfigurationManager.AppSettings["devId"];
            _apiKey = ConfigurationManager.AppSettings["apiKey"];
        }

        [Route("nearby")]
        public IHttpActionResult GetNearbyStops(float latitude, float longitude)
        {
            var response = new List<StopsCollectionDto>();
            var stopApi = new StopsApi(new PTVApi.Client.Configuration(new ApiClient("http://timetableapi.ptv.vic.gov.au", _devId, _apiKey)));

            var trainStopsResponse = stopApi.StopsStopsByGeolocation(latitude,
                longitude,
                maxDistance: 10000,
                maxResults: 5,
                routeTypes: new List<int?> { 0 }).Stops;
            var trainStopsCollectionDto = new StopsCollectionDto()
            {
                RouteType = 0,
                Stops = Mapper.Map<List<V3StopGeosearch>, List<StopDto>>(trainStopsResponse)
            };
            response.Add(trainStopsCollectionDto);

            var tramStopsResponse = stopApi.StopsStopsByGeolocation(latitude,
                longitude,
                maxDistance: 10000,
                maxResults: 5,
                routeTypes: new List<int?> { 1 }).Stops;
            var tramsStopsCollectionDto = new StopsCollectionDto()
            {
                RouteType = 1,
                Stops = Mapper.Map<List<V3StopGeosearch>, List<StopDto>>(tramStopsResponse)
            };
            response.Add(tramsStopsCollectionDto);

            var busStopsResponse= stopApi.StopsStopsByGeolocation(latitude,
                longitude,
                maxDistance: 10000,
                maxResults: 5,
                routeTypes: new List<int?> { 2 }).Stops;
            var busStopsCollectionDto = new StopsCollectionDto()
            {
                RouteType = 2,
                Stops = Mapper.Map<List<V3StopGeosearch>, List<StopDto>>(busStopsResponse)
            };
            response.Add(busStopsCollectionDto);

            return Ok(response);
        }
    }
}
