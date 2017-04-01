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
    [RoutePrefix("api/patterns")]
    [Authorize]
    public class PatternsController : ApiController
    {
        private string _devId;
        private string _apiKey;

        public PatternsController()
        {
            _devId = ConfigurationManager.AppSettings["devId"];
            _apiKey = ConfigurationManager.AppSettings["apiKey"];
        }

        [Route("run/{runId}/route_type/{routeType}")]
        public IHttpActionResult GetPattern(int runId, int routeType)
        {
            var patternsApi = new PatternsApi(new PTVApi.Client.Configuration(new ApiClient("http://timetableapi.ptv.vic.gov.au", _devId, _apiKey)));
            var patternResponse = patternsApi.PatternsGetPatternByRun(runId, routeType);

            
            var patternDepartureDtos = new List<PatternDepartureDto>();
            var stopsApi = new StopsApi(new PTVApi.Client.Configuration(new ApiClient("http://timetableapi.ptv.vic.gov.au", _devId, _apiKey)));
            foreach (V3Departure departure in patternResponse.Departures)
            {
                var stopResponse = stopsApi.StopsStopDetails(departure.StopId, routeType);
                var patternStopDto = Mapper.Map<V3StopDetails, PatternStopDto>(stopResponse.Stop);
                var patternDepartureDto = new PatternDepartureDto() { Stop = patternStopDto, ScheduledDepartureUtc = departure.ScheduledDepartureUtc };
                patternDepartureDtos.Add(patternDepartureDto);
            }

            return Ok(patternDepartureDtos);
        }
    }
}
