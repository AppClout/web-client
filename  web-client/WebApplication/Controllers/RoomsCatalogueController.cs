using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Infrastructure.Entities;

namespace WebApplication.Controllers
{
    public class RoomsCatalogueController : Controller
    {
        //
        // GET: /RoomsCatalogue/

        public ActionResult Index()
        {
            Room model = new Room() 
            {
                Type = "SuperLux", Price = 1000, NumberOfBeds = 10, NumberOfRooms=100500, Roominess=16, RoomNumber="403",ID=5

            };

            return View("Entity", model);
        }

    }
}
