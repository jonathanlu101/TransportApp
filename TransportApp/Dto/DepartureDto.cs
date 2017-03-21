using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TransportApp.Dto
{
    public class DepartureDto
    {
        //Mapped properties
        public int? RouteId { get; set; }
        public int? RunId { get; set; }
        public int? DirectionId { get; set; }
        public List<int?> DisruptionIds { get; set; }
        public DateTime? ScheduledDepartureUtc { get; set; }

        //Added properties
        public string RouteName { get; set; }
        public string RouteNumber { get; set; }
        public string DirectionName { get; set; }
    }
}