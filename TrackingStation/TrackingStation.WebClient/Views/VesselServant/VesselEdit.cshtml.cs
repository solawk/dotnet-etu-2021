using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TrackingStation.WebClient.Models;

namespace TrackingStation.WebClient.Views
{
    public class VesselEditModel : PageModel
    {
        public VesselModel Vessel { get; }

        public IEnumerable<BodyModel> Bodies { get; }

        public VesselEditModel(VesselModel vessel, IEnumerable<BodyModel> bodies)
        {
            Vessel = vessel;
            Bodies = bodies;
        }
    }
}
