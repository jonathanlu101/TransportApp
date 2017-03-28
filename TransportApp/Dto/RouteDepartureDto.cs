using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TransportApp.Dto
{
    public class RouteDepartureDto
    {
        //Mapped properties
        public int? RouteId { get; set; }
        public int? RunId { get; set; }
        public int? DirectionId { get; set; }
        public List<int?> DisruptionIds { get; set; }
        public DateTime? ScheduledDepartureUtc { get; set; }
    }
}