using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using TransportApp.PTVApi.Model;

namespace TransportApp.Dto
{
    public class NearbyStopsDto
    {
        public List<StopDto> TrainStops { get; set; }
        public List<StopDto> BusStops { get; set; }
        public List<StopDto> TramStops { get; set; }
    }
}