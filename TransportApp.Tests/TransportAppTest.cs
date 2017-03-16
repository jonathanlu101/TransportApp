using NUnit.Framework;
using TransportApp.PTVApi.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportApp.PTVApi.Client;
using System.Configuration;
using System.Diagnostics;

namespace TransportApp.Tests
{
    [TestFixture]
    public class TransportAppTest
    {
        [Test]
        public void NearbyStops()
        {
            var devId = ConfigurationManager.AppSettings["devId"];
            var apiKey = ConfigurationManager.AppSettings["apiKey"];
            var stopApi = new StopsApi(new PTVApi.Client.Configuration(new ApiClient("http://timetableapi.ptv.vic.gov.au", devId, apiKey)));
            var response = stopApi.StopsStopsByGeolocation(-37.8232845f, 145.2247167f);

            Console.WriteLine(response.Stops[0].StopName);

            Assert.Pass("Your first passing test");
        }
    }
}
