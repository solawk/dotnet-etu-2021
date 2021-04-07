using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackingStation.WebClient.Models;
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

        public async Task<IActionResult> BodyDetails(string bodyName)
        {
            return View(await BodyClientServant.GetSpecificBody(bodyName));
        }

        [HttpGet]
        public async Task<IActionResult> BodyNew()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BodyNew(string name, double radius, double sma, double v1, double v2, int type, int color)
        {
            return View("BodyDetails",
                await BodyClientServant.AddBody(new InputBody { BodyName = name, Radius = radius, SMA = sma, V1 = v1, V2 = v2, Type = type, Color = color }));
        }

        [HttpGet]
        public async Task<IActionResult> BodyEdit(string bodyName)
        {
            return View(await BodyClientServant.GetSpecificBody(bodyName));
        }

        [HttpPost]
        public async Task<IActionResult> BodyEdit(string bodyName, double radius, double sma, double v1, double v2, int type, int color)
        {
            return View("BodyDetails",
                await BodyClientServant.EditBody(new InputBody { BodyName = bodyName, Radius = radius, SMA = sma, V1 = v1, V2 = v2, Type = type, Color = color }));
        }

        [HttpGet]
        public async Task<IActionResult> BodyDelete(string bodyName)
        {
            return View(await BodyClientServant.GetSpecificBody(bodyName));
        }

        [ActionName("BodyDelete")]
        [HttpPost]
        public async Task<IActionResult> BodyDelete_Confirmed(string bodyName)
        {
            await BodyClientServant.DeleteBody(bodyName);
            return View("Bodies", await BodyClientServant.GetAllBodies());
        }
    }
}
