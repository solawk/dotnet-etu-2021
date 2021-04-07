using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackingStation.WebClient.Models;
using TrackingStation.WebClient.Services;
using TrackingStation.WebClient.Views;

namespace TrackingStation.WebClient.Controllers
{
    public class VesselServantController : Controller
    {
        private IVesselClientServant VesselClientServant { get; }
        private IBodyClientServant BodyClientServant { get; }

        public VesselServantController(IVesselClientServant vesselClientServant, IBodyClientServant bodyClientServant)
        {
            VesselClientServant = vesselClientServant;
            BodyClientServant = bodyClientServant;
        }

        public async Task<IActionResult> Vessels()
        {
            return View(await VesselClientServant.GetAllVessels());
        }

        public async Task<IActionResult> VesselDetails(string vesselName)
        {
            return View(await VesselClientServant.GetSpecificVessel(vesselName));
        }

        [HttpGet]
        public async Task<IActionResult> VesselNew()
        {
            return View(await BodyClientServant.GetAllBodies());
        }

        [HttpPost]
        public async Task<IActionResult> VesselNew(string name, string affiliation, string bodyName, double dv, int flightState)
        {
            return View("VesselDetails",
                await VesselClientServant.AddVessel(new InputVessel { Name = name, Affiliation = affiliation, BodyName = bodyName, DV = dv, FlightState = flightState }));
        }

        [HttpGet]
        public async Task<IActionResult> VesselEdit(string vesselName)
        {
            var PageModel = new VesselEditModel(await VesselClientServant.GetSpecificVessel(vesselName), await BodyClientServant.GetAllBodies());
            return View(PageModel);
        }

        [HttpPost]
        public async Task<IActionResult> VesselEdit(string vesselName, string affiliation, string bodyName, double dv, int flightState)
        {
            return View("VesselDetails",
                await VesselClientServant.EditVessel(new InputVessel { Name = vesselName, Affiliation = affiliation, BodyName = bodyName, DV = dv, FlightState = flightState }));
        }

        [HttpGet]
        public async Task<IActionResult> VesselDelete(string vesselName)
        {
            return View(await VesselClientServant.GetSpecificVessel(vesselName));
        }

        [ActionName("VesselDelete")]
        [HttpPost]
        public async Task<IActionResult> VesselDelete_Confirmed(string vesselName)
        {
            await VesselClientServant.DeleteVessel(vesselName);
            return View("Vessels", await VesselClientServant.GetAllVessels());
        }
    }
}
