using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TransportApp.Dto
{
    public class PatternDepartureDto
    {
        
        public DateTime? ScheduledDepartureUtc { get; set; }
        public PatternStopDto Stop { get; set; }
    }
}