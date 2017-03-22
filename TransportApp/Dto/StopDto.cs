using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TransportApp.Dto
{
    public class StopDto
    {
        public float? StopDistance { get; set; }
        public string StopName { get; set; }
        public int? StopId { get; set; }
        public int? RouteType { get; set; }
        public float? StopLatitude { get; set; }
        public float? StopLongitude { get; set; }
    }
}