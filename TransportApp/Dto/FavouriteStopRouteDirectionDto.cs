using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TransportApp.Dto
{
    public class FavouriteStopRouteDirectionDto
    {
        public int Id { get; set; }

        public int StopId { get; set; }
        public string StopName { get; set; }
        public int RouteId { get; set; }
        public string RouteName { get; set; }
        public int DirectionId { get; set; }
        public string DirectionName { get; set; }
    }
}