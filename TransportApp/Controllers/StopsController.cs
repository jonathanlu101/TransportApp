using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
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
            var stopApi = new StopsApi(new PTVApi.Client.Configuration(new ApiClient("http://timetableapi.ptv.vic.gov.au", _devId, _apiKey)));
            var response = stopApi.StopsStopsByGeolocation(latitude, longitude);
            return Ok(response.Stops);
        }
    }
}
