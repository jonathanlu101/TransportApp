using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TransportApp.Models
{
    public class FavouriteStopRouteDirection
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int StopId { get; set; }
        [Required]
        public string StopName { get; set; }
        [Required]
        public int RouteId { get; set; }
        [Required]
        public string RouteName { get; set; }
        [Required]
        public int DirectionId { get; set; }
        [Required]
        public string DirectionName { get; set; }

        public ApplicationUser User { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
    }
}