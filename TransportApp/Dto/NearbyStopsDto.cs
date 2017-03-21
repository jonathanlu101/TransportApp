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
        public List<V3StopGeosearch> TrainStops { get; set; }
        public List<V3StopGeosearch> BusStops { get; set; }
        public List<V3StopGeosearch> TramStops { get; set; }
    }
}