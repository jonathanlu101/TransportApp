using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TransportApp.Dto
{
    public class StopCollectionDto
    {
        public int RouteType { get; set; }
        public List<StopDto> Stops { get; set; }
    }
}