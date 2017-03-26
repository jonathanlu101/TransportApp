using AutoMapper;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;
using TransportApp.Dto;
using TransportApp.Models;

namespace TransportApp.Controllers
{
    [Authorize]
    [RoutePrefix("api/favourites")]
    public class FavouriteController : ApiController
    {
        private ApplicationDbContext _context;

        public FavouriteController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Route("routes")]
        [HttpGet]
        public IHttpActionResult GetFavouriteStopRouteDirections()
        {
            var userId = User.Identity.GetUserId();

            var favourites = (from favourite in _context.FavouriteStopRouteDirection
                              where favourite.UserId == userId
                              select favourite).ToList();

            var favouriteDtos = favourites.Select(x => Mapper.Map<FavouriteStopRouteDirection, FavouriteStopRouteDirectionDto>(x));

            return Ok(favouriteDtos);
        }

        [Route("routes")]
        [HttpPost]
        public IHttpActionResult CreateFavouriteStopRouteDirections(FavouriteStopRouteDirectionDto newFavouriteDto)
        {
            var newFavourite = Mapper.Map<FavouriteStopRouteDirectionDto, FavouriteStopRouteDirection>(newFavouriteDto);
            newFavourite.UserId = User.Identity.GetUserId();

            _context.FavouriteStopRouteDirection.Add(newFavourite);
            _context.SaveChanges();

            return Ok();
        }
    }
}
