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

        //[Route("nearby")]
        //public IHttpActionResult GetNearbyStops(float latitude, float longitude, string route_types = null, int? max_distance = null, int? max_results = null)
        //{
        //    List<int?> route_types_list = route_types.Split(',').Select(x => (int?) int.Parse(x)).ToList();
        //    var stopApi = new StopsApi(new PTVApi.Client.Configuration(new ApiClient("http://timetableapi.ptv.vic.gov.au", _devId, _apiKey)));
        //    var response = stopApi.StopsStopsByGeolocation(latitude, longitude, maxDistance: max_distance, maxResults: max_results, routeTypes: route_types_list);
        //    return Ok(response.Stops);
        //}

        [Route("nearby")]
        public IHttpActionResult GetNearbyStops(float latitude, float longitude)
        {
            var response = new NearbyStopsDto();

            var stopApi = new StopsApi(new PTVApi.Client.Configuration(new ApiClient("http://timetableapi.ptv.vic.gov.au", _devId, _apiKey)));

            response.TrainStops = stopApi.StopsStopsByGeolocation(latitude,
                longitude,
                maxDistance: 10000,
                maxResults: 5,
                routeTypes: new List<int?> { 0 }).Stops;
            response.TramStops = stopApi.StopsStopsByGeolocation(latitude,
                longitude,
                maxDistance: 10000,
                maxResults: 5,
                routeTypes: new List<int?> { 1 }).Stops;
            response.BusStops = stopApi.StopsStopsByGeolocation(latitude,
                longitude,
                maxDistance: 10000,
                maxResults: 5,
                routeTypes: new List<int?> { 2 }).Stops;

            return Ok(response);
        }
    }
}
