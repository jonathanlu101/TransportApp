using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TransportApp.Dto
{
    public class PatternStopDto
    {
        public int? StopId { get; set; }
        public string StopName { get; set; }
        public float? StopLatitude { get; set; }
        public float? StopLongitude { get; set; }
    }
}