using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackingStation.WebClient.Services;

namespace TrackingStation.WebClient.Controllers
{
    public class BodyServantController : Controller
    {
        private IBodyClientServant BodyClientServant { get; }

        public BodyServantController(IBodyClientServant bodyClientServant)
        {
            BodyClientServant = bodyClientServant;
        }

        public async Task<IActionResult> Bodies()
        {
            return View(await BodyClientServant.GetAllBodies());
        }
    }
}
